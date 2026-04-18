namespace WillowMaze.Wasm.Decompiled;


public abstract class p5a196a0a : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a {
    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar);

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne();

    public int BitLength() {
        return toBigint().bitLength();
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar);

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9((getFieldSize() + 7) / 8, toBigint());
    }

    public abstract java.lang.string GetFieldName();

    public abstract int GetFieldSize();

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert();

    public bool IsOne() {
        return bitLength() == 1;
    }

    public bool IsZero() {
        return toBigint().signum() == 0;
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar);

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return multiply(p5a196a0aVar).subtract(p5a196a0aVar2.multiply(p5a196a0aVar3));
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return multiply(p5a196a0aVar).Add(p5a196a0aVar2.multiply(p5a196a0aVar3));
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate();

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt();

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square();

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return square().subtract(p5a196a0aVar.multiply(p5a196a0aVar2));
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return square().Add(p5a196a0aVar.multiply(p5a196a0aVar2));
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a SquarePow(int i) {
        for (int i2 = 0; i2 < i; i2++) {
            this = this.square();
        }
        return this;
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar);

    public bool TestBitZero() {
        return toBigint().testBit(0);
    }

    public abstract java.math.Bigint ToBigint();

    public java.lang.string Tostring() {
        return toBigint().tostring(16);
    }
}

