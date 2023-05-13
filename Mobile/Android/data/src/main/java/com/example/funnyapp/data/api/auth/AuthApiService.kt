package com.example.funnyapp.data.api.auth

import com.example.funnyapp.data.model.response.AuthInfo
import retrofit2.Call

interface AuthApiService {
    fun refreshToken(): Call<AuthInfo>
}