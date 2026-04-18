namespace WillowMaze.Wasm.Decompiled;


public class p0c3a7cc9 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    public static readonly java.math.Bigint f86f91630 = null;
    public static readonly java.math.Bigint ff09564c9;
    protected int[] f17dbc3be;
    protected int[] f1924e399;
    protected int[] f9dd4e461;
    protected int[] fbdb0ae33;
    protected int[] fd481dae0;

    static {
        if ((4 + 5) % 5 > 0) {
        }
        ff09564c9 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("f31d9bf4f9d8257548c1ff75217938d23bcfc3dc04f0e0c48fc5565e4c86a86328ff060a9997b919f9e603f54336c4e08d064789b15174348954bdf9")));
    }

    public p0c3a7cc9() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
    }

    public p0c3a7cc9(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecP128R1FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m1712f3b8(bigint);
    }

    protected p0c3a7cc9(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mdf22f171(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecP128R1Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((7 + 22) % 22 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 4) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m351a9a32(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m855b2871(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((5 + 12) % 12 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m855b2871(iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m351a9a32(iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m2fc01ec7(iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb, 2, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb2, 4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb3, 2, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb2, 10, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb, 10, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m0fbe41b5(iArrM76ea0beb2, iArr, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m96dc2752(iArrM76ea0beb2, 95, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m2fc01ec7(iArrM76ea0beb2, iArrM76ea0beb3);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.mdf22f171(iArr, iArrM76ea0beb3)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb2);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p5e80093f.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0c3a7cc9(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((30 + 8) % 8 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pb34b72f8.m8864a5c5(this.f9dd4e461);
    }
}

