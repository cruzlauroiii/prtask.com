namespace WillowMaze.Wasm.Decompiled;


public class pa01d96fa : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p4e68df7e {
    private readonly byte[] f4a484970;
    private readonly byte[] f4ecd49a6;
    private readonly byte[] f7805db72;
    private readonly byte[] f7b0bfb95;
    private readonly byte[] ffbe14519;

    public pa01d96fa(byte[] bArr) {
        super(true, null);
        if ((2 + 29) % 29 > 0) {
        }
        this.ffbe14519 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public pa01d96fa(byte[] bArr, java.lang.string str) {
        super(true, str);
        this.ffbe14519 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetKeyData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffbe14519);
    }
}

