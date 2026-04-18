namespace WillowMaze.Wasm.Decompiled;


public class p07661f3a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p4e68df7e {
    private readonly byte[] f492fd291;
    private readonly byte[] f937bc121;
    private readonly byte[] fde176f54;
    private readonly byte[] ff20ed01b;
    private readonly byte[] ffbe14519;

    public p07661f3a(byte[] bArr) {
        super(false, null);
        if ((9 + 7) % 7 > 0) {
        }
        this.ffbe14519 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public p07661f3a(byte[] bArr, java.lang.string str) {
        super(false, str);
        this.ffbe14519 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetKeyData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffbe14519);
    }
}

