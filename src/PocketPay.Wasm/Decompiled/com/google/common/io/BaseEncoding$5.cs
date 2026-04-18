namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$5 : java.io.Writer {
    readonly java.io.Writer val$delegate;
    readonly java.lang.Appendable val$separatingAppendable;

    BaseEncoding$5(java.lang.Appendable appendable, java.io.Writer writer) {
        this.val$separatingAppendable = appendable;
        this.val$delegate = writer;
    }

    public override void Close() throws java.io.IOException {
        this.val$delegate.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        this.val$delegate.flush();
    }

    public override void Write(int i) throws java.io.IOException {
        this.val$separatingAppendable.append((char) i);
    }

    public override void Write(char[] cArr, int i, int i2) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }
}

