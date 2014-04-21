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
		if (q.dequeue(element)){
			cout << "The element is: " << element << endl;
		}
	}

	return 0;
}