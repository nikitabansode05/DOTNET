using System.Reflection;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T>:IEnumerable<T>
{
    public Node<T> head{get;set;}

    public LinkedList()
    {
        head=null;
    }
    public void insert(T data)
    {
        if (head == null)
        {
            head=new Node<T>();
            head.data=data;
            head.next=null;
        }
        else
        {
            Node<T> current=head;
            while (current.next!= null)
            {
                current=current.next;
            }
            Node<T> newNode=new Node<T>();
            newNode.data=data;
            newNode.next=null;
            current.next=newNode;
        }
    }

    // public void update(T currentData,T updatedData)
    // {
    //     Node<T> current=head;
    //     while (current != null)
    //     {
    //         if (EqualityComparer<T>.Default.Equals(current.data, currentData))
    //         {
    //             current.data=updatedData;
    //             break;
    //         }
    //         current=current.next;
    //     }
    // }

    public void update(T oldData, T newData)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.data.Equals(oldData))
            {
                current.data = newData;
                break;
            }
            current = current.next;
        }
    }


    public void delete(T data)
    {
       
        if (head == null)
        {
            return;
        }
        else if (head.data.Equals(data))
        {
            head=head.next;
            return;
        }
        Node<T> current=head;
        while (current.next!= null)
        {
            //if (EqualityComparer<T>.Default.Equals(current.next.data, data))
            if(current.next.data.Equals(data))
            {
                current.next=current.next.next;
                return;
            }
            current=current.next;
        }
    }

    public void display()
    {
        Node<T> currentCustomer=head;
        while (currentCustomer != null)
        {
            Console.WriteLine(currentCustomer.data);
            currentCustomer=currentCustomer.next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = head;

        while (current != null)
        {
            yield return current.data;
            current = current.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}