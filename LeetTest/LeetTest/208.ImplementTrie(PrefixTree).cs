
TestTrie();


void TestTrie()
{
    Trie trie = new Trie();
    trie.Insert("apple");
    trie.Insert("apple");
    trie.Insert("trie");
    trie.Insert("insert");
    trie.Insert("search");
    var res0 = trie.Search("apple");
    var res1 = trie.Search("text");
    var res2 = trie.Search("insert");
    var res3 = trie.StartsWith("app");
    var res4 = trie.StartsWith("one");
}

public class Trie
{
    public Dictionary<char, Trie> dict = new Dictionary<char, Trie>();
    public bool endOfWord = false;

    public Trie() { }

    public void Insert(string word)
    {
        var currTrie = this;
        for (int i = 0; i < word.Length; i++)
        {
            if (currTrie.dict.TryGetValue(word[i], out Trie val))
            {
                currTrie = val;
            }
            else
            {
                var tmp = new Trie();
                currTrie.dict[word[i]] = tmp;
                currTrie = tmp;
            }
        }

        currTrie.endOfWord = true;
    }

    public bool Search(string word)
    {
        var currTrie = this;
        for (int i = 0; i < word.Length; i++)
        {
            if (currTrie.dict.TryGetValue(word[i], out Trie val))
            {
                currTrie = val;
            }
            else return false;
        }

        return currTrie.endOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var currTrie = this;
        for (int i = 0; i < prefix.Length; i++)
        {
            if (currTrie.dict.TryGetValue(prefix[i], out Trie val))
            {
                currTrie = val;
            }
            else return false;
        }

        return true;
    }
}