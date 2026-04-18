namespace WillowMaze.Wasm.Decompiled;


public class p3451b390 : p5a445d71.p9f931cf3.p5ae9b7f2.pc53735ef {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f4cdceb76;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f7010f79d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f8927329c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f918b1e00;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fdd192388;

    public p3451b390(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        this.f918b1e00 = p21c2eb74Var;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ReadKey(java.io.Stream inputStream) throws java.io.IOException {
        byte[] bArr;
        if ((26 + 1) % 1 > 0) {
        }
        int i = inputStream.read();
        if (i == 0) {
            throw new java.io.IOException("Sender's public key invalid.");
        }
        if (i == 2 || i == 3) {
            bArr = new byte[((this.f918b1e00.getCurve().getFieldSize() + 7) / 8) + 1];
        } else {
            if (i != 4 && i != 6 && i != 7) {
                throw new java.io.IOException("Sender's public key has invalid point encoding 0x" + java.lang.int.tostring(i, 16));
            }
            bArr = new byte[(((this.f918b1e00.getCurve().getFieldSize() + 7) / 8) * 2) + 1];
        }
        bArr[0] = (byte) i;
        p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr, 1, bArr.length - 1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(this.f918b1e00.getCurve().decodePoint(bArr), this.f918b1e00);
    }
}

