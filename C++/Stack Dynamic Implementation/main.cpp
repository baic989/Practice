#include <iostream>
#include "stack.h"

int main(){
	
	stack numbers;
	ELTYPE x;

	// Check if it is empty
	cout << "If the stack is empty it will show 1 (true), or 0 (false) if it's not empty." << endl;
	cout << numbers.is_empty() << endl;

	// Feed it some numbers
	numbers.push(10);
	numbers.push(20);
	numbers.push(30);
	numbers.push(40);
	numbers.push(50);

	// Check it again
	cout << "If the stack is empty it will show 1 (true), or 0 (false) if it's not empty." << endl;
	cout << numbers.is_empty() << endl;

	// Check the top element
	if (numbers.top(x)){
		cout << "The number on top is " << x << endl;
	}
	else{
		cout << "Error, stack seems to be empty." << endl;
	}

	// Empty and print out elements
	while (!numbers.is_empty()){
		if (numbers.pop(x)){
			cout << "Removed " << x << endl;
		}
		else{
			cout << "The stack is empty" << endl;
		}
	}

	return 0;
}