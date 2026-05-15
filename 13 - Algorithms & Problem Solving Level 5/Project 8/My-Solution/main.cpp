
#include <iostream>
#include "clsQueueLine.h"

using namespace std;





int main()
{

    clsQueueLine PayBillsQueue("A0", 10);
    clsQueueLine SubscriptionsQueue("B0", 5);

    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();




    cout << "\nPay Bills Queue Info : \n\n";
    PayBillsQueue.PrintInfo();


    PayBillsQueue.PrintTicketsLineRTL();
    PayBillsQueue.PrintTicketsLineLTR();
  
    PayBillsQueue.PrintAllTickets();


    cout << "\n\nPay Bills Queue After Serving One Clinet : \n\n";

    PayBillsQueue.ServeNextClient();

    PayBillsQueue.PrintInfo();




    SubscriptionsQueue.IssueTicket();
    SubscriptionsQueue.IssueTicket();
    SubscriptionsQueue.IssueTicket();
    SubscriptionsQueue.IssueTicket();
    SubscriptionsQueue.IssueTicket();




    cout << "\nSubscriptions Queue Info : \n\n";
    SubscriptionsQueue.PrintInfo();


    SubscriptionsQueue.PrintTicketsLineRTL();
    SubscriptionsQueue.PrintTicketsLineLTR();

    SubscriptionsQueue.PrintAllTickets();


    cout << "\n\nSubscriptions Queue After Serving One Clinet : \n\n";

    SubscriptionsQueue.ServeNextClient();

    SubscriptionsQueue.PrintInfo();




    system("pause>0");

    return 0;
}

