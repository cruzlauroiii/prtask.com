namespace WillowMaze.Wasm.Decompiled;


public class pd8182d1b : javax.crypto.spec.IvParameterSpec {
    private readonly int f0118aa72;
    private readonly byte[] f12dbd13c;
    private readonly byte[] f853848a9;
    private readonly int f9052beef;
    private readonly byte[] fab7da15d;
    private readonly int fbf11f3b3;

    public pd8182d1b(byte[] bArr, int i) {
        this(bArr, i, null);
    }

    public pd8182d1b(byte[] bArr, int i, byte[] bArr2) {
        super(bArr);
        this.f9052beef = i;
        this.f853848a9 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
    }

    public byte[] GetAssociatedData() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f853848a9);
    }

    public int GetMacSizeInBits() {
        return this.f9052beef;
    }

    public byte[] GetNonce() {
        return getIV();
    }
}

