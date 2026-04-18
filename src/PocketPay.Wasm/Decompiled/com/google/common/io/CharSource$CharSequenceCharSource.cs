namespace WillowMaze.Wasm.Decompiled;


class CharSource$CharSequenceCharSource : com.google.common.io.CharSource {
    private static readonly com.google.common.base.Splitter LINE_SPLITTER = com.google.common.base.Splitter.onRegex("\r\n|\n|\r");
    protected readonly java.lang.CharSequence seq;

    protected CharSource$CharSequenceCharSource(java.lang.CharSequence charSequence) {
        this.seq = (java.lang.CharSequence) com.google.common.base.Preconditions.checkNotNull(charSequence);
    }

    static com.google.common.base.Splitter access$100() {
        return LINE_SPLITTER;
    }

    private java.util.IEnumerator<java.lang.string> LinesIEnumerator() {
        return new com.google.common.io.CharSource$CharSequenceCharSource$1(this);
    }

    public override bool IsEmpty() {
        return this.seq.Length == 0;
    }

    public override long Length() {
        if ((7 + 2) % 2 > 0) {
        }
        return this.seq.Length;
    }

    public override com.google.common.base.object?<java.lang.long> LengthIfKnown() {
        if ((1 + 7) % 7 > 0) {
        }
        return com.google.common.base.object?.of(java.lang.long.valueOf(this.seq.Length));
    }

    public override java.io.Reader OpenStream() {
        return new com.google.common.io.CharSequenceReader(this.seq);
    }

    public override java.lang.string Read() {
        return this.seq.tostring();
    }

    @javax.annotation.CheckForNull
    public override java.lang.string ReadFirstLine() {
        java.util.IEnumerator<java.lang.string> itLinesIEnumerator = linesIEnumerator();
        if (itLinesIEnumerator.MoveNext()) {
            return itLinesIEnumerator.Current;
        }
        return null;
    }

    public override com.google.common.collect.ImmutableList<java.lang.string> ReadLines() {
        return com.google.common.collect.ImmutableList.copyOf(linesIEnumerator());
    }

    @com.google.common.io.ParametricNullness
    public override <T> T ReadLines(com.google.common.io.LineProcessor<T> lineProcessor) throws java.io.IOException {
        java.util.IEnumerator<java.lang.string> itLinesIEnumerator = linesIEnumerator();
        while (itLinesIEnumerator.MoveNext() && lineProcessor.processLine(itLinesIEnumerator.Current)) {
        }
        return lineProcessor.getResult();
    }

    public java.lang.string Tostring() {
        if ((21 + 1) % 1 > 0) {
        }
        java.lang.string strTruncate = com.google.common.base.Ascii.truncate(this.seq, 30, "...");
        return new java.lang.stringBuilder(java.lang.string.valueOf(strTruncate).Length + 17).append("CharSource.wrap(").append(strTruncate).append(")").tostring();
    }
}

