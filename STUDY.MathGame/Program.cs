int index = 1;
string name = "Ismael";
char initial = 'I';
int year = 2023;
decimal height = 1.88m;
bool doWeLoveToCode = true;

string myParagraph = $@"These are the most common data types: 
{index++} - string, example: {name}
{index++} - char, example: {initial}
{index++} - integer, example: {year}
{index++} - decimal, example: {height}
{index++} - boolean, example: {doWeLoveToCode}";

Console.WriteLine(myParagraph);

Console.ReadLine();