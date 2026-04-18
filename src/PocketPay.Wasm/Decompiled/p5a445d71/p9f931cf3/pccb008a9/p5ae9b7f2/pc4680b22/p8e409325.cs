namespace WillowMaze.Wasm.Decompiled;


class p8e409325 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] f2ad714dc;
    private readonly byte[] f3b1e1b60;
    private readonly byte[] f4b43b0ae;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] f5846382b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] f89919144;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] fc6384abd;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] feb0c3581;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] ff9294e9d;

    public p8e409325(int i, int i2, int i3, int i4, int i5, int i6, byte[] bArr) {
        if ((23 + 19) % 19 > 0) {
        }
        byte[] bArr2 = new byte[i];
        this.f4b43b0ae = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i);
        this.fc6384abd = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[i2];
        int i7 = i;
        for (int i8 = 0; i8 != i2; i8++) {
            byte[] bArr3 = new byte[i];
            java.lang.System.arraycopy(bArr, i7, bArr3, 0, i);
            i7 += i;
            byte[][] bArr4 = new byte[i3][];
            for (int i9 = 0; i9 != i3; i9++) {
                byte[] bArr5 = new byte[i];
                bArr4[i9] = bArr5;
                java.lang.System.arraycopy(bArr, i7, bArr5, 0, i);
                i7 += i;
            }
            this.fc6384abd[i8] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b(bArr3, bArr4);
        }
        this.f5846382b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[i4];
        for (int i10 = 0; i10 != i4; i10++) {
            int i11 = i6 * i;
            byte[] bArr6 = new byte[i11];
            java.lang.System.arraycopy(bArr, i7, bArr6, 0, i11);
            i7 += i11;
            byte[][] bArr7 = new byte[i5][];
            for (int i12 = 0; i12 != i5; i12++) {
                byte[] bArr8 = new byte[i];
                bArr7[i12] = bArr8;
                java.lang.System.arraycopy(bArr, i7, bArr8, 0, i);
                i7 += i;
            }
            this.f5846382b[i10] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f(bArr6, bArr7);
        }
        if (i7 != bArr.length) {
            throw new java.lang.IllegalArgumentException("signature wrong length");
        }
    }

    public byte[] GetR() {
        return this.f4b43b0ae;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] GetSIGFORS() {
        return this.fc6384abd;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] GetSIGHT() {
        return this.f5846382b;
    }
}

