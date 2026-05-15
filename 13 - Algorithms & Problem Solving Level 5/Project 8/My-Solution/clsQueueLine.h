#pragma once
#include <iostream>
#include <queue>
#include <stack>
#include "clsDate.h"
#include <iomanip>
using namespace std;


class clsQueueLine
{

private:
	string _prefix;
	int _serveTime;

	int _ServedClients = 0;
	int _TotalTicketsCounter = 0;
	

	struct stIssueTicket
	{
		string _ID;
		string _DateAndTime;
		int _WaitingClients = 0;
		int _serveTimeIn = 0;
	};



	queue<stIssueTicket>_OriginalQuClients;
	

public:

	clsQueueLine(string Prefix, int ServeTime)
	{
		_prefix = Prefix;
		_serveTime = ServeTime;
	}



	void IssueTicket()
	{
		stIssueTicket _Ticket;

		_TotalTicketsCounter++;

		_Ticket._ID = _prefix + to_string(_TotalTicketsCounter);
		_Ticket._DateAndTime = clsDate::GetSystemDateTimeString();

		if (_TotalTicketsCounter == 1)
		{
			_Ticket._WaitingClients = 0;
			_Ticket._serveTimeIn = 0;
			_OriginalQuClients.push(_Ticket);
			
			return;
		}

		_Ticket._WaitingClients = _TotalTicketsCounter - 1;
		_Ticket._serveTimeIn = _Ticket._WaitingClients * _serveTime;
		_OriginalQuClients.push(_Ticket);
		
	}

	void PrintInfo() {
		cout << "\n\n";
		cout << "\n\t\t\t\t_________________________________\n";
		cout << "\t\t\t\t\t   Queue Info";
		cout << "\n\t\t\t\t_________________________________\n\n";

		cout << "\t\t\t\t  " << left << setw(15) << "Prefix" << " = " << _prefix << endl;
		cout << "\t\t\t\t  " << left << setw(15) << "Total Tickets" << " = " << _OriginalQuClients.size() << endl;
		cout << "\t\t\t\t  " << left << setw(15) << "Served Clients" << " = " << _ServedClients << endl;
		cout << "\t\t\t\t  " << left << setw(15) << "Wating Clients" << " = " << _OriginalQuClients.size() << endl;

		cout << "\t\t\t\t_________________________________\n";
	}

	void PrintTicketsLineRTL()
	{
		queue<stIssueTicket>_TempQuClients;
		_TempQuClients = _OriginalQuClients;
		cout << "\n\n\t\t\tTickets:  ";

		while (!_TempQuClients.empty())
		{
			cout << _TempQuClients.front()._ID;
			_TempQuClients.pop();

				cout << " <-- ";
		}
		cout << "\n\n";
	}

	void PrintTicketsLineLTR()
	{
		stack<stIssueTicket> _TempStackClients;
		queue<stIssueTicket>_TempQuClients;

		_TempQuClients = _OriginalQuClients;

		while (!_TempQuClients.empty())
		{
			_TempStackClients.push(_TempQuClients.front());
			_TempQuClients.pop();
		}

		cout << "\t\t\tTickets:  "; 
		while (!_TempStackClients.empty())
		{
			cout << _TempStackClients.top()._ID;
			_TempStackClients.pop();

				cout << " --> ";
		}
		cout << "\n\n";
	}

	void PrintAllTickets()
	{
		queue<stIssueTicket>_TempQuClients;

		_TempQuClients = _OriginalQuClients;
		cout << "\n\n\t\t\t\t\t--- Tickets ---\n";

		while (!_TempQuClients.empty())
		{
			stIssueTicket Ticket = _TempQuClients.front();

			cout << "\n\t\t\t\t_________________________________\n";
			cout << "\t\t\t\t\t\t" << Ticket._ID << "\n\n";
			cout << "\t\t\t\t   " << Ticket._DateAndTime << "\n";
			cout << "\t\t\t\t   Wating Clients = " << Ticket._WaitingClients << "\n";
			cout << "\t\t\t\t   Serve Time In\n";
			cout << "\t\t\t\t\t" << Ticket._serveTimeIn << " Minutes.\n";
			cout << "\t\t\t\t_________________________________\n";

			_TempQuClients.pop();
		}
	}


	void ServeNextClient()
	{
		if (!_OriginalQuClients.empty()) 
		{
			_OriginalQuClients.pop();
			_ServedClients++;
		}
		else
		{
			cout << "\n\t\t\t\tNo clients in the queue to serve!\n";
		}
	}


};

