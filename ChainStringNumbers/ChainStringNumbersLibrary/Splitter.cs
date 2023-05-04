namespace ChainStringNumbersLibrary
{
    public class Splitter 
    {
        

        public Splitter()
        {
        }

        public List<string> GetList(string myString)
        {
            return myString.Split(",").ToList();
        }
    }
}
