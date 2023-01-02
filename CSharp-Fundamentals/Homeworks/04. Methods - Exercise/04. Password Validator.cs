using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidator(password);
        }

        static void PasswordValidator(string password)
        {
            int digitCnt = 0;
            bool isValidPass = true;

            if (password.Length < 6 || password.Length > 10)
            {
                isValidPass = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }            

            for (int i = 0; i < password.Length; i++)
            {
                bool isPasswordLetAndDig = password[i] < 48 || (password[i] > 57 && password[i] < 65) || (password[i] > 90 && password[i] < 97) || password[i] > 122;
                if (isPasswordLetAndDig)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValidPass = false;
                    break;
                }                
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitCnt++;
                }
            }

            if (digitCnt < 2)
            {
                isValidPass = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidPass)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
