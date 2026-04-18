namespace WillowMaze.Wasm.Decompiled;


public class p8e011e6b : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$pf8607c41 {
    public static readonly java.math.Bigint f14565711 = null;
    public static readonly java.math.Bigint ff09564c9;
    public static readonly java.math.Bigint ff2c06df3 = null;
    protected int[] f9dd4e461;
    protected int[] fcbcacdae;

    static {
        if ((7 + 24) % 24 > 0) {
        }
        ff09564c9 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("9c53526ce4e15e955236a1ee0f202e0ea95184e892a9cbfe3d70f9360c21b64122560bf427c5485c80a0908faf9d876f42bcc37462300b496608745566fe53b37f45e1b2f91788924d8b5ba751c6e43ea415f407")));
    }

    public p8e011e6b() {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
    }

    public p8e011e6b(java.math.Bigint bigint) {
        if (bigint is null || bigint.signum() < 0 || bigint.compareTo(ff09564c9) >= 0) {
            throw new java.lang.IllegalArgumentException("x value invalid for SecP224R1FieldElement");
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m1712f3b8(bigint);
    }

    protected p8e011e6b(int[] iArr) {
        this.f9dd4e461 = iArr;
    }

    private static void M2622e9b3(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4, int[] iArr5, int[] iArr6, int[] iArr7) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr5, iArr3, iArr7);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr7, iArr, iArr7);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr4, iArr2, iArr6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m34ec78fc(iArr6, iArr7, iArr6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr4, iArr3, iArr7);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr6, iArr4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr5, iArr2, iArr5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m34ec78fc(iArr5, iArr7, iArr5);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArr5, iArr6);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr6, iArr, iArr6);
    }

    private static bool M5b222973(int[] iArr) {
        if ((9 + 17) % 17 > 0) {
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr, iArrM76ea0beb);
        for (int i = 0; i < 7; i++) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArrM76ea0beb, iArrM76ea0beb2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m96dc2752(iArrM76ea0beb, 1 << i, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m96dc2752(iArrM76ea0beb, 95, iArrM76ea0beb);
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m351a9a32(iArrM76ea0beb);
    }

    private static bool M726f0627(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((5 + 8) % 8 > 0) {
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr2, iArrM76ea0beb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        iArrM76ea0beb2[0] = 1;
        int[] iArrM76ea0beb3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        mc4cb0a6b(iArr, iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb3, iArr3);
        int[] iArrM76ea0beb4 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb5 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        for (int i = 1; i < 96; i++) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArrM76ea0beb, iArrM76ea0beb4);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArrM76ea0beb2, iArrM76ea0beb5);
            m8cee5050(iArrM76ea0beb, iArrM76ea0beb2, iArrM76ea0beb3, iArr3);
            if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(iArrM76ea0beb)) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m545f7f57(iArrM76ea0beb5, iArr3);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr3, iArrM76ea0beb4, iArr3);
                return true;
            }
        }
        return false;
    }

    private static void M8cee5050(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr2, iArr, iArr2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.macab8a08(iArr2, iArr2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArr, iArr4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m34ec78fc(iArr3, iArr4, iArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArr3, iArr4, iArr3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m4cdbfe4c(p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m63ff7439(7, iArr3, 2, 0), iArr3);
    }

    private static void Mc4cb0a6b(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4, int[] iArr5) {
        if ((17 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr, iArr4);
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        for (int i = 0; i < 7; i++) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr2, iArrM76ea0beb);
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m12cba3ee(iArr3, iArrM76ea0beb2);
            int i2 = 1 << i;
            while (true) {
                i2--;
                if (i2 < 0) {
                    break;
                } else {
                    m8cee5050(iArr2, iArr3, iArr4, iArr5);
                }
            }
            m2622e9b3(iArr, iArrM76ea0beb, iArrM76ea0beb2, iArr2, iArr3, iArr4, iArr5);
        }
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m34ec78fc(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.mfbf72fda(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m545f7f57(((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(iArrM76ea0beb, this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mdf22f171(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) obj).f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "SecP224R1Field";
    }

    public override int GetFieldSize() {
        return ff09564c9.bitLength();
    }

    public int HashCode() {
        if ((17 + 6) % 6 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9dd4e461, 0, 7) ^ ff09564c9.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m545f7f57(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override bool IsOne() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m351a9a32(this.f9dd4e461);
    }

    public override bool IsZero() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(this.f9dd4e461);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m0fbe41b5(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2d11beba(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        if ((28 + 16) % 16 > 0) {
        }
        int[] iArr = this.f9dd4e461;
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m855b2871(iArr) || p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m351a9a32(iArr)) {
            return this;
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2d11beba(iArr, iArrM76ea0beb);
        int[] iArrM7ddf32e1 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m7ddf32e1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.f44c29edb);
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        if (!m5b222973(iArr)) {
            return null;
        }
        while (!m726f0627(iArrM76ea0beb, iArrM7ddf32e1, iArrM76ea0beb2)) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.mfbf72fda(iArrM7ddf32e1, iArrM7ddf32e1);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(iArrM76ea0beb2, iArrM7ddf32e1);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mdf22f171(iArr, iArrM7ddf32e1)) {
            return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb2);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m2fc01ec7(this.f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p9cc2f788.m97f415c1(this.f9dd4e461, ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b) p5a196a0aVar).f9dd4e461, iArrM76ea0beb);
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p8e011e6b(iArrM76ea0beb);
    }

    public override bool TestBitZero() {
        if ((21 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m86de2abf(this.f9dd4e461, 0) == 1;
    }

    public override java.math.Bigint ToBigint() {
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m8864a5c5(this.f9dd4e461);
    }
}

