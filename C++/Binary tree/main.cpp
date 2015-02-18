#include <iostream>
#include "binary_tree.h"
using namespace std;

int main(){

	binary_tree tree;
	tree.create("A");

	POSITION node_a = tree.root();
	tree.insert_left(node_a, "B");

	POSITION node_b = tree.get_left_child(node_a);
	tree.insert_right(node_a, "C");

	POSITION node_c = tree.get_right_child(node_a);
	tree.insert_left(node_b, "D");

	tree.insert_left(node_c, "E");

	tree.print_tree();

	return 0;
}
