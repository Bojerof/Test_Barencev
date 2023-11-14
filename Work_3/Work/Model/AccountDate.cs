
namespace Work_3.Work
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

		public string Username { get => userName; set => userName = value; }

		public string Password { get => password; set => password = value; }
	}
}

