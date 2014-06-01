#include "operators.h"

using namespace std;

// Default value
car::car(){
	speed = 0;
	year = 0;
	codename = "";
}

// Custom initialization value
car::car(int spd, int yr, string code){
	speed = spd;
	year = yr;
	codename = code;
}

// Simply returns speed
int car::getSpeed(){
	return speed;
}

// Returns year
int car::getYear(){
	return year;
}

// Returns codename
string car::getCode(){
	return codename;
}

// Sets the speed
void car::setSpeed(int spd){
	speed = spd;
}

// Sets the desired year
void car::setYear(int yr){
	year = yr;
}

// Sets the desired codename
void car::setCode(string code){
	codename = code;
}

// Operator will tell the compiler to add
// the variables speed of two classes so when we type
// car3 = car2 + car1;
// car3 will have the added values of car1 and car2.
// Compiler reads it like
// car3 = car2.operator+(car1);
car car::operator+(car &someCar){
	return car(speed + someCar.getSpeed() + 100, year, codename);
}

// Our assignment operator will let us know if the car is cloned
car car::operator=(car &someCar){
	return car(speed = someCar.getSpeed(), year = someCar.getYear(), codename = someCar.getCode() + " clone");
}

// In this example two cars are equal if
// they are manufactured the same year
bool car::operator==(car &someCar){
	if (this->getYear() == someCar.getYear()){
		return true;
	}
	return false;
}

// In this example one car is "bigger" if
// it's speed is higher
bool car::operator>(car &someCar){
	if (this->getSpeed() > someCar.getSpeed()){
		return true;
	}
	return false;
}
