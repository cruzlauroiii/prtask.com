namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f2a279d3c;
    java.lang.object f2d2ba268;
    java.security.SecureRandom f34edcc17;
    java.lang.string f3efc0b47;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f57b3b0fc;
    bool f5d44b7b9;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f637c4507;
    bool f7b5c03d0;
    java.security.SecureRandom f7ddf32e1;
    java.lang.object f918b1e00;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fad1943a9;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 fc1d145f0;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fc1d7dbd4;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 fc338a062;
    bool fdb1687e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 feca07335;
    java.lang.string fed469618;

    public pde667cd0() {
        super("DSTU4145");
        if ((13 + 13) % 13 > 0) {
        }
        this.f918b1e00 = null;
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pc4d64c56();
        this.fed469618 = "DSTU4145";
        this.f7ddf32e1 = null;
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((17 + 20) % 20 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException("DSTU Key ValueTuple Generator not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pd255ec94VarGenerateKeyValueTuple.getPublic();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pd255ec94VarGenerateKeyValueTuple.getPrivate();
        java.lang.object obj = this.f918b1e00;
        if (obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj;
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69(this.fed469618, pd16c2d8eVar, p835df581Var);
            return new java.security.KeyValueTuple(p75258f69Var, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b(this.fed469618, p06022b5aVar, p75258f69Var, p835df581Var));
        }
        if (obj is null) {
            return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69(this.fed469618, pd16c2d8eVar), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b(this.fed469618, p06022b5aVar));
        }
        java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) obj;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69(this.fed469618, pd16c2d8eVar, eCParameterSpec);
        return new java.security.KeyValueTuple(p75258f69Var2, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b(this.fed469618, p06022b5aVar, p75258f69Var2, eCParameterSpec));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
        java.lang.object obj = this.f918b1e00;
        if (obj is null) {
            throw new java.security.InvalidParameterException("unknown key size.");
        }
        try {
            initialize((java.security.spec.ECGenParameterSpec) obj, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException unused) {
            throw new java.security.InvalidParameterException("key size not configurable.");
        }
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var;
        if ((21 + 9) % 9 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581)) {
            if (algorithmParameterSpec is java.security.spec.ECParameterSpec) {
                java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) algorithmParameterSpec;
                this.f918b1e00 = algorithmParameterSpec;
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMaa4c417b = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, eCParameterSpec.getGenerator());
                if (eCParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p89d3f0b2) {
                    this.feca07335 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p654e2f75(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfaVarM2ace2977, p53a5793fVarMaa4c417b, eCParameterSpec.getOrder(), java.math.Bigint.valueOf(eCParameterSpec.getCofactor())), ((p5a445d71.p9f931cf3.p72417664.pb979c293.p89d3f0b2) eCParameterSpec).getDKE()), secureRandom);
                } else {
                    this.feca07335 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfaVarM2ace2977, p53a5793fVarMaa4c417b, eCParameterSpec.getOrder(), java.math.Bigint.valueOf(eCParameterSpec.getCofactor())), secureRandom);
                }
                this.fad1943a9.init(this.feca07335);
            } else {
                bool z = algorithmParameterSpec is java.security.spec.ECGenParameterSpec;
                if (z || (algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587)) {
                    java.lang.string name = !z ? ((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587) algorithmParameterSpec).getName() : ((java.security.spec.ECGenParameterSpec) algorithmParameterSpec).getName();
                    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarMd0402605 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7eca5bf5.md0402605(new p5a445d71.p9f931cf3.pca323100.p364bf33a(name));
                    if (p21c2eb74VarMd0402605 is null) {
                        throw new java.security.InvalidAlgorithmParameterException("unknown curve name: " + name);
                    }
                    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(name, p21c2eb74VarMd0402605.getCurve(), p21c2eb74VarMd0402605.getG(), p21c2eb74VarMd0402605.getN(), p21c2eb74VarMd0402605.getH(), p21c2eb74VarMd0402605.getSeed());
                    this.f918b1e00 = p698f972dVar;
                    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar2 = p698f972dVar;
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace29772 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p698f972dVar2.getCurve());
                    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfaVarM2ace29772, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace29772, p698f972dVar2.getGenerator()), p698f972dVar2.getOrder(), java.math.Bigint.valueOf(p698f972dVar2.getCofactor())), secureRandom);
                    this.feca07335 = p4760c269Var2;
                    this.fad1943a9.init(p4760c269Var2);
                } else {
                    if (algorithmParameterSpec is not null || p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() is null) {
                        if (algorithmParameterSpec is not null || p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() is not null) {
                            throw new java.security.InvalidAlgorithmParameterException("parameter object not a ECParameterSpec: " + algorithmParameterSpec.GetType().getName());
                        }
                        throw new java.security.InvalidAlgorithmParameterException("null parameter passed but no implicitCA set");
                    }
                    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
                    this.f918b1e00 = algorithmParameterSpec;
                    p4760c269Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getG(), ecImplicitlyCa.getN(), ecImplicitlyCa.getH()), secureRandom);
                }
            }
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) algorithmParameterSpec;
        this.f918b1e00 = algorithmParameterSpec;
        p4760c269Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581Var.getCurve(), p835df581Var.getG(), p835df581Var.getN(), p835df581Var.getH()), secureRandom);
        this.feca07335 = p4760c269Var;
        this.fad1943a9.init(p4760c269Var);
        this.fdb1687e1 = true;
    }
}

