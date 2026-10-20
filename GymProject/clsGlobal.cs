using System;
using Microsoft.Win32;

namespace GymMangementSystem
{
    static public class clsGlobal
    {

        static public bool WriteInWindowsRegister(string username,string password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\GMS_UserInfo";
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

        static public bool ReadFromWindowsRegistery(ref string username,ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\GMS_UserInfo";
            string ValueName = "Username";
            string ValueName2 = "Password";

            try
            {
                username = Registry.GetValue(KeyPath, ValueName, null) as string;
                Password = Registry.GetValue(KeyPath, ValueName2, null) as string;
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }

    }

}
