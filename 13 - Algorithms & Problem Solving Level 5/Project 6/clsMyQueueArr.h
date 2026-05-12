#pragma once
#include"clsDynamicArray.h"


template <typename T>
class clsMyQueueArr
{
protected:

	clsDynamicArray <T> _MyList;

public:

	void push(T Item)
	{
		_MyList.InsertAtEnd(Item);
	}

	void Print()
	{
		_MyList.PrintList();
	}

	int Size()
	{
		return _MyList.Size();
	}

	T front()
	{
		return _MyList.GetItem(0);
	}

	T back()
	{
		return _MyList.GetItem(Size() - 1);
	}

	void pop()
	{
	  _MyList.DeleteFirstItem();
	}

	T GetItem(int index)
	{
		return _MyList.GetItem(index);
	}
	

	void Reverse()
	{
		_MyList.Reverse();
	}

	bool UpdateItem(int index, T item)
	{
		return _MyList.SetItem(index, item);
	}

	bool InsertAfter(int index, T item)
	{
		return _MyList.InsertAfter(index, item);
	}

	bool InsertAtFront(T item)
	{
		return _MyList.InsertAt(0, item);
	}


	bool InsertAtBack(T item)
	{
		return _MyList.InsertAt(Size(), item);
	}

	void Clear()
	{
		_MyList.Clear();
	}

};

