using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Counter
{
    class Link_Hash
    {
        Random random = new Random();
        /// <summary>
        /// 
        /// </summary>
        static public int INPUT = int.Parse(Console.ReadLine());
        public Node[] hashTable = new Node[INPUT];
        Node node = null;
        public void Hash_Chaining()
        {
            int input1 = random.Next(), input2 = random.Next();
            Node myNode = new Node((input1 % 90000) + 10000, input2 % 1000000);
            int index = ( input1 % 900 + 100 ) % INPUT;
            if (hashTable[index] == null)
            {
                hashTable[index] = myNode;
            }
            else
            {
                node = hashTable[index];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = myNode;
            }
        }
        public void Traverse()
        {
            for (int index = 0 ; index < INPUT ; index++ )
            {
                    node = hashTable[index];
                    while (node != null)
                    {
                        Console.Write("| account number : " + node.accountNumber + " Bank balance :"+node.bankBalance+" |->");
                        node = node.next;
                    }
               Console.WriteLine("null");
            }
        }
        public void Bank()
        {
            for (int index = 0; index < INPUT; index++)
            {
                node = hashTable[index];
                while (node.next != null)
                {
                    Transaction();
                    node = node.next;
                }
                Transaction();
            }
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
