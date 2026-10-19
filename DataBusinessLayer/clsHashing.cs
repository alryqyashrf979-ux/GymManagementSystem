using DataAccessLayer;
using System;
using System.Security.Cryptography;
using System.Text;

namespace DataBusinessLayer
{
    static public class clsHashing
    {
    
            static public string Hashing(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashData = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                    return BitConverter.ToString(hashData).Replace("-", "").ToLower();
                }
            }
        
    }
}
