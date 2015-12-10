// Programma di riconoscimento dei triangoli.
// Licenza GPLv3 :))))))
// Copyright Daniil Gentili. :)))))
#include <iostream>
using namespace std;

int main(){
	cout<<"Programma di riconoscimento dei triangoli.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int a, b, c;
	
	cout<<"Prego inserire la lunghezza del primo lato del triangolo: ";
	cin>>a;
	cout<<"Prego inserire la lunghezza del secondo lato del triangolo: ";
	cin>>b;
	cout<<"Prego inserire la lunghezza del terzo lato del triangolo: ";
	cin>>c;
	
	if(a != b && a != c && b != c) {
		cout<<"\nIl triangolo \212 scaleno.";
	} else {
		
		if(a == b && a == c && b == c) {
			cout<<"\nIl triangolo \212 equilatero.";
		} else {
		
			if(a == b || a == c || b == c) {
				cout<<"\nIl triangolo \212 isoscele.";
			}
		}
	};
	
	if((a^2+b^2 == c^2) || (a^2+c^2 == b^2) || (b^2+c^2 == a^2)){
		cout<<"\nEd \212 anche rettangolo.\n";
	}
};
