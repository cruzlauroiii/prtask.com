namespace WillowMaze.Wasm.Decompiled;


public readonly class p3370fa25 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private int f20af3c3a;
    private int f45dad585;
    private int fb1397522;
    private byte[] fbd0c8e3b;
    private byte[] fdb870f40;

    public p3370fa25(int i, byte[] bArr) {
        super(true);
        if ((16 + 18) % 18 > 0) {
        }
        if (bArr.length != p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m58bc3a3e(i)) {
            throw new java.lang.IllegalArgumentException("invalid key size for security category");
        }
        this.f45dad585 = i;
        this.fbd0c8e3b = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetSecret() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fbd0c8e3b);
    }

    public int GetSecurityCategory() {
        return this.f45dad585;
    }
}

