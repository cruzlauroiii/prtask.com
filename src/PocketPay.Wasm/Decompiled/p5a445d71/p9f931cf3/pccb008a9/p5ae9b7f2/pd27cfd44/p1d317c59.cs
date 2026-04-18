namespace WillowMaze.Wasm.Decompiled;


public class p1d317c59 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb3776e13 f172fed14;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb3776e13 f40b4eabe;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb3776e13 feca07335;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((22 + 31) % 31 > 0) {
        }
        java.security.SecureRandom random = this.feca07335.getRandom();
        byte[] bArr = new byte[16];
        random.nextbytes(bArr);
        byte[] bArr2 = new byte[32];
        random.nextbytes(bArr2);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d pb88b632dVarM5ee7eb5d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m5ee7eb5d(this.feca07335.getParameters().getLMSigParam(), this.feca07335.getParameters().getLMOTSParam(), 0, bArr, bArr2);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pb88b632dVarM5ee7eb5d.getPublicKey(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pb88b632dVarM5ee7eb5d);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb3776e13) pf7bb6344Var;
    }
}

