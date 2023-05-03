namespace ChainStringNumbersLibrary
{
    public interface IValidator
    {
        (bool, string) IsValid(List<string> myList);
    }
}
