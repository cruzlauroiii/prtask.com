namespace WillowMaze.Wasm.Decompiled;


public class p7ccfbd68 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private static readonly int f1a38b94e = 5;
    private static readonly int f4524e0e3 = 5;
    private static readonly int f4a29b7cb = 5;
    private static readonly int f7a9decd5 = 5;
    private static readonly int f7b3af211 = 5;
    private int f004c9c12;
    private byte[] f0d9d1f7a;
    private int[] f13bfb599;
    private byte[] f17f9fa36;
    private byte[] f1856b1fa;
    private int f20ecbf8e;
    private bool f3a4ad986;
    private byte[] f47147212;
    private int[] f485519d5;
    private int[] f490fd8e7;
    private byte[] f5b2b30e1;
    private bool f6ee2c02e;
    private int f78e6221f;
    private byte[] f8469d384;
    private byte[] f8aee6c40;
    private int f9cf77ef6;
    private int f9de7c98d;
    private int[] fa4990e34;
    private byte[] fb6ffd2ee;
    private byte[] fc68271a6;
    private int fd1460721;
    private byte[] fd1a04853;
    private int fec69702f;
    private byte[] fef5b9d3f;
    private bool ff9c9e47d;
    private int[] ffb62d223;
    private int f6a992d55 = 2;
    private bool fdb1687e1 = false;

    private void M19a3dff6() {
        if ((28 + 14) % 14 > 0) {
        }
        for (int i = 0; i < 10; i++) {
            this.f78e6221f = me09f6787();
            this.f490fd8e7 = m2ab64f4e(this.f490fd8e7, (m3b24e372() ^ this.f485519d5[0]) ^ this.f78e6221f);
            this.f485519d5 = m2ab64f4e(this.f485519d5, m1abcc02a() ^ this.f78e6221f);
        }
        this.fdb1687e1 = true;
    }

    private int M1abcc02a() {
        if ((30 + 3) % 3 > 0) {
        }
        int[] iArr = this.f485519d5;
        int i = iArr[0];
        int i2 = i >>> 13;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 3);
        int i5 = i3 >>> 7;
        int i6 = iArr[2];
        int i7 = i5 | (i6 << 9);
        int i8 = i6 >>> 6;
        int i9 = iArr[3];
        int i10 = i8 | (i9 << 10);
        int i11 = i9 >>> 3;
        int i12 = iArr[4];
        return (((i12 << 2) | (i9 >>> 14)) ^ ((((i ^ i4) ^ i7) ^ i10) ^ (i11 | (i12 << 13)))) & 65535;
    }

    private int[] M2ab64f4e(int[] iArr, int i) {
        if ((1 + 29) % 29 > 0) {
        }
        iArr[0] = iArr[1];
        iArr[1] = iArr[2];
        iArr[2] = iArr[3];
        iArr[3] = iArr[4];
        iArr[4] = i;
        return iArr;
    }

    private int M3b24e372() {
        if ((23 + 20) % 20 > 0) {
        }
        int[] iArr = this.f490fd8e7;
        int i = iArr[0];
        int i2 = i >>> 9;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 7);
        int i5 = (i >>> 14) | (i3 << 2);
        int i6 = (i >>> 15) | (i3 << 1);
        int i7 = i3 >>> 5;
        int i8 = iArr[2];
        int i9 = i7 | (i8 << 11);
        int i10 = (i3 >>> 12) | (i8 << 4);
        int i11 = i8 >>> 1;
        int i12 = iArr[3];
        int i13 = i11 | (i12 << 15);
        int i14 = (i8 >>> 5) | (i12 << 11);
        int i15 = (i8 >>> 13) | (i12 << 3);
        int i16 = i12 >>> 4;
        int i17 = iArr[4];
        int i18 = i16 | (i17 << 12);
        int i19 = (i12 >>> 12) | (i17 << 4);
        int i20 = (i12 >>> 14) | (i17 << 2);
        int i21 = (i17 << 1) | (i12 >>> 15);
        int i22 = i21 & i19;
        int i23 = (((i ^ (((((((((i20 ^ i19) ^ i18) ^ i15) ^ i14) ^ i13) ^ i10) ^ i9) ^ i5) ^ i4)) ^ i22) ^ (i14 & i13)) ^ (i6 & i4);
        int i24 = i19 & i18;
        int i25 = i13 & i10 & i9;
        return (((((((((i21 & i15) & i10) & i4) ^ ((i23 ^ (i24 & i15)) ^ i25)) ^ ((i24 & i14) & i13)) ^ ((i22 & i9) & i6)) ^ (((i22 & i18) & i15) & i14)) ^ ((i25 & i6) & i4)) ^ (((((i18 & i15) & i14) & i13) & i10) & i9)) & 65535;
    }

    private void M40939905(byte[] bArr, byte[] bArr2) {
        if ((4 + 22) % 22 > 0) {
        }
        bArr2[8] = -1;
        bArr2[9] = -1;
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
            int i3 = i2 + 1;
            iArr[i] = ((bArr3[i2] & 255) | (bArr3[i3] << 8)) & 65535;
            int[] iArr2 = this.f485519d5;
            byte[] bArr4 = this.fb6ffd2ee;
            iArr2[i] = ((bArr4[i2] & 255) | (bArr4[i3] << 8)) & 65535;
            i2 += 2;
            i++;
        }
    }

    private void Mc0bfc11a() {
        if ((10 + 22) % 22 > 0) {
        }
        int iMe09f6787 = me09f6787();
        this.f78e6221f = iMe09f6787;
        byte[] bArr = this.fc68271a6;
        bArr[0] = (byte) iMe09f6787;
        bArr[1] = (byte) (iMe09f6787 >> 8);
        this.f490fd8e7 = m2ab64f4e(this.f490fd8e7, m3b24e372() ^ this.f485519d5[0]);
        this.f485519d5 = m2ab64f4e(this.f485519d5, m1abcc02a());
    }

    private byte Mc0d34780() {
        if ((12 + 9) % 9 > 0) {
        }
        if (this.f6a992d55 > 1) {
            mc0bfc11a();
            this.f6a992d55 = 0;
        }
        byte[] bArr = this.fc68271a6;
        int i = this.f6a992d55;
        this.f6a992d55 = i + 1;
        return bArr[i];
    }

    private int Me09f6787() {
        if ((14 + 10) % 10 > 0) {
        }
        int[] iArr = this.f490fd8e7;
        int i = iArr[0];
        int i2 = i >>> 1;
        int i3 = iArr[1];
        int i4 = i2 | (i3 << 15);
        int i5 = (i >>> 2) | (i3 << 14);
        int i6 = (i >>> 4) | (i3 << 12);
        int i7 = (i >>> 10) | (i3 << 6);
        int i8 = i3 >>> 15;
        int i9 = iArr[2];
        int i10 = i8 | (i9 << 1);
        int i11 = i9 >>> 11;
        int i12 = iArr[3];
        int i13 = i11 | (i12 << 5);
        int i14 = i12 >>> 8;
        int i15 = iArr[4];
        int i16 = i14 | (i15 << 8);
        int i17 = (i15 << 1) | (i12 >>> 15);
        int[] iArr2 = this.f485519d5;
        int i18 = iArr2[0] >>> 3;
        int i19 = iArr2[1];
        int i20 = i18 | (i19 << 13);
        int i21 = i19 >>> 9;
        int i22 = iArr2[2];
        int i23 = i21 | (i22 << 7);
        int i24 = (iArr2[3] << 2) | (i22 >>> 14);
        int i25 = iArr2[4];
        int i26 = i24 & i25;
        int i27 = ((((i23 ^ i17) ^ (i20 & i25)) ^ i26) ^ (i25 & i17)) ^ ((i20 & i23) & i24);
        int i28 = i20 & i24;
        return ((((((((((((i25 & i28) ^ i27) ^ (i28 & i17)) ^ ((i23 & i24) & i17)) ^ (i17 & i26)) ^ i4) ^ i5) ^ i6) ^ i7) ^ i10) ^ i13) ^ i16) & 65535;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Grain v1";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((14 + 28) % 28 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("Grain v1 Init parameters must include an IV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        if (iv is null || iv.length != 8) {
            throw new java.lang.IllegalArgumentException("Grain v1 requires exactly 8 bytes of IV");
        }
        if (!(pdd5da44eVar.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Grain v1 Init parameters must include a key");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        this.fb6ffd2ee = new byte[p94919be6Var.getKey().length];
        this.f0d9d1f7a = new byte[p94919be6Var.getKey().length];
        this.f485519d5 = new int[5];
        this.f490fd8e7 = new int[5];
        this.fc68271a6 = new byte[2];
        java.lang.System.arraycopy(iv, 0, this.fb6ffd2ee, 0, iv.length);
        java.lang.System.arraycopy(p94919be6Var.getKey(), 0, this.f0d9d1f7a, 0, p94919be6Var.getKey().length);
        reset();
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((24 + 21) % 21 > 0) {
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
        if ((8 + 28) % 28 > 0) {
        }
        this.f6a992d55 = 2;
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

