package com.example.funnyapp.presentation

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.example.funnyapp.R
import com.google.android.material.bottomsheet.BottomSheetDialogFragment

class ProfileBottomSheet : BottomSheetDialogFragment() {

    companion object {
        const val TAG = "ProfileBottomSheet"
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View?
    = inflater.inflate(R.layout.bottom_sheet_profile, container, false)
}