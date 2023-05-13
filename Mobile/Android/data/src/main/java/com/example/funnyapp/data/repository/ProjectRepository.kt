package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.GetProjectsByTeamIdParam
import com.example.funnyapp.data.model.request.GetProjectsByDivisionId
import com.example.funnyapp.data.model.request.GetProjectsByIdParam
import com.example.funnyapp.data.model.request.GetProjectsBySubdivisionIdParam
import com.example.funnyapp.data.model.request.GetProjectsByUserIdParam

class ProjectRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getAllProjects() = apiRequestFlow {
        apiService.getAllProjects()
    }

    fun getProjectsByUserId(getProjectsByUserIdParam: GetProjectsByUserIdParam) = apiRequestFlow {
        apiService.getProjectsByUserId(userId = getProjectsByUserIdParam.userId)
    }

    fun getProjectsByTeamId(getProjectsByTeamIdParam: GetProjectsByTeamIdParam) = apiRequestFlow {
        apiService.getProjectsByTeamId(teamId = getProjectsByTeamIdParam.teamId)
    }

    fun getProjectsBySubdivisionId(getProjectsBySubdivisionIdParam: GetProjectsBySubdivisionIdParam) = apiRequestFlow {
        apiService.getProjectsBySubdivisionId(subdivisionId = getProjectsBySubdivisionIdParam.subdivisionId)
    }

    fun getProjectsByDivisionId(getProjectsByDivisionId: GetProjectsByDivisionId) = apiRequestFlow {
        apiService.getProjectsByDivisionId(divisionId = getProjectsByDivisionId.divisionId)
    }

    fun getProjectsById(getProjectsByIdParam: GetProjectsByIdParam) = apiRequestFlow {
        apiService.getProjectsById(projectId = getProjectsByIdParam.projectId)
    }
}