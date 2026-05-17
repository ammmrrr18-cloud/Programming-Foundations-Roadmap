#pragma once

#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
protected:
	int _Size = 0;
	T* _TempArray;
public:

	T* OriginalArray;

	clsDynamicArray(int size=0)
	{

		if (size < 0)
			size = 0;

		_Size = size;

		OriginalArray = new T[_Size];
	}


	~clsDynamicArray()
	{
		delete[]OriginalArray;
		OriginalArray = NULL;
	}

	bool SetItem(int index,T item)
	{
		if (index >= _Size || index < 0)
		{
			return false;
		}

		//OrigenalArray[index] = item;
		*(OriginalArray + index) = item;

		return true;
	}

	bool IsEmpty()
	{
		return !_Size;
	}

	int Size()
	{
		return _Size;
	}

	void Resize(int NewSize)
	{
		if (NewSize < 0)
			_Size = 0;

		if (NewSize == _Size)
			return;

		
		_TempArray = new T[NewSize];
		
		if (NewSize < _Size)
			_Size = NewSize;

		for (int i = 0;i < _Size;i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		_Size = NewSize;

		delete[]OriginalArray;
		OriginalArray = _TempArray;

	}

	T GetItem(int index)
	{

		if (index < 0 || index >= _Size|| IsEmpty())
			return T();

		return OriginalArray[index];
	}

	void Reverse()
	{
		if (IsEmpty())return;


		T* _TempArray = new T[_Size];

		for (int i = 0;i < _Size;i++)
		{
			_TempArray[_Size - 1 - i] = OriginalArray[i];
		}

		delete [] OriginalArray;

		OriginalArray = _TempArray;
	}

	void ClearZero()
	{
		_Size = 0;
		_TempArray = new T[0];
		delete[]OriginalArray;
		OriginalArray = _TempArray;
	}

	void ClearNULL()
	{
		delete[] OriginalArray;
		OriginalArray = NULL;
		_Size = 0;
	}

	void PrintList()
	{
		for (int i = 0;i < _Size;i++)
		{
			//cout << OrigenalArray[i] << " ";
			cout << *(OriginalArray + i) << " ";
		}

		cout << "\n";
	}

	bool DeleteItemAt(int index)
	{
		if (IsEmpty() || index < 0 || index >= _Size)
			return false;

		_Size--;

		_TempArray = new T[_Size];

		for (int i = 0;i < index;i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		for (int i = index + 1;i < _Size + 1;i++)
		{
			_TempArray[i - 1] = OriginalArray[i];
		}

		delete[]OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}

	bool DeleteFirstItem()
	{
	
		return DeleteItemAt(0);
	}

	bool DeleteLastItem()
	{
		
		return DeleteItemAt(_Size - 1);
	}


	int Find(T value)
	{

		for (int i = 0;i < _Size;i++)
		{
			if (OriginalArray[i] == value)
			{
				return i;
			}
		}

		return -1;
	}

	bool DeleteItem(T value)
	{
		int index = Find(value);

		if (index == -1)
			return false;

		DeleteItemAt(index);
		return true;
	}

	bool InsertAt(int index, T item)
	{
	
		if (index < 0 || index > _Size)
			return false;
		
		_Size++;
		_TempArray = new T[_Size];

	
		for (int i = 0;i < index;i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		_TempArray[index] = item;
		
		for (int i = index;i < _Size-1;i++)
		{
			_TempArray[i + 1] = OriginalArray[i];
		}

		delete[]OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}


	bool InsertAtBeginning(T item)
	{
		return InsertAt(0, item);
	}

	bool InsertBefore(int index, T item)
	{
	// This function relies on the boundary checks in InsertAt().
	// If (index - 1) is invalid (e.g., index is 0 or less), 
	// InsertAt will safely return false.
		
		return InsertAt(index - 1, item);
	}


	bool InsertAfter(int index, T item)
	{
	// Redirects to InsertAt with (index + 1).
	// Range validation is handled by InsertAt; if (index + 1) 
	// exceeds current array boundaries, it returns false.

		return InsertAt(index + 1, item);
	}


	bool InsertAtEnd(T item)
	{
		return InsertAt(_Size, item);
	}

};



