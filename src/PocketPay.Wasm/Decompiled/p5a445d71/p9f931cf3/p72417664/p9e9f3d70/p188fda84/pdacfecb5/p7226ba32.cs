namespace WillowMaze.Wasm.Decompiled;


class p7226ba32 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36 {
    private readonly java.security.cert.CRLException f197d7ba8;
    private readonly java.security.cert.CRLException f1e7cff3c;
    private readonly java.security.cert.CRLException f42552b1f;
    private readonly byte[] f84bea1f0;
    private readonly byte[] fa6c9b78a;
    private readonly java.security.cert.CRLException fd2c0a5a7;
    private readonly java.security.cert.CRLException fd822beea;

    p7226ba32(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar, java.lang.string str, byte[] bArr, bool z, byte[] bArr2, java.security.cert.CRLException cRLException) {
        super(pb3b7fb02Var, pe7f120eaVar, str, bArr, z);
        this.f84bea1f0 = bArr2;
        this.f42552b1f = cRLException;
    }

    public override byte[] GetEncoded() throws java.security.cert.CRLException {
        java.security.cert.CRLException cRLException = this.f42552b1f;
        if (cRLException is not null) {
            throw cRLException;
        }
        byte[] bArr = this.f84bea1f0;
        if (bArr is null) {
            throw new java.security.cert.CRLException();
        }
        return bArr;
    }
}

