package com.example.funnyapp.data.model.response

data class Division(
    val Id: String,
    val Name: String,
    val Description: String,
    val Subdivisions: List<Subdivision>
)
