// 認証を設定してから認可を設定する
// 2. 認可ポリシーなどの設定
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy =>
    {
        policy.RequireRole("Admin");
    });
});


// 認可
app.UseAuthorization();