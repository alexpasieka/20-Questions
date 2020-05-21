// Using statements.
using System;
using System.IO;

namespace _20_Questions
{
    // Public class for the binary search tree.
    public class BinTree
    {
        // Create a root node.
        public Node root;
        // Create a stream reader.
        private StreamReader reader;
        // Create a string to hold text lines read from a file.
        private string line;
        // Create a stream writer.
        private StreamWriter writer;

        // Function which calls the recursive function to read through a text file to create the binary search tree.
        public void FileInput()
        {
            // Try...
            try
            {
                // ...initializing the stream reader to a specific file.
                reader = new StreamReader("savedTree.txt");
                // Using the stream reader...
                using (reader)
                {
                    // ...initialize the binary search tree.
                    root = RecReadTree();
                }
            }
            // If it doesn't work...
            catch (Exception e)
            {
                // ...display the error message in the console.
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        // Recursive function which creates the tree by reading a text file.
        private Node RecReadTree()
        {
            // Read the next line in the text file.
            line = reader.ReadLine();
            // Read to the end of the text file.
            while (line != null)
            {
                // Save the first character in the line to a variable.
                char firstChar = line[0];
                // Remove that first character from the line.
                line = line.Remove(0, 1);
                // Create a new node that holds the line's text in the node's data.
                Node newNode = new Node(line);
                // If the first character in the line was an "L"...
                if (firstChar == 'L')
                {
                    // ...this line is a leaf node, so set both the "yes" node...
                    newNode.Yes = null;
                    // ...and the "no" to null.
                    newNode.No = null;
                }
                // If the first character in the line was a "B"...
                else if (firstChar == 'B')
                {
                    // ...this line is a branch node, so recursively call this function on both the "yes"...
                    newNode.Yes = RecReadTree();
                    // ...and the "no" node.
                    newNode.No = RecReadTree();
                }
                // Return this new node.
                return newNode;
            }
            // Must return null in case the function does not enter the primary path.
            return null;
        }

        // Function which calls the recursive writing function.
        public void FileOutput()
        {
            // Initialize the stream writer to a specific text file.
            writer = new StreamWriter("savedTree.txt");
            // Using the stream writer...
            using (writer)
            {
                // ...call the recursive function starting at the root of the tree.
                RecSaveTree(root);
            }
        }

        // Recursive function which writes the whole tree traversal to a text file, passing in a root node as a parameter.
        private void RecSaveTree(Node n)
        {
            // If the traversal reaches a branch node...
            if (n.Yes != null && n.No != null)
            {
                // ...write the node's data out to the text file...
                writer.WriteLine("B" + n.Data);
                // ...and call this function on the branch's "yes" leaf...
                RecSaveTree(n.Yes);
                // ...and "no" leaf.
                RecSaveTree(n.No);
            }
            // If the traversal reaches a leaf node...
            else
            {
                // ...write the node's data out to the text file.
                writer.WriteLine("L" + n.Data);
            }
        }
    }
}