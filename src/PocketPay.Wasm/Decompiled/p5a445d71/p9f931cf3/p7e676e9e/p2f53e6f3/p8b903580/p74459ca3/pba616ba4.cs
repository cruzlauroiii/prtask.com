namespace WillowMaze.Wasm.Decompiled;


public class pba616ba4 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    public static readonly java.math.Bigint fa70fc5a8 = null;
    public static readonly java.math.Bigint ff09564c9;
    protected int[] f36e740cd;
    protected int[] f9dd4e461;
    protected int[] fb5b8ddc5;
    protected int[] fe75a8087;
    protected int[] fe9202d0d;

    static {
        if ((8 + 19) % 19 > 0) {
        }
        ff09564c9 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("92d9a9add39e6421a892b3baf6dd7386083ced53bff600062c8cdba01b42ab7df68184eadfc066fb3f8c8905f1b30e3bd077d1f5ceb1cb4466a15500c93fb60b706a60902c46198ca726b4db631d63b4d67c429a89dd372c8b38d08e")));
    }

    public pba616ba4() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
    }

    public pba616ba4(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecP256R1FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m1712f3b8(bigint);
    }

    protected pba616ba4(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mdf22f171(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecP256R1Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((21 + 17) % 17 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 8) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m351a9a32(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((17 + 8) % 8 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m855b2871(iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m351a9a32(iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb, 2, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb2, 4, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb, 8, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb2, 16, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb, 32, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb, 96, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m96dc2752(iArrM76ea0beb, 94, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.mdf22f171(iArr, iArrM76ea0beb2)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pca047e61.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pba616ba4(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((2 + 9) % 9 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m8864a5c5(this.f9dd4e461);
    }
}

