package com.example.funnyapp.data.api

import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.PUT
import retrofit2.http.Path

interface MainApiService {
    /**
     * Company Structure Requests
     */
    @GET("api/CompanyStructure/GetDivisions")
    fun getCompanyDivisions()

    @GET("api/CompanyStructure/GetSubdivisions/{divisionId}")
    fun getCompanySubdivisionsById(@Path("divisionId") divisionId: String)

    @GET("api/CompanyStructure/GetTeams/{subdivisionId}")
    fun getCompanyTeamsById(@Path("subdivisionId") subdivisionId: String)

    /**
     * Profile Requests
     */
    @GET("/api/Profile/GetById/{id}")
    fun getProfileById(@Path("id") id: String)

    @PUT("api/Profile/Update/{id}")
    fun changeProfileById(@Path("id") id: String)

    @DELETE("api/Profile/Delete/{id}")
    fun deleteProfileById(@Path("id") id: String)

    /**
     * Project Requests
     */
    @GET("/api/Project/GetAllProjects")
    fun getAllProjects()

    @GET("api/Project/GetProjectByTeamId/{teamId}")
    fun getProjectById(@Path("teamId") teamId: String)

    @GET("api/Project/GetProjectsByDivisionId/{divisionId}")
    fun getProjectsById(@Path("divisionId") divisionId: String)
}