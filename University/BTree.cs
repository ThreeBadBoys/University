using System;

namespace UniversityClasses
{
    [Serializable]
    class BTree
    {
        private static int M = 4;

        private Node root;       // root of the B-tree
        private int height;      // height of the B-tree
        private int n;           // number of key-value pairs in the B-tree
                                 // helper B-tree node data type
        public class Node
        {
            public int m;                             // number of children
            public Entry[] children = new Entry[M];   // the array of children

            // create a node with k children
            public Node(int k)
            {
                m = k;
            }
        }

        // internal nodes: only use key and next
        // external nodes: only use key and value
        public class Entry
        {
            public string key;
            public string address;
            public Node next;     // helper field to iterate over array entries
            public Entry(string key, string address, Node next)
            {
                this.key = key;
                this.address = address;
                this.next = next;
            }
        }
        /**
         * Initializes an empty B-tree.
         */
        public BTree()
        {
            root = new Node(0);
        }

        /**
         * Returns true if this symbol table is empty.
         * @return {@code true} if this symbol table is empty; {@code false} otherwise
         */
        public bool isEmpty()
        {
            return size() == 0;
        }

        /**
         * Returns the number of key-value pairs in this symbol table.
         * @return the number of key-value pairs in this symbol table
         */
        public int size()
        {
            return n;
        }

        /**
         * Returns the height of this B-tree (for debugging).
         *
         * @return the height of this B-tree
         */
        public int Height()
        {
            return height;
        }


        /**
         * Returns the value associated with the given key.
         *
         * @param  key the key
         * @return the value associated with the given key if the key is in the symbol table
         *         and {@code null} if the key is not in the symbol table
         * @throws IllegalArgumentException if {@code key} is {@code null}
         */
        public string get(string key)
        {
            if (key == null) throw new ArgumentOutOfRangeException("argument to get() is null");
            return search(root, key, height);
        }

        private string search(Node x, string key, int ht)
        {
            Entry[] children = x.children;

            // external node
            if (ht == 0)
            {
                for (int j = 0; j < x.m; j++)
                {
                    if (equal(key, children[j].key)) return children[j].address;
                }
            }

            // internal node
            else
            {
                for (int j = 0; j < x.m; j++)
                {
                    if (j + 1 == x.m || less(key, children[j + 1].key))
                        return search(children[j].next, key, ht - 1);
                }
            }
            return null;
        }


        /**
         * Inserts the key-value pair into the symbol table, overwriting the old value
         * with the new value if the key is already in the symbol table.
         * If the value is {@code null}, this effectively deletes the key from the symbol table.
         *
         * @param  key the key
         * @param  val the value
         * @throws IllegalArgumentException if {@code key} is {@code null}
         */
        public void put(string key, string address)
        {
            if (key == null) throw new ArgumentOutOfRangeException("argument key to put() is null");
            Node u = insert(root, key, address, height);
            n++;
            if (u == null) return;

            // need to split root
            Node t = new Node(2);
            t.children[0] = new Entry(root.children[0].key, null, root);
            t.children[1] = new Entry(u.children[0].key, null, u);
            root = t;
            height++;
        }

        private Node insert(Node h, string key, string address, int ht)
        {
            int j;
            Entry t = new Entry(key, address, null);

            // external node
            if (ht == 0)
            {
                for (j = 0; j < h.m; j++)
                {
                    if (less(key, h.children[j].key)) break;
                }
            }

            // internal node
            else
            {
                for (j = 0; j < h.m; j++)
                {
                    if ((j + 1 == h.m) || less(key, h.children[j + 1].key))
                    {
                        Node u = insert(h.children[j++].next, key, address, ht - 1);
                        if (u == null) return null;
                        t.key = u.children[0].key;
                        t.next = u;
                        break;
                    }
                }
            }

            for (int i = h.m; i > j; i--)
                h.children[i] = h.children[i - 1];
            h.children[j] = t;
            h.m++;
            if (h.m < M) return null;
            else return split(h);
        }

        // split node in half
        private Node split(Node h)
        {
            Node t = new Node(M / 2);
            h.m = M / 2;
            for (int j = 0; j < M / 2; j++)
                t.children[j] = h.children[M / 2 + j];
            return t;
        }

        /**
         * Returns a string representation of this B-tree (for debugging).
         *
         * @return a string representation of this B-tree.
         */
        public string toString()
        {
            return toString(root, height, "") + "\n";
        }

        private string toString(Node h, int ht, string indent)
        {
            string s = null;
            Entry[] children = h.children;

            if (ht == 0)
            {
                for (int j = 0; j < h.m; j++)
                {
                    s += indent + children[j].key + " " + children[j].address + "\n";
                }
            }
            else
            {
                for (int j = 0; j < h.m; j++)
                {
                    if (j > 0) s += indent + "(" + children[j].key + ")\n";
                    s += toString(children[j].next, ht - 1, indent + "     ");
                }
            }
            return s;
        }


        // comparison functions - make Comparable instead of Key to avoid casts
        private bool less(string k1, string k2)
        {
            return k1.CompareTo(k2) < 0;
        }

        private bool equal(string k1, string k2)
        {
            return k1.Equals(k2);
        }

    }
}
