namespace ChainStringNumbersLibrary
{
    internal class Splitter 
    {
        private readonly string _myString;

        public Splitter(string MyString)
        {
            _myString = MyString;
        }

        public List<string> GetList()
        {
            return _myString.Split(",").ToList();
        }
    }
}
