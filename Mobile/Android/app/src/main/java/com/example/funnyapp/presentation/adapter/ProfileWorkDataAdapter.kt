package com.example.funnyapp.presentation.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.funnyapp.R
import com.example.funnyapp.databinding.ItemProfileWorkDataBinding
import com.example.funnyapp.model.ProfileWorkData

class ProfileWorkDataAdapter : ListAdapter<ProfileWorkData, ProfileWorkDataAdapter.Holder>(Comparator()) {
    class Holder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        private val binding = ItemProfileWorkDataBinding.bind(itemView)

        fun bind(item: ProfileWorkData) = with(binding) {
            textWorkDataTitle.text = item.workDataTitle
            textWorkDataDescription.text = item.workDataDescription
        }
    }

    class Comparator : DiffUtil.ItemCallback<ProfileWorkData>() {
        override fun areItemsTheSame(oldItem: ProfileWorkData, newItem: ProfileWorkData): Boolean {
            return oldItem == newItem
        }

        override fun areContentsTheSame(oldItem: ProfileWorkData, newItem: ProfileWorkData): Boolean {
            return oldItem == newItem
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): Holder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_profile_work_data, parent, false)
        return Holder(view)
    }

    override fun onBindViewHolder(holder: Holder, position: Int) {
        holder.bind(getItem(position))
    }
}