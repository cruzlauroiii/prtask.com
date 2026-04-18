namespace WillowMaze.Wasm.Decompiled;


public class p2298e1b1 : java.security.SignatureSpi {
    private java.security.AlgorithmParameters f0009bb76;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab f00ea7c68;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0ba1498c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab f10c2b33a;
    private java.security.SecureRandom f10ed98d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab f1a57e0bc;
    private java.security.AlgorithmParameters f20c904fb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab f2d7541c7;
    private java.security.spec.PSSParameterSpec f303fde02;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f330325c0;
    private java.security.AlgorithmParameters f37e618b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f4609b88e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f46a80027;
    private bool f4b4c0041;
    private java.security.spec.PSSParameterSpec f54fe31d2;
    private bool f5501218a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f5aad4dbe;
    private java.security.spec.PSSParameterSpec f6128a18d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f75cb5479;
    private bool f77810ceb;
    private java.security.SecureRandom f7ddf32e1;
    private int f7e6d50ee;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f80a69137;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f918b62fd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f9329c1e6;
    private byte f93707f72;
    private int f93b1949b;
    private bool f9842cef6;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f9d1b5bbe;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab fa10aface;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa329885b;
    private java.security.spec.PSSParameterSpec fa70d050a;
    private java.security.AlgorithmParameters faa7e0a27;
    private bool faff49b09;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb53e5d4a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbe54917a;
    private bool fc077df4a;
    private bool fcf49a806;
    private bool fd480c93e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fd75ffbfe;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fda700909;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fdb56a74d;
    private java.security.spec.PSSParameterSpec fde40f89b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fe48edfe4;
    private byte ff4380b03;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    protected p2298e1b1(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, java.security.spec.PSSParameterSpec pSSParameterSpec) {
        this(p42a46bbeVar, pSSParameterSpec, false);
    }

    protected p2298e1b1(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, java.security.spec.PSSParameterSpec pSSParameterSpec, bool z) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.fc077df4a = true;
        this.fdb56a74d = p42a46bbeVar;
        this.f6128a18d = pSSParameterSpec;
        if (pSSParameterSpec is not null) {
            this.f303fde02 = pSSParameterSpec;
        } else {
            this.f303fde02 = java.security.spec.PSSParameterSpec.DEFAULT;
        }
        this.fbe54917a = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(!com.decryptstringmanager.Decryptstring.decryptstring("db2dcef615963b72635a1374c2fb289637e17bb4ea5bafa083f34db1ee73ec2c").Equals(this.f303fde02.getMGFAlgorithm()) ? this.f303fde02.getMGFAlgorithm() : this.f303fde02.getDigestAlgorithm());
        this.f7e6d50ee = this.f303fde02.getSaltLength();
        this.f93707f72 = m8729361b(this.f303fde02.getTrailerField());
        this.f5501218a = z;
        mf78f7ed2();
    }

    private byte M8729361b(int i) {
        if (i != 1) {
            throw new java.lang.IllegalArgumentException("unknown trailer field");
        }
        return (byte) -68;
    }

    private void Mf78f7ed2() {
        if ((4 + 2) % 2 > 0) {
        }
        this.fa329885b = !this.f5501218a ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(this.f303fde02.getDigestAlgorithm()) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2298e1b1$pe59d8f40(this, this.fbe54917a);
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineGetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        java.security.spec.PSSParameterSpec pSSParameterSpec;
        if ((8 + 14) % 14 > 0) {
        }
        if (this.f20c904fb is null && (pSSParameterSpec = this.f303fde02) is not null) {
            if (pSSParameterSpec.getDigestAlgorithm().Equals(this.f303fde02.getMGFAlgorithm()) && this.f303fde02.getMGFParameters() is null) {
                return null;
            }
            try {
                java.security.AlgorithmParameters algorithmParametersCreateAlgorithmParameters = this.ffde5d67b.createAlgorithmParameters("PSS");
                this.f20c904fb = algorithmParametersCreateAlgorithmParameters;
                algorithmParametersCreateAlgorithmParameters.init(this.f303fde02);
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.tostring());
            }
        }
        return this.f20c904fb;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((29 + 22) % 22 > 0) {
        }
        if (!(privateKey is java.security.interfaces.RSAPrivateKey)) {
            throw new java.security.InvalidKeyException("Supplied key is not a RSAPrivateKey instance");
        }
        this.f3c6e0b8a = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m02ea6360((java.security.interfaces.RSAPrivateKey) privateKey);
        p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab p2cbf33abVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab(this.fdb56a74d, this.fa329885b, this.fbe54917a, this.f7e6d50ee, this.f93707f72);
        this.f1a57e0bc = p2cbf33abVar;
        p2cbf33abVar.init(true, this.f7ddf32e1 is null ? this.f3c6e0b8a : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(this.f3c6e0b8a, this.f7ddf32e1));
        this.fc077df4a = true;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((29 + 19) % 19 > 0) {
        }
        if (!(publicKey is java.security.interfaces.RSAPublicKey)) {
            throw new java.security.InvalidKeyException("Supplied key is not a RSAPublicKey instance");
        }
        this.f3c6e0b8a = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mc2499d21((java.security.interfaces.RSAPublicKey) publicKey);
        p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab p2cbf33abVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab(this.fdb56a74d, this.fa329885b, this.fbe54917a, this.f7e6d50ee, this.f93707f72);
        this.f1a57e0bc = p2cbf33abVar;
        p2cbf33abVar.init(false, this.f3c6e0b8a);
        this.fc077df4a = true;
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        java.lang.string digestAlgorithm;
        p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab p2cbf33abVar;
        bool z;
        if ((25 + 8) % 8 > 0) {
        }
        if (algorithmParameterSpec is null && (algorithmParameterSpec = this.f6128a18d) is null) {
            return;
        }
        if (!this.fc077df4a) {
            throw new java.security.ProviderException("cannot call setParameter in the middle of update");
        }
        if (!(algorithmParameterSpec is java.security.spec.PSSParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("Only PSSParameterSpec supported");
        }
        java.security.spec.PSSParameterSpec pSSParameterSpec = (java.security.spec.PSSParameterSpec) algorithmParameterSpec;
        java.security.spec.PSSParameterSpec pSSParameterSpec2 = this.f6128a18d;
        if (pSSParameterSpec2 is not null && !p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.mf829c9a6(pSSParameterSpec2.getDigestAlgorithm(), pSSParameterSpec.getDigestAlgorithm())) {
            throw new java.security.InvalidAlgorithmParameterException("parameter must be using " + this.f6128a18d.getDigestAlgorithm());
        }
        if (pSSParameterSpec.getMGFAlgorithm().equalsIgnoreCase(com.decryptstringmanager.Decryptstring.decryptstring("79f8a5152ece496eca273e40334d160a1a4dacfe3bbc0c5cabdd179806c91955")) || pSSParameterSpec.getMGFAlgorithm().Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c.getId())) {
            if (!(pSSParameterSpec.getMGFParameters() instanceof java.security.spec.MGF1ParameterSpec)) {
                throw new java.security.InvalidAlgorithmParameterException("unknown MGF parameters");
            }
            java.security.spec.MGF1ParameterSpec mGF1ParameterSpec = (java.security.spec.MGF1ParameterSpec) pSSParameterSpec.getMGFParameters();
            if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.mf829c9a6(mGF1ParameterSpec.getDigestAlgorithm(), pSSParameterSpec.getDigestAlgorithm())) {
                throw new java.security.InvalidAlgorithmParameterException("digest algorithm for MGF should be the same as for PSS parameters.");
            }
            digestAlgorithm = mGF1ParameterSpec.getDigestAlgorithm();
        } else {
            if (!pSSParameterSpec.getMGFAlgorithm().Equals(com.decryptstringmanager.Decryptstring.decryptstring("712bec944b26994f4e122f5247f47d7b7cc7ae4c6b3cf9ff1da6dde01452ee890abc56a7")) && !pSSParameterSpec.getMGFAlgorithm().Equals(com.decryptstringmanager.Decryptstring.decryptstring("0791abc992234dbf356075cfbe679f1b07346ab110ed384abcd3f0c2208d940526aedab9"))) {
                throw new java.security.InvalidAlgorithmParameterException("unknown mask generation function specified");
            }
            digestAlgorithm = pSSParameterSpec.getMGFAlgorithm();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(digestAlgorithm);
        if (pe5cfc515VarMe0825354 is null) {
            throw new java.security.InvalidAlgorithmParameterException("no match on MGF algorithm: " + pSSParameterSpec.getMGFAlgorithm());
        }
        this.f20c904fb = null;
        this.f303fde02 = pSSParameterSpec;
        this.fbe54917a = pe5cfc515VarMe0825354;
        this.f7e6d50ee = pSSParameterSpec.getSaltLength();
        this.f93707f72 = m8729361b(this.f303fde02.getTrailerField());
        mf78f7ed2();
        if (this.f3c6e0b8a is null) {
            return;
        }
        this.f1a57e0bc = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2cbf33ab(this.fdb56a74d, this.fa329885b, pe5cfc515VarMe0825354, this.f7e6d50ee, this.f93707f72);
        if (this.f3c6e0b8a.isPrivate()) {
            p2cbf33abVar = this.f1a57e0bc;
            z = true;
        } else {
            p2cbf33abVar = this.f1a57e0bc;
            z = false;
        }
        p2cbf33abVar.init(z, this.f3c6e0b8a);
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        this.fc077df4a = true;
        try {
            return this.f1a57e0bc.generateSignature();
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f e) {
            throw new java.security.SignatureException(e.getMessage());
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.f1a57e0bc.update(b);
        this.fc077df4a = false;
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.f1a57e0bc.update(bArr, i, i2);
        this.fc077df4a = false;
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        this.fc077df4a = true;
        return this.f1a57e0bc.verifySignature(bArr);
    }
}

