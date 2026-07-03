public class Customer{
    public int id{get;set;}
    public string name{get;set;}
    public string policyType{get;set;}
    public double premium{get;set;}

    public Customer(){}

    public Customer(int id,string name,string policyType,double premium){
        this.id=id;
        this.name=name;
        this.policyType=policyType;
        this.premium=premium;
    }
}