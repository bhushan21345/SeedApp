using System;

namespace Xamagon.SeedApp.Common
{
    public interface ISecureStorageProvider
    {
        string GetValue (string key);

        void SetValue (string key, string value);

        void Delete (string key);
    }
}