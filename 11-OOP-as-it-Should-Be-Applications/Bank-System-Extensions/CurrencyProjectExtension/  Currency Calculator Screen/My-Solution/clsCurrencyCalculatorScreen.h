#pragma once
#include "clsScreen.h"
#include "clsInputValidate.h"
#include "clsCurrency.h"

class clsCurrencyCalculatorScreen:protected clsScreen
{

private:

	static void _PrintCurrencyCard(clsCurrency& Currency1,string Message="\nConvert From:\n")
	{
		cout << Message << endl;

		cout << "----------------------------\n";
		cout << "Country    : " << Currency1.GetCountry() << endl;
		cout << "Code       : " << Currency1.GetCurrencyCode() << endl;
		cout << "Name       : " << Currency1.GetCurrencyName() << endl;
		cout << "Rate(1$) = : " << Currency1.GetExchangeRate() << endl;
		cout << "----------------------------\n";


	}
	static clsCurrency _GetCurrencyObject(string Message="\nPlease enter Currency1 Code : ")
	{
		string CurrencyCode = "";

		cout << Message;
		CurrencyCode = clsInputValidate::ReadString();

		while (!clsCurrency::IsCurrencyExist(CurrencyCode))
		{
			cout << "\nCurrency is Not found,please enter another one :";
			CurrencyCode = clsInputValidate::ReadString();
		}

		return clsCurrency::FindByCurrencyCode(CurrencyCode);
	}
	static float _ReadExchangeAmount()
	{
		float ExchangeAmount = 0;

		cout << "\nEnter Amount to Exchange: ";
		ExchangeAmount = clsInputValidate::ReadFloatNumber();

		return ExchangeAmount;
	}

	static float _ConvertToUSD(float ExchangeAmount,float RateFrom)
	{
		return (float)(ExchangeAmount / RateFrom);
	}
	static void _PrintConvertResult(float ExchangeAmount, string CurrencyCode1, float ConvertedAmount, string CurrencyCode2="USD")
	{
		cout << "\n" << ExchangeAmount << " " << CurrencyCode1 << " = "
			<< ConvertedAmount << " " << CurrencyCode2 << endl;
	}
	static float _ConvertFromUSD(float USDAmount, float RateTo)
	{
		return (float)RateTo * USDAmount;
	}


public:



	static void ShowCurrencyCalculatorScreen()
	{
		system("cls");
		_DrawScreenHeader("\tCurrency Calculator Screen");

	
		clsCurrency CurrencyFrom = _GetCurrencyObject();
		clsCurrency CurrencyTo = _GetCurrencyObject("\nPlease enter Currency2 Code : ");


		float ExchangeAmount = _ReadExchangeAmount();
		_PrintCurrencyCard(CurrencyFrom);
		float USDAmount = _ConvertToUSD(ExchangeAmount, CurrencyFrom.GetExchangeRate());
		_PrintConvertResult(ExchangeAmount, CurrencyFrom.GetCurrencyCode(), USDAmount);


		
		if (CurrencyTo.GetCurrencyCode() != "USD")
		{
			cout << "\n\nConverting from USD to:\n\n";
			
			_PrintCurrencyCard(CurrencyTo, "\nConvert To:\n");

			float AmountFromUSD = _ConvertFromUSD(USDAmount, CurrencyTo.GetExchangeRate());


			_PrintConvertResult(ExchangeAmount, CurrencyFrom.GetCurrencyCode()
				, AmountFromUSD, CurrencyTo.GetCurrencyCode());


		}




	}



};




