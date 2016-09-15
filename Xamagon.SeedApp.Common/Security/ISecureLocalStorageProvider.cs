namespace Xamagon.SeedApp.Common.Security
{
    public interface ISecureLocalStorageProvider
    {
        string GetValue (string key);

        void SetValue (string key, string value);

        void Delete (string key);
    }
}