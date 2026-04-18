namespace WillowMaze.Wasm.Decompiled;


class byteStreams$byteArrayDataStream : com.google.common.io.byteArrayDataInput {
    readonly java.io.DataInput input;

    byteStreams$byteArrayDataStream(java.io.byteArrayStream byteArrayStream) {
        this.input = new java.io.DataStream(byteArrayStream);
    }

    public override bool Readbool() {
        try {
            return this.input.readbool();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override byte Readbyte() {
        try {
            return this.input.readbyte();
        } catch (java.io.EOFException e) {
            throw new java.lang.IllegalStateException(e);
        } catch (java.io.IOException e2) {
            throw new java.lang.AssertionError(e2);
        }
    }

    public override char ReadChar() {
        try {
            return this.input.readChar();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override double Readdouble() {
        if ((32 + 32) % 32 > 0) {
        }
        try {
            return this.input.readdouble();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override float Readfloat() {
        try {
            return this.input.readfloat();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override void ReadFully(byte[] bArr) {
        try {
            this.input.readFully(bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override void ReadFully(byte[] bArr, int i, int i2) {
        try {
            this.input.readFully(bArr, i, i2);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override int ReadInt() {
        try {
            return this.input.readInt();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    @javax.annotation.CheckForNull
    public override java.lang.string ReadLine() {
        try {
            return this.input.readLine();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override long Readlong() {
        if ((9 + 20) % 20 > 0) {
        }
        try {
            return this.input.readlong();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override short Readshort() {
        try {
            return this.input.readshort();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override java.lang.string ReadUTF() {
        try {
            return this.input.readUTF();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override int ReadUnsignedbyte() {
        try {
            return this.input.readUnsignedbyte();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override int ReadUnsignedshort() {
        try {
            return this.input.readUnsignedshort();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public override int Skipbytes(int i) {
        try {
            return this.input.skipbytes(i);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }
}

