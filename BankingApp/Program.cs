using BankingLogic;

Console.WriteLine("Willkommen zur Banking-App!");
Console.WriteLine("Bitte geben Sie die Kundendaten ein:");

string firstName = "";
while (true)
{
    Console.Write("Vorname: ");
    firstName = Console.ReadLine() ?? string.Empty;
    if (!Customer.ValidateName(firstName))
    {
        Console.WriteLine("Fehler: Der Vorname muss mindestens 3 Buchstaben enthalten.");
    }
    else
    {
        break;
    }
}

string lastName = "";
while (true)
{
    Console.Write("Nachname: ");
    lastName = Console.ReadLine() ?? string.Empty;
    if (!Customer.ValidateName(lastName))
    {
        Console.WriteLine("Fehler: Der Nachname muss mindestens 3 Buchstaben enthalten.");
    }
    else
    {
        break;
    }
}

string email = "";
while (true)
{
    Console.Write("E-Mail: ");
    email = Console.ReadLine() ?? string.Empty;
    if (!Customer.ValidateEmail(email))
    {
        Console.WriteLine("Fehler: Die E-Mail-Adresse muss ein \"@\" enthalten.");
    }
    else
    {
        break;
    }
}

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
