package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.GetProfileByFiltersParam
import com.example.funnyapp.data.model.request.GetProfileByIdParam
import com.example.funnyapp.data.model.request.GetProfileByNameParam

class UserProfileRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getProfile(getProfileByIdParam: GetProfileByIdParam) = apiRequestFlow {
        apiService.getProfileById(id = getProfileByIdParam.id)
    }

    fun getProfileByName(getProfileByNameParam: GetProfileByNameParam) = apiRequestFlow {
        apiService.getProfileByName(name = getProfileByNameParam.name)
    }

    fun getProfileByFilters(getProfileByFiltersParam: GetProfileByFiltersParam) = apiRequestFlow {
        apiService.getProfileByFilters(request = getProfileByFiltersParam)
    }
}