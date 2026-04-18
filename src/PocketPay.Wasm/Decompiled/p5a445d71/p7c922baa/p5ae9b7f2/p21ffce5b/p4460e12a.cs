namespace WillowMaze.Wasm.Decompiled;


public class p4460e12a : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private static readonly int f5ed3ac76 = 160;
    private static readonly int f799a9463 = 160;
    private static readonly int fbbe6e15c = 160;
    private java.math.Bigint f0ae266ea;
    private java.math.Bigint f110593db;
    private int f2db95e8e;
    private java.math.Bigint f363b122c;
    private java.math.Bigint f377ffc71;
    private java.math.Bigint f3b570933;
    private java.math.Bigint f638e6a8d;
    private int f6f8f5771;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f7c90b450;
    private java.math.Bigint f81bfaec9;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f860919a5;
    private java.math.Bigint f8f74defa;
    private java.math.Bigint f900268e1;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 fa617908b;
    private int fae4c9537;
    private int fb170e65a;
    private java.math.Bigint fb2f5ff47;
    private int fbb4c0ad6;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 fcba49fe2;
    private int fd22eb200;

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(bigint, bigint2, null, 0);
        if ((4 + 1) % 1 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, 0);
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i) {
        this(bigint, bigint2, bigint3, ryFIxAvsbKIvFAYL(i), i, null, null);
        if ((2 + 1) % 1 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i, int i2) {
        this(bigint, bigint2, bigint3, i, i2, null, null);
        if ((4 + 22) % 22 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i, int i2, java.math.Bigint bigint4, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var) {
        if (i2 != 0) {
            if (i2 > QRwGqnfmDZvmonhH(bigint)) {
                throw new java.lang.IllegalArgumentException("when l value specified, it must satisfy 2^(l-1) <= p");
            }
            if (i2 < i) {
                throw new java.lang.IllegalArgumentException("when l value specified, it may not be less than m value");
            }
        }
        this.fb2f5ff47 = bigint2;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint3;
        this.f6f8f5771 = i;
        this.f2db95e8e = i2;
        this.f363b122c = bigint4;
        this.fa617908b = p2d99d697Var;
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var) {
        this(bigint, bigint2, bigint3, 160, 0, bigint4, p2d99d697Var);
        if ((18 + 3) % 3 > 0) {
        }
    }

    public static java.math.Bigint AagUhVpUEohGouFl(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint JyuxgwhfSbwXFgsA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static bool NPfJzqDpiIvWXlvi(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint OsSFjEDgwthWVrpm(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getG();
    }

    public static int QRwGqnfmDZvmonhH(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint QepPGuyZVRZFogYG(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static bool RxyeAAVanHsuGVqA(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint SJfZSkToRJoyGWpU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint XLKhfnQYZCvwMjRc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint GQUSqlvxMIMGlNmS(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint HWAGPiztWvoMWOoQ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getG();
    }

    public static java.math.Bigint KFDQyTBijhPnLwtw(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    private static int Mddde675e(int i) {
        if (i == 0 || i >= 160) {
            return 160;
        }
        return i;
    }

    public static bool NZVMWLCFcCAWYXzX(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int QORUvQjOFkdHAwRP(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static int RyFIxAvsbKIvFAYL(int i) {
        return mddde675e(i);
    }

    public static java.math.Bigint VxqIAVXMgdWahmUP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static int XhQTQiqitwLOIKsA(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static int ZsEZEjjCHnCMfGwL(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 18) % 18 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a) obj;
        if (kFDQyTBijhPnLwtw(this) is null) {
            if (QepPGuyZVRZFogYG(p4460e12aVar) is not null) {
                return false;
            }
        } else if (!NPfJzqDpiIvWXlvi(AagUhVpUEohGouFl(this), SJfZSkToRJoyGWpU(p4460e12aVar))) {
            return false;
        }
        return nZVMWLCFcCAWYXzX(vxqIAVXMgdWahmUP(p4460e12aVar), this.f83878c91) && RxyeAAVanHsuGVqA(OsSFjEDgwthWVrpm(p4460e12aVar), this.fb2f5ff47);
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public java.math.Bigint GetJ() {
        return this.f363b122c;
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 GetValidationParameters() {
        return this.fa617908b;
    }

    public int HashCode() {
        if ((16 + 7) % 7 > 0) {
        }
        return (XLKhfnQYZCvwMjRc(this) is null ? 0 : xhQTQiqitwLOIKsA(gQUSqlvxMIMGlNmS(this))) ^ (qORUvQjOFkdHAwRP(JyuxgwhfSbwXFgsA(this)) ^ zsEZEjjCHnCMfGwL(hWAGPiztWvoMWOoQ(this)));
    }
}

