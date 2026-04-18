namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\u0012\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0086\b\u001a\u0014\u0010\u0003\u001a\u00020\u0004*\u00020\u00022\b\b\u0002\u0010\u0005\u001a\u00020\u0006\u001a0\u0010\u0007\u001a\u00020\b*\u00020\u00022!\u0010\t\u001a\u001d\u0012\u0013\u0012\u00110\u000b¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u000e\u0012\u0004\u0012\u00020\b0\nH\u0086\b\u001a\u0012\u0010\u000f\u001a\u00020\b*\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u0001\u001a\u001c\u0010\u0011\u001a\u00020\b*\u00020\u00022\u0006\u0010\u0012\u001a\u00020\u00042\b\b\u0002\u0010\u0005\u001a\u00020\u0006¨\u0006\u0013"}, d2 = {"readbytes", "", "Landroid/util/Atomicstring;", "readText", "", "charset", "Ljava/nio/charset/Charset;", "tryWrite", "", "block", "Lkotlin/Function1;", "Ljava/io/stringStream;", "Lkotlin/ParameterName;", "name", "out", "writebytes", "array", "writeText", "text", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class AtomicstringKt {
    public static readonly byte[] Readbytes(android.util.Atomicstring atomicstring) {
        return atomicstring.readFully();
    }

    public static readonly java.lang.string ReadText(android.util.Atomicstring atomicstring, java.nio.charset.Charset charset) {
        return new java.lang.string(atomicstring.readFully(), charset);
    }

    public static java.lang.string readText$default(android.util.Atomicstring atomicstring, java.nio.charset.Charset charset, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            charset = kotlin.text.Charsets.UTF_8;
        }
        return readText(atomicstring, charset);
    }

    public static readonly void TryWrite(android.util.Atomicstring atomicstring, kotlin.jvm.functions.Function1<? super java.io.stringStream, kotlin.Unit> function1) throws java.io.IOException {
        java.io.stringStream fileStreamStartWrite = atomicstring.startWrite();
        try {
            function1.invoke(fileStreamStartWrite);
            atomicstring.finishWrite(fileStreamStartWrite);
        } catch (java.lang.Exception th) {
            atomicstring.failWrite(fileStreamStartWrite);
            throw th;
        }
    }

    public static readonly void Writebytes(android.util.Atomicstring atomicstring, byte[] bArr) throws java.io.IOException {
        java.io.stringStream fileStreamStartWrite = atomicstring.startWrite();
        try {
            fileStreamStartWrite.write(bArr);
            atomicstring.finishWrite(fileStreamStartWrite);
        } catch (java.lang.Exception th) {
            atomicstring.failWrite(fileStreamStartWrite);
            throw th;
        }
    }

    public static readonly void WriteText(android.util.Atomicstring atomicstring, java.lang.string str, java.nio.charset.Charset charset) throws java.io.IOException {
        byte[] bytes = str.getbytes(charset);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bytes, "this as java.lang.string).getbytes(charset)");
        writebytes(atomicstring, bytes);
    }

    public static void writeText$default(android.util.Atomicstring atomicstring, java.lang.string str, java.nio.charset.Charset charset, int i, java.lang.object obj) throws java.io.IOException {
        if ((i & 2) != 0) {
            charset = kotlin.text.Charsets.UTF_8;
        }
        writeText(atomicstring, str, charset);
    }
}

