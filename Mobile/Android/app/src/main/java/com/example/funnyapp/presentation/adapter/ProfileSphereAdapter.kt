package com.example.funnyapp.presentation.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView.ViewHolder
import com.example.funnyapp.R
import com.example.funnyapp.data.model.response.Divisions
import com.example.funnyapp.databinding.ItemProfileSphereBinding

class ProfileSphereAdapter(private val listener: OnClickListener) : ListAdapter<Divisions, ProfileSphereAdapter.Holder>(Comparator()) {
    interface OnClickListener {
        fun onProfileSphereClick(item: Divisions)
    }

    class Holder(itemView: View, listener: OnClickListener) : ViewHolder(itemView) {
        private val binding = ItemProfileSphereBinding.bind(itemView)
        private lateinit var divisionItem: Divisions

        init {
            binding.root.setOnClickListener {
                listener.onProfileSphereClick(item = divisionItem)
            }
        }

        fun bind(item: Divisions) {
            divisionItem = item
        }
    }

    class Comparator : DiffUtil.ItemCallback<Divisions>() {
        override fun areItemsTheSame(oldItem: Divisions, newItem: Divisions): Boolean {
            return oldItem.id == newItem.id
        }

        override fun areContentsTheSame(oldItem: Divisions, newItem: Divisions): Boolean {
            return oldItem == newItem
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): Holder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_profile_sphere, parent, false)
        return Holder(view, listener)
    }

    override fun onBindViewHolder(holder: Holder, position: Int) {
        holder.bind(getItem(position))
    }
}