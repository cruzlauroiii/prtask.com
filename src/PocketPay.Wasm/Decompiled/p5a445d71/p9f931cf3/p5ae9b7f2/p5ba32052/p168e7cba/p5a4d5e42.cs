namespace WillowMaze.Wasm.Decompiled;


public class p5a4d5e42 : p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 f168e7cba;
    private byte[] f16dd8311;
    private int f2496da2f;
    private int f2e76193f;
    private byte[] f36f2d639;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 f5bb936c5;
    private int f6674d3a8;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f87bb6216;
    private byte[] f886e1a24;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f98b2489c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fa27d6e6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 fca91a33c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe6785247 fd9f3f3b9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fed469618;
    private byte[] ffbade9e3;

    public p5a4d5e42(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f168e7cba = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p8f2a305e(pe5cfc515Var);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((20 + 23) % 23 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("output buffer too small");
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(this.fed469618, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 2, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2496da2f))));
        try {
            this.f168e7cba.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3(this.ffbade9e3, new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("3b98007811039412144ddd0354811f25823661e19be4df26f9e24413e39aee"))));
            return this.f168e7cba.generatebytes(bArr, i, i2);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException("unable to initialise kdf: " + e.getMessage());
        }
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.f168e7cba.getDigest();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p97b2f481 p97b2f481Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p97b2f481) p873e950bVar;
        this.fed469618 = p97b2f481Var.getAlgorithm();
        this.f2496da2f = p97b2f481Var.getKeySize();
        this.ffbade9e3 = p97b2f481Var.getZ();
    }
}

