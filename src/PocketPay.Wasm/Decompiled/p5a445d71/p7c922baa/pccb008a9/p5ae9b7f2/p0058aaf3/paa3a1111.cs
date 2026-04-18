namespace WillowMaze.Wasm.Decompiled;


class paa3a1111 {
    private static readonly byte[] f18bf0eb1 = null;
    private static readonly byte[] f6a52a3a0 = null;
    private static readonly byte[] f9c69871c = null;
    private static readonly byte[] ff5373e28 = jMhqZtQxKfgZWFEO(blGjfDQJPhjQGLJV("b7f90b7bf668ea965b02dcd51acaf07668e51f19a21a3177e113a954af9c29ca843e4d2e7d789734b0c49025170cd0965ec2430428680ea7664e9c85"));
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e f21a3d8f0;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f45ff73f4;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e f6b0261af;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f8420d28c;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e f85ecb909;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f92b1c555;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fa62a39bd;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e fca659200;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fd54933f1;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fe37ca853;

    paa3a1111(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(pe5cfc515Var, null);
    }

    paa3a1111(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var2) {
        this.fca659200 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e();
        this.fe37ca853 = pe5cfc515Var;
        this.f45ff73f4 = pe5cfc515Var2;
    }

    public static void CSNYLWxXPUsHqldE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e pfa662c6eVar, byte[] bArr, byte[] bArr2) {
        pfa662c6eVar.chacha_permute(bArr, bArr2);
    }

    public static void KJfXzlwxYXFplYuS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e pfa662c6eVar, byte[] bArr, byte[] bArr2) {
        pfa662c6eVar.chacha_permute(bArr, bArr2);
    }

    public static void BbndiGsHXIJYegoV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e pfa662c6eVar, byte[] bArr, byte[] bArr2) {
        pfa662c6eVar.chacha_permute(bArr, bArr2);
    }

    public static java.lang.string BlGjfDQJPhjQGLJV(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int CTaBoRSyfBfubwWF(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static byte[] JMhqZtQxKfgZWFEO(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static int MBZqGKXeYxMAYFDP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return paa3a1111Var.hash_n_n(bArr, i, bArr2, i2);
    }

    public static void VZVfLqwIPyHBGkqB(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int XfnRBDgpdwbjhYjN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return paa3a1111Var.hash_2n_n(bArr, i, bArr2, i2);
    }

    p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 getMessageHash() {
        return this.f45ff73f4;
    }

    int hash_2n_n(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((2 + 16) % 16 > 0) {
        }
        byte[] bArr3 = new byte[64];
        for (int i3 = 0; i3 < 32; i3++) {
            bArr3[i3] = bArr2[i2 + i3];
            bArr3[i3 + 32] = ff5373e28[i3];
        }
        bbndiGsHXIJYegoV(this.fca659200, bArr3, bArr3);
        for (int i4 = 0; i4 < 32; i4++) {
            bArr3[i4] = (byte) (bArr3[i4] ^ bArr2[(i2 + i4) + 32]);
        }
        CSNYLWxXPUsHqldE(this.fca659200, bArr3, bArr3);
        for (int i5 = 0; i5 < 32; i5++) {
            bArr[i + i5] = bArr3[i5];
        }
        return 0;
    }

    int hash_2n_n_mask(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((6 + 4) % 4 > 0) {
        }
        byte[] bArr4 = new byte[64];
        for (int i4 = 0; i4 < 64; i4++) {
            bArr4[i4] = (byte) (bArr2[i2 + i4] ^ bArr3[i3 + i4]);
        }
        return xfnRBDgpdwbjhYjN(this, bArr, i, bArr4, 0);
    }

    int hash_n_n(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((11 + 9) % 9 > 0) {
        }
        byte[] bArr3 = new byte[64];
        for (int i3 = 0; i3 < 32; i3++) {
            bArr3[i3] = bArr2[i2 + i3];
            bArr3[i3 + 32] = ff5373e28[i3];
        }
        KJfXzlwxYXFplYuS(this.fca659200, bArr3, bArr3);
        for (int i4 = 0; i4 < 32; i4++) {
            bArr[i + i4] = bArr3[i4];
        }
        return 0;
    }

    int hash_n_n_mask(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((13 + 8) % 8 > 0) {
        }
        byte[] bArr4 = new byte[32];
        for (int i4 = 0; i4 < 32; i4++) {
            bArr4[i4] = (byte) (bArr2[i2 + i4] ^ bArr3[i3 + i4]);
        }
        return mBZqGKXeYxMAYFDP(this, bArr, i, bArr4, 0);
    }

    int varlen_hash(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((4 + 27) % 27 > 0) {
        }
        vZVfLqwIPyHBGkqB(this.fe37ca853, bArr2, 0, i2);
        cTaBoRSyfBfubwWF(this.fe37ca853, bArr, i);
        return 0;
    }
}

