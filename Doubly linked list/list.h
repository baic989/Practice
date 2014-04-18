#ifndef _LIST_H_
#define _LIST_H_

#include <string>
using namespace std;

struct node;

typedef string ELTYPE;
typedef node *POSITION;

struct node{
	ELTYPE element;
	POSITION previous;
	POSITION next;
};

class list{
private:
	POSITION _head; // Points to the first element
	POSITION _tail; // Last element points to _tail
public:
	list();
	POSITION first();
	POSITION end();
	POSITION empty();
	bool insert(ELTYPE element, POSITION pos);
	bool read(POSITION pos, ELTYPE &element);
	bool remove(POSITION pos);
	POSITION find(ELTYPE element);
	POSITION next(POSITION pos);
	POSITION prev(POSITION pos);	
};

#endif