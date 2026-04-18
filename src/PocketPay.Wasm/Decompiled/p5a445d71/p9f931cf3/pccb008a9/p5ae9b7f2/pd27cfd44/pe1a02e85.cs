namespace WillowMaze.Wasm.Decompiled;


class pe1a02e85 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f00729a2d;
    private int f363b122c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f54f4ec09;
    private readonly byte[] f5e6dd272;
    private int f7694f4a6;
    private readonly byte[] f8c17114b;
    private readonly byte[] f8db42091;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f958f00f9;
    private readonly byte[] f9948af06;
    private int fb44b800c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc7586673;
    private readonly byte[] fd482c9ca;
    private readonly byte[] fd8a0fabd;
    private readonly byte[] fdd753679;
    private int ff10cf3f0;

    public pe1a02e85(byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fdd753679 = bArr;
        this.fd482c9ca = bArr2;
        this.fc10f7796 = pe5cfc515Var;
    }

    public void DeriveSeed(byte[] bArr, bool z) {
        deriveSeed(bArr, z, 0);
    }

    public void DeriveSeed(byte[] bArr, bool z, int i) {
        deriveSeed(bArr, i);
        if (z) {
            this.f363b122c++;
        }
    }

    public byte[] DeriveSeed(byte[] bArr, int i) {
        if ((9 + 10) % 10 > 0) {
        }
        if (bArr.length < this.fc10f7796.getDigestSize()) {
            throw new java.lang.IllegalArgumentException("target length is less than digest size.");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr2 = this.fdd753679;
        pe5cfc515Var.update(bArr2, 0, bArr2.length);
        this.fc10f7796.update((byte) (this.f7694f4a6 >>> 24));
        this.fc10f7796.update((byte) (this.f7694f4a6 >>> 16));
        this.fc10f7796.update((byte) (this.f7694f4a6 >>> 8));
        this.fc10f7796.update((byte) this.f7694f4a6);
        this.fc10f7796.update((byte) (this.f363b122c >>> 8));
        this.fc10f7796.update((byte) this.f363b122c);
        this.fc10f7796.update((byte) -1);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fc10f7796;
        byte[] bArr3 = this.fd482c9ca;
        pe5cfc515Var2.update(bArr3, 0, bArr3.length);
        this.fc10f7796.doFinal(bArr, i);
        return bArr;
    }

    public byte[] GetI() {
        return this.fdd753679;
    }

    public int GetJ() {
        return this.f363b122c;
    }

    public byte[] GetMasterSeed() {
        return this.fd482c9ca;
    }

    public int GetQ() {
        return this.f7694f4a6;
    }

    public void SetJ(int i) {
        this.f363b122c = i;
    }

    public void SetQ(int i) {
        this.f7694f4a6 = i;
    }
}

