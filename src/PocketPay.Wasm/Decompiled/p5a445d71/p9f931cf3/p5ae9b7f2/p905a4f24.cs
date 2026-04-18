namespace WillowMaze.Wasm.Decompiled;


public class p905a4f24 {
    private readonly byte[] f2714db8e;
    private readonly byte[] f43b7fb9b;
    private readonly byte[] f5ebe2294;
    private readonly byte[] f90cae957;
    private readonly byte[] f91153d7f;
    private readonly byte[] f9a472362;
    private readonly byte[] fe4586172;
    private readonly byte[] fec32bf4b;

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

