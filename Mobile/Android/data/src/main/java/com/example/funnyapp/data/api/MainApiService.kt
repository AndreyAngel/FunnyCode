package com.example.funnyapp.data.api

import com.example.funnyapp.data.model.request.GetProfileByFiltersParam
import com.example.funnyapp.data.model.response.Division
import com.example.funnyapp.data.model.response.Divisions
import com.example.funnyapp.data.model.response.Project
import com.example.funnyapp.data.model.response.Projects
import com.example.funnyapp.data.model.response.Subdivision
import com.example.funnyapp.data.model.response.Subdivisions
import com.example.funnyapp.data.model.response.Team
import com.example.funnyapp.data.model.response.Teams
import com.example.funnyapp.data.model.response.UserProfile
import com.example.funnyapp.data.model.response.Users
import retrofit2.Call
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface MainApiService {
    /**
     * Company Structure Requests
     */
    @GET("api/CompanyStructure/GetDivisions")
    fun getDivisions(): Call<List<Divisions>>

    @GET("/api/CompanyStructure/GetDivisionById/{id}")
    fun getDivisionById(@Path("id") divisionId: String): Call<Division>

    @GET("/api/CompanyStructure/GetDivisionByName/{name}")
    fun getDivisionByName(@Path("name") divisionName: String): Call<Division>

    @GET("api/CompanyStructure/GetSubdivisions/{divisionId}")
    fun getSubdivisions(@Path("divisionId") divisionId: String): Call<List<Subdivisions>>

    @GET("/api/CompanyStructure/GetSubdivisionById/{id}")
    fun getSubdivisionById(@Path("id") subdivisionId: String): Call<Subdivision>

    @GET("/api/CompanyStructure/GetSubdivisionByName/{name}")
    fun getSubdivisionByName(@Path("name") subdivisionName: String): Call<Subdivision>

    @GET("api/CompanyStructure/GetTeams/{subdivisionId}")
    fun getTeams(@Path("subdivisionId") subdivisionId: String): Call<List<Teams>>

    @GET("/api/CompanyStructure/GetTeamById/{id}")
    fun getTeamById(@Path("id") teamId: String): Call<Team>

    @GET("/api/CompanyStructure/GetTeamByName/{name}")
    fun getTeamByName(@Path("name") teamName: String): Call<Team>

    /**
     * Profile Requests
     */
    @GET("/api/Profile/GetById/{id}")
    fun getProfileById(@Path("id") id: String): Call<UserProfile>

    @POST("/api/Profile/GetByFilters")
    fun getProfileByFilters(request: GetProfileByFiltersParam): Call<List<Users>>

    @PUT("api/Profile/Update/{id}")
    fun updateProfileById(@Path("id") id: String): Call<Unit>

    /**
     * Project Requests
     */
    @GET("/api/Project/GetAllProjects")
    fun getAllProjects(): Call<List<Projects>>

    @GET("/api/Project/GetProjectsByUserProfileId/{userProfileId}")
    fun getProjectsByUserId(@Path("userProfileId") userId: String): Call<List<Projects>>

    @GET("api/Project/GetProjectByTeamId/{teamId}")
    fun getProjectsByTeamId(@Path("teamId") teamId: String): Call<List<Projects>>

    @GET("/api/Project/GetProjectsBySubdivisionId/{subdivisionId}")
    fun getProjectsBySubdivisionId(@Path("subdivisionId") subdivisionId: String): Call<List<Projects>>

    @GET("/api/Project/GetProjectsByDivisionId/{divisionId}")
    fun getProjectsByDivisionId(@Path("divisionId") divisionId: String): Call<List<Projects>>

    @GET("/api/Project/GetDivisionsByProjectId/{projectId}")
    fun getProjectsById(@Path("projectId") projectId: String): Call<List<Project>>
}