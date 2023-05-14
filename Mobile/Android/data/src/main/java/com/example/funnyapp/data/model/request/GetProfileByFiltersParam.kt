package com.example.funnyapp.data.model.request

import com.example.funnyapp.data.model.JobTitle
import com.example.funnyapp.data.model.RoleInProject
import com.example.funnyapp.data.model.WorkAddress

data class GetProfileByFiltersParam(
    val teamName: String,
    val divisionName: String,
    val subdivisionName: String,
    val workAddress: WorkAddress,
    val jobTitle: JobTitle,
    val roleInProject: RoleInProject
)
