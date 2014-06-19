#include "symbolTable.h"
using namespace std;

symTable::symTable(){

}

bool symTable::put(string key, eltype value){
	for (position temp = _list.first(); temp != _list.end(); temp = temp->next){
		if (temp->element.personalID == key){
			return false;
		}
	}
	_list.insert(value, _list.end());
	return true;
}

eltype *symTable::get(string key){
	for (position temp = _list.first(); temp != _list.end(); temp = temp->next){
		if (temp->element.personalID == key){
			return &temp->element;
		}
	}
	return nullptr;
}

bool symTable::remove(string key){
	for (position temp = _list.first(); temp != _list.end(); temp = temp->next){
		if (temp->element.personalID == key){
			_list.remove(temp);
			return true;
		}
	}
	return false;
}