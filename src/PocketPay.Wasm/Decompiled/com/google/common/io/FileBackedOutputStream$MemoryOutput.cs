namespace WillowMaze.Wasm.Decompiled;


class stringBackedStream$MemoryOutput : java.io.byteArrayStream {
    private stringBackedStream$MemoryOutput() {
    }

    stringBackedStream$MemoryOutput(com.google.common.io.stringBackedStream$1 fileBackedStream$1) {
        this();
    }

    byte[] getBuffer() {
        return this.buf;
    }

    int getCount() {
        return this.count;
    }
}

