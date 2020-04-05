﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Counter
{
    class Queue
    {
        public Node headNode = null;
        public Node node = null;
        /// <summary>
        /// New node get added in the list
        /// </summary>
        public void LinkList()
        {
            Random random = new Random();
            int input1 = random.Next(), input2 = random.Next();
            Node myNode = new Node((input1 % 90000) + 10000, input2 % 1000000);
            if (headNode == null)
            {
                headNode = myNode;
            }
            else
            {
                node = headNode;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = myNode;
            }
        }
        /// <summary>
        /// Printing the list asper Queue order
        /// </summary>
        public void Print()
        {
            node = headNode;
            Console.WriteLine("Users in Queue");
            while (node.next != null)
            {
                Console.WriteLine("Account Number : " + node.accountNumber + " and Bank Balance : " + node.bankBalance);
                node = node.next;
            }
            Console.WriteLine("Account Number : " + node.accountNumber + " and Bank Balance : " + node.bankBalance);
        }
    }
}