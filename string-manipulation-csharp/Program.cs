Console.Write("Insert the contents of your HTML: ");
string? message = Console.ReadLine();

Console.Write("Insert the HTML tag name: ");
string tagName = Console.ReadLine();

while (tagName.Length == 0)
{
    Console.Write("Null entries are not allowed. Insert the HTML tag name: ");
    tagName = Console.ReadLine();
}

string generatedTag = GenerateHTMLTagWithContent(message, tagName);

ExtractHTMLContent(tagName, generatedTag);

string GenerateHTMLTagWithContent(string? content, string tagName)
{
    string tag = $"<{tagName}>{content}</{tagName}>";
    Console.WriteLine($"Generated HTML: {tag}");

    return tag;
}

string ExtractHTMLContent(string tagName, string HTMLTag)
{
    string startTag = $"<{tagName}>",
        endTag = $"</{tagName}>";

    int startTagIndex = HTMLTag.IndexOf(startTag),
        endTagIndex = HTMLTag.IndexOf(endTag),
        contentLength = endTagIndex - (startTagIndex + startTag.Length);

    string content = HTMLTag.Substring((startTagIndex + startTag.Length), contentLength);

    Console.WriteLine($"Content length: {contentLength}\nExtracted content: {content}");

    return content;
}