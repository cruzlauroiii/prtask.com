namespace WillowMaze.Wasm.Decompiled;

public class P4a9ff35b : Pd81e8b93
{
    private static int F05064252;
    private static int[] F2a229599;
    private static int F50a85cdb;
    private static int F620f337b;
    private static int F77cc92af;
    private static int[] Fa5f3c6a1;
    private static int Fc75e2054;
    private static int Fdc3bab45;
    private int[] F0d9d1f7a;
    private bool F9301aa9b;
    private bool F9cb19c45;
    private bool Fc24c5ba8;
    private int[] Fc3236ca8;
    private int[] Fd798c813;

    private void M38ba9ce4(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p4a9ff35b.me8d7bec7
        // call: p4a9ff35b.meaa1a095
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.fa5f3c6a1
    }

    private void M54b8c68b(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p4a9ff35b.me8d7bec7
        // call: p4a9ff35b.meaa1a095
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.fa5f3c6a1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f0d9d1f7a
    }

    private void M6544ab85(byte[] P0, int[] P1, int P2, int P3)
    {
    }

    private void Me8d7bec7(int[] P0, byte[] P1, int P2)
    {
    }

    private void Meaa1a095(byte[] P0, int[] P1, int P2, int P3)
    {
    }

    public string GetAlgorithmName()
    {
        // str: "Shacal2"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "only simple KeyParameter expected."
        // call: p94919be6.getKey
        // call: p4a9ff35b.setKey
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f9301aa9b
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // str: "Shacal2 not initialised"
        // call: p2500579c.<init>
        // call: p4a9ff35b.m38ba9ce4
        // call: p4a9ff35b.m54b8c68b
        // call: IllegalStateException.<init>
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f9301aa9b
        // type: IllegalStateException
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
    }

    public void SetKey(byte[] P0)
    {
        // str: "Shacal2-key must be 16 - 64 bytes and multiple of 8"
        // call: p4a9ff35b.m6544ab85
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4a9ff35b.f0d9d1f7a
        // type: IllegalArgumentException
    }

}
