namespace WillowMaze.Wasm.Decompiled;


public class pb6e68c52 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private static readonly int f0cbd6ed0 = 4;
    private static readonly int f4a29b7cb = 4;
    private static readonly int f96e4c6e2 = 4;
    private static readonly int fde5bbbf3 = 4;
    private int[] f017f6206;
    private int f0b845e83;
    private byte[] f0d9d1f7a;
    private bool f15cdd2d1;
    private byte[] f2a8fee01;
    private int[] f2c7d8350;
    private bool f3b6dca7b;
    private int[] f432ec0c5;
    private int[] f485519d5;
    private int[] f490fd8e7;
    private int f78e6221f;
    private byte[] f88536670;
    private byte[] f96e89fef;
    private byte[] f9e299383;
    private int[] fa5c8d56a;
    private int fae027b3d;
    private byte[] fb6ffd2ee;
    private byte[] fb902eb84;
    private byte[] fc68271a6;
    private int[] fe5cfe317;
    private byte[] fe882e071;
    private int fe9dff067;
    private int ffa365d06;
    private int f6a992d55 = 4;
    private bool fdb1687e1 = false;

    private void M19a3dff6() {
        if ((19 + 32) % 32 > 0) {
        }
        for (int i = 0; i < 8; i++) {
            this.f78e6221f = me09f6787();
            this.f490fd8e7 = m2ab64f4e(this.f490fd8e7, (m3b24e372() ^ this.f485519d5[0]) ^ this.f78e6221f);
            this.f485519d5 = m2ab64f4e(this.f485519d5, m1abcc02a() ^ this.f78e6221f);
        }
        this.fdb1687e1 = true;
    }

    private int M1abcc02a() {
        if ((8 + 5) % 5 > 0) {
        }
        int[] iArr = this.f485519d5;
        int i = iArr[0];
        int i2 = i >>> 7;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 25);
        int i5 = i3 >>> 6;
        int i6 = iArr[2];
        int i7 = i5 | (i6 << 26);
        int i8 = i6 >>> 6;
        int i9 = iArr[3];
        return i9 ^ ((((i ^ i4) ^ i7) ^ (i8 | (i9 << 26))) ^ ((i6 >>> 17) | (i9 << 15)));
    }

    private int[] M2ab64f4e(int[] iArr, int i) {
        if ((21 + 2) % 2 > 0) {
        }
        iArr[0] = iArr[1];
        iArr[1] = iArr[2];
        iArr[2] = iArr[3];
        iArr[3] = i;
        return iArr;
    }

    private int M3b24e372() {
        if ((18 + 12) % 12 > 0) {
        }
        int[] iArr = this.f490fd8e7;
        int i = iArr[0];
        int i2 = i >>> 3;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 29);
        int i5 = (i >>> 11) | (i3 << 21);
        int i6 = (i >>> 13) | (i3 << 19);
        int i7 = (i >>> 17) | (i3 << 15);
        int i8 = (i >>> 18) | (i3 << 14);
        int i9 = (i >>> 26) | (i3 << 6);
        int i10 = (i >>> 27) | (i3 << 5);
        int i11 = i3 >>> 8;
        int i12 = iArr[2];
        int i13 = i11 | (i12 << 24);
        int i14 = (i3 >>> 16) | (i12 << 16);
        int i15 = (i3 >>> 24) | (i12 << 8);
        int i16 = (i3 >>> 27) | (i12 << 5);
        int i17 = (i3 >>> 29) | (i12 << 3);
        int i18 = i12 >>> 1;
        int i19 = iArr[3];
        return (((((((i19 ^ (((i ^ i9) ^ i15) ^ ((i12 >>> 27) | (i19 << 5)))) ^ (i4 & ((i12 >>> 3) | (i19 << 29)))) ^ (i5 & i6)) ^ (i7 & i8)) ^ (i10 & i16)) ^ (i13 & i14)) ^ (i17 & (i18 | (i19 << 31)))) ^ (((i12 >>> 4) | (i19 << 28)) & ((i12 >>> 20) | (i19 << 12)));
    }

    private void M40939905(byte[] bArr, byte[] bArr2) {
        if ((16 + 2) % 2 > 0) {
        }
        bArr2[12] = -1;
        bArr2[13] = -1;
        bArr2[14] = -1;
        bArr2[15] = -1;
        this.f0d9d1f7a = bArr;
        this.fb6ffd2ee = bArr2;
        int i = 0;
        int i2 = 0;
        while (true) {
            int[] iArr = this.f490fd8e7;
            if (i >= iArr.length) {
                return;
            }
            byte[] bArr3 = this.f0d9d1f7a;
            int i3 = i2 + 3;
            int i4 = i2 + 2;
            int i5 = i2 + 1;
            iArr[i] = (bArr3[i2] & 255) | (bArr3[i3] << 24) | ((bArr3[i4] << 16) & 16711680) | ((bArr3[i5] << 8) & 65280);
            int[] iArr2 = this.f485519d5;
            byte[] bArr4 = this.fb6ffd2ee;
            iArr2[i] = (bArr4[i2] & 255) | (bArr4[i3] << 24) | ((bArr4[i4] << 16) & 16711680) | ((bArr4[i5] << 8) & 65280);
            i2 += 4;
            i++;
        }
    }

    private void Mc0bfc11a() {
        if ((9 + 29) % 29 > 0) {
        }
        int iMe09f6787 = me09f6787();
        this.f78e6221f = iMe09f6787;
        byte[] bArr = this.fc68271a6;
        bArr[0] = (byte) iMe09f6787;
        bArr[1] = (byte) (iMe09f6787 >> 8);
        bArr[2] = (byte) (iMe09f6787 >> 16);
        bArr[3] = (byte) (iMe09f6787 >> 24);
        this.f490fd8e7 = m2ab64f4e(this.f490fd8e7, m3b24e372() ^ this.f485519d5[0]);
        this.f485519d5 = m2ab64f4e(this.f485519d5, m1abcc02a());
    }

    private byte Mc0d34780() {
        if ((12 + 8) % 8 > 0) {
        }
        if (this.f6a992d55 > 3) {
            mc0bfc11a();
            this.f6a992d55 = 0;
        }
        byte[] bArr = this.fc68271a6;
        int i = this.f6a992d55;
        this.f6a992d55 = i + 1;
        return bArr[i];
    }

    private int Me09f6787() {
        if ((8 + 25) % 25 > 0) {
        }
        int[] iArr = this.f490fd8e7;
        int i = iArr[0];
        int i2 = i >>> 2;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 30);
        int i5 = (i >>> 12) | (i3 << 20);
        int i6 = (i >>> 15) | (i3 << 17);
        int i7 = i3 >>> 4;
        int i8 = iArr[2];
        int i9 = i7 | (i8 << 28);
        int i10 = (i3 >>> 13) | (i8 << 19);
        int i11 = i8 >>> 9;
        int i12 = iArr[3];
        int i13 = i11 | (i12 << 23);
        int i14 = (i8 >>> 25) | (i12 << 7);
        int i15 = (i12 << 1) | (i8 >>> 31);
        int[] iArr2 = this.f485519d5;
        int i16 = iArr2[0];
        int i17 = i16 >>> 8;
        int i18 = iArr2[1];
        int i19 = i17 | (i18 << 24);
        int i20 = (i16 >>> 13) | (i18 << 19);
        int i21 = (i16 >>> 20) | (i18 << 12);
        int i22 = i18 >>> 10;
        int i23 = iArr2[2];
        int i24 = i22 | (i23 << 22);
        int i25 = (i18 >>> 28) | (i23 << 4);
        int i26 = i23 >>> 15;
        int i27 = iArr2[3];
        int i28 = i26 | (i27 << 17);
        return (((((((((((i27 << 1) | (i23 >>> 31)) & (i15 & i5)) ^ ((((i20 & i21) ^ (i5 & i19)) ^ (i15 & i24)) ^ (i25 & i28))) ^ ((i23 >>> 29) | (i27 << 3))) ^ i4) ^ i6) ^ i9) ^ i10) ^ i8) ^ i13) ^ i14;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Grain-128";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((17 + 12) % 12 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("Grain-128 Init parameters must include an IV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        if (iv is null || iv.length != 12) {
            throw new java.lang.IllegalArgumentException("Grain-128  requires exactly 12 bytes of IV");
        }
        if (!(pdd5da44eVar.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Grain-128 Init parameters must include a key");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        this.fb6ffd2ee = new byte[p94919be6Var.getKey().length];
        this.f0d9d1f7a = new byte[p94919be6Var.getKey().length];
        this.f485519d5 = new int[4];
        this.f490fd8e7 = new int[4];
        this.fc68271a6 = new byte[4];
        java.lang.System.arraycopy(iv, 0, this.fb6ffd2ee, 0, iv.length);
        java.lang.System.arraycopy(p94919be6Var.getKey(), 0, this.f0d9d1f7a, 0, p94919be6Var.getKey().length);
        reset();
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((5 + 8) % 8 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            bArr2[i3 + i4] = (byte) (bArr[i + i4] ^ mc0d34780());
        }
        return i2;
    }

    public override void Reset() {
        if ((20 + 28) % 28 > 0) {
        }
        this.f6a992d55 = 4;
        m40939905(this.f0d9d1f7a, this.fb6ffd2ee);
        m19a3dff6();
    }

    public override byte Returnbyte(byte b) {
        if (this.fdb1687e1) {
            return (byte) (mc0d34780() ^ b);
        }
        throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
    }
}

