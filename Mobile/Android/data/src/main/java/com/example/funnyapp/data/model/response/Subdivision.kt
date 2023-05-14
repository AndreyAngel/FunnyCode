package com.example.funnyapp.data.model.response

data class Subdivision(
    val name: String,
    val description: String,
    val division: String,
    val teams: List<Teams>,
    val users: List<Users>
)
