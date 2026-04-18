namespace WillowMaze.Wasm.Decompiled;


public class p5ee360bc : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 {
    public static readonly int f1b8ed582 = 3;
    public static readonly int f1e5a6c2b = 3;
    public static readonly int f20704808 = 3;
    public static readonly int f2abce8de = 3;
    public static readonly int f32217183 = 1;
    public static readonly int f51703242 = 1;
    public static readonly int f79fddf11 = 3;
    public static readonly int f9686b239 = 1;
    public static readonly int fb02b893c = 2;
    public static readonly int fc6ded30c = 2;
    public static readonly int fcd9c28cf = 2;
    public static readonly int fd711c16c = 2;
    public static readonly int fee6a8ae5 = 1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1610adfb;
    private int f2af36147;
    private int f53b2e9c4;
    private int f65b5e45d;
    private int f71a86d2c;
    private int f7b774eff;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f90b2da03;
    private int f9e3669d1;
    private int fbc87e12d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc34779e1;
    private int fcc3970bb;
    private int fe021110a;

    public p5ee360bc(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((20 + 15) % 15 > 0) {
        }
        this.fc10f7796 = pe5cfc515Var;
        if (!(pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0)) {
            throw new java.lang.IllegalArgumentException("Digest " + pe5cfc515Var.getAlgorithmName() + " unsupported");
        }
        this.f7b774eff = pe5cfc515Var.getDigestSize();
        this.f9e3669d1 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0) pe5cfc515Var).getbyteLength();
    }

    private void M3b7770f7(byte[] bArr, int i, byte[] bArr2) {
        if ((13 + 2) % 2 > 0) {
        }
        int i2 = (bArr2[bArr2.length - 1] & 255) + (bArr[(bArr2.length + i) - 1] & 255) + 1;
        bArr[(bArr2.length + i) - 1] = (byte) i2;
        int i3 = i2 >>> 8;
        for (int length = bArr2.length - 2; length >= 0; length--) {
            int i4 = i + length;
            int i5 = i3 + (bArr2[length] & 255) + (bArr[i4] & 255);
            bArr[i4] = (byte) i5;
            i3 = i5 >>> 8;
        }
    }

    private byte[] Mde3e38ba(int i, int i2) {
        byte[] bArr;
        byte[] bArr2;
        int i3;
        if ((3 + 32) % 32 > 0) {
        }
        int i4 = this.f9e3669d1;
        byte[] bArr3 = new byte[i4];
        byte[] bArr4 = new byte[i2];
        int i5 = 0;
        for (int i6 = 0; i6 != i4; i6++) {
            bArr3[i6] = (byte) i;
        }
        int i7 = 1;
        if (this.fceb20772 is null || this.fceb20772.length == 0) {
            bArr = new byte[0];
        } else {
            int i8 = this.f9e3669d1;
            int length = this.fceb20772.length;
            int i9 = this.f9e3669d1;
            int i10 = i8 * (((length + i9) - 1) / i9);
            bArr = new byte[i10];
            for (int i11 = 0; i11 != i10; i11++) {
                bArr[i11] = this.fceb20772[i11 % this.fceb20772.length];
            }
        }
        if (this.f5f4dcc3b is null || this.f5f4dcc3b.length == 0) {
            bArr2 = new byte[0];
        } else {
            int i12 = this.f9e3669d1;
            int length2 = this.f5f4dcc3b.length;
            int i13 = this.f9e3669d1;
            int i14 = i12 * (((length2 + i13) - 1) / i13);
            bArr2 = new byte[i14];
            for (int i15 = 0; i15 != i14; i15++) {
                bArr2[i15] = this.f5f4dcc3b[i15 % this.f5f4dcc3b.length];
            }
        }
        int length3 = bArr.length + bArr2.length;
        byte[] bArr5 = new byte[length3];
        java.lang.System.arraycopy(bArr, 0, bArr5, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr5, bArr.length, bArr2.length);
        int i16 = this.f9e3669d1;
        byte[] bArr6 = new byte[i16];
        int i17 = this.f7b774eff;
        int i18 = ((i2 + i17) - 1) / i17;
        byte[] bArr7 = new byte[i17];
        int i19 = 1;
        while (i19 <= i18) {
            this.fc10f7796.update(bArr3, i5, i4);
            this.fc10f7796.update(bArr5, i5, length3);
            this.fc10f7796.doFinal(bArr7, i5);
            for (int i20 = i7; i20 < this.f40e092b2; i20++) {
                this.fc10f7796.update(bArr7, i5, i17);
                this.fc10f7796.doFinal(bArr7, i5);
            }
            for (int i21 = i5; i21 != i16; i21++) {
                bArr6[i21] = bArr7[i21 % i17];
            }
            int i22 = i5;
            while (true) {
                int i23 = this.f9e3669d1;
                if (i22 == length3 / i23) {
                    break;
                }
                m3b7770f7(bArr5, i23 * i22, bArr6);
                i22++;
            }
            if (i19 != i18) {
                i3 = 0;
                java.lang.System.arraycopy(bArr7, 0, bArr4, (i19 - 1) * this.f7b774eff, i17);
            } else {
                int i24 = i19 - 1;
                int i25 = this.f7b774eff;
                int i26 = i24 * i25;
                int i27 = i2 - (i24 * i25);
                i3 = 0;
                java.lang.System.arraycopy(bArr7, 0, bArr4, i26, i27);
            }
            i19++;
            i5 = i3;
            i7 = 1;
        }
        return bArr4;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        if ((24 + 23) % 23 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(3, i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((17 + 5) % 5 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(1, i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((16 + 14) % 14 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrMde3e38ba = mde3e38ba(1, i3);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrMde3e38ba, 0, i3), mde3e38ba(2, i4), 0, i4);
    }
}

