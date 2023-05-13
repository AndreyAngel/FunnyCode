package com.example.funnyapp.data.extension

import com.example.funnyapp.data.api.ApiResult

fun <T : Any> ApiResult<T>.onLoading(
    executable: () -> Unit
): ApiResult<T> = apply {
    if (this is ApiResult.Loading) {
        executable()
    }
}

fun <T : Any> ApiResult<T>.onSuccess(
    executable: (T) -> Unit
): ApiResult<T> = apply {
    if (this is ApiResult.Success<T>) {
        executable(data)
    }
}

fun <T : Any> ApiResult<T>.onFailure(
    executable: (message: String, error: String?) -> Unit
): ApiResult<T> = apply {
    if (this is ApiResult.Failure) {
        executable(message, error)
    }
}