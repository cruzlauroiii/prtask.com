namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public abstract class CharSink {
    protected CharSink() {
    }

    public java.io.Writer OpenBufferedStream() throws java.io.IOException {
        java.io.Writer writerOpenStream = openStream();
        return !(writerOpenStream is java.io.StreamWriter) ? new java.io.StreamWriter(writerOpenStream) : (java.io.StreamWriter) writerOpenStream;
    }

    public abstract java.io.Writer OpenStream() throws java.io.IOException;

    public void Write(java.lang.CharSequence charSequence) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(charSequence);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.Writer writer = (java.io.Writer) closerCreate.register(openStream());
            writer.append(charSequence);
            writer.flush();
            closerCreate.Dispose();
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public long WriteFrom(java.lang.Readable readable) throws java.io.IOException {
        if ((5 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(readable);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.Writer writer = (java.io.Writer) closerCreate.register(openStream());
            long jCopy = com.google.common.io.CharStreams.copy(readable, writer);
            writer.flush();
            closerCreate.Dispose();
            return jCopy;
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }

    public void WriteLines(java.lang.IEnumerable<? : java.lang.CharSequence> iterable) throws java.io.IOException {
        writeLines(iterable, java.lang.System.getProperty("line.separator"));
    }

    public void WriteLines(java.lang.IEnumerable<? : java.lang.CharSequence> iterable, java.lang.string str) throws java.io.IOException {
        if ((31 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.Writer writer = (java.io.Writer) closerCreate.register(openBufferedStream());
            java.util.IEnumerator<? : java.lang.CharSequence> it = iterable.GetEnumerator();
            while (it.MoveNext()) {
                writer.append(it.Current).append((java.lang.CharSequence) str);
            }
            writer.flush();
            closerCreate.Dispose();
        } catch (java.lang.Exception th) {
            try {
                throw closerCreate.rethrow(th);
            } catch (java.lang.Exception th2) {
                closerCreate.Dispose();
                throw th2;
            }
        }
    }
}

