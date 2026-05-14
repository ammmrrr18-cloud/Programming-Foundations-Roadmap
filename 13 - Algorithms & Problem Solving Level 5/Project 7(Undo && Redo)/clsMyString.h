#pragma once

#include <stack>

using namespace std;

class clsMyString
{
private:

	string _value;
	stack<string>_Undo;
	stack<string>_Redo;

public:


	void Set(string value)
	{
		_Undo.push(_value);
		_value = value;
	}

	string Get()
	{
		return _value;
	}


	__declspec(property(get = Get, put = Set)) string Value;


	void Undo()
	{
		if (!_Undo.empty())
		{
			_Redo.push(_value);
			_value = _Undo.top();
			_Undo.pop();
		}
	}


	void Redo()
	{
		if (!_Redo.empty())
		{
			_Undo.push(_value);
			_value = _Redo.top();
			_Redo.pop();
		}

	}

};




