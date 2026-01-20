using BankingLogic;

Console.WriteLine("Willkommen zur Banking-App!");
Console.WriteLine("Bitte geben Sie die Kundendaten ein:");

Console.Write("Vorname: ");
string firstName = Console.ReadLine() ?? string.Empty;

Console.Write("Nachname: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.Write("E-Mail: ");
string email = Console.ReadLine() ?? string.Empty;

Console.Write("Telefonnummer: ");
string phoneNumber = Console.ReadLine() ?? string.Empty;

Customer customer = new Customer
{
    FirstName = firstName,
    LastName = lastName,
    Email = email,
    PhoneNumber = phoneNumber
};

Console.WriteLine("\nKunde erstellt:");
Console.WriteLine(customer.ToString());
