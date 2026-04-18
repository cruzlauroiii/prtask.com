namespace WillowMaze.Wasm.Decompiled;


class pe1dae81f {
    readonly byte[] f3311842a;
    readonly byte[] f568d2eb2;
    readonly byte[] fadfa8784;
    readonly byte[][] fced15118;
    readonly byte[][] fe81973d7;
    readonly byte[][] ffa53b91c;
    readonly byte[] ffb161482;

    public pe1dae81f(byte[] bArr, byte[][] bArr2) {
        this.f3311842a = bArr;
        this.ffa53b91c = bArr2;
    }

    public byte[] GetWOTSSig() {
        return this.f3311842a;
    }

    public byte[][] GetXMSSAUTH() {
        return this.ffa53b91c;
    }
}

