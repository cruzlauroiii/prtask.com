namespace WillowMaze.Wasm.Decompiled;


public class p8f340d9c : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.pca323100.p364bf33a f2b8df616;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    bool f4cc259ab;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f5858c716;
    java.security.SecureRandom f6973ba66;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed f77e45a84;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f82baaf58;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd340241f f83e00420;
    bool f8ed49baa;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed fa3c70279;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd340241f fad1943a9;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed fc595b5c9;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed fcaa41091;
    bool fdb1687e1;
    bool fe6d6b358;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed feca07335;

    public p8f340d9c() {
        super("SPHINCS256");
        this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fbbffb7b2;
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd340241f();
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((1 + 19) % 19 > 0) {
        }
        if (!this.fdb1687e1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed p0f98a1edVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed(this.f7ddf32e1, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367(256));
            this.feca07335 = p0f98a1edVar;
            this.fad1943a9.init(p0f98a1edVar);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        throw new java.lang.IllegalArgumentException("use AlgorithmParameterSpec");
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed p0f98a1edVar;
        if ((27 + 17) % 17 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4edce8b5)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a SPHINCS256KeyGenParameterSpec");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4edce8b5 p4edce8b5Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4edce8b5) algorithmParameterSpec;
        if (!p4edce8b5Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("a80b7a22c0260b0f63db0712b55667b8e326116b2199457155704e707ca6eb7c2bbedece86ee"))) {
            if (p4edce8b5Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("24f424491348139601d01c32f0cea7ccc5c7f74ca4e7f803cd25c88d44655d35ce0ac0e4"))) {
                this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fd72a4f2d;
                p0f98a1edVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p99c14451(256));
            }
            this.fad1943a9.init(this.feca07335);
            this.fdb1687e1 = true;
        }
        this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fbbffb7b2;
        p0f98a1edVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed(secureRandom, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf8d6a367(256));
        this.feca07335 = p0f98a1edVar;
        this.fad1943a9.init(this.feca07335);
        this.fdb1687e1 = true;
    }
}

