namespace WillowMaze.Wasm.Decompiled;


public class p5f5d8807 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f0023366a;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f08edd4e1;
    private readonly bool f0dafce37;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f1dd7752c;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f3b7d312e;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f5e529309;
    private readonly bool f5ec241df;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f5f5dc412;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f63bb6b10;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f646d40d9;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f6c683bc1;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f700309e0;
    private readonly bool f8f6bb089;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f910845ed;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f967e7935;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f fb7cba51d;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a ff8da9f2c;

    public p5f5d8807(bool z, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2) {
        if ((10 + 22) % 22 > 0) {
        }
        if (p06022b5aVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        if (p06022b5aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarUbYVqNbGHTdTFDsj = ubYVqNbGHTdTFDsj(p06022b5aVar);
        if (!EAsMuUjntrTrICYj(p21c2eb74VarUbYVqNbGHTdTFDsj, lXHtiOIcDToncHTL(p06022b5aVar2))) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral private keys have different domain parameters");
        }
        this.f5ec241df = z;
        this.f08edd4e1 = p06022b5aVar;
        this.f3b7d312e = ReJOTsYcBaIdIvFM(FUElKYdUSjssrZzW(TXbZdyZuKzXyaEee(p21c2eb74VarUbYVqNbGHTdTFDsj), HbBcaRPqgcBLfWhZ(p06022b5aVar)));
        this.ff8da9f2c = p06022b5aVar2;
        this.f0023366a = sXOmkhlOtpTZlMpe(baCTgtunLXMGNgTR(uVXtfgDxtNcjpvUD(p21c2eb74VarUbYVqNbGHTdTFDsj), TMPHTBOSPmdHQEZg(p06022b5aVar2)));
    }

    public static bool EAsMuUjntrTrICYj(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.lang.object obj) {
        return p21c2eb74Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f FUElKYdUSjssrZzW(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static java.math.Bigint HbBcaRPqgcBLfWhZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getD();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ReJOTsYcBaIdIvFM(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.normalize();
    }

    public static java.math.Bigint TMPHTBOSPmdHQEZg(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getD();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f TXbZdyZuKzXyaEee(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getG();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f BaCTgtunLXMGNgTR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 LXHtiOIcDToncHTL(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getParameters();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f SXOmkhlOtpTZlMpe(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.normalize();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f UVXtfgDxtNcjpvUD(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getG();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 UbYVqNbGHTdTFDsj(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getParameters();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetEphemeralPublicPoint() {
        return this.f0023366a;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a GetStaticPrivateKey() {
        return this.f08edd4e1;
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetStaticPublicPoint() {
        return this.f3b7d312e;
    }

    public bool IsInitiator() {
        return this.f5ec241df;
    }
}

