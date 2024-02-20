// static void PrintLinkedList(SinglyLinkedListNode head)
// {
//     Print(head);
// }
//
// static void Print(SinglyLinkedListNode head)
// {
//     Console.WriteLine(head.data);
//     if (head.next is not null)
//         Print(head.next);
// }
//
// SinglyLinkedList llist = new SinglyLinkedList();
//
// int llistCount = 3;
//
// for (int i = 0; i < llistCount; i++)
// {
//     int llistItem = 3;
//     llist.InsertNode(llistItem);
// }
//
// PrintLinkedList(llist.head);
//
// class SinglyLinkedListNode
// {
//     public int data;
//     public SinglyLinkedListNode next;
//
//     public SinglyLinkedListNode(int nodeData)
//     {
//         this.data = nodeData;
//         this.next = null;
//     }
// }
//
// class SinglyLinkedList
// {
//     public SinglyLinkedListNode head;
//     public SinglyLinkedListNode tail;
//
//     public SinglyLinkedList()
//     {
//         this.head = null;
//         this.tail = null;
//     }
//
//     public void InsertNode(int nodeData)
//     {
//         SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);
//
//         if (this.head == null)
//         {
//             this.head = node;
//         }
//         else
//         {
//             this.tail.next = node;
//         }
//
//         this.tail = node;
//     }
// }