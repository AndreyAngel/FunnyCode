package com.example.funnyapp.presentation.fragment

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.data.model.response.Divisions
import com.example.funnyapp.databinding.FragmentProfileBinding
import com.example.funnyapp.presentation.adapter.ProfileSphereAdapter
import com.example.funnyapp.presentation.adapter.ProfileWorkDataAdapter
import com.example.funnyapp.presentation.vm.ProfileViewModel
import org.koin.androidx.viewmodel.ext.android.viewModel


class ProfileFragment : Fragment(), ProfileSphereAdapter.OnClickListener {
    private lateinit var binding: FragmentProfileBinding
    private val profileViewModel by viewModel<ProfileViewModel>()
    private val profileSpheresAdapter by lazy { ProfileSphereAdapter(this) }
    private val profileContactsAdapter by lazy { ProfileWorkDataAdapter() }
    private val profileWorkDataAdapter by lazy { ProfileWorkDataAdapter() }

    companion object {
        @JvmStatic
        fun newInstance() = ProfileFragment()
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        profileViewModel.getContacts()
        profileViewModel.getWorkData()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentProfileBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        listContacts.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = profileContactsAdapter
        }

        listWorkData.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = profileWorkDataAdapter
        }

        cardProjects.apply {
            textProfileSphere.text = "Проекты"
            textSphereData.text = "2"
        }

        cardTasks.apply {
            textProfileSphere.text = "Задачи"
            textSphereData.text = "3"
        }

        cardTeam.apply {
            textProfileSphere.text = "Команда"
            textSphereData.text = "5 человек"
        }

        cardRest.apply {
            textProfileSphere.text = "Отпуск"
            textSphereData.text = "До 10.07.23"
        }

        cardCalendar.apply {
            textProfileSphere.text = "Календарь занятости"
            textSphereData.text = "Занят в Пн, Пт"
        }

        cardSalary.apply {
            textProfileSphere.text = "Зарплата"
            textSphereData.text = "125k"
        }

        cardNextPayout.apply {
            textProfileSphere.text = "Ближайшая выплата"
            textSphereData.text = "20 июня"
        }

        profileViewModel.contacts.observe(viewLifecycleOwner) {
            profileContactsAdapter.submitList(it)
        }

        profileViewModel.workData.observe(viewLifecycleOwner) {
            profileWorkDataAdapter.submitList(it)
        }
    }

    override fun onProfileSphereClick(item: Divisions) {

    }
}