#ifndef _DICT_H_
#define _DICT_H_

#include "DoublyLinkedList.h"
#include <string>

typedef player eltype;
typedef int key;

class dict{
private:
	static const unsigned int capacity = 7;
	list *_elements[capacity];
	unsigned int hash(key);
public:
	dict();
	void insert(key, eltype);
	void remove(key);
	eltype* search(key);
};

#endif