// Programma per numeri
// Copyright Daniil Gentli.
// Licenza GPLv3
//

#include <iostream>

using namespace std;


int tryreadint(string cosa){
	int x;
	cout<<cosa;
	
	cin >> x;
    while(std::cin.fail() || x < 0) {
        cout << "Hai inserito un valore errato. Prego riprovare.\n"<<cosa;
;
        cin.clear();
        cin.ignore(256,'\n');
        cin >> x;
    }
    return x;
}
int main()
{
	cout << "Programma per numeri.\nCopyright Daniil Gentili. :)))))\nLicenza GPLv3 :))))))\n\n";
	int input;
	int div [3] = { 0, 0, 0 };
	int q;
	int n = 0;
	string wut;
	
	q = tryreadint("Quanti numeri volete che vi chieda? ");
	while (n < q) {
		n++;
		cout<<"Inserisci il "<<n<<"^ numero. ";
		input = tryreadint("");
		if (input % 2 == 0){
			div[0]++;
		}
		if(input % 3 == 0){
			div[1]++;
		}
		if(input % 5 == 0){
			div[2]++;
		}
	}
	cout<<"Numeri divisibili per 2: "<<div[0]<<"\nNumeri divisibili per 3: "<<div[1]<<"\nNumeri divisibili per 5: "<<div[2];
	return 0;
}


