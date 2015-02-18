#ifndef _LISTA_H_
#define _LISTA_H_

#include<string>
using namespace std;

struct node;

typedef node *POSITION;
typedef string ELTYPE;

struct node{
	ELTYPE element;
	POSITION next;
};

class list{
private:
	POSITION _head; // Will point to the first element in the list
	POSITION _tail; // Last element will point to _tail
public:
	list();
	POSITION first();
	POSITION end();
	POSITION empty();
	bool insert(ELTYPE element, POSITION pos);
	bool remove(POSITION pos);
	bool read(POSITION pos, ELTYPE &element);
	POSITION find(ELTYPE element);
	POSITION next(POSITION pos);
	POSITION prev(POSITION pos);
};

#endif