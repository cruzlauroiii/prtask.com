namespace WillowMaze.Wasm.Decompiled;


public class p1bfd3a52 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f293c625f = null;
    private static readonly java.math.Bigint f32dddde4 = null;
    private static readonly java.math.Bigint f531c94b2 = null;
    private static readonly java.math.Bigint f9474a222 = null;
    private static readonly java.math.Bigint f96381941 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fbf787434 = null;
    private static readonly java.math.Bigint ff2b00643 = null;
    private static readonly java.math.Bigint ff419dbbe = null;
    private java.math.Bigint f41529076;
    private java.math.Bigint f72797788;
    private java.math.Bigint f7763b57a;
    private java.math.Bigint fdc4835a3;

    static {
        if ((24 + 28) % 28 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public p1bfd3a52(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(false, p4460e12aVar);
        this.f41529076 = mf9ab0545(bigint, p4460e12aVar);
    }

    private static int Md2a7f9f4(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((9 + 24) % 24 > 0) {
        }
        int iBitLength = bigint2.bitLength();
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint);
        int[] iArrM1712f3b82 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint2);
        int length = iArrM1712f3b82.length;
        int i = 0;
        while (true) {
            int i2 = iArrM1712f3b8[0];
            if (i2 != 0) {
                int iM7fa407d1 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m7fa407d1(i2);
                if (iM7fa407d1 > 0) {
                    p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m326839af(length, iArrM1712f3b8, iM7fa407d1, 0);
                    int i3 = iArrM1712f3b82[0];
                    i ^= (iM7fa407d1 << 1) & (i3 ^ (i3 >>> 1));
                }
                int iM1f83af4e = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1f83af4e(length, iArrM1712f3b8, iArrM1712f3b82);
                if (iM1f83af4e == 0) {
                    break;
                }
                if (iM1f83af4e < 0) {
                    i ^= iArrM1712f3b8[0] & iArrM1712f3b82[0];
                    int[] iArr = iArrM1712f3b82;
                    iArrM1712f3b82 = iArrM1712f3b8;
                    iArrM1712f3b8 = iArr;
                }
                while (true) {
                    int i4 = length - 1;
                    if (iArrM1712f3b8[i4] != 0) {
                        break;
                    }
                    length = i4;
                }
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(length, iArrM1712f3b8, iArrM1712f3b82, iArrM1712f3b8);
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m75e4b9d5(length, iArrM1712f3b8, 0);
            }
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m351a9a32(length, iArrM1712f3b82)) {
            return 1 - (i & 2);
        }
        return 0;
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        if ((25 + 16) % 16 > 0) {
        }
        if (bigint is null) {
            throw new java.lang.NullPointerException("y value cannot be null");
        }
        java.math.Bigint p = p4460e12aVar.getP();
        java.math.Bigint bigint2 = f0f82d86a;
        if (bigint.compareTo(bigint2) < 0 || bigint.compareTo(p.subtract(bigint2)) > 0) {
            throw new java.lang.IllegalArgumentException("invalid DH public key");
        }
        java.math.Bigint q = p4460e12aVar.getQ();
        if (q is null || (p.testBit(0) && p.bitLength() - 1 == q.bitLength() && p.shiftRight(1).Equals(q) ? 1 == md2a7f9f4(bigint, p) : fbc21e648.Equals(bigint.modPow(q, p)))) {
            return bigint;
        }
        throw new java.lang.IllegalArgumentException("Y value does not appear to be in correct group");
    }

    public override bool Equals(java.lang.object obj) {
        if ((22 + 14) % 14 > 0) {
        }
        return (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) && ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) obj).getY().Equals(this.f41529076) && super.Equals(obj);
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }

    public override int HashCode() {
        return super.GetHashCode() ^ this.f41529076.GetHashCode();
    }
}

