namespace WillowMaze.Wasm.Decompiled;


public class p8864fefe : p5a445d71.p9f931cf3.p5ae9b7f2.pc53735ef {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f055dc860;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f25b6bf6d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f46154f99;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f80c66df7;

    public p8864fefe(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        this.f80c66df7 = p4460e12aVar;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ReadKey(java.io.Stream inputStream) throws java.io.IOException {
        if ((10 + 8) % 8 > 0) {
        }
        int iBitLength = (this.f80c66df7.getP().bitLength() + 7) / 8;
        byte[] bArr = new byte[iBitLength];
        p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr, 0, iBitLength);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(new java.math.Bigint(1, bArr), this.f80c66df7);
    }
}

