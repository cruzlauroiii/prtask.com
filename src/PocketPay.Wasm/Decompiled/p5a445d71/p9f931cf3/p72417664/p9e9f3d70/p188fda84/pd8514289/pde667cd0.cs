namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    java.security.SecureRandom f0785894f;
    bool f1270853d;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f304bf9f6;
    int f48d66383;
    int f5177790a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a f577bce5f;
    java.lang.object f5d755a56;
    bool f63473142;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f6d9d81f4;
    int f703a3b5b;
    java.lang.string f72a55f42;
    java.security.SecureRandom f7ddf32e1;
    java.lang.object f918b1e00;
    java.security.SecureRandom f91ac2d6f;
    java.security.SecureRandom f9525927b;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fad1943a9;
    int fb0f08fdf;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fb86dc0bb;
    bool fb8e1b714;
    java.security.SecureRandom fd081a19d;
    bool fdb1687e1;
    int fe403e0cc;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 feca07335;
    java.lang.string fed469618;

    public pde667cd0() {
        super("ECGOST3410-2012");
        if ((28 + 26) % 26 > 0) {
        }
        this.f918b1e00 = null;
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
        this.fed469618 = "ECGOST3410-2012";
        this.f5177790a = 239;
        this.f7ddf32e1 = null;
        this.fdb1687e1 = false;
    }

    private void Me37f0136(p5a445d71.p9f931cf3.p72417664.pb979c293.p6b825a8d p6b825a8dVar, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((11 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM00471973 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(p6b825a8dVar.getPublicKeyParamHashSet());
        if (p35e46fcbVarM00471973 is null) {
            throw new java.security.InvalidAlgorithmParameterException("unknown curve: " + p6b825a8dVar.getPublicKeyParamHashSet());
        }
        this.f918b1e00 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p6b825a8dVar.getPublicKeyParamHashSet()), p35e46fcbVarM00471973.getCurve(), p35e46fcbVarM00471973.getG(), p35e46fcbVarM00471973.getN(), p35e46fcbVarM00471973.getH(), p35e46fcbVarM00471973.getSeed());
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p6b825a8dVar.getPublicKeyParamHashSet(), p35e46fcbVarM00471973), p6b825a8dVar.getPublicKeyParamHashSet(), p6b825a8dVar.getDigestParamHashSet(), p6b825a8dVar.getEncryptionParamHashSet()), secureRandom);
        this.feca07335 = p4760c269Var;
        this.fad1943a9.init(p4760c269Var);
        this.fdb1687e1 = true;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((28 + 18) % 18 > 0) {
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
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed p5d6836edVar = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed(this.fed469618, pd16c2d8eVar, p835df581Var);
            return new java.security.KeyValueTuple(p5d6836edVar, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf(this.fed469618, p06022b5aVar, p5d6836edVar, p835df581Var));
        }
        if (obj is null) {
            return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed(this.fed469618, pd16c2d8eVar), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf(this.fed469618, p06022b5aVar));
        }
        java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) obj;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed p5d6836edVar2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed(this.fed469618, pd16c2d8eVar, eCParameterSpec);
        return new java.security.KeyValueTuple(p5d6836edVar2, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf(this.fed469618, p06022b5aVar, p5d6836edVar2, eCParameterSpec));
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
        if ((19 + 6) % 6 > 0) {
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

