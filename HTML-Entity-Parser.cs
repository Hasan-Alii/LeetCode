public class Solution {
    public string EntityParser(string text) {
        Hashtable tags = new Hashtable();
        tags.Add("&quot;", "\"");
        tags.Add("&apos;", "'");
        tags.Add("&gt;", ">");
        tags.Add("&lt;", "<");
        tags.Add("&frasl;", "/");
        string text2 = "";
        foreach (string tag in tags.Keys)
            {
            if (text.Contains(tag))
                text = text.Replace(tag, tags[tag]!.ToString());
        }
        if (text.Contains("&amp;"))
            text = text.Replace("&amp;", "&");
        return text;
    }
}
