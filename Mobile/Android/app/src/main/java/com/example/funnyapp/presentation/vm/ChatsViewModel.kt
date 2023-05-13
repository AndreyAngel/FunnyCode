package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.funnyapp.R
import com.example.funnyapp.data.model.response.Chat

class ChatsViewModel : ViewModel() {
    private val chatsListMutable = MutableLiveData<List<Chat>>()
    val chatsList: LiveData<List<Chat>> = chatsListMutable

    fun getChats() {
        chatsListMutable.value = listOf(
            Chat("0" ,"Владимир Ибрагимов Александрович", R.drawable.ic_launcher_background),
            Chat("1" ,"Андреева Ольга Александровна", R.drawable.ic_launcher_background)
        )
    }
}