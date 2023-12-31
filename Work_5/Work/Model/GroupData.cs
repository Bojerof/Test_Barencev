﻿namespace Work_5.Work
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {

        public GroupData(string name)
        {
            Name = name;
        }

        public GroupData(string name, string header, string footer) : this(name)
        {
            Header = header;
            Footer = footer;
        }

        public string Name { get; set; }

        public string Header { get; set; }

        public string Footer { get; set; }

        public string Id { get; set; }

        public int CompareTo(GroupData? other)
        {
            if (Object.ReferenceEquals(other, null)) return 1;
            return Name.CompareTo(other.Name);
        }

        public bool Equals(GroupData? other)
        {
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;

            return Name == other.Name;
        }

        public override int GetHashCode() => Name.GetHashCode();


        public override string ToString() => $"Name = {Name}\nheader = {Header}\nfooter = {Footer}";
    }
}

