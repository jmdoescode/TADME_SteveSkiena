4-27. Let P be a simple, but not necessarily convex, polygon and q an arbitrary point not necessarily in P. Design an efficient algorithm to find a line segment originating from q that intersects the maximum number of edges of P. In other words, if standing at point q, in what direction should you aim a gun so the bullet will go through the largest number of walls. A bullet through a vertex of P gets credit for only one wall. An O(nlogn) algorithm is possible.



<details>
<summary>**ANSWER**</summary>
  <p>

	Since a bullet through a vertex doesn't count as 2 walls, let's describe the polygon P in terms of pairs of points like [(x0,y1),(x2,y2)). That is, the first point will count as a wall, but the second will not.

    Next, let's convert all of the points in P to polar notation. We don't actually need to store the radius, however, just the angle θ. Also, the polar notation is relative to q's location, (qx,qy), so for every point p in P we have θp=atan((py−qy)/(px−qx)). These calculations are done on every point, so a computational complexity of Θ(n).

    Keep a list of the line segments, with points stored as pairs of angles relative to q, and sort them by the minimum of the two angles. It is okay to switch which angle comes first in a pair, but the pairs must move together when they are sorted. It is also important to preserve knowledge of which point was the source (closed interval) and which was the destination (open interval), so we don't count one vertex twice. This sorting costs O(n lg n), and it is the dominant factor in this algorithm.[ 

    Finally, iterate through the sorted list of minimum elements, incrementing a counter whenever the start of a line segment is encountered, and decrementing the counter whenever a line segment ends.


  
  </p>
</details>
