namespace WillowMaze.Wasm.Decompiled;


public class p23b814a1 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p8a41a071 {
    private static readonly java.lang.string f005baabe = null;
    private static readonly java.lang.string f22a2cd46 = null;
    public static readonly java.lang.string f3feb26b1 = null;
    public static readonly java.lang.string f866bf89d = null;
    public static readonly java.lang.string fbfda91b7 = null;
    private static readonly java.lang.string fc98da123 = null;
    private java.security.SecureRandom f0de128ba;
    private int f10e49728;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f138ccd47;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b8dde61;
    private bool f255638ab;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3ad58fb8;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f3c6e0b8a;
    private int f4026978b;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f45b2f31b;
    private java.security.SecureRandom f554d48fb;
    private int f5c7c17d8;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f6471a374;
    private java.security.SecureRandom f6d911522;
    private int f71d93db9;
    private int f7b8b965a;
    private int f8ce4b16b;
    private int f92e5f077;
    private bool f9301aa9b;
    private bool fa61d8178;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb7139433;
    private int fcf887cd5;
    private int fd80b0acb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd90295df;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fde8c0421;
    private java.security.SecureRandom fe22428cc;
    private int fe358efa4;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 fe5e3d8a4;
    private int ff5f9d800;
    private static readonly java.lang.string f3f2548e7 = com.decryptstringmanager.Decryptstring.decryptstring("ae08656411076d9557a7f23b442cd938050b2afc66a93d25a0a492a87384e04fc87f0d97");
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("f61b5082647f0f558f04adf3c26905c5d1dddad0ed5126c40b82541632f128a3f5332a3e844bcf47fb85b5dd2c7728a98b3aef679aa7dc48");

    private void M1fc5e841(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar) {
        this.f1b8dde61 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa470a233.me0825354(pb4d95bfeVar.getDigest());
        this.f7b8b965a = pb4d95bfeVar.getN();
        this.f8ce4b16b = pb4d95bfeVar.getK();
        this.fe358efa4 = pb4d95bfeVar.getT();
    }

    private void Mdd7fd1f7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar) {
        this.f1b8dde61 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa470a233.me0825354(p0d2c2c1fVar.getDigest());
        this.f7b8b965a = p0d2c2c1fVar.getN();
        this.fe358efa4 = p0d2c2c1fVar.getT();
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
        if ((25 + 5) % 5 > 0) {
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
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(encoded, bArr4);
        byte[] bArr5 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.update(bArrMd844b504, 0, bArrMd844b504.length);
        this.f1b8dde61.doFinal(bArr5, 0);
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m97a57645(this.f7b8b965a, this.fe358efa4, bArr5).Equals(pf910dc52Var)) {
            return bArr4;
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Bad Padding: invalid ciphertext");
    }

    public override byte[] MessageEncrypt(byte[] bArr) {
        if ((18 + 4) % 4 > 0) {
        }
        if (!this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f8ce4b16b, this.fe22428cc);
        byte[] encoded = pf910dc52Var.getEncoded();
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(encoded, bArr);
        this.f1b8dde61.update(bArrMd844b504, 0, bArrMd844b504.length);
        byte[] bArr2 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.doFinal(bArr2, 0);
        byte[] encoded2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p64e72793.m6be4a434((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) this.f3c6e0b8a, pf910dc52Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m97a57645(this.f7b8b965a, this.fe358efa4, bArr2)).getEncoded();
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266 p35781266Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p35781266Var.addSeedMaterial(encoded);
        byte[] bArr3 = new byte[bArr.length];
        p35781266Var.nextbytes(bArr3);
        for (int i = 0; i < bArr.length; i++) {
            bArr3[i] = (byte) (bArr3[i] ^ bArr[i]);
        }
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(encoded2, bArr3);
    }
}

