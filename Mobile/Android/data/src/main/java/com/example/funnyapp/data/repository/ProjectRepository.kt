package com.example.funnyapp.data.repository

import android.content.Context
import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.model.request.GetProjectByTeamIdParam
import com.example.funnyapp.data.model.request.GetProjectsByDivisionId

class ProjectRepository(context: Context, apiClient: MainApiClient) : BaseRepository(context, apiClient) {
    fun getAllProjects() = apiRequestFlow {
        apiService.getAllProjects()
    }

    fun getProjectByTeamId(getProjectByTeamIdParam: GetProjectByTeamIdParam) = apiRequestFlow {
        apiService.getProjectById(teamId = getProjectByTeamIdParam.teamId)
    }

    fun getProjectsByDivisionId(getProjectsByDivisionId: GetProjectsByDivisionId) = apiRequestFlow {
        apiService.getProjectsById(divisionId = getProjectsByDivisionId.divisionId)
    }
}