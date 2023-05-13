package com.example.funnyapp.data.model

import com.example.funnyapp.data.model.response.Teams

data class ProjectSubdivision(
    val id: String,
    val name: String,
    val teams: List<Teams>,
)
