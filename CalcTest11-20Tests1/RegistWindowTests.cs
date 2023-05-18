using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcTest11_20.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest11_20.Windows.Tests
{
    [TestClass()]
    public class RegistWindowTests
    {

        RegistrationWindow registWindow = new RegistrationWindow();

        // Password test

        // Symbols > 8

        [TestMethod()]
        public void Check_PasswordMoreThan8Symbols_ReturnTrue()
        {
            string password = "Pswd123@#";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Symbols < 32
        [TestMethod()]
        public void Check_PasswordMoreThan35Symbols_ReturnFalse()
        {
            string password = "Pswd123!Pswd123!Pswd123!Pswd123!P";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Symbols < 8
        [TestMethod()]
        public void Check_PasswordLessThan8Symbols_ReturnFalse()
        {
            string password = "Pswd1!";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password numbers
        [TestMethod()]
        public void Check_PassworHasDigits_ReturnTrue()
        {
            string password = "Pswd123!@";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password without numbers
        [TestMethod()]
        public void Check_PasswordHasNoDigits_ReturnFalse()
        {
            string password = "Pswd!@#$%";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password special symbols
        [TestMethod()]
        public void Check_PasswordHasSpecSymbols_ReturnTrue()
        {
            string password = "Pswd123!@";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password without special symbols
        [TestMethod()]
        public void Check_PasswordHasNoSpecSymbols_ReturnFalse()
        {
            string password = "Pswd12345678";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password upper letters
        [TestMethod()]
        public void Check_PasswordHasUpperLetters_ReturnTrue()
        {
            string password = "Pswd123!@";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password lower letters
        [TestMethod()]
        public void Check_PasswordHasLowersLetters_ReturnTrue()
        {
            string password = "Pswd123!@";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Password without upper letter
        [TestMethod()]
        public void Check_PasswordHasNoUpperLetters_ReturnFalse()
        {
            string password = "pswd123!@";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

       
        // Login test

        // Symbols > 10
        [TestMethod()]
        public void Check_LoginBodyMoreThan10Symbols_ReturnTrue()
        {
            string login = "Pasha12!log.calc";
            bool expected = true;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }



        // Symbols > 35
        [TestMethod()]
        public void Check_LoginMoreThan35Symbols_ReturnFalse()
        {

            string login = "Pasha12!logpasha12!logpasha12!logpas.calc";
            bool expected = false;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }


        // Symbols < 10
        [TestMethod()]
        public void Check_LoginBodyLessThan10Symbols_ReturnFalse()
        {
            string login = "Pash12!.calc";
            bool expected = false;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }


        // Login numbers
        [TestMethod()]
        public void Check_LoginBodyHasdigits_ReturnTrue()
        {
            string login = "Pasha12!log.calc";
            bool expected = true;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Login without numbers
        [TestMethod()]
        public void Check_LoginBodyHasNoDigits_ReturnFalse()
        {
            string login = "Pashastaf!@#.calc";
            bool expected = false;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Login special symbols
        [TestMethod()]
        public void Check_LoginBodyHasSpecialSymbols_ReturnTrue()
        {
            string login = "Pasha12!log.calc";
            bool expected = true;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Login without special symbols
        [TestMethod()]
        public void Check_LoginBodyHasNoSpecialSymbols_ReturnFalse()
        {
            string login = "Pasha12log.calc";
            bool expected = false;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }
        // Login upper letters
        [TestMethod()]
        public void Check_LoginBodyHasUpperLetters_ReturnTrue()
        {
            string login = "Pasha12!log.calc";
            bool expected = true;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Login lower letters
        [TestMethod()]
        public void Check_LoginBodyHasLowerLetters_ReturnTrue()
        {
            string login = "Pasha12!log.calc";
            bool expected = true;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Login has no ending with .calc
        [TestMethod()]
        public void Check_LoginHasNoEnding_ReturnFalse()
        {
            string login = "Pasha12!log";
            bool expected = false;

            bool actual = RegistrationWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }
    }
}