#include <iostream>
#include "stack.h"

int main(){

	// Let's make our stack contain numbers
	stack numbers;
	ELTYPE x;

	// Check if it initialized correctly, it should be empty
	cout << "Return true if our stack is empty or false if not" << endl;
	cout << numbers.is_empty() << endl;

	// OK, now we can put some numbers in
	numbers.push(10);
	numbers.push(20);
	numbers.push(30);
	numbers.push(40);
	numbers.push(50);

	// Now let's see if it's empty
	cout << "Return true if our stack is empty or false if not" << endl;
	cout << numbers.is_empty() << endl;

	// Let's see which element is on top. It should be the last element as stack is a LIFO structure
	if (numbers.top(x)){
		cout << "The element on top is " << x << endl;
	}
	else{
		cout << "Error" << endl;
	}
	
	// Now to print and empty our stack
	while (!numbers.is_empty()){
		if (numbers.pop(x)){
			cout << "Removing: " << x << endl;
		}
		else{
			cout << "The stack is empty." << endl;
		}
	}

	return 0;

}