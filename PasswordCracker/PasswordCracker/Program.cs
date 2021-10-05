using System;
using System.IO;

namespace PasswordCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hashedPasswords = File.ReadAllLines("passwords_hashed.txt");

            Console.WriteLine("MD5 Password Cracker v1.0");
            
            foreach (var pass in hashedPasswords)
            {
                Console.WriteLine(pass);
            }

            // Use this method to test if you managed to correctly crack all the passwords
            // Note that hashedPasswords will need to be swapped out with an array the exact
            // same length that contains all the cracked passwords
            bool passwordsValidated = Validator.ValidateResults(hashedPasswords);
            
            Console.WriteLine($"\nPasswords successfully cracked: {passwordsValidated}");
        }
    }
}