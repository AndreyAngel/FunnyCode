package com.example.funnyapp.presentation

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.fragment.app.Fragment
import com.example.funnyapp.R
import com.example.funnyapp.databinding.ActivityMainBinding
import com.example.funnyapp.presentation.fragment.ChatsFragment
import com.example.funnyapp.presentation.fragment.EmployeeFragment
import com.example.funnyapp.presentation.fragment.ProfileFragment

class MainActivity : AppCompatActivity() {
    private val fragmentManager by lazy { supportFragmentManager }
    private val chatsFragment by lazy { ChatsFragment.newInstance() }
    private val employeeFragment by lazy { EmployeeFragment.newInstance() }
    private val profileFragment by lazy { ProfileFragment.newInstance() }
    private lateinit var activeFragment: Fragment
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        initView()
        setContentView(binding.root)
    }

    private fun initView() = with(binding) {
        activeFragment = employeeFragment

        navMain.setOnItemSelectedListener {
            when (it.itemId) {
                R.id.navMain -> {
                    return@setOnItemSelectedListener false
                }
                R.id.navChats -> {
                    openFragment(chatsFragment)
                    return@setOnItemSelectedListener true
                }
                R.id.navSearch -> {
                    openFragment(employeeFragment)
                    return@setOnItemSelectedListener true
                }
                R.id.navProfile -> {
                    openFragment(profileFragment)
                    return@setOnItemSelectedListener true
                }
                else -> return@setOnItemSelectedListener false
            }
        }
    }

    private fun openFragment(fragment: Fragment) {
        fragmentManager.beginTransaction()
            .replace(R.id.containerFragment, fragment)
            .commit()
        activeFragment = fragment
    }
}