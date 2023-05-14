package com.example.funnyapp.di

import com.example.funnyapp.data.api.MainApiClient
import com.example.funnyapp.data.repository.UserProfileRepository
import org.koin.dsl.module

val dataModule = module {
    single {
        UserProfileRepository(context = get(), apiClient = MainApiClient())
    }
}