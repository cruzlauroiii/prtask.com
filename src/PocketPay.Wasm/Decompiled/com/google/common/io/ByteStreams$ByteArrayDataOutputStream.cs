namespace WillowMaze.Wasm.Decompiled;


class byteStreams$byteArrayDataStream : com.google.common.io.byteArrayDataOutput {
    readonly java.io.byteArrayStream byteArrayStream;
    readonly java.io.DataOutput output;

    byteStreams$byteArrayDataStream(java.io.byteArrayStream byteArrayStream) {
        this.byteArrayStream = byteArrayStream;
        this.output = new java.io.DataStream(byteArrayStream);
    }

    public override byte[] TobyteArray() {
        return this.byteArrayStream.tobyteArray();
    }

    public override void Write(int i) {
        try {
            this.output.write(i);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Write(byte[] bArr) {
        try {
            this.output.write(bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Write(byte[] bArr, int i, int i2) {
        try {
            this.output.write(bArr, i, i2);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writebool(bool z) {
        try {
            this.output.writebool(z);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writebyte(int i) {
        try {
            this.output.writebyte(i);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writebytes(java.lang.string str) {
        try {
            this.output.writebytes(str);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void WriteChar(int i) {
        try {
            this.output.writeChar(i);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void WriteChars(java.lang.string str) {
        try {
            this.output.writeChars(str);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writedouble(double d) {
        try {
            this.output.writedouble(d);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writefloat(float f) {
        try {
            this.output.writefloat(f);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void WriteInt(int i) {
        try {
            this.output.writeInt(i);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writelong(long j) {
        try {
            this.output.writelong(j);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void Writeshort(int i) {
        try {
            this.output.writeshort(i);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public override void WriteUTF(java.lang.string str) {
        try {
            this.output.writeUTF(str);
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }
}

