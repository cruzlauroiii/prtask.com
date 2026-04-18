namespace WillowMaze.Wasm.Decompiled;


public class p3290ef7c : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] f0f4de15a;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] f35142b10;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] f8a16ee00;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] feaef7c6b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] ffd8cac40;

    public p3290ef7c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] p936247f3VarArr, java.security.SecureRandom secureRandom) {
        super(secureRandom, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m892095ff(p936247f3VarArr[0]));
        if (p936247f3VarArr.length == 0 || p936247f3VarArr.length > 8) {
            throw new java.lang.IllegalArgumentException("lmsParameters length should be between 1 and 8 inclusive");
        }
        this.feaef7c6b = p936247f3VarArr;
    }

    public int GetDepth() {
        return this.feaef7c6b.length;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3[] GetLmsParameters() {
        return this.feaef7c6b;
    }
}

