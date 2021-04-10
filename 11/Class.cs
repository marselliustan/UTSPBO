using System;

namespace _11
{
    class Member
    {
        protected double fee;
        protected double pay;
        protected double discount;
        public int memberSince;
        public Member(int year, double total){
            //Console.WriteLine("This is constructor");
            fee = total;
            memberSince = year;
        }
        public void Pay(){
            int payment = 0;
            Console.WriteLine("===========================================================================");
            Console.Write("Input amount of money    : Rp.");
            double amount = Convert.ToDouble(Console.ReadLine());
            for(int i=0;i<10;i++){
                if(amount < pay){
                    Console.WriteLine("Sorry, your money is not enough");
                    Console.WriteLine("===============================");
                    Console.Write("Please enter the right amount of money    : Rp.");
                    amount = Convert.ToDouble(Console.ReadLine());
                }
                else{
                    Console.WriteLine("Change                                   : Rp. {0},00",(amount - pay));
                    payment = 1;
                    break;
                }
            }
            if(payment == 1){
                Console.WriteLine("====================");
                Console.WriteLine("Thank you! Have a nice day!");
            }
            else{
                Console.WriteLine("====================");
                Console.WriteLine("Please contact our manager");
            }
        }
        public void calculatePay(){
            pay = (fee - (discount*fee));
            Console.WriteLine("Total amount to be paid  : Rp. {0},00 - Rp. {1},00 = Rp. {2},00", fee, discount*fee, pay);
        }
    }
    class normalMember : Member
    {
        public normalMember(int a, int memberSince, double fee): base(memberSince, fee){
            Console.WriteLine("Hello customer no. {0}!", a);
            Console.WriteLine("==========================");
            Console.WriteLine("Member type              : normal member, since {0}", memberSince);
            Console.WriteLine("Total                    : Rp. {0},00", fee);
        }
        public void calculateDiscount(){
            int dif = 2021 - memberSince;
            discount = (0.1 + 0.01*dif);
            Console.WriteLine("Total discount           : {0} % x Rp. {1},00 = Rp. {2},00", discount*100, fee, discount*fee);
        }  
    }
    class VIPMember : Member
    {
        public VIPMember(int a, int memberSince, double fee): base(memberSince, fee){
            Console.WriteLine("Hello customer no. {0}!", a);
            Console.WriteLine("==========================");
            Console.WriteLine("Member type              : VIP member, since {0}", memberSince);
            Console.WriteLine("Total                    : Rp. {0},00", fee);
        }
        public void calculateDiscount(){
            int dif = 2021 - memberSince;
            discount = (0.15 + 0.015*dif);
            Console.WriteLine("Total discount           : {0} % x Rp. {1},00 = Rp. {2},00", discount*100, fee, discount*fee);
        }
        
        
    }
}