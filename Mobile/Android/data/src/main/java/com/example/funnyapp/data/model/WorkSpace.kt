package com.example.funnyapp.data.model

data class WorkSpace(
    val division: ProfileDivision,
    val subdivision: String,
    val teamId: String,
    val jobTitle: Int,
    val role: Int,
    val workAddress: WorkAddress,
    val remotely: Boolean
)
