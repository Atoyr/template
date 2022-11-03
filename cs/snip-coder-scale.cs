// しゃくとり法
// {{_input_:N}} : 配列の長さ
// {{_input_:array_name}} : 整数配列
// {{_input_:K}} : 差
int[] R = new int[1000000007];
for(int i = 1; i <= {{_input_:N}} - 1; i++)
{
    if ( i == 1)
    {
        R[i] = 1;
    }
    else
    {
        R[i] = R[i - 1];
    }

    while (R[i] < N && {{_input_:array_name}}[R[i] + 1] - {{_input_:array_name}}[i] <= {{_input_:K}})
    {
        R[i] += 1;
    }
}

long answer = 0;
for (int i = 1; i <= {{_input_:N}} - 1; i++)
{
    answer += (R[i] - i);
}
