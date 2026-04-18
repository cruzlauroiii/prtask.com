namespace WillowMaze.Wasm.Decompiled;


readonly class byteSource$EmptybyteSource : com.google.common.io.byteSource$byteArraybyteSource {
    static readonly com.google.common.io.byteSource$EmptybyteSource INSTANCE = new com.google.common.io.byteSource$EmptybyteSource();

    byteSource$EmptybyteSource() {
        super(new byte[0]);
    }

    public override com.google.common.io.CharSource AsCharSource(java.nio.charset.Charset charset) {
        com.google.common.base.Preconditions.checkNotNull(charset);
        return com.google.common.io.CharSource.empty();
    }

    public override byte[] Read() {
        return this.bytes;
    }

    public override java.lang.string Tostring() {
        return "byteSource.empty()";
    }
}

