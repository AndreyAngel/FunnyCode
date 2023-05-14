package com.example.funnyapp.data.model.response

import com.example.funnyapp.data.model.BirthDate
import com.example.funnyapp.data.model.Contact
import com.example.funnyapp.data.model.Date
import com.example.funnyapp.data.model.Schedule
import com.example.funnyapp.data.model.Vacation
import com.example.funnyapp.data.model.WorkSpace

data class User(
    val name: String,
    val birthDate: BirthDate,
    val contact: Contact,
    val workSpace: WorkSpace,
    val schedule: Schedule,
    val currentVacation: Vacation,
    val nextVacationStartDate: Date
)
