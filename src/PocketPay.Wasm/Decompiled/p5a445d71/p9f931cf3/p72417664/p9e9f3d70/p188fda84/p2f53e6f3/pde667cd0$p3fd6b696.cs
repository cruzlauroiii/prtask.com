namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0$p3fd6b696 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pde667cd0 {
    private static java.util.Hashtable f07b46124;
    private static java.util.Hashtable f1e2e3705;
    private static java.util.Hashtable f7a022186;
    private static java.util.Hashtable f9127309d;
    private static java.util.Hashtable f93d22a9e;
    java.security.SecureRandom f0af0cfd4;
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f3f695167;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 f426954c3;
    int f5177790a;
    java.lang.object f7039d30f;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f87135bcf;
    java.lang.object f918b1e00;
    java.lang.object fa4cd1c63;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fad1943a9;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a fc274140c;
    int fc8bea13b;
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fccd10663;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 fcf09ff5b;
    java.lang.string fd4fc7909;
    bool fdb1687e1;
    bool fdb42cb97;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 feca07335;
    java.security.SecureRandom feca0e524;
    java.lang.string fed469618;

    static {
        if ((27 + 2) % 2 > 0) {
        }
        java.util.Hashtable hashtable = new java.util.Hashtable();
        f07b46124 = hashtable;
        hashtable.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("542e324abdf1f9be8a3d993ff95d233bc6f3cd4384759f1d609ae292435c89040075f9d66463")));
        f07b46124.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(239), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("8cead714473cdcbbff917139ea192f1b77213920576d7a973b3541d4301d51a712f826d4b36a")));
        f07b46124.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("3ade0eb33563fd86f3c5ef09efe564f378926c9ff1945558e376df487deb88df017257db1a22")));
        f07b46124.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(224), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("cba38cd0f273cdfb118fae7a752964fdd97967e5dcc2010226d9f579ce3145dfe6")));
        f07b46124.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(384), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("45505fb80e37a94668da2d1024c6a6a436b54ef8a7f9facb7d0ba94d3439f0f4c2")));
        f07b46124.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(521), new java.security.spec.ECGenParameterSpec(com.decryptstringmanager.Decryptstring.decryptstring("8fc293ba8630f5e9e0f57cbc730509ab8fd0383609bf1f00e6c3c74a556c753736")));
    }

    public pde667cd0$p3fd6b696() {
        super("EC");
        if ((3 + 7) % 7 > 0) {
        }
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
        this.f918b1e00 = null;
        this.f5177790a = 239;
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
        this.fed469618 = "EC";
        this.fccd10663 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea;
    }

    public pde667cd0$p3fd6b696(java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        super(str);
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
        this.f918b1e00 = null;
        this.f5177790a = 239;
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
        this.fed469618 = str;
        this.fccd10663 = pfe41e66bVar;
    }

    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 CreateKeyGenParamsBC(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var, java.security.SecureRandom secureRandom) {
        if ((7 + 7) % 7 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581Var.getCurve(), p835df581Var.getG(), p835df581Var.getN(), p835df581Var.getH()), secureRandom);
    }

    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 CreateKeyGenParamsJCE(java.security.spec.ECParameterSpec eCParameterSpec, java.security.SecureRandom secureRandom) {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM0daa78aa;
        if ((7 + 2) % 2 > 0) {
        }
        if ((eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) && (p35e46fcbVarM0daa78aa = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.m0daa78aa(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName(), this.fccd10663)) is not null) {
            return createKeyGenParamsJCE(p35e46fcbVarM0daa78aa, secureRandom);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfaVarM2ace2977, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, eCParameterSpec.getGenerator()), eCParameterSpec.getOrder(), java.math.Bigint.valueOf(eCParameterSpec.getCofactor())), secureRandom);
    }

    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 CreateKeyGenParamsJCE(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar, java.security.SecureRandom secureRandom) {
        if ((14 + 22) % 22 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p35e46fcbVar.getCurve(), p35e46fcbVar.getG(), p35e46fcbVar.getN(), p35e46fcbVar.getH()), secureRandom);
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((30 + 18) % 18 > 0) {
        }
        if (!this.fdb1687e1) {
            initialize(this.f5177790a, new java.security.SecureRandom());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pd255ec94VarGenerateKeyValueTuple.getPublic();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pd255ec94VarGenerateKeyValueTuple.getPrivate();
        java.lang.object obj = this.f918b1e00;
        if (obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj;
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, pd16c2d8eVar, p835df581Var, this.fccd10663);
            return new java.security.KeyValueTuple(p3ecd70d1Var, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, p06022b5aVar, p3ecd70d1Var, p835df581Var, this.fccd10663));
        }
        if (obj is null) {
            return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, pd16c2d8eVar, this.fccd10663), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, p06022b5aVar, this.fccd10663));
        }
        java.security.spec.ECParameterSpec eCParameterSpec = (java.security.spec.ECParameterSpec) obj;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, pd16c2d8eVar, eCParameterSpec, this.fccd10663);
        return new java.security.KeyValueTuple(p3ecd70d1Var2, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, p06022b5aVar, p3ecd70d1Var2, eCParameterSpec, this.fccd10663));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
        java.security.spec.ECGenParameterSpec eCGenParameterSpec = (java.security.spec.ECGenParameterSpec) f07b46124[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i));
        if (eCGenParameterSpec is null) {
            throw new java.security.InvalidParameterException("unknown key size.");
        }
        try {
            initialize(eCGenParameterSpec, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException unused) {
            throw new java.security.InvalidParameterException("key size not configurable.");
        }
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa;
        java.lang.string name;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269VarCreateKeyGenParamsJCE;
        if (algorithmParameterSpec is not null) {
            if (algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) {
                this.f918b1e00 = algorithmParameterSpec;
                ecImplicitlyCa = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) algorithmParameterSpec;
            } else if (algorithmParameterSpec is java.security.spec.ECParameterSpec) {
                this.f918b1e00 = algorithmParameterSpec;
                p4760c269VarCreateKeyGenParamsJCE = createKeyGenParamsJCE((java.security.spec.ECParameterSpec) algorithmParameterSpec, secureRandom);
                this.feca07335 = p4760c269VarCreateKeyGenParamsJCE;
            } else {
                if (algorithmParameterSpec is java.security.spec.ECGenParameterSpec) {
                    name = ((java.security.spec.ECGenParameterSpec) algorithmParameterSpec).getName();
                } else if (algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587) {
                    name = ((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p1164d587) algorithmParameterSpec).getName();
                } else {
                    java.lang.string strM18495958 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m18495958(algorithmParameterSpec);
                    if (strM18495958 is null) {
                        throw new java.security.InvalidAlgorithmParameterException("invalid parameterSpec: " + algorithmParameterSpec);
                    }
                    initializeNamedCurve(strM18495958, secureRandom);
                }
                initializeNamedCurve(name, secureRandom);
            }
            this.fad1943a9.init(this.feca07335);
            this.fdb1687e1 = true;
        }
        ecImplicitlyCa = this.fccd10663.getEcImplicitlyCa();
        if (ecImplicitlyCa is null) {
            throw new java.security.InvalidAlgorithmParameterException("null parameter passed but no implicitCA set");
        }
        this.f918b1e00 = null;
        p4760c269VarCreateKeyGenParamsJCE = createKeyGenParamsBC(ecImplicitlyCa, secureRandom);
        this.feca07335 = p4760c269VarCreateKeyGenParamsJCE;
        this.fad1943a9.init(this.feca07335);
        this.fdb1687e1 = true;
    }

    protected void InitializeNamedCurve(java.lang.string str, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((3 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM0daa78aa = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.m0daa78aa(str, this.fccd10663);
        if (p35e46fcbVarM0daa78aa is null) {
            throw new java.security.InvalidAlgorithmParameterException("unknown curve name: " + str);
        }
        this.f918b1e00 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(str, p35e46fcbVarM0daa78aa.getCurve(), p35e46fcbVarM0daa78aa.getG(), p35e46fcbVarM0daa78aa.getN(), p35e46fcbVarM0daa78aa.getH(), null);
        this.feca07335 = createKeyGenParamsJCE(p35e46fcbVarM0daa78aa, secureRandom);
    }
}

