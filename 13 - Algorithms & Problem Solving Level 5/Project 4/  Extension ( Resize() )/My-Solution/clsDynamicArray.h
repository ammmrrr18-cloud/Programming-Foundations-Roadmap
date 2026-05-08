#pragma once

#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
protected:
	int _Size = 0;

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



	bool Resize(int size)
	{
		if (size < 0)
			return false;

		if (size == _Size)
			return true;

	
		T* TempArray = new T[size];

		int NumberOfItemsToCopy = (size < _Size ? size : _Size);

		for (int i = 0;i < NumberOfItemsToCopy;i++)
		{
			TempArray[i] = OriginalArray[i];
		}

		delete [] OriginalArray;
		OriginalArray = TempArray;
		_Size = size;

		return true;
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

