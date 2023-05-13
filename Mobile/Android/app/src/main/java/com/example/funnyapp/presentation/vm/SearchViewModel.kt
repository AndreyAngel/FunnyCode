package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.funnyapp.R
import com.example.funnyapp.model.Personnel

class SearchViewModel : ViewModel() {
    private val searchTextMutable = MutableLiveData<String>()
    val searchText: LiveData<String> = searchTextMutable

    private val managersListMutable = MutableLiveData<List<Personnel>>()
    val managersList: LiveData<List<Personnel>> = managersListMutable

    private val employeesListMutable = MutableLiveData<List<Personnel>>()
    val employeesList: LiveData<List<Personnel>> = employeesListMutable

    fun searchPersonnel(text: String) {
        managersListMutable.value = listOf(
            Personnel(R.drawable.ic_launcher_background, "Владимир Ибрагимов Александрович", "Должность")
        )
        employeesListMutable.value = listOf(
            Personnel(R.drawable.ic_launcher_background, "Федоров Александр Игоревич", "Должность"),
            Personnel(R.drawable.ic_launcher_background, "Лебедева Екатерина Алексеевна", "Должность"),
            Personnel(R.drawable.ic_launcher_background, "Иванов Сергей Геннадьевич", "Backend разработчик"),
            Personnel(R.drawable.ic_launcher_background, "Андреева Ольга Александровна", "Frontend разработчик")
        )
    }
}