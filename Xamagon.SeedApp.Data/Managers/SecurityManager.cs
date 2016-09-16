using System;
using Xamagon.SeedApp.Data.Interfaces;
using Xamagon.SeedApp.Common.Security;

namespace Xamagon.SeedApp.Data.Managers
{
    public class SecurityManager : ISecurityManager
    {
        private readonly ISecureLocalStorageProvider _secureStorageProvider;
        public const string CurrentAccessTokenKey = "CurrentAccessToken";

        public SecurityManager (ISecureLocalStorageProvider secureStorageProvider)
        {
            _secureStorageProvider = secureStorageProvider;
        }

        public void SaveAccessToken (string accessToken)
        {
            _secureStorageProvider.SetValue (CurrentAccessTokenKey, accessToken);
        }
    }
}