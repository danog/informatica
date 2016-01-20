// 6 maggiorenne?
// Copyright Daniil Gentili. :)))))
// Licenza GPLv3 :))))))
#include <iostream>
using namespace std;

int main(){
	cout<<"6 maggiorenne?\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int volte, n;
	int contatoreminorenne = 0;
	int contatoremaggiorenne = 0;
	int contatore = 1;
	bool weird = true;
	/*
	cout<<"Quanti numeri volete inserire? ";
	cin>>volte;*/
	volte = 20;
	while (contatore <= volte){
		while (weird == true) {
			cout<<"\nPrego inserire il "<<contatore<<"^ numero: ";
			cin>>n;
			if (n >= 0) { weird = false; } else { cout<<"\nNon sei ancora nato e gia usi il pc?\nCosi si fa :)!\n"; };
		};
		if(n >= 18){
			contatoremaggiorenne++;
		} else {
			contatoreminorenne++;
		}
		contatore++;
		weird = true;
	}
	
	cout<<"\nSu "<<volte<<" persone "<<contatoremaggiorenne<<" sono maggiorenni.\n";
}
