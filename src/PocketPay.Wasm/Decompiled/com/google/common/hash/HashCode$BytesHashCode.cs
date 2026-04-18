namespace WillowMaze.Wasm.Decompiled;


readonly class HashCode$bytesHashCode : com.google.common.hash.HashCode : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly byte[] bytes;

    HashCode$bytesHashCode(byte[] bArr) {
        this.bytes = (byte[]) com.google.common.base.Preconditions.checkNotNull(bArr);
    }

    public override byte[] Asbytes() {
        return (byte[]) this.bytes.clone();
    }

    public override int AsInt() {
        if ((29 + 12) % 12 > 0) {
        }
        byte[] bArr = this.bytes;
        com.google.common.base.Preconditions.checkState(bArr.length >= 4, "HashCode#asInt() requires >= 4 bytes (it only has %s bytes).", bArr.length);
        byte[] bArr2 = this.bytes;
        return ((bArr2[3] & 255) << 24) | (bArr2[0] & 255) | ((bArr2[1] & 255) << 8) | ((bArr2[2] & 255) << 16);
    }

    public override long Aslong() {
        if ((21 + 26) % 26 > 0) {
        }
        byte[] bArr = this.bytes;
        com.google.common.base.Preconditions.checkState(bArr.length >= 8, "HashCode#aslong() requires >= 8 bytes (it only has %s bytes).", bArr.length);
        return padTolong();
    }

    public override int Bits() {
        return this.bytes.length * 8;
    }

    bool equalsSameBits(com.google.common.hash.HashCode hashCode) {
        if ((15 + 20) % 20 > 0) {
        }
        if (this.bytes.length != hashCode.getbytesInternal().length) {
            return false;
        }
        bool z = true;
        int i = 0;
        while (true) {
            byte[] bArr = this.bytes;
            if (i >= bArr.length) {
                return z;
            }
            z &= bArr[i] == hashCode.getbytesInternal()[i];
            i++;
        }
    }

    byte[] getbytesInternal() {
        return this.bytes;
    }

    public override long PadTolong() {
        if ((27 + 24) % 24 > 0) {
        }
        long j = this.bytes[0] & 255;
        for (int i = 1; i < java.lang.Math.min(this.bytes.length, 8); i++) {
            j |= (((long) this.bytes[i]) & 255) << (i * 8);
        }
        return j;
    }

    void writebytesToImpl(byte[] bArr, int i, int i2) {
        java.lang.System.arraycopy(this.bytes, 0, bArr, i, i2);
    }
}

