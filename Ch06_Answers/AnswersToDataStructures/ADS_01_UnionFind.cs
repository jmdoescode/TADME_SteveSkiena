using System;

namespace Ch06
{
    public class ADS_01_UnionFind
    {
        private int size;               // the number of elements in the data structure
        private int[] componentSize;    // the number of elements in a component
        private int[] parent;           // parent[i] points to the parent of i (if i = parent[i] then it has no parent or is the root)
        private int numComponents;      // the number of components in the data structure

        public int Size { get { return this.size; } }                   // returns the size of the data structure
        public int Components { get { return this.numComponents; } }    // returns the number of remaining components

        public ADS_01_UnionFind(int numElements)
        {
            if (size <= 0) throw new Exception("Cannot have 0 or less elements");

            size = numComponents = numElements;
            componentSize = new int[numElements];
            parent = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                componentSize[i] = 1;   // each component is originally size 1
                parent[i] = i;          // links to itself
            }
        }

        public int Find(int indexOfComponent)
        {
            int root = parent[indexOfComponent];

            // get the root of the indexOfComponent
            while (root != parent[root])
            {
                root = parent[root];
            }

            // compress the data structure 
            // make all components point to the root as the parent
            // this is known as path compression which gives us amortized constant time complexity
            while (root != indexOfComponent)
            {
                int next = parent[indexOfComponent];
                parent[indexOfComponent] = root;
                indexOfComponent = next;
            }

            return root;
        }

        /// <summary>
        /// Finds whether or not a component is connected to another component
        /// </summary>
        /// <param name="p">index value 1</param>
        /// <param name="q">index value 2</param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        /// <summary>
        /// returns the size for which the component belongs to
        /// </summary>
        /// <param name="indexOfComponent">The index of the component</param>
        /// <returns></returns>
        public int ComponentSize(int indexOfComponent)
        {
            return componentSize[indexOfComponent];
        }

        /// <summary>
        /// Gets two components and connects / unionizes them together so that they are one component.
        /// In code this will point all the parents of one component to the root of the other component.
        /// It will connect smallest to the largest component.
        /// </summary>
        /// <param name="compA">Index of component A</param>
        /// <param name="compB">Index of component B</param>
        public void Union(int compA, int compB)
        {
            int rootA = Find(compA);
            int rootB = Find(compB);

            // nothing needed since they are already in the same group
            if (rootA == rootB) return;

            // merge the smallest of the two components to the largest one
            if (componentSize[rootA] < componentSize[rootB])
            {
                componentSize[rootB] += componentSize[rootA];
                parent[rootA] = rootB;
            }
            else
            {
                componentSize[rootA] += componentSize[rootB];
                parent[rootB] = rootA;
            }

            // decrease the number of components since we have merged them as one
            numComponents--;
        }
    }
}
