package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.ApiResult
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.DeleteUserProfileParam
import com.example.funnyapp.data.model.request.GetUserProfileParam
import com.example.funnyapp.data.model.request.UpdateUserProfileParam
import com.example.funnyapp.data.model.response.UserProfile
import kotlinx.coroutines.flow.Flow

class UserProfileRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getProfile(getUserProfileParam: GetUserProfileParam) = apiRequestFlow {
        apiService.getProfileById(id = getUserProfileParam.id)
    }

    fun updateProfile(updateUserProfileParam: UpdateUserProfileParam) = apiRequestFlow {
        apiService.changeProfileById(id = updateUserProfileParam.id)
    }

    fun deleteProfile(deleteUserProfileParam: DeleteUserProfileParam) = apiRequestFlow {
        apiService.deleteProfileById(id = deleteUserProfileParam.id)
    }
}