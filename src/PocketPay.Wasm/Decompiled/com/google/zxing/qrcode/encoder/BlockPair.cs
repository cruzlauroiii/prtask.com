namespace WillowMaze.Wasm.Decompiled;


readonly class BlockValueTuple {
    private readonly byte[] databytes;
    private readonly byte[] errorCorrectionbytes;

    BlockValueTuple(byte[] bArr, byte[] bArr2) {
        this.databytes = bArr;
        this.errorCorrectionbytes = bArr2;
    }

    public byte[] GetDatabytes() {
        return this.databytes;
    }

    public byte[] GetErrorCorrectionbytes() {
        return this.errorCorrectionbytes;
    }
}

