public class Node
{
    public Customer data{get;set;}
    public Node next{get;set;}

    public Node(){}

    public Node(Customer data)
    {
        this.data=data;
    }
}