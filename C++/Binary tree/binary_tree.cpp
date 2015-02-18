#include "binary_tree.h"
#include <iostream>
using namespace std;


/*************** PRIVATE METHODS ***************/

POSITION binary_tree::calc_left(const POSITION pos){
	return 2 * pos + 1;
}

POSITION binary_tree::calc_right(const POSITION pos){
	return 2 * pos + 2;
}

bool binary_tree::is_valid_pos(const POSITION pos){
	return pos >= 0 && pos < CAPACITY;
}

bool binary_tree::insert(const POSITION pos, const ELTYPE &element){
	if (!is_valid_pos(pos)){
		return false;
	}

	node new_node;
	new_node.element = element;
	_elements[pos] = new_node;
	
	last = pos;
	return true;
}


/*************** PUBLIC METHODS ***************/

void binary_tree::create(const ELTYPE &element){
	node root;
	root.element = element;
	_elements[0] = root;
	last = 0;
}

bool binary_tree::insert_left(const POSITION parent, const ELTYPE &element){
	POSITION pos = calc_left(parent);
	return insert(pos, element);
}

bool binary_tree::insert_right(const POSITION parent, const ELTYPE &element){
	POSITION pos = calc_right(parent);
	return insert(pos, element);
}

POSITION binary_tree::root(){
	return 0;
}

POSITION binary_tree::get_left_child(const POSITION parent){
	return calc_left(parent);
}

POSITION binary_tree::get_right_child(const POSITION parent){
	return calc_right(parent);
}

bool binary_tree::get_node(const POSITION pos, ELTYPE &element){
	if (!is_valid_pos(pos)){
		return false;
	}

	element = _elements[pos].element;
	return true;
}

void binary_tree::print_tree(){
	for (unsigned int i = 0; i <= last; i++){
		cout << "(" << i << ")" << _elements[i].element << endl;
	}
}