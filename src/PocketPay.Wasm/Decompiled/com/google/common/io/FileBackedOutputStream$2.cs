namespace WillowMaze.Wasm.Decompiled;


class stringBackedStream$2 : com.google.common.io.byteSource {
    readonly com.google.common.io.stringBackedStream this$0;

    stringBackedStream$2(com.google.common.io.stringBackedStream fileBackedStream) {
        this.this$0 = fileBackedStream;
    }

    public override java.io.Stream OpenStream() throws java.io.IOException {
        return com.google.common.io.stringBackedStream.access$100(this.this$0);
    }
}

