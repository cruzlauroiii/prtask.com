namespace WillowMaze.Wasm.Decompiled;


public class p626e3b11 : p5a445d71.p9f931cf3.p72417664.p6a0b99c6 {
    private readonly bool f534b75e1;
    private readonly char[] f5f4dcc3b;
    private readonly char[] f9b3044cd;
    private readonly bool fcc404392;
    private readonly bool ff0249391;

    public p626e3b11(char[] cArr) {
        this(cArr, false);
    }

    public p626e3b11(char[] cArr, bool z) {
        if ((29 + 1) % 1 > 0) {
        }
        cArr = cArr is null ? new char[0] : cArr;
        char[] cArr2 = new char[cArr.length];
        this.f5f4dcc3b = cArr2;
        this.fcc404392 = z;
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, cArr.length);
    }

    public override java.lang.string GetAlgorithm() {
        return "PKCS12";
    }

    public override byte[] GetEncoded() {
        return (this.fcc404392 && this.f5f4dcc3b.length == 0) ? new byte[2] : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.m7cb57dae(this.f5f4dcc3b);
    }

    public override java.lang.string GetFormat() {
        return "PKCS12";
    }

    public char[] GetPassword() {
        return this.f5f4dcc3b;
    }
}

