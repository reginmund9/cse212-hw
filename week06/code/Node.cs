public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (Contains(value)) {
        // Value already exists in the tree, do not insert duplicates
        return;
        }
    
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (Data == value) {
        return true; // Value found at this node
        } else if (value < Data && Left != null) {
            return Left.Contains(value); // Search in the left subtree
        } else if (value > Data && Right != null) {
            return Right.Contains(value); // Search in the right subtree
        } else {
            return false; // Value not found
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
       int leftHeight = Left?.GetHeight() ?? 0;
       int rightHeight = Right?.GetHeight() ?? 0;
       return 1 + Math.Max(leftHeight, rightHeight);
    }
    
}