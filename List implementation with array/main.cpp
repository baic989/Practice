#include "list.h"
#include <iostream>

void print_list(list &l);

int main(){
	list people;

	people.insert("Hrvoje", 1);
	print_list(people);

	people.insert("Lucija", 1);
	print_list(people);

	people.insert("Someone", 3);
	print_list(people);

	cout << endl << "Searching for Lucija..." << endl;
	POSITION found = people.find("Lucija");
	if (found >= people.first() && found < people.end()){
		cout << "Found on " << found << ". place!" << endl;
	}
	else {
		cout << "Doesn't exist in the list." << endl;
	}

	people.remove(3);
	print_list(people);

	while (people.first() != people.end()){
		people.remove(1);
	}
	print_list(people);

	return 0;
}

void print_list(list &l){
	string element;
	cout << "Printing list..." << endl;
	for (POSITION pos = l.first(); pos < l.end(); pos = l.next(pos)){
		l.read(pos, element);
		cout << element << endl;
	}
	cout << endl;
}