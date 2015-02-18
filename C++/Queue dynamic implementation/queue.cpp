#include "queue.h"

queue::queue(){
	_head = new node;
	_head->next = nullptr;

	_tail = new node;
	_tail->next = nullptr;
}

bool queue::is_empty(){
	return _head->next == nullptr && _tail->next == nullptr;
}

bool queue::enqueue(ELTYPE element){
	node *new_node = new node;
	new_node->element = element;
	new_node->next = nullptr;

	if (_head->next == nullptr){
		_head->next = new_node;
	}

	if (_tail->next != nullptr) {
		_tail->next->next = new_node;
	}

	_tail->next = new_node;
	return true;
}

bool queue::dequeue(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	node *first = _head->next;

	if (first->next == nullptr){
		_head->next = nullptr;
		_tail->next = nullptr;
	}
	else{
		_head->next = first->next;
	}

	element = first->element;
	delete first;
	return true;
}

bool queue::front(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	element = _head->next->element;
	return true;
}

