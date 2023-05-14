package com.example.funnyapp.data.model.response

import com.example.funnyapp.data.model.Leader

data class Team(
    val name: String,
    val users: List<Users>,
    val leader: Leader,
    val project: Projects
)
