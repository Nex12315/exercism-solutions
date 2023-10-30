public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber.StartsWith("212");
        bool isFake = phoneNumber.Substring(4, 3) == "555";
        string localNumber = phoneNumber.Substring(8);

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(PhoneNumber.Analyze("631-555-1234"));

        Console.WriteLine(PhoneNumber.IsFake(PhoneNumber.Analyze("631-555-1234")));
    }
}
