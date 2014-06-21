#include "dictionary.h"
#include <string>
#include <iostream>
#include <fstream>
using namespace std;

int main(){

	ifstream is("players.txt");
	if (!is){
		throw string("Error occure while trying to open players.txt.\n"
			"Please make sure the file is in the same folder as other .cpp files");
	}

	dict players;
	player p;

	while (is >> p.number){
		is.ignore();
		getline(is, p.name);

		players.insert(p.number, p);
	}

	// Where is Waldo?
	player *Waldo = players.search(1);

	if (Waldo != nullptr){
		cout << "Found " << Waldo->name << "!" << endl;
	}
	else{
		cout << "There is no player with that number!" << endl;
	}


	// Delete a player and then search
	players.remove(1);

	Waldo = players.search(1);

	if (Waldo != nullptr){
		cout << "Found " << Waldo->name << "!" << endl;
	}
	else{
		cout << "There is no player with that number!" << endl;
	}

	delete Waldo;
	is.close();

	return 0;
}