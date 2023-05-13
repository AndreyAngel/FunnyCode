package com.example.funnyapp.presentation.fragment

import android.content.Intent
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.R
import com.example.funnyapp.data.model.response.Chat
import com.example.funnyapp.databinding.FragmentChatsBinding
import com.example.funnyapp.presentation.ChatActivity
import com.example.funnyapp.presentation.adapter.ChatAdapter
import com.example.funnyapp.presentation.vm.ChatsViewModel
import org.koin.androidx.viewmodel.ext.android.viewModel

class ChatsFragment : Fragment(), ChatAdapter.OnClickListener {
    private lateinit var binding: FragmentChatsBinding
    private val chatsViewModel by viewModel<ChatsViewModel>()
    private val chatsAdapter by lazy { ChatAdapter(this) }

    companion object {
        @JvmStatic
        fun newInstance() = ChatsFragment()
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        chatsViewModel.getChats()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentChatsBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        listChats.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = chatsAdapter
        }

        chatsViewModel.chatsList.observe(viewLifecycleOwner) {
            chatsAdapter.submitList(it)
        }

    }

    override fun onChatClick(item: Chat) {
        val intent = Intent(requireActivity(), ChatActivity::class.java).apply {
            putExtra("ChatUser", item.userName)
            putExtra("ChatUserImage", item.userImage)
        }
        startActivity(intent)
    }
}