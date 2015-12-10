// Programma di calcolo del punteggio della patente 
// Copyright Daniil Gentili. :)))))
// Licenza GPLv3 :))))))
#include <iostream>
using namespace std;

int main()
{
	int vpratico;
	int vorale;
	int totale;
	bool weird = true;
	cout<<"Programma di calcolo del punteggio della patente\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	while (weird == true){
		cout<<"Prego inserire il voto della prova pratica: ";
		cin>>vpratico;
		cout<<"\nPrego inserire il voto della prova orale: ";
		cin>>vorale;
		totale = vorale + vpratico;
		if(totale >= 18 && totale <= 30) {
			cout<<"\nCongratulazioni! Avete passato l'esame della patente! ("<<totale<<"/30)";
			weird = false;
		} else {
			if(totale < 18) {
				cout<<"\nMi dispiace, non avete passato l'esame della patente. ("<<totale<<"/30)";
				weird = false;
			} else {
				cout<<"Voti inseriti errati ("<<totale<<"/30). Prego riprovare.\n\n";
				weird = true;
			}
		}
	}
};


