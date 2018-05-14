using System;

/*  Create a Union-Find Data Structure
 * */

namespace Ch06
{
    public class DS_01_UnionFind
    {
    }
}



/*  HINTS: 
 *      
 *      - What properties do you need?
 *          - Size
 *          - Components array
 *          - Parents array
 *          - Number of components
 *      
 *      - Will need a constructor
 *          - need to pass in the size
 *          - need to initialize the parents array 
 *              - should be initialized pointing to itself
 *          - need to initialize the components array
 *              - should all be initialized to 1
 *              
 *      - Will need a Find method
 *          - need to pass in the index of the component
 *          - need to find the root of that component
 *              - it is the one who's parent value is the same as the index
 *          - need to compress the data structure
 *              - make all the parents (starting from the index of the component) = to the actual root
 *              
 *      - Will need a Connected method to see if two components are connected
 *      
 *      - Will need a ComponentSize method to get the size of a component based on index
 *      
 *      - Will need a Union method
 *          - This method will connect two components together based on two indices 
 *              - increase the component size of the larger component
 *              - make the root of smaller component equal the larger one
 *          - return nothing if they're already in the same group
 *          - decrease the number of components
 * */ 
