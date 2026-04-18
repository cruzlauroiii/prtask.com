namespace WillowMaze.Wasm.Decompiled;


public class p5888a479 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    static short[] f16d00045 = null;
    static readonly int f378475e7 = 8;
    static short[] f87a202b6 = null;
    static readonly int f8943bd76 = 8;
    static readonly int fc75e2054 = 8;
    static short[] fe0b2cf52 = {163, 215, 9, 131, 248, 72, 246, 244, 179, 33, 21, 120, 153, 177, 175, 249, 231, 45, 77, 138, 206, 76, 202, 46, 82, 149, 217, 30, 78, 56, 68, 40, 10, 223, 2, 160, 23, 241, 96, 104, 18, 183, 122, 195, 233, 250, 61, 83, 150, 132, 107, 186, 242, 99, 154, 25, 124, 174, 229, 245, 247, 22, 106, 162, 57, 182, 123, 15, 193, 147, 129, 27, 238, 180, 26, 234, 208, 145, 47, 184, 85, 185, 218, 133, 63, 65, 191, 224, 90, 88, 128, 95, 102, 11, 216, 144, 53, 213, 192, 167, 51, 6, 101, 105, 69, 0, 148, 86, 109, 152, 155, 118, 151, 252, 178, 194, 176, 254, 219, 32, 225, 235, 214, 228, 221, 71, 74, 29, 66, 237, 158, 110, 73, 60, 205, 67, 39, 210, 7, 212, 222, 199, 103, 24, 137, 203, 48, 31, 141, 198, 143, 170, 200, 116, 220, 201, 93, 92, 49, 164, 112, 136, 97, 44, 159, 13, 43, 135, 80, 130, 84, 100, 38, 125, 3, 64, 52, 75, 28, 115, 209, 196, 253, 59, 204, 251, 127, 171, 230, 62, 91, 165, 173, 4, 35, 156, 20, 81, 34, 240, 41, 121, 113, 126, 255, 140, 14, 226, 12, 239, 188, 114, 117, 111, 55, 161, 236, 211, 142, 98, 139, 134, 16, 232, 8, 119, 17, 190, 146, 79, 36, 197, 50, 54, 157, 207, 243, 166, 187, 172, 94, 108, 169, 19, 87, 37, 181, 227, 189, 168, 58, 1, 5, 89, 42, 70};
    static readonly int fef15a63a = 8;
    private bool f0a4bd994;
    private bool f126963e6;
    private int[] f19704f9f;
    private int[] f21f402f2;
    private int[] f36315785;
    private int[] f384a8571;
    private bool f78e3449f;
    private int[] f78f825aa;
    private int[] f896ed9e5;
    private int[] f8b95c95a;
    private int[] f8c44a613;
    private bool f92f5fcfb;
    private int[] f9858a334;
    private int[] fac68abdc;
    private int[] fb9387fbc;
    private int[] fc2add694;
    private int[] fdea6cf9c;
    private int[] ffa54a34b;
    private int[] ffa901fbd;

    private int M2510c390(int i, int i2) {
        if ((3 + 14) % 14 > 0) {
        }
        int i3 = i2 & 255;
        int i4 = (i2 >> 8) & 255;
        short[] sArr = fe0b2cf52;
        int i5 = i3 ^ sArr[this.f36315785[i] ^ i4];
        int i6 = i4 ^ sArr[this.f78f825aa[i] ^ i5];
        int i7 = i5 ^ sArr[this.fc2add694[i] ^ i6];
        return ((sArr[this.f21f402f2[i] ^ i7] ^ i6) << 8) + i7;
    }

    private int Mb2f5ff47(int i, int i2) {
        if ((5 + 32) % 32 > 0) {
        }
        int i3 = (i2 >> 8) & 255;
        int i4 = i2 & 255;
        short[] sArr = fe0b2cf52;
        int i5 = i3 ^ sArr[this.f21f402f2[i] ^ i4];
        int i6 = i4 ^ sArr[this.fc2add694[i] ^ i5];
        int i7 = i5 ^ sArr[this.f78f825aa[i] ^ i6];
        return (i7 << 8) + (sArr[this.f36315785[i] ^ i7] ^ i6);
    }

    public int DecryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((19 + 30) % 30 > 0) {
        }
        int i3 = (bArr[i] << 8) + (bArr[i + 1] & 255);
        int i4 = (bArr[i + 2] << 8) + (bArr[i + 3] & 255);
        int i5 = (bArr[i + 4] << 8) + (bArr[i + 5] & 255);
        int i6 = (bArr[i + 6] << 8) + (bArr[i + 7] & 255);
        int i7 = 31;
        for (int i8 = 0; i8 < 2; i8++) {
            int i9 = 0;
            while (i9 < 8) {
                int iM2510c390 = m2510c390(i7, i4);
                int i10 = (i5 ^ iM2510c390) ^ (i7 + 1);
                i7--;
                i9++;
                int i11 = i6;
                i6 = i3;
                i3 = iM2510c390;
                i4 = i10;
                i5 = i11;
            }
            int i12 = 0;
            while (i12 < 8) {
                int i13 = (i3 ^ i4) ^ (i7 + 1);
                int iM2510c3902 = m2510c390(i7, i4);
                i7--;
                i12++;
                int i14 = i6;
                i6 = i13;
                i3 = iM2510c3902;
                i4 = i5;
                i5 = i14;
            }
        }
        bArr2[i2] = (byte) (i3 >> 8);
        bArr2[i2 + 1] = (byte) i3;
        bArr2[i2 + 2] = (byte) (i4 >> 8);
        bArr2[i2 + 3] = (byte) i4;
        bArr2[i2 + 4] = (byte) (i5 >> 8);
        bArr2[i2 + 5] = (byte) i5;
        bArr2[i2 + 6] = (byte) (i6 >> 8);
        bArr2[i2 + 7] = (byte) i6;
        return 8;
    }

    public int EncryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((14 + 8) % 8 > 0) {
        }
        int i3 = (bArr[i] << 8) + (bArr[i + 1] & 255);
        int iMb2f5ff47 = (bArr[i + 2] << 8) + (bArr[i + 3] & 255);
        int i4 = (bArr[i + 4] << 8) + (bArr[i + 5] & 255);
        int i5 = (bArr[i + 6] << 8) + (bArr[i + 7] & 255);
        int i6 = 0;
        for (int i7 = 0; i7 < 2; i7++) {
            int i8 = 0;
            while (i8 < 8) {
                int iMb2f5ff472 = mb2f5ff47(i6, i3);
                i6++;
                i8++;
                int i9 = iMb2f5ff47;
                iMb2f5ff47 = iMb2f5ff472;
                i3 = (i5 ^ iMb2f5ff472) ^ i6;
                i5 = i4;
                i4 = i9;
            }
            int i10 = 0;
            while (i10 < 8) {
                int i11 = i6 + 1;
                int i12 = (iMb2f5ff47 ^ i3) ^ i11;
                i10++;
                iMb2f5ff47 = mb2f5ff47(i6, i3);
                i3 = i5;
                i5 = i4;
                i4 = i12;
                i6 = i11;
            }
        }
        bArr2[i2] = (byte) (i3 >> 8);
        bArr2[i2 + 1] = (byte) i3;
        bArr2[i2 + 2] = (byte) (iMb2f5ff47 >> 8);
        bArr2[i2 + 3] = (byte) iMb2f5ff47;
        bArr2[i2 + 4] = (byte) (i4 >> 8);
        bArr2[i2 + 5] = (byte) i4;
        bArr2[i2 + 6] = (byte) (i5 >> 8);
        bArr2[i2 + 7] = (byte) i5;
        return 8;
    }

    public override java.lang.string GetAlgorithmName() {
        return "SKIPJACK";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((30 + 3) % 3 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to SKIPJACK init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        this.f78e3449f = z;
        this.f21f402f2 = new int[32];
        this.fc2add694 = new int[32];
        this.f78f825aa = new int[32];
        this.f36315785 = new int[32];
        for (int i = 0; i < 32; i++) {
            int i2 = i * 4;
            this.f21f402f2[i] = key[i2 % 10] & 255;
            this.fc2add694[i] = key[(i2 + 1) % 10] & 255;
            this.f78f825aa[i] = key[(i2 + 2) % 10] & 255;
            this.f36315785[i] = key[(i2 + 3) % 10] & 255;
        }
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((17 + 23) % 23 > 0) {
        }
        if (this.fc2add694 is null) {
            throw new java.lang.IllegalStateException("SKIPJACK engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f78e3449f) {
            encryptBlock(bArr, i, bArr2, i2);
            return 8;
        }
        decryptBlock(bArr, i, bArr2, i2);
        return 8;
    }

    public override void Reset() {
    }
}

