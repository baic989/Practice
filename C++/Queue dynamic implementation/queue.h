#ifndef _QUEUE_H_
#define _QUEUE_H_

#include <string>
using namespace std;

typedef string ELTYPE;

struct node{
	ELTYPE element;
	node *next;
};

class queue{
private:
	node *_head;
	node *_tail;

public:
	queue();
	bool is_empty();
	bool enqueue(ELTYPE element);
	bool dequeue(ELTYPE &element);
	bool front(ELTYPE &element);
};


#endif