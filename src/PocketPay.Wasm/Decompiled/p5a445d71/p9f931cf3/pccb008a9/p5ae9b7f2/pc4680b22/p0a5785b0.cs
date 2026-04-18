namespace WillowMaze.Wasm.Decompiled;


public class p0a5785b0 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 f166e64f6;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 f98befdc2;
    private java.security.SecureRandom fc97779d6;
    private java.security.SecureRandom fd58f0260;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 fef2aac81;
    private java.security.SecureRandom ff07c6a72;

    private byte[] Mac46ada1(int i) {
        byte[] bArr = new byte[i];
        this.f7ddf32e1.nextbytes(bArr);
        return bArr;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((19 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 engine = this.f166e64f6.getEngine();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f p13dd621fVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f(mac46ada1(engine.f8d9c307c), mac46ada1(engine.f8d9c307c));
        byte[] bArrMac46ada1 = mac46ada1(engine.f8d9c307c);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 pd71bdd22Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22(bArrMac46ada1, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p90d64eeb(engine, p13dd621fVar.ffe4c0f30, bArrMac46ada1).f82e2b998);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58368a92(this.f166e64f6, pd71bdd22Var), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pfd366b6e(this.f166e64f6, p13dd621fVar, pd71bdd22Var));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f166e64f6 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p1559ebe3) pf7bb6344Var).getParameters();
    }
}

