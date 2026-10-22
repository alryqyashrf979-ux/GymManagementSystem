using System;
using DataBusinessLayer;
using Microsoft.Win32;

namespace GymMangementSystem
{
    static public class clsGlobal
    {
        static public clsUsers CurrentUserInfo;
        static public bool WriteInWindowsRegister(string username,string password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\GMS_UserInfo";
           

            try
            {
                Registry.SetValue(KeyPath, "Username", username, RegistryValueKind.String);
                Registry.SetValue(KeyPath, "Password", password, RegistryValueKind.String);
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
          

            try
            {
                username = Registry.GetValue(KeyPath, "Username", null) as string;
                Password = Registry.GetValue(KeyPath, "Password", null) as string;
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }

    }

}
