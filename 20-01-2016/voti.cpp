// Contatore di fine anno
// Copyright Daniil Gentili. :)))))
// Licenza GPLv3 :))))))
#include <iostream>
using namespace std;

int main(){
	cout<<"Contatore di fine anno.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int volte = 3;
	int n, media;
	int somma = 0;
	int contatore = 1;
	bool weird = true;
	while (contatore <= volte){
		while (weird == true) {
			cout<<"\nPrego inserire il "<<contatore<<"^ voto: ";
			cin>>n;
			if (n >= 0 && n <= 10) { weird = false; } else { cout<<"\nAvete inserito un numero strano. Prego riprovare.\n"; };
		};
		somma += n;
		contatore++;
		weird = true;
	}
	media = somma / volte;
	if (media >= 6) { cout<<"\nCongratulazioni!\nSiete stati promossi (voto medio "<<media<<")!\n"; } else { cout<<"\nMi dispiace.\nSiete stati bocciati :(voto medio "<<media<<")\n";; }
}
