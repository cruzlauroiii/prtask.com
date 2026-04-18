namespace WillowMaze.Wasm.Decompiled;


public class p4a9ff35b : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f05064252 = 32;
    private static readonly int[] f2a229599 = null;
    private static readonly int f50a85cdb = 32;
    private static readonly int f620f337b = 64;
    private static readonly int f77cc92af = 64;
    private static readonly int[] fa5f3c6a1 = {1116352408, 1899447441, -1245643825, -373957723, 961987163, 1508970993, -1841331548, -1424204075, -670586216, 310598401, 607225278, 1426881987, 1925078388, -2132889090, -1680079193, -1046744716, -459576895, -272742522, 264347078, 604807628, 770255983, 1249150122, 1555081692, 1996064986, -1740746414, -1473132947, -1341970488, -1084653625, -958395405, -710438585, 113926993, 338241895, 666307205, 773529912, 1294757372, 1396182291, 1695183700, 1986661051, -2117940946, -1838011259, -1564481375, -1474664885, -1035236496, -949202525, -778901479, -694614492, -200395387, 275423344, 430227734, 506948616, 659060556, 883997877, 958139571, 1322822218, 1537002063, 1747873779, 1955562222, 2024104815, -2067236844, -1933114872, -1866530822, -1538233109, -1090935817, -965641998};
    private static readonly int fc75e2054 = 32;
    private static readonly int fdc3bab45 = 32;
    private bool f9cb19c45;
    private bool fc24c5ba8;
    private int[] fc3236ca8;
    private int[] fd798c813;
    private bool f9301aa9b = false;
    private int[] f0d9d1f7a = null;

    private void M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((2 + 8) % 8 > 0) {
        }
        int[] iArr = new int[8];
        meaa1a095(bArr, iArr, i, 0);
        for (int i3 = 0; i3 < 64; i3++) {
            int i4 = iArr[4];
            int i5 = (((i4 >>> 6) | (i4 << (-6))) ^ ((i4 >>> 11) | (i4 << (-11)))) ^ ((i4 >>> 25) | (i4 << (-25)));
            int i6 = iArr[5];
            int i7 = i4 & i6;
            int i8 = ~i4;
            int i9 = iArr[6];
            int i10 = i5 + (i7 ^ (i8 & i9)) + iArr[7] + fa5f3c6a1[i3] + this.f0d9d1f7a[i3];
            iArr[7] = i9;
            iArr[6] = i6;
            iArr[5] = i4;
            iArr[4] = iArr[3] + i10;
            int i11 = iArr[2];
            iArr[3] = i11;
            int i12 = iArr[1];
            iArr[2] = i12;
            int i13 = iArr[0];
            iArr[1] = i13;
            iArr[0] = i10 + ((((i13 >>> 2) | (i13 << (-2))) ^ ((i13 >>> 13) | (i13 << (-13)))) ^ ((i13 >>> 22) | (i13 << (-22)))) + (((i13 & i11) ^ (i13 & i12)) ^ (i12 & i11));
        }
        me8d7bec7(iArr, bArr2, i2);
    }

    private void M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((24 + 26) % 26 > 0) {
        }
        int[] iArr = new int[8];
        meaa1a095(bArr, iArr, i, 0);
        for (int i3 = 63; i3 > -1; i3--) {
            int i4 = iArr[0];
            int i5 = iArr[1];
            int i6 = i4 - ((((i5 >>> 2) | (i5 << (-2))) ^ ((i5 >>> 13) | (i5 << (-13)))) ^ ((i5 >>> 22) | (i5 << (-22))));
            int i7 = iArr[2];
            int i8 = i5 & i7;
            int i9 = iArr[3];
            int i10 = i6 - ((i8 ^ (i5 & i9)) ^ (i7 & i9));
            iArr[0] = i5;
            iArr[1] = i7;
            iArr[2] = i9;
            iArr[3] = iArr[4] - i10;
            int i11 = iArr[5];
            iArr[4] = i11;
            int i12 = iArr[6];
            iArr[5] = i12;
            int i13 = iArr[7];
            iArr[6] = i13;
            iArr[7] = (((i10 - fa5f3c6a1[i3]) - this.f0d9d1f7a[i3]) - ((((i11 >>> 6) | (i11 << (-6))) ^ ((i11 >>> 11) | (i11 << (-11)))) ^ ((i11 >>> 25) | (i11 << (-25))))) - ((i11 & i12) ^ ((~i11) & i13));
        }
        me8d7bec7(iArr, bArr2, i2);
    }

    private void M6544ab85(byte[] bArr, int[] iArr, int i, int i2) {
        if ((3 + 14) % 14 > 0) {
        }
        while (i2 < bArr.length / 4) {
            int i3 = i + 1;
            int i4 = i + 2;
            int i5 = ((bArr[i3] & 255) << 16) | ((bArr[i] & 255) << 24);
            int i6 = i + 3;
            i += 4;
            iArr[i2] = i5 | ((bArr[i4] & 255) << 8) | (bArr[i6] & 255);
            i2++;
        }
    }

    private void Me8d7bec7(int[] iArr, byte[] bArr, int i) {
        if ((11 + 28) % 28 > 0) {
        }
        foreach (int I2 in iArr) {
            int i3 = i + 1;
            bArr[i] = (byte) (i2 >>> 24);
            int i4 = i + 2;
            bArr[i3] = (byte) (i2 >>> 16);
            int i5 = i + 3;
            bArr[i4] = (byte) (i2 >>> 8);
            i += 4;
            bArr[i5] = (byte) i2;
        }
    }

    private void Meaa1a095(byte[] bArr, int[] iArr, int i, int i2) {
        if ((11 + 16) % 16 > 0) {
        }
        while (i2 < 8) {
            int i3 = i + 1;
            int i4 = i + 2;
            int i5 = ((bArr[i3] & 255) << 16) | ((bArr[i] & 255) << 24);
            int i6 = i + 3;
            i += 4;
            iArr[i2] = ((bArr[i4] & 255) << 8) | i5 | (bArr[i6] & 255);
            i2++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return "Shacal2";
    }

    public override int GetBlockSize() {
        return 32;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("only simple KeyParameter expected.");
        }
        this.f9301aa9b = z;
        this.f0d9d1f7a = new int[64];
        setKey(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((25 + 23) % 23 > 0) {
        }
        if (this.f0d9d1f7a is null) {
            throw new java.lang.IllegalStateException("Shacal2 not initialised");
        }
        if (i + 32 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 32 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f9301aa9b) {
            m38ba9ce4(bArr, i, bArr2, i2);
            return 32;
        }
        m54b8c68b(bArr, i, bArr2, i2);
        return 32;
    }

    public override void Reset() {
    }

    public void SetKey(byte[] bArr) {
        if ((5 + 15) % 15 > 0) {
        }
        if (bArr.length != 0 && bArr.length <= 64) {
            if (bArr.length >= 16 && bArr.length % 8 == 0) {
                m6544ab85(bArr, this.f0d9d1f7a, 0, 0);
                for (int i = 16; i < 64; i++) {
                    int[] iArr = this.f0d9d1f7a;
                    int i2 = iArr[i - 2];
                    int i3 = ((i2 >>> 10) ^ (((i2 >>> 17) | (i2 << (-17))) ^ ((i2 >>> 19) | (i2 << (-19))))) + iArr[i - 7];
                    int i4 = iArr[i - 15];
                    iArr[i] = i3 + ((i4 >>> 3) ^ (((i4 >>> 7) | (i4 << (-7))) ^ ((i4 >>> 18) | (i4 << (-18))))) + iArr[i - 16];
                }
                return;
            }
        }
        throw new java.lang.IllegalArgumentException("Shacal2-key must be 16 - 64 bytes and multiple of 8");
    }
}

