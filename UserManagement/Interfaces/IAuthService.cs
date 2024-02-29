﻿using Microsoft.AspNetCore.Mvc;
using UserManagement.Entity;
using UserManagement.Model;

namespace UserManagement.Interfaces
{
    public interface IAuthService
    {
        Task<Result<UserLoginResponse>> Login(UserLoginRequest request);

        Task<Result<UserLoginResponse>> RefreshToken(RefreshTokenRequest request);
        Task<Result<string>> ForgotPassword(ForgotPasswordRequest request);
        Task<Result<bool>> ResetPassword(ChangePasswordRequest request);
        Task<Result<User>> Register(User user);

    }
}
