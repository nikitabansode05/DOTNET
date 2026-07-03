using System.Reflection;

public class LinkedList
{
    public Node head{get;set;}

    public LinkedList()
    {
        head=null;
    }
    public void insert(Customer data)
    {
        if (head == null)
        {
            head=new Node();
            head.data=data;
            head.next=null;
        }
        else
        {
            Node current=head;
            while (current.next!= null)
            {
                current=current.next;
            }
            Node newNode=new Node();
            newNode.data=data;
            newNode.next=null;
            current.next=newNode;
        }
    }

    public void update(Customer previousData,Customer updatedData)
    {
        Node current=head;
        while (current != null)
        {
            if (current.data == previousData)
            {
                current.data=updatedData;
            }
            current=current.next;
        }
    }

    public void delete(Customer data)
    {
        Node current=head;
        while (current.next!= null)
        {
            if (current.next.data == data)
            {
                current.next=current.next.next;
            }
            current=current.next;
        }
    }

    public void display()
    {
        Node currentCustomer=head;
        while (currentCustomer != null)
        {
            Console.WriteLine(currentCustomer.data);
            currentCustomer=currentCustomer.next;
        }
    }
}