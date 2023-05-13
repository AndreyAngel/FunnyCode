package com.example.funnyapp.data.model.response

import com.example.funnyapp.data.model.ProjectSubdivision

data class Project(
    val id: String,
    val name: String,
    val subdivisions: List<ProjectSubdivision>
)
