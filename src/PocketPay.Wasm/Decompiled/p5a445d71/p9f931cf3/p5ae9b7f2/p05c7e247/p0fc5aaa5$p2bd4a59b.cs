namespace WillowMaze.Wasm.Decompiled;


public readonly class p0fc5aaa5$p2bd4a59b {
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f03b80b6b;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f11dbfee1;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f17adeb6c;
    private byte[] f1a12e1f6;
    private byte[] f1cb251ec;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f29e00bbd;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 f43ea7ace;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 f599dcce2;
    private byte[] f6067f937;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 f840c4bed;
    private byte[] f85ac421a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 f8ae18a23;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 f9e2c6ca4;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fa23231d7;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fac0d22d7;
    private byte[] fb0fdc5a0;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fc4df9553;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fd871ed70;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fda63e2b5;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 ff46cff95;

    public p0fc5aaa5$p2bd4a59b(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$pa1fa2777 p0fc5aaa5_pa1fa2777, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        this.f599dcce2 = p0fc5aaa5_pa1fa2777;
        this.f17adeb6c = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr);
        this.fda63e2b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr2);
        this.f29e00bbd = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr3);
        this.ff46cff95 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr4);
    }

    private byte[] Md844b504(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5, byte[] bArr6) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr4, bArr5, bArr6));
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5 Build() {
        if ((32 + 23) % 23 > 0) {
        }
        int i = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$1.$SwitchDictionary$org$bouncycastle$crypto$util$DERMacData$Type[this.f599dcce2.ordinal()];
        if (i == 1 || i == 2) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5(md844b504(this.f599dcce2.getHeader(), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.f17adeb6c), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.fda63e2b5), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.f29e00bbd), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.ff46cff95), this.f1cb251ec), null);
        }
        if (i == 3 || i == 4) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5(md844b504(this.f599dcce2.getHeader(), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.fda63e2b5), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.f17adeb6c), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.ff46cff95), p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(this.f29e00bbd), this.f1cb251ec), null);
        }
        throw new java.lang.IllegalStateException("Unknown type encountered in build");
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0fc5aaa5$p2bd4a59b withText(byte[] bArr) {
        if ((10 + 6) % 6 > 0) {
        }
        this.f1cb251ec = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.md6c3dad7(new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr)));
        return this;
    }
}

