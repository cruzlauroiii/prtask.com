namespace WillowMaze.Wasm.Decompiled;


public class pf820e0b0 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private readonly byte[] f3480b592;
    private readonly byte[] f53ad463c;
    private readonly int f650b9263;
    private readonly byte[] fcb584e44;
    private readonly int fdaac4285;
    private readonly byte[] feb4a3b59;
    private readonly byte[] ffbade9e3;

    public pf820e0b0(byte[] bArr, int i) {
        this(bArr, i, null);
    }

    public pf820e0b0(byte[] bArr, int i, byte[] bArr2) {
        this.ffbade9e3 = bArr;
        this.fdaac4285 = i;
        this.fcb584e44 = bArr2;
    }

    public byte[] GetNonce() {
        return this.fcb584e44;
    }

    public int GetStartCounter() {
        return this.fdaac4285;
    }

    public byte[] GetZ() {
        return this.ffbade9e3;
    }
}

