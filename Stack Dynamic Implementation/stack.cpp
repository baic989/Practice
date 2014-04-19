#include "stack.h"

stack::stack(){
	
	_bottom = new node;
	_bottom->under = nullptr;

	_top = new node;
	_top->under = _bottom;
}

void stack::empty(){
	node *temp = _top->under;
	while (temp != _bottom){
		node *next = temp->under;
		delete temp;
		temp = next;
	}
	_top->under = _bottom;
}

bool stack::is_empty(){
	return _top->under == _bottom;
}

bool stack::push(ELTYPE element){
	node *new_node = new node;
	new_node->element = element;
	new_node->under = _top->under;
	_top->under = new_node;
	return true;
}

bool stack::pop(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	// temp becomes the top element
	node *temp = _top->under;
	element = temp->element;
	_top->under = temp->under;

	delete temp;

	return true;
}

bool stack::top(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	element = _top->under->element;
	return true;
}