#pragma once
#include <iostream>
#include "clsDblLinkedList.h"

template<typename T>
class clsMyQueue
{

protected:

	clsDblLinkedList<T>myLinkedList;


public:

void push(T Item)
{
	myLinkedList.InsertAtEnd(value);
};

void pop()
{
	if (myLinkedList.IsEmpty())return;
	myLinkedList.DeleteFirstNode();
}

T front()
{
	return myLinkedList.GetFirstItem();
}

T back()
{
	return myLinkedList.GetLastItem();
}

int Size()
{
	return myLinkedList.Size();
}

void Print()
{
	myLinkedList.PrintList();
}


};

