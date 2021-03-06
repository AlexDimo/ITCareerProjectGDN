﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using DatabaseOperations.Operations.PasswordManagerBuissiness;
using DatabaseOperations.Model.PasswordManagerModel;

namespace PasswordManager.PasswordManager.Services
{
	public static class PasswordServices
	{
		public static List<Password> GetChromePasswords()
		{
			List<Password> passwords = new List<Password>();

			//Opens a Connection to the DB
			SqliteConnection sqliteChromeData = new SqliteConnection(ReturnSqlitePathToChrome());
			sqliteChromeData.Open();

			//Making a SQL statement and reader
			string commandGetInfo = "SELECT origin_url,username_value,password_value FROM logins";
			SqliteCommand sqliteCommand = new SqliteCommand(commandGetInfo, sqliteChromeData);
			SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			
			//Reading the Db for passwords
			while (sqliteDataReader.Read())
			{
				string url = sqliteDataReader.GetString(0);
				string username = sqliteDataReader.GetString(1);
				string password = DecryptPassword(sqliteDataReader);
				passwords.Add(new Password(url, username, password));
			}

			passwords = passwords.Where(x => x.LoginPassword != "").ToList();
			//Closing Connection
			sqliteChromeData.Close();

			//Adds a password operation into GNA_Toolbox main DB
			PasswordManagerServices.AddPasswordManagerAsync(passwords);
			PasswordManagerServices.AddPasswordOperationAsync();

			return passwords;
		}

		private static string DecryptPassword(SqliteDataReader sqliteDataReader)
		{
			//Making a blob string from chrome db
			string passwordBlob = Encoding.ASCII.GetString((byte[])sqliteDataReader[2]);

			//trying to decrypt the passwords
			try
			{
				byte[] passwordByte = ProtectedData.Unprotect((byte[])sqliteDataReader[2], null, DataProtectionScope.CurrentUser);
				string passwordString = Encoding.ASCII.GetString(passwordByte);
				return passwordString;
			}
			catch (Exception)
			{
				//returning unencrypted password
				return "";
			}

		}

		public static string ReturnSqlitePathToChrome()
		{
			//Making paths for files
			string dataSource = "Data Source=";
			string localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string loginData = @"\Google\Chrome\User Data\Default\Login Data";
			string defaultPath = @"\Google\Chrome\User Data\Default\Login Data GNA";

			//Copy the chrome db for further use
			FileStream fileLoginDataCopy = new FileStream(localData + defaultPath, FileMode.Create);
			fileLoginDataCopy.Close();

			FileStream fileData = File.Open(localData + loginData, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			byte[] fileDataBytes = new byte[fileData.Length];
			fileData.Read(fileDataBytes, 0, (int)fileData.Length);
			File.WriteAllBytes(localData + defaultPath, fileDataBytes);

			//Returns the path to Chrome's Database 
			return dataSource + localData + defaultPath;
		}

		public static string RandomPassword()
		{
			List<char> password = new List<char>();

			const string alphanumericUpperCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			const string alphanumericLowerCharacters = "abcdefghijklmnopqrstuvwxyz";
			const string alphanumericNumCharacters = "0123456789";

			Random random = new Random();

			for (int i = 0; i < random.Next(15, 20); i++)
			{
				int array = random.Next(1, 4);
				if (array == 1)
				{
					password.Add(alphanumericUpperCharacters[random.Next(alphanumericUpperCharacters.Length)]);
				}
				if (array == 2)
				{
					password.Add(alphanumericLowerCharacters[random.Next(alphanumericLowerCharacters.Length)]);
				}
				if (array == 3)
				{
					password.Add(alphanumericNumCharacters[random.Next(alphanumericNumCharacters.Length)]);
				}
			}

			return new string(password.ToArray());
		}

	}
}
