package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.funnyapp.model.ProfileSphere
import com.example.funnyapp.model.ProfileWorkData

class ProfileViewModel : ViewModel() {
    private val contactsMutable = MutableLiveData<List<ProfileWorkData>>()
    val contacts: LiveData<List<ProfileWorkData>> = contactsMutable

    private val workDataMutable = MutableLiveData<List<ProfileWorkData>>()
    val workData: LiveData<List<ProfileWorkData>> = workDataMutable

    fun getContacts() {
        contactsMutable.value = listOf(
            ProfileWorkData("Мобильный телефон", "+7 (983) 231-95-09"),
            ProfileWorkData("Рабочий телефон", "90508882"),
            ProfileWorkData("E-mail", "Sabirovdima1@gmial.com"),
            ProfileWorkData("День рождения", "9 июня 2004")
        )
    }

    fun getWorkData() {
        workDataMutable.value = listOf(
            ProfileWorkData("Дата приема", "1 апреля 2016"),
            ProfileWorkData("Организация", "Samokat.Tech"),
            ProfileWorkData("Подразделение", "Отдел проектирования, разработка интерфейса"),
            ProfileWorkData("Адрес работы", "Россия, Томск, ул. Фрунзе, 8"),
            ProfileWorkData("Рабочее время", "Пн - Пт с 8 до 18")
        )
    }
}