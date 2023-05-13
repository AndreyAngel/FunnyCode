package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.GetSubdivisionsByIdParam
import com.example.funnyapp.data.model.request.GetTeamsByIdParam

class CompanyStructureRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getDivisions() = apiRequestFlow {
        apiService.getDivisions()
    }

    fun getSubdivisionsById(getSubdivisionsByIdParam: GetSubdivisionsByIdParam) = apiRequestFlow {
        apiService.getSubdivisionsById(divisionId = getSubdivisionsByIdParam.divisionId)
    }

    fun getTeamsById(getTeamsByIdParam: GetTeamsByIdParam) = apiRequestFlow {
        apiService.getTeamsById(subdivisionId = getTeamsByIdParam.subdivisionId)
    }
}