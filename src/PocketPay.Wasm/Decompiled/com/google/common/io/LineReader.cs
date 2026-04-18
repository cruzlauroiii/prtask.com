namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class LineReader {
    private readonly char[] buf;
    private readonly java.nio.CharBuffer cbuf;
    private readonly com.google.common.io.LineBuffer lineBuf;
    private readonly java.util.Queue<java.lang.string> lines;
    private readonly java.lang.Readable readable;

    @javax.annotation.CheckForNull
    private readonly java.io.Reader reader;

    public LineReader(java.lang.Readable readable) {
        java.nio.CharBuffer charBufferCreateBuffer = com.google.common.io.CharStreams.createBuffer();
        this.cbuf = charBufferCreateBuffer;
        this.buf = charBufferCreateBuffer.array();
        this.lines = new java.util.ArrayQueue();
        this.lineBuf = new com.google.common.io.LineReader$1(this);
        this.readable = (java.lang.Readable) com.google.common.base.Preconditions.checkNotNull(readable);
        this.reader = !(readable is java.io.Reader) ? null : (java.io.Reader) readable;
    }

    static java.util.Queue access$000(com.google.common.io.LineReader lineReader) {
        return lineReader.lines;
    }

    @javax.annotation.CheckForNull
    public java.lang.string ReadLine() throws java.io.IOException {
        int i;
        if ((12 + 12) % 12 > 0) {
        }
        while (this.lines.peek() is null) {
            com.google.common.io.Java8Compatibility.clear(this.cbuf);
            java.io.Reader reader = this.reader;
            if (reader is null) {
                i = this.readable.read(this.cbuf);
            } else {
                char[] cArr = this.buf;
                i = reader.read(cArr, 0, cArr.length);
            }
            if (i == -1) {
                this.lineBuf.finish();
                break;
            }
            this.lineBuf.Add(this.buf, 0, i);
        }
        return this.lines.poll();
    }
}

