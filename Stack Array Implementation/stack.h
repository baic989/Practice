#ifndef _STACK_H_
#define _STACK_H_

#include <string>
using namespace std;

typedef int ELTYPE;

class stack{
private:
	static const unsigned int CAPACITY = 10;
	ELTYPE _elements[CAPACITY];
	unsigned int _vrh;
	bool is_full();

public:
	stack();
	void empty();
	bool is_empty();
	bool push(ELTYPE element);
	bool pop(ELTYPE &element);
	bool top(ELTYPE &element);
};

#endif