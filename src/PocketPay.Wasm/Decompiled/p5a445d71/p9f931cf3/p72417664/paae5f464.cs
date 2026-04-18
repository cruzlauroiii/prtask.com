namespace WillowMaze.Wasm.Decompiled;


public class paae5f464 : p5a445d71.p9f931cf3.p72417664.p6a0b99c6 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f0ea7dd4d;
    private readonly char[] f5f4dcc3b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f7febd326;
    private readonly char[] fddab26f9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed fea702ec0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed fecf5e2b1;

    public paae5f464(char[] cArr, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar) {
        this.f5f4dcc3b = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(cArr);
        this.f0ea7dd4d = p63c054edVar;
    }

    public override java.lang.string GetAlgorithm() {
        return "PBKDF2";
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

