//Высокий 4
int n = 10;
while (n < 100)
{
    int reversNum = 0;
    int OrigNum = n;

    int num = n;
    while (num > 0)
    {
        int digit = num % 10;
        reversNum = (reversNum * 10) + digit;
        num /= 10;
    }

    if (OrigNum == reversNum)
    {
        Console.WriteLine(OrigNum);
    }

    n++;
}
