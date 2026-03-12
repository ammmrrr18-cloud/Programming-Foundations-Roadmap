#pragma once
#include "clsScreen.h"
#include"clsBankClient.h"
#include "clsInputValidate.h"

class clsTransferScreen :protected clsScreen
{

	static void _PrintClient(clsBankClient Client)
	{
		cout << "\nClient Card:";
		cout << "\n___________________\n";
		cout << "\nFull Name   : " << Client.FullName();
		cout << "\nAcc. Number : " << Client.AccountNumber();
		cout << "\nBalance     : " << Client.AccountBalance;
		cout << "\n___________________\n";

	}

	static double _ReadAmount(clsBankClient SourceClient)
	{
		double Amount = 0.0;

		cout << "\nEnter transfer amount ?";
		Amount = clsInputValidate::ReadDblNumber();

		while (Amount > SourceClient.AccountBalance)
		{
			cout << "\nAmount Exceeds the available Balance, Enter another Amount ? ";
			Amount = clsInputValidate::ReadDblNumber();
		}

	  return Amount;
	}



public:


	static void ShowTransferScreen()
	{
		_DrawScreenHeader("\nTransfer Screen");

		string AccountNumber1 = "";

		cout << "\nPlease enter account number to Transfrom from:";
		cin >> AccountNumber1;
		while (!clsBankClient::IsClientExist(AccountNumber1))
		{
			cout << "\nAccount Number [" << AccountNumber1 << "] is Not exist\n";
			cout << "Enter another one:";
			cin >> AccountNumber1;
		}

		clsBankClient SourceClient = clsBankClient::Find(AccountNumber1);
		_PrintClient(SourceClient);



		string AccountNumber2 = "";

		cout << "\nPlease enter account number to Transfrom to:";
		cin >> AccountNumber2;
		while (!clsBankClient::IsClientExist(AccountNumber2))
		{
			cout << "\nAccount Number [" << AccountNumber2 << "] is Not exist\n";
			cout << "Enter another one:";
			cin >> AccountNumber2;
		}

		clsBankClient DestinationClient = clsBankClient::Find(AccountNumber2);
		_PrintClient(DestinationClient);


		double Amount = _ReadAmount(SourceClient);


		char Answer = 'n';
		cout << "\nAre you sure that you want to perform this operation ? y/n?";
		cin >> Answer;

		if (Answer == 'y' || Answer == 'Y')
		{
			if (SourceClient.Transfer(Amount, DestinationClient))
			{
				cout << "\nTransfer done successfully\n";

				_PrintClient(SourceClient);
				_PrintClient(DestinationClient);
			}
			else
			{
				cout << "\nTransfer Faild\n";
			}



		}
		else
		{
			cout << "\nthis operation is Canseled";
		}


		 




	}


};

