#include "dictionary.h"

dict::dict(){
	for (int i = 0; i < capacity; i++){
		_elements[i] = new list;
	}
}

unsigned int dict::hash(key k){
	return k % 7;
}

void dict::insert(key k, eltype element){
	unsigned int index = hash(k);

	_elements[index]->insert(element, _elements[index]->end());
}

void dict::remove(key k){
	unsigned int index = hash(k);

	position pos = _elements[index]->find(k);
	_elements[index]->remove(pos);
}

eltype *dict::search(key k){
	unsigned int index = hash(k);
	position pos = _elements[index]->find(k);
	
	if (pos != _elements[index]->end()){
		player *p = new player;

		_elements[index]->read(*p, pos);
		return p;
	}
	else{
		return nullptr;
	}
}

