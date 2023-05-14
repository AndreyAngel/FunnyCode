package com.example.funnyapp.presentation.fragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.R
import com.example.funnyapp.data.extension.onSuccess
import com.example.funnyapp.databinding.FragmentSearchBinding
import com.example.funnyapp.model.Personnel
import com.example.funnyapp.presentation.ProfileBottomSheet
import com.example.funnyapp.presentation.adapter.PersonnelAdapter
import com.example.funnyapp.presentation.vm.SearchViewModel
import org.koin.androidx.viewmodel.ext.android.activityViewModel


class SearchFragment : Fragment(), PersonnelAdapter.OnClickListener {
    private lateinit var binding: FragmentSearchBinding
    private val searchViewModel by activityViewModel<SearchViewModel>()
    private val managersAdapter by lazy { PersonnelAdapter(this) }
    private val employeesAdapter by lazy { PersonnelAdapter(this) }

    companion object {
        @JvmStatic
        fun newInstance() = SearchFragment()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentSearchBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        listManagers.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = managersAdapter
        }
        listEmployees.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = employeesAdapter
        }

        searchViewModel.searchList.observe(viewLifecycleOwner) { result ->
            result.onSuccess {
                searchViewModel.getPersonnelFromSearchList(
                    it,
                    requireActivity().resources.getStringArray(R.array.posts)
                )
            }
        }

        searchViewModel.managersList.observe(viewLifecycleOwner) {
            managersAdapter.submitList(it)
        }

        searchViewModel.employeesList.observe(viewLifecycleOwner) {
            employeesAdapter.submitList(it)
        }
    }

    override fun onPersonnelClick(item: Personnel) {
        val modalBottomSheet = ProfileBottomSheet()
        modalBottomSheet.show(requireActivity().supportFragmentManager, ProfileBottomSheet.TAG)
    }
}