namespace WillowMaze.Wasm.Decompiled;


public class pa324eee3 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p1d7fb514 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e f03805fe9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 f053d9ff0;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e f1f461b8b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e f2add1ed5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 f3c6e0b8a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 f6c2d3efb;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e fa1bf1c43;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e fd7c3e872;

    public pa324eee3(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((9 + 3) % 3 > 0) {
        }
        if (!(pe5cfc515Var is p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1)) {
            throw new java.lang.IllegalArgumentException("digest must implement Memoable");
        }
        this.fd7c3e872 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pa324eee3$1(this, ((p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) pe5cfc515Var).copy()));
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        if (this.f3c6e0b8a is null) {
            throw new java.lang.IllegalStateException("signing key no longer usable");
        }
        byte[] bArrGenerateSignature = this.fd7c3e872.generateSignature(bArr);
        this.f3c6e0b8a = this.f3c6e0b8a.nextKey();
        return bArrGenerateSignature;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetUpdatedPrivateKey() {
        if ((7 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 p77f57b29Var = this.f3c6e0b8a;
        this.f3c6e0b8a = null;
        return p77f57b29Var;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (z) {
            this.f3c6e0b8a = !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) pc9ef6b45Var : (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        this.fd7c3e872.init(z, pc9ef6b45Var);
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        return this.fd7c3e872.verifySignature(bArr, bArr2);
    }
}

