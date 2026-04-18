namespace WillowMaze.Wasm.Decompiled;


public class pd340241f : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0a453e9f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f41ef148a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f42c28003;
    private java.security.SecureRandom f64d94cc3;
    private java.security.SecureRandom f6819e8e6;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fa7bcc72c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb5813ed3;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((15 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4();
        byte[] bArr = new byte[1088];
        this.f7ddf32e1.nextbytes(bArr);
        byte[] bArr2 = new byte[1056];
        java.lang.System.arraycopy(bArr, 32, bArr2, 0, 1024);
        p3b0c1477_p4e9e06a4.fc9e9a848 = 11;
        p3b0c1477_p4e9e06a4.f12f1774e = 0L;
        p3b0c1477_p4e9e06a4.f0aae9c6b = 0L;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477.m42339e1e(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111(this.f42c28003), bArr2, 1024, 5, bArr, p3b0c1477_p4e9e06a4, bArr2, 0);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a(bArr2, this.f42c28003.getAlgorithmName()), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa(bArr, this.f42c28003.getAlgorithmName()));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f42c28003 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed) pf7bb6344Var).getTreeDigest();
    }
}

