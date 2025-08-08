namespace MinimalApi.Dominio.ModelViews;

public struct Home
{
    public static string Html()
    {
        return @"<!DOCTYPE html>
<html lang='pt-br'>
<head>
    <meta charset='UTF-8'>
    <title>Minimal API</title>
    <style>
        body { font-family: Arial, sans-serif; text-align: center; margin-top: 80px; }
        h1 { color: #2c3e50; }
        a { color: #0078D7; text-decoration: none; font-weight: bold; font-size: 18px; }
        a:hover { text-decoration: underline; }
    </style>
</head>
<body>
    <h1>🚗 Boas-vindas à API de gerenciamento de veículos</h1>
    <p>Esta é uma API construída com Minimal API para gerenciar veículos, usuários e muito mais.</p>
    <p><a href='/swagger' target='_blank'>➡ Acesse a documentação Swagger</a></p>
</body>
</html>";
    }
}
