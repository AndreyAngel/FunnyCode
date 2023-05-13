package com.example.funnyapp.data.model.response

data class Team(
    val Id: String,
    val ProjectId: String,
    val Project: Any,
    val Users: List<UserProfile>
)
