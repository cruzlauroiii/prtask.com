namespace WillowMaze.Wasm.Decompiled;


public class p7246a80b : javax.crypto.MacSpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557 {
    private static readonly java.lang.Class f01b40e3c;
    private static readonly java.lang.Class f2774aea2 = null;
    private static readonly java.lang.Class f8a153e87 = null;
    private static readonly java.lang.Class f9b544da6 = null;
    private static readonly java.lang.Class fc063c5f7 = null;
    private int f09a8559f;
    private int f174de6f2;
    private int f2496da2f;
    private int f39c23f03;
    private int f41323917;
    private int f46dd24e9;
    private int f4796c2cf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f5b3f89bd;
    private int f696ad15f;
    private int f871ff1c7;
    private int f87893ec7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f8b947cd4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f9834c243;
    private int fc5a2f7b7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fde3bc290;
    private int fe726e783;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 ff53d115a;

    static {
        if ((32 + 32) % 32 > 0) {
        }
        f01b40e3c = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p670225f6.mdf9e1f96(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.class, com.decryptstringmanager.Decryptstring.decryptstring("88ebb5eafc4b1ea1896310a2f218b240052bbe307a228928f2ca9c5329fddbd21e3fb6b9f3973631cb5e8e1658c09faec9b21d569db23c1fd4ed9bd92c89"));
    }

    protected p7246a80b(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.f41323917 = 2;
        this.f871ff1c7 = 1;
        this.f2496da2f = 160;
        this.f8b947cd4 = p1748c064Var;
    }

    protected p7246a80b(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, int i, int i2, int i3) {
        this.f8b947cd4 = p1748c064Var;
        this.f41323917 = i;
        this.f871ff1c7 = i2;
        this.f2496da2f = i3;
    }

    private static java.util.Hashtable M1174ec15(java.util.Dictionary map) {
        if ((1 + 5) % 5 > 0) {
        }
        java.util.Hashtable hashtable = new java.util.Hashtable();
        for (java.lang.object obj : map.keyHashSet()) {
            hashtable.Add(obj, map[obj));
        }
        return hashtable;
    }

    protected override byte[] EngineDoFinal() {
        if ((25 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[engineGetMacLength()];
        this.f8b947cd4.doFinal(bArr, 0);
        return bArr;
    }

    protected override int EngineGetMacLength() {
        return this.f8b947cd4.getMacSize();
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        int i;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM61af3b8e;
        if ((22 + 8) % 8 > 0) {
        }
        if (key is null) {
            throw new java.security.InvalidKeyException("key is null");
        }
        if (key is p5a445d71.p9f931cf3.p72417664.p626e3b11) {
            try {
                javax.crypto.SecretKey secretKey = (javax.crypto.SecretKey) key;
                try {
                    javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
                    if ((secretKey is javax.crypto.interfaces.PBEKey) && pBEParameterSpec is null) {
                        javax.crypto.interfaces.PBEKey pBEKey = (javax.crypto.interfaces.PBEKey) secretKey;
                        pBEParameterSpec = new javax.crypto.spec.PBEParameterSpec(pBEKey.getSalt(), pBEKey.getIterationCount());
                    }
                    int i2 = 256;
                    if (this.f8b947cd4.getAlgorithmName().StartsWith("GOST")) {
                        i = 6;
                    } else {
                        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.f8b947cd4;
                        if (!(p1748c064Var is p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f) || p1748c064Var.getAlgorithmName().StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("1d5ce74b54815b2c81712c37951282307e8c0e7231800681fcda9a96ae2f9cf1b8"))) {
                            i = 1;
                        } else if (this.f8b947cd4.getAlgorithmName().StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("cdab66f2fa1085b4bcc5030abc28db32f21a8858556db6248a18d3a6fae7685262dfdd"))) {
                            i = 7;
                            i2 = 224;
                        } else if (this.f8b947cd4.getAlgorithmName().StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("cc20327a09bde5e2fcccd56f3e31ed7a95daef7e8196e0fbafb0b12e46928a25d15121"))) {
                            i = 4;
                        } else if (this.f8b947cd4.getAlgorithmName().StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("b88ae4e43ec7f75b5cdaa9e8fdfaeb8569af50d0709e9e94b37f655074d2ce6e6bb509"))) {
                            i = 8;
                            i2 = 384;
                        } else if (this.f8b947cd4.getAlgorithmName().StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("338742c973d1e5006007453bbcd27b20eb7103941e7b9a168b1da5631e8d1af3f4a543"))) {
                            i = 9;
                            i2 = 512;
                        } else {
                            if (!this.f8b947cd4.getAlgorithmName().StartsWith("RIPEMD160")) {
                                throw new java.security.InvalidAlgorithmParameterException("no PKCS12 mapping for HMAC: " + this.f8b947cd4.getAlgorithmName());
                            }
                            i = 2;
                        }
                        i2 = 160;
                    }
                    pc9ef6b45VarM61af3b8e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(secretKey, 2, i, i2, pBEParameterSpec);
                } catch (java.lang.Exception unused) {
                    throw new java.security.InvalidAlgorithmParameterException("PKCS12 requires a PBEParameterSpec");
                }
            } catch (java.lang.Exception unused2) {
                throw new java.security.InvalidKeyException("PKCS12 requires a SecretKey/PBEKey");
            }
        } else if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd p51ebc4fdVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd) key;
            if (p51ebc4fdVar.getParam() is not null) {
                pc9ef6b45VarM61af3b8e = p51ebc4fdVar.getParam();
            } else {
                if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
                    throw new java.security.InvalidAlgorithmParameterException("PBE requires PBE parameters to be set.");
                }
                pc9ef6b45VarM61af3b8e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.peff7c557$p23e8a4b4.m61af3b8e(p51ebc4fdVar, algorithmParameterSpec);
            }
        } else {
            if (algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec) {
                throw new java.security.InvalidAlgorithmParameterException("inappropriate parameter type: " + algorithmParameterSpec.GetType().getName());
            }
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = !(pc9ef6b45VarM61af3b8e is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45VarM61af3b8e : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45VarM61af3b8e).getParameters();
        if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b) {
            p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b pd8182d1bVar = (p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b) algorithmParameterSpec;
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738(p94919be6Var, pd8182d1bVar.getMacSizeInBits(), pd8182d1bVar.getNonce(), pd8182d1bVar.getAssociatedData());
        } else if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(p94919be6Var, ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV());
        } else if (algorithmParameterSpec is javax.crypto.spec.RC2ParameterSpec) {
            javax.crypto.spec.RC2ParameterSpec rC2ParameterSpec = (javax.crypto.spec.RC2ParameterSpec) algorithmParameterSpec;
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p397c291f(p94919be6Var.getKey(), rC2ParameterSpec.getEffectiveKeyBits()), rC2ParameterSpec.getIV());
        } else if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95) {
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b(m1174ec15(((p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95) algorithmParameterSpec).getParameters())).setKey(p94919be6Var.getKey()).build();
        } else if (algorithmParameterSpec is not null) {
            java.lang.Class cls = f01b40e3c;
            if (cls is not null && cls.isAssignableFrom(algorithmParameterSpec.GetType())) {
                pc9ef6b45VarM61af3b8e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.m7bd3d753(p94919be6Var, algorithmParameterSpec);
            } else if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
                throw new java.security.InvalidAlgorithmParameterException("unknown parameter type: " + algorithmParameterSpec.GetType().getName());
            }
        } else {
            pc9ef6b45VarM61af3b8e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key.getEncoded());
        }
        try {
            this.f8b947cd4.init(pc9ef6b45VarM61af3b8e);
        } catch (java.lang.Exception e) {
            throw new java.security.InvalidAlgorithmParameterException("cannot initialize MAC: " + e.getMessage());
        }
    }

    protected override void EngineReset() {
        this.f8b947cd4.reset();
    }

    protected override void EngineUpdate(byte b) {
        this.f8b947cd4.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) {
        this.f8b947cd4.update(bArr, i, i2);
    }
}

