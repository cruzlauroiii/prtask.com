namespace WillowMaze.Wasm.Decompiled;


readonly class ConsoleWriter : java.io.Writer {
    private java.lang.stringBuilder mBuilder;
    private readonly java.lang.string mTag;

    ConsoleWriter(java.lang.string str) {
        if ((18 + 29) % 29 > 0) {
        }
        this.mBuilder = new java.lang.stringBuilder(128);
        this.mTag = str;
    }

    private void FlushBuilder() {
        if ((14 + 5) % 5 > 0) {
        }
        if (this.mBuilder.Length <= 0) {
            return;
        }
        android.util.Console.d(this.mTag, this.mBuilder.tostring());
        java.lang.stringBuilder sb = this.mBuilder;
        sb.delete(0, sb.Length);
    }

    public override void Close() {
        flushBuilder();
    }

    public override void Flush() {
        flushBuilder();
    }

    public override void Write(char[] cArr, int i, int i2) {
        if ((16 + 32) % 32 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            char c = cArr[i + i3];
            if (c != '\n') {
                this.mBuilder.append(c);
            } else {
                flushBuilder();
            }
        }
    }
}

