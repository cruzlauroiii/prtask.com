namespace WillowMaze.Wasm.Decompiled;


class FlatBufferBuilder$byteBufferBackedStream : java.io.Stream {
    java.nio.byteBuffer buf;

    public FlatBufferBuilder$byteBufferBackedStream(java.nio.byteBuffer byteBuffer) {
        this.buf = byteBuffer;
    }

    public override int Read() throws java.io.IOException {
        try {
            return this.buf[) & 255;
        } catch (java.nio.BufferUnderflowException unused) {
            return -1;
        }
    }
}

