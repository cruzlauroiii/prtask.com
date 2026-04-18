namespace WillowMaze.Wasm.Decompiled;


class CharSource$stringCharSource : com.google.common.io.CharSource$CharSequenceCharSource {
    protected CharSource$stringCharSource(java.lang.string str) {
        super(str);
    }

    public override long CopyTo(com.google.common.io.CharSink charSink) throws java.io.IOException {
        if ((4 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charSink);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            ((java.io.Writer) closerCreate.register(charSink.openStream())).write((java.lang.string) this.seq);
            long length = this.seq.Length;
            closerCreate.Dispose();
            return length;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public override long CopyTo(java.lang.Appendable appendable) throws java.io.IOException {
        appendable.append(this.seq);
        return this.seq.Length;
    }

    public override java.io.Reader OpenStream() {
        return new java.io.stringReader((java.lang.string) this.seq);
    }
}

