namespace WillowMaze.Wasm.Decompiled;


class p510a4454 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a {
    private readonly byte[] f0d880361;
    private readonly java.security.cert.CertificateEncodingException f12b27aa7;
    private readonly java.security.cert.CertificateEncodingException f14ce9efc;
    private readonly byte[] f1bcfb1c0;
    private readonly java.security.cert.CertificateEncodingException f42552b1f;
    private readonly byte[] f82841fae;
    private readonly byte[] f84bea1f0;
    private readonly java.security.cert.CertificateEncodingException ffbace2e0;

    p510a4454(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 p44f86c11Var, bool[] zArr, java.lang.string str, byte[] bArr, byte[] bArr2, java.security.cert.CertificateEncodingException certificateEncodingException) {
        super(pb3b7fb02Var, peb0f48a1Var, p44f86c11Var, zArr, str, bArr);
        this.f84bea1f0 = bArr2;
        this.f42552b1f = certificateEncodingException;
    }

    public override byte[] GetEncoded() throws java.security.cert.CertificateEncodingException {
        java.security.cert.CertificateEncodingException certificateEncodingException = this.f42552b1f;
        if (certificateEncodingException is not null) {
            throw certificateEncodingException;
        }
        byte[] bArr = this.f84bea1f0;
        if (bArr is null) {
            throw new java.security.cert.CertificateEncodingException();
        }
        return bArr;
    }
}

