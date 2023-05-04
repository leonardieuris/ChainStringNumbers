namespace ChainStringNumbersLibrary
{
    public class Handler
    {
        private readonly Validator _validator;
        private readonly Splitter _splitter;

        public Handler(Validator validator,Splitter splitter)
        {
            _validator = validator;
            _splitter = splitter;
        }


        public int GetResult(string input)
        {
            var myList = _splitter.GetList(input);
            var validation = _validator.IsValid(myList);
            if (!validation.Item1)
                throw new Exception(validation.Item2);
            return Sum(myList);

        }


        private int Sum(List<string> myList)
        {
            return myList.Sum(x => Convert.ToInt32(x));
        }
    }
}
