#include <iostream>
#include <iomanip>
#include "clsDynamicArray.h"

using namespace std;

int main()
{
    // ====================================================================
    // CASE 1: Testing ClearZero (The Teacher's Way - Allocating Size 0)
    // ====================================================================
    cout << "====================================================================" << endl;
    cout << "  [CASE 1] TESTING CLEAR_ZERO (Teacher's Method: new T[0])" << endl;
    cout << "====================================================================" << endl;

    clsDynamicArray<int> ArrayZero(3);
    ArrayZero.SetItem(0, 10);
    ArrayZero.SetItem(1, 20);
    ArrayZero.SetItem(2, 30);

    // Initial State
    cout << " -> INITIAL STATE:" << endl;
    cout << "    * Current Size : " << ArrayZero.Size() << endl;
    cout << "    * Elements     : "; ArrayZero.PrintList();
    cout << "    * Memory Heap  : " << ArrayZero.OriginalArray << endl;
    cout << "--------------------------------------------------------------------" << endl;

    // Executing ClearZero
    cout << " [!] Executing ArrayZero.ClearZero()..." << endl;
    ArrayZero.ClearZero();
    cout << "--------------------------------------------------------------------" << endl;

    // Post-Clear State
    cout << " -> POST-CLEAR STATE:" << endl;
    cout << "    * New Size     : " << ArrayZero.Size() << endl;
    cout << "    * Elements     : "; ArrayZero.PrintList();
    cout << "    * Memory Heap  : " << ArrayZero.OriginalArray << " (Valid slot assigned for size 0!)" << endl;
    cout << "--------------------------------------------------------------------" << endl;

    // Security & Boundary Check
    cout << " -> BOUNDARY SECURITY CHECK:" << endl;
    cout << "    * Attempting to set item at index 0 with value 99..." << endl;
    if (ArrayZero.SetItem(0, 99))
    {
        cout << "    * Status       : SUCCESS! Item was modified." << endl;
    }
    else
    {
        cout << "    * Status       : BLOCKED! Safe boundary condition prevented data corruption." << endl;
    }
    cout << "--------------------------------------------------------------------" << endl;

    // New Resize Phase
    cout << " [!] Executing ArrayZero.Resize(3) to open space..." << endl;
    ArrayZero.Resize(3);
    cout << "--------------------------------------------------------------------" << endl;

    cout << " -> POST-RESIZE STATE:" << endl;
    cout << "    * New Size     : " << ArrayZero.Size() << endl;
    cout << "    * Memory Heap  : " << ArrayZero.OriginalArray << " (Allocated a brand new open space!)" << endl;

    cout << "    * Attempting to set item at index 0 after Resize..." << endl;
    ArrayZero.SetItem(0, 55);
    ArrayZero.SetItem(1, 66);
    ArrayZero.SetItem(2, 77);
    cout << "    * Elements now : "; ArrayZero.PrintList();
    cout << "====================================================================\n\n" << endl;


    // ====================================================================
    // CASE 2: Testing ClearNULL (Setting Pointer directly to NULL)
    // ====================================================================
    cout << "====================================================================" << endl;
    cout << "  [CASE 2] TESTING CLEAR_NULL (Direct Assignment: NULL)" << endl;
    cout << "====================================================================" << endl;

    clsDynamicArray<int> ArrayNULL(3);
    ArrayNULL.SetItem(0, 100);
    ArrayNULL.SetItem(1, 200);
    ArrayNULL.SetItem(2, 300);

    // Initial State
    cout << " -> INITIAL STATE:" << endl;
    cout << "    * Current Size : " << ArrayNULL.Size() << endl;
    cout << "    * Elements     : "; ArrayNULL.PrintList();
    cout << "    * Memory Heap  : " << ArrayNULL.OriginalArray << endl;
    cout << "--------------------------------------------------------------------" << endl;

    // Executing ClearNULL
    cout << " [!] Executing ArrayNULL.ClearNULL()..." << endl;
    ArrayNULL.ClearNULL();
    cout << "--------------------------------------------------------------------" << endl;

    // Post-Clear State
    cout << " -> POST-CLEAR STATE:" << endl;
    cout << "    * New Size     : " << ArrayNULL.Size() << endl;
    cout << "    * Elements     : "; ArrayNULL.PrintList();
    cout << "    * Memory Heap  : " << ArrayNULL.OriginalArray << " (Completely disconnected / 0)" << endl;
    cout << "--------------------------------------------------------------------" << endl;

    // Security & Boundary Check
    cout << " -> BOUNDARY SECURITY CHECK:" << endl;
    cout << "    * Attempting to set item at index 0 with value 99..." << endl;
    if (ArrayNULL.SetItem(0, 99))
    {
        cout << "    * Status       : SUCCESS! Item was modified." << endl;
    }
    else
    {
        cout << "    * Status       : BLOCKED! Safe boundary condition prevented data corruption." << endl;
    }
    cout << "--------------------------------------------------------------------" << endl;

    // New Resize Phase
    cout << " [!] Executing ArrayNULL.Resize(3) to reconnect pointer..." << endl;
    ArrayNULL.Resize(3);
    cout << "--------------------------------------------------------------------" << endl;

    cout << " -> POST-RESIZE STATE:" << endl;
    cout << "    * New Size     : " << ArrayNULL.Size() << endl;
    cout << "    * Memory Heap  : " << ArrayNULL.OriginalArray << " (Connected to a fresh open block!)" << endl;

    cout << "    * Attempting to set item at index 0 after Resize..." << endl;
    ArrayNULL.SetItem(0, 555);
    ArrayNULL.SetItem(1, 666);
    ArrayNULL.SetItem(2, 777);
    cout << "    * Elements now : "; ArrayNULL.PrintList();
    cout << "====================================================================" << endl;

    return 0;
}
