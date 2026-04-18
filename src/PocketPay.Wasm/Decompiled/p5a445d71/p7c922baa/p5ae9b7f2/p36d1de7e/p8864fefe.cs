namespace WillowMaze.Wasm.Decompiled;


public class p8864fefe : p5a445d71.p7c922baa.p5ae9b7f2.pc53735ef {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a f485ae9d2;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a f80c66df7;

    public p8864fefe(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        this.f80c66df7 = p4460e12aVar;
    }

    public static int NUirsmHmWfBTEFNm(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint PrsPJDOvrQkMMXwh(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static int GYwoMimAwUGGMffQ(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr, i, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a ReadKey(java.io.Stream inputStream) throws java.io.IOException {
        if ((1 + 18) % 18 > 0) {
        }
        int iNUirsmHmWfBTEFNm = (NUirsmHmWfBTEFNm(PrsPJDOvrQkMMXwh(this.f80c66df7)) + 7) / 8;
        byte[] bArr = new byte[iNUirsmHmWfBTEFNm];
        gYwoMimAwUGGMffQ(inputStream, bArr, 0, iNUirsmHmWfBTEFNm);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52(new java.math.Bigint(1, bArr), this.f80c66df7);
    }
}

