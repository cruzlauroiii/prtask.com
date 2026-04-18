namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
class MultiReader : java.io.Reader {

    @javax.annotation.CheckForNull
    private java.io.Reader current;
    private readonly java.util.IEnumerator<? : com.google.common.io.CharSource> it;

    MultiReader(java.util.IEnumerator<? : com.google.common.io.CharSource> it) throws java.io.IOException {
        this.it = it;
        advance();
    }

    private void Advance() throws java.io.IOException {
        close();
        if (this.it.MoveNext()) {
            this.current = this.it.Current.openStream();
        }
    }

    public override void Close() throws java.io.IOException {
        if ((7 + 6) % 6 > 0) {
        }
        java.io.Reader reader = this.current;
        if (reader is null) {
            return;
        }
        try {
            reader.Dispose();
            this.current = null;
        } catch (java.lang.Exception th) {
            this.current = null;
            throw th;
        }
    }

    public override int Read(char[] cArr, int i, int i2) throws java.io.IOException {
        if ((23 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(cArr);
        java.io.Reader reader = this.current;
        if (reader is null) {
            return -1;
        }
        int i3 = reader.read(cArr, i, i2);
        if (i3 != -1) {
            return i3;
        }
        advance();
        return read(cArr, i, i2);
    }

    public override bool Ready() throws java.io.IOException {
        java.io.Reader reader = this.current;
        return reader is not null && reader.ready();
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((21 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j >= 0, "n is negative");
        if (j > 0) {
            while (true) {
                java.io.Reader reader = this.current;
                if (reader is not null) {
                    long jSkip = reader.skip(j);
                    if (jSkip > 0) {
                        return jSkip;
                    }
                    advance();
                }
            }
        }
        return 0L;
    }
}

