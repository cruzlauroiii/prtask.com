namespace WillowMaze.Wasm.Decompiled;

public class P431357a7 : Pc3ccd415
{
    private static int F10843b2c;
    private static int F549aa581;
    private static int F5abc76b9;
    private static int F620f337b;
    private static int F6e3e638b;
    private static int Fc75e2054;
    private static int Fc9d36483;
    private int[] F0877d161;
    private int[] F141b7219;
    private int[] F1b3cee76;
    private int[] F2a55be48;
    private int[] F2c4a34f9;
    private int[] F5d7ff110;
    private int[] F6ad110f0;
    private int[] F7464da94;
    private int[] F8912ab75;
    private int[] F8bfabcf4;
    private int[] F9061ac58;
    private int[] F96bf0c2c;
    private int[] Fa701eece;
    private int[] Fab41ace2;
    private int[] Fc96c4560;
    private int[] Fcd106c91;
    private int[] Fdf00588d;
    private int[] Fe971d794;
    private int[] Ff3a88bbd;
    private int[] Ffa3696e0;

    private void CAST_Decipher(int P0, int P1, int P2, int P3, int[] P4)
    {
        // call: p431357a7.F2
        // call: p431357a7.F1
        // call: p431357a7.F3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f8912ab75
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f96bf0c2c
    }

    private void CAST_Encipher(int P0, int P1, int P2, int P3, int[] P4)
    {
        // call: p431357a7.F1
        // call: p431357a7.F2
        // call: p431357a7.F3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f96bf0c2c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f8912ab75
    }

    private int DecryptBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p431357a7.BytesTo32bits
        // call: p431357a7.CAST_Decipher
        // call: p431357a7.Bits32ToBytes
        return 0;
    }

    private int EncryptBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p431357a7.Bits32ToBytes
        // call: p431357a7.BytesTo32bits
        // call: p431357a7.CAST_Encipher
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "CAST6"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Reset()
    {
    }

    private void SetKey(byte[] P0)
    {
        // call: p431357a7.F1
        // call: p431357a7.F3
        // call: System.arraycopy
        // call: p431357a7.F2
        // call: p431357a7.BytesTo32bits
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f2a55be48
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.fa701eece
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f1b3cee76
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f96bf0c2c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p431357a7.f8912ab75
    }

}
