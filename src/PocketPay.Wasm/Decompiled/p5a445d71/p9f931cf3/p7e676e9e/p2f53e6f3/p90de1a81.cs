namespace WillowMaze.Wasm.Decompiled;


public class p90de1a81 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb9ced64f {
    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((32 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        if (bigint.bitLength() > p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m0d042c55(curve)) {
            throw new java.lang.IllegalStateException("fixed-point comb doesn't support scalars larger than the curve order");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m338b9121(p53a5793fVar);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f lookupTable = p63c38610VarM338b9121.getLookupTable();
        int width = p63c38610VarM338b9121.getWidth();
        int i = ((r0 + width) - 1) / width;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = curve.getInfinity();
        int i2 = width * i;
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(i2, bigint);
        int i3 = i2 - 1;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = 0;
            for (int i6 = i3 - i4; i6 >= 0; i6 -= i) {
                int i7 = iArrM1712f3b8[i6 >>> 5] >>> (i6 & 31);
                i5 = ((i5 ^ (i7 >>> 1)) << 1) ^ i7;
            }
            infinity = infinity.twicePlus(lookupTable.lookup(i5));
        }
        return infinity.Add(p63c38610VarM338b9121.getOffset());
    }
}

