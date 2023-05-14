package com.example.funnyapp.presentation.fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.R
import com.example.funnyapp.databinding.FragmentFavoritesBinding
import com.example.funnyapp.model.Personnel
import com.example.funnyapp.presentation.ProfileBottomSheet
import com.example.funnyapp.presentation.adapter.PersonnelAdapter

class FavoritesFragment : Fragment(), PersonnelAdapter.OnClickListener {
    private lateinit var binding: FragmentFavoritesBinding
    private val employeesAdapter by lazy { PersonnelAdapter(this) }

    companion object {
        @JvmStatic
        fun newInstance() = FavoritesFragment()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentFavoritesBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        listEmployees.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = employeesAdapter
        }
    }

    override fun onPersonnelClick(item: Personnel) {
        val modalBottomSheet = ProfileBottomSheet()
        modalBottomSheet.show(requireActivity().supportFragmentManager, ProfileBottomSheet.TAG)
    }
}