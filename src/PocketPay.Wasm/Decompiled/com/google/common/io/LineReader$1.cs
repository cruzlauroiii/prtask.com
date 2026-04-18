namespace WillowMaze.Wasm.Decompiled;


class LineReader$1 : com.google.common.io.LineBuffer {
    readonly com.google.common.io.LineReader this$0;

    LineReader$1(com.google.common.io.LineReader lineReader) {
        this.this$0 = lineReader;
    }

    protected override void HandleLine(java.lang.string str, java.lang.string str2) {
        com.google.common.io.LineReader.access$000(this.this$0).Add(str);
    }
}

