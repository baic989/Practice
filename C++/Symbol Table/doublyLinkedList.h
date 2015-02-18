#ifndef _LIST_H_
#define _LIST_H_

#include "student.h"
#include <string>

typedef student eltype;
struct node;
typedef node *position;

struct node{
	eltype element;
	position previous;
	position next;
};

class list{
private:
	position _head;				// Pointing to the first element
	position _tail;				// Pointing to the last element
public:
	list();
	position first();			// Returns first element
	position end();				// Returns _tail, not last element
	position empty();
	position next(position);
	position previous(position);
	bool insert(eltype, position);
	bool read(eltype&, position);
	bool remove(position);
};

#endif