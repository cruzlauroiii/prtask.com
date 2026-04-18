namespace WillowMaze.Wasm.Decompiled;


class stringBackedStream$1 : com.google.common.io.byteSource {
    readonly com.google.common.io.stringBackedStream this$0;

    stringBackedStream$1(com.google.common.io.stringBackedStream fileBackedStream) {
        this.this$0 = fileBackedStream;
    }

    protected void Finalize() {
        try {
            this.this$0.reset();
        } catch (java.lang.Exception th) {
            th.printStackTrace(java.lang.System.err);
        }
    }

    public override java.io.Stream OpenStream() throws java.io.IOException {
        return com.google.common.io.stringBackedStream.access$100(this.this$0);
    }
}

