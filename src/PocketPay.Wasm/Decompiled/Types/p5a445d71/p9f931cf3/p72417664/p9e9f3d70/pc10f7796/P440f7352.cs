namespace WillowMaze.Wasm.Decompiled;

public abstract class P440f7352 : Pf0f6addc
{
    private void AddHMACAlgorithm(pa80a706f P0, string P1, string P2, string P3)
    {
        // str: "Alg.Alias.KeyGenerator.HMAC/"
        // str: "HMAC"
        // str: "Alg.Alias.Mac.HMAC-"
        // str: "Alg.Alias.KeyGenerator.HMAC-"
        // str: "KeyGenerator."
        // str: "Mac."
        // str: "Alg.Alias.Mac.HMAC/"
        // call: StringBuilder.append
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
    }

    private void AddHMACAlias(pa80a706f P0, string P1, p364bf33a P2)
    {
        // str: "Alg.Alias.KeyGenerator."
        // str: "HMAC"
        // str: "Alg.Alias.Mac."
        // call: StringBuilder.<init>
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // type: StringBuilder
    }

}
