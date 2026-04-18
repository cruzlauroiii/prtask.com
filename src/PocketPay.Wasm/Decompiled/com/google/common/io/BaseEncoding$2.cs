namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$2 : com.google.common.io.byteSource {
    readonly com.google.common.io.BaseEncoding this$0;
    readonly com.google.common.io.CharSource val$encodedSource;

    BaseEncoding$2(com.google.common.io.BaseEncoding baseEncoding, com.google.common.io.CharSource charSource) {
        this.this$0 = baseEncoding;
        this.val$encodedSource = charSource;
    }

    public override java.io.Stream OpenStream() throws java.io.IOException {
        return this.this$0.decodingStream(this.val$encodedSource.openStream());
    }
}

