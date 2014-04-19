#include "stack.h"

stack::stack(){
	_vrh = 0;
}

void stack::empty(){
	_vrh = 0;
}

bool stack::is_full(){
	return _vrh == CAPACITY;
}

bool stack::is_empty(){
	return _vrh == 0;
}

bool stack::push(ELTYPE element){

	if (is_full()){
		return false;
	}

	_elements[_vrh] = element;
	++_vrh;
	return true;
}

bool stack::pop(ELTYPE &element){

	if (is_empty()){
		return false;
	}

	element = _elements[_vrh - 1];
	--_vrh;
	return true;
}

bool stack::top(ELTYPE &element){

	if (is_empty()){
		return false;
	}

	element = _elements[_vrh - 1];
	return true;
}