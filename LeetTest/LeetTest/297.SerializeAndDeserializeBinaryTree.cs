using LeetTest.Models;

ExamineSerialisation(new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))));

const string nullIndicator = "#";

TreeNode ExamineSerialisation(TreeNode root)
{
    var data = serialize(root);
    var deserialised = deserialize(data);

    return deserialised;
}

// Encodes a tree to a single string.
string serialize(TreeNode root)
{
    var valList = new List<string>();
    void Dfs(TreeNode node)
    {
        if (node == null)
        {
            valList.Add(nullIndicator);
            return;
        }

        valList.Add($"{node.val}");
        Dfs(node.left);
        Dfs(node.right);
    }

    Dfs(root);
    var serialisedStr = string.Join(",", valList);
    Console.WriteLine(serialisedStr);
    return serialisedStr;
}

// Decodes your encoded data to tree.
TreeNode deserialize(string data)
{
    var nodesArr = data.Split(',');
    int arrIndx = 0;

    TreeNode Dfs()
    {
        if (nodesArr[arrIndx] == nullIndicator)
        {
            arrIndx++;
            return null;
        }

        var rootNode = new TreeNode(int.Parse(nodesArr[arrIndx++]));
        rootNode.left = Dfs();
        rootNode.right = Dfs();

        return rootNode;
    }

    var deserialised = Dfs();
    return deserialised;
}
