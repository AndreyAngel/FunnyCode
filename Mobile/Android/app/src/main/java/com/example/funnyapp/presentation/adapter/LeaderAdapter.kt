package com.example.funnyapp.presentation.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView.ViewHolder
import com.example.funnyapp.R
import com.example.funnyapp.data.model.Leader
import com.example.funnyapp.databinding.ItemLeaderBinding

class LeaderAdapter(private val listener: OnClickListener) : ListAdapter<Leader, LeaderAdapter.Holder>(Comparator()) {
    interface OnClickListener {
        fun onLeaderClick(item: Leader)
    }

    class Holder(itemView: View, listener: OnClickListener) : ViewHolder(itemView) {
        private val binding = ItemLeaderBinding.bind(itemView)
        private lateinit var leaderItem: Leader

        init {
            binding.root.setOnClickListener {
                listener.onLeaderClick(leaderItem)
            }
        }

        fun bind(item: Leader) = with(binding) {
            leaderItem = item

            textPersonName.text = item.name
            textPersonPost.text = itemView.context.resources.getStringArray(R.array.posts)[item.jobTitle.ordinal]
        }
    }

    class Comparator : DiffUtil.ItemCallback<Leader>() {
        override fun areItemsTheSame(oldItem: Leader, newItem: Leader): Boolean {
            return oldItem.id == newItem.id
        }

        override fun areContentsTheSame(oldItem: Leader, newItem: Leader): Boolean {
            return oldItem == newItem
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): Holder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_leader, parent, false)
        return Holder(view, listener)
    }

    override fun onBindViewHolder(holder: Holder, position: Int) {
        holder.bind(getItem(position))
    }
}