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

// Simply return speed
int car::getSpeed(){
	return speed;
}

int car::getYear(){
	return year;
}

string car::getCode(){
	return codename;
}

// Sets the speed
void car::setSpeed(int spd){
	speed = spd;
}

void car::setYear(int yr){
	year = yr;
}

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

car car::operator=(car &someCar){
	return car(speed = someCar.getSpeed(), year = someCar.getYear(), codename = someCar.getCode() + " clone");
}

