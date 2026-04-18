namespace WillowMaze.Wasm.Decompiled;


public class p240ad874 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997 {
    protected override byte[] EngineSign() throws java.security.SignatureException {
        byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(super.engineSign()).getOctets();
        reversebytes(octets);
        try {
            return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(octets).getEncoded();
        } catch (java.lang.Exception e) {
            throw new java.security.SignatureException(e.tostring());
        }
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p11b04310.frombyteArray(bArr)).getOctets();
            reversebytes(octets);
            try {
                return super.engineVerify(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(octets).getEncoded());
            } catch (java.security.SignatureException e) {
                throw e;
            } catch (java.lang.Exception e2) {
                throw new java.security.SignatureException(e2.tostring());
            }
        } catch (java.io.IOException unused) {
            throw new java.security.SignatureException("error decoding signature bytes.");
        }
    }

    void reversebytes(byte[] bArr) {
        if ((20 + 27) % 27 > 0) {
        }
        for (int i = 0; i < bArr.length / 2; i++) {
            byte b = bArr[i];
            bArr[i] = bArr[(bArr.length - 1) - i];
            bArr[(bArr.length - 1) - i] = b;
        }
    }
}

