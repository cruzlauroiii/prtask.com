namespace WillowMaze.Wasm.Decompiled;

public class P84f1c057 : P1748c064
{
    private static byte F09b5f508;
    private static byte F13110c36;
    private static byte F15374a1c;
    private static byte F5b377a1e;
    private static byte Fa23f5bd7;
    private static byte Fb1bfe26c;
    private static int Fe3a0a6b0;
    private static int Fe76739cb;
    private int F08501003;
    private byte[] F246c6bb3;
    private byte[] F2862ab37;
    private byte[] F477c684e;
    private int F4c64bc33;
    private byte[] F58860f06;
    private pe5cfc515 F7f160557;
    private int F9255f8d1;
    private pe5cfc515 F9dde1bea;
    private byte[] F9fd97ad1;
    private byte[] Fb4f33c31;
    private pe5cfc515 Fc10f7796;
    private byte[] Fd027420f;
    private pe5cfc515 Fed5a2f7c;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p84f1c057.reset
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f477c684e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f9255f8d1
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/HMAC"
        // call: pe5cfc515.getAlgorithmName
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f9255f8d1
        return 0;
    }

    public pe5cfc515 GetUnderlyingDigest()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
        return default!;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: pe5cfc515.doFinal
        // call: System.arraycopy
        // call: pe5cfc515.reset
        // call: pe5cfc515.update
        // call: p94919be6.getKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f246c6bb3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f477c684e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f9255f8d1
    }

    public void Reset()
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.f246c6bb3
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p84f1c057.fc10f7796
    }

}
