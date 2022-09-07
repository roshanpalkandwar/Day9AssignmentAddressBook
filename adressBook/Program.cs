namespace adressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("welecome to adress book ");
            AddressBook addressBook = new AddressBook();

            addressBook.AddContact("Roshan", "Palkandwar", "Age-25 ", "Wardha", "Maharashtra", 442001, 9823760189, "roshanPalkandwar@gmail.com");
            
            
             addressBook.AddContact("prasad", "patare", "Age-23", "amrawati", "maharashtra", 453326, 9845783465, "prasadpatare@gmail.com");
            
            addressBook.ViewContact();
            

        }
    }
}