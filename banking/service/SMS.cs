namespace banking.service{
    public class SMS:Notification{
        public void send(string message){
            Console.WriteLine("SMS:"+message);
        }
    }
}