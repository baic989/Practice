#include "list.h"

list::list(){
	//Initializes our list and predefines the last value
	_last = 0;
}

POSITION list::end(){
	return _last + 1;
}

POSITION list::first(){
	return 1;
}

bool list::insert(string element, POSITION pos){
	// Checks if the place is correct
	if (pos >= first() && pos <= end() && _last < CAPACITY){
		// Shift to the right
		for (uint i = _last; i >= pos; i--){
			_elements[i] = _elements[i - 1];
		}
		// Insert new and update _last
		_elements[pos - 1] = element;
		_last++;
		return true;
	}
	return false;
}

bool list::read(POSITION pos, string &element){
	// Checks if the position is correct
	if (pos >= first() && pos < end()){
		element = _elements[pos - 1];
		return true;
	}
	return false;
}

bool list::remove(POSITION pos){
	// Checks if the position is correct
	if (pos >= first() && pos < end()){
		// Shift to the left
		for (uint i = pos; i < _last; i++){
			_elements[i] = _elements[i + 1];
		}
		_last--;
		return true;
	}
	return false;
}

POSITION list::find(string element){
	for (uint i = first()-1; i < end(); i++){
		if (_elements[i] == element){
			return i + 1;
		}
	}
	return end();
}

POSITION list::empty(){
	_last = 0;
	return end();
}

POSITION list::next(POSITION pos){
	return pos + 1;
}

POSITION list::prev(POSITION pos){
	return pos - 1;
}