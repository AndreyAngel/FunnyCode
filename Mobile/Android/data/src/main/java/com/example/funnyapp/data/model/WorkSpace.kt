package com.example.funnyapp.data.model

data class WorkSpace(
    val division: ProfileDivision,
    val subdivision: String,
    val teamId: String,
    val jobTitle: JobTitle,
    val role: RoleInProject,
    val workAddress: WorkAddress,
    val remotely: Boolean
)
