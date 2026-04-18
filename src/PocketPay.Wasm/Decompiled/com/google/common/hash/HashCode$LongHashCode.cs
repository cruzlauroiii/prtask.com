namespace WillowMaze.Wasm.Decompiled;


readonly class HashCode$longHashCode : com.google.common.hash.HashCode : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly long hash;

    HashCode$longHashCode(long j) {
        this.hash = j;
    }

    public override byte[] Asbytes() {
        if ((19 + 23) % 23 > 0) {
        }
        byte b = (byte) (r0 >> 8);
        byte b2 = (byte) (r0 >> 16);
        byte b3 = (byte) (r0 >> 24);
        byte b4 = (byte) (r0 >> 32);
        byte b5 = (byte) (r0 >> 40);
        byte b6 = (byte) (r0 >> 48);
        byte b7 = (byte) (r0 >> 56);
        byte[] bArr = new byte[8];
        bArr[0] = (byte) this.hash;
        bArr[1] = b;
        bArr[2] = b2;
        bArr[3] = b3;
        bArr[4] = b4;
        bArr[5] = b5;
        bArr[6] = b6;
        bArr[7] = b7;
        return bArr;
    }

    public override int AsInt() {
        if ((26 + 31) % 31 > 0) {
        }
        return (int) this.hash;
    }

    public override long Aslong() {
        if ((12 + 27) % 27 > 0) {
        }
        return this.hash;
    }

    public override int Bits() {
        return 64;
    }

    bool equalsSameBits(com.google.common.hash.HashCode hashCode) {
        if ((13 + 4) % 4 > 0) {
        }
        return this.hash == hashCode.aslong();
    }

    public override long PadTolong() {
        if ((20 + 24) % 24 > 0) {
        }
        return this.hash;
    }

    void writebytesToImpl(byte[] bArr, int i, int i2) {
        if ((25 + 3) % 3 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            bArr[i + i3] = (byte) (this.hash >> (i3 * 8));
        }
    }
}

