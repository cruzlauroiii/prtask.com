namespace WillowMaze.Wasm.Decompiled;


public class p31aaa8d2 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private java.security.AlgorithmParameters f20c904fb;
    private java.security.spec.AlgorithmParameterSpec f303fde02;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f369f65f8;
    private java.security.AlgorithmParameters f57af1c01;
    private java.security.spec.AlgorithmParameterSpec fa731a5a7;
    private java.security.spec.AlgorithmParameterSpec fc965120b;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46 fea03596c;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46 ff55b8df9 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46();
    private java.security.AlgorithmParameters ffb8ea07f;

    public p31aaa8d2(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.f08406a6e = p42a46bbeVar;
    }

    private void M8872f202(javax.crypto.spec.OAEPParameterSpec oAEPParameterSpec) throws javax.crypto.NoSuchPaddingException {
        if ((14 + 1) % 1 > 0) {
        }
        java.security.spec.MGF1ParameterSpec mGF1ParameterSpec = (java.security.spec.MGF1ParameterSpec) oAEPParameterSpec.getMGFParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(mGF1ParameterSpec.getDigestAlgorithm());
        if (pe5cfc515VarMe0825354 is null) {
            throw new javax.crypto.NoSuchPaddingException("no match on OAEP constructor for digest algorithm: " + mGF1ParameterSpec.getDigestAlgorithm());
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d(), pe5cfc515VarMe0825354, ((javax.crypto.spec.PSource$PSpecified) oAEPParameterSpec.getPSource()).getValue());
        this.f303fde02 = oAEPParameterSpec;
    }

    private byte[] Me09f6787() throws javax.crypto.BadPaddingException {
        if ((32 + 19) % 19 > 0) {
        }
        try {
            try {
                byte[] bArrProcessBlock = this.f08406a6e.processBlock(this.ff55b8df9.getBuf(), 0, this.ff55b8df9.Count);
                this.ff55b8df9.erase();
                return bArrProcessBlock;
            } catch (java.lang.ArrayIndexOutOfBoundsException e) {
                throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to decrypt block", e);
            } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e2) {
                throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to decrypt block", e2);
            }
        } catch (java.lang.Exception th) {
            this.ff55b8df9.erase();
            throw th;
        }
    }

    protected override int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        if ((25 + 15) % 15 > 0) {
        }
        if (engineGetOutputSize(i2) + i3 > bArr2.length) {
            throw new javax.crypto.shortBufferException("output buffer too short for input.");
        }
        if (bArr is not null) {
            this.ff55b8df9.write(bArr, i, i2);
        }
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for ElGamal block");
            }
        } else if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for ElGamal block");
        }
        byte[] bArrMe09f6787 = me09f6787();
        for (int i4 = 0; i4 != bArrMe09f6787.length; i4++) {
            bArr2[i3 + i4] = bArrMe09f6787[i4];
        }
        return bArrMe09f6787.length;
    }

    protected override byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        if (bArr is not null) {
            this.ff55b8df9.write(bArr, i, i2);
        }
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for ElGamal block");
            }
        } else if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for ElGamal block");
        }
        return me09f6787();
    }

    protected override int EngineGetBlockSize() {
        return this.f08406a6e.getInputBlockSize();
    }

    protected override int EngineGetKeySize(java.security.Key key) {
        java.math.Bigint p;
        if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p65f7e056) {
            p = ((p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p65f7e056) key).getParameters().getP();
        } else {
            if (!(key is javax.crypto.interfaces.DHKey)) {
                throw new java.lang.IllegalArgumentException("not an ElGamal key!");
            }
            p = ((javax.crypto.interfaces.DHKey) key).getParams().getP();
        }
        return p.bitLength();
    }

    protected override int EngineGetOutputSize(int i) {
        return this.f08406a6e.getOutputBlockSize();
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        if ((11 + 6) % 6 > 0) {
        }
        if (this.f20c904fb is null && this.f303fde02 is not null) {
            try {
                java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("OAEP");
                this.f20c904fb = algorithmParametersCreateParametersInstance;
                algorithmParametersCreateParametersInstance.init(this.f303fde02);
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
            }
        }
        return this.f20c904fb;
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("can't handle parameters in ElGamal");
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((10 + 20) % 20 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.security.InvalidKeyException("Eeeek! " + e.tostring(), e);
        }
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMc2499d21;
        if ((9 + 9) % 9 > 0) {
        }
        if (key is javax.crypto.interfaces.DHPublicKey) {
            pc9ef6b45VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pc89bbf9f.mc2499d21((java.security.PublicKey) key);
        } else {
            if (!(key is javax.crypto.interfaces.DHPrivateKey)) {
                throw new java.security.InvalidKeyException("unknown key type passed to ElGamal");
            }
            pc9ef6b45VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pc89bbf9f.m02ea6360((java.security.PrivateKey) key);
        }
        if (algorithmParameterSpec is javax.crypto.spec.OAEPParameterSpec) {
            javax.crypto.spec.OAEPParameterSpec oAEPParameterSpec = (javax.crypto.spec.OAEPParameterSpec) algorithmParameterSpec;
            this.f303fde02 = algorithmParameterSpec;
            if (!oAEPParameterSpec.getMGFAlgorithm().equalsIgnoreCase(com.decryptstringmanager.Decryptstring.decryptstring("13396577c70ab4bb2a9725b6f08a533df234af0bbaee8bd3d50be709b63d67c4")) && !oAEPParameterSpec.getMGFAlgorithm().Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c.getId())) {
                throw new java.security.InvalidAlgorithmParameterException("unknown mask generation function specified");
            }
            if (!(oAEPParameterSpec.getMGFParameters() instanceof java.security.spec.MGF1ParameterSpec)) {
                throw new java.security.InvalidAlgorithmParameterException("unkown MGF parameters");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(oAEPParameterSpec.getDigestAlgorithm());
            if (pe5cfc515VarMe0825354 is null) {
                throw new java.security.InvalidAlgorithmParameterException("no match on digest algorithm: " + oAEPParameterSpec.getDigestAlgorithm());
            }
            java.security.spec.MGF1ParameterSpec mGF1ParameterSpec = (java.security.spec.MGF1ParameterSpec) oAEPParameterSpec.getMGFParameters();
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe08253542 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(mGF1ParameterSpec.getDigestAlgorithm());
            if (pe5cfc515VarMe08253542 is null) {
                throw new java.security.InvalidAlgorithmParameterException("no match on MGF digest algorithm: " + mGF1ParameterSpec.getDigestAlgorithm());
            }
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d(), pe5cfc515VarMe0825354, pe5cfc515VarMe08253542, ((javax.crypto.spec.PSource$PSpecified) oAEPParameterSpec.getPSource()).getValue());
        } else if (algorithmParameterSpec is not null) {
            throw new java.security.InvalidAlgorithmParameterException("unknown parameter type.");
        }
        if (secureRandom is not null) {
            pc9ef6b45VarMc2499d21 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarMc2499d21, secureRandom);
        }
        if (i != 1) {
            if (i != 2) {
                if (i != 3) {
                    if (i != 4) {
                        throw new java.security.InvalidParameterException("unknown opmode " + i + " passed to ElGamal");
                    }
                }
            }
            this.f08406a6e.init(false, pc9ef6b45VarMc2499d21);
            return;
        }
        this.f08406a6e.init(true, pc9ef6b45VarMc2499d21);
    }

    protected override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((23 + 30) % 30 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (!strMb8a8247c.Equals(com.decryptstringmanager.Decryptstring.decryptstring("9df9bd4e9abc7e7301c0a628f32fe49215ba9944faa1c6438d4e024f5e794874")) && !strMb8a8247c.Equals("ECB")) {
            throw new java.security.NoSuchAlgorithmException("can't support mode " + str);
        }
    }

    protected override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if ((3 + 6) % 6 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals("NOPADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d();
            return;
        }
        if (strMb8a8247c.Equals("PKCS1PADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pb4e47103(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d());
            return;
        }
        if (strMb8a8247c.Equals("ISO9796-1PADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.p2ddea612(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p599eb12d());
            return;
        }
        if (strMb8a8247c.Equals("OAEPPADDING")) {
            m8872f202(javax.crypto.spec.OAEPParameterSpec.DEFAULT);
            return;
        }
        bool zEquals = strMb8a8247c.Equals("OAEPWITHMD5ANDMGF1PADDING");
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("5c65538db1b72bb20f80fc9d57148ce5f60d0020e6e99863580d04cae867e4cf");
        if (zEquals) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec("MD5", strDecryptstring, new java.security.spec.MGF1ParameterSpec("MD5"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA1ANDMGF1PADDING")) {
            m8872f202(javax.crypto.spec.OAEPParameterSpec.DEFAULT);
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA224ANDMGF1PADDING")) {
            java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("89c4ce67b94e6650a4244ad34256eb1e392ad831859a4b16deaf412c4bff842fb54e60");
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(strDecryptstring2, strDecryptstring, new java.security.spec.MGF1ParameterSpec(strDecryptstring2), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA256ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("8391e74c0010db626e46ec8993d21e994a7a782e53198779e455efce1b50feeaf81f53"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA256, javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA384ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("b45bbfc6de51b505862d4b4b43638b89529188e05796517242c6da1fae48a3789fc974"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA384, javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA512ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("29293f45abf64b5f4eaae1d58b02d167f108363863e98db76a7a42136966c132d8728b"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA512, javax.crypto.spec.PSource$PSpecified.DEFAULT));
        } else {
            if (strMb8a8247c.Equals("OAEPWITHSHA3-224ANDMGF1PADDING")) {
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-224", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-224"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
                return;
            }
            if (strMb8a8247c.Equals("OAEPWITHSHA3-256ANDMGF1PADDING")) {
                java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("789fb2fae84e63b61116ec5527a691d9ca01fbc92aa8ea15079bd48b64a0107524a83ce8");
                m8872f202(new javax.crypto.spec.OAEPParameterSpec(strDecryptstring3, strDecryptstring, new java.security.spec.MGF1ParameterSpec(strDecryptstring3), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            } else if (strMb8a8247c.Equals("OAEPWITHSHA3-384ANDMGF1PADDING")) {
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-384", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-384"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            } else {
                if (!strMb8a8247c.Equals("OAEPWITHSHA3-512ANDMGF1PADDING")) {
                    throw new javax.crypto.NoSuchPaddingException(str + " unavailable with ElGamal.");
                }
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-512", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-512"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            }
        }
    }

    protected override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        this.ff55b8df9.write(bArr, i, i2);
        return 0;
    }

    protected override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        this.ff55b8df9.write(bArr, i, i2);
        return null;
    }
}

