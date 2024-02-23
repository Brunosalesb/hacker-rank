// static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
// {
//     while (node != null)
//     {
//         Console.Write(node.data);
//
//         node = node.next;
//
//         if (node != null)
//         {
//             Console.Write(sep);
//         }
//     }
// }
//
// // Complete the insertNodeAtHead function below.
//
// /*
//  * For your reference:
//  *
//  * SinglyLinkedListNode {
//  *     int data;
//  *     SinglyLinkedListNode next;
//  * }
//  *
//  */
// static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data) {
//     var newNode = new SinglyLinkedListNode(data);
//     if (llist != null) {
//         newNode.next = llist;
//     }
//     return newNode;
// }
//
// SinglyLinkedList llist = new SinglyLinkedList();
//
// int llistCount = 5;
// var list = new List<int>{141, 302, 164, 530, 474};
//
// for (int i = 0; i < llistCount; i++)
// {
//     int llistItem = list[i];
//     SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
//     llist.head = llist_head;
// }
//
//
// PrintSinglyLinkedList(llist.head, "\n");
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
// }