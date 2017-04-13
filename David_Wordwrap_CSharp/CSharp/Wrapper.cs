namespace CSharp
{
    public class Wrapper
    {
        public string WrapText(string theText, int columnWidth)
        {
            if (theText.Length > columnWidth)
            {
                var finalSpace = theText.Substring(0, columnWidth).LastIndexOf(' ');
                var hypen = theText.Substring(0, columnWidth).LastIndexOf('-');
                if (finalSpace > 0 && finalSpace > hypen)
                    return theText.Substring(0, finalSpace + 1) + '\n' + WrapText(theText.Substring(finalSpace + 1), columnWidth);
                else if (hypen > 0)
                    return theText.Substring(0, hypen) + '\n' + WrapText(theText.Substring(hypen), columnWidth);
                else
                    return theText.Substring(0, columnWidth) + '\n' + WrapText(theText.Substring(columnWidth), columnWidth);
            }
            else
                return theText;
        }
    }
}
