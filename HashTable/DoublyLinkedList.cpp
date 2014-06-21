#include "DoublyLinkedList.h"

list::list(){
	_head = new node;
	_tail = new node;

	_head->next = _tail;
	_head->previous = nullptr;

	_tail->next = nullptr;
	_tail->previous = _head;
}

position list::first(){
	return _head->next;
}

position list::end(){
	return _tail;
}

position list::next(position pos){
	return pos->next;
}

position list::prev(position pos){
	return pos->previous;
}

position list::empty(){
	position temp = _head->next;

	while (temp != end()){
		position temp2 = temp->next;
		delete temp;
		temp = temp2;
	}

	_head->next = _tail;
	_tail->previous = _head;

	return end();
}

position list::find(int number){
	position temp = _head->next;

	while (temp != end()){
		if (temp->element.number == number){
			return temp;
		}

		temp = temp->next;
	}

	return end();
}

bool list::insert(eltype element, position pos){
	node *new_node = new node;

	new_node->element = element;
	new_node->previous = pos->previous;
	new_node->next = pos;

	pos->previous->next = new_node;
	pos->previous = new_node;

	return true;
}

bool list::remove(position pos){
	pos->previous->next = pos->next;
	pos->next->previous = pos->previous;

	delete pos;
	return true;
}

bool list::read(eltype &element, position pos){
	element = pos->element;

	return true;
}