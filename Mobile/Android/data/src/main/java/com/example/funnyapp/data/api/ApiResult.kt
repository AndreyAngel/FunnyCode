package com.example.funnyapp.data.api

sealed class ApiResult<out T> {
    object Loading: ApiResult<Nothing>()

    data class Success<out T>(
        val data: T
    ) : ApiResult<T>()

    data class Failure(
        val message: String,
        val error: String?
    ) : ApiResult<Nothing>()
}
