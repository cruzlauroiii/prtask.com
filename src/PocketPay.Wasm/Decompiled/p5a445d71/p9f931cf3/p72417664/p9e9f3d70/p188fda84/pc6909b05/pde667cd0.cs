namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    bool f08949889;
    int f0a3729bc;
    bool f100d1747;
    java.lang.string f241323e7;
    bool f2d52b220;
    java.lang.string f31cd06a6;
    java.lang.object f331285a7;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f350cbcc0;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f43f3cb4f;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f4d027305;
    int f5177790a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f5c1cb0f1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f5c985afe;
    java.lang.string f77fc2700;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f819e6334;
    java.lang.object f918b1e00;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fad1943a9;
    java.security.SecureRandom fb3a087be;
    java.lang.string fc17cdf20;
    bool fdb1687e1;
    int fded396f6;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 feca07335;
    java.lang.string fed469618;
    bool ff63b22f0;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a ff6d37379;
    int ff72a112c;

    public pde667cd0() {
        super("ECGOST3410");
        if ((24 + 7) % 7 > 0) {
        }
        this.f918b1e00 = null;
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
        this.fed469618 = "ECGOST3410";
        this.f5177790a = 239;
        this.f7ddf32e1 = null;
        this.fdb1687e1 = false;
    }

    private void Me37f0136(p5a445d71.p9f931cf3.p72417664.pb979c293.p6b825a8d p6b825a8dVar, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((32 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a publicKeyParamHashSet = p6b825a8dVar.getPublicKeyParamHashSet();
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM00471973 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(publicKeyParamHashSet);
        if (p35e46fcbVarM00471973 is null) {
            throw new java.security.InvalidAlgorithmParameterException("unknown curve: " + publicKeyParamHashSet);
        }
        this.f918b1e00 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(publicKeyParamHashSet), p35e46fcbVarM00471973.getCurve(), p35e46fcbVarM00471973.getG(), p35e46fcbVarM00471973.getN(), p35e46fcbVarM00471973.getH(), p35e46fcbVarM00471973.getSeed());
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(publicKeyParamHashSet, p35e46fcbVarM00471973), publicKeyParamHashSet, p6b825a8dVar.getDigestParamHashSet(), p6b825a8dVar.getEncryptionParamHashSet()), secureRandom);
        this.feca07335 = p4760c269Var;
        this.fad1943a9.init(p4760c269Var);
        this.fdb1687e1 = true;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((11 + 28) % 28 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException("EC Key ValueTuple Generator not initialised");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pd255ec94VarGenerateKeyValueTuple.getPublic();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pd255ec94VarGenerateKeyValueTuple.getPrivate();
        java.lang.object obj = this.f918b1e00;
        if (obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj;
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685(this.fed469618, pd16c2d8eVar, p835df581Var);
            return new java.security.KeyValueTuple(pecf68685Var, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8(this.fed469618, p06022b5aVar, pecf68685Var, p835df581Var));
        }
        if (obj is null) {
            return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685(this.fed469618, pd16c2d8eVar), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8(this.fed469618, p06022b5aVar));
        }
        java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) obj;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685(this.fed469618, pd16c2d8eVar, eCParameterSpec);
        return new java.security.KeyValueTuple(pecf68685Var2, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8(this.fed469618, p06022b5aVar, pecf68685Var2, eCParameterSpec));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
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
        if ((15 + 31) % 31 > 0) {
        }
        if (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p6b825a8d) {
            me37f0136((p5a445d71.p9f931cf3.p72417664.pb979c293.p6b825a8d) algorithmParameterSpec, secureRandom);
            return;
        }
        if (algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) algorithmParameterSpec;
            this.f918b1e00 = algorithmParameterSpec;
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581Var.getCurve(), p835df581Var.getG(), p835df581Var.getN(), p835df581Var.getH()), secureRandom);
            this.feca07335 = p4760c269Var;
            this.fad1943a9.init(p4760c269Var);
            this.fdb1687e1 = true;
            return;
        }
        if (algorithmParameterSpec is java.security.spec.ECParameterSpec) {
            java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) algorithmParameterSpec;
            this.f918b1e00 = algorithmParameterSpec;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfaVarM2ace2977, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, eCParameterSpec.getGenerator()), eCParameterSpec.getOrder(), java.math.Bigint.valueOf(eCParameterSpec.getCofactor())), secureRandom);
            this.feca07335 = p4760c269Var2;
            this.fad1943a9.init(p4760c269Var2);
            this.fdb1687e1 = true;
            return;
        }
        bool z = algorithmParameterSpec is java.security.spec.ECGenParameterSpec;
        if (z || (algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587)) {
            me37f0136(new p5a445d71.p9f931cf3.p72417664.pb979c293.p6b825a8d(!z ? ((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587) algorithmParameterSpec).getName() : ((java.security.spec.ECGenParameterSpec) algorithmParameterSpec).getName()), secureRandom);
            return;
        }
        if (algorithmParameterSpec is not null || p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() is null) {
            if (algorithmParameterSpec is not null || p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() is not null) {
                throw new java.security.InvalidAlgorithmParameterException("parameter object not a ECParameterSpec: " + algorithmParameterSpec.GetType().getName());
            }
            throw new java.security.InvalidAlgorithmParameterException("null parameter passed but no implicitCA set");
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
        this.f918b1e00 = algorithmParameterSpec;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getG(), ecImplicitlyCa.getN(), ecImplicitlyCa.getH()), secureRandom);
        this.feca07335 = p4760c269Var3;
        this.fad1943a9.init(p4760c269Var3);
        this.fdb1687e1 = true;
    }
}

