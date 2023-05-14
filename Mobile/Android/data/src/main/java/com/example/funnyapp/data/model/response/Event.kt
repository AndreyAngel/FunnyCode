package com.example.funnyapp.data.model.response

data class Event(
    val Id: String,
    val Name: String,
    val Description: String,
    val Date: String,
    val Location: String,
    val Subdivisions: List<Subdivisions>,
    val Divisions: List<Divisions>
)
