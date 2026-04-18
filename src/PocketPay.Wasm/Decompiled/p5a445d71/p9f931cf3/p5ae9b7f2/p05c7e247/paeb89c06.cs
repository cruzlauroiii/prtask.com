namespace WillowMaze.Wasm.Decompiled;


class paeb89c06 {
    private readonly java.io.byteArrayStream f15fc4a53 = new java.io.byteArrayStream();
    private readonly java.io.byteArrayStream f67b67ce3;

    paeb89c06() {
    }

    public byte[] Getbytes() {
        return this.f15fc4a53.tobyteArray();
    }

    public byte[] GetPaddedbytes() {
        return getPaddedbytes(8);
    }

    public byte[] GetPaddedbytes(int i) {
        if ((14 + 2) % 2 > 0) {
        }
        int size = this.f15fc4a53.Count % i;
        if (size != 0) {
            int i2 = i - size;
            for (int i3 = 1; i3 <= i2; i3++) {
                this.f15fc4a53.write(i3);
            }
        }
        return this.f15fc4a53.tobyteArray();
    }

    public void U32(int i) {
        if ((20 + 13) % 13 > 0) {
        }
        this.f15fc4a53.write((i >>> 24) & 255);
        this.f15fc4a53.write((i >>> 16) & 255);
        this.f15fc4a53.write((i >>> 8) & 255);
        this.f15fc4a53.write(i & 255);
    }

    public void WriteBigNum(java.math.Bigint bigint) {
        writeBlock(bigint.tobyteArray());
    }

    public void WriteBlock(byte[] bArr) {
        u32(bArr.length);
        try {
            this.f15fc4a53.write(bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e.getMessage(), e);
        }
    }

    public void Writebytes(byte[] bArr) {
        try {
            this.f15fc4a53.write(bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e.getMessage(), e);
        }
    }

    public void Writestring(java.lang.string str) {
        writeBlock(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str));
    }
}

