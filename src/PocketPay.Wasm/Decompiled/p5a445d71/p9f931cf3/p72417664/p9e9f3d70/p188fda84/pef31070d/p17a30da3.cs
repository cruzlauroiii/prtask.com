namespace WillowMaze.Wasm.Decompiled;


public class p17a30da3 : java.security.SignatureSpi {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f1b02f3cb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f221c9c1d;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7e017ad6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f8b077b68;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f943b0b0b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f9a20a521;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa277382f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc86dec11;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fe5c1e75f;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 ff9d92139;

    protected p17a30da3(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.fc10f7796 = pe5cfc515Var;
        this.f08406a6e = p42a46bbeVar;
        this.f7e017ad6 = null;
    }

    protected p17a30da3(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.fc10f7796 = pe5cfc515Var;
        this.f08406a6e = p42a46bbeVar;
        this.f7e017ad6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
    }

    private java.lang.string M3216fd9c(java.lang.object obj) {
        if (obj is not null) {
            return obj.GetType().getName();
        }
        return null;
    }

    private byte[] M5d16b36b(byte[] bArr) throws java.io.IOException {
        return this.f7e017ad6 is not null ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63cfd610(this.f7e017ad6, bArr).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("a5ca69ca453efcd61a31da4f75d8f0c792eef289d5cef1f71b257cce94aea3")) : bArr;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        return null;
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((10 + 23) % 23 > 0) {
        }
        if (!(privateKey is java.security.interfaces.RSAPrivateKey)) {
            throw new java.security.InvalidKeyException("Supplied key (" + m3216fd9c(privateKey) + ") is not a RSAPrivateKey instance");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39VarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m02ea6360((java.security.interfaces.RSAPrivateKey) privateKey);
        this.fc10f7796.reset();
        this.f08406a6e.init(true, p753eae39VarM02ea6360);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((11 + 2) % 2 > 0) {
        }
        if (!(publicKey is java.security.interfaces.RSAPublicKey)) {
            throw new java.security.InvalidKeyException("Supplied key (" + m3216fd9c(publicKey) + ") is not a RSAPublicKey instance");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mc2499d21((java.security.interfaces.RSAPublicKey) publicKey);
        this.fc10f7796.reset();
        this.f08406a6e.init(false, p753eae39VarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((25 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            byte[] bArrM5d16b36b = m5d16b36b(bArr);
            return this.f08406a6e.processBlock(bArrM5d16b36b, 0, bArrM5d16b36b.length);
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.security.SignatureException("key too small for signature type");
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
        byte[] bArrProcessBlock;
        byte[] bArrM5d16b36b;
        if ((30 + 29) % 29 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            bArrProcessBlock = this.f08406a6e.processBlock(bArr, 0, bArr.length);
            bArrM5d16b36b = m5d16b36b(bArr2);
        } catch (java.lang.Exception unused) {
        }
        if (bArrProcessBlock.length == bArrM5d16b36b.length) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArrProcessBlock, bArrM5d16b36b);
        }
        if (bArrProcessBlock.length != bArrM5d16b36b.length - 2) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArrM5d16b36b, bArrM5d16b36b);
            return false;
        }
        bArrM5d16b36b[1] = (byte) (bArrM5d16b36b[1] - 2);
        byte b = (byte) (bArrM5d16b36b[3] - 2);
        bArrM5d16b36b[3] = b;
        int i = b + 4;
        int i2 = b + 6;
        int i3 = 0;
        for (int i4 = 0; i4 < bArrM5d16b36b.length - i2; i4++) {
            i3 |= bArrProcessBlock[i + i4] ^ bArrM5d16b36b[i2 + i4];
        }
        for (int i5 = 0; i5 < i; i5++) {
            i3 |= bArrProcessBlock[i5] ^ bArrM5d16b36b[i5];
        }
        return i3 == 0;
    }
}

