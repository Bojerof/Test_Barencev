using System;
namespace Work_1
{
	public class GroupDate
	{
		private string name;
		private string header = "";
		private string footer = "";
		public GroupDate(string name)
		{
			this.name = name;
		}

        public GroupDate(string name, string header, string footer) : this(name)
        {
            this.header = header;
            this.footer = footer;
        }

        public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public string Header
		{
			get
			{
				return header;
			}
			set
			{
				header = value;
			}
		}

        public string Footer { get => footer; set => footer = value; }
    }
}

