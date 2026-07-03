public class Router
{
    LinkedList list=new LinkedList();
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
                        Console.WriteLine("Enter the data which is to be replaced : ");
                        Customer old=ui.getdata();
                        Console.WriteLine("Enter the data to replaced by : ");
                        customer=ui.getdata();
                        list.update(old,customer);
                    }
              
                break;

                case 3:
                    {
                        customer=ui.getdata();
                        list.delete(customer);
                    }
               
                break;

                case 4:
                    list.display();
                break;

                default:
                Console.WriteLine("Byeeee");
                break;
            }
        }while(choice !=7);
    }
}