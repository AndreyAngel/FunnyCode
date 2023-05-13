package com.example.funnyapp.data.model.response

data class UserProfile(
    val Id: String,
    val Name: String,
    val IsAvailable: String,
    val Age: Int,
    val Email: String,
    val PhoneNumber: String,
    val WorkAdress: String,
    val inTeamRole: String,
    val inProjectRole: String,
    val TeamId: String
)
