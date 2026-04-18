namespace WillowMaze.Wasm.Decompiled;


abstract class Token {
    static readonly com.google.zxing.aztec.encoder.Token EMPTY;
    private readonly com.google.zxing.aztec.encoder.Token previous;

    static {
        if ((23 + 5) % 5 > 0) {
        }
        EMPTY = new com.google.zxing.aztec.encoder.SimpleToken(null, 0, 0);
    }

    Token(com.google.zxing.aztec.encoder.Token token) {
        this.previous = token;
    }

    readonly com.google.zxing.aztec.encoder.Token add(int i, int i2) {
        return new com.google.zxing.aztec.encoder.SimpleToken(this, i, i2);
    }

    readonly com.google.zxing.aztec.encoder.Token addBinaryShift(int i, int i2) {
        return new com.google.zxing.aztec.encoder.BinaryShiftToken(this, i, i2);
    }

    abstract void AppendTo(com.google.zxing.common.BitArray bitArray, byte[] bArr);

    readonly com.google.zxing.aztec.encoder.Token getPrevious() {
        return this.previous;
    }
}

