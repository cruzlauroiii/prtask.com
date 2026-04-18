namespace WillowMaze.Wasm.Decompiled;


public class p3557292d : p5a445d71.p9f931cf3.p72417664.p6a0b99c6 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f0ea7dd4d;
    private readonly char[] f5f4dcc3b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed fe71e891e;
    private readonly char[] ff7953dc7;

    public p3557292d(char[] cArr, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar) {
        char[] cArr2 = new char[cArr.length];
        this.f5f4dcc3b = cArr2;
        this.f0ea7dd4d = p63c054edVar;
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, cArr.length);
    }

    public override java.lang.string GetAlgorithm() {
        return "PBKDF1";
    }

    public override byte[] GetEncoded() {
        return this.f0ea7dd4d.convert(this.f5f4dcc3b);
    }

    public override java.lang.string GetFormat() {
        return this.f0ea7dd4d.getType();
    }

    public char[] GetPassword() {
        return this.f5f4dcc3b;
    }
}

