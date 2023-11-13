using System;
namespace Work_1.Homework
{
	public struct AccountDate
	{
		private string userName;
		private string password;
		public AccountDate(string userName, string password)
		{
			this.userName = userName;
			this.password = password;
		}

		public string UserName { get => userName; set => userName = value; }
		public string Password { get => password; set => password = value; }
	}
}

