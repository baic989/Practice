#include <iostream>
#include <string>
#include "symbolTable.h"
using namespace std;

void printStudent(student *s){
	if (s != nullptr){
		cout << "Found " << s->firstName << " " << s->lastName << "!" << endl;
	}
	else{
		cout << "Student with given ID not found!" << endl;
	}
}

int main(){


	// Making our guinea pigs
	student s1;
	s1.firstName = "Johnny";
	s1.lastName = "Bravo";
	s1.academicID = "11111";
	s1.personalID = "1111111";

	student s2;
	s2.firstName = "Johnny";
	s2.lastName = "Quid";
	s2.academicID = "22222";
	s2.personalID = "2222222";

	student s3;
	s3.firstName = "Arnold";
	s3.lastName = "Schwarzenegger"; // That is correct
	s3.academicID = "33333";
	s3.personalID = "3333333";


	// Making symbol table
	symTable st;

	st.put(s1.personalID, s1);
	st.put(s2.personalID, s2);
	st.put(s3.personalID, s3);


	// Looking for student
	student *Waldo = st.get("1111111");
	printStudent(Waldo);

	// Looking for non existent
	Waldo = st.get("9999999");
	printStudent(Waldo);

	// Remove and then look for the student
	st.remove("1111111");
	Waldo = st.get("1111111");
	printStudent(Waldo);

	return 0;
}