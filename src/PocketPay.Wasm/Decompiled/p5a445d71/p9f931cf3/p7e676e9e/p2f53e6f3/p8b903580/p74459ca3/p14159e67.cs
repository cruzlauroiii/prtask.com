namespace WillowMaze.Wasm.Decompiled;


public class p14159e67 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    public static readonly java.math.Bigint f6b33c4c6 = null;
    public static readonly java.math.Bigint f8f243f72 = null;
    public static readonly java.math.Bigint ff09564c9;
    public static readonly java.math.Bigint ffdf0a772 = null;
    protected int[] f5cb073fe;
    protected int[] f9dd4e461;
    protected int[] fac61ae43;

    static {
        if ((26 + 18) % 18 > 0) {
        }
        ff09564c9 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("746ad8633412fd738c2092314137f7c2be6fa7684cf0274546ae2d51ea1e2aead76b21bf7120de7c549d898e9858b1d24272ea2ac9d82a1338f55227b64d027af39422d5632b9e79caf70f8cf29fbce28e3ae4d684b6612f0f2a034ee256d821ce74ca1dd64bda0dcfb091b116e1da14051e926bf03a9635a5c466ff414d0e66b692e4c1196696a60f770bc3f3093f651f9060fb4e356967caae5fd29dd73fed")));
    }

    public p14159e67() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
    }

    public p14159e67(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecP521R1FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m1712f3b8(bigint);
    }

    protected p14159e67(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(17, this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecP521R1Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((5 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 17) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m351a9a32(17, this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(17, this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((15 + 26) % 26 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(17, iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m351a9a32(17, iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m96dc2752(iArr, 519, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(17, iArr, iArrM76ea0beb2)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(17);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8517bf22.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p14159e67(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((10 + 26) % 26 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8864a5c5(17, this.f9dd4e461);
    }
}

