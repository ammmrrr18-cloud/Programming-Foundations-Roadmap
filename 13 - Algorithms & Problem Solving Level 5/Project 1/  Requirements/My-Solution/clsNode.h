#pragma once

template<typename T>
class clsNode
{

public:

	T vaLue;
	clsNode <T> * Next = NULL;
	clsNode <T>* Prev = NULL;


};

