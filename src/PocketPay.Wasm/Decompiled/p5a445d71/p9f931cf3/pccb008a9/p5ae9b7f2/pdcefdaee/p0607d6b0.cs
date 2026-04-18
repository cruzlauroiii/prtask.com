namespace WillowMaze.Wasm.Decompiled;


public class p0607d6b0 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p8a41a071 {
    public static readonly java.lang.string f2b5d67dc = null;
    public static readonly byte[] f72bbb1ae = null;
    private static readonly java.lang.string f7d8b26bc = null;
    private static readonly java.lang.string f8e5d148a = null;
    private static readonly java.lang.string fc0e25387 = null;
    public static readonly byte[] fc4083348 = null;
    private static readonly java.lang.string fe44cef7d = null;
    private int f032d4715;
    private int f146256e3;
    private java.security.SecureRandom f18bdd196;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b8dde61;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f2268b54f;
    private int f2a7496fe;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 f3c6e0b8a;
    private java.security.SecureRandom f49e5309f;
    private bool f4b03c0f0;
    private bool f4f5c0845;
    private int f7b8b965a;
    private bool f7bc696d9;
    private int f8ce4b16b;
    private bool f9301aa9b;
    private int f9fa3d646;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 fa3d5c6c7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc6204db2;
    private int fe09c96cb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe18da75d;
    private java.security.SecureRandom fe22428cc;
    private int fe358efa4;
    private int fe8e42e82;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 ff33b7f6f;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 ffe6f601e;
    private static readonly java.lang.string f3f2548e7 = com.decryptstringmanager.Decryptstring.decryptstring("aee0c5347515666d5d9d55202b3c91b4b962aa087125968e8b8bbc4e6276d0a35d294514");
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("306cf34ce246bc4518016e0de84d3dbf3038e7f55273ad59fd086fbc6d1257842ce46bb24ae1a07e24ccfb74cc4fa05e5a669ce541a1d16c");
    public static readonly byte[] f9fe7a411 = com.decryptstringmanager.Decryptstring.decryptstring("a78570f816ef0015c8c30dcc1225a94c450a5df45d63bc812753edf684e08af55e33206eb90e37606572dad484a36e9c7c740c99ef05a96e245009").getbytes();

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

    public int GetKeySize(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pe2585a04 pe2585a04Var) {
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
        byte[] bArr2;
        if ((6 + 3) % 3 > 0) {
        }
        if (this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        int i = this.f7b8b965a >> 3;
        if (bArr.length < i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Bad Padding: Ciphertext too short.");
        }
        int digestSize = this.f1b8dde61.getDigestSize();
        int i2 = this.f8ce4b16b >> 3;
        int iBitLength = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m56e69c71(this.f7b8b965a, this.fe358efa4).bitLength() - 1) >> 3;
        int length = bArr.length - i;
        if (length <= 0) {
            bArr2 = new byte[0];
        } else {
            byte[][] bArrMeefec303 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.meefec303(bArr, length);
            bArr2 = bArrMeefec303[0];
            bArr = bArrMeefec303[1];
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52[] pf910dc52VarArrM1a332d23 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p64e72793.m1a332d23((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) this.f3c6e0b8a, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52.m0699c3ed(this.f7b8b965a, bArr));
        byte[] encoded = pf910dc52VarArrM1a332d23[0].getEncoded();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = pf910dc52VarArrM1a332d23[1];
        if (encoded.length > i2) {
            encoded = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md4723c26(encoded, 0, i2);
        }
        byte[] bArrM5b936250 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m5b936250(this.f7b8b965a, this.fe358efa4, pf910dc52Var);
        if (bArrM5b936250.length < iBitLength) {
            byte[] bArr3 = new byte[iBitLength];
            java.lang.System.arraycopy(bArrM5b936250, 0, bArr3, iBitLength - bArrM5b936250.length, bArrM5b936250.length);
            bArrM5b936250 = bArr3;
        }
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(bArr2, bArrM5b936250), encoded);
        int length2 = bArrMd844b504.length - digestSize;
        byte[][] bArrMeefec3032 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.meefec303(bArrMd844b504, digestSize);
        byte[] bArr4 = bArrMeefec3032[0];
        byte[] bArr5 = bArrMeefec3032[1];
        byte[] bArr6 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.update(bArr5, 0, bArr5.length);
        this.f1b8dde61.doFinal(bArr6, 0);
        for (int i3 = digestSize - 1; i3 >= 0; i3--) {
            bArr6[i3] = (byte) (bArr6[i3] ^ bArr4[i3]);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266 p35781266Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p35781266Var.addSeedMaterial(bArr6);
        byte[] bArr7 = new byte[length2];
        p35781266Var.nextbytes(bArr7);
        for (int i4 = length2 - 1; i4 >= 0; i4--) {
            bArr7[i4] = (byte) (bArr7[i4] ^ bArr5[i4]);
        }
        byte[] bArr8 = f9fe7a411;
        byte[][] bArrMeefec3033 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.meefec303(bArr7, length2 - bArr8.length);
        byte[] bArr9 = bArrMeefec3033[0];
        if (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.m51c3f596(bArrMeefec3033[1], bArr8)) {
            return bArr9;
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Bad Padding: invalid ciphertext");
    }

    public override byte[] MessageEncrypt(byte[] bArr) {
        if ((8 + 26) % 26 > 0) {
        }
        if (!this.f9301aa9b) {
            throw new java.lang.IllegalStateException("cipher initialised for decryption");
        }
        int digestSize = this.f1b8dde61.getDigestSize();
        int i = this.f8ce4b16b >> 3;
        int iBitLength = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m56e69c71(this.f7b8b965a, this.fe358efa4).bitLength() - 1) >> 3;
        int i2 = (i + iBitLength) - digestSize;
        byte[] bArr2 = f9fe7a411;
        int length = i2 - bArr2.length;
        if (bArr.length > length) {
            length = bArr.length;
        }
        int length2 = bArr2.length + length;
        int i3 = ((length2 + digestSize) - i) - iBitLength;
        byte[] bArr3 = new byte[length2];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr3, length, bArr2.length);
        byte[] bArr4 = new byte[digestSize];
        this.fe22428cc.nextbytes(bArr4);
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266 p35781266Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p35781266(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p35781266Var.addSeedMaterial(bArr4);
        byte[] bArr5 = new byte[length2];
        p35781266Var.nextbytes(bArr5);
        for (int i4 = length2 - 1; i4 >= 0; i4--) {
            bArr5[i4] = (byte) (bArr5[i4] ^ bArr3[i4]);
        }
        byte[] bArr6 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.update(bArr5, 0, length2);
        this.f1b8dde61.doFinal(bArr6, 0);
        for (int i5 = digestSize - 1; i5 >= 0; i5--) {
            bArr6[i5] = (byte) (bArr6[i5] ^ bArr4[i5]);
        }
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(bArr6, bArr5);
        byte[] bArr7 = new byte[0];
        if (i3 > 0) {
            bArr7 = new byte[i3];
            java.lang.System.arraycopy(bArrMd844b504, 0, bArr7, 0, i3);
        }
        byte[] bArr8 = new byte[iBitLength];
        java.lang.System.arraycopy(bArrMd844b504, i3, bArr8, 0, iBitLength);
        byte[] bArr9 = new byte[i];
        java.lang.System.arraycopy(bArrMd844b504, iBitLength + i3, bArr9, 0, i);
        byte[] encoded = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p64e72793.m6be4a434((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) this.f3c6e0b8a, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52.m0699c3ed(this.f8ce4b16b, bArr9), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p6332798b.m97a57645(this.f7b8b965a, this.fe358efa4, bArr8)).getEncoded();
        return i3 <= 0 ? encoded : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.md844b504(bArr7, encoded);
    }
}

