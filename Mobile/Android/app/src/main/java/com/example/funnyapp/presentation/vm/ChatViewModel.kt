package com.example.funnyapp.presentation.vm

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.funnyapp.data.model.response.ChatMessage
import com.example.funnyapp.data.model.response.Message
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Locale

class ChatViewModel : ViewModel() {
    private val messagesListMutable = MutableLiveData<ChatMessage>()
    val messagesList: LiveData<ChatMessage> = messagesListMutable

    fun sendMessage(message: String) {
        val currentTime = SimpleDateFormat(
            "HH:mm", Locale.getDefault()).format(Calendar.getInstance().time
        )
        messagesListMutable.value = Message(owner = 1, text = message, time = currentTime)
    }
}