package com.example.funnyapp.data.model.response

import com.example.funnyapp.data.model.Leader

data class Division(
    val name: String,
    val description: String,
    val subdivisions: List<Subdivisions>,
    val leader: Leader,
    val users: List<Users>
)