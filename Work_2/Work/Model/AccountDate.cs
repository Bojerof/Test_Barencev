using System;
namespace Work_2.Work
{
	public class AccountDate
	{
		private string username;
		private string password;
		public AccountDate(string username, string password)
		{
			this.username = username;
			this.password = password;
		}
		public string Username
		{
			get
			{
				return username;
			}
			set
			{
				username = value;
			}
		}
		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}
	}

}

