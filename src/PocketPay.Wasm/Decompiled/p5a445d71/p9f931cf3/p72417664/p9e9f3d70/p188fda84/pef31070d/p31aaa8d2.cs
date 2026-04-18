namespace WillowMaze.Wasm.Decompiled;


public class p31aaa8d2 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267 {
    private java.security.AlgorithmParameters f03957e2d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private java.security.AlgorithmParameters f20c904fb;
    private java.security.spec.AlgorithmParameterSpec f29fa4215;
    private java.security.spec.AlgorithmParameterSpec f303fde02;
    private bool f3247ce79;
    private java.security.spec.AlgorithmParameterSpec f50dd2d7c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f71aa2be1;
    private java.security.spec.AlgorithmParameterSpec f7f147658;
    private bool f8c2d8443;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fa97078c7;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46 faed90dde;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fb9319c5b;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fb97c689f;
    private bool fcca896c4;
    private bool fce26c9ef;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fd42c23ce;
    private java.security.spec.AlgorithmParameterSpec fd656ade4;
    private bool fed414023;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46 ff55b8df9;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    public p31aaa8d2(javax.crypto.spec.OAEPParameterSpec oAEPParameterSpec) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.fce26c9ef = false;
        this.f3247ce79 = false;
        this.ff55b8df9 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46();
        try {
            m8872f202(oAEPParameterSpec);
        } catch (javax.crypto.NoSuchPaddingException e) {
            throw new java.lang.IllegalArgumentException(e.getMessage());
        }
    }

    public p31aaa8d2(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.fce26c9ef = false;
        this.f3247ce79 = false;
        this.ff55b8df9 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46();
        this.f08406a6e = p42a46bbeVar;
    }

    public p31aaa8d2(bool z, bool z2, p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.fce26c9ef = false;
        this.f3247ce79 = false;
        this.ff55b8df9 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267$pf0d24f46();
        this.fce26c9ef = z;
        this.f3247ce79 = z2;
        this.f08406a6e = p42a46bbeVar;
    }

    private void M8872f202(javax.crypto.spec.OAEPParameterSpec oAEPParameterSpec) throws javax.crypto.NoSuchPaddingException {
        if ((21 + 32) % 32 > 0) {
        }
        java.security.spec.MGF1ParameterSpec mGF1ParameterSpec = (java.security.spec.MGF1ParameterSpec) oAEPParameterSpec.getMGFParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(mGF1ParameterSpec.getDigestAlgorithm());
        if (pe5cfc515VarMe0825354 is null) {
            throw new javax.crypto.NoSuchPaddingException("no match on OAEP constructor for digest algorithm: " + mGF1ParameterSpec.getDigestAlgorithm());
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94(), pe5cfc515VarMe0825354, ((javax.crypto.spec.PSource$PSpecified) oAEPParameterSpec.getPSource()).getValue());
        this.f303fde02 = oAEPParameterSpec;
    }

    private byte[] Me09f6787() throws javax.crypto.BadPaddingException {
        if ((25 + 16) % 16 > 0) {
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
        if ((22 + 8) % 8 > 0) {
        }
        if (engineGetOutputSize(i2) + i3 > bArr2.length) {
            throw new javax.crypto.shortBufferException("output buffer too short for input.");
        }
        if (bArr is not null) {
            this.ff55b8df9.write(bArr, i, i2);
        }
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
            }
        } else if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
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
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
            }
        } else if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
        }
        return me09f6787();
    }

    protected override int EngineGetBlockSize() {
        try {
            return this.f08406a6e.getInputBlockSize();
        } catch (java.lang.NullPointerException unused) {
            throw new java.lang.IllegalStateException("RSA Cipher not initialised");
        }
    }

    protected override int EngineGetKeySize(java.security.Key key) {
        java.math.Bigint modulus;
        if (key is java.security.interfaces.RSAPrivateKey) {
            modulus = ((java.security.interfaces.RSAPrivateKey) key).getModulus();
        } else {
            if (!(key is java.security.interfaces.RSAPublicKey)) {
                throw new java.lang.IllegalArgumentException("not an RSA key!");
            }
            modulus = ((java.security.interfaces.RSAPublicKey) key).getModulus();
        }
        return modulus.bitLength();
    }

    protected override int EngineGetOutputSize(int i) {
        try {
            return this.f08406a6e.getOutputBlockSize();
        } catch (java.lang.NullPointerException unused) {
            throw new java.lang.IllegalStateException("RSA Cipher not initialised");
        }
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        if ((4 + 18) % 18 > 0) {
        }
        if (this.f20c904fb is null && this.f303fde02 is not null) {
            try {
                java.security.AlgorithmParameters algorithmParametersCreateAlgorithmParameters = this.ffde5d67b.createAlgorithmParameters("OAEP");
                this.f20c904fb = algorithmParametersCreateAlgorithmParameters;
                algorithmParametersCreateAlgorithmParameters.init(this.f303fde02);
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
            }
        }
        return this.f20c904fb;
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        java.security.spec.AlgorithmParameterSpec parameterSpec;
        if (algorithmParameters is null) {
            parameterSpec = null;
        } else {
            try {
                parameterSpec = algorithmParameters.getParameterSpec(javax.crypto.spec.OAEPParameterSpec.class);
            } catch (java.security.spec.InvalidParameterSpecException e) {
                throw new java.security.InvalidAlgorithmParameterException("cannot recognise parameters: " + e.tostring(), e);
            }
        }
        this.f20c904fb = algorithmParameters;
        engineInit(i, key, parameterSpec, secureRandom);
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((26 + 25) % 25 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.security.InvalidKeyException("Eeeek! " + e.tostring(), e);
        }
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM02ea6360;
        if ((2 + 6) % 6 > 0) {
        }
        if (algorithmParameterSpec is not null && !(algorithmParameterSpec is javax.crypto.spec.OAEPParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("unknown parameter type: " + algorithmParameterSpec.GetType().getName());
        }
        if (key is java.security.interfaces.RSAPublicKey) {
            if (this.f3247ce79 && i == 1) {
                throw new java.security.InvalidKeyException("mode 1 requires RSAPrivateKey");
            }
            pc9ef6b45VarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mc2499d21((java.security.interfaces.RSAPublicKey) key);
        } else {
            if (!(key is java.security.interfaces.RSAPrivateKey)) {
                throw new java.security.InvalidKeyException("unknown key type passed to RSA");
            }
            if (this.fce26c9ef && i == 1) {
                throw new java.security.InvalidKeyException("mode 2 requires RSAPublicKey");
            }
            pc9ef6b45VarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m02ea6360((java.security.interfaces.RSAPrivateKey) key);
        }
        if (algorithmParameterSpec is not null) {
            javax.crypto.spec.OAEPParameterSpec oAEPParameterSpec = (javax.crypto.spec.OAEPParameterSpec) algorithmParameterSpec;
            this.f303fde02 = algorithmParameterSpec;
            if (!oAEPParameterSpec.getMGFAlgorithm().equalsIgnoreCase(com.decryptstringmanager.Decryptstring.decryptstring("78da444882d92c4c6700cf443b7e2b249006b66acb3cc89c0212522b09c0ddc8")) && !oAEPParameterSpec.getMGFAlgorithm().Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c.getId())) {
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
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94(), pe5cfc515VarMe0825354, pe5cfc515VarMe08253542, ((javax.crypto.spec.PSource$PSpecified) oAEPParameterSpec.getPSource()).getValue());
        }
        if (!(this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94)) {
            pc9ef6b45VarM02ea6360 = secureRandom is null ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarM02ea6360, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1()) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarM02ea6360, secureRandom);
        }
        this.ff55b8df9.reset();
        if (i != 1) {
            if (i != 2) {
                if (i != 3) {
                    if (i != 4) {
                        throw new java.security.InvalidParameterException("unknown opmode " + i + " passed to RSA");
                    }
                }
            }
            this.f08406a6e.init(false, pc9ef6b45VarM02ea6360);
            return;
        }
        this.f08406a6e.init(true, pc9ef6b45VarM02ea6360);
    }

    protected override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((8 + 1) % 1 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals(com.decryptstringmanager.Decryptstring.decryptstring("2c272194b4d1720a259f66ee67cc2fddebd33da3714d680583078142abc1f204")) || strMb8a8247c.Equals("ECB")) {
            return;
        }
        if (strMb8a8247c.Equals(com.decryptstringmanager.Decryptstring.decryptstring("082c952cc4c84974f0eab1eb6fb4c5c7ccefb196c421e583591496c520"))) {
            this.f3247ce79 = true;
            this.fce26c9ef = false;
        } else {
            if (!strMb8a8247c.Equals(com.decryptstringmanager.Decryptstring.decryptstring("d4d3d1444d8a8859042420ca7d641ff85c6b1445fa677e9ad146565732"))) {
                throw new java.security.NoSuchAlgorithmException("can't support mode " + str);
            }
            this.f3247ce79 = false;
            this.fce26c9ef = true;
        }
    }

    protected override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if ((30 + 15) % 15 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals("NOPADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94();
            return;
        }
        if (strMb8a8247c.Equals("PKCS1PADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pb4e47103(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94());
            return;
        }
        if (strMb8a8247c.Equals("ISO9796-1PADDING")) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.p2ddea612(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94());
            return;
        }
        bool zEquals = strMb8a8247c.Equals("OAEPWITHMD5ANDMGF1PADDING");
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("50fd8338f3ded4883efb8d8fe468a1ce541c3d348bd05777b41b0396317a7615");
        if (zEquals) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec("MD5", strDecryptstring, new java.security.spec.MGF1ParameterSpec("MD5"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPPADDING")) {
            m8872f202(javax.crypto.spec.OAEPParameterSpec.DEFAULT);
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA1ANDMGF1PADDING") || strMb8a8247c.Equals("OAEPWITHSHA-1ANDMGF1PADDING")) {
            m8872f202(javax.crypto.spec.OAEPParameterSpec.DEFAULT);
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA224ANDMGF1PADDING") || strMb8a8247c.Equals("OAEPWITHSHA-224ANDMGF1PADDING")) {
            java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("0c2e22f0e28765b14293c8f22d2a794d22dbf897332548d8617a87b800f5bea5af664f");
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(strDecryptstring2, strDecryptstring, new java.security.spec.MGF1ParameterSpec(strDecryptstring2), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA256ANDMGF1PADDING") || strMb8a8247c.Equals("OAEPWITHSHA-256ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("2dc3b4a4c353464646daef1a021ff9c1c8a4a6a85974bf4776658cb74454264a015411"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA256, javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA384ANDMGF1PADDING") || strMb8a8247c.Equals("OAEPWITHSHA-384ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("4ebf43f6ca8956d9c4274e6f944626167747a2a7cfa5f3b185778da4fb966f6ec1e059"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA384, javax.crypto.spec.PSource$PSpecified.DEFAULT));
            return;
        }
        if (strMb8a8247c.Equals("OAEPWITHSHA512ANDMGF1PADDING") || strMb8a8247c.Equals("OAEPWITHSHA-512ANDMGF1PADDING")) {
            m8872f202(new javax.crypto.spec.OAEPParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("877f1cebcdc3bad405fdb3253f21feed57bac19bae91ecab17419f442a80867eaec381"), strDecryptstring, java.security.spec.MGF1ParameterSpec.SHA512, javax.crypto.spec.PSource$PSpecified.DEFAULT));
        } else {
            if (strMb8a8247c.Equals("OAEPWITHSHA3-224ANDMGF1PADDING")) {
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-224", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-224"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
                return;
            }
            if (strMb8a8247c.Equals("OAEPWITHSHA3-256ANDMGF1PADDING")) {
                java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("561700d971893e1d380164efaa69e2fc672ed25520988fbc13e4afaf1909a6a2b77f5e0f");
                m8872f202(new javax.crypto.spec.OAEPParameterSpec(strDecryptstring3, strDecryptstring, new java.security.spec.MGF1ParameterSpec(strDecryptstring3), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            } else if (strMb8a8247c.Equals("OAEPWITHSHA3-384ANDMGF1PADDING")) {
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-384", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-384"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            } else {
                if (!strMb8a8247c.Equals("OAEPWITHSHA3-512ANDMGF1PADDING")) {
                    throw new javax.crypto.NoSuchPaddingException(str + " unavailable with RSA.");
                }
                m8872f202(new javax.crypto.spec.OAEPParameterSpec("SHA3-512", strDecryptstring, new java.security.spec.MGF1ParameterSpec("SHA3-512"), javax.crypto.spec.PSource$PSpecified.DEFAULT));
            }
        }
    }

    protected override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        this.ff55b8df9.write(bArr, i, i2);
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
            }
            return 0;
        }
        if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
        }
        return 0;
    }

    protected override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        this.ff55b8df9.write(bArr, i, i2);
        if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9d452d94) {
            if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize() + 1) {
                throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
            }
            return null;
        }
        if (this.ff55b8df9.Count > this.f08406a6e.getInputBlockSize()) {
            throw new java.lang.ArrayIndexOutOfBoundsException("too much data for RSA block");
        }
        return null;
    }
}

