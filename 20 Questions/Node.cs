namespace _20_Questions
{
    // Public class for nodes in the binary tree.
    public class Node
    {
        // Holds the data within a node.
        private string data;
        // Get and set properties.
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        // Nodes for yes answers.
        private Node yes;
        // Get and set properties.
        public Node Yes
        {
            get
            {
                return yes;
            }
            set
            {
                yes = value;
            }
        }

        // Nodes for no answers.
        private Node no;
        // Get and set properties.
        public Node No
        {
            get
            {
                return no;
            }
            set
            {
                no = value;
            }
        }

        // Class constructor which requires data to hold in the node as a parameter.
        public Node(string data)
        {
            // Initialize the node's data.
            this.data = data;
        }
    }
}
