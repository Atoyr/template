// 素数判定
static bool IsPrime(int x)
{
    for ( int i = 2; i * i <= x; i++)
    {
        if ( x % i == 0) return false;
    }
    return true;
}
