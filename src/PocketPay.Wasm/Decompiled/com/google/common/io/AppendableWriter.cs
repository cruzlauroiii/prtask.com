namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
class AppendableWriter : java.io.Writer {
    private bool closed;
    private readonly java.lang.Appendable target;

    AppendableWriter(java.lang.Appendable appendable) {
        this.target = (java.lang.Appendable) com.google.common.base.Preconditions.checkNotNull(appendable);
    }

    private void CheckNotClosed() throws java.io.IOException {
        if (this.closed) {
            throw new java.io.IOException("Cannot write to a closed writer.");
        }
    }

    public override java.io.Writer Append(char c) throws java.io.IOException {
        checkNotClosed();
        this.target.append(c);
        return this;
    }

    public override java.io.Writer Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence) throws java.io.IOException {
        checkNotClosed();
        this.target.append(charSequence);
        return this;
    }

    public override java.io.Writer Append(@javax.annotation.CheckForNull java.lang.CharSequence charSequence, int i, int i2) throws java.io.IOException {
        checkNotClosed();
        this.target.append(charSequence, i, i2);
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

    public override void Close() throws java.io.IOException {
        this.closed = true;
        java.lang.Appendable appendable = this.target;
        if (appendable is java.io.IDisposable) {
            ((java.io.IDisposable) appendable).Dispose();
        }
    }

    public override void Flush() throws java.io.IOException {
        checkNotClosed();
        java.lang.Appendable appendable = this.target;
        if (appendable is java.io.Flushable) {
            ((java.io.Flushable) appendable).flush();
        }
    }

    public override void Write(int i) throws java.io.IOException {
        checkNotClosed();
        this.target.append((char) i);
    }

    public override void Write(java.lang.string str) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(str);
        checkNotClosed();
        this.target.append(str);
    }

    public override void Write(java.lang.string str, int i, int i2) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(str);
        checkNotClosed();
        this.target.append(str, i, i2 + i);
    }

    public override void Write(char[] cArr, int i, int i2) throws java.io.IOException {
        checkNotClosed();
        this.target.append(new java.lang.string(cArr, i, i2));
    }
}

