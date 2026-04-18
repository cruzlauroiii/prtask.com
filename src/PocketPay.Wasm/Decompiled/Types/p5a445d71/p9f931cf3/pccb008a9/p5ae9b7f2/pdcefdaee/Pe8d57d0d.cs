namespace WillowMaze.Wasm.Decompiled;

public class Pe8d57d0d : P8a41a071
{
    public static string F0db40378;
    public static string F7fb8c7ed;
    public static string Faebf756f;
    public static string Faec57492;
    private pb404f231 F0c843190;
    private int F1af7e1fc;
    public int F25f9919b;
    private pb404f231 F3c6e0b8a;
    private int F65dad0dd;
    private bool F7592b0f2;
    private int F7b8b965a;
    private System.Security.Cryptography.RandomNumberGenerator F88a802f7;
    private int F8ce4b16b;
    private int F908db7d0;
    private bool F9301aa9b;
    private System.Security.Cryptography.RandomNumberGenerator F99e19e0e;
    public int Fa172f9ee;
    private bool Fa69082e6;
    public int Faa44ab9d;
    private bool Faba6a610;
    private int Fac639f38;
    private System.Security.Cryptography.RandomNumberGenerator Faffe6a2c;
    private pb404f231 Fb413acc5;
    private bool Fbde73aac;
    public int Fcc3c23e1;
    private int Fccc1b143;
    private int Fdebf9476;
    private System.Security.Cryptography.RandomNumberGenerator Fe22428cc;
    public int Fe249f4f5;
    private int Fe358efa4;
    private pb404f231 Ff31da5f2;
    public int Fff1f7ae6;

    private byte[] M17149097(pf910dc52 P0)
    {
        // str: "Bad Padding: invalid ciphertext"
        // call: System.arraycopy
        // call: p21c8c989.<init>
        // call: pf910dc52.getEncoded
        // type: p21c8c989
        return default!;
    }

    private void M1fc5e841(p62f43b9f P0)
    {
        // call: p62f43b9f.getN
        // call: p62f43b9f.getK
        // call: p62f43b9f.getT
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f7b8b965a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fa172f9ee
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fe358efa4
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f25f9919b
    }

    private pf910dc52 M4cd2359a(byte[] P0)
    {
        // call: pf910dc52.m0699c3ed
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fa172f9ee
        return default!;
    }

    private void Mdd7fd1f7(pa1d4de93 P0)
    {
        // call: pa1d4de93.getK
        // call: pa1d4de93.getN
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f25f9919b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fa172f9ee
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f7b8b965a
    }

    public int GetKeySize(pb404f231 P0)
    {
        // str: "unsupported type"
        // call: p62f43b9f.getN
        // call: pa1d4de93.getN
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getRandom
        // call: p4715f007.getParameters
        // call: pe8d57d0d.m1fc5e841
        // call: pe8d57d0d.mdd7fd1f7
        // call: pa9682fb5.m07091bf1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fe22428cc
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f9301aa9b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f3c6e0b8a
    }

    public byte[] MessageDecrypt(byte[] P0)
    {
        // str: "cipher initialised for decryption"
        // call: pf910dc52.m0699c3ed
        // call: pa1d4de93.getH
        // call: pe8d57d0d.m17149097
        // call: pa1d4de93.getField
        // call: pfd29d683.m19d66f68
        // call: pa1d4de93.getP2
        // call: pa1d4de93.getQInv
        // call: pf910dc52.add
        // call: pf910dc52.extractRightVector
        // call: pf910dc52.multiply
        // call: IllegalStateException.<init>
        // call: pfc77ea6c.rightMultiply
        // call: p6c210a37.leftMultiply
        // call: p6c210a37.rightMultiply
        // call: pa1d4de93.getSInv
        // call: pfc77ea6c.computeInverse
        // call: pa1d4de93.getP1
        // call: pa1d4de93.getGoppaPoly
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f7b8b965a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f8ce4b16b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f9301aa9b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f3c6e0b8a
        // type: IllegalStateException
        return default!;
    }

    public byte[] MessageEncrypt(byte[] P0)
    {
        // str: "cipher initialised for decryption"
        // call: pf910dc52.getEncoded
        // call: pe8d57d0d.m4cd2359a
        // call: p6c210a37.leftMultiply
        // call: pf910dc52.<init>
        // call: IllegalStateException.<init>
        // call: p57dea6f5.add
        // call: p62f43b9f.getG
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fe358efa4
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f9301aa9b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.fe22428cc
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe8d57d0d.f7b8b965a
        // type: pf910dc52
        // type: IllegalStateException
        return default!;
    }

}
