using System;
using System.Text;
using DataAccessLayer;

namespace DataBusinessLayer
{
    static public class clsHashing
    {
        static public string Hashing(string input)
        {
            return clsHashingData.Hashing(input);
        }
    }
}
