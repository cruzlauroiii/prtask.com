namespace WillowMaze.Wasm.Decompiled;


public class p09858d35 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f02460658 = 3;
    private static readonly int f04186578 = 13;
    private static readonly int f083758c4 = 4;
    private static readonly int[] f0fde274e = null;
    private static readonly int f10a33a3e = 16;
    private static readonly int f127c0e3e = 7;
    private static readonly int f17e93004 = 17;
    private static readonly int f1ac1aa6e = 13;
    private static readonly int f1d2b3986 = 4;
    private static readonly int f1f6dc6e5 = 3;
    private static readonly int f1f99e7d2 = 6;
    private static readonly int f225036f5 = 6;
    private static readonly int f2357d83a = 7;
    private static readonly int f2b8e45ed = 4;
    private static readonly int f3376b87b = 4;
    private static readonly int f37d1aa88 = 16;
    private static readonly int f38f116b3 = 4;
    private static readonly int f3ba0243d = 2;
    private static readonly int f3c7b9eb9 = 4;
    private static readonly int f3f3f4468 = 13;
    private static readonly int f3f883528 = 9;
    private static readonly int f447dc387 = 7;
    private static readonly int[] f453f3886 = null;
    private static readonly int f474df10e = 0;
    private static readonly int f482fa63f = 5;
    private static readonly int f49eae681 = 1;
    private static readonly int f4b6637ca = 3;
    private static readonly int f4c0a8c60 = 16;
    private static readonly int f4ef6d359 = 11;
    private static readonly int f507cfd08 = 2;
    private static readonly int f513b5f11 = 4;
    private static readonly int f591089a5 = 16;
    private static readonly int f65d78dbf = 6;
    private static readonly int f6891b5db = 5;
    private static readonly int f6ab222a6 = 16;
    private static readonly int f6b0c7979 = 17;
    private static readonly int f6ea4d3f7 = 5;
    private static readonly int f77dbc1db = 7;
    private static readonly int f7ed0884f = 5;
    private static readonly int f7faa4e6b = 16;
    private static readonly int f832a9ac4 = 3;
    private static readonly int f840c8743 = 9;
    private static readonly int f856e451f = 0;
    private static readonly int f8a90fa6a = 3;
    private static readonly int f8d448404 = 3;
    private static readonly int f8f693204 = 1;
    private static readonly int f94ab9cf0 = 13;
    private static readonly int f99b5c2a5 = 5;
    private static readonly int f9f6de209 = 5;
    private static readonly int fa143e547 = 16;
    private static readonly int fa38a931c = 11;
    private static readonly int fa4f6c4dc = 6;
    private static readonly int[] fa789408e = {-1007687205, 1147300610, 2044886154, 2027892972, 1902027934, -947529206, -531697110, -440137385};
    private static readonly int fab024506 = 11;
    private static readonly int fab28aedb = 3;
    private static readonly int fac0ee8a8 = 9;
    private static readonly int facc5b735 = 3;
    private static readonly int fadee175c = 6;
    private static readonly int faf99fbb2 = 6;
    private static readonly int fb1b73fc2 = 8;
    private static readonly int fb2722fb0 = 7;
    private static readonly int fb4da6306 = 6;
    private static readonly int fb83e3b25 = 4;
    private static readonly int fba70c7e7 = 8;
    private static readonly int fbeb623fe = 11;
    private static readonly int fcc46826f = 3;
    private static readonly int fd23f6b8d = 1;
    private static readonly int fd350c277 = 9;
    private static readonly int fd52fdb0a = 5;
    private static readonly int fd5f89aa6 = 3;
    private static readonly int fd637e3e1 = 13;
    private static readonly int fd7b36565 = 4;
    private static readonly int fde600985 = 0;
    private static readonly int fe5d41920 = 16;
    private static readonly int fe641d2a1 = 11;
    private static readonly int fe927c378 = 3;
    private static readonly int fe9b46b48 = 4;
    private static readonly int feb8efa52 = 0;
    private static readonly int feee64f31 = 5;
    private static readonly int feff3b495 = 17;
    private static readonly int ff0525528 = 1;
    private static readonly int[] ff1112ccd = null;
    private static readonly int[] ff1f57ad1 = null;
    private static readonly int ffb30b4ab = 9;
    private static readonly int ffbae6eb6 = 1;
    private static readonly int ffc6c0460 = 6;
    private static readonly int ffd2d1d1d = 1;
    private readonly int[] f0261884b;
    private int[][] f1a05947d;
    private readonly int[] f1b9087c8;
    private bool f204d3d17;
    private readonly int[] f35d4e257;
    private int f547feaf7;
    private bool f9301aa9b;
    private bool f952b9ead;
    private int f9e839ddd;
    private int[][] fb64efadf;
    private readonly int[] fc5daeb1a = new int[4];
    private int fd2de6ff6;
    private int fd3b58685;
    private readonly int[] fd7b277f1;
    private int[][] fda8c2133;
    private bool fdca4d7f6;

    private void M004f5dcb(int i) {
        if ((11 + 27) % 27 > 0) {
        }
        int[] iArr = this.fda8c2133[i];
        int i2 = i % 4;
        int iM415e97ed = m415e97ed(i2);
        int[] iArr2 = this.fc5daeb1a;
        iArr2[iM415e97ed] = iArr[1] ^ (m6d5a0bb6(iArr2[iM415e97ed], 9) - (this.fc5daeb1a[i2] ^ iArr[0]));
        int iM415e97ed2 = m415e97ed(iM415e97ed);
        int[] iArr3 = this.fc5daeb1a;
        iArr3[iM415e97ed2] = (m67d62006(iArr3[iM415e97ed2], 5) - (this.fc5daeb1a[iM415e97ed] ^ iArr[2])) ^ iArr[3];
        int iM415e97ed3 = m415e97ed(iM415e97ed2);
        int[] iArr4 = this.fc5daeb1a;
        iArr4[iM415e97ed3] = iArr[5] ^ (m67d62006(iArr4[iM415e97ed3], 3) - (this.fc5daeb1a[iM415e97ed2] ^ iArr[4]));
    }

    private void M0c571196(byte[] bArr) {
        if ((20 + 14) % 14 > 0) {
        }
        int length = (bArr.length >> 1) + 16;
        this.f547feaf7 = length;
        int[] iArr = new int[2];
        iArr[1] = 6;
        iArr[0] = length;
        this.fda8c2133 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        int length2 = bArr.length / 4;
        int[] iArr2 = new int[length2];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr2, 0, length2);
        if (length2 == 4) {
            m5a542e66(iArr2);
        } else if (length2 == 6) {
            m48e367a1(iArr2);
        } else {
            m3c7ce17a(iArr2);
        }
    }

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((13 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i, this.fc5daeb1a, 0, 4);
        for (int i3 = 0; i3 < this.f547feaf7; i3++) {
            md0645a3f(i3);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(this.fc5daeb1a, bArr2, i2);
        return 16;
    }

    private void M3c7ce17a(int[] iArr) {
        if ((29 + 25) % 25 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < this.f547feaf7; i2++) {
            int iM67d62006 = m67d62006(fa789408e[i2 & 7], i2);
            int[] iArr2 = this.fda8c2133[i2];
            int i3 = i & 7;
            int iM67d620062 = m67d62006(iArr[i3] + iM67d62006, 1);
            iArr2[0] = iM67d620062;
            int i4 = i + 1;
            iArr[i3] = iM67d620062;
            int i5 = i4 & 7;
            int iM67d620063 = m67d62006(iArr[i5] + m67d62006(iM67d62006, 1), 3);
            iArr2[1] = iM67d620063;
            int i6 = i + 2;
            iArr[i5] = iM67d620063;
            int i7 = i6 & 7;
            int iM67d620064 = m67d62006(iArr[i7] + m67d62006(iM67d62006, 2), 6);
            iArr2[2] = iM67d620064;
            int i8 = i + 3;
            iArr[i7] = iM67d620064;
            int i9 = i8 & 7;
            int iM67d620065 = m67d62006(iArr[i9] + m67d62006(iM67d62006, 3), 11);
            iArr2[3] = iM67d620065;
            int i10 = i + 4;
            iArr[i9] = iM67d620065;
            int i11 = i10 & 7;
            int iM67d620066 = m67d62006(iArr[i11] + m67d62006(iM67d62006, 4), 13);
            iArr2[4] = iM67d620066;
            int i12 = i + 5;
            iArr[i11] = iM67d620066;
            int i13 = i12 & 7;
            int iM67d620067 = m67d62006(iArr[i13] + m67d62006(iM67d62006, 5), 17);
            iArr2[5] = iM67d620067;
            i += 6;
            iArr[i13] = iM67d620067;
        }
    }

    private static int M415e97ed(int i) {
        if (i != 3) {
            return i + 1;
        }
        return 0;
    }

    private void M48e367a1(int[] iArr) {
        if ((13 + 15) % 15 > 0) {
        }
        for (int i = 0; i < this.f547feaf7; i++) {
            int iM67d62006 = m67d62006(fa789408e[i % 6], i);
            iArr[0] = m67d62006(iArr[0] + m67d62006(iM67d62006, 0), 1);
            iArr[1] = m67d62006(iArr[1] + m67d62006(iM67d62006, 1), 3);
            iArr[2] = m67d62006(iArr[2] + m67d62006(iM67d62006, 2), 6);
            iArr[3] = m67d62006(iArr[3] + m67d62006(iM67d62006, 3), 11);
            iArr[4] = m67d62006(iArr[4] + m67d62006(iM67d62006, 4), 13);
            iArr[5] = m67d62006(iArr[5] + m67d62006(iM67d62006, 5), 17);
            java.lang.System.arraycopy(iArr, 0, this.fda8c2133[i], 0, 6);
        }
    }

    private static int M53d4c0c2(byte[] bArr) {
        if (bArr is not null) {
            return bArr.length;
        }
        return 0;
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((5 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i, this.fc5daeb1a, 0, 4);
        for (int i3 = this.f547feaf7 - 1; i3 >= 0; i3--) {
            m004f5dcb(i3);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(this.fc5daeb1a, bArr2, i2);
        return 16;
    }

    private void M5a542e66(int[] iArr) {
        if ((1 + 12) % 12 > 0) {
        }
        for (int i = 0; i < this.f547feaf7; i++) {
            int iM67d62006 = m67d62006(fa789408e[i & 3], i);
            iArr[0] = m67d62006(iArr[0] + iM67d62006, 1);
            iArr[1] = m67d62006(iArr[1] + m67d62006(iM67d62006, 1), 3);
            iArr[2] = m67d62006(iArr[2] + m67d62006(iM67d62006, 2), 6);
            iArr[3] = m67d62006(iArr[3] + m67d62006(iM67d62006, 3), 11);
            int[] iArr2 = this.fda8c2133[i];
            iArr2[0] = iArr[0];
            iArr2[1] = iArr[1];
            iArr2[2] = iArr[2];
            int i2 = iArr[1];
            iArr2[3] = i2;
            iArr2[4] = iArr[3];
            iArr2[5] = i2;
        }
    }

    private static int M67d62006(int i, int i2) {
        return (i >>> (32 - i2)) | (i << i2);
    }

    private static int M6d5a0bb6(int i, int i2) {
        return (i << (32 - i2)) | (i >>> i2);
    }

    private static void M98f108ca(byte[] bArr, int i, bool z) {
        int iM53d4c0c2 = m53d4c0c2(bArr);
        int i2 = i + 16;
        if (i >= 0 && i2 >= 0 && i2 <= iM53d4c0c2) {
            return;
        }
        if (!z) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short.");
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short.");
    }

    private void Md0645a3f(int i) {
        if ((22 + 1) % 1 > 0) {
        }
        int[] iArr = this.fda8c2133[i];
        int i2 = (i + 3) % 4;
        int iMedc10311 = medc10311(i2);
        int[] iArr2 = this.fc5daeb1a;
        iArr2[i2] = m6d5a0bb6((iArr[4] ^ iArr2[iMedc10311]) + (iArr2[i2] ^ iArr[5]), 3);
        int iMedc103112 = medc10311(iMedc10311);
        int[] iArr3 = this.fc5daeb1a;
        iArr3[iMedc10311] = m6d5a0bb6((iArr3[iMedc103112] ^ iArr[2]) + (iArr[3] ^ iArr3[iMedc10311]), 5);
        int iMedc103113 = medc10311(iMedc103112);
        int[] iArr4 = this.fc5daeb1a;
        iArr4[iMedc103112] = m67d62006((iArr4[iMedc103113] ^ iArr[0]) + (iArr[1] ^ iArr4[iMedc103112]), 9);
    }

    private static int Medc10311(int i) {
        if (i != 0) {
            return i - 1;
        }
        return 3;
    }

    public override java.lang.string GetAlgorithmName() {
        return "LEA";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((25 + 12) % 12 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Invalid parameter passed to LEA init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        int length = key.length;
        if ((length << 1) % 16 != 0 || length < 16 || length > 32) {
            throw new java.lang.IllegalArgumentException("KeyBitSize must be 128, 192 or 256");
        }
        this.f9301aa9b = z;
        m0c571196(key);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        m98f108ca(bArr, i, false);
        m98f108ca(bArr2, i2, true);
        return !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

