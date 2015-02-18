#include "doublyLinkedList.h"
using namespace std;

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

position list::previous(position pos){
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

bool list::insert(eltype element, position pos){
	node *new_node = new node;

	new_node->element = element;
	new_node->next = pos;
	new_node->previous = pos->previous;

	pos->previous->next = new_node;
	pos->previous = new_node;

	return true;
}

bool list::read(eltype &element, position pos){
	element = pos->element;
	return true;
}

bool list::remove(position pos){
	pos->previous->next = pos->next;
	pos->next->previous = pos->previous;

	delete pos;
	return true;
}