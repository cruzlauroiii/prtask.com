namespace WillowMaze.Wasm.Decompiled;


public class pa827ecfa$p375bd7ee : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41 {
    private static readonly int f0eb55cbe = 4;
    private static readonly int f135ef5c1 = 4;
    private static readonly int f265bb22e = 4;
    private static readonly int ff52b96b9 = 4;
    java.math.Bigint f3b2cd816;
    java.math.Bigint f463c6aa4;
    java.math.Bigint f4b43b0ae;
    java.math.Bigint f4f30a557;
    java.math.Bigint f7694f4a6;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee f888dacfc;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee fbd53cb19;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee fce56a994;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee fe173e973;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee ff2fdee93;

    public pa827ecfa$p375bd7ee(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, null, null);
        if ((13 + 18) % 18 > 0) {
        }
    }

    public pa827ecfa$p375bd7ee(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5) {
        super(bigint);
        this.f7694f4a6 = bigint;
        this.f4b43b0ae = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee.ma3c961ec(bigint);
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(this, null, null);
        this.f0cc175b9 = fromBigint(bigint2);
        this.f92eb5ffe = fromBigint(bigint3);
        this.f70a17ffa = bigint4;
        this.ff89ed0d1 = bigint5;
        this.f332de775 = 4;
    }

    protected pa827ecfa$p375bd7ee(java.math.Bigint bigint, java.math.Bigint bigint2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        super(bigint);
        this.f7694f4a6 = bigint;
        this.f4b43b0ae = bigint2;
        this.ff2fdee93 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(this, null, null);
        this.f0cc175b9 = p5a196a0aVar;
        this.f92eb5ffe = p5a196a0aVar2;
        this.f70a17ffa = bigint3;
        this.ff89ed0d1 = bigint4;
        this.f332de775 = 4;
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa CloneCurve() {
        if ((27 + 17) % 17 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, this.f0cc175b9, this.f92eb5ffe, this.f70a17ffa, this.ff89ed0d1);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(this, p5a196a0aVar, p5a196a0aVar2);
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateRawPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVarArr);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a FromBigint(java.math.Bigint bigint) {
        if ((5 + 19) % 19 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p375bd7ee(this.f7694f4a6, this.f4b43b0ae, bigint);
    }

    public override int GetFieldSize() {
        return this.f7694f4a6.bitLength();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetInfinity() {
        return this.ff2fdee93;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ImportPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        int coordinateSystem;
        if ((23 + 20) % 20 > 0) {
        }
        if (this == p53a5793fVar.getCurve() || getCoordinateSystem() != 2 || p53a5793fVar.isInfinity() || ((coordinateSystem = p53a5793fVar.getCurve().getCoordinateSystem()) != 2 && coordinateSystem != 3 && coordinateSystem != 4)) {
            return super.importPoint(p53a5793fVar);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = fromBigint(p53a5793fVar.f9dd4e461.toBigint());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint2 = fromBigint(p53a5793fVar.f41529076.toBigint());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr[0] = fromBigint(p53a5793fVar.ff6706d5d[0].toBigint());
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p375bd7ee(this, p5a196a0aVarFromBigint, p5a196a0aVarFromBigint2, p5a196a0aVarArr);
    }

    public override bool SupportsCoordinateSystem(int i) {
        return i == 0 || i == 1 || i == 2 || i == 4;
    }
}

