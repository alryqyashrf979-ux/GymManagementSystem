using System;
using Microsoft.Win32;

namespace GymMangementSystem
{
    static public class clsGlobal
    {
        static public bool WriteInWindowsRegister(string username,string password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\USERINFO";
            string value = "Username";
            string ValueData = username;
            string value2 = "Password";
            string ValueData2 = password;

            try
            {
                Registry.SetValue(KeyPath, value, ValueData, RegistryValueKind.String);
                Registry.SetValue(KeyPath, value2, ValueData2, RegistryValueKind.String);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
