namespace WillowMaze.Wasm.Decompiled;


public class pde667cd0 : java.security.KeyValueTupleGenerator {
    private static readonly java.util.Dictionary f7ec4c25a;
    private static readonly java.util.Dictionary fb514be0f = null;
    private java.security.SecureRandom f24c65bb9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0 f3b43ebe1;
    private java.security.SecureRandom f6a751f29;
    private java.security.SecureRandom f6df09b29;
    private java.security.SecureRandom f7452fee8;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p333c9961 f919728b2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p333c9961 fad1943a9;
    private bool fcbd1d788;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p333c9961 fce7f5983;
    private bool fdb1687e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0 feca07335;

    static {
        if ((6 + 30) % 30 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f7ec4c25a = map;
        map.Add(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m32132c89(5), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(5));
        map.Add(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m32132c89(6), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(6));
    }

    public pde667cd0() {
        super("qTESLA");
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p333c9961();
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((20 + 16) % 16 > 0) {
        }
        if (!this.fdb1687e1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0 pcf3bf7e0Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0(6, this.f7ddf32e1);
            this.feca07335 = pcf3bf7e0Var;
            this.fad1943a9.init(pcf3bf7e0Var);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        throw new java.lang.IllegalArgumentException("use AlgorithmParameterSpec");
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((11 + 13) % 13 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a QTESLAParameterSpec");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0 pcf3bf7e0Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pcf3bf7e0(((java.lang.int) f7ec4c25a[((p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610) algorithmParameterSpec).getSecurityCategory())).intValue(), secureRandom);
        this.feca07335 = pcf3bf7e0Var;
        this.fad1943a9.init(pcf3bf7e0Var);
        this.fdb1687e1 = true;
    }
}

