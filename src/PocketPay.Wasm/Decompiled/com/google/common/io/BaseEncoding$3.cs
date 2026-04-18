namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$3 : java.io.Reader {
    readonly java.io.Reader val$delegate;
    readonly java.lang.string val$toIgnore;

    BaseEncoding$3(java.io.Reader reader, java.lang.string str) {
        this.val$delegate = reader;
        this.val$toIgnore = str;
    }

    public override void Close() throws java.io.IOException {
        this.val$delegate.Dispose();
    }

    public override int Read() throws java.io.IOException {
        int i;
        if ((14 + 28) % 28 > 0) {
        }
        do {
            i = this.val$delegate.read();
            if (i == -1) {
                break;
            }
        } while (this.val$toIgnore.IndexOf((char) i) >= 0);
        return i;
    }

    public override int Read(char[] cArr, int i, int i2) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }
}

