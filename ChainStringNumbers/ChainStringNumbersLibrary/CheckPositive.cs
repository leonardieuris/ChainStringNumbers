namespace ChainStringNumbersLibrary;

public class CheckPositive : Validator
{
    public override (bool, string) IsValid(List<string> myList)
    {

        if ((int.Parse(myList[0])>0) && int.Parse(myList[1]) > 0)
        {
            if (_successor != null)
                return _successor.IsValid(myList);
            return (true, string.Empty);
        }

        return (false, "Not Positive Numbers");

    }
}