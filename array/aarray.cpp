#include <iostream>
using namespace std;

int main() {
    // Declarar y crear un array de enteros
    int numeros[5] = {10, 20, 30, 40, 50};

    cout << "Elementos del array:" << endl;
    for (int i = 0; i < 5; i++) {
        cout << "Posición " << i << ": " << numeros[i] << endl;
    }

    return 0;
}
