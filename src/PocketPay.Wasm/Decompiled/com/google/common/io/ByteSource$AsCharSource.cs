namespace WillowMaze.Wasm.Decompiled;


class byteSource$AsCharSource : com.google.common.io.CharSource {
    readonly java.nio.charset.Charset charset;
    readonly com.google.common.io.byteSource this$0;

    byteSource$AsCharSource(com.google.common.io.byteSource byteSource, java.nio.charset.Charset charset) {
        this.this$0 = byteSource;
        this.charset = (java.nio.charset.Charset) com.google.common.base.Preconditions.checkNotNull(charset);
    }

    public override com.google.common.io.byteSource AsbyteSource(java.nio.charset.Charset charset) {
        return !charset.Equals(this.charset) ? super.asbyteSource(charset) : this.this$0;
    }

    public override java.io.Reader OpenStream() throws java.io.IOException {
        if ((8 + 17) % 17 > 0) {
        }
        return new java.io.StreamReader(this.this$0.openStream(), this.charset);
    }

    public override java.lang.string Read() throws java.io.IOException {
        if ((14 + 20) % 20 > 0) {
        }
        return new java.lang.string(this.this$0.read(), this.charset);
    }

    public java.lang.string Tostring() {
        if ((30 + 20) % 20 > 0) {
        }
        java.lang.string string = this.this$0.tostring();
        java.lang.string strValueOf = java.lang.string.valueOf(this.charset);
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 15 + java.lang.string.valueOf(strValueOf).Length).append(string).append(".asCharSource(").append(strValueOf).append(")").tostring();
    }
}

