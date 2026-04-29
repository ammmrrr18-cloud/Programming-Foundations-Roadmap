#pragma once
#include <iostream>
#include <string>
#include "clsNode.h"


using namespace std;

template <typename T>
class clsDblLinkedList
{

private:

	clsNode <T>* _Head = NULL;

public:

	bool IsEmpty()
	{
		return (_Head == NULL);
	}

	void InsertAtBeginning(T Num)
	{

		clsNode <T>* NewNode = new clsNode<T>();


		NewNode->vaLue = Num;
		NewNode->Next = _Head;
		NewNode->Prev = NULL;

		if (_Head != NULL)
		{
			_Head->Prev = NewNode;
		}

		_Head = NewNode;
	}

	clsNode <T>* Find(T Num)
	{


		clsNode <T>* Current = _Head;

		while (Current != NULL && Current->vaLue != Num)
		{
			Current = Current->Next;
		}


		return Current;

	}


	void InsertAfter(clsNode <T>* N1, T Num)
	{
		if (N1 == NULL)
			return;

		clsNode<T>* NewNode = new clsNode<T>();


		NewNode->vaLue = Num;
		NewNode->Next = N1->Next;
		NewNode->Prev = N1;

		if (N1->Next != NULL)
		{
			N1->Next->Prev = NewNode;
		}

		N1->Next = NewNode;

	}


	void InsertAtEnd(T Num)
	{
		clsNode <T>* NewNode = new clsNode<T>();
		NewNode->vaLue = Num;
		NewNode->Next = NULL;

		if (_Head == NULL)
		{
			NewNode->Prev = NULL;
			_Head = NewNode;
			return;
		}

		clsNode<T>* Current = _Head;

		while (Current->Next != NULL)
		{
			Current = Current->Next;
		}

		NewNode->Prev = Current;
		Current->Next = NewNode;
	}


	void DeleteNode(clsNode <T>* N1)
	{
		if (IsEmpty() || N1 == NULL)
			return;


		if (_Head == N1)
			_Head = _Head->Next;


		if (N1->Next != NULL)
		{
			N1->Next->Prev = N1->Prev;
		}
			
		if (N1->Prev != NULL)
		{
			N1->Prev->Next = N1->Next;
		}


		delete N1;
	}


	void DeleteFirstNode()
	{
		if (IsEmpty())
			return;


		clsNode<T>* Current = _Head;

		_Head = _Head->Next;

		if (_Head != NULL)
		{
			_Head->Prev = NULL;
		}
		

		delete Current;
	}

	void DeleteLastNode()
	{
		if (IsEmpty())
			return;

		clsNode <T>* Current = _Head;

		if (_Head->Next == NULL)
		{
			_Head = NULL;
			delete Current;
			return;
		}


		while (Current->Next->Next != NULL)
		{
			Current = Current->Next;
		}

		Current = Current->Next;
		Current->Prev->Next = NULL;

		delete Current;
	}


	void PrintList()
	{

		clsNode<T>* Current = _Head;

		while (Current != NULL)
		{
			cout << Current->vaLue << " ";
			Current = Current->Next;
		}

	
	}



};

