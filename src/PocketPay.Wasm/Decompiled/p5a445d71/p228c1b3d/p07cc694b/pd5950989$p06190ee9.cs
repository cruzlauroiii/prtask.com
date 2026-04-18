namespace WillowMaze.Wasm.Decompiled;


class pd5950989$p06190ee9 : p5a445d71.p228c1b3d.p07cc694b.pd5950989 {
    private static readonly long f087b92fe = 31156755687123L;
    private static readonly long f8f6119c4 = 31156755687123L;
    private static readonly long f97cc1cd4 = 31156755687123L;
    private static readonly long fc6e1e520 = 31156755687123L;
    private readonly byte fa28ba2ab;
    private readonly byte fa2b0b7df;
    private readonly byte fafba7380;
    private readonly byte fb073ee9d;

    pd5950989$p06190ee9(java.lang.string str, byte b) {
        super(str);
        this.fafba7380 = b;
    }

    private java.lang.object M73fa47c3() {
        switch (this.fafba7380) {
            case 1:
                return f8f8119ed;
            case 2:
                return f482ad595;
            case 3:
                return fc0ca8727;
            case 4:
                return f27fcc745;
            case 5:
                return f0e094219;
            case 6:
                return fa58d355d;
            case 7:
                return f40eee7eb;
            case 8:
                return f87aa2815;
            case 9:
                return f80c146de;
            case 10:
                return f310d7146;
            case 11:
                return f142ec40e;
            case 12:
                return f1c9f60b1;
            default:
                return this;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 29) % 29 > 0) {
        }
        if (this != obj) {
            return (obj is p5a445d71.p228c1b3d.p07cc694b.pd5950989$p06190ee9) && this.fafba7380 == ((p5a445d71.p228c1b3d.p07cc694b.pd5950989$p06190ee9) obj).fafba7380;
        }
        return true;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetField(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        switch (this.fafba7380) {
            case 1:
                return p7bf898deVarM5911c428.eras();
            case 2:
                return p7bf898deVarM5911c428.centuries();
            case 3:
                return p7bf898deVarM5911c428.weekyears();
            case 4:
                return p7bf898deVarM5911c428.years();
            case 5:
                return p7bf898deVarM5911c428.months();
            case 6:
                return p7bf898deVarM5911c428.weeks();
            case 7:
                return p7bf898deVarM5911c428.days();
            case 8:
                return p7bf898deVarM5911c428.halfdays();
            case 9:
                return p7bf898deVarM5911c428.hours();
            case 10:
                return p7bf898deVarM5911c428.minutes();
            case 11:
                return p7bf898deVarM5911c428.seconds();
            case 12:
                return p7bf898deVarM5911c428.millis();
            default:
                throw new java.lang.InternalError();
        }
    }

    public int HashCode() {
        return 1 << this.fafba7380;
    }
}

