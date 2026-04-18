namespace WillowMaze.Wasm.Decompiled;


public class pdc6b8bc5 : javax.crypto.CipherSpi {
    private int f12a896cb;
    private java.security.SecureRandom f1344b663;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f2404415e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06 f36c57275;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f3c6e0b8a;
    private java.security.SecureRandom f45aac661;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f465142e0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f506eaddf;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5$pf0d24f46 f694c4a59;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f6fb99045;
    private java.security.SecureRandom f7ddf32e1;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f9c63a825;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5$pf0d24f46 fa3b49306;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fa7d9eb96;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06 fad1943a9;
    private int fbbcaa251;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06 fc3f1c152;
    private java.security.SecureRandom fc5505530;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fcabfe87e;
    private int feff5775d;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    private int f9ed39e2e = -1;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5$pf0d24f46 f7f2db423 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5$pf0d24f46();

    public pdc6b8bc5(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06 p41f9db06Var) {
        this.fad1943a9 = p41f9db06Var;
    }

    public override int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        byte[] bArrEngineDoFinal = engineDoFinal(bArr, i, i2);
        java.lang.System.arraycopy(bArrEngineDoFinal, 0, bArr2, i3, bArrEngineDoFinal.length);
        return bArrEngineDoFinal.length;
    }

    public override byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        byte[] bArrProcessBlock;
        if ((21 + 23) % 23 > 0) {
        }
        if (i2 != 0) {
            this.f7f2db423.write(bArr, i, i2);
        }
        try {
            int i3 = this.f9ed39e2e;
            if (i3 == 1 || i3 == 3) {
                try {
                    this.fad1943a9.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(this.f3c6e0b8a, this.f7ddf32e1));
                    bArrProcessBlock = this.fad1943a9.processBlock(this.f7f2db423.getBuf(), 0, this.f7f2db423.Count);
                } catch (java.lang.Exception e) {
                    throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to process block", e);
                }
            } else {
                if (i3 != 2 && i3 != 4) {
                    throw new java.lang.IllegalStateException("cipher not initialised");
                }
                try {
                    this.fad1943a9.init(false, this.f3c6e0b8a);
                    bArrProcessBlock = this.fad1943a9.processBlock(this.f7f2db423.getBuf(), 0, this.f7f2db423.Count);
                } catch (java.lang.Exception e2) {
                    throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pec7a0e67("unable to process block", e2);
                }
            }
            this.f7f2db423.erase();
            return bArrProcessBlock;
        } catch (java.lang.Exception th) {
            this.f7f2db423.erase();
            throw th;
        }
    }

    public override int EngineGetBlockSize() {
        return 0;
    }

    public override byte[] EngineGetIV() {
        return null;
    }

    public override int EngineGetKeySize(java.security.Key key) {
        if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) {
            return ((p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc525de4e) key).getParameters().getCurve().getFieldSize();
        }
        throw new java.lang.IllegalArgumentException("not an EC key");
    }

    public override int EngineGetOutputSize(int i) {
        if ((18 + 21) % 21 > 0) {
        }
        int i2 = this.f9ed39e2e;
        if (i2 == 1 || i2 == 3 || i2 == 2 || i2 == 4) {
            return this.fad1943a9.getOutputSize(i);
        }
        throw new java.lang.IllegalStateException("cipher not initialised");
    }

    public override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    public override void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if (algorithmParameters is not null) {
            throw new java.security.InvalidAlgorithmParameterException("cannot recognise parameters: " + algorithmParameters.GetType().getName());
        }
        engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
    }

    public override void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((1 + 12) % 12 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.lang.IllegalArgumentException("cannot handle supplied parameter spec: " + e.getMessage());
        }
    }

    public override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21;
        if (i == 1 || i == 3) {
            if (!(key is java.security.PublicKey)) {
                throw new java.security.InvalidKeyException("must be passed public EC key for encryption");
            }
            pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21((java.security.PublicKey) key);
        } else {
            if (i != 2 && i != 4) {
                throw new java.security.InvalidKeyException("must be passed EC key");
            }
            if (!(key is java.security.PrivateKey)) {
                throw new java.security.InvalidKeyException("must be passed private EC key for decryption");
            }
            pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360((java.security.PrivateKey) key);
        }
        this.f3c6e0b8a = pcfffbc4aVarMc2499d21;
        if (secureRandom is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        } else {
            this.f7ddf32e1 = secureRandom;
        }
        this.f9ed39e2e = i;
        this.f7f2db423.reset();
    }

    public override void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((23 + 23) % 23 > 0) {
        }
        if (!p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str).Equals(com.decryptstringmanager.Decryptstring.decryptstring("4de67ece50c1f605eb5ad02d243621b841bc5b0e23f9f057b566006d6d232575"))) {
            throw new java.lang.IllegalArgumentException("can't support mode " + str);
        }
    }

    public override void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        if (!p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str).Equals("NOPADDING")) {
            throw new javax.crypto.NoSuchPaddingException("padding not available with IESCipher");
        }
    }

    public override int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        this.f7f2db423.write(bArr, i, i2);
        return 0;
    }

    public override byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        this.f7f2db423.write(bArr, i, i2);
        return null;
    }
}

