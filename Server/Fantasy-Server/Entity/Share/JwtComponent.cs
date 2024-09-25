using Fantasy;
using Fantasy.Entitas;
using Microsoft.IdentityModel.Tokens;
// ReSharper disable All

namespace Model;

public class JwtComponent : Entity
{
    //生成网站 https://www.csfieldguide.org.nz/en/interactives/rsa-key-generator/
    
    /// <summary>
    /// 公钥 PKCS#1 Pem格式
    /// </summary>
    public  readonly string PubicKeyPem =
        "-----BEGIN RSA PUBLIC KEY-----" +
        "MIGJAoGBAIAf3K8d8tR55VA1qGTNcsZzZg93CGnTaQnmQ5WFSR0+kBu1d1fE/B9R" +
        "/SowKrCSOS8VbYwQVXom8eD5N9pcRlxskU5Tb29LyzRF+ODISpQkn6noE21c2bPw" +
        "ppR6Rpl4YFASYXc6lXo1WncMoGJmG4X5LUkPlFYNc9AgbPoFkEPRAgMBAAE=" +
        "-----END RSA PUBLIC KEY-----";
    /// <summary>
    /// 私钥 PKCS#1 Pem格式
    /// </summary>
    public readonly string PrivateKeyPem = "-----BEGIN RSA PRIVATE KEY-----" +
                                        "MIICXAIBAAKBgQCAH9yvHfLUeeVQNahkzXLGc2YPdwhp02kJ5kOVhUkdPpAbtXdX" +
                                        "xPwfUf0qMCqwkjkvFW2MEFV6JvHg+TfaXEZcbJFOU29vS8s0RfjgyEqUJJ+p6BNt" +
                                        "XNmz8KaUekaZeGBQEmF3OpV6NVp3DKBiZhuF+S1JD5RWDXPQIGz6BZBD0QIDAQAB" +
                                        "AoGAZ1/NwajLPO3gu/efFz3ARifjh8TFkATX8fnMO75fgG3y/bhLQxCXT3nqZniY" +
                                        "aQCBjOCgE2s2XClB7P+HNfJPfaaLLVB+uYXmsIPaH9k4unJq8JAYNXtUb85LbTL5" +
                                        "22rDJahpmPkf+pXL9APR+EjoIwMhy6BZIwLhhCBAGasa7CUCQQDdqAvRBTuitfiO" +
                                        "Amn0dJaSa4M81MPHg3nBaFpX/h0jl+UlX0RfgtAUek/9xy+81NH6/2RkDl/nWeun" +
                                        "5kgPQoGrAkEAk/nkClF7POe2Ufmcz8anjEfhRFYo8HKvPKmRmhuuZLLhiH1c1Q4k" +
                                        "4kJD06v5QJGTfHu4ZjqoANlCaPvtAdQMcwJACsWs9VaMxGaVksk5PwEfhDQnZ6Br" +
                                        "d1nDZAvfQCGAZwdtwngzyXSBCk27b3jrsACjx8/7oAU20faDxmAhpmQ0CwJAA/VG" +
                                        "NURysHFePhkYKbKdnrH5g5NuaugWad/7Rg0BgC4MvFLmHcjQEcFGAS5zb1e1gznn" +
                                        "98wP3F3zWc2LTGY4owJBAJFZ7fd9bhgN6e9P0VEnuIxgsvCLheX3FyehMGU0sfPl" +
                                        "TfVJtNyo38kCtTiU7NLnUQ13mL74A0hYfy649Zz1U1Y=" +
                                        "-----END RSA PRIVATE KEY-----";
    
    public SigningCredentials? signingCredentials;
    public TokenValidationParameters? tokenValidationParameters;
}