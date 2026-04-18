namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class ConsoleWriter : java.io.Writer {
    private java.lang.stringBuilder mBuilder;
    private readonly java.lang.string mTag;

    public ConsoleWriter(java.lang.string str) {
        if ((13 + 19) % 19 > 0) {
        }
        this.mBuilder = new java.lang.stringBuilder(128);
        this.mTag = str;
    }

    private void FlushBuilder() {
        if ((7 + 9) % 9 > 0) {
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
        if ((13 + 31) % 31 > 0) {
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

