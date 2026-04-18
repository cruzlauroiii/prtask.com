namespace WillowMaze.Wasm.Decompiled;


public class p5a196a0a$p73b12670 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p7979ad97 {
    public static readonly int f093d786e = 3;
    public static readonly int f0ea6b27c = 1;
    public static readonly int f134d4015 = 3;
    public static readonly int f225df02d = 1;
    public static readonly int f3e2ccdfb = 1;
    public static readonly int f3e67c1c2 = 3;
    public static readonly int f44fdadfd = 2;
    public static readonly int f55f40c0e = 2;
    public static readonly int f6e6dd27e = 3;
    public static readonly int f7b5913c1 = 2;
    public static readonly int f7c0dcdab = 1;
    public static readonly int f900df1d2 = 1;
    public static readonly int fcaef9c57 = 2;
    private int[] f05f39d8a;
    private int f1470bb44;
    private int f525a29f0;
    private int[] f65da27f3;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 f662e0e0e;
    private int f6f8f5771;
    private int f8c74bb1b;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 f9dd4e461;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 fa09c7ba0;
    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 fa1e2b46f;
    private int fae4e5c04;
    private int fe86da8c2;
    private int feda0a59a;
    private int fee16755a;

    p5a196a0a$p73b12670(int i, int i2, int i3, int i4, java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.bitLength() > i) {
            throw new java.lang.IllegalArgumentException("x value invalid in F2m field element");
        }
        if (i3 == 0 && i4 == 0) {
            this.fee16755a = 2;
            this.f05f39d8a = new int[]{i2};
        } else {
            if (i3 >= i4) {
                throw new java.lang.IllegalArgumentException("k2 must be smaller than k3");
            }
            if (i3 <= 0) {
                throw new java.lang.IllegalArgumentException("k2 must be larger than 0");
            }
            this.fee16755a = 3;
            this.f05f39d8a = new int[]{i2, i3, i4};
        }
        this.f6f8f5771 = i;
        this.f9dd4e461 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253(bigint);
    }

    p5a196a0a$p73b12670(int i, int[] iArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        this.f6f8f5771 = i;
        this.fee16755a = iArr.length != 1 ? 3 : 2;
        this.f05f39d8a = iArr;
        this.f9dd4e461 = p8bbd1253Var;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((27 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253) this.f9dd4e461.clone();
        p8bbd1253Var.addShiftedByWords(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461, 0);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253Var);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        if ((20 + 28) % 28 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, this.f9dd4e461.addOne());
    }

    public override int BitLength() {
        return this.f9dd4e461.degree();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return multiply(p5a196a0aVar.invert());
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 30) % 30 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670)) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) obj;
        return this.f6f8f5771 == p5a196a0a_p73b12670.f6f8f5771 && this.fee16755a == p5a196a0a_p73b12670.fee16755a && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f05f39d8a, p5a196a0a_p73b12670.f05f39d8a) && this.f9dd4e461.Equals(p5a196a0a_p73b12670.f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "F2m";
    }

    public override int GetFieldSize() {
        return this.f6f8f5771;
    }

    public int GetK1() {
        return this.f05f39d8a[0];
    }

    public int GetK2() {
        if ((18 + 7) % 7 > 0) {
        }
        int[] iArr = this.f05f39d8a;
        if (iArr.length < 2) {
            return 0;
        }
        return iArr[1];
    }

    public int GetK3() {
        if ((1 + 15) % 15 > 0) {
        }
        int[] iArr = this.f05f39d8a;
        if (iArr.length < 3) {
            return 0;
        }
        return iArr[2];
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public int GetRepresentation() {
        return this.fee16755a;
    }

    public int HashCode() {
        if ((9 + 32) % 32 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f05f39d8a) ^ (this.f9dd4e461.GetHashCode() ^ this.f6f8f5771);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        if ((20 + 4) % 4 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, this.f9dd4e461.modInverse(i, iArr));
    }

    public override bool IsOne() {
        return this.f9dd4e461.isOne();
    }

    public override bool IsZero() {
        return this.f9dd4e461.isZero();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((1 + 7) % 7 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, this.f9dd4e461.modMultiply(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461, i, iArr));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return multiplyPlusProduct(p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        if ((27 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var3 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar2).f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var4 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar3).f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarMultiply = p8bbd1253Var.multiply(p8bbd1253Var2, this.f6f8f5771, this.f05f39d8a);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarMultiply2 = p8bbd1253Var3.multiply(p8bbd1253Var4, this.f6f8f5771, this.f05f39d8a);
        if (p8bbd1253VarMultiply == p8bbd1253Var || p8bbd1253VarMultiply == p8bbd1253Var2) {
            p8bbd1253VarMultiply = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253) p8bbd1253VarMultiply.clone();
        }
        p8bbd1253VarMultiply.addShiftedByWords(p8bbd1253VarMultiply2, 0);
        p8bbd1253VarMultiply.reduce(this.f6f8f5771, this.f05f39d8a);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253VarMultiply);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        return this;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        return (this.f9dd4e461.isZero() || this.f9dd4e461.isOne()) ? this : squarePow(this.f6f8f5771 - 1);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        if ((28 + 18) % 18 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, this.f9dd4e461.modSquare(i, iArr));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return squarePlusProduct(p5a196a0aVar, p5a196a0aVar2);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((4 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = this.f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var3 = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar2).f9dd4e461;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarSquare = p8bbd1253Var.square(this.f6f8f5771, this.f05f39d8a);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarMultiply = p8bbd1253Var2.multiply(p8bbd1253Var3, this.f6f8f5771, this.f05f39d8a);
        if (p8bbd1253VarSquare == p8bbd1253Var) {
            p8bbd1253VarSquare = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253) p8bbd1253VarSquare.clone();
        }
        p8bbd1253VarSquare.addShiftedByWords(p8bbd1253VarMultiply, 0);
        p8bbd1253VarSquare.reduce(this.f6f8f5771, this.f05f39d8a);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253VarSquare);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePow(int i) {
        if ((23 + 25) % 25 > 0) {
        }
        if (i < 1) {
            return this;
        }
        int i2 = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i2, iArr, this.f9dd4e461.modSquareN(i, i2, iArr));
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return add(p5a196a0aVar);
    }

    public override bool TestBitZero() {
        return this.f9dd4e461.testBitZero();
    }

    public override java.math.Bigint ToBigint() {
        return this.f9dd4e461.toBigint();
    }
}

