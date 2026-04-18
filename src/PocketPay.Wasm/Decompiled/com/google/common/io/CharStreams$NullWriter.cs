namespace WillowMaze.Wasm.Decompiled;


readonly class CharStreams$NullWriter : java.io.Writer {
    private static readonly com.google.common.io.CharStreams$NullWriter INSTANCE = new com.google.common.io.CharStreams$NullWriter();

    private CharStreams$NullWriter() {
    }

    static com.google.common.io.CharStreams$NullWriter access$000() {
        return INSTANCE;
    }

    public override java.io.Writer Append(char c) {
        return this;
    }

    public override java.io.Writer Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence) {
        return this;
    }

    public override java.io.Writer Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence, int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, charSequence is not null ? charSequence.Length : "null".Length);
        return this;
    }

    public override java.lang.Appendable Append(char c) throws java.io.IOException {
        return append(c);
    }

    public override java.lang.Appendable Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence) throws java.io.IOException {
        return append(charSequence);
    }

    public override java.lang.Appendable Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence, int i, int i2) throws java.io.IOException {
        return append(charSequence, i, i2);
    }

    public override void Close() {
    }

    public override void Flush() {
    }

    public java.lang.string Tostring() {
        return "CharStreams.nullWriter()";
    }

    public override void Write(int i) {
    }

    public override void Write(java.lang.string str) {
        com.google.common.base.Preconditions.checkNotNull(str);
    }

    public override void Write(java.lang.string str, int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2 + i, str.Length);
    }

    public override void Write(char[] cArr) {
        com.google.common.base.Preconditions.checkNotNull(cArr);
    }

    public override void Write(char[] cArr, int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2 + i, cArr.length);
    }
}

