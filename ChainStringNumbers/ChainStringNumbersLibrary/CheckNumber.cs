namespace ChainStringNumbersLibrary
{
    public class CheckNumber : Validator
    {
        public override (bool, string) IsValid(List<string> myList)
        {

            if (int.TryParse(myList[0], out _) && int.TryParse(myList[1], out _))
            {
                if (_successor != null)
                    return _successor.IsValid(myList);
                return (true, string.Empty);
            }

            return (false, "Not Numbers");

        }
    }
}