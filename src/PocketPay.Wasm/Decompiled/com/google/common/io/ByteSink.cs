namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public abstract class byteSink {
    protected byteSink() {
    }

    public com.google.common.io.CharSink AsCharSink(java.nio.charset.Charset charset) {
        if ((30 + 2) % 2 > 0) {
        }
        return new com.google.common.io.byteSink$AsCharSink(this, charset, null);
    }

    public java.io.Stream OpenBufferedStream() throws java.io.IOException {
        java.io.Stream outputStreamOpenStream = openStream();
        return !(outputStreamOpenStream is java.io.BufferedStream) ? new java.io.BufferedStream(outputStreamOpenStream) : (java.io.BufferedStream) outputStreamOpenStream;
    }

    public abstract java.io.Stream OpenStream() throws java.io.IOException;

    public void Write(byte[] bArr) throws java.io.IOException {
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.Stream outputStream = (java.io.Stream) closerCreate.register(openStream());
            outputStream.write(bArr);
            outputStream.flush();
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

    public long WriteFrom(java.io.Stream inputStream) throws java.io.IOException {
        if ((29 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(inputStream);
        com.google.common.io.Closer closerCreate = com.google.common.io.Closer.create();
        try {
            java.io.Stream outputStream = (java.io.Stream) closerCreate.register(openStream());
            long jCopy = com.google.common.io.byteStreams.copy(inputStream, outputStream);
            outputStream.flush();
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
}

