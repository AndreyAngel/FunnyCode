package com.example.funnyapp.data.api.auth

import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class AuthApiClient {
    private lateinit var authApiService: AuthApiService
    private val url = "https://cec8-95-191-8-57.ngrok-free.app"

    fun getApiService(tokenManager: TokenManager): AuthApiService {
        if (!::authApiService.isInitialized) {
            val retrofit = Retrofit.Builder()
                .baseUrl(url)
                .addConverterFactory(GsonConverterFactory.create())
                .client(okHttpClient(tokenManager))
                .build()
            authApiService = retrofit.create(AuthApiService::class.java)
        }
        return authApiService
    }

    private fun okHttpClient(tokenManager: TokenManager): OkHttpClient {
        val httpLoggingInterceptor = HttpLoggingInterceptor().apply {
            level = HttpLoggingInterceptor.Level.BODY
        }
        return OkHttpClient.Builder()
            .addInterceptor(httpLoggingInterceptor)
            .addInterceptor(AuthInterceptor(tokenManager))
            .authenticator(AuthAuthenticator(tokenManager))
            .build()
    }
}