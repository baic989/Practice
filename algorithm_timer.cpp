#include <iostream>
#include <ctime>
#include <stdio.h>
using namespace std;

// Dummy function to be called in nested loops
void code_to_time(){

}

// First funciton to measure O(n)
void f1(long int iters){
	time_t start, end;
	time (&start);
	for(long i = 1; i<= iters; i++){
		code_to_time();
	}
	time (&end);
	double dif = difftime(end, start);
	cout << "Elapsed time: " << dif << endl;
}

// Second function to measure O(n^2)
void f2(int iters){
	time_t start, end;
	time (&start);
	for(int i = 1; i<= iters; i++){
		for(int j= 1; j<=iters; j++){
			code_to_time();
		}
	}
	time (&end);
	double dif = difftime(end, start);
	cout << "Elapsed time: " << dif << endl;
}

// Third function to measure O(n^3)
void f3(int iters){
	time_t start, end;
	time (&start);
	for(int i = 1; i<= iters; i++){
		for(int i= 1; i<=iters; i++){
			for(int k= 1; k<=iters; k++){
			code_to_time();
			}
		}
	}
	time (&end);
	double dif = difftime(end, start);
	cout << "Elapsed time: " << dif << endl;
}

int main(){
	long int iters1 = 100000000;
	int iters2 = 10000;
	int iters3 = 1000;

	f1(iters1);
	f2(iters2);
	f3(iters3);

	cout << endl;
	system("pause");
	return 0;

}
