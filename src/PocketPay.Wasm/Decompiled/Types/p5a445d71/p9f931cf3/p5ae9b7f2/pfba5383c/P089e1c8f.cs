namespace WillowMaze.Wasm.Decompiled;

public class P089e1c8f : P1748c064
{
    private static byte F15374a1c;
    private static byte F253a7069;
    private static byte F3a8ff182;
    private static byte F5b377a1e;
    private static Hashtable F8c9c9557;
    private static Hashtable Faf7c35e6;
    private static Hashtable Fef0d8e28;
    private byte[] F00255016;
    private byte[] F246c6bb3;
    private int F46cf2f26;
    private byte[] F490d1302;
    private p4d7fdfb1 F53c20662;
    private int F6e2afb89;
    private int F6e42f040;
    private p4d7fdfb1 F82859e7a;
    private int F9255f8d1;
    private p4d7fdfb1 F9a7d06a0;
    private int F9bf6395e;
    private byte[] F9e2837e3;
    private p4d7fdfb1 Fa4139c16;
    private p4d7fdfb1 Fabcbcb27;
    private int Fbd69fb59;
    private pe5cfc515 Fc10f7796;
    private byte[] Fc45b601c;
    private p4d7fdfb1 Fc5d9e14f;
    private int Fca118ceb;
    private byte[] Fcd0a3344;
    private p4d7fdfb1 Fed426c55;
    private pe5cfc515 Ff38ed08f;
    private byte[] Ff6ccc643;
    private p4d7fdfb1 Ff814bc6e;

    private static void M00bdaf19(byte[] P0, int P1, byte P2)
    {
    }

    private static int M41c1abd5(pe5cfc515 P0)
    {
        // str: "unknown digest passed: "
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pe5cfc515.getAlgorithmName
        // call: IllegalArgumentException.<init>
        // call: int.intValue
        // call: StringBuilder.append
        // call: p085a71d0.getByteLength
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.faf7c35e6
        // type: IllegalArgumentException
        // type: StringBuilder
        return 0;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p4d7fdfb1.reset
        // call: pe5cfc515.update
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f00255016
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fbd69fb59
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f246c6bb3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fa4139c16
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f53c20662
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/HMAC"
        // call: StringBuilder.append
        // call: pe5cfc515.getAlgorithmName
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f9255f8d1
        return 0;
    }

    public pe5cfc515 GetUnderlyingDigest()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
        return default!;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: pe5cfc515.update
        // call: p4d7fdfb1.copy
        // call: System.arraycopy
        // call: pe5cfc515.reset
        // call: p089e1c8f.m00bdaf19
        // call: p94919be6.getKey
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fbd69fb59
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f9255f8d1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f246c6bb3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f00255016
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fa4139c16
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f53c20662
    }

    public void Reset()
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.f246c6bb3
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f.fc10f7796
    }

}
