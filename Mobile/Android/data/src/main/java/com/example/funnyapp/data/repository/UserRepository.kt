package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient

class UserRepository(apiClient: MainApiClient, context: Context) : BaseRepository(context) {
    private val apiService = apiClient.getApiService()
}