#include <iostream>
#include "clsClientsQueueLine.h"

using namespace std;

int main()
{
    // Create a bank queue system (Prefix: "A", Average Serve Time: 10 Minutes)
    clsBankClientsQueue BankQueue("A", 10);

    // 1. Issue 3 tickets sequentially
    BankQueue.IssueTicket(); // First Client
    BankQueue.IssueTicket(); // Second Client
    BankQueue.IssueTicket(); // Third Client

    cout << "\n=== System Status After Issuing 3 Tickets ===";
    BankQueue.PrintInfo();
    BankQueue.PrintTicketsLineRTL();

    // 2. Print all active tickets currently waiting in the queue
    BankQueue.PrintAllTickets();

    // 3. Inquiry: Display who is next on the screen
    cout << "\nNext Client on Screen: " << BankQueue.WhoIsNext() << "\n\n";

    // 4. The bank employee serves the first client in line
    cout << "--- Serving One Client ---";
    BankQueue.ServeNextClient();

    cout << "\n=== System Status After Serving The First Client ===";
    BankQueue.PrintInfo();
    BankQueue.PrintTicketsLineRTL();

    // 5. Inquiry: Check the screen again after updating the queue
    cout << "\nNext Client on Screen: " << BankQueue.WhoIsNext() << "\n\n";

    return 0;
}
