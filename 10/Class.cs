using System;

namespace _10
{
    class Customer{
        public int memberSince;
        protected double price;
        public double discount;
        public Customer(int since, double total){
            memberSince = since;
            price = total;
        }
    }
    class nonMember : Customer{
        public nonMember(int year, double total):base(year, total){
        }
        public void calculateDiscount(){
            discount = (10/100)*100000;
        }
    }
}