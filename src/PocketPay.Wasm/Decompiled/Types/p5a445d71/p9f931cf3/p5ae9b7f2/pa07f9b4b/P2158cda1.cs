namespace WillowMaze.Wasm.Decompiled;

public class P2158cda1 : P35da9a23
{
    public string GetAlgorithmName()
    {
        // str: "XSalsa20"
        return string.Empty;
    }

    private int GetNonceSize()
    {
        return 0;
    }

    private void SetKey(byte[] P0, byte[] P1)
    {
        // str: " requires a 256 bit key"
        // str: " doesn't support re-init with null key"
        // call: p2158cda1.salsaCore
        // call: StringBuilder.<init>
        // call: p2158cda1.getAlgorithmName
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: p4492081c.m0eef4fb6
        // call: p35da9a23.setKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p2158cda1.f9457b3e2
        // type: StringBuilder
        // type: IllegalArgumentException
    }

}
