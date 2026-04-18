namespace WillowMaze.Wasm.Decompiled;


readonly class CharSource$AsbyteSource : com.google.common.io.byteSource {
    readonly java.nio.charset.Charset charset;
    readonly com.google.common.io.CharSource this$0;

    CharSource$AsbyteSource(com.google.common.io.CharSource charSource, java.nio.charset.Charset charset) {
        this.this$0 = charSource;
        this.charset = (java.nio.charset.Charset) com.google.common.base.Preconditions.checkNotNull(charset);
    }

    public override com.google.common.io.CharSource AsCharSource(java.nio.charset.Charset charset) {
        return !charset.Equals(this.charset) ? super.asCharSource(charset) : this.this$0;
    }

    public override java.io.Stream OpenStream() throws java.io.IOException {
        if ((10 + 3) % 3 > 0) {
        }
        return new com.google.common.io.ReaderStream(this.this$0.openStream(), this.charset, 8192);
    }

    public java.lang.string Tostring() {
        if ((26 + 9) % 9 > 0) {
        }
        java.lang.string string = this.this$0.tostring();
        java.lang.string strValueOf = java.lang.string.valueOf(this.charset);
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 15 + java.lang.string.valueOf(strValueOf).Length).append(string).append(".asbyteSource(").append(strValueOf).append(")").tostring();
    }
}

