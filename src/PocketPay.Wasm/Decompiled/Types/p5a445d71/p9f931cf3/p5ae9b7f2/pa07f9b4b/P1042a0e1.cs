namespace WillowMaze.Wasm.Decompiled;

public class P1042a0e1 : P47b78e9d
{
    private int F0d3a2b3f;
    private byte[] F0f36a74d;
    private int[] F1d52cc4d;
    private int[] F23228289;
    private int F2817f701;
    private bool F34f20fe7;
    private bool F3c6630e9;
    private byte[] F3c6e0b8a;
    private int[] F40ecc087;
    private byte[] F459981d8;
    private byte[] F671ae024;
    private int[] F7694f4a6;
    private int F7f9bec28;
    private int F811b06de;
    private int[] F83878c91;
    private byte[] F8442f198;
    private byte[] Fb0646cd3;
    private byte[] Fcb7e52b2;
    private int[] Fd4c128c6;
    private byte[] Fd64b8382;
    private bool Fdb1687e1;
    private int Fe4db5398;
    private byte[] Feca26d1e;
    private byte[] Ff0b53b2d;
    private byte[] Ff0ea04d7;
    private int[] Ff75286b0;

    private byte M0d2146e4()
    {
        // call: p1042a0e1.m2764ca9d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f7f9bec28
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.fcb7e52b2
        return 0;
    }

    private int M2764ca9d()
    {
        // call: p1042a0e1.ma12752e3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f2817f701
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f7694f4a6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f83878c91
        return 0;
    }

    private static int Ma12752e3(int P0, int P1)
    {
        return 0;
    }

    private void Me37f0136()
    {
        // str: "The IV must be at least 128 bits long"
        // str: "The key must be 128/256 bits long"
        // call: System.arraycopy
        // call: p1042a0e1.ma12752e3
        // call: IllegalArgumentException.<init>
        // call: p1042a0e1.m2764ca9d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f2817f701
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f7694f4a6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f7f9bec28
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f83878c91
        // type: IllegalArgumentException
    }

    public string GetAlgorithmName()
    {
        // str: "HC-256"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Invalid parameter passed to HC256 init - "
        // call: StringBuilder.toString
        // call: pdd5da44e.getParameters
        // call: p94919be6.getKey
        // call: pdd5da44e.getIV
        // call: IllegalArgumentException.<init>
        // call: object.getClass
        // call: StringBuilder.append
        // call: Type.getName
        // call: StringBuilder.<init>
        // call: p1042a0e1.me37f0136
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.fdb1687e1
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: " not initialised"
        // str: "input buffer too short"
        // str: "output buffer too short"
        // call: p96068848.<init>
        // call: StringBuilder.toString
        // call: p2500579c.<init>
        // call: StringBuilder.append
        // call: p1042a0e1.getAlgorithmName
        // call: p1042a0e1.m0d2146e4
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p1042a0e1.fdb1687e1
        // type: p96068848
        // type: IllegalStateException
        // type: StringBuilder
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: p1042a0e1.me37f0136
    }

    public byte ReturnByte(byte P0)
    {
        // call: p1042a0e1.m0d2146e4
        return 0;
    }

}
