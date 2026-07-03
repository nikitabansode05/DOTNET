public class UImanager
{

    public void showMenu()
    {
        Console.WriteLine("1)Add new customer");
        Console.WriteLine("2)Update customer");
        Console.WriteLine("3)Delete customer");
        Console.WriteLine("4)Display customer");
    }

    public int getChoice()
    {
        Console.WriteLine("Enter your choice : ");
        int choice=int.Parse(Console.ReadLine());

        return choice;
    }
    public Customer getdata()
    {
        Console.WriteLine("Enter the id : ");
        int id=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name : ");
        string name=Console.ReadLine();

        Console.WriteLine("Enter the policy type : ");
        string policy=Console.ReadLine();

        Console.WriteLine("Enter the premium : ");
        double premium=double.Parse(Console.ReadLine()); 

        Customer newCustomer=new Customer(id,name,policy,premium);

        return newCustomer;
    }
}