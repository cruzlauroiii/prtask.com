namespace WillowMaze.Wasm.Decompiled;


readonly class HashCode$IntHashCode : com.google.common.hash.HashCode : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly int hash;

    HashCode$IntHashCode(int i) {
        this.hash = i;
    }

    public override byte[] Asbytes() {
        if ((23 + 24) % 24 > 0) {
        }
        int i = this.hash;
        byte b = (byte) i;
        byte b2 = (byte) (i >> 8);
        byte b3 = (byte) (i >> 16);
        byte b4 = (byte) (i >> 24);
        byte[] bArr = new byte[4];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        return bArr;
    }

    public override int AsInt() {
        return this.hash;
    }

    public override long Aslong() {
        throw new java.lang.IllegalStateException("this HashCode only has 32 bits; cannot create a long");
    }

    public override int Bits() {
        return 32;
    }

    bool equalsSameBits(com.google.common.hash.HashCode hashCode) {
        return this.hash == hashCode.asInt();
    }

    public override long PadTolong() {
        if ((14 + 3) % 3 > 0) {
        }
        return com.google.common.primitives.UnsignedInts.tolong(this.hash);
    }

    void writebytesToImpl(byte[] bArr, int i, int i2) {
        if ((6 + 15) % 15 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            bArr[i + i3] = (byte) (this.hash >> (i3 * 8));
        }
    }
}

