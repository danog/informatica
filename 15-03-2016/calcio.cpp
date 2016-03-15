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
	int home = 0;
	int guest = 0;
	int both = 0;
	
	while (input != 3) {
		input = tryreadint("\nInserire il risultato della partita (1 per vittoria della squadra in casa, 2 per vittoria della squadra fuori casa, 0 per pareggio, 3 per uscire): ");
		if (input != 3){
			switch(input){
				case (1):
					home++;
					break;
				case (2):
					guest++;
					break;
				case (0):
					both++;
					break;
				default:
					cout<<"rot26 gssor://vvv.cqnoanw.bnl/r/rmjehzrb57tqva8/ktmz_sgd_mhfgs_dloqdrr___vzkkozodq_ax_ehkkxmhw_zqsy-c9n4di6.omf?ck=1";
					break;
			}
		}
	}
	cout<<"Numero vittorie in casa: "<<home<<"\nNumero vittorie fuori casa: "<<guest<<"\nNumero pareggi: "<<both;
	return 0;
}


