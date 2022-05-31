// See https://aka.ms/new-console-template for more information
LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
Console.WriteLine("Enter your choice\n1 - Adding to the list\n2 - To add and reverse the list\n3 - To insert a new node");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        linkedList.addNode(56);
        linkedList.addNode(30);
        linkedList.addNode(70);
        linkedList.Displaylist();
        break;
    case 2:
        linkedList.addNode(70);
        linkedList.addNode(30);
        linkedList.addNode(56);
        linkedList.ReverseList();
        linkedList.Displaylist();
        break;
    case 3:
        linkedList.addNode(56);
        linkedList.addNode(70);
        linkedList.Displaylist();
        linkedList.InsertNewNode(0, 30);
        linkedList.Displaylist();
        break;
}




