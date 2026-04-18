namespace WillowMaze.Wasm.Decompiled;


public class p760e3353 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    public static readonly java.math.Bigint f2e161a94 = null;
    private static readonly int[] f4d5d4d55 = null;
    private static readonly int[] f860b61fd = null;
    public static readonly java.math.Bigint fafaa6456 = null;
    public static readonly java.math.Bigint fc1f1477c = null;
    public static readonly java.math.Bigint fc38f6195 = null;
    protected int[] f054b337d;
    protected int[] f9dd4e461;
    protected int[] fcd95555f;
    public static readonly java.math.Bigint ff09564c9 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8864a5c5(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.f44c29edb);
    private static readonly int[] f99c85639 = {1242472624, -991028441, -1389370248, 792926214, 1039914919, 726466713, 1338105611, 730014848};

    public p760e3353() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
    }

    public p760e3353(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for Curve25519FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m1712f3b8(bigint);
    }

    protected p760e3353(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mdf22f171(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "Curve25519Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((16 + 17) % 17 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 8) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m351a9a32(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((2 + 18) % 18 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m351a9a32(iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, iArr, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb2, 3, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb3, 4, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb, 4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb3, 15, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb2, 30, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb3, 60, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb2, 11, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m96dc2752(iArrM76ea0beb3, 120, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mdf22f171(iArr, iArrM76ea0beb2)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m0fbe41b5(iArrM76ea0beb, f99c85639, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mdf22f171(iArr, iArrM76ea0beb2)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.pb3f0692e.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p6bb6375f.p760e3353(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((10 + 7) % 7 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8864a5c5(this.f9dd4e461);
    }
}

