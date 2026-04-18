namespace WillowMaze.Wasm.Decompiled;


class p4780ae5b {
    readonly byte[] f41d6ad07;
    readonly byte[][] f76310c9b;
    readonly byte[][] f8c33c5ce;
    readonly byte[] fd037a540;
    readonly byte[][] ff3a4984c;
    readonly byte[][] ff5edd354;

    p4780ae5b(byte[] bArr, byte[][] bArr2) {
        this.ff5edd354 = bArr2;
        this.f41d6ad07 = bArr;
    }

    public byte[][] GetAuthPath() {
        return this.ff5edd354;
    }

    byte[] getSK() {
        return this.f41d6ad07;
    }
}

