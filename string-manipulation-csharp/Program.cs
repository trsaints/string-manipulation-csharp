const string HTMLInput = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string HTMLInputChild = GetChildHTMLContent(HTMLInput, "div");
int quantity = GetQuantityFromHTML(HTMLInputChild, "span");
string output = $"Output: {HTMLInputChild}";

// Your work here

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine(output);

string GetChildHTMLContent(string HTML, string parentTagName)
{
    string openingTag = $"<{parentTagName}>",
        closingTag = $"</{parentTagName}>";

    int openingPosition = HTML.IndexOf(openingTag),
        closingPosition = HTML.IndexOf(closingTag),
        openingTagLength = openingPosition + openingTag.Length,
        childLength = closingPosition - openingTagLength;

    return HTML.Substring(openingTagLength, childLength);
}

int GetQuantityFromHTML(string HTML, string quantityTagName)
{
    string openingTag = $"<{quantityTagName}>",
        closingTag = $"</{quantityTagName}>";

    int openingPosition = HTML.IndexOf(openingTag),
        closingPosition = HTML.IndexOf(closingTag),
        openingTagLength = openingPosition + openingTag.Length,
        childLength = closingPosition - openingTagLength;

    string content = HTML.Substring(openingTagLength, childLength);

    if (int.TryParse(content, out _))
        return int.Parse(content);
    else
        return -1;
}