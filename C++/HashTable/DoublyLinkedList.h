#ifndef _LIST_H_
#define _LIST_H_

#include "player.h"
#include <string>

typedef player eltype;
struct node;
typedef node *position;

struct node{
	eltype element;
	position previous;
	position next;
};

class list{
private:
	position _head;
	position _tail;
public:
	list();
	position first();
	position end();
	position next(position);
	position prev(position);
	position empty();
	position find(int);
	bool insert(eltype, position);
	bool remove(position);
	bool read(eltype&, position);
};

#endif