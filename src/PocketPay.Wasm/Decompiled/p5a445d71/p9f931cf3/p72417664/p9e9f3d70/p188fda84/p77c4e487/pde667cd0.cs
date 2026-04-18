namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c f0874d98c;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f1966568e;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p24d9a6a4 f1dfda22a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c f1ff386e8;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f2d3bf47c;
    bool f368ef9ad;
    bool f3b38f9e2;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p24d9a6a4 f44a9361d;
    int f5177790a;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f59d4bbcc;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c f5a8b8e60;
    int f61c6330e;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f8b81282f;
    int f98bb8ad8;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p24d9a6a4 fad1943a9;
    int fca42e03b;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c fd4951ab6;
    bool fd63d0993;
    bool fdb1687e1;
    int fe75795a8;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c feca07335;

    public pde667cd0() {
        super("GOST3410");
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p24d9a6a4();
        this.f5177790a = 1024;
        this.f7ddf32e1 = null;
        this.fdb1687e1 = false;
    }

    private void Me37f0136(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d p6b825a8dVar, java.security.SecureRandom secureRandom) {
        if ((14 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 publicKeyParameters = p6b825a8dVar.getPublicKeyParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c pe5a0758cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe5a0758c(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05(publicKeyParameters.getP(), publicKeyParameters.getQ(), publicKeyParameters.getA()));
        this.feca07335 = pe5a0758cVar;
        this.fad1943a9.init(pe5a0758cVar);
        this.fdb1687e1 = true;
        this.f2d3bf47c = p6b825a8dVar;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((24 + 32) % 32 > 0) {
        }
        if (!this.fdb1687e1) {
            me37f0136(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f78e8f52e.getId()), p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8) pd255ec94VarGenerateKeyValueTuple.getPublic(), this.f2d3bf47c), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf) pd255ec94VarGenerateKeyValueTuple.getPrivate(), this.f2d3bf47c));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a GOST3410ParameterSpec");
        }
        me37f0136((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d) algorithmParameterSpec, secureRandom);
    }
}

