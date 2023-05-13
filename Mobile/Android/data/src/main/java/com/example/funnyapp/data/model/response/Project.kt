package com.example.funnyapp.data.model.response

data class Project(
    val Id: String,
    val Name: String,
    val Description: String,
    val Teams: List<Team>
)
