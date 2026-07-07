public class DNode<T>
{
    public T data;
    public DNode<T> next;
    public DNode<T> previous;

    public DNode(){}

    public DNode(T data)
    {
        this.data=data;
    }

}