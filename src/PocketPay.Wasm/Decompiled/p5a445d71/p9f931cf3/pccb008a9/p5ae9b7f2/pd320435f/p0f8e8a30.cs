namespace WillowMaze.Wasm.Decompiled;


public readonly class p0f8e8a30 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private int f45dad585;
    private byte[] f7626753a;
    private byte[] f82b7c471;
    private byte[] fa4d91d72;
    private byte[] fa6264501;
    private byte[] fc36853ea;
    private int fc8c4dc3b;
    private int ff2c75da1;

    public p0f8e8a30(int i, byte[] bArr) {
        super(false);
        if ((25 + 32) % 32 > 0) {
        }
        if (bArr.length != p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m021ac29e(i)) {
            throw new java.lang.IllegalArgumentException("invalid key size for security category");
        }
        this.f45dad585 = i;
        this.fc36853ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetPublicData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fc36853ea);
    }

    public int GetSecurityCategory() {
        return this.f45dad585;
    }
}

