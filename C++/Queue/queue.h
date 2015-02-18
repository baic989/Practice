#ifndef _QUEUE_H_
#define _QUEUE_H_

#include <string>
using namespace std;

typedef string ELTYPE;

class queue{
private:
	static const unsigned int CAPACITY = 6;
	ELTYPE _elements[CAPACITY];

	unsigned int _head;
	unsigned int _tail;

	bool is_full();

public:
	queue();
	bool is_empty();
	bool enqueue(ELTYPE element);
	bool dequeue(ELTYPE &element);
	bool front(ELTYPE &element);
};

#endif