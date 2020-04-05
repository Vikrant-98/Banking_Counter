using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Counter
{
    class Stack
    {
        public Node headNode = null;
        public Node node = null;
        /// <summary>
        /// New node get added in the list and use it as Stack
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
                node = myNode;
                node.next = headNode;
                headNode = node;
                Console.WriteLine("Account Number : " + headNode.accountNumber + " and Bank Balance : " + headNode.bankBalance);
            }
        }
    }
}
