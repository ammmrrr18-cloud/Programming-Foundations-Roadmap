#pragma once
#include "clsMyQueue.h"

template<typename T>
class clsMyStack
{

protected:

	clsMyQueue <T> _Queue;

public:


void push(T item)
{
	_Queue.InsertAtFront(item);
}

void Print()
{
	_Queue.Print();
}

int Size()
{
	return _Queue.Size();
}

T Top()
{
	return _Queue.front();
}

T Bottom()
{
	return _Queue.back();
}

void pop()
{
	_Queue.pop();
}

T GetItem(int index)
{
	return _Queue.GetItem(index);
}

void Reverse()
{
	_Queue.Reverse();
}

void UpdateItem(int index,T NewValue)
{
	_Queue.UpdateItem(index, NewValue);
}

void InsertAfter(int index, T NewValue)
{
	_Queue.InsertAfter(index, NewValue);
}

void InsertAtFront(T Value)
{
	_Queue.InsertAtFront(Value);
}

void InsertAtBack(T Value)
{
	_Queue.InsertAtBack(Value);
}

void Clear()
{
	_Queue.Clear();
}

};

