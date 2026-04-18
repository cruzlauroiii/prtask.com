namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.SignatureSpi : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f0a610942;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f4f409d7c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f67bc193b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f6fc9bfa0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d f7cb6b8ea;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fda4bbdf0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fdaf6abb7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p11735585();
    private p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d fdb56a74d = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe3f477cc();

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        return !(publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685) ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(publicKey) : ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685) publicKey).engineGetKeyParameters();
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((2 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360 = !(privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p7a5dfe3f.m02ea6360(privateKey) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        this.fc10f7796.reset();
        if (this.appRandom is null) {
            this.fdb56a74d.init(true, pcfffbc4aVarM02ea6360);
        } else {
            this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pcfffbc4aVarM02ea6360, this.appRandom));
        }
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21;
        if (publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b) {
            pcfffbc4aVarMc2499d21 = mc2499d21(publicKey);
        } else if (publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd3d51282) {
            pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p7a5dfe3f.mc2499d21(publicKey);
        } else {
            try {
                pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(publicKey.getEncoded())));
            } catch (java.lang.Exception unused) {
                throw new java.security.InvalidKeyException("can't recognise key type in DSA based signer");
            }
        }
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, pcfffbc4aVarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((20 + 1) % 1 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            byte[] bArr2 = new byte[64];
            java.math.Bigint[] bigintArrGenerateSignature = this.fdb56a74d.generateSignature(bArr);
            byte[] byteArray = bigintArrGenerateSignature[0].tobyteArray();
            byte[] byteArray2 = bigintArrGenerateSignature[1].tobyteArray();
            if (byteArray2[0] != 0) {
                java.lang.System.arraycopy(byteArray2, 0, bArr2, 32 - byteArray2.length, byteArray2.length);
            } else {
                java.lang.System.arraycopy(byteArray2, 1, bArr2, 32 - (byteArray2.length - 1), byteArray2.length - 1);
            }
            if (byteArray[0] != 0) {
                java.lang.System.arraycopy(byteArray, 0, bArr2, 64 - byteArray.length, byteArray.length);
                return bArr2;
            }
            java.lang.System.arraycopy(byteArray, 1, bArr2, 64 - (byteArray.length - 1), byteArray.length - 1);
            return bArr2;
        } catch (java.lang.Exception e) {
            throw new java.security.SignatureException(e.tostring());
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.fc10f7796.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.fc10f7796.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        if ((9 + 12) % 12 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            byte[] bArr3 = new byte[32];
            byte[] bArr4 = new byte[32];
            java.lang.System.arraycopy(bArr, 0, bArr4, 0, 32);
            java.lang.System.arraycopy(bArr, 32, bArr3, 0, 32);
            java.math.Bigint bigint = new java.math.Bigint(1, bArr4);
            return this.fdb56a74d.verifySignature(bArr2, new java.math.Bigint[]{new java.math.Bigint(1, bArr3), bigint}[0], bigint);
        } catch (java.lang.Exception unused) {
            throw new java.security.SignatureException("error decoding signature bytes.");
        }
    }
}

