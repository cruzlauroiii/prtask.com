namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    private static java.lang.object f38878df7;
    private static java.lang.object f3b236df5;
    private static java.lang.object fa1d7a7f3;
    private static java.util.Hashtable fa6117409;
    private static java.lang.object fd134470b;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 f12da1a7a;
    bool f1b17d120;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682 f28d53022;
    bool f402b3012;
    int f4ccf0264;
    int f5177790a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682 f5ab977dc;
    bool f647b6dc5;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f86020eba;
    java.security.SecureRandom f89547c29;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682 fad1943a9;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682 fb3915154;
    int fc6086e4c;
    p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682 fcbde7de8;
    bool fdb1687e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 fdb7298e4;
    int fdddd6846;
    java.security.SecureRandom feab574c6;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 feca07335;
    private static java.util.Hashtable f21ffce5b = new java.util.Hashtable();
    private static java.lang.object fdce7c417 = new java.lang.object();

    public pde667cd0() {
        super("DSA");
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p1e1fa682();
        this.f5177790a = 2048;
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0 p47a1abc0Var;
        int i;
        java.security.SecureRandom secureRandom;
        if ((20 + 17) % 17 > 0) {
        }
        if (!this.fdb1687e1) {
            java.lang.int numM1adac6f4 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(this.f5177790a);
            if (f21ffce5b.ContainsKey(numM1adac6f4)) {
                this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309) f21ffce5b[numM1adac6f4);
            } else {
                lock (fdce7c417) {
                    try {
                        if (f21ffce5b.ContainsKey(numM1adac6f4)) {
                            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309) f21ffce5b[numM1adac6f4);
                        } else {
                            int iM7702ab0e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pe65dc874.m7702ab0e(this.f5177790a);
                            int i2 = this.f5177790a;
                            if (i2 == 1024) {
                                p47a1abc0Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0();
                                if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.dsa.FIPS186-2for1024bits")) {
                                    i = this.f5177790a;
                                    secureRandom = this.f7ddf32e1;
                                    p47a1abc0Var.init(i, iM7702ab0e, secureRandom);
                                } else {
                                    p47a1abc0Var.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd(1024, 160, iM7702ab0e, this.f7ddf32e1));
                                }
                            } else if (i2 > 1024) {
                                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd peccdefbdVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd(this.f5177790a, 256, iM7702ab0e, this.f7ddf32e1);
                                p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0 p47a1abc0Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
                                p47a1abc0Var2.init(peccdefbdVar);
                                p47a1abc0Var = p47a1abc0Var2;
                            } else {
                                p47a1abc0Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0();
                                i = this.f5177790a;
                                secureRandom = this.f7ddf32e1;
                                p47a1abc0Var.init(i, iM7702ab0e, secureRandom);
                            }
                            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 pc97cd309Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309(this.f7ddf32e1, p47a1abc0Var.generateParameters());
                            this.feca07335 = pc97cd309Var;
                            f21ffce5b.Add(numM1adac6f4, pc97cd309Var);
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
            this.fad1943a9.init(this.feca07335);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        bool z;
        if ((23 + 28) % 28 > 0) {
        }
        if (i < 512 || i > 4096 || ((i < 1024 && i % 64 != 0) || (i >= 1024 && i % 1024 != 0))) {
            throw new java.security.InvalidParameterException("strength must be from 512 - 4096 and a multiple of 1024 above 1024");
        }
        java.security.spec.DSAParameterSpec dSADefaultParameters = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getDSADefaultParameters(i);
        if (dSADefaultParameters is null) {
            this.f5177790a = i;
            this.f7ddf32e1 = secureRandom;
            z = false;
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 pc97cd309Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSADefaultParameters.getP(), dSADefaultParameters.getQ(), dSADefaultParameters.getG()));
            this.feca07335 = pc97cd309Var;
            this.fad1943a9.init(pc97cd309Var);
            z = true;
        }
        this.fdb1687e1 = z;
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((27 + 13) % 13 > 0) {
        }
        if (!(algorithmParameterSpec is java.security.spec.DSAParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a DSAParameterSpec");
        }
        java.security.spec.DSAParameterSpec dSAParameterSpec = (java.security.spec.DSAParameterSpec) algorithmParameterSpec;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309 pc97cd309Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc97cd309(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSAParameterSpec.getP(), dSAParameterSpec.getQ(), dSAParameterSpec.getG()));
        this.feca07335 = pc97cd309Var;
        this.fad1943a9.init(pc97cd309Var);
        this.fdb1687e1 = true;
    }
}

