namespace Task1
{
    class Worker
    {
        private string fullName;
        private int startYear;
        private string job;

        public string FullName { get => fullName; }
        public int StartYear { get => startYear; }
        public string Job { get => job; }

        public Worker(string name, int year, string job)
        {
            fullName = name;
            startYear = year;
            this.job = job;
        }
    }
}
