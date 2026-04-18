namespace WillowMaze.Wasm.Decompiled;


public class peece513f : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e f0544d239;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e f0efb0825;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58368a92 f28c326cd;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e f4aa2361b;
    private java.security.SecureRandom f52b4c26a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e f77988504;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58368a92 f7fd8579f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58368a92 fccfdb194;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e fd60641ac;

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((18 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 engine = this.f4aa2361b.getParameters().getEngine();
        byte[] bArr2 = new byte[engine.f8d9c307c];
        java.security.SecureRandom secureRandom = this.f7ddf32e1;
        if (secureRandom is not null) {
            secureRandom.nextbytes(bArr2);
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e p58fdc63eVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e(engine);
        byte[] bArrPRF_msg = engine.PRF_msg(this.f4aa2361b.f41d6ad07.fd21713e9, bArr2, bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216 p0e9f4216VarH_msg = engine.H_msg(bArrPRF_msg, this.f4aa2361b.f1cd3c693.ffe4c0f30, this.f4aa2361b.f1cd3c693.f63a9f0ea, bArr);
        byte[] bArr3 = p0e9f4216VarH_msg.fc10f7796;
        long j = p0e9f4216VarH_msg.f67a7182d;
        int i = p0e9f4216VarH_msg.f122b5fc8;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea();
        p8f5875eaVar.setType(3);
        p8f5875eaVar.setTreeAddress(j);
        p8f5875eaVar.setKeyValueTupleAddress(i);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] p4780ae5bVarArrSign = p58fdc63eVar.sign(bArr3, this.f4aa2361b.f41d6ad07.ffe4c0f30, this.f4aa2361b.f1cd3c693.ffe4c0f30, p8f5875eaVar);
        byte[] bArrPkFromSig = p58fdc63eVar.pkFromSig(p4780ae5bVarArrSign, bArr3, this.f4aa2361b.f1cd3c693.ffe4c0f30, p8f5875eaVar);
        new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea().setType(2);
        byte[] bArrSign = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p90d64eeb(engine, this.f4aa2361b.getSeed(), this.f4aa2361b.getPublicSeed()).sign(bArrPkFromSig, j, i);
        int length = p4780ae5bVarArrSign.length;
        byte[][] bArr4 = new byte[length + 2][];
        int i2 = 0;
        bArr4[0] = bArrPRF_msg;
        while (i2 != p4780ae5bVarArrSign.length) {
            int i3 = i2 + 1;
            bArr4[i3] = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p4780ae5bVarArrSign[i2].f41d6ad07, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p4780ae5bVarArrSign[i2].ff5edd354));
            i2 = i3;
        }
        bArr4[length + 1] = bArrSign;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr4);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!z) {
            this.f28c326cd = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58368a92) pc9ef6b45Var;
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
                this.f4aa2361b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e) pc9ef6b45Var;
                return;
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f4aa2361b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e) p4715f007Var.getParameters();
            this.f7ddf32e1 = p4715f007Var.getRandom();
        }
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((27 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 engine = this.f28c326cd.getParameters().getEngine();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8e409325 p8e409325Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8e409325(engine.f8d9c307c, engine.fa5f3c6a1, engine.f7fc56270, engine.ff623e75a, engine.f6032edb9, engine.f85f8e4a2, bArr2);
        byte[] r = p8e409325Var.getR();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] sig_fors = p8e409325Var.getSIG_FORS();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] sig_ht = p8e409325Var.getSIG_HT();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216 p0e9f4216VarH_msg = engine.H_msg(r, this.f28c326cd.getSeed(), this.f28c326cd.getRoot(), bArr);
        byte[] bArr3 = p0e9f4216VarH_msg.fc10f7796;
        long j = p0e9f4216VarH_msg.f67a7182d;
        int i = p0e9f4216VarH_msg.f122b5fc8;
        p8f5875eaVar.setLayerAddress(0);
        p8f5875eaVar.setTreeAddress(j);
        p8f5875eaVar.setType(3);
        p8f5875eaVar.setKeyValueTupleAddress(i);
        byte[] bArrPkFromSig = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e(engine).pkFromSig(sig_fors, bArr3, this.f28c326cd.getSeed(), p8f5875eaVar);
        p8f5875eaVar.setType(2);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p90d64eeb(engine, null, this.f28c326cd.getSeed()).verify(bArrPkFromSig, sig_ht, this.f28c326cd.getSeed(), j, i, this.f28c326cd.getRoot());
    }
}

