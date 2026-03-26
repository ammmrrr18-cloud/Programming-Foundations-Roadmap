#pragma once
#include"clsDate.h"
#include <iostream>
#include <string>
#include <limits>

class clsInputValidateT
{
public:

template <typename T>
static bool IsNumberBetween(T Num, T From, T To)
{
	return (Num >= From && Num <= To);
}

// My version using CompareDates: faster, shorter, and clearer logic
		// ; avoids multiple function calls and repeated conditions, easier to maintain and read

static bool IsDateBetween(clsDate Date, clsDate FromDate, clsDate ToDate)
		{

			if (clsDate::CompareDates(Date, FromDate) == clsDate::Equal || clsDate::CompareDates(Date, ToDate) == clsDate::Equal)
				return true;
			if (clsDate::CompareDates(Date, FromDate) == clsDate::After && clsDate::CompareDates(Date, ToDate) == clsDate::Before)
				return true;
			if (clsDate::CompareDates(Date, FromDate) == clsDate::Before && clsDate::CompareDates(Date, ToDate) == clsDate::After)
				return true;


			return false;
		}

// Professor's version using IsDate1After/Before/Equal: longer, more verbose, multiple
		// function calls, repeated checks, harder to read and maintain

//static bool IsDateBetween(clsDate Date, clsDate From, clsDate To)
		//{
		//	//Date>=From && Date<=To
		//	if ((clsDate::IsDate1AfterDate2(Date, From) || clsDate::IsDate1EqualToDate2(Date, From))
		//		&&
		//		(clsDate::IsDate1BeforeThanDate2(Date, To) || clsDate::IsDate1EqualToDate2(Date, To))
		//		)
		//	{
		//		return true;
		//	}
		//	//Date>=To && Date<=From
		//	if ((clsDate::IsDate1AfterDate2(Date, To) || clsDate::IsDate1EqualToDate2(Date, To))
		//		&&
		//		(clsDate::IsDate1BeforeThanDate2(Date, From) || clsDate::IsDate1EqualToDate2(Date, From))
		//		)
		//	{
		//		return true;
		//	}
		//	return false;
		//}


template <typename T>
static T ReadNumber(string ErrorMessage = "Invalid Number, Enter again:\n")
{
	T Number;

	while (!(cin >> Number))
	{
		// user didn't input a number
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

		cout << ErrorMessage << endl;

	}

	return Number;
}

template <typename T>
static T ReadNumberBetween(T From, T To, string ErrorMessage = "Number is not within range, Enter again:\n")
{
	T Number = 0;

	Number = ReadNumber<T>();

	while (!IsNumberBetween<T>(Number, From, To))
	{
		cout << ErrorMessage;
		Number = ReadNumber<T>();
	}

	return Number;
}


static bool IsValideDate(clsDate Date)
		{
			return clsDate::IsValidDate(Date);
		}

static string ReadString(string Message = "")
		{
			string s = "";

			if (Message != "")
				cout << Message << endl;

			getline(cin >> ws, s);
			return s;
		}

};



