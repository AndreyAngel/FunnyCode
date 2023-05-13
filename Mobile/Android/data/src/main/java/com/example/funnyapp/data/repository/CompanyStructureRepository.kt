package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.GetSubdivisionByIdParam
import com.example.funnyapp.data.model.request.GetTeamsByIdParam

class CompanyStructureRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getDivisions() = apiRequestFlow {
        apiService.getDivisions()
    }
}