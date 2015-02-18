#ifndef _SYMBOL_TABLE_H_
#define _SYMBOL_TABLE_H_

#include <string>
#include "student.h"
#include "doublyLinkedList.h"

class symTable{
private:
	list _list;
public:
	symTable();
	bool put(std::string key, eltype value);
	bool remove(std::string key);
	eltype *get(std::string key);
};


#endif