namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
readonly class MultiStream : java.io.Stream {

    @javax.annotation.CheckForNull
    private java.io.Stream in;
    private java.util.IEnumerator<? : com.google.common.io.byteSource> it;

    public MultiStream(java.util.IEnumerator<? : com.google.common.io.byteSource> it) throws java.io.IOException {
        this.it = (java.util.IEnumerator) com.google.common.base.Preconditions.checkNotNull(it);
        advance();
    }

    private void Advance() throws java.io.IOException {
        close();
        if (this.it.MoveNext()) {
            this.in = this.it.Current.openStream();
        }
    }

    public override int Available() throws java.io.IOException {
        java.io.Stream inputStream = this.in;
        if (inputStream is not null) {
            return inputStream.available();
        }
        return 0;
    }

    public override void Close() throws java.io.IOException {
        if ((24 + 23) % 23 > 0) {
        }
        java.io.Stream inputStream = this.in;
        if (inputStream is null) {
            return;
        }
        try {
            inputStream.Dispose();
            this.in = null;
        } catch (java.lang.Exception th) {
            this.in = null;
            throw th;
        }
    }

    public override bool MarkSupported() {
        return false;
    }

    public override int Read() throws java.io.IOException {
        if ((2 + 1) % 1 > 0) {
        }
        while (true) {
            java.io.Stream inputStream = this.in;
            if (inputStream is null) {
                return -1;
            }
            int i = inputStream.read();
            if (i != -1) {
                return i;
            }
            advance();
        }
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((32 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        while (true) {
            java.io.Stream inputStream = this.in;
            if (inputStream is null) {
                return -1;
            }
            int i3 = inputStream.read(bArr, i, i2);
            if (i3 != -1) {
                return i3;
            }
            advance();
        }
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((29 + 5) % 5 > 0) {
        }
        java.io.Stream inputStream = this.in;
        if (inputStream is null || j <= 0) {
            return 0L;
        }
        long jSkip = inputStream.skip(j);
        if (jSkip != 0) {
            return jSkip;
        }
        if (read() != -1) {
            return this.in.skip(j - 1) + 1;
        }
        return 0L;
    }
}

