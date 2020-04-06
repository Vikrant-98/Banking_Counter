using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Counter
{
    class Queue
    {
        public Node headNode = null;
        public Node node = null;
        /// <summary>
        /// Node get added in the list and used it as Queue
        /// Random object assigning value to accoutn number and bank balance (5 Digits)
        /// Local variables input1 and input2 is used to store the account number and bank balance
        /// </summary>
        public void LinkList()
        {
            Random random = new Random();
            int input1 = random.Next(), input2 = random.Next();
            Node myNode = new Node((input1 % 90000) + 10000, input2 % 1000000);
            if (headNode == null)
            {
                headNode = myNode;
                Console.WriteLine("Account Number : " + headNode.accountNumber + " and Bank Balance : " + headNode.bankBalance);
            }
            else
            {
                node = headNode;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = myNode;
                Console.WriteLine("Account Number : " + node.accountNumber + " and Bank Balance : " + node.bankBalance);
            }
        }
    }
}
