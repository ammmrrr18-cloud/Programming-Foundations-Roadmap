#pragma once

#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
private:
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

