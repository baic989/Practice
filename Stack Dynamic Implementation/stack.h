#ifndef _STACK_H_
#define _STACK_H_

using namespace std;

typedef int ELTYPE;

struct node{
	ELTYPE element;
	node *under;
};

class stack{
private:
	node *_top; // Points to the element on top or to the _bottom if stack is empty
	node *_bottom;

public:
	stack();
	void empty();
	bool is_empty();
	bool push(ELTYPE element);
	bool pop(ELTYPE &element);
	bool top(ELTYPE &element);
};


#endif