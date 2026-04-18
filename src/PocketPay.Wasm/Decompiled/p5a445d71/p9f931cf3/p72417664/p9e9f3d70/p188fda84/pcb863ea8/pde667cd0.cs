namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77 f1d6fbcff;
    int f29fb8879;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77 f2ae1ce04;
    java.security.SecureRandom f361346a6;
    int f38fafb02;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77 f398c46cf;
    int f5177790a;
    int f68aa8a86;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa f7c97e4b7;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f84936f07;
    int f909e1f71;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa fa615dd3d;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77 fab2fc726;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77 fad1943a9;
    int fb7d31f7a;
    bool fc5c26087;
    int fd0ae4c8e;
    java.security.SecureRandom fd0ef24b0;
    bool fdb1687e1;
    java.security.SecureRandom fdd43c12c;
    int fdfae62f9;
    bool fe443ddb7;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa feca07335;
    bool ff86c1fee;

    public pde667cd0() {
        super("ElGamal");
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pcbecfd77();
        this.f5177790a = 1024;
        this.f29fb8879 = 20;
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa p3d024eaaVar;
        if ((32 + 17) % 17 > 0) {
        }
        if (!this.fdb1687e1) {
            javax.crypto.spec.DHParameterSpec dHDefaultParameters = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getDHDefaultParameters(this.f5177790a);
            if (dHDefaultParameters is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb68cb209 pb68cb209Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb68cb209();
                pb68cb209Var.init(this.f5177790a, this.f29fb8879, this.f7ddf32e1);
                p3d024eaaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa(this.f7ddf32e1, pb68cb209Var.generateParameters());
            } else {
                p3d024eaaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa(this.f7ddf32e1, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(dHDefaultParameters.getP(), dHDefaultParameters.getG(), dHDefaultParameters.getL()));
            }
            this.feca07335 = p3d024eaaVar;
            this.fad1943a9.init(this.feca07335);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p5bad5e0c((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa p3d024eaaVar;
        if ((30 + 25) % 25 > 0) {
        }
        bool z = algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f;
        if (!z && !(algorithmParameterSpec is javax.crypto.spec.DHParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a DHParameterSpec or an ElGamalParameterSpec");
        }
        if (z) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f pdcabce2fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f) algorithmParameterSpec;
            p3d024eaaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(pdcabce2fVar.getP(), pdcabce2fVar.getG()));
        } else {
            javax.crypto.spec.DHParameterSpec dHParameterSpec = (javax.crypto.spec.DHParameterSpec) algorithmParameterSpec;
            p3d024eaaVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(dHParameterSpec.getP(), dHParameterSpec.getG(), dHParameterSpec.getL()));
        }
        this.feca07335 = p3d024eaaVar;
        this.fad1943a9.init(this.feca07335);
        this.fdb1687e1 = true;
    }
}

