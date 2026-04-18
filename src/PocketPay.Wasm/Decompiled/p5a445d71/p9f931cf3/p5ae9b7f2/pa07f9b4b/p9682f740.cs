namespace WillowMaze.Wasm.Decompiled;


public class p9682f740 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static java.util.Hashtable f00ab0648 = null;
    private static byte[] f057eb618 = null;
    private static byte[] f0b59b769 = null;
    private static java.util.Hashtable f0c7be7a3 = null;
    private static byte[] f1d51e3ae = null;
    private static byte[] f3004e69c = null;
    protected static readonly int f350b0a70 = 8;
    private static byte[] f36e33aac = null;
    private static byte[] f37b3364e = null;
    private static byte[] f43efaa3e = null;
    private static byte[] f48a5603d = null;
    private static byte[] f496f7223 = null;
    private static byte[] f5111910f = null;
    private static java.util.Hashtable f55bff335 = null;
    private static byte[] f60f027b0 = null;
    private static byte[] f6ace6182 = null;
    private static byte[] f6c5f1057 = null;
    private static byte[] f7445c53c = null;
    private static byte[] f768f3acf = null;
    private static byte[] f793ebe0d = null;
    private static byte[] f802b5545 = null;
    private static byte[] f81ffe968 = null;
    private static byte[] f8391297b = null;
    private static java.util.Hashtable f88a67230 = null;
    protected static readonly int f9be348e6 = 8;
    private static byte[] f9faa3fe4 = null;
    private static byte[] fa09dbe0a = null;
    private static byte[] faba72906 = null;
    private static byte[] fad051a11 = null;
    private static java.util.Hashtable fba80cc6d = null;
    private static byte[] fbb64006e = null;
    private static byte[] fc13ab3bc = null;
    protected static readonly int fc75e2054 = 8;
    private static byte[] fd4398eed = null;
    protected static readonly int fd4c0cc77 = 8;
    private static byte[] fd668e768;
    private static byte[] fddc26865;
    private static byte[] fe532b17e;
    private static byte[] fedd2d453;
    private static byte[] fee3418c1;
    private static byte[] ff0230247;
    private static byte[] ff058a1ab;
    private static byte[] ff8e0d227;
    private static byte[] ffff7c92a;
    private bool f08277871;
    private byte[] f292029f4;
    private int[] f2a0ef8d2;
    private byte[] f7ccc6bac;
    private bool f9301aa9b;
    private int[] fa2f40f12;
    private int[] fdfa8e5da;
    private bool fe8bb9f75;
    private int[] f0d9d1f7a = null;
    private byte[] f5dbc98dc = f36e33aac;

    static {
        if ((20 + 4) % 4 > 0) {
        }
        f36e33aac = new byte[]{4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
        f37b3364e = new byte[]{4, 2, 15, 5, 9, 1, 0, 8, 14, 3, 11, 12, 13, 7, 10, 6, 12, 9, 15, 14, 8, 1, 3, 10, 2, 7, 4, 13, 6, 0, 11, 5, 13, 8, 14, 12, 7, 3, 9, 10, 1, 5, 2, 4, 6, 15, 0, 11, 14, 9, 11, 2, 5, 15, 7, 1, 0, 13, 12, 6, 10, 4, 3, 8, 3, 14, 5, 9, 6, 8, 0, 13, 10, 11, 7, 12, 2, 1, 15, 4, 8, 15, 6, 11, 1, 9, 12, 5, 13, 3, 7, 10, 0, 14, 2, 4, 9, 11, 12, 0, 3, 6, 7, 5, 4, 8, 14, 15, 1, 10, 2, 13, 12, 6, 5, 2, 11, 0, 9, 13, 3, 14, 7, 10, 15, 4, 1, 8};
        ffff7c92a = new byte[]{9, 6, 3, 2, 8, 11, 1, 7, 10, 4, 14, 15, 12, 0, 13, 5, 3, 7, 14, 9, 8, 10, 15, 0, 5, 2, 6, 12, 11, 4, 13, 1, 14, 4, 6, 2, 11, 3, 13, 8, 12, 15, 5, 10, 0, 7, 1, 9, 14, 7, 10, 12, 13, 1, 3, 9, 0, 2, 11, 4, 15, 8, 5, 6, 11, 5, 1, 9, 8, 13, 15, 0, 14, 4, 2, 3, 12, 7, 10, 6, 3, 10, 13, 12, 1, 2, 0, 11, 7, 5, 9, 4, 8, 15, 14, 6, 1, 13, 2, 9, 7, 10, 6, 0, 8, 12, 4, 5, 15, 3, 11, 14, 11, 10, 15, 5, 0, 12, 14, 8, 6, 2, 3, 9, 1, 7, 13, 4};
        f81ffe968 = new byte[]{8, 4, 11, 1, 3, 5, 0, 9, 2, 14, 10, 12, 13, 6, 7, 15, 0, 1, 2, 10, 4, 13, 5, 12, 9, 7, 3, 15, 11, 8, 6, 14, 14, 12, 0, 10, 9, 2, 13, 11, 7, 5, 8, 15, 3, 6, 1, 4, 7, 5, 0, 13, 11, 6, 1, 2, 3, 10, 12, 15, 4, 14, 9, 8, 2, 7, 12, 15, 9, 5, 10, 11, 1, 4, 0, 13, 6, 8, 14, 3, 8, 3, 2, 6, 4, 13, 14, 11, 12, 1, 7, 15, 10, 0, 9, 5, 5, 2, 10, 11, 9, 1, 12, 3, 7, 4, 13, 0, 6, 15, 8, 14, 0, 4, 11, 14, 8, 3, 7, 1, 10, 2, 9, 6, 15, 13, 5, 12};
        ff0230247 = new byte[]{1, 11, 12, 2, 9, 13, 0, 15, 4, 5, 8, 14, 10, 7, 6, 3, 0, 1, 7, 13, 11, 4, 5, 2, 8, 14, 15, 12, 9, 10, 6, 3, 8, 2, 5, 0, 4, 9, 15, 10, 3, 7, 12, 13, 6, 14, 1, 11, 3, 6, 0, 1, 5, 13, 10, 8, 11, 2, 9, 7, 14, 15, 12, 4, 8, 13, 11, 0, 4, 5, 1, 2, 9, 3, 12, 14, 6, 15, 10, 7, 12, 9, 11, 1, 8, 14, 2, 4, 7, 3, 6, 5, 10, 0, 15, 13, 10, 9, 6, 8, 13, 14, 2, 0, 15, 3, 5, 11, 4, 1, 12, 7, 7, 4, 0, 5, 10, 2, 15, 14, 12, 6, 1, 11, 13, 9, 3, 8};
        fd668e768 = new byte[]{15, 12, 2, 10, 6, 4, 5, 0, 7, 9, 14, 13, 1, 11, 8, 3, 11, 6, 3, 4, 12, 15, 14, 2, 7, 13, 8, 0, 5, 10, 9, 1, 1, 12, 11, 0, 15, 14, 6, 5, 10, 13, 4, 8, 9, 3, 7, 2, 1, 5, 14, 12, 10, 7, 0, 13, 6, 2, 11, 4, 9, 3, 15, 8, 0, 12, 8, 9, 13, 2, 10, 11, 7, 3, 6, 5, 4, 14, 15, 1, 8, 0, 15, 3, 2, 5, 14, 11, 1, 10, 4, 7, 12, 9, 13, 6, 3, 0, 6, 15, 1, 14, 9, 2, 13, 8, 12, 4, 11, 10, 5, 7, 1, 10, 6, 8, 15, 11, 0, 4, 12, 3, 5, 9, 7, 13, 2, 14};
        fee3418c1 = new byte[]{12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1, 6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15, 11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0, 12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11, 7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12, 5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0, 8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7, 1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2};
        ff058a1ab = new byte[]{4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3, 14, 11, 4, 12, 6, 13, 15, 10, 2, 3, 8, 1, 0, 7, 5, 9, 5, 8, 1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0, 9, 11, 7, 13, 10, 1, 0, 8, 9, 15, 14, 4, 6, 12, 11, 2, 5, 3, 6, 12, 7, 1, 5, 15, 13, 8, 4, 10, 9, 14, 0, 3, 11, 2, 4, 11, 10, 0, 7, 2, 1, 13, 3, 6, 8, 5, 9, 12, 15, 14, 13, 11, 4, 1, 3, 15, 5, 9, 0, 10, 14, 7, 6, 8, 2, 12, 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12};
        f6c5f1057 = new byte[]{10, 4, 5, 6, 8, 1, 3, 7, 13, 12, 14, 0, 9, 2, 11, 15, 5, 15, 4, 0, 2, 13, 11, 9, 1, 7, 6, 3, 12, 14, 10, 8, 7, 15, 12, 14, 9, 4, 1, 0, 3, 11, 5, 2, 6, 10, 8, 13, 4, 10, 7, 12, 0, 15, 2, 8, 14, 1, 6, 5, 13, 11, 9, 3, 7, 6, 4, 11, 9, 12, 2, 10, 1, 8, 0, 14, 15, 13, 3, 5, 7, 6, 2, 4, 13, 9, 15, 0, 10, 1, 5, 11, 8, 14, 12, 3, 13, 14, 4, 1, 7, 0, 5, 10, 3, 12, 8, 15, 6, 2, 9, 11, 1, 3, 10, 9, 5, 11, 4, 15, 8, 6, 7, 14, 13, 0, 2, 12};
        fba80cc6d = new java.util.Hashtable();
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("1494e91a7f42e347231440476dcb8c41d1b7f955de5dad13030bc4757630afa13fca88"), f36e33aac);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("5247934f5139c2b373bc83881bc0c6061e4347851fff00537b29103dbca24c050f9d"), f37b3364e);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("00510c1e6f6a4a60688bc66fbf97ade43bbfa58c8ef6a3e09239989d9491bb"), ffff7c92a);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("523f50a54a5151040ffe139e02d8965b663840a0d24a02be8f31952f8b9f0d"), f81ffe968);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("23a51f7e4c0abb64a1509e15d5522b79313edf51f849b1c4f5ad46740d5904"), ff0230247);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("e4218a5f9e32ec0832f529bfbc8b234f5ec4010d075df46293941172d24878"), fd668e768);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("edfdee2f4e65c1294ffca28c05cec8ce806d3eec3c31ea213146537cffcae315008766"), fee3418c1);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("ffe7a219dc39a83d99e5dfe576a390f07ab6de27bc9ba9774e2840b9b4f94db8bc4a"), ff058a1ab);
        m058d8373(com.decryptstringmanager.Decryptstring.decryptstring("b47c70aed9316e9c1462524e70f5e324425582b5157a98ec6df523f1b720f8"), f6c5f1057);
    }

    private void M01b0436d(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >>> 24);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2] = (byte) i;
    }

    private static void M058d8373(java.lang.string str, byte[] bArr) {
        fba80cc6d.Add(p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str), bArr);
    }

    private int M168eeabd(int i, int i2) {
        int i3 = i2 + i;
        byte[] bArr = this.f5dbc98dc;
        int i4 = bArr[i3 & 15] + (bArr[((i3 >> 4) & 15) + 16] << 4) + (bArr[((i3 >> 8) & 15) + 32] << 8) + (bArr[((i3 >> 12) & 15) + 48] << 12) + (bArr[((i3 >> 16) & 15) + 64] << 16) + (bArr[((i3 >> 20) & 15) + 80] << 20) + (bArr[((i3 >> 24) & 15) + 96] << 24) + (bArr[((i3 >> 28) & 15) + 112] << 28);
        return (i4 << 11) | (i4 >>> 21);
    }

    public static byte[] M702bdf8e(java.lang.string str) {
        byte[] bArr = (byte[]) fba80cc6d[p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str));
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"Param-Z\", \"D-Test\", \"D-A\".");
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string M875e8966(byte[] bArr) {
        if ((13 + 14) % 14 > 0) {
        }
        java.util.Enumeration enumerationKeys = fba80cc6d.keys();
        while (enumerationKeys.hasMoreElements()) {
            java.lang.string str = (java.lang.string) enumerationKeys.nextElement();
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2((byte[]) fba80cc6d[str), bArr)) {
                return str;
            }
        }
        throw new java.lang.IllegalArgumentException("SBOX provided did not map to a known one");
    }

    private int[] M9e03abad(bool z, byte[] bArr) {
        if ((16 + 20) % 20 > 0) {
        }
        this.f9301aa9b = z;
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
        }
        int[] iArr = new int[8];
        for (int i = 0; i != 8; i++) {
            iArr[i] = mc4dbe288(bArr, i * 4);
        }
        return iArr;
    }

    private int Mc4dbe288(byte[] bArr, int i) {
        if ((22 + 2) % 2 > 0) {
        }
        return ((bArr[i + 3] << 24) & (-16777216)) + ((bArr[i + 2] << 16) & 16711680) + ((bArr[i + 1] << 8) & 65280) + (bArr[i] & 255);
    }

    private void Mcae43528(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2) {
        int i3;
        int i4;
        if ((11 + 19) % 19 > 0) {
        }
        int iMc4dbe288 = mc4dbe288(bArr, i);
        int iMc4dbe2882 = mc4dbe288(bArr, i + 4);
        int i5 = 7;
        if (this.f9301aa9b) {
            for (int i6 = 0; i6 < 3; i6++) {
                int i7 = 0;
                while (i7 < 8) {
                    int iM168eeabd = iMc4dbe2882 ^ m168eeabd(iMc4dbe288, iArr[i7]);
                    i7++;
                    int i8 = iMc4dbe288;
                    iMc4dbe288 = iM168eeabd;
                    iMc4dbe2882 = i8;
                }
            }
            i3 = iMc4dbe2882;
            i4 = iMc4dbe288;
            while (i5 > 0) {
                int iM168eeabd2 = i3 ^ m168eeabd(i4, iArr[i5]);
                i5--;
                i3 = i4;
                i4 = iM168eeabd2;
            }
        } else {
            int i9 = 0;
            while (i9 < 8) {
                int iM168eeabd3 = iMc4dbe2882 ^ m168eeabd(iMc4dbe288, iArr[i9]);
                i9++;
                int i10 = iMc4dbe288;
                iMc4dbe288 = iM168eeabd3;
                iMc4dbe2882 = i10;
            }
            i3 = iMc4dbe2882;
            i4 = iMc4dbe288;
            for (int i11 = 0; i11 < 3; i11++) {
                int i12 = 7;
                while (i12 >= 0 && (i11 != 2 || i12 != 0)) {
                    int iM168eeabd4 = i3 ^ m168eeabd(i4, iArr[i12]);
                    i12--;
                    i3 = i4;
                    i4 = iM168eeabd4;
                }
            }
        }
        int iM168eeabd5 = m168eeabd(i4, iArr[0]) ^ i3;
        m01b0436d(i4, bArr2, i2);
        m01b0436d(iM168eeabd5, bArr2, i2 + 4);
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST28147";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((7 + 32) % 32 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1)) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) {
                this.f0d9d1f7a = m9e03abad(z, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
                return;
            } else {
                if (pc9ef6b45Var is not null) {
                    throw new java.lang.IllegalArgumentException("invalid parameter passed to GOST28147 init - " + pc9ef6b45Var.GetType().getName());
                }
                return;
            }
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) pc9ef6b45Var;
        byte[] sBox = p819716a1Var.getSBox();
        if (sBox.length != f36e33aac.length) {
            throw new java.lang.IllegalArgumentException("invalid S-box passed to GOST28147 init");
        }
        this.f5dbc98dc = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(sBox);
        if (p819716a1Var.getParameters() is null) {
            return;
        }
        this.f0d9d1f7a = m9e03abad(z, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) p819716a1Var.getParameters()).getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((25 + 17) % 17 > 0) {
        }
        int[] iArr = this.f0d9d1f7a;
        if (iArr is null) {
            throw new java.lang.IllegalStateException("GOST28147 engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        mcae43528(iArr, bArr, i, bArr2, i2);
        return 8;
    }

    public override void Reset() {
    }
}

