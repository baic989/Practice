#ifndef _OPERATORS_H_
#define _OPERATORS_H_

#include <string>

class car{
private:
	int speed;
	int year;
	std::string codename;

public:
	car();
	car(int, int, std::string); // overloaded constructor so initial speed can be set
	~car(){};
	int getSpeed();
	int getYear();
	std::string getCode();
	void setSpeed(int);
	void setYear(int);
	void setCode(std::string);
	car operator+(car&); // Will define the '+' operator for our class
	car operator=(car&); // Will define the '=' operator for our class
	bool operator==(car&); // Will define when two cars are the same
	bool operator>(car&); // Will define when one car is "bigger"
};


#endif