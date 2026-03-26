#include <iostream>
using namespace std;

template <typename T> T myMax(T Number1, T Number2)
{
    return (Number1 > Number2) ? Number1 : Number2;
}

int main()
{
    cout << myMax<int>(3, 7) << endl; // Call myMax for int

    cout << myMax<double>(5.3, 4.2)
        << endl; // call myMax for double

    cout << myMax<char>('a', 'b')
        << endl; // call myMax for char

    return 0;
}
