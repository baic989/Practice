#include <iostream>
#include "queue.h"
using namespace std;

int main(){

	queue q;

	q.enqueue("Hrvoje");
	q.enqueue("Lucija");
	q.enqueue("Jura");

	ELTYPE element;

	while (!q.is_empty()){
		q.dequeue(element);
		cout << "Element is: " << element << endl;
	}

	return 0;
}