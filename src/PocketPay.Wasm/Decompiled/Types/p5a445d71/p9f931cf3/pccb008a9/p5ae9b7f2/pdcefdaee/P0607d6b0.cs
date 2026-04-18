namespace WillowMaze.Wasm.Decompiled;

public class P0607d6b0 : P8a41a071
{
    public static string F2b5d67dc;
    private static string F3f2548e7;
    public static byte[] F72bbb1ae;
    private static string F7d8b26bc;
    private static string F8e5d148a;
    public static byte[] F9fe7a411;
    public static string Faebf756f;
    private static string Fc0e25387;
    public static byte[] Fc4083348;
    private static string Fe44cef7d;
    private int F032d4715;
    private int F146256e3;
    private System.Security.Cryptography.RandomNumberGenerator F18bdd196;
    private pe5cfc515 F1b8dde61;
    private pe2585a04 F2268b54f;
    private int F2a7496fe;
    private pe2585a04 F3c6e0b8a;
    private System.Security.Cryptography.RandomNumberGenerator F49e5309f;
    private bool F4b03c0f0;
    private bool F4f5c0845;
    private int F7b8b965a;
    private bool F7bc696d9;
    private int F8ce4b16b;
    private bool F9301aa9b;
    private int F9fa3d646;
    private pe2585a04 Fa3d5c6c7;
    private pe5cfc515 Fc6204db2;
    private int Fe09c96cb;
    private pe5cfc515 Fe18da75d;
    private System.Security.Cryptography.RandomNumberGenerator Fe22428cc;
    private int Fe358efa4;
    private int Fe8e42e82;
    private pe5cfc515 Ff33b7f6f;
    private pe2585a04 Ffe6f601e;

    private void M1fc5e841(pb4d95bfe P0)
    {
        // call: pb4d95bfe.getT
        // call: pb4d95bfe.getK
        // call: pb4d95bfe.getDigest
        // call: pb4d95bfe.getN
        // call: pa470a233.me0825354
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f7b8b965a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe358efa4
    }

    private void Mdd7fd1f7(p0d2c2c1f P0)
    {
        // call: pa470a233.me0825354
        // call: p0d2c2c1f.getT
        // call: p0d2c2c1f.getDigest
        // call: p0d2c2c1f.getN
        // call: p0d2c2c1f.getK
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe358efa4
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f7b8b965a
    }

    public int GetKeySize(pe2585a04 P0)
    {
        // str: "unsupported type"
        // call: p0d2c2c1f.getN
        // call: IllegalArgumentException.<init>
        // call: pb4d95bfe.getN
        // type: IllegalArgumentException
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getParameters
        // call: p4715f007.getRandom
        // call: pa9682fb5.m07091bf1
        // call: p0607d6b0.mdd7fd1f7
        // call: p0607d6b0.m1fc5e841
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe22428cc
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f9301aa9b
    }

    public byte[] MessageDecrypt(byte[] P0)
    {
        // str: "Bad Padding: invalid ciphertext"
        // str: "Bad Padding: Ciphertext too short."
        // str: "cipher initialised for decryption"
        // call: p21c8c989.<init>
        // call: p35781266.addSeedMaterial
        // call: pee861e31.m51c3f596
        // call: pee861e31.md844b504
        // call: p9cd0c098.<init>
        // call: pe5cfc515.update
        // call: pee861e31.md4723c26
        // call: p35781266.<init>
        // call: pee861e31.meefec303
        // call: pe5cfc515.getDigestSize
        // call: p64e72793.m1a332d23
        // call: System.Numerics.BigInteger.bitLength
        // call: IllegalStateException.<init>
        // call: p35781266.nextBytes
        // call: pf910dc52.m0699c3ed
        // call: pe5cfc515.doFinal
        // call: System.arraycopy
        // call: p2c0bac8b.m56e69c71
        // call: pf910dc52.getEncoded
        // call: p6332798b.m5b936250
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe358efa4
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f7b8b965a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f9fe7a411
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f9301aa9b
        // type: IllegalStateException
        // type: p21c8c989
        // type: p9cd0c098
        // type: p35781266
        return default!;
    }

    public byte[] MessageEncrypt(byte[] P0)
    {
        // str: "cipher initialised for decryption"
        // call: pe5cfc515.getDigestSize
        // call: p2c0bac8b.m56e69c71
        // call: p6332798b.m97a57645
        // call: System.arraycopy
        // call: pe5cfc515.doFinal
        // call: pee861e31.md844b504
        // call: pe5cfc515.update
        // call: p35781266.nextBytes
        // call: p35781266.<init>
        // call: System.Numerics.BigInteger.bitLength
        // call: p64e72793.m6be4a434
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p9cd0c098.<init>
        // call: pf910dc52.getEncoded
        // call: p35781266.addSeedMaterial
        // call: pf910dc52.m0699c3ed
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f7b8b965a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe22428cc
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.fe358efa4
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f9fe7a411
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0607d6b0.f9301aa9b
        // type: p9cd0c098
        // type: IllegalStateException
        // type: p35781266
        return default!;
    }

}
