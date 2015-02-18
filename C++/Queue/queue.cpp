#include "queue.h"

queue::queue(){
	_head = 0;
	_tail = 0;
}

bool queue::is_full(){
	return _tail + 1 == _head;
}

bool queue::is_empty(){
	return _tail == _head;
}

bool queue::enqueue(ELTYPE element){
	if (is_full()){
		return false;
	}

	_elements[_tail] = element;
	_tail = (_tail + 1) % CAPACITY;
	return true;
}

bool queue::dequeue(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	element = _elements[_head];
	_head = (_head + 1) % CAPACITY;
	return true;
}

bool queue::front(ELTYPE &element){
	if (is_empty()){
		return false;
	}

	element = _elements[_head];
	return true;
}