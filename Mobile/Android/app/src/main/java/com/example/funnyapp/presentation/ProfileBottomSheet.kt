package com.example.funnyapp.presentation

import android.content.Intent
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.funnyapp.R
import com.example.funnyapp.data.extension.onSuccess
import com.example.funnyapp.data.model.Leader
import com.example.funnyapp.databinding.BottomSheetProfileBinding
import com.example.funnyapp.model.ProfileSphere
import com.example.funnyapp.model.ProfileWorkData
import com.example.funnyapp.presentation.adapter.LeaderAdapter
import com.example.funnyapp.presentation.adapter.ProfileSphereAdapter
import com.example.funnyapp.presentation.adapter.ProfileWorkDataAdapter
import com.example.funnyapp.presentation.vm.ProfileViewModel
import com.google.android.material.bottomsheet.BottomSheetDialogFragment
import org.koin.androidx.viewmodel.ext.android.viewModel

class ProfileBottomSheet : BottomSheetDialogFragment(), ProfileSphereAdapter.OnClickListener, LeaderAdapter.OnClickListener {
    private lateinit var binding: BottomSheetProfileBinding
    private val profileViewModel by viewModel<ProfileViewModel>()
    private val profileSpheresAdapter by lazy { ProfileSphereAdapter(this) }
    private val leadersAdapter by lazy { LeaderAdapter(this) }
    private val profileContactsAdapter by lazy { ProfileWorkDataAdapter() }
    private val profileWorkDataAdapter by lazy { ProfileWorkDataAdapter() }

    companion object {
        const val TAG = "ProfileBottomSheet"
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        profileViewModel.getUserProfile()
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = BottomSheetProfileBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        initView()
    }

    private fun initView() = with(binding) {
        listWorkSpheres.apply {
            layoutManager = LinearLayoutManager(requireActivity(), LinearLayoutManager.HORIZONTAL, false)
            adapter = profileSpheresAdapter
        }

        listLeaders.apply {
            layoutManager = LinearLayoutManager(requireActivity(), LinearLayoutManager.HORIZONTAL, false)
            adapter = leadersAdapter
        }

        listContacts.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = profileContactsAdapter
        }

        listWorkData.apply {
            layoutManager = LinearLayoutManager(requireActivity())
            adapter = profileWorkDataAdapter
        }

        buttonBeginChat.setOnClickListener {
            val intent = Intent(requireActivity(), ChatActivity::class.java).apply {
                putExtra("ChatUser", textProfileName.text)
                putExtra("ChatUserImage", R.drawable.ic_man)
            }
            startActivity(intent)
        }

        profileViewModel.userProfile.observe(viewLifecycleOwner) { result ->
            result.onSuccess {
                textProfileName.text = it.name
                imagePerson.setImageResource(R.drawable.ic_man)
                textWorkSphere.text = requireActivity().resources.getStringArray(R.array.posts)[it.workSpace.role]
                val schedules = it.schedule.schedules
                var calendarDays = ""
                schedules.forEach { sc ->
                    calendarDays += requireActivity().resources.getStringArray(R.array.week)[sc.dayOfWeek - 1]
                    calendarDays += ", "
                }
                val vacationInfo = if (it.currentVacation == null) "Не скоро" else "До ${it.currentVacation!!.endData}"
                profileSpheresAdapter.submitList(
                    listOf(
                        ProfileSphere("Проекты", it.countProjects.toString()),
                        ProfileSphere("Задачи", it.countTasks.toString()),
                        ProfileSphere("Команда", it.countTeamUsers.toString()),
                        ProfileSphere("Отпуск", vacationInfo),
                        ProfileSphere("Календарь занятости", "Занят в $calendarDays"),
                        ProfileSphere("Зарплата", "125k"),
                        ProfileSphere("Ближайшая выплата", "20 июня")
                    )
                )
                leadersAdapter.submitList(
                    listOf(it.workSpace.division.leader)
                )
                profileContactsAdapter.submitList(
                    listOf(
                        ProfileWorkData("Мобильный телефон", it.contacts.mobilePhoneNumber),
                        ProfileWorkData("Рабочий телефон", it.contacts.workPhoneNumber),
                        ProfileWorkData("E-mail", it.contacts.email),
                        ProfileWorkData("Логин Rocket.Chat", it.contacts.rocketChatLogin)
                    )
                )
                profileWorkDataAdapter.submitList(
                    listOf(
                        ProfileWorkData("Дата приема", "1 апреля 2016"),
                        ProfileWorkData("Организация", "Samokat.Tech"),
                        ProfileWorkData("Подразделение", "Отдел проектирования, разработка интерфейса"),
                        ProfileWorkData("Адрес работы", "Россия, Томск, ул. Фрунзе, 8"),
                        ProfileWorkData("Рабочее время", "Пн - Пт с 8 до 18")
                    )
                )
            }
        }
    }

    override fun onLeaderClick(item: Leader) {

    }

    override fun onProfileSphereClick(item: ProfileSphere) {

    }
}