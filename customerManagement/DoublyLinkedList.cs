using System.Collections.Generic;
using System.Collections;
using System.Reflection;


public class DoublyLinkedList<T>:IEnumerable<T>
{
    public DNode<T> head{get;set;}
    public DNode<T> tail{get;set;}

    public void insertfromFront(T data)
    {
        if (head == null)
        {
            head = new DNode<T>();
            head.data=data;
            head.next=null;
            head.previous=null;
            tail=head;
        }
        else
        {
            DNode<T> newNode=new DNode<T>();
            
            newNode.data=data;
            newNode.next=head;
            newNode.previous=null;
            head.previous=newNode;
            head=newNode;
            DNode<T> current=head;
            while (current != null)
            {
                if (current.next == null)
                {
                    tail=current;
                    break;
                }
                current=current.next;
            }
        }
    }

     public void delete(T data)
    {
        if (data.Equals(head.data))
        {
            head=head.next;
            head.previous=null;
        }
        else{
            DNode<T> current=head;
            while (current != null)
            {
                if (current.data.Equals(data))
                {
                    if(current.next == null)
                    {
                        current.previous.next=null;
                        break;
                    }
                    else
                    {
                        current.previous.next=current.next;
                        current.next.previous=current.previous;
                        break;
                    }
                    
                }                
                current=current.next;
            }
        }

    }

    public void update(T previousData,T newData)
    {
        DNode<T> current=head;
        while (current != null)
        {
            if (current.data.Equals(previousData))
            {
                current.data=newData;
                break;
            }
            current=current.next;
        }
    }

    public void insertfromBack(T data)
    {
        if (head == null)
        {
            head = new DNode<T>();
            head.data=data;
            head.next=null;
            head.previous=null;
            tail=head;
        }
        else
        {
            DNode<T> newNode=new DNode<T>();
            newNode.data=data;
            DNode<T> current=head;
            while (current.next != null)
            {
                current=current.next;
            }
            current.next=newNode;
            newNode.previous=current;
            newNode.next=null;
            tail=newNode;
        }
    } 

    public void displayfromFront()
    {
        DNode<T> current=head;
        Console.WriteLine("Displaying from front");
        while (current != null)
        {
            Console.Write(current.data+"->");
            current=current.next;
        }
        Console.WriteLine();
    }

    public void displayfromBack()
    {
        DNode<T> current=tail;
        Console.WriteLine("Displaying from back");
        while (current!= null)
        {
            Console.Write(current.data+"->");
            current=current.previous;
        }
        Console.WriteLine();
    }

    public IEnumerator<T> GetEnumerator()
    {
        DNode<T> current=head;
        while (current != null)
        {
            yield return current.data;
            current=current.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}