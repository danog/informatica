// Programma per campionato di calcio
// Copyright Daniil Gentli.
// Licenza GPLv3
//

#include <iostream>

using namespace std;


int tryreadint(string cosa) {
	int x;
	cout<<cosa;
	
	cin >> x;
    while(std::cin.fail() || (x < 0 || x > 3)) {
        cout << "Hai inserito un valore errato. Prego riprovare.\n"<<cosa;
        cin.clear();
        cin.ignore(256,'\n');
        cin >> x;
    }
    return x;
}
int main()
{
	cout << "Programma per campionato di calcio.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int input;
	int vittorie [3] = { 0, 0, 0 };
	
	while (input != 3) {
		input = tryreadint("\nInserire il risultato della partita (1 per vittoria della squadra in casa, 2 per vittoria della squadra fuori casa, 0 per pareggio, 3 per uscire): ");
		if (input != 3){
			vittorie[input]++;
		}
	}
	cout<<"Numero vittorie in casa: "<<vittorie[1]<<"\nNumero vittorie fuori casa: "<<vittorie[2]<<"\nNumero pareggi: "<<vittorie[0];
	return 0;
}


