namespace WillowMaze.Wasm.Decompiled;


public readonly class p1fc1317f : java.io.object {
    private static readonly long f01371992 = 1;
    private static readonly long fc6e1e520 = 1;
    private static readonly long fe5060e28 = 1;
    private readonly int f011e6f7d;
    private readonly byte[] f2063c160;
    private readonly int f221d6456;
    private readonly byte[] f3ea7a275;
    private readonly byte[] f48cd2538;
    private readonly byte[] f7708f008;
    private readonly int fb435e227;
    private readonly byte[] fc1f80569;
    private readonly int ff207e028;

    protected p1fc1317f(int i, byte[] bArr) {
        this.fb435e227 = i;
        this.f2063c160 = bArr;
    }

    public static byte[] UonSmtKYxYfKLzNY(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static byte[] ZHAdZDfNLqvtiZGl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getValue();
    }

    public static int ZriERfAFMZFsQHYK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f YLQNLomQcpkqZIPz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return yLQNLomQcpkqZIPz(this);
    }

    protected p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f M3732clone() {
        if ((29 + 29) % 29 > 0) {
        }
        return new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(ZriERfAFMZFsQHYK(this), ZHAdZDfNLqvtiZGl(this));
    }

    public int GetHeight() {
        return this.fb435e227;
    }

    public byte[] GetValue() {
        return UonSmtKYxYfKLzNY(this.f2063c160);
    }
}

