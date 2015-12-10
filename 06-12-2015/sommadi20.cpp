// Programma di calcolo della somma di 20 numeri
// Copyright Daniil Gentili. :)))))
// Licenza GPLv3 :))))))
#include <iostream>
using namespace std;

int main(){
	int volte = 20;
	int n;
	int somma = 0;
	int contatore = 1;
	
	cout<<"Programma di calcolo della somma di "<<volte<<" numeri\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	while (contatore <= volte){
		cout<<"\nPrego inserire il "<<contatore<<"^ numero: ";
		cin>>n;
		somma = somma + n;
		contatore++;
	}
	cout<<"\nLa somma dei numeri da voi inseriti \212 "<<somma<<".";
}
