// See https://aka.ms/new-console-template for more information
LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
int yes = 1;
while (yes == 1)
{
    Console.WriteLine("Enter your choice\n1 - Adding to the list\n2 - To add and reverse the list\n3 - To insert a new node\n" +
        "4 - To Delete First Node\n5 - To Delete the Last Node\n6 - To sSearch for a data in the list\n");
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
        case 4:
            linkedList.Pop();
            linkedList.Displaylist();
            break;
        case 5:
            linkedList.PopLast();
            linkedList.Displaylist();
            break;
        case 6:
            int result = linkedList.Search(30);
            Console.WriteLine("Match Found at position: "+result);
            break;
            
    }
    Console.WriteLine("Press 1 to continue selecting functions....");
    yes = Convert.ToInt32(Console.ReadLine());
}



