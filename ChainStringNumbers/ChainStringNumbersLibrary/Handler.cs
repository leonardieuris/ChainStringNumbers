namespace ChainStringNumbersLibrary
{
    public class Handler
    {
        public Handler()
        {
            
        }


        public int GetResult(string input)
        {
            var myList = ManageString(input);
            var validation = Validator(myList);
            if (!validation.Item1)
                throw new Exception(validation.Item2);
            return Sum(myList);

        }

        private (bool,string) Validator(List<string> myList)
        {
            var checkTwoItems = new CheckTwoItems();
            var checkNumbers = new CheckNumber();
            var checkPositive = new CheckPositive();
            checkTwoItems.SetSuccessor(checkNumbers);
            checkNumbers.SetSuccessor(checkPositive);
            return checkTwoItems.IsValid(myList);
        }

        private List<string> ManageString(string input)
        {
            var splitter = new Splitter(input);
            return splitter.GetList();
        }

        private int Sum(List<string> myList)
        {
            return myList.Sum(x => Convert.ToInt32(x));
        }
    }
}
