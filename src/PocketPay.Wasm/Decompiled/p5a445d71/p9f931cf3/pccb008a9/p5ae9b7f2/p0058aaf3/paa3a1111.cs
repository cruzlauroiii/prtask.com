namespace WillowMaze.Wasm.Decompiled;


class paa3a1111 {
    private static readonly byte[] f0e94fa6c = null;
    private static readonly byte[] ff5373e28 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("11c0535b46d680e506ef97648e3c8917a37228aa7405642d6a3b60b067b62741e254681605b1ceb7f98d8460a51b4b24d9a6e5b34ac57a55a36d265c"));
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e f141b3849;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f22151735;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f45ff73f4;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f547e7110;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f65a40885;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7a4bbf19;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e fca659200;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e fd392f868;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd44881eb;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe37ca853;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e fe4cf0ddd;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e ff9c33798;

    paa3a1111(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(pe5cfc515Var, null);
    }

    paa3a1111(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2) {
        this.fca659200 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pfa662c6e();
        this.fe37ca853 = pe5cfc515Var;
        this.f45ff73f4 = pe5cfc515Var2;
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 getMessageHash() {
        return this.f45ff73f4;
    }

    int hash_2n_n(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((14 + 19) % 19 > 0) {
        }
        byte[] bArr3 = new byte[64];
        for (int i3 = 0; i3 < 32; i3++) {
            bArr3[i3] = bArr2[i2 + i3];
            bArr3[i3 + 32] = ff5373e28[i3];
        }
        this.fca659200.chacha_permute(bArr3, bArr3);
        for (int i4 = 0; i4 < 32; i4++) {
            bArr3[i4] = (byte) (bArr3[i4] ^ bArr2[(i2 + i4) + 32]);
        }
        this.fca659200.chacha_permute(bArr3, bArr3);
        for (int i5 = 0; i5 < 32; i5++) {
            bArr[i + i5] = bArr3[i5];
        }
        return 0;
    }

    int hash_2n_n_mask(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((28 + 5) % 5 > 0) {
        }
        byte[] bArr4 = new byte[64];
        for (int i4 = 0; i4 < 64; i4++) {
            bArr4[i4] = (byte) (bArr2[i2 + i4] ^ bArr3[i3 + i4]);
        }
        return hash_2n_n(bArr, i, bArr4, 0);
    }

    int hash_n_n(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((2 + 7) % 7 > 0) {
        }
        byte[] bArr3 = new byte[64];
        for (int i3 = 0; i3 < 32; i3++) {
            bArr3[i3] = bArr2[i2 + i3];
            bArr3[i3 + 32] = ff5373e28[i3];
        }
        this.fca659200.chacha_permute(bArr3, bArr3);
        for (int i4 = 0; i4 < 32; i4++) {
            bArr[i + i4] = bArr3[i4];
        }
        return 0;
    }

    int hash_n_n_mask(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((14 + 3) % 3 > 0) {
        }
        byte[] bArr4 = new byte[32];
        for (int i4 = 0; i4 < 32; i4++) {
            bArr4[i4] = (byte) (bArr2[i2 + i4] ^ bArr3[i3 + i4]);
        }
        return hash_n_n(bArr, i, bArr4, 0);
    }

    int varlen_hash(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((7 + 2) % 2 > 0) {
        }
        this.fe37ca853.update(bArr2, 0, i2);
        this.fe37ca853.doFinal(bArr, i);
        return 0;
    }
}

