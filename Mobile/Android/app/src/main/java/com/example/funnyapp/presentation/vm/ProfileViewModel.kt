package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.funnyapp.data.api.ApiResult
import com.example.funnyapp.data.model.request.GetProfileByIdParam
import com.example.funnyapp.data.model.response.User
import com.example.funnyapp.data.repository.UserProfileRepository
import com.example.funnyapp.model.ProfileSphere
import com.example.funnyapp.model.ProfileWorkData

class ProfileViewModel(private val userRepository: UserProfileRepository) : BaseViewModel() {
    private val userProfileMutable = MutableLiveData<ApiResult<User>>()
    val userProfile: LiveData<ApiResult<User>> = userProfileMutable

    fun getUserProfile() = baseRequest(userProfileMutable) {
        userRepository.getProfile(GetProfileByIdParam())
    }
}