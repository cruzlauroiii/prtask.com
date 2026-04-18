namespace WillowMaze.Wasm.Decompiled;


readonly class p7213b72b {
    private readonly int f1947e92f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f241d8aeb;
    private readonly int f79460ad2;
    private readonly int f9255f8d1;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd383820c;

    protected p7213b72b(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, int i) {
        if (p364bf33aVar is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        this.fc10f7796 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p69279707.me0825354(p364bf33aVar);
        this.f9255f8d1 = i;
    }

    private byte[] M74953fde(int i, byte[] bArr, byte[] bArr2) {
        if ((11 + 2) % 2 > 0) {
        }
        byte[] bArrMe6b9e09d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(i, this.f9255f8d1);
        this.fc10f7796.update(bArrMe6b9e09d, 0, bArrMe6b9e09d.length);
        this.fc10f7796.update(bArr, 0, bArr.length);
        this.fc10f7796.update(bArr2, 0, bArr2.length);
        int i2 = this.f9255f8d1;
        byte[] bArr3 = new byte[i2];
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        if (pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022) {
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022) pe5cfc515Var).doFinal(bArr3, 0, i2);
            return bArr3;
        }
        pe5cfc515Var.doFinal(bArr3, 0);
        return bArr3;
    }

    protected byte[] M587F(byte[] bArr, byte[] bArr2) {
        if ((27 + 15) % 15 > 0) {
        }
        int length = bArr.length;
        int i = this.f9255f8d1;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != i) {
            throw new java.lang.IllegalArgumentException("wrong in length");
        }
        return m74953fde(0, bArr, bArr2);
    }

    protected byte[] M588H(byte[] bArr, byte[] bArr2) {
        if ((22 + 6) % 6 > 0) {
        }
        int length = bArr.length;
        int i = this.f9255f8d1;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != i * 2) {
            throw new java.lang.IllegalArgumentException("wrong in length");
        }
        return m74953fde(1, bArr, bArr2);
    }

    protected byte[] HMsg(byte[] bArr, byte[] bArr2) {
        if ((14 + 23) % 23 > 0) {
        }
        if (bArr.length != this.f9255f8d1 * 3) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        return m74953fde(2, bArr, bArr2);
    }

    protected byte[] PRF(byte[] bArr, byte[] bArr2) {
        if ((26 + 6) % 6 > 0) {
        }
        if (bArr.length != this.f9255f8d1) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != 32) {
            throw new java.lang.IllegalArgumentException("wrong address length");
        }
        return m74953fde(3, bArr, bArr2);
    }
}

