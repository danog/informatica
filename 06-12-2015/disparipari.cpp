// Contatore di numeri pari e dispari.
// Copyright Daniil Gentili. :)))))
// Licenza GPLv3 :))))))
#include <iostream>
using namespace std;

int main(){
	cout<<"Contatore di numeri pari e dispari.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int volte, n, div;
	int contatorepari = 0;
	int contatoredispari = 0;
	int contatore = 1;
	
	cout<<"Quanti numeri volete inserire? ";
	cin>>volte;
	while (contatore <= volte){
		cout<<"\nPrego inserire il "<<contatore<<"^ numero: ";
		cin>>n;
		div = n % 2;
		if(div == 0){
			contatorepari++;
		} else {
			contatoredispari++;
		}
		contatore++;
	}
	
	cout<<"\nAvete inserito "<<contatorepari<<" numero/i pari e "<<contatoredispari<<" numero/i dispari su "<<volte<<" numero/i.";
}
