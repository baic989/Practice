#include <iostream>
using namespace std;

// Note that the array has to be sorted
// in order to perform binary search
int binarySearch(int *p, int n, int element){

	int min, max;
	min = 0;
	max = n - 1;

	while (min <= max){
		int mid = (min + max) / 2;

		if (p[mid] == element){
			// Element found!
			return mid;
		}
		else if (p[mid] > element){
			// In this case the element
			// must be in the left part
			// of the array
			max = mid - 1;
		}
		else{
			// The element is on the right
			// of middle
			min = mid + 1;
		}
	}
	return -1;
}

int main(){

	int p[] = { 1, 2, 3, 6, 8, 10, 11, 14, 35, 65, 76, 77, 87, 99 };

	// 1 is the element we are looking for
	int x = binarySearch(p, 14, 1);

	if (x == -1){
		cout << "Element doesn't exist" << endl;
	}
	else {
		cout << "Found! Element is on index " << x << "!" << endl;
	} 

	return 0;
}