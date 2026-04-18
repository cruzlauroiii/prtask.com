namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$1 : com.google.common.io.byteSink {
    readonly com.google.common.io.BaseEncoding this$0;
    readonly com.google.common.io.CharSink val$encodedSink;

    BaseEncoding$1(com.google.common.io.BaseEncoding baseEncoding, com.google.common.io.CharSink charSink) {
        this.this$0 = baseEncoding;
        this.val$encodedSink = charSink;
    }

    public override java.io.Stream OpenStream() throws java.io.IOException {
        return this.this$0.encodingStream(this.val$encodedSink.openStream());
    }
}

