package com.example.funnyapp.presentation.fragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.widget.addTextChangedListener
import androidx.fragment.app.Fragment
import androidx.fragment.app.viewModels
import com.example.funnyapp.databinding.FragmentEmployeeBinding
import com.example.funnyapp.presentation.adapter.TabsPagerAdapter
import com.example.funnyapp.presentation.vm.SearchViewModel
import com.google.android.material.tabs.TabLayoutMediator
import org.koin.androidx.viewmodel.ext.android.viewModel

class EmployeeFragment : Fragment() {
    private lateinit var binding: FragmentEmployeeBinding

    companion object {
        @JvmStatic
        fun newInstance() = EmployeeFragment()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentEmployeeBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        val searchFragment = SearchFragment.newInstance()
        val fragList = listOf(
            searchFragment,
            FavoritesFragment.newInstance()
        )
        val tabTitles = listOf("Список", "Избранные")
        //vpSearch.isUserInputEnabled = false
        vpSearch.adapter = TabsPagerAdapter(requireActivity(), fragList)
        TabLayoutMediator(tabsSearch, vpSearch) { tab, position ->
            tab.text = tabTitles[position]
        }.attach()

        editTextSearchEmployee.addTextChangedListener {
            searchFragment.searchPersonnel(it.toString())
        }
    }
}