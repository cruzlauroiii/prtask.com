namespace WillowMaze.Wasm.Decompiled;


public class p1cf86070 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p8a41a071 {
    public static readonly java.lang.string f583ece16 = null;
    public static readonly java.lang.string f78bba418 = null;
    public static readonly java.lang.string f8c6ea80f = null;
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("4b49f1ecf7cd6dd2c66875e0c9e2ec3465da9954cec28596f1eef1d965fba86f8cb05c5425710a5354cda32561a77bbc2cbd394056fca4cf");
    public static readonly java.lang.string ff8d52127 = null;
    private int f02ed17a7;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f04009fa0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f16af8337;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f1a91a1fb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b8dde61;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f3c6e0b8a;
    private int f4272f76c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f4eb045b1;
    private java.security.SecureRandom f531ba3c7;
    private int f55a8c653;
    private int f685f0082;
    private int f7b8b965a;
    private bool f887be12c;
    private int f8ce4b16b;
    private bool f9301aa9b;
    private int f9c77f95e;
    private bool fbfa021b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc0456b15;
    private bool fcdb057a8;
    private int fdb2b302d;
    private int fdd3e9d2d;
    private java.security.SecureRandom fe22428cc;
    private int fe358efa4;
    private java.security.SecureRandom fe5938ed5;
    private bool fe5bd8cfc;

    private void M1fc5e841(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar) {
        this.f1b8dde61 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa470a233.me0825354(pb4d95bfeVar.getDigest());
        this.f7b8b965a = pb4d95bfeVar.getN();
        this.f8ce4b16b = pb4d95bfeVar.getK();
        this.fe358efa4 = pb4d95bfeVar.getT();
    }

    private void Mdd7fd1f7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar) {
        this.f1b8dde61 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa470a233.me0825354(p0d2c2c1fVar.getDigest());
        this.f7b8b965a = p0d2c2c1fVar.getN();
        this.f8ce4b16b = p0d2c2c1fVar.getK();
        this.fe358efa4 = p0d2c2c1fVar.getT();
    }

    protected int DecryptOutputSize(int i) {
        return 0;
    }

    protected int EncryptOutputSize(int i) {
        return 0;
    }

    public int GetKeySize(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 pe2585a04Var) throws java.lang.IllegalArgumentException {
        if (pe2585a04Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) pe2585a04Var).getN();
        }
        if (pe2585a04Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) pe2585a04Var).getN();
        }
        throw new java.lang.IllegalArgumentException("unsupported type");
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f9301aa9b = z;
        if (!z) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) pc9ef6b45Var;
            this.f3c6e0b8a = p0d2c2c1fVar;
            mdd7fd1f7(p0d2c2c1fVar);
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
                this.fe22428cc = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) pc9ef6b45Var;
                this.f3c6e0b8a = pb4d95bfeVar;
                m1fc5e841(pb4d95bfeVar);
                return;
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.fe22428cc = p4715f007Var.getRandom();
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) p4715f007Var.getParameters();
            this.f3c6e0b8a = pb4d95bfeVar2;
            m1fc5e841(pb4d95bfeVar2);
        }
    }

    public override byte[] MessageDecrypt(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((28 + 2) % 2 > 0) {
        }
        if (this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        int i = (this.f7b8b965a + 7) >> 3;
        int length = bArr.length - i;
        byte[][] bArrMeefec303 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.meefec303(bArr, i);
        byte[] bArr2 = bArrMeefec303[0];
        byte[] bArr3 = bArrMeefec303[1];
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52[] pf910dc52VarArrM1a332d23 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p64e72793.m1a332d23((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) this.f3c6e0b8a, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52.m0699c3ed(this.f7b8b965a, bArr2));
        byte[] encoded = pf910dc52VarArrM1a332d23[0].getEncoded();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = pf910dc52VarArrM1a332d23[1];
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266 p35781266Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p35781266Var.addSeedMaterial(encoded);
        byte[] bArr4 = new byte[length];
        p35781266Var.nextbytes(bArr4);
        for (int i2 = 0; i2 < length; i2++) {
            bArr4[i2] = (byte) (bArr4[i2] ^ bArr3[i2]);
        }
        this.f1b8dde61.update(bArr4, 0, length);
        byte[] bArr5 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.doFinal(bArr5, 0);
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m97a57645(this.f7b8b965a, this.fe358efa4, bArr5).Equals(pf910dc52Var)) {
            return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.meefec303(bArr4, length - (this.f8ce4b16b >> 3))[0];
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Bad Padding: Invalid ciphertext.");
    }

    public override byte[] MessageEncrypt(byte[] bArr) {
        if ((7 + 7) % 7 > 0) {
        }
        if (!this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        int i = this.f8ce4b16b >> 3;
        byte[] bArr2 = new byte[i];
        this.fe22428cc.nextbytes(bArr2);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f8ce4b16b, this.fe22428cc);
        byte[] encoded = pf910dc52Var.getEncoded();
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(bArr, bArr2);
        this.f1b8dde61.update(bArrMd844b504, 0, bArrMd844b504.length);
        byte[] bArr3 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.doFinal(bArr3, 0);
        byte[] encoded2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p64e72793.m6be4a434((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) this.f3c6e0b8a, pf910dc52Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m97a57645(this.f7b8b965a, this.fe358efa4, bArr3)).getEncoded();
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266 p35781266Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p35781266Var.addSeedMaterial(encoded);
        byte[] bArr4 = new byte[bArr.length + i];
        p35781266Var.nextbytes(bArr4);
        for (int i2 = 0; i2 < bArr.length; i2++) {
            bArr4[i2] = (byte) (bArr4[i2] ^ bArr[i2]);
        }
        for (int i3 = 0; i3 < i; i3++) {
            int length = bArr.length + i3;
            bArr4[length] = (byte) (bArr4[length] ^ bArr2[i3]);
        }
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(encoded2, bArr4);
    }
}

