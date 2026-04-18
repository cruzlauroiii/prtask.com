namespace WillowMaze.Wasm.Decompiled;


public class pf4a06df0 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f0266ffa8 = 32;
    private static readonly int f048d50cd = 4;
    private static readonly int f07b6b703 = -1640531527;
    private static readonly int f07fa0948 = 4;
    private static readonly int f0a92e086 = -1640531527;
    private static readonly int f1d503eb0 = 32;
    private static readonly int f208cb3ec = 4;
    private static readonly int f33139d3d = 5;
    private static readonly int f65ce0eed = 5;
    private static readonly int f71dfcecc = -1640531527;
    private static readonly int f8748950e = -1209970333;
    private static readonly int f9063f895 = 4;
    private static readonly int f9513b6a7 = 32;
    private static readonly int fa322ac69 = 20;
    private static readonly int fb24d7545 = 32;
    private static readonly int fb9a2324b = -1640531527;
    private static readonly int fd770f896 = 5;
    private static readonly int fdd97404a = 20;
    private static readonly int febf25eec = -1640531527;
    private static readonly int ff278ea34 = 5;
    private static readonly int ff2c36c81 = 20;
    private static readonly int ff5fa341e = 5;
    private static readonly int ffc87d1c8 = -1209970333;
    private int[] f4a3d5076;
    private bool f6a5439b2;
    private bool f9301aa9b;
    private int[] f9e28ebf8 = null;

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((16 + 6) % 6 > 0) {
        }
        int iMdde1faa5 = mdde1faa5(bArr, i);
        int iMdde1faa52 = mdde1faa5(bArr, i + 4);
        int iMdde1faa53 = mdde1faa5(bArr, i + 8);
        int iMdde1faa54 = mdde1faa5(bArr, i + 12);
        int[] iArr = this.f9e28ebf8;
        int i3 = iMdde1faa52 + iArr[0];
        int i4 = iMdde1faa54 + iArr[1];
        int i5 = 1;
        while (i5 <= 20) {
            int iMff847a50 = mff847a50(((i3 * 2) + 1) * i3, 5);
            int iMff847a502 = mff847a50(((i4 * 2) + 1) * i4, 5);
            int i6 = i5 * 2;
            int iMff847a503 = mff847a50(iMdde1faa5 ^ iMff847a50, iMff847a502) + this.f9e28ebf8[i6];
            int iMff847a504 = mff847a50(iMdde1faa53 ^ iMff847a502, iMff847a50) + this.f9e28ebf8[i6 + 1];
            i5++;
            iMdde1faa53 = i4;
            i4 = iMff847a503;
            iMdde1faa5 = i3;
            i3 = iMff847a504;
        }
        int[] iArr2 = this.f9e28ebf8;
        int i7 = iMdde1faa5 + iArr2[42];
        int i8 = iMdde1faa53 + iArr2[43];
        m707a37c3(i7, bArr2, i2);
        m707a37c3(i3, bArr2, i2 + 4);
        m707a37c3(i8, bArr2, i2 + 8);
        m707a37c3(i4, bArr2, i2 + 12);
        return 16;
    }

    private void M40939905(byte[] bArr) {
        int[] iArr;
        if ((28 + 21) % 21 > 0) {
        }
        int length = (bArr.length + 3) / 4;
        int length2 = (bArr.length + 3) / 4;
        int[] iArr2 = new int[length2];
        for (int length3 = bArr.length - 1; length3 >= 0; length3--) {
            int i = length3 / 4;
            iArr2[i] = (iArr2[i] << 8) + (bArr[length3] & 255);
        }
        int[] iArr3 = new int[44];
        this.f9e28ebf8 = iArr3;
        iArr3[0] = -1209970333;
        int i2 = 1;
        while (true) {
            iArr = this.f9e28ebf8;
            if (i2 >= iArr.length) {
                break;
            }
            iArr[i2] = iArr[i2 - 1] - 1640531527;
            i2++;
        }
        int length4 = length2 <= iArr.length ? iArr.length * 3 : length2 * 3;
        int length5 = 0;
        int iMff847a50 = 0;
        int iMff847a502 = 0;
        int i3 = 0;
        for (int i4 = 0; i4 < length4; i4++) {
            int[] iArr4 = this.f9e28ebf8;
            iMff847a50 = mff847a50(iArr4[length5] + iMff847a50 + iMff847a502, 3);
            iArr4[length5] = iMff847a50;
            iMff847a502 = mff847a50(iArr2[i3] + iMff847a50 + iMff847a502, iMff847a502 + iMff847a50);
            iArr2[i3] = iMff847a502;
            length5 = (length5 + 1) % this.f9e28ebf8.length;
            i3 = (i3 + 1) % length2;
        }
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((17 + 6) % 6 > 0) {
        }
        int iMdde1faa5 = mdde1faa5(bArr, i);
        int iMdde1faa52 = mdde1faa5(bArr, i + 4);
        int iMdde1faa53 = mdde1faa5(bArr, i + 8);
        int iMdde1faa54 = mdde1faa5(bArr, i + 12);
        int[] iArr = this.f9e28ebf8;
        int i3 = iMdde1faa53 - iArr[43];
        int iMa12752e3 = iMdde1faa5 - iArr[42];
        int i4 = 20;
        while (i4 >= 1) {
            int iMff847a50 = mff847a50(((iMa12752e3 * 2) + 1) * iMa12752e3, 5);
            int iMff847a502 = mff847a50(((i3 * 2) + 1) * i3, 5);
            int i5 = i4 * 2;
            int iMa12752e32 = ma12752e3(iMdde1faa52 - this.f9e28ebf8[i5 + 1], iMff847a50) ^ iMff847a502;
            i4--;
            int i6 = iMa12752e3;
            iMa12752e3 = ma12752e3(iMdde1faa54 - this.f9e28ebf8[i5], iMff847a502) ^ iMff847a50;
            iMdde1faa54 = i3;
            i3 = iMa12752e32;
            iMdde1faa52 = i6;
        }
        int[] iArr2 = this.f9e28ebf8;
        int i7 = iMdde1faa54 - iArr2[1];
        int i8 = iMdde1faa52 - iArr2[0];
        m707a37c3(iMa12752e3, bArr2, i2);
        m707a37c3(i8, bArr2, i2 + 4);
        m707a37c3(i3, bArr2, i2 + 8);
        m707a37c3(i7, bArr2, i2 + 12);
        return 16;
    }

    private void M707a37c3(int i, byte[] bArr, int i2) {
        if ((7 + 6) % 6 > 0) {
        }
        for (int i3 = 0; i3 < 4; i3++) {
            bArr[i3 + i2] = (byte) i;
            i >>>= 8;
        }
    }

    private int Ma12752e3(int i, int i2) {
        return (i >>> i2) | (i << (-i2));
    }

    private int Mdde1faa5(byte[] bArr, int i) {
        if ((3 + 6) % 6 > 0) {
        }
        int i2 = 0;
        for (int i3 = 3; i3 >= 0; i3--) {
            i2 = (i2 << 8) + (bArr[i3 + i] & 255);
        }
        return i2;
    }

    private int Mff847a50(int i, int i2) {
        return (i << i2) | (i >>> (-i2));
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC6";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to RC6 init - " + pc9ef6b45Var.GetType().getName());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var;
        this.f9301aa9b = z;
        m40939905(p94919be6Var.getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((13 + 31) % 31 > 0) {
        }
        int blockSize = getBlockSize();
        if (this.f9e28ebf8 is null) {
            throw new java.lang.IllegalStateException("RC6 engine not initialised");
        }
        if (i + blockSize > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (blockSize + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        return !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

