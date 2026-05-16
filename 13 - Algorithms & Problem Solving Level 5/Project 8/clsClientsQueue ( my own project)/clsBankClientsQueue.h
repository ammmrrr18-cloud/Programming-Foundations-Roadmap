#pragma once
#include <iostream>
#include "clsDate.h"
#include <iomanip>
#include <queue>
#include <stack>

using namespace std;


class clsBankClientsQueue
{

private:

	int _ClientTicketNumber = 0;
	string _Prefix;
	int _AverageServeTime = 0;
	


	class clsTicket
	{
	private:

		int _TicketNumber = 0;
		string _Prefix;
		string _TicketTime;
		int _WaitingClients = 0;
		int _AverageServeTime = 0;

	public:


		clsTicket(int TicketNumber, string Prifex, int WatingClients, int AverageServeTime)
		{
			_TicketNumber = TicketNumber;
			_Prefix = Prifex;
			_WaitingClients = WatingClients;
			_AverageServeTime = AverageServeTime;
			_TicketTime = clsDate::GetSystemDateTimeString();
			
		}

		string FullNumber()
		{
			return _Prefix + to_string(_TicketNumber);
		}
		
		int AverageServeTime()
		{
			return _AverageServeTime;
		}

		int ExpectedServeTime()
		{
			return _WaitingClients * AverageServeTime();
		}

		string TicketTime()
		{
			return _TicketTime;
		}

		void Print()
		{
			cout << "\n\t\t\t  _______________________\n";
			cout << "\n\t\t\t\t    " << FullNumber();
			cout << "\n\n\t\t\t    " << _TicketTime;
			cout << "\n\t\t\t    Wating Clients = " << _WaitingClients;
			cout << "\n\t\t\t      Serve Time In";
			cout << "\n\t\t\t       " << ExpectedServeTime() << " Minutes.";
			cout << "\n\t\t\t  _______________________\n";


		}


	};

public:

	queue <clsTicket> ClientsQueue;

	clsBankClientsQueue(string Prefix,int AverageServeTime)
	{
		
		_Prefix = Prefix;
		_AverageServeTime = AverageServeTime;
		_ClientTicketNumber = 0;
	}
	
	void IssueTicket()
	{
		_ClientTicketNumber++;
		clsTicket Ticket(_ClientTicketNumber, _Prefix, WaitingClients(), _AverageServeTime);
		ClientsQueue.push(Ticket);
	}


	int WaitingClients()
	{
		return ClientsQueue.size();
	}

	int ServedClients()
	{
		return _ClientTicketNumber - WaitingClients();
	}

	void PrintInfo()
	{
		cout << "\n\t\t\t _________________________\n";
		cout << "\n\t\t\t\tQueue Info";
		cout << "\n\t\t\t _________________________\n";
		cout << "\n\t\t\t    Prefix   = " << _Prefix;
		cout << "\n\t\t\t    Total Tickets   = " << _ClientTicketNumber;
		cout << "\n\t\t\t    Served Clients  = " << ServedClients();
		cout << "\n\t\t\t    Wating Clients  = " << WaitingClients(); ;
		cout << "\n\t\t\t _________________________\n";
		cout << "\n";

	}


	void PrintTicketsLineRTL()
	{

		if (ClientsQueue.empty())
			cout << "\n\t\tTickets: No Tickets.";
		else
			cout << "\n\t\tTickets: ";

		//we copy the queue in order not to lose the original
		queue <clsTicket> TempQueueLine = ClientsQueue;


		while (!TempQueueLine.empty())
		{
			clsTicket Ticket = TempQueueLine.front();

			cout << " " << Ticket.FullNumber() << " <-- ";

			TempQueueLine.pop();
		}

		cout << "\n";

	}
	void PrintTicketsLineLTR()
	{
		if (ClientsQueue.empty())
			cout << "\n\t\tTickets: No Tickets.";
		else
			cout << "\n\t\tTickets: ";

		//we copy the queue in order not to lose the original
		queue <clsTicket> TempQueueLine = ClientsQueue;
		stack <clsTicket> TempStackLine;

		while (!TempQueueLine.empty())
		{
			TempStackLine.push(TempQueueLine.front());
			TempQueueLine.pop();
		}

		while (!TempStackLine.empty())
		{
			clsTicket Ticket = TempStackLine.top();

			cout << " " << Ticket.FullNumber() << " --> ";

			TempStackLine.pop();
		}
		cout << "\n";
	}


	void PrintAllTickets()
	{
		cout << "\n\n\t\t\t       ---Tickets---";

		if (ClientsQueue.empty())
		{
			cout << "\n\n\t\t\t     ---No Tickets---\n";
			return;
		}
		
		queue <clsTicket> TempClientsQueue = ClientsQueue;


		while (!TempClientsQueue.empty())
		{
			TempClientsQueue.front().Print();
			TempClientsQueue.pop();
		}


	}

	bool ServeNextClient()
	{
		if (ClientsQueue.empty())
		
			return false;
		
	    ClientsQueue.pop();
	    return true;
	}

	string WhoIsNext()
	{
		if (ClientsQueue.empty())
			return "No Clients Left.";
		else
			return ClientsQueue.front().FullNumber();

	}

};

