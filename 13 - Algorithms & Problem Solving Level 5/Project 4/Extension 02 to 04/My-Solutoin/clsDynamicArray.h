#pragma once

#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
protected:
	int _Size = 0;
	T* TempArray;
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

		
		TempArray = new T[NewSize];
		
		if (NewSize < _Size)
			_Size = NewSize;

		for (int i = 0;i < _Size;i++)
		{
			TempArray[i] = OriginalArray[i];
		}

		_Size = NewSize;

		delete[]OriginalArray;
		OriginalArray = TempArray;

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


		T* Array = new T[_Size];

		for (int i = 0;i < _Size;i++)
		{
			Array[_Size - 1 - i] = OriginalArray[i];
		}

		delete [] OriginalArray;

		OriginalArray = Array;
	}


	void Clear()
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




};

