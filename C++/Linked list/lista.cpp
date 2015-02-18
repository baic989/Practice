#include "lista.h"

list::list(){
	_tail = new node;
	_tail->next = nullptr;

	_head = new node;
	_head->next = _tail;
}

POSITION list::first(){
	return _head->next;
}

POSITION list::end(){
	return _tail;
}

POSITION list::next(POSITION pos){
	return pos->next;
}

POSITION list::prev(POSITION pos){
	node *temp = _head;
	while (temp->next != end() && temp->next != pos){
		temp = temp->next;
	}
	return temp;
}

bool list::insert(ELTYPE element, POSITION pos){
	node *new_node = new node;
	new_node->element = element;

	node *temp = prev(pos);
	temp->next = new_node;
	new_node->next = pos;
	return true;
}

bool list::read(POSITION pos, ELTYPE &element){
	element = pos->element;
	return true;
}

bool list::remove(POSITION pos){
	node *temp = prev(pos);
	temp->next = pos->next;
	delete pos;
	return true;
}

POSITION list::find(ELTYPE element){
	node *temp = _head;
	while (temp->next != end()){
		if (temp->element == element){
			return temp;
		}
		temp = temp->next;
	}
	return end();
}

POSITION list::empty(){
	node *temp = _head->next;

	while (temp != end()){
		node *next = temp->next;
		delete temp;
		temp = next;
	}

	_head->next = _tail;

	return end();
}

