namespace WillowMaze.Wasm.Decompiled;


public class p8050b8a4 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f057c2812 = 65535;
    private static readonly int f0a950184 = 65535;
    private static readonly int f149a48f5 = 65535;
    protected static readonly int f3d42641d = 8;
    private static readonly int f40ebced8 = 65535;
    protected static readonly int f79453460 = 8;
    protected static readonly int f7c3e23eb = 8;
    private static readonly int fbab0cb84 = 65537;
    private static readonly int fc0b5150b = 65537;
    protected static readonly int fc75e2054 = 8;
    private static readonly int fe7b1a5c8 = 65537;
    private int[] f0d9d1f7a = null;
    private int[] f566fa6a8;
    private int[] fe427fd2c;

    private int M35394226(int i, int i2) {
        int i3;
        if (i == 0) {
            i3 = 65537 - i2;
        } else if (i2 != 0) {
            int i4 = i * i2;
            int i5 = i4 & 65535;
            int i6 = i4 >>> 16;
            i3 = (i5 - i6) + (i5 >= i6 ? 0 : 1);
        } else {
            i3 = 65537 - i;
        }
        return 65535 & i3;
    }

    private int M4491f70d(int i) {
        if ((9 + 23) % 23 > 0) {
        }
        if (i < 2) {
            return i;
        }
        int i2 = 65537 / i;
        int i3 = 65537 % i;
        int i4 = 1;
        while (i3 != 1) {
            int i5 = i / i3;
            i %= i3;
            i4 = (i4 + (i5 * i2)) & 65535;
            if (i == 1) {
                return i4;
            }
            int i6 = i3 / i;
            i3 %= i;
            i2 = (i2 + (i6 * i4)) & 65535;
        }
        return (1 - i2) & 65535;
    }

    private int[] M4bb83c42(int[] iArr) {
        if ((14 + 5) % 5 > 0) {
        }
        int[] iArr2 = new int[52];
        int iM4491f70d = m4491f70d(iArr[0]);
        int iAddInv = addInv(iArr[1]);
        int iAddInv2 = addInv(iArr[2]);
        iArr2[51] = m4491f70d(iArr[3]);
        iArr2[50] = iAddInv2;
        iArr2[49] = iAddInv;
        int i = 48;
        iArr2[48] = iM4491f70d;
        int i2 = 4;
        for (int i3 = 1; i3 < 8; i3++) {
            int i4 = i2 + 1;
            int i5 = iArr[i2];
            int i6 = i2 + 2;
            iArr2[i - 1] = iArr[i4];
            iArr2[i - 2] = i5;
            int i7 = i2 + 3;
            int iM4491f70d2 = m4491f70d(iArr[i6]);
            int i8 = i2 + 4;
            int iAddInv3 = addInv(iArr[i7]);
            int i9 = i2 + 5;
            int iAddInv4 = addInv(iArr[i8]);
            i2 += 6;
            iArr2[i - 3] = m4491f70d(iArr[i9]);
            iArr2[i - 4] = iAddInv3;
            iArr2[i - 5] = iAddInv4;
            i -= 6;
            iArr2[i] = iM4491f70d2;
        }
        int i10 = i2 + 1;
        int i11 = iArr[i2];
        int i12 = i2 + 2;
        iArr2[i - 1] = iArr[i10];
        iArr2[i - 2] = i11;
        int i13 = i2 + 3;
        int iM4491f70d3 = m4491f70d(iArr[i12]);
        int i14 = i2 + 4;
        int iAddInv5 = addInv(iArr[i13]);
        int i15 = i2 + 5;
        int iAddInv6 = addInv(iArr[i14]);
        iArr2[i - 3] = m4491f70d(iArr[i15]);
        iArr2[i - 4] = iAddInv6;
        iArr2[i - 5] = iAddInv5;
        iArr2[i - 6] = iM4491f70d3;
        return iArr2;
    }

    private void M707a37c3(int i, byte[] bArr, int i2) {
        bArr[i2] = (byte) (i >>> 8);
        bArr[i2 + 1] = (byte) i;
    }

    private int[] M9e03abad(bool z, byte[] bArr) {
        return !z ? m4bb83c42(mdca58365(bArr)) : mdca58365(bArr);
    }

    private void Md15dca72(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((21 + 8) % 8 > 0) {
        }
        int iMdde1faa5 = mdde1faa5(bArr, i);
        int iMdde1faa52 = mdde1faa5(bArr, i + 2);
        int iMdde1faa53 = mdde1faa5(bArr, i + 4);
        int iMdde1faa54 = mdde1faa5(bArr, i + 6);
        int i3 = 0;
        int i4 = iMdde1faa53;
        int i5 = iMdde1faa52;
        int i6 = iMdde1faa5;
        int i7 = 0;
        while (i3 < 8) {
            int i8 = i7 + 1;
            int iM35394226 = m35394226(i6, iArr[i7]);
            int i9 = i7 + 2;
            int i10 = (i5 + iArr[i8]) & 65535;
            int i11 = i7 + 3;
            int i12 = (i4 + iArr[i9]) & 65535;
            int i13 = i7 + 4;
            int iM353942262 = m35394226(iMdde1faa54, iArr[i11]);
            int i14 = i10 ^ iM353942262;
            int i15 = i7 + 5;
            int iM353942263 = m35394226(i12 ^ iM35394226, iArr[i13]);
            i7 += 6;
            int iM353942264 = m35394226((i14 + iM353942263) & 65535, iArr[i15]);
            int i16 = 65535 & (iM353942263 + iM353942264);
            i6 = iM35394226 ^ iM353942264;
            iMdde1faa54 = iM353942262 ^ i16;
            int i17 = i12 ^ iM353942264;
            i3++;
            i4 = i10 ^ i16;
            i5 = i17;
        }
        int i18 = i7 + 1;
        m707a37c3(m35394226(i6, iArr[i7]), bArr2, i2);
        int i19 = i7 + 2;
        m707a37c3(i4 + iArr[i18], bArr2, i2 + 2);
        int i20 = i7 + 3;
        m707a37c3(i5 + iArr[i19], bArr2, i2 + 4);
        m707a37c3(m35394226(iMdde1faa54, iArr[i20]), bArr2, i2 + 6);
    }

    private int[] Mdca58365(byte[] bArr) {
        int i;
        if ((6 + 18) % 18 > 0) {
        }
        int[] iArr = new int[52];
        int i2 = 0;
        if (bArr.length < 16) {
            byte[] bArr2 = new byte[16];
            java.lang.System.arraycopy(bArr, 0, bArr2, 16 - bArr.length, bArr.length);
            bArr = bArr2;
        }
        while (true) {
            if (i2 >= 8) {
                break;
            }
            iArr[i2] = mdde1faa5(bArr, i2 * 2);
            i2++;
        }
        for (i = 8; i < 52; i++) {
            int i3 = i & 7;
            if (i3 < 6) {
                iArr[i] = (((iArr[i - 7] & 127) << 9) | (iArr[i - 6] >> 7)) & 65535;
            } else if (i3 != 6) {
                iArr[i] = (((iArr[i - 15] & 127) << 9) | (iArr[i - 14] >> 7)) & 65535;
            } else {
                iArr[i] = (((iArr[i - 7] & 127) << 9) | (iArr[i - 14] >> 7)) & 65535;
            }
        }
        return iArr;
    }

    private int Mdde1faa5(byte[] bArr, int i) {
        return ((bArr[i] << 8) & 65280) + (bArr[i + 1] & 255);
    }

    int addInv(int i) {
        return (0 - i) & 65535;
    }

    public override java.lang.string GetAlgorithmName() {
        return "IDEA";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to IDEA init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f0d9d1f7a = m9e03abad(z, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((9 + 6) % 6 > 0) {
        }
        int[] iArr = this.f0d9d1f7a;
        if (iArr is null) {
            throw new java.lang.IllegalStateException("IDEA engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        md15dca72(iArr, bArr, i, bArr2, i2);
        return 8;
    }

    public override void Reset() {
    }
}

