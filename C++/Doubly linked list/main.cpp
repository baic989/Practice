#include <iostream>
#include "list.h"

void print_list(list &l);

int main(){

	// Initialize and add people to the list
	list people;

	people.insert("Hrvoje", people.first());
	people.insert("Johnny", people.first());
	people.insert("Bravo", people.first());

	people.insert("dr.Evil", people.find("Johnny"));

	// Print them out
	print_list(people);

	// Let's see where dr. Evil is hiding!
	cout << "Looking for dr.Evil..." << endl;
	POSITION found = people.find("dr.Evil");

	if (found != people.end()){
		cout << "Found on adress: " << found << endl;
	}
	else{
		cout << "No match." << endl;
	}

	// Now let's get rid of him once and for all!
	people.remove(people.find("dr.Evil"));
	print_list(people);

	// And send the rest of our party on vacation
	people.empty();
	print_list(people);

	return 0;
}

void print_list(list &l){
	ELTYPE element;

	cout << "List: " << endl;
	for (POSITION pos = l.first(); pos != l.end(); pos = l.next(pos)){
		l.read(pos, element);
		cout << element << endl;
	}
	cout << endl;
}