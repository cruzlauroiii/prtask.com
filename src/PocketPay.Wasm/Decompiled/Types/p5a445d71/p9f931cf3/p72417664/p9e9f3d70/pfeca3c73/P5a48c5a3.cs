namespace WillowMaze.Wasm.Decompiled;

public abstract class P5a48c5a3 : Pf0f6addc
{
    private void AddCMacAlgorithm(pa80a706f P0, string P1, string P2, string P3)
    {
        // str: "Alg.Alias.KeyGenerator."
        // str: "KeyGenerator."
        // str: "-CMAC"
        // str: "CMAC"
        // str: "Alg.Alias.Mac."
        // str: "Mac."
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // type: StringBuilder
    }

    private void AddGMacAlgorithm(pa80a706f P0, string P1, string P2, string P3)
    {
        // str: "-GMAC"
        // str: "Alg.Alias.Mac."
        // str: "Alg.Alias.KeyGenerator."
        // str: "KeyGenerator."
        // str: "GMAC"
        // str: "Mac."
        // call: StringBuilder.append
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
    }

    private void AddPoly1305Algorithm(pa80a706f P0, string P1, string P2, string P3)
    {
        // str: "Alg.Alias.KeyGenerator.POLY1305"
        // str: "POLY1305-"
        // str: "KeyGenerator.POLY1305-"
        // str: "Alg.Alias.Mac.POLY1305"
        // str: "Mac.POLY1305-"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pa80a706f.addAlgorithm
        // call: StringBuilder.<init>
        // type: StringBuilder
    }

}
