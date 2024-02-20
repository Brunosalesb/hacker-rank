static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
{
    while (node != null)
    {
        Console.Write(node.data);

        node = node.next;

        if (node != null)
        {
            Console.Write(sep);
        }
    }
}

static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
{
    if (head?.data == null)
    {
        var newNode = new SinglyLinkedListNode(data);
        head = newNode;
        return head;
    }

    AddNewNode(head, data);

    return head;
}

static void AddNewNode(SinglyLinkedListNode head, int data)
{
    if (head.next == null)
    {
        var newNode = new SinglyLinkedListNode(data);
        head.next = newNode;
    }
    else
    {
        AddNewNode(head.next, data);
    }
}


SinglyLinkedList llist = new SinglyLinkedList();

int llistCount = 5;
var list = new List<int>{141, 302, 164, 530, 474};

for (int i = 0; i < llistCount; i++)
{
    int llistItem = list[i];
    SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
    llist.head = llist_head;
}


PrintSinglyLinkedList(llist.head, "\n");


class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;

    public SinglyLinkedList()
    {
        this.head = null;
    }
}