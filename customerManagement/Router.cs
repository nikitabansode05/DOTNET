public class Router
{
    LinkedList<Customer> list=new LinkedList<Customer>();
    UImanager ui=new UImanager();
    Customer customer=new Customer();
    int choice=0;
    public void route()
    {
        do
        {
            ui.showMenu();
            choice=ui.getChoice();
            switch (choice)
            {
                case 1:
                    {
                        customer=ui.getdata();
                        list.insert(customer);
                    }
                
                break;

                case 2:
                    {
                        Console.WriteLine("Enter the customer to replaced : ");
                        Customer previouscustomer=ui.getdata();
                        Console.WriteLine("Enter the customer to replaced by : ");
                        customer=ui.getdata();
                        list.update(previouscustomer,customer);
                    }
              
                break;

                case 3:
                    {
                        Console.WriteLine("Enter the customer delete : ");
                        Customer previouscustomer=ui.getdata();
                        list.delete(previouscustomer);
                    }
               
                break;

                case 4:
                    list.display();
                break;

                default:
                Console.WriteLine("Byeeee");
                break;
            }
        }while(choice !=5);
    }
}