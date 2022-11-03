// 順列 nPr
static T Permutation<T>(T n, T r)
{
    T ret = n;
    for(T i = n - 1; n - r < i; i--)
    {
        ret *= i;
    }
    return ret;
}
