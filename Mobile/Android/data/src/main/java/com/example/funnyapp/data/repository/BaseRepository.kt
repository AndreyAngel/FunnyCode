package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.R
import com.example.funnyapp.data.api.ApiResult
import com.example.funnyapp.data.api.auth.TokenManager
import com.example.funnyapp.data.model.ServerError
import com.google.gson.Gson
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.flow
import kotlinx.coroutines.flow.flowOn
import kotlinx.coroutines.withTimeoutOrNull
import retrofit2.Call
import retrofit2.HttpException
import timber.log.Timber
import java.io.IOException

abstract class BaseRepository(private val context: Context) {
    val tokenManager = TokenManager(context)

    fun <D> apiRequestFlow(call: suspend () -> Call<D>): Flow<ApiResult<D>> = flow {
        emit(ApiResult.Loading)

        withTimeoutOrNull(20000L) {
            try {
                val response = call().execute()

                if (response.isSuccessful) {
                    response.body()?.let { data ->
                        emit(ApiResult.Success(data))
                    }
                } else {
                    response.errorBody()?.let { error ->
                        error.close()
                        val parsedError: ServerError =
                            Gson().fromJson(error.charStream(), ServerError::class.java)
                        emit(
                            ApiResult.Failure(
                                message = context.resources.getString(R.string.error),
                                error = parsedError.failureMessage + ", HTTP 400"
                            )
                        )
                    }
                }
            } catch (e: HttpException) {
                emit(
                    ApiResult.Failure(
                        message = context.resources.getString(R.string.http_error),
                        error = e.message
                    )
                )
            } catch (e: IOException) {
                emit(
                    ApiResult.Failure(
                        message = context.resources.getString(R.string.network_error),
                        error = e.message
                    )
                )
            } catch (e: Exception) {
                Timber.e(e, e.message)
                emit(
                    ApiResult.Failure(
                        message = context.resources.getString(R.string.error),
                        error = e.message
                    )
                )
            }
        } ?: emit(
            ApiResult.Failure(
                message = context.resources.getString(R.string.timeout_error),
                error = "HTTP 408"
            )
        )
    }.flowOn(Dispatchers.IO)
}