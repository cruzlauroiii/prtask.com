namespace WillowMaze.Wasm.Decompiled;


public class p23638c61 : java.security.SignatureSpi {
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f1d987523;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p66e08786 f1fde040b;
    private java.security.AlgorithmParameters f20c904fb;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p66e08786 f303fde02;
    private java.security.AlgorithmParameters f509a9e5d;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f81e0dee8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7 f8d4d414e;
    private java.security.AlgorithmParameters fa564b737;
    private java.security.AlgorithmParameters fb6981c90;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fc3ab12ec;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7 fc9487809;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7 fdb56a74d;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p66e08786 fe339fd5d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7 ff1b16c1c;
    private java.security.AlgorithmParameters ffbc745bd;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();

    p23638c61(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p4942c8b7 p4942c8b7Var) {
        this.fdb56a74d = p4942c8b7Var;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineGetParameter unsupported");
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        if ((2 + 2) % 2 > 0) {
        }
        if (this.f20c904fb is null && this.f303fde02 is not null) {
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
        if ((18 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        if (this.appRandom is not null) {
            pc9ef6b45VarM02ea6360 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarM02ea6360, this.appRandom);
        }
        if (this.f303fde02 is null) {
            this.fdb56a74d.init(true, pc9ef6b45VarM02ea6360);
        } else {
            this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd(pc9ef6b45VarM02ea6360, this.f303fde02.getID()));
        }
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((8 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(publicKey);
        if (this.f303fde02 is not null) {
            pc9ef6b45VarMc2499d21 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd(pc9ef6b45VarMc2499d21, this.f303fde02.getID());
        }
        this.fdb56a74d.init(false, pc9ef6b45VarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p66e08786)) {
            throw new java.security.InvalidAlgorithmParameterException("only SM2ParameterSpec supported");
        }
        this.f303fde02 = (p5a445d71.p9f931cf3.p72417664.pb979c293.p66e08786) algorithmParameterSpec;
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((21 + 13) % 13 > 0) {
        }
        try {
            return this.fdb56a74d.generateSignature();
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f e) {
            throw new java.security.SignatureException("unable to create signature: " + e.getMessage());
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

