namespace WillowMaze.Wasm.Decompiled;


public class pe8d57d0d : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p8a41a071 {
    public static readonly java.lang.string f0db40378 = null;
    public static readonly java.lang.string f7fb8c7ed = null;
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("563918e08aaa235138e356842a5e9ab4f3eae2c310577cf26c26e42d08ccc158e058a523eed11a522c3a8c805db2162f34d3534e5428");
    public static readonly java.lang.string faec57492 = null;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231 f0c843190;
    private int f1af7e1fc;
    public int f25f9919b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231 f3c6e0b8a;
    private int f65dad0dd;
    private bool f7592b0f2;
    private int f7b8b965a;
    private java.security.SecureRandom f88a802f7;
    private int f8ce4b16b;
    private int f908db7d0;
    private bool f9301aa9b;
    private java.security.SecureRandom f99e19e0e;
    public int fa172f9ee;
    private bool fa69082e6;
    public int faa44ab9d;
    private bool faba6a610;
    private int fac639f38;
    private java.security.SecureRandom faffe6a2c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231 fb413acc5;
    private bool fbde73aac;
    public int fcc3c23e1;
    private int fccc1b143;
    private int fdebf9476;
    private java.security.SecureRandom fe22428cc;
    public int fe249f4f5;
    private int fe358efa4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231 ff31da5f2;
    public int fff1f7ae6;

    private byte[] M17149097(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((11 + 30) % 30 > 0) {
        }
        byte[] encoded = pf910dc52Var.getEncoded();
        int length = encoded.length - 1;
        while (length >= 0 && encoded[length] == 0) {
            length--;
        }
        if (length < 0 || encoded[length] != 1) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Bad Padding: invalid ciphertext");
        }
        byte[] bArr = new byte[length];
        java.lang.System.arraycopy(encoded, 0, bArr, 0, length);
        return bArr;
    }

    private void M1fc5e841(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f p62f43b9fVar) {
        this.f7b8b965a = p62f43b9fVar.getN();
        this.f8ce4b16b = p62f43b9fVar.getK();
        this.fe358efa4 = p62f43b9fVar.getT();
        this.f25f9919b = this.f7b8b965a >> 3;
        this.fa172f9ee = this.f8ce4b16b >> 3;
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M4cd2359a(byte[] bArr) {
        if ((22 + 26) % 26 > 0) {
        }
        byte[] bArr2 = new byte[this.fa172f9ee + ((this.f8ce4b16b & 7) == 0 ? 0 : 1)];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        bArr2[bArr.length] = 1;
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52.m0699c3ed(this.f8ce4b16b, bArr2);
    }

    private void Mdd7fd1f7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 pa1d4de93Var) {
        this.f7b8b965a = pa1d4de93Var.getN();
        int k = pa1d4de93Var.getK();
        this.f8ce4b16b = k;
        this.fa172f9ee = k >> 3;
        this.f25f9919b = this.f7b8b965a >> 3;
    }

    public int GetKeySize(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb404f231 pb404f231Var) {
        if (pb404f231Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) pb404f231Var).getN();
        }
        if (pb404f231Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93) pb404f231Var).getN();
        }
        throw new java.lang.IllegalArgumentException("unsupported type");
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f9301aa9b = z;
        if (!z) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 pa1d4de93Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93) pc9ef6b45Var;
            this.f3c6e0b8a = pa1d4de93Var;
            mdd7fd1f7(pa1d4de93Var);
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
                this.fe22428cc = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f p62f43b9fVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) pc9ef6b45Var;
                this.f3c6e0b8a = p62f43b9fVar;
                m1fc5e841(p62f43b9fVar);
                return;
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.fe22428cc = p4715f007Var.getRandom();
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f p62f43b9fVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) p4715f007Var.getParameters();
            this.f3c6e0b8a = p62f43b9fVar2;
            m1fc5e841(p62f43b9fVar2);
        }
    }

    public override byte[] MessageDecrypt(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((1 + 12) % 12 > 0) {
        }
        if (this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52VarM0699c3ed = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52.m0699c3ed(this.f7b8b965a, bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 pa1d4de93Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93) this.f3c6e0b8a;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 field = pa1d4de93Var.getField();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 goppaPoly = pa1d4de93Var.getGoppaPoly();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 sInv = pa1d4de93Var.getSInv();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c p1 = pa1d4de93Var.getP1();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c p2 = pa1d4de93Var.getP2();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 h = pa1d4de93Var.getH();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] qInv = pa1d4de93Var.getQInv();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVarRightMultiply = p1.rightMultiply(p2);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pf910dc52VarM0699c3ed.multiply(pfc77ea6cVarRightMultiply.computeInverse());
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52VarM19d66f68 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.m19d66f68((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) h.rightMultiply(pf910dc52Var), field, goppaPoly, qInv);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var2 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pf910dc52Var.Add(pf910dc52VarM19d66f68)).multiply(p1);
        return m17149097((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) sInv.leftMultiply(pf910dc52Var2.extractRightVector(this.f8ce4b16b)));
    }

    public override byte[] MessageEncrypt(byte[] bArr) {
        if ((11 + 29) % 29 > 0) {
        }
        if (!this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52VarM4cd2359a = m4cd2359a(bArr);
        return ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) this.f3c6e0b8a).getG().leftMultiply(pf910dc52VarM4cd2359a).Add(new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f7b8b965a, this.fe358efa4, this.fe22428cc))).getEncoded();
    }
}

