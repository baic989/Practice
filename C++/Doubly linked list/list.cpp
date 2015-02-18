#include "list.h"

list::list(){
	_head = new node;
	_tail = new node;

	_head->next = _tail;
	_head->previous = nullptr;
	_tail->next = nullptr;
	_tail->previous = _head;
}

POSITION list::first(){
	return _head->next;
}

POSITION list::end(){
	return _tail;
}

bool list::insert(ELTYPE element, POSITION pos){

	node *new_node = new node;
	new_node->element = element;
	new_node->previous = pos->previous;
	new_node->next = pos;

	pos->previous->next = new_node;
	pos->previous = new_node;


	return true;
}

bool list::read(POSITION pos, ELTYPE &element){
	element = pos->element;
	return true;
}

bool list::remove(POSITION pos){
	pos->previous->next = pos->next;
	pos->next->previous = pos->previous;

	delete pos;

	return true;
}

POSITION list::find(ELTYPE element){
	node *temp = _head;
	while (temp != end()){
		if (temp->element == element){
			return temp;
		}
		temp = temp->next;
	}
	return end();
}

POSITION list::empty(){
	node *temp = _head->next;
	node *next = temp->next;
	while (temp != end()){
		delete temp;
		temp = next;
		next = temp->next;
	}
	_head->next = _tail;
	_tail->previous = _head;
	return end();
}

POSITION list::next(POSITION pos){
	return pos->next;
}

POSITION list::prev(POSITION pos){
	return pos->previous;
}