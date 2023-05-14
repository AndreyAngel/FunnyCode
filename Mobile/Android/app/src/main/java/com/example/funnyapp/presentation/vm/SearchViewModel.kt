package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.funnyapp.R
import com.example.funnyapp.data.api.ApiResult
import com.example.funnyapp.data.model.JobTitle
import com.example.funnyapp.data.model.request.GetProfileByNameParam
import com.example.funnyapp.data.model.response.User
import com.example.funnyapp.data.model.response.Users
import com.example.funnyapp.data.repository.UserProfileRepository
import com.example.funnyapp.model.Personnel
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext

class SearchViewModel(private val userRepository: UserProfileRepository) : BaseViewModel() {
    private val searchListMutable = MutableLiveData<ApiResult<List<Users>>>()
    val searchList: LiveData<ApiResult<List<Users>>> = searchListMutable

    private val managersListMutable = MutableLiveData<List<Personnel>>()
    val managersList: LiveData<List<Personnel>> = managersListMutable

    private val employeesListMutable = MutableLiveData<List<Personnel>>()
    val employeesList: LiveData<List<Personnel>> = employeesListMutable

    fun searchPersonnel(text: String) = baseRequest(searchListMutable) {
        userRepository.getProfileByName(GetProfileByNameParam(name = text))
    }

    fun getPersonnelFromSearchList(searchList: List<Users>, roles: Array<String>) {
        viewModelScope.launch(Dispatchers.IO) {
            val listLeaders = ArrayList<Personnel>()
            val listEmployees = ArrayList<Personnel>()
            searchList.forEach { user ->
                when (user.jobTitle) {
                    JobTitle.DepartmentLeader.ordinal -> {
                        listLeaders.add(
                            Personnel(R.drawable.ic_man, user.name, roles[user.jobTitle])
                        )
                    }
                    else -> {
                        listEmployees.add(
                            Personnel(R.drawable.ic_man, user.name, roles[user.jobTitle])
                        )
                    }
                }

            }
            withContext(Dispatchers.Main) {
                managersListMutable.value = listLeaders
                employeesListMutable.value = listEmployees
            }
        }
    }
}