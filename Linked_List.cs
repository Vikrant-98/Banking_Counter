using System;

namespace Banking_Counter
{
    class Linked_List
    {
        static void Main(string[] args)
        {
            List link = new List();
            Console.WriteLine("How Many User you want ");
            int user = int.Parse(Console.ReadLine());
            for(int index = 0 ; index < user ; index++)
            { 
                link.LinkList();
            }
            link.Bank();
        }
    }
    /// <Node_Created>
    /// local input as data in constructor  
    /// </Node_Created>
    class Node
    {
        public int accountNumber,bankBalance;
        public Node next;
        /// <Node>
        /// Node get Created along with two parameters and link to another node
        /// </Node>
        /// <param accountNumber="input1"></param>
        /// <param bankBalance="input2"></param>
        public Node(int input1,int input2)
        {
            accountNumber = input1;
            bankBalance = input2;
            next = null;
        }
    }
    class List : Stack
    {
        /// <summary>
        /// Process of treversing the linklist as Queue
        /// Here Transaction function called to perform Trancacton on account
        /// </summary>
        public void Bank()
        {
            node = headNode;
            while (node.next != null)
            {
                Transaction();
                node = node.next;
            }
            Transaction();
        }
        /// <summary>
        /// Local amount is declared for input
        /// Checking about the amount is valid to widthdraw
        /// </summary>
        public void Withdraw()                                                  
        {
            Console.WriteLine("Enter amount want to withdraw :");
            int amount = int.Parse(Console.ReadLine());                         
            if (node.bankBalance - amount > 0)
            {
                node.bankBalance = node.bankBalance - amount;
                Console.WriteLine("Your balance is :" + node.bankBalance);
            }
            else
            {
                Console.WriteLine("You can't withdraw " + amount + " amount\nYour balance is :" + node.bankBalance);
            }
        }
        /// <summary>
        /// Local amount is declared for input
        /// Checking about the amount is valid to widthdraw
        /// </summary>
        public void Deposit()                                                   
        {
            Console.WriteLine("Enter amount want to deposit :");
            int amount = int.Parse(Console.ReadLine());
            if (amount > 0)                                                     
            {
                node.bankBalance = node.bankBalance + amount;
            }
            else
            {
                Console.WriteLine("Enter valid amount");
            }
        }
        /// <summary>
        /// Showing the balance of the user
        /// Local choice declare to get the input for user to continue teh task
        /// Withdraw and Deposit functions called in operation
        /// </summary>
        public void Transaction()
        {
            Console.WriteLine("Users account number is :" + node.accountNumber);
            Console.WriteLine("Users balance is " + node.bankBalance);
            Console.WriteLine("1).For Withdraw\n2).For Deposit");
            int choice1 = 0;
            while (choice1 == 0)                                                                
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Withdraw();                                                           
                        break;
                    case 2:
                        Deposit();                                                            
                        break;
                    default:
                        Console.WriteLine("No match found");
                        break;
                }
                Console.WriteLine("Press 0 For continue your transaction or any number to exit:");       
                choice1 = int.Parse(Console.ReadLine());
            }
        }
    }
}