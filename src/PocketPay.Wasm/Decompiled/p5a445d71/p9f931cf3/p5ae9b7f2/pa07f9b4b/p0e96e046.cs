namespace WillowMaze.Wasm.Decompiled;


public class p0e96e046 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly byte[] f0b874a86 = {-128, 27, 54, 108, -40, -85, 77, -102, 47, 94, -68, 99, -58, -105, 53, 106, -44};
    private static readonly int f2375b30c = 16;
    private static readonly byte[] f4a0e24ff = null;
    private static readonly int f62e5cef8 = 16;
    private static readonly int f94d798de = 16;
    private bool f0657dfb6;
    private bool f1ef935c9;
    private readonly int[] f7c780224;
    private bool f84b00bdc;
    private bool fa792592e;
    private bool fd9e69079;
    private readonly int[] fdbcd49b3;
    private readonly int[] f8ce4b16b = new int[4];
    private bool fbdf3566b = false;

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((22 + 9) % 9 > 0) {
        }
        int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i);
        int iMc4a600532 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 4);
        int iMc4a600533 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 8);
        int iMc4a600534 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 12);
        int[] iArr = this.f8ce4b16b;
        int i3 = 0;
        int i4 = iArr[0];
        int i5 = iArr[1];
        int i6 = iArr[2];
        int i7 = iArr[3];
        while (true) {
            int i8 = iMc4a60053 ^ (f0b874a86[i3] & 255);
            int i9 = i8 ^ iMc4a600533;
            int iMff847a50 = i9 ^ (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i9, 8) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i9, 24));
            int i10 = i8 ^ i4;
            int i11 = iMc4a600532 ^ i5;
            int i12 = iMc4a600533 ^ i6;
            int i13 = iMc4a600534 ^ i7;
            int i14 = i11 ^ i13;
            int iMff847a502 = (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i14, 24) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i14, 8)) ^ i14;
            int i15 = i10 ^ iMff847a502;
            int i16 = i11 ^ iMff847a50;
            int i17 = i12 ^ iMff847a502;
            int i18 = i13 ^ iMff847a50;
            i3++;
            if (i3 > 16) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i15, bArr2, i2);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i16, bArr2, i2 + 4);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i17, bArr2, i2 + 8);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i18, bArr2, i2 + 12);
                return 16;
            }
            int iMff847a503 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i16, 1);
            int iMff847a504 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i17, 5);
            int iMff847a505 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i18, 2);
            int i19 = iMff847a503 ^ (iMff847a505 | iMff847a504);
            int i20 = ~i19;
            int i21 = i15 ^ (iMff847a504 & i20);
            int i22 = (iMff847a504 ^ (i20 ^ iMff847a505)) ^ i21;
            int i23 = i19 ^ (i21 | i22);
            int i24 = iMff847a505 ^ (i22 & i23);
            iMc4a600532 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i23, 31);
            iMc4a600533 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i22, 27);
            int iMff847a506 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i21, 30);
            iMc4a60053 = i24;
            iMc4a600534 = iMff847a506;
        }
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((21 + 8) % 8 > 0) {
        }
        int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i);
        int iMc4a600532 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 4);
        int iMc4a600533 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 8);
        int iMc4a600534 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 12);
        int[] iArr = this.f8ce4b16b;
        int i3 = iArr[0];
        int i4 = iArr[1];
        int i5 = iArr[2];
        int i6 = iArr[3];
        int i7 = 16;
        while (true) {
            int i8 = iMc4a60053 ^ iMc4a600533;
            int iMff847a50 = i8 ^ (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i8, 8) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i8, 24));
            int i9 = iMc4a60053 ^ i3;
            int i10 = iMc4a600532 ^ i4;
            int i11 = iMc4a600533 ^ i5;
            int i12 = iMc4a600534 ^ i6;
            int i13 = i10 ^ i12;
            int iMff847a502 = i13 ^ (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i13, 24) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i13, 8));
            int i14 = i10 ^ iMff847a50;
            int i15 = i11 ^ iMff847a502;
            int i16 = i12 ^ iMff847a50;
            int i17 = (i9 ^ iMff847a502) ^ (f0b874a86[i7] & 255);
            i7--;
            if (i7 < 0) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i17, bArr2, i2);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i14, bArr2, i2 + 4);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i15, bArr2, i2 + 8);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i16, bArr2, i2 + 12);
                return 16;
            }
            int iMff847a503 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i14, 1);
            int iMff847a504 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i15, 5);
            int iMff847a505 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i16, 2);
            int i18 = iMff847a503 ^ (iMff847a505 | iMff847a504);
            int i19 = ~i18;
            int i20 = i17 ^ (iMff847a504 & i19);
            int i21 = (iMff847a504 ^ (i19 ^ iMff847a505)) ^ i20;
            int i22 = i18 ^ (i20 | i21);
            int i23 = iMff847a505 ^ (i21 & i22);
            iMc4a600532 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i22, 31);
            iMc4a600533 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i21, 27);
            int iMff847a506 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i20, 30);
            iMc4a60053 = i23;
            iMc4a600534 = iMff847a506;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return "Noekeon";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((29 + 31) % 31 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to Noekeon init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length != 16) {
            throw new java.lang.IllegalArgumentException("Key length not 128 bits.");
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(key, 0, this.f8ce4b16b, 0, 4);
        if (!z) {
            int[] iArr = this.f8ce4b16b;
            int i = iArr[0];
            int i2 = iArr[1];
            int i3 = iArr[2];
            int i4 = iArr[3];
            int i5 = i ^ i3;
            int iMff847a50 = i5 ^ (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i5, 8) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i5, 24));
            int i6 = i2 ^ i4;
            int iMff847a502 = (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i6, 8) ^ p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(i6, 24)) ^ i6;
            int i7 = i ^ iMff847a502;
            int i8 = i2 ^ iMff847a50;
            int i9 = i3 ^ iMff847a502;
            int i10 = i4 ^ iMff847a50;
            int[] iArr2 = this.f8ce4b16b;
            iArr2[0] = i7;
            iArr2[1] = i8;
            iArr2[2] = i9;
            iArr2[3] = i10;
        }
        this.f0657dfb6 = z;
        this.fbdf3566b = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if (!this.fbdf3566b) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i > bArr.length - 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 > bArr2.length - 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        return !this.f0657dfb6 ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

