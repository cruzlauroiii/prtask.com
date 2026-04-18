namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.SignatureSpi {
    private static readonly byte[] f585c02fd = null;
    private static readonly byte[] f6872d72b = null;
    private static readonly byte[] f6c67955e = null;
    private static readonly byte[] fa5e896eb = new byte[0];
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b f5c08a622;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b f80c9f1f0;
    private readonly java.lang.string f87059776;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fba38d884;
    private readonly java.lang.string fc5728259;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fd6663514;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fdb56a74d;
    private readonly java.lang.string fed469618;

    p26a1a997(java.lang.string str) {
        this.fed469618 = str;
    }

    private static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M5e287205(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408) key).engineGetKeyParameters();
        }
        throw new java.security.InvalidKeyException("cannot identify EdDSA public key");
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b Mb423450a(java.lang.string str) throws java.security.InvalidKeyException {
        if ((18 + 12) % 12 > 0) {
        }
        java.lang.string str2 = this.fed469618;
        if (str2 is null || str.Equals(str2)) {
            return !str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("1a071b98dec77a8e3761f10444eaca0560de9de39b121a5cab33650039e7e3a47a")) ? new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82() : new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116(fa5e896eb);
        }
        throw new java.security.InvalidKeyException("inappropriate key for " + this.fed469618);
    }

    private static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mbbd91822(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9) key).engineGetKeyParameters();
        }
        throw new java.security.InvalidKeyException("cannot identify EdDSA private key");
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) throws java.security.InvalidParameterException {
        throw new java.lang.UnsupportedOperationException("engineGetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        java.lang.string strDecryptstring;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMbbd91822 = mbbd91822(privateKey);
        if (pcfffbc4aVarMbbd91822 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("2ef3c5cea378d4fed2b42d464d8baf9fd15f988f797d24b9b863caeec4548092222a63");
        } else {
            if (!(pcfffbc4aVarMbbd91822 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e)) {
                throw new java.lang.IllegalStateException("unsupported private key type");
            }
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("2b1da0194c8a985c79764686fc462519b9f5c311cd61b0c9db360e8114f926940e");
        }
        this.fdb56a74d = mb423450a(strDecryptstring);
        this.fdb56a74d.init(true, pcfffbc4aVarMbbd91822);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        java.lang.string strDecryptstring;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM5e287205 = m5e287205(publicKey);
        if (pcfffbc4aVarM5e287205 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("b0c0477fc637da9f1df5271bc8c906a11af8689c108c5120b7483eb9ddc56ba2240a2b");
        } else {
            if (!(pcfffbc4aVarM5e287205 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed)) {
                throw new java.lang.IllegalStateException("unsupported public key type");
            }
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("de6b0ebe9c6b7eba8a10148f2c8bbf9bfc43587977f8a7ebd2c6b36956a58a686c");
        }
        this.fdb56a74d = mb423450a(strDecryptstring);
        this.fdb56a74d.init(false, pcfffbc4aVarM5e287205);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) throws java.security.InvalidParameterException {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        try {
            return this.fdb56a74d.generateSignature();
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f e) {
            throw new java.security.SignatureException(e.getMessage());
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.fdb56a74d.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.fdb56a74d.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        return this.fdb56a74d.verifySignature(bArr);
    }
}

