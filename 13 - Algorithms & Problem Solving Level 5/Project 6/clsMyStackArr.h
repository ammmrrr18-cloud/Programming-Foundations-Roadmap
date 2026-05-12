#pragma once
#include "clsMyQueueArr.h"

template<typename T>
class clsMyStackArr :public clsMyQueueArr<T>
{
public:

	// Using this


	void push(T item)
	{
		this->InsertAtFront(item);
	}

	T Top()
	{
		return this->front();
	}

	T Bottom()
	{
		return this->back();
	}


	// Using clsMyQueueArr<T>::

	//void push(T item)
	//{
	//	clsMyQueueArr<T>::_MyList.InsertAtBeginning(item);
	//}

	//T Top()
	//{
	//	return clsMyQueueArr<T>::front();
	//}

	//T Bottom()
	//{
	//	return clsMyQueueArr<T>::back();
	//}



};

