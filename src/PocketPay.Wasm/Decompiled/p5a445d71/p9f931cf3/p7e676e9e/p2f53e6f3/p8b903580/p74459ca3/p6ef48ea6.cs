namespace WillowMaze.Wasm.Decompiled;


public class p6ef48ea6 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    private static readonly int[] f188ac737 = null;
    private static readonly int[] f6a8d87ff = null;
    public static readonly java.math.Bigint f8c823f9c = null;
    private static readonly int[] f8ea8cc86 = null;
    private static readonly int[] f99c85639;
    public static readonly java.math.Bigint faae176fa = null;
    private static readonly int[] fc098247e = null;
    public static readonly java.math.Bigint ff09564c9;
    protected int[] f079aba91;
    protected int[] f4dae139d;
    protected int[] f9dd4e461;

    static {
        if ((26 + 13) % 13 > 0) {
        }
        ff09564c9 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("89a88e611a89cf5bfbcde9434e035b5ce5718d8e46114436e5f59c622dffcc0a961e57ff16a847fd1cdac393198cd60124b8a99d69bbec75b52d8afd2c1d818e426bfe0e937786b883147f3088bc4c8bbd1f6755")));
        f99c85639 = new int[]{868209154, -587542221, 579297866, -1014948952, -1470801668, 514782679, -1897982644};
    }

    public p6ef48ea6() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
    }

    public p6ef48ea6(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecP224K1FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m1712f3b8(bigint);
    }

    protected p6ef48ea6(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mdf22f171(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecP224K1Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((23 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 7) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m351a9a32(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((21 + 25) % 25 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m351a9a32(iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb, iArr, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArrM76ea0beb, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb2, iArr, iArrM76ea0beb2);
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb2, 4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 3, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb4, iArrM76ea0beb, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb4, 8, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb4, iArrM76ea0beb3, iArrM76ea0beb4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb4, 4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 19, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb4, iArrM76ea0beb2);
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb2, 42, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb5, iArrM76ea0beb2, iArrM76ea0beb5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb5, 23, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb2, iArrM76ea0beb3, iArrM76ea0beb2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb2, 84, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb5, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 20, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 3, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArr, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 2, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArr, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m96dc2752(iArrM76ea0beb3, 4, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, iArrM76ea0beb, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb5);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mdf22f171(iArr, iArrM76ea0beb5)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb3);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m0fbe41b5(iArrM76ea0beb3, f99c85639, iArrM76ea0beb3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(iArrM76ea0beb3, iArrM76ea0beb5);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mdf22f171(iArr, iArrM76ea0beb5)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb3);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p43d47db1.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((17 + 5) % 5 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m8864a5c5(this.f9dd4e461);
    }
}

