namespace WillowMaze.Wasm.Decompiled;


public class pa2e835d1 : java.security.KeyValueTupleGenerator {
    int f04491ee7;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa f42f5f7a5;
    int f5177790a;
    int f517b8ac8;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa f6b602bd2;
    java.security.SecureRandom f7ddf32e1;
    bool f96b3a40b;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p789f0a22 fad1943a9;
    int fb03fb481;
    int fb79caa0e;
    bool fbaa2f6d2;
    java.security.SecureRandom fbe3650d0;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa fc8a3a0d5;
    bool fdb1687e1;
    bool fe52a3202;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa feca07335;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p789f0a22 fffc1c72f;

    public pa2e835d1() {
        super("Rainbow");
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p789f0a22();
        this.f5177790a = 1024;
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((22 + 27) % 27 > 0) {
        }
        if (!this.fdb1687e1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa p30852caaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa(this.f7ddf32e1, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671(new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pa68faf01().getVi()));
            this.feca07335 = p30852caaVar;
            this.fad1943a9.init(p30852caaVar);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((2 + 9) % 9 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pa68faf01)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a RainbowParameterSpec");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa p30852caaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa(secureRandom, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671(((p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pa68faf01) algorithmParameterSpec).getVi()));
        this.feca07335 = p30852caaVar;
        this.fad1943a9.init(p30852caaVar);
        this.fdb1687e1 = true;
    }
}

