package com.example.funnyapp.presentation.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView.ViewHolder
import com.example.funnyapp.R
import com.example.funnyapp.databinding.ItemPersonnelBinding
import com.example.funnyapp.model.Personnel

class PersonnelAdapter : ListAdapter<Personnel, PersonnelAdapter.Holder>(Comparator()) {
    class Holder(itemView: View) : ViewHolder(itemView) {
        private val binding = ItemPersonnelBinding.bind(itemView)

        fun bind(item: Personnel) = with(binding) {
            imagePerson.setImageResource(item.image)
            textPersonName.text = item.name
            textPersonPost.text = item.post
        }
    }

    class Comparator : DiffUtil.ItemCallback<Personnel>() {
        override fun areItemsTheSame(oldItem: Personnel, newItem: Personnel): Boolean {
            return oldItem == newItem
        }

        override fun areContentsTheSame(oldItem: Personnel, newItem: Personnel): Boolean {
            return oldItem == newItem
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): Holder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_personnel, parent, false)
        return Holder(view)
    }

    override fun onBindViewHolder(holder: Holder, position: Int) {
        holder.bind(getItem(position))
    }
}