6-12. Devise an efficient data structure to handle the following operations on a weighted directed graph:

(a) Merge two given components.
(b) Locate which component contains a given vertex v.
(c) Retrieve a minimum edge from a given component.


<details>
<summary>**ANSWER**</summary>
  <p>

  Create a union-find data structure. Your data structure will include these properties:

  - An array of Vertices that holds the Vertex at a given index. It does not matter what order they are in as long as you know what the value of the node is at the index. For example: index of 0 holds node A, index of 1 holds node D, etc...
  - An array for Parents of the Vertices (this will be the parent of the given component (the component of the index can be found using the Vertices array) - if the parent value is the same as the component value then it is either the root or it is an individual component).
  - An array for the Component's Size (this will be how many components are unioned to the root).
  - An int value for the number of components in the data structure (should be initialized to the number of vertices).
  - An int value for the size of the data structure (the number of elements in the data structure).
  - An array to hold the minimum weight of a component at the root.


  (a) To merge two components:

  - Create a void method, this will be your union method, which takes two ints as paramenters (one for index of Component A and one for index of Component B). 
  - Find the roots for component A and B. 
  - If the roots are the same return nothing. 
  - Merge the smallest of the two components to the biggest one; you will also need to increase the size of the larger component as well as change the parent for the smaller component to that of the larger component. You will also need to update the minimum weight array and whichever value is smaller update the value at the root. 
  - Then you need to decrease the number of components since they were just merged.

  (b) To locate which component contains a given vertex v:

  - Create an int method, this will be your find method, which takes the index of the component as the parameter.
  - Get the root of the component. The root is found with a while loop that gets the parent of the component until the parent of the index of component is the same as the index of the component. So until root == parent[root].
  - Then you compress the data strucure by making all the parent's (from the index of the component to the root) the same value as the root. This way all the components will have the same root value and it takes only one stop to get the root rather than follow more than one value to get to the root.
  - Then return the root.

  (c) Retrieve a minimum edge from a given component.

  - Create an int method, this will be your minimum edge of component method which will take the index of any part of the component.
  - Get the root by finding the parent of the index of the component.
  - Get the value of minimum weight array passing in the root as the index.
  - Return the value.

	
  </p>
</details>