#include <iostream>
#include "lista.h"

void print_list(list &l);

int main(){

	// Initialize and insert some people in the list
	list people;
	people.insert("Hrvoje", people.first());
	people.insert("Lucija", people.first());
	people.insert("Mujo", people.first());

	people.insert("Slavko", people.find("Lucija"));

	// Print the list
	print_list(people);

	// Search for a person
	cout << "Searching for Mujo" << endl;
	POSITION found = people.find("Mujo");
	
	if (found != people.end()){
		cout << "Found on " << found << " in memory." << endl;
	}
	else {
		cout << "No match found." << endl;
	}

	cout << endl;

	// Remove first person
	POSITION first = people.first();
	people.remove(first);
	print_list(people);

	// Remove everyone
	while (people.first() != people.end()){
		people.remove(people.first());
	}
	print_list(people);

	return 0;
}

void print_list(list &l){
	cout << "List: " << endl;
	for (POSITION pos = l.first(); pos != l.end(); pos = l.next(pos)){
		cout << pos->element << endl;
	}

	if (l.first() == l.end()){
		cout << "The list is empty" << endl;
	}
	cout << endl;
}