package com.example.funnyapp.presentation

import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.isGone
import androidx.core.view.isVisible
import androidx.core.widget.addTextChangedListener
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.data.model.response.Message
import com.example.funnyapp.databinding.ActivityChatBinding
import com.example.funnyapp.presentation.adapter.ChatMessageAdapter
import com.example.funnyapp.presentation.vm.ChatViewModel
import org.koin.androidx.viewmodel.ext.android.viewModel
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale

class ChatActivity : AppCompatActivity() {
    private lateinit var binding: ActivityChatBinding
    private val chatViewModel by viewModel<ChatViewModel>()
    private val chatMessagesAdapter by lazy { ChatMessageAdapter() }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityChatBinding.inflate(layoutInflater)
        initView()
        setContentView(binding.root)
    }

    private fun initView() = with(binding) {
        buttonBack.setOnClickListener { finish() }

        textChatUser.text = intent.getStringExtra("ChatUser")
        imageChatUser.setImageResource(intent.getIntExtra("ChatUserImage", 0))

        listMessages.apply {
            layoutManager = LinearLayoutManager(this@ChatActivity)
            adapter = chatMessagesAdapter
        }

        editTextMessage.addTextChangedListener {
            if (it.toString().isNotEmpty() && buttonSendMessage.isGone)
                buttonSendMessage.visibility = View.VISIBLE

            if (it.toString().isEmpty() && buttonSendMessage.isVisible)
                buttonSendMessage.visibility = View.GONE
        }

        buttonSendMessage.setOnClickListener {
            if (editTextMessage.text.isEmpty()) return@setOnClickListener

            chatViewModel.sendMessage(editTextMessage.text.toString())
        }

        chatViewModel.messagesList.observe(this@ChatActivity) {
            val list = chatMessagesAdapter.currentList
            chatMessagesAdapter.submitList(list.plus(it))
            listMessages.smoothScrollToPosition(chatMessagesAdapter.itemCount - 1)
        }
    }
}