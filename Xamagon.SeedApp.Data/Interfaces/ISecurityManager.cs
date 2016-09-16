using System;

namespace Xamagon.SeedApp.Data.Interfaces
{
    public interface ISecurityManager
    {
        void SaveAccessToken (string accessToken);
    }
}