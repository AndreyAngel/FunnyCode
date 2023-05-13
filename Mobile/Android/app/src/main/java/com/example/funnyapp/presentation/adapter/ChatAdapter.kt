package com.example.funnyapp.presentation.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.funnyapp.R
import com.example.funnyapp.data.model.response.Chat
import com.example.funnyapp.databinding.ItemChatBinding

class ChatAdapter(private val listener: OnClickListener) : ListAdapter<Chat, ChatAdapter.Holder>(Comparator()) {
    interface OnClickListener {
        fun onChatClick(item: Chat)
    }

    class Holder(itemView: View, listener: OnClickListener) : RecyclerView.ViewHolder(itemView) {
        private val binding = ItemChatBinding.bind(itemView)
        private lateinit var chatItem: Chat

        init {
            binding.root.setOnClickListener {
                listener.onChatClick(chatItem)
            }
        }

        fun bind(item: Chat) = with(binding) {
            chatItem = item
            imagePerson.setImageResource(item.userImage)
            textPersonName.text = item.userName
        }
    }

    class Comparator : DiffUtil.ItemCallback<Chat>() {
        override fun areItemsTheSame(oldItem: Chat, newItem: Chat): Boolean {
            return oldItem.id == newItem.id
        }

        override fun areContentsTheSame(oldItem: Chat, newItem: Chat): Boolean {
            return oldItem == newItem
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): Holder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_chat, parent, false)
        return Holder(view, listener)
    }

    override fun onBindViewHolder(holder: Holder, position: Int) {
        holder.bind(getItem(position))
    }
}