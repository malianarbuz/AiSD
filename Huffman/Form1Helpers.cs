using Huffman;

internal static class Form1Helpers
{
    public static void GenerateCodes(Node tree, List<String> codes,  String code="")
    {
        if (tree.left != null)
            GenerateCodes(tree.left, codes, code + "0");
        if (tree.right != null)
            GenerateCodes(tree.right, codes, code + "1");
        if (tree.left == null && tree.right == null)
        {
            NodeS tree1 = (NodeS)tree;
            codes.Add(tree1.symbol +" "+ code);
        }
    }
}