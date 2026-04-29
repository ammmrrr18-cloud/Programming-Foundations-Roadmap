
#include <iostream>
#include "clsDblLinkedList.h"
#include "clsNode.h"

using namespace std;

int main()
{
    
    clsDblLinkedList <int> DblLinkedList;

    DblLinkedList.InsertAtBeginning(10);
    DblLinkedList.InsertAtBeginning(20);
    DblLinkedList.InsertAtBeginning(30);
    DblLinkedList.InsertAtBeginning(40);
    DblLinkedList.InsertAtBeginning(50);
    DblLinkedList.InsertAtBeginning(60);


    cout << "\nPrint Linked Content\n";
    DblLinkedList.PrintList();


    clsNode<int>* N1 = DblLinkedList.Find(20);

    if (N1 != NULL)
    {
        cout << "\n\nNode with value 20 is found\n";
    }
    else
    {
        cout << "\n\nNode with value 20 is Not found\n";
    }


    DblLinkedList.InsertAfter(N1, 500);
    cout << "\n\nInserting 500 after 20\n\n";
    DblLinkedList.PrintList();


    clsNode<int>* DeletedNode = DblLinkedList.Find(40);
    DblLinkedList.DeleteNode(DeletedNode);
    cout << "\n\nAfter deleting 40\n";
    DblLinkedList.PrintList();


    DblLinkedList.DeleteFirstNode();
    cout << "\n\nAfter deleting first node\n";
    DblLinkedList.PrintList();


    DblLinkedList.DeleteLastNode();
    cout << "\n\nAfter deleting Last node\n";
    DblLinkedList.PrintList();



}

