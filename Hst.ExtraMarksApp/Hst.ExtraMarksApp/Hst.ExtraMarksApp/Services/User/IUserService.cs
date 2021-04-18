using Hst.ExtraMarksApp.Models;
using Hst.ExtraMarksApp.Models.User;
using SBMS.Mobile.Models;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hst.ExtraMarksApp.Services.User
{
    public interface IUserService
    {
        Task<ApiBaseModel<UserModel>> Login(LoginModel loginModel);
        //Task<ApiBaseModel<LoginResponseModel>> Register(RegisterModel registerModel);
        //Task<ApiBaseModel<string>> ChangePassword(ChangePasswordModel model);
        //Task<ApiBaseModel<ChangePasswordResponseModel>> SendOTP(PasswordRecoveryModel model);
        //Task<ApiBaseModel<ChangePasswordResponseModel>> ValidateOTP(string mobileNo, string OTP);
        //Task<ApiBaseModel<string>> ChangePasswordWiaForgotPassword(ChangePasswordModel model);
        //Task<ApiBaseModel<ValidateParentsUserNameResponseModel>> VerifyMobileNoOnForgotPassword(ValidateParentsUserNameModel model);
        //Task<ApiBaseModel<OTPVerificationResponseModel>> VerifyOTP(OTPVerificationModel model);
        //Task<ApiBaseModel<ValidateParentsUserNameResponseModel>> ValidateUserOnParentsRegistration(ValidateParentsUserNameModel model);
        //Task<ApiBaseModel<LoginResponseModel>> ParentsRegistration(ParentsRegistrationModel model);
        //Task<ApiBaseModel<ParentsProfileModel>> GetParentsProfile(int parentsId);
        //Task<ApiBaseModel<string>> UpdateParentsProfile(ParentsProfileModel model);
    }
}
