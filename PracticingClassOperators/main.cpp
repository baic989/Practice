#include "operators.h"
#include <iostream>
using namespace std;

int main(){

	// Initialize
	car Ford, Mazda, Ferrari, Mazda6;

	// Set speed
	Ford.setSpeed(100);
	Mazda.setSpeed(150);

	// Set year
	Ford.setYear(1990);
	Mazda.setYear(2000);

	// Set codename (only for Mazda as we copy only that one)
	Mazda.setCode("ASCA344435-991KKHUIJ1");

	// Testing the copy constructor
	// Ferrari's speed will be 350 instead of 250
	// as we added +100 in our copy constructor
	Ferrari = Ford + Mazda;

	cout << "Ferrari:\t" << Ferrari.getSpeed() << "km/h" << endl;
	cout << "Mazda:\t" << Mazda.getSpeed() << "km/h" << endl;
	cout << "Ford:\t" << Ford.getSpeed() << "km/h" << endl;

	// Testing assignment constructor
	// Mazda6 codename will let us know the
	// car is cloned
	Mazda6 = Mazda;

	cout << endl;
	cout << "Mazda6\t\t" << Mazda6.getSpeed() << "km/h" << endl;
	cout << "Mazda6 year\t" << Mazda6.getYear() << "." << endl;
	cout << "Mazda6 code\t" << Mazda6.getCode() << endl;

	cout << "Mazda code\t" << Mazda.getCode() << endl;


	// Testing bool operators "==" and ">"
	cout << endl;
	cout << "Ferrari is faster than Mazda: " << (Ferrari > Mazda) << endl;
	cout << "Ford is faster than Mazda: " << (Ford > Mazda) << endl;

	return 0;
}