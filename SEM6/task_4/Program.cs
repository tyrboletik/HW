//Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.
static string NewMethod(string strNew)
{
    string[] strNewSplit = strNew.Split();

    string res = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }

    return res;
}

string strNew = "Hello my world";
string res = NewMethod(strNew);
Console.WriteLine(res);