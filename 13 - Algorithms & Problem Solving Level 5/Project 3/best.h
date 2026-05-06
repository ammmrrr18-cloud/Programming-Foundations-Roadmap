#pragma once
#include "clsMyQueue.h"

template<typename T>
/**
 * Changed inheritance to 'protected' to hide clsMyQueue methods (like front/back) from the main function.
 * This ensures the user can only access the specific Stack methods defined in the public section below.
 */
class clsMyStack : protected clsMyQueue<T>
{
public:

	void push(T Item)
	{
		// Accessing the protected list from the parent class using 'this'
		this->_MyList.InsertAtBeginning(Item);
	}

	T Top()
	{
		// Wrapping the parent's front() method to match Stack terminology
		return this->front();
	}

	T Bottom()
	{
		// Wrapping the parent's back() method to match Stack terminology
		return this->back();
	}

	/**
	 * Note: Methods like Size(), IsEmpty(), etc., from clsMyQueue are now protected.
	 * If you want the user to see them in the main, you must 're-expose' them here.
	 */
};
