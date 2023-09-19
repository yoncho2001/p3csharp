using System.Text;
using System.Collections;

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree : ICloneable
{
    private String output= "";
    public Node Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Add(int value)
    {
        Root = AddRecursive(Root, value);
    }

    private Node AddRecursive(Node node, int value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.Left = AddRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = AddRecursive(node.Right, value);
        }

        return node;
    }

    public int Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private int SearchRecursive(Node node, int value)
    {
        int valueS = 0;

        if (node == null)
        {
            return -1;
        }

        if (node.Value == value)
        {
            return 1;
        }

        if (value < node.Value)
        {
            valueS = SearchRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            valueS = SearchRecursive(node.Right, value);
        }

        return valueS;
    }

    public void Delete(int value)
    {
        Root = DeleteRecursive(Root, value);
    }

    private Node DeleteRecursive(Node node, int value)
    {
        if (node == null)
        {
            return null;
        }

        if (value < node.Value)
        {
            node.Left = DeleteRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = DeleteRecursive(node.Right, value);
        }
        else
        {
            if (node.Left != null && node.Right != null)
            {
                Node maxNode = FindMax(node.Left);
                node.Value = maxNode.Value;
                node.Left = DeleteRecursive(node.Left, maxNode.Value);
            }
            else
            {
                if (node.Left != null)
                {
                    return node.Left;
                }
                else if (node.Right != null)
                {
                    return node.Right;
                }
                else
                {
                    return null;
                }
            }
        }

        return node;
    }

    private Node FindMax(Node node)
    {
        while (node.Right != null)
        {
            node = node.Right;
        }

        return node;
    }

    public override string ToString()
    {
        treeToString(Root);
        return output;
    }

    private void treeToString(Node node)
    {
        if (node == null)
        {
            return;
        }

        output += node.Value.ToString();
        
        if (node.Left == null && node.Right == null)
        {
            return;
        }

        output += ('(');
        treeToString(node.Left);
        output += (')');

        if (node.Right != null)
        {
            output += ('(');
            treeToString(node.Right);
            output += (')');
        }
    }

    public override bool Equals(object? objekt)
    {
        if (objekt == null || GetType() != objekt.GetType())
            return false;

        BinaryTree other = (BinaryTree)objekt;
        return AreTreesEqual(this.Root, other.Root);
    }

    private bool AreTreesEqual(Node objekt1, Node objekt2)
    {
        if (objekt1 == null && objekt2 == null) return true;
        if (objekt1 == null || objekt2 == null) return false;

        return objekt1.Value == objekt2.Value &&
               AreTreesEqual(objekt1.Left, objekt2.Left) &&
               AreTreesEqual(objekt1.Right, objekt2.Right);
    }

    public override int GetHashCode()
    {
        return Root == null ? 0 : HashSum(Root);
    }

    public int HashSum(Node objekt)
    {
        return objekt.Value.GetHashCode() ^ HashSum(objekt.Left) ^ HashSum(objekt.Right);
    }

    public static bool operator ==(BinaryTree objekt1, BinaryTree objekt2)
    {
        return objekt1.Equals(objekt2);
    }

    public static bool operator !=(BinaryTree objekt1, BinaryTree objekt2)
    {
        return !objekt1.Equals(objekt2);
    }

    public object Clone()
    {
        BinaryTree newTree = new BinaryTree();
        newTree.Root = CloneRecursive(this.Root);
        return newTree;
    }

    private Node CloneRecursive(Node node)
    {
        if (node == null)
        {
            return null;
        }

        Node newNode = new Node(node.Value);
        newNode.Left = CloneRecursive(node.Left);
        newNode.Right = CloneRecursive(node.Right);
        return newNode;
    }
}