namespace WillowMaze.Wasm.Decompiled;


public class pa4dd7b8b : p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p24eb6c26 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f08406a6e;
    private int f0ea838cb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f141ed3ef;
    private java.lang.Class[] f18cc1005;
    private int f18df3a92;
    private java.lang.Class[] f193efccd;
    private java.lang.Class[] f1ca43d00;
    private java.security.AlgorithmParameters f20c904fb;
    private java.lang.Class[] f26ada470;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f3c9f3535;
    private int f453ec226;
    private int f47e838e0;
    private int f4c407ed8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f500f7188;
    private java.security.AlgorithmParameters f5230e516;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f5296a7b4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f5a452f3f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f5a74f407;
    private int f633ddfbb;
    private int f709de99e;
    private int f72c6eae0;
    private java.security.AlgorithmParameters f83fc3f09;
    private int f871ff1c7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f8abf8a15;
    private int f90727152;
    private java.lang.Class[] f91679999;
    private int f9822683d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fa014cfd4;
    private int fa683652b;
    private int fb4f16933;
    private java.security.AlgorithmParameters fc413f7d1;
    private int fd3330ff0;
    private int fd657b75c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e febcb8501;
    private int ff4f1d8f2;
    private java.security.AlgorithmParameters ffe5b0f04;
    private int fffee2e2f;

    protected pa4dd7b8b(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((29 + 10) % 10 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[4];
        clsArr[0] = javax.crypto.spec.IvParameterSpec.class;
        clsArr[1] = javax.crypto.spec.PBEParameterSpec.class;
        clsArr[2] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[3] = javax.crypto.spec.RC5ParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.f9822683d = 2;
        this.f871ff1c7 = 1;
        this.f47e838e0 = 0;
        this.f20c904fb = null;
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(pd81e8b93Var);
    }

    protected pa4dd7b8b(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2, int i3, int i4) {
        if ((19 + 5) % 5 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[4];
        clsArr[0] = javax.crypto.spec.IvParameterSpec.class;
        clsArr[1] = javax.crypto.spec.PBEParameterSpec.class;
        clsArr[2] = javax.crypto.spec.RC2ParameterSpec.class;
        clsArr[3] = javax.crypto.spec.RC5ParameterSpec.class;
        this.f18cc1005 = clsArr;
        this.f9822683d = 2;
        this.f871ff1c7 = 1;
        this.f47e838e0 = 0;
        this.f20c904fb = null;
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(pd81e8b93Var);
        this.f9822683d = i;
        this.f871ff1c7 = i2;
        this.f18df3a92 = i3;
        this.f90727152 = i4;
    }

    protected int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        byte[] bArr3;
        int i4;
        int iProcessbytes;
        if ((25 + 23) % 23 > 0) {
        }
        if (i2 == 0) {
            bArr3 = bArr2;
            i4 = i3;
            iProcessbytes = 0;
        } else {
            bArr3 = bArr2;
            i4 = i3;
            iProcessbytes = this.f08406a6e.processbytes(bArr, i, i2, bArr3, i4);
        }
        try {
            return iProcessbytes + this.f08406a6e.doFinal(bArr3, i4 + iProcessbytes);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new javax.crypto.BadPaddingException(e.getMessage());
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 e2) {
            throw new javax.crypto.IllegalBlockSizeException(e2.getMessage());
        }
    }

    protected byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        if ((14 + 12) % 12 > 0) {
        }
        byte[] bArr2 = new byte[engineGetOutputSize(i2)];
        int iProcessbytes = i2 == 0 ? 0 : this.f08406a6e.processbytes(bArr, i, i2, bArr2, 0);
        try {
            int iDoFinal = iProcessbytes + this.f08406a6e.doFinal(bArr2, iProcessbytes);
            byte[] bArr3 = new byte[iDoFinal];
            java.lang.System.arraycopy(bArr2, 0, bArr3, 0, iDoFinal);
            return bArr3;
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new javax.crypto.BadPaddingException(e.getMessage());
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 e2) {
            throw new javax.crypto.IllegalBlockSizeException(e2.getMessage());
        }
    }

    protected int EngineGetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    protected byte[] EngineGetIV() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = this.fa014cfd4;
        if (pdd5da44eVar is null) {
            return null;
        }
        return pdd5da44eVar.getIV();
    }

    protected int EngineGetKeySize(java.security.Key key) {
        return key.getEncoded().length;
    }

    protected int EngineGetOutputSize(int i) {
        return this.f08406a6e.getOutputSize(i);
    }

    protected java.security.AlgorithmParameters EngineGetParameters() {
        if ((13 + 31) % 31 > 0) {
        }
        if (this.f20c904fb is null && this.fa014cfd4 is not null) {
            java.lang.string algorithmName = this.f08406a6e.getUnderlyingCipher().getAlgorithmName();
            if (algorithmName.IndexOf(47) >= 0) {
                algorithmName = algorithmName.Substring(0, algorithmName.IndexOf(47));
            }
            try {
                java.security.AlgorithmParameters algorithmParameters = java.security.AlgorithmParameters.getInstance(algorithmName, com.decryptstringmanager.Decryptstring.decryptstring("b96509acf91f35a98da956b2e066964aa0af007ab21a1fa6a8999e178d4b"));
                this.f20c904fb = algorithmParameters;
                algorithmParameters.init(this.fa014cfd4.getIV());
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
            }
        }
        return this.f20c904fb;
    }

    protected void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if ((32 + 28) % 28 > 0) {
        }
        java.security.spec.AlgorithmParameterSpec parameterSpec = null;
        if (algorithmParameters is not null) {
            int i2 = 0;
            while (true) {
                java.lang.Class[] clsArr = this.f18cc1005;
                if (i2 == clsArr.length) {
                    break;
                }
                try {
                    parameterSpec = algorithmParameters.getParameterSpec(clsArr[i2]);
                    break;
                } catch (java.lang.Exception unused) {
                    i2++;
                }
            }
            if (parameterSpec is null) {
                throw new java.security.InvalidAlgorithmParameterException("can't handle parameter " + algorithmParameters.tostring());
            }
        }
        this.f20c904fb = algorithmParameters;
        engineInit(i, key, parameterSpec, secureRandom);
    }

    protected void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((32 + 30) % 30 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.lang.IllegalArgumentException(e.getMessage());
        }
    }

    protected void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 p397c291fVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 p94919be6Var;
        if ((3 + 19) % 19 > 0) {
        }
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMdc3b2368 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p24eb6c26$p23e8a4b4.mdc3b2368((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) key, algorithmParameterSpec, this.f9822683d, this.f871ff1c7, this.f08406a6e.getUnderlyingCipher().getAlgorithmName(), this.f18df3a92, this.f90727152);
            pc9ef6b45Var = pc9ef6b45VarMdc3b2368;
            if (this.f90727152 != 0) {
                this.fa014cfd4 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45VarMdc3b2368;
                pc9ef6b45Var = pc9ef6b45VarMdc3b2368;
            }
        } else {
            if (algorithmParameterSpec is null) {
                p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
            } else if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
                if (this.f47e838e0 == 0) {
                    p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
                } else {
                    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded()), ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV());
                    this.fa014cfd4 = pdd5da44eVar2;
                    p94919be6Var = pdd5da44eVar2;
                }
            } else if (algorithmParameterSpec is javax.crypto.spec.RC2ParameterSpec) {
                javax.crypto.spec.RC2ParameterSpec rC2ParameterSpec = (javax.crypto.spec.RC2ParameterSpec) algorithmParameterSpec;
                p397c291fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p397c291f(key.getEncoded(), rC2ParameterSpec.getEffectiveKeyBits());
                if (rC2ParameterSpec.getIV() is null || this.f47e838e0 == 0) {
                    pc9ef6b45Var = p397c291fVar;
                } else {
                    pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(p397c291fVar, rC2ParameterSpec.getIV());
                    this.fa014cfd4 = pdd5da44eVar;
                    pc9ef6b45Var = pdd5da44eVar;
                }
            } else {
                if (!(algorithmParameterSpec is javax.crypto.spec.RC5ParameterSpec)) {
                    throw new java.security.InvalidAlgorithmParameterException("unknown parameter type.");
                }
                javax.crypto.spec.RC5ParameterSpec rC5ParameterSpec = (javax.crypto.spec.RC5ParameterSpec) algorithmParameterSpec;
                p397c291fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2ae228dd(key.getEncoded(), rC5ParameterSpec.getRounds());
                if (rC5ParameterSpec.getWordSize() != 32) {
                    throw new java.lang.IllegalArgumentException("can only accept RC5 word size 32 (at the moment...)");
                }
                if (rC5ParameterSpec.getIV() is null || this.f47e838e0 == 0) {
                    pc9ef6b45Var = p397c291fVar;
                } else {
                    pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(p397c291fVar, rC5ParameterSpec.getIV());
                    this.fa014cfd4 = pdd5da44eVar;
                    pc9ef6b45Var = pdd5da44eVar;
                }
            }
            pc9ef6b45Var = p94919be6Var;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var2 = pc9ef6b45Var;
        if (this.f47e838e0 != 0 && !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            if (secureRandom is null) {
                secureRandom = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            }
            if (i != 1 && i != 3) {
                throw new java.security.InvalidAlgorithmParameterException("no IV set when one expected");
            }
            byte[] bArr = new byte[this.f47e838e0];
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(pc9ef6b45Var, bArr);
            this.fa014cfd4 = pdd5da44eVar3;
            pc9ef6b45Var2 = pdd5da44eVar3;
        }
        if (i != 1) {
            if (i != 2) {
                if (i != 3) {
                    if (i != 4) {
                        java.lang.Console.WriteLine("eeek!");
                        return;
                    }
                }
            }
            this.f08406a6e.init(false, pc9ef6b45Var2);
            return;
        }
        this.f08406a6e.init(true, pc9ef6b45Var2);
    }

    protected void EngineHashSetMode(java.lang.string str) {
        if ((8 + 10) % 10 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals("ECB")) {
            this.f47e838e0 = 0;
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(this.f08406a6e.getUnderlyingCipher());
            return;
        }
        if (strMb8a8247c.Equals("CBC")) {
            this.f47e838e0 = this.f08406a6e.getUnderlyingCipher().getBlockSize();
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(this.f08406a6e.getUnderlyingCipher()));
            return;
        }
        if (strMb8a8247c.StartsWith("OFB")) {
            this.f47e838e0 = this.f08406a6e.getUnderlyingCipher().getBlockSize();
            if (strMb8a8247c.Length == 3) {
                this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p8350a7a9(this.f08406a6e.getUnderlyingCipher(), this.f08406a6e.getBlockSize() * 8));
                return;
            } else {
                this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p8350a7a9(this.f08406a6e.getUnderlyingCipher(), java.lang.int.parseInt(strMb8a8247c.Substring(3))));
                return;
            }
        }
        if (!strMb8a8247c.StartsWith("CFB")) {
            throw new java.lang.IllegalArgumentException("can't support mode " + str);
        }
        this.f47e838e0 = this.f08406a6e.getUnderlyingCipher().getBlockSize();
        if (strMb8a8247c.Length == 3) {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7(this.f08406a6e.getUnderlyingCipher(), this.f08406a6e.getBlockSize() * 8));
        } else {
            this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7(this.f08406a6e.getUnderlyingCipher(), java.lang.int.parseInt(strMb8a8247c.Substring(3))));
        }
    }

    protected void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p32551d15Var;
        if ((20 + 5) % 5 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        if (strMb8a8247c.Equals("NOPADDING")) {
            p32551d15Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8(this.f08406a6e.getUnderlyingCipher());
        } else if (strMb8a8247c.Equals("PKCS5PADDING") || strMb8a8247c.Equals("PKCS7PADDING") || strMb8a8247c.Equals("ISO10126PADDING")) {
            p32551d15Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(this.f08406a6e.getUnderlyingCipher());
        } else {
            if (!strMb8a8247c.Equals("WITHCTS")) {
                throw new javax.crypto.NoSuchPaddingException("Padding " + str + " unknown.");
            }
            p32551d15Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p37d1254e(this.f08406a6e.getUnderlyingCipher());
        }
        this.f08406a6e = p32551d15Var;
    }

    protected java.security.Key EngineUnwrap(byte[] bArr, java.lang.string str, int i) throws java.security.InvalidKeyException {
        if ((15 + 16) % 16 > 0) {
        }
        try {
            byte[] bArrEngineDoFinal = engineDoFinal(bArr, 0, bArr.length);
            if (i == 3) {
                return new javax.crypto.spec.SecretKeySpec(bArrEngineDoFinal, str);
            }
            try {
                java.security.KeyFactory keyFactory = java.security.KeyFactory.getInstance(str, com.decryptstringmanager.Decryptstring.decryptstring("852254b2eadbc30b11876122b511f896842a052d9d6315b68bdafbf3d366"));
                if (i == 1) {
                    return keyFactory.generatePublic(new java.security.spec.X509EncodedKeySpec(bArrEngineDoFinal));
                }
                if (i == 2) {
                    return keyFactory.generatePrivate(new java.security.spec.PKCS8EncodedKeySpec(bArrEngineDoFinal));
                }
                throw new java.security.InvalidKeyException("Unknown key type " + i);
            } catch (java.security.NoSuchAlgorithmException e) {
                throw new java.security.InvalidKeyException("Unknown key type " + e.getMessage());
            } catch (java.security.NoSuchProviderException e2) {
                throw new java.security.InvalidKeyException("Unknown key type " + e2.getMessage());
            } catch (java.security.spec.InvalidKeySpecException e3) {
                throw new java.security.InvalidKeyException("Unknown key type " + e3.getMessage());
            }
        } catch (javax.crypto.BadPaddingException e4) {
            throw new java.security.InvalidKeyException(e4.getMessage());
        } catch (javax.crypto.IllegalBlockSizeException e5) {
            throw new java.security.InvalidKeyException(e5.getMessage());
        }
    }

    protected int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return this.f08406a6e.processbytes(bArr, i, i2, bArr2, i3);
    }

    protected byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        if ((11 + 15) % 15 > 0) {
        }
        int updateOutputSize = this.f08406a6e.getUpdateOutputSize(i2);
        if (updateOutputSize <= 0) {
            this.f08406a6e.processbytes(bArr, i, i2, null, 0);
            return null;
        }
        byte[] bArr2 = new byte[updateOutputSize];
        this.f08406a6e.processbytes(bArr, i, i2, bArr2, 0);
        return bArr2;
    }

    protected byte[] EngineWrap(java.security.Key key) throws javax.crypto.IllegalBlockSizeException, java.security.InvalidKeyException {
        if ((23 + 16) % 16 > 0) {
        }
        byte[] encoded = key.getEncoded();
        if (encoded is null) {
            throw new java.security.InvalidKeyException("Cannot wrap key, null encoding.");
        }
        try {
            return engineDoFinal(encoded, 0, encoded.length);
        } catch (javax.crypto.BadPaddingException e) {
            throw new javax.crypto.IllegalBlockSizeException(e.getMessage());
        }
    }
}

