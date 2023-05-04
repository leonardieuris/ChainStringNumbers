namespace ChainStringNumbersLibrary;

public class CheckTwoItems : Validator
{
    public override (bool, string) IsValid(List<string> myList)
    {
        if (myList.Count == 2)
        {
            if (_successor != null)
            {
                return _successor.IsValid(myList);
            }
            else
            {
                return (true, string.Empty);
            }
        }

        return (false, "More Items");
    }
}