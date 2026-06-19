namespace banking.service{
    public class Email:Notification{
        public void send(string message){
            Console.WriteLine("Email:"+message);
        }
    }
}