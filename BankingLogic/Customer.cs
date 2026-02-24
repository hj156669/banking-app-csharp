namespace BankingLogic;

public class Customer
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Email: {Email}, Phone: {PhoneNumber}";
    }

    public static bool ValidateName(string name)
    {
        int letterCount = name.Count(char.IsLetter);
        return letterCount >= 3;
    }

    public static bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }
}