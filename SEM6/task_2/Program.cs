// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
static string UpperToLower(string str)
{
    string strResult = string.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            strResult += char.ToLower(str[i]);
        }
        else
        {
            strResult += str[i];
        }
    }

    return strResult;
}

string str = "aBcDlef!-";

string strResult = UpperToLower(str);

Console.WriteLine(strResult);
