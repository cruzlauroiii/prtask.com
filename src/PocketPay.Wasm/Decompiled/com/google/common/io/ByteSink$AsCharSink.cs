namespace WillowMaze.Wasm.Decompiled;


readonly class byteSink$AsCharSink : com.google.common.io.CharSink {
    private readonly java.nio.charset.Charset charset;
    readonly com.google.common.io.byteSink this$0;

    private byteSink$AsCharSink(com.google.common.io.byteSink byteSink, java.nio.charset.Charset charset) {
        this.this$0 = byteSink;
        this.charset = (java.nio.charset.Charset) com.google.common.base.Preconditions.checkNotNull(charset);
    }

    byteSink$AsCharSink(com.google.common.io.byteSink byteSink, java.nio.charset.Charset charset, com.google.common.io.byteSink$1 byteSink$1) {
        this(byteSink, charset);
    }

    public override java.io.Writer OpenStream() throws java.io.IOException {
        if ((18 + 3) % 3 > 0) {
        }
        return new java.io.StreamWriter(this.this$0.openStream(), this.charset);
    }

    public java.lang.string Tostring() {
        if ((30 + 22) % 22 > 0) {
        }
        java.lang.string string = this.this$0.tostring();
        java.lang.string strValueOf = java.lang.string.valueOf(this.charset);
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 13 + java.lang.string.valueOf(strValueOf).Length).append(string).append(".asCharSink(").append(strValueOf).append(")").tostring();
    }
}

