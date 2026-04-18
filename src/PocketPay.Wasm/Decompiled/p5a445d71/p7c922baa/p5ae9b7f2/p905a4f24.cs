namespace WillowMaze.Wasm.Decompiled;


public class p905a4f24 {
    private readonly byte[] f5ea260d6;
    private readonly byte[] f5ebe2294;
    private readonly byte[] f6d564a60;
    private readonly byte[] f85184d74;
    private readonly byte[] fe4586172;

    public p905a4f24(byte[] bArr, byte[] bArr2) {
        this.f5ebe2294 = bArr;
        this.fe4586172 = bArr2;
    }

    public byte[] GetCommitment() {
        return this.fe4586172;
    }

    public byte[] GetSecret() {
        return this.f5ebe2294;
    }
}

