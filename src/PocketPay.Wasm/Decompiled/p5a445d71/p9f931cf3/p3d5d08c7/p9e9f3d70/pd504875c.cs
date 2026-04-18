namespace WillowMaze.Wasm.Decompiled;


class pd504875c : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 {
    public static readonly int f0ce23e28 = 3;
    public static readonly int f1c4f5ad1 = 2;
    public static readonly int f1e5a6c2b = 3;
    public static readonly int f49a06e24 = 3;
    public static readonly int f4b9ef6f6 = 2;
    public static readonly int fb02b893c = 2;
    public static readonly int fc15524e7 = 1;
    public static readonly int fc5e641d8 = 1;
    public static readonly int feb9c10ac = 3;
    public static readonly int fee6a8ae5 = 1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2b3f26c8;
    private int f4b8afcfa;
    private int f4ef2ecc2;
    private int f5a2ba942;
    private int f7b774eff;
    private int f9e3669d1;
    private int fa72a6539;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd4e6cbad;
    private int fe31ee5e1;

    public pd504875c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((6 + 25) % 25 > 0) {
        }
        this.fc10f7796 = pe5cfc515Var;
        if (pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8) {
            this.f7b774eff = 16;
        } else {
            if (!(pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098) && !(pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pc267ca5e)) {
                throw new java.lang.IllegalArgumentException("Digest " + pe5cfc515Var.getAlgorithmName() + " unsupported");
            }
            this.f7b774eff = 20;
        }
        this.f9e3669d1 = 64;
    }

    private void M3b7770f7(byte[] bArr, int i, byte[] bArr2) {
        if ((21 + 17) % 17 > 0) {
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
        if ((10 + 1) % 1 > 0) {
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
        int i19 = 1;
        while (i19 <= i18) {
            int i20 = this.f7b774eff;
            byte[] bArr7 = new byte[i20];
            this.fc10f7796.update(bArr3, i5, i4);
            this.fc10f7796.update(bArr5, i5, length3);
            this.fc10f7796.doFinal(bArr7, i5);
            for (int i21 = i7; i21 != this.f40e092b2; i21++) {
                this.fc10f7796.update(bArr7, i5, i20);
                this.fc10f7796.doFinal(bArr7, i5);
            }
            for (int i22 = i5; i22 != i16; i22++) {
                bArr6[i19] = bArr7[i22 % i20];
            }
            int i23 = i5;
            while (true) {
                int i24 = this.f9e3669d1;
                if (i23 == length3 / i24) {
                    break;
                }
                m3b7770f7(bArr5, i24 * i23, bArr6);
                i23++;
            }
            if (i19 != i18) {
                i3 = 0;
                java.lang.System.arraycopy(bArr7, 0, bArr4, (i19 - 1) * this.f7b774eff, i20);
            } else {
                int i25 = i19 - 1;
                int i26 = this.f7b774eff;
                int i27 = i25 * i26;
                int i28 = i2 - (i25 * i26);
                i3 = 0;
                java.lang.System.arraycopy(bArr7, 0, bArr4, i27, i28);
            }
            i19++;
            i5 = i3;
            i7 = 1;
        }
        return bArr4;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        if ((24 + 8) % 8 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(3, i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((26 + 4) % 4 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(1, i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((6 + 22) % 22 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrMde3e38ba = mde3e38ba(1, i3);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrMde3e38ba, 0, i3), mde3e38ba(2, i4), 0, i4);
    }
}

