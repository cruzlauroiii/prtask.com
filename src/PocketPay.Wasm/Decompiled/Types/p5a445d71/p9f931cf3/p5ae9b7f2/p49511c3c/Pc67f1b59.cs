namespace WillowMaze.Wasm.Decompiled;

public class Pc67f1b59 : P55d6939e
{
    private static byte F04299473;
    private static byte F0f09b1da;
    private static byte F425cc05e;
    private static byte F61db593a;
    private static byte F63e8bce9;
    private static byte F9e4bc6c7;
    private static byte Fdf9e459c;
    private static byte Ff2651be8;

    private static void M945926b9(byte P0, byte P1)
    {
        // str: "Invalid format for r portion of Poly1305 key."
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    public static void Ma597a055(byte[] P0)
    {
        // str: "Poly1305 key must be 256 bits."
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    public static void Me8701a96(byte[] P0)
    {
        // str: "Poly1305 key must be 256 bits."
        // call: pc67f1b59.m945926b9
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    public byte[] GenerateKey()
    {
        // call: pc67f1b59.ma597a055
        // call: p55d6939e.generateKey
        return default!;
    }

    public void Init(pf7bb6344 P0)
    {
        // call: pf7bb6344.getRandom
        // call: pf7bb6344.<init>
        // call: p55d6939e.init
        // type: pf7bb6344
    }

}
