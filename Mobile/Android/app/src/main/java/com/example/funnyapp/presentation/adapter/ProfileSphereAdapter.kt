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
import com.example.funnyapp.model.ProfileSphere

class ProfileSphereAdapter(private val listener: OnClickListener) : ListAdapter<ProfileSphere, ProfileSphereAdapter.Holder>(Comparator()) {
    interface OnClickListener {
        fun onProfileSphereClick(item: ProfileSphere)
    }

    class Holder(itemView: View, listener: OnClickListener) : ViewHolder(itemView) {
        private val binding = ItemProfileSphereBinding.bind(itemView)
        private lateinit var sphereItem: ProfileSphere

        init {
            binding.root.setOnClickListener {
                listener.onProfileSphereClick(item = sphereItem)
            }
        }

        fun bind(item: ProfileSphere) = with(binding) {
            sphereItem = item

            textProfileSphere.text = item.sphereName
            textSphereData.text = item.sphereData
        }
    }

    class Comparator : DiffUtil.ItemCallback<ProfileSphere>() {
        override fun areItemsTheSame(oldItem: ProfileSphere, newItem: ProfileSphere): Boolean {
            return oldItem.sphereName == newItem.sphereName
        }

        override fun areContentsTheSame(oldItem: ProfileSphere, newItem: ProfileSphere): Boolean {
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