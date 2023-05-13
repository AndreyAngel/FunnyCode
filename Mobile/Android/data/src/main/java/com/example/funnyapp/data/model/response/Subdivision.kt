package com.example.funnyapp.data.model.response

data class Subdivision(
    val Id: String,
    val Name: String,
    val Description: String,
    val DivisionId: String,
    val Division: Division,
    val Teams: List<Team>
)
