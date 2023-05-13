package com.example.funnyapp.presentation.fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.example.funnyapp.R
import com.example.funnyapp.databinding.FragmentStructureBinding

class StructureFragment : Fragment() {
    private lateinit var binding: FragmentStructureBinding

    companion object {
        @JvmStatic
        fun newInstance() = StructureFragment()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        binding = FragmentStructureBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {

    }
}