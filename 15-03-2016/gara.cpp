// Programma per gare
// Copyright Daniil Gentli.
// Licenza GPLv3
//

#include <iostream>

using namespace std;


int tryreadint(string cosa) {
	int x;
	cout<<cosa;
	
	cin >> x;
    while(std::cin.fail()) {
        cout << "Non hai inserito un numero. Prego riprovare.\n"<<cosa;
        cin.clear();
        cin.ignore(256,'\n');
        cin >> x;
    }
    return x;
}
int main()
{
	cout << "Programma per gare.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int n = 0;
	int max = 0;
	int points;
	string winner, nome, wintxt;
	
	while (nome != ".") {
		cout<<"\nInserire il nome del "<<n+1<<"^ atleta (scrivi . per annullare): ";
		cin>>nome;
		if (nome != "."){	
			points = tryreadint("Inserire il punteggio di "+nome+": ");

			if (points == max) {
				winner += ", " + nome;
				wintxt = "Vincono (ex aequo)";
			}
			
			if(points > max || n == 0) {
				max = points;
				winner = nome;
				wintxt = "Vince";
			}
			
			n++;
		}
	}
	
	if (winner != "") {
		cout<<wintxt<<" la gara: "<<winner<<" con "<<max<<" punti.";
	} else {
		cout<<"Non hai inserito neanche un nome.";
	}
	return 0;
}


