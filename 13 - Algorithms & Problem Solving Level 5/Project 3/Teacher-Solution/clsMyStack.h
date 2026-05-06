#pragma once
#include "clsMyQueue.h"

template<typename T>
class clsMyStack :public clsMyQueue<T>
{
public:

	void push(T Item)
	{
		clsMyQueue <T>::_MyList.InsertAtBeginning(Item);
	}

	T Top()
	{
		return clsMyQueue <T>::front();

	}

	T Bottom()
	{
		return clsMyQueue <T>::back();

	}


};




// use (this) is better

#pragma once
#include "clsMyQueue.h"

template<typename T>
class clsMyStack :public clsMyQueue<T>
{
public:

	void push(T Item)
	{
		//clsMyQueue <T>::_MyList.InsertAtBeginning(Item);
		this->_MyList.InsertAtBeginning(Item);
	}

	T Top()
	{
		//return clsMyQueue <T>::front();
		return	this->front();

	}

	T Bottom()
	{
		//return clsMyQueue <T>::back();,
		return this->back();

	}


};


