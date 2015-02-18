#ifndef _LIST_H_
#define _LIST_H_
#include <string>

typedef unsigned int uint;
typedef uint POSITION;
using namespace std;

class list {
private:
	static const uint CAPACITY = 10;
	string _elements[CAPACITY];
	POSITION _last; // Position of the last element
public:
	list();
	POSITION end(); // Returns a position of the last + 1
	POSITION first(); // Returns first, if the list is empty returns end()
	bool insert(string element, POSITION pos); // Inserts an element to position pos
	bool read(POSITION pos, string &element); // Reference is used so we can return both element and True/False
	bool remove(POSITION pos); // Removes an element on position pos
	POSITION find(string element); // Returns a position of the first match (in case there are more elements named Foo, for example)
	POSITION empty(); // Deletes the whole list and returns end()
	POSITION next(POSITION pos); // Returns first position after pos
	POSITION prev(POSITION pos); // Returns first position before pos
};

#endif