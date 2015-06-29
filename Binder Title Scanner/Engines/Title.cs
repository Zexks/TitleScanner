namespace BTS.Engines
{
    public struct Title
    {
        public string Guid, Name, Version, Year;

        public Title(string guid, string name, string version, string year)
        {
            Guid = guid;
            Name = name;
            Version = version;
            Year = year;
        }
    }
}