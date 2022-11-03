// 順列 nPr
int[] factorial = new int[10000009];
static void initFactorial(int size)
{
    factorial[0] = 0;
    factorial[1] = 1;
    for(int i = 2; i <= size; i++)
    {
        factorial[i] = factorial[i -1] * i;
    }
}

static int Permutation(int n, int r)
{
    return factorial[n] / factorial[n - r];
}
