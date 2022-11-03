// 累積和
// {{_input_:N}} : 配列の長さ
// {{_input_:array_name}} : 整数配列
int[] S = new int[1000000007];

S[0] = 0;
for(int i = 1; i <= {{_input_:N}}; i++)
{
    S[i] = S[i - 1] + {{_input:array_name}}[i];
}


