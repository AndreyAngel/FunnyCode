package com.example.funnyapp.data.api

import com.example.funnyapp.data.model.response.Division
import com.example.funnyapp.data.model.response.Project
import com.example.funnyapp.data.model.response.Subdivision
import com.example.funnyapp.data.model.response.Team
import com.example.funnyapp.data.model.response.UserProfile
import retrofit2.Call
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.PUT
import retrofit2.http.Path

interface MainApiService {
    /**
     * Company Structure Requests
     */
    @GET("api/CompanyStructure/GetDivisions")
    fun getDivisions(): Call<List<Division>>

    @GET("api/CompanyStructure/GetSubdivisions/{divisionId}")
    fun getSubdivisionsById(@Path("divisionId") divisionId: String): Call<List<Subdivision>>

    @GET("api/CompanyStructure/GetTeams/{subdivisionId}")
    fun getTeamsById(@Path("subdivisionId") subdivisionId: String): Call<List<Team>>

    /**
     * Profile Requests
     */
    @GET("/api/Profile/GetById/{id}")
    fun getProfileById(@Path("id") id: String): Call<UserProfile>

    @PUT("api/Profile/Update/{id}")
    fun changeProfileById(@Path("id") id: String): Call<Unit>

    @DELETE("api/Profile/Delete/{id}")
    fun deleteProfileById(@Path("id") id: String): Call<Unit>

    /**
     * Project Requests
     */
    @GET("/api/Project/GetAllProjects")
    fun getAllProjects(): Call<List<Project>>

    @GET("api/Project/GetProjectByTeamId/{teamId}")
    fun getProjectById(@Path("teamId") teamId: String): Call<Project>

    @GET("api/Project/GetProjectsByDivisionId/{divisionId}")
    fun getProjectsById(@Path("divisionId") divisionId: String): Call<List<Project>>
}