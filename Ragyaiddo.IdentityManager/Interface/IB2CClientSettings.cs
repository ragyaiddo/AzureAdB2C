namespace Ragyaiddo.IdentityManager.Interface
{
    /// <summary>
    /// Azure AD B2C application settings for the client app 
    /// </summary>
    public interface IB2CClientSettings
    {
        #region Settings from the Azure AD B2C instance
        string Tenant { get; set; }
        string ClientId { get; set; }
        string ClientSecret { get; set; }
        string SignUpSignInPolicyId { get; set; }
        string SignUpPolicyId { get; set; }
        string SignInPolicyId { get; set; }
        string EditProfilePolicyId { get; set; }
        string ResetPasswordPolicyId { get; set; }
        /// <summary>
        /// The callback url after a call to the B2C policy. 
        /// This should match to the configured value in the B2C instance
        /// </summary>
        string RedirectUri { get; set; }

        #endregion

        /// <summary>
        /// Azure active directory instance metadata url format 
        /// </summary>
        string AadInstance { get; set; }
        /// <summary>
        /// Url/controller route to force user logout
        /// </summary>
        string LogoutUri { get; set; }
        /// <summary>
        /// Callback Uri after user is logged out
        /// </summary>
        string PostLogoutRedirectUri { get; set; }
        string ErrorRedirectUri { get; set; }
        string ResetPasswordRoute { get; set; }
        string DefaultPolicyId { get; set; }
        /// <summary>
        /// Prefix of the Azure AD B2c Policies. Currently equal to "B2C_"
        /// </summary>
        string PolicyIdPrefix { get; set; }
    }
}
