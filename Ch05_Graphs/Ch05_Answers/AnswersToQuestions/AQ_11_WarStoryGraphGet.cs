using System;
using System.Collections.Generic;
using System.Linq;

/*  5-11. The war story of Section 5.4 (page 158) describes an algorithm for constructing
            the dual graph of the triangulation efficiently, although it does not guarantee linear
            time. Give a worst-case linear algorithm for the problem.

    Consider the representation of data, the same way as in the war story.
    i.e a number vertices, and Triangles mentioned as a set of 3 vertices.
 * 
 * */

namespace Ch05
{

    /*  Steps
     *      create adjacency matrix
     *      it is an Edge<T>[,] array initiated with all values of null
     *      Another array of edges will be maintained
     *          Every element in this array will point to a list of triangles that contain that edge
     *          Thus the Edge should have a List of all triangles
     *      When we read a triangle, for every edge we check if that edge is present in the matrix, 
     *          if so the matrix contains the pointer to the edge. 
     * */

    public class AQ_11_WarStoryGraphGet
    {
    }
}
