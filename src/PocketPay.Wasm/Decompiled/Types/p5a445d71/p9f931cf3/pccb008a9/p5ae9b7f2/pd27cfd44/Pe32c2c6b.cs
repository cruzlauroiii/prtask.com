namespace WillowMaze.Wasm.Decompiled;

public class Pe32c2c6b : Pcc0037e2, Pd9f65fa7
{
    private readonly p9064fad6 F18b284aa;
    private readonly int F2db95e8e;
    private readonly int F3bb4c88a;
    private readonly p9064fad6 F6c7501c9;
    private readonly int F9695a4fc;
    private readonly p9064fad6 Fbc6e52ea;
    private readonly p9064fad6 Fc4013924;
    private readonly int Fc8181b4d;
    private readonly int Fef31fbe7;

    public static pe32c2c6b M8bab0102(object P0)
    {
        // str: "cannot parse "
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: pe32c2c6b.<init>
        // call: Stream.close
        // call: MemoryStream.<init>
        // call: DataInputStream.<init>
        // call: pe32c2c6b.m8bab0102
        // call: StringBuilder.toString
        // call: DataInputStream.readInt
        // call: p21b3cb64.m257a59b8
        // call: StringBuilder.append
        // call: p9064fad6.m8bab0102
        // type: StringBuilder
        // type: DataInputStream
        // type: MemoryStream
        // type: IllegalArgumentException
        // type: pe32c2c6b
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: object.getClass
        // call: p9064fad6.equals
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f6c7501c9
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f2db95e8e
        return false;
    }

    public pf502f530 GenerateLMSContext(byte[] P0)
    {
        // str: "cannot parse signature: "
        // call: pf82a7aa7.getSignature
        // call: IllegalStateException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pe32c2c6b.getL
        // call: pf82a7aa7.m8bab0102
        // call: pe0a7073e.getPublicKey
        // call: pf82a7aa7.getSignedPubKey
        // call: StringBuilder.toString
        // call: p9064fad6.generateOtsContext
        // call: pf502f530.withSignedPublicKeys
        // call: IOException.getMessage
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: pbcba235a.build
        // call: pbcba235a.u32str
        // call: pbcba235a.m13b3f3e7
        // call: p9064fad6.getEncoded
        // call: pbcba235a.bytes
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f2db95e8e
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f6c7501c9
        return default!;
    }

    public int GetL()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f2db95e8e
        return 0;
    }

    public p9064fad6 GetLMSPublicKey()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f6c7501c9
        return default!;
    }

    public int HashCode()
    {
        // call: p9064fad6.hashCode
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f6c7501c9
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.f2db95e8e
        return 0;
    }

    public bool Verify(pf502f530 P0)
    {
        // call: p66a8f281.m34a82b06
        // call: pe0a7073e.getPublicKey
        // call: p9064fad6.verify
        // call: pe0a7073e.getSignature
        // call: p9064fad6.toByteArray
        // call: pe32c2c6b.getL
        // call: pf502f530.getSignedPubKeys
        // call: pe32c2c6b.getLMSPublicKey
        return false;
    }

}
