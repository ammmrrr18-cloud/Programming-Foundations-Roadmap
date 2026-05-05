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
	myLinkedList.InsertAtEnd(Item);
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


T GetItem(int index)
{
	return myLinkedList.GetItem(index);
}

void Reverse()
{
	myLinkedList.Reverse();
}

void UpdateItem(int index,T NewValue)
{
	myLinkedList.UpdateItem(index, NewValue);
}

void InsertAfter(int index, T NewValue)
{
	 myLinkedList.InsertAfter(index, NewValue);
}

void InsertAtFront(T Value)
{
	myLinkedList.InsertAtBeginning(Value);
}

void InsertAtBack(T Value)
{
	myLinkedList.InsertAtEnd(Value);
}

void Clear()
{
	myLinkedList.Clear();
}

};

