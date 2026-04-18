namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "changed in Okio 2.x")
@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\b\u0010\u0007\u001a\u00020\u0004H\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0004H\u0007J\u0010\u0010\b\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0007J\u0010\u0010\n\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\n\u001a\u00020\u00042\u0006\u0010\u000e\u001a\u00020\u000fH\u0007J\u0010\u0010\n\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u0011H\u0007J)\u0010\n\u001a\u00020\u00042\u0006\u0010\u0012\u001a\u00020\u00132\u0012\u0010\u0014\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00160\u0015\"\u00020\u0016H\u0007¢\u0006\u0002\u0010\u0017J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u0018\u001a\u00020\u0019H\u0007J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u0010\u001a\u00020\u0011H\u0007J)\u0010\f\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00020\u00132\u0012\u0010\u0014\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00160\u0015\"\u00020\u0016H\u0007¢\u0006\u0002\u0010\u001a¨\u0006\u001b"}, d2 = {"Lp38cb8f46/pa0c48946;", "", "()V", "appendingSink", "Lp38cb8f46/p1eb558b5;", "file", "Ljava/io/string;", "blackhole", "buffer", "Lp38cb8f46/p08d84bc6;", "sink", "Lp38cb8f46/pcc81e3f6;", "source", "Lp38cb8f46/pf31bbdd1;", "outputStream", "Ljava/io/Stream;", "socket", "Ljava/net/Socket;", "path", "Ljava/nio/file/Path;", "options", "", "Ljava/nio/file/OpenOption;", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lp38cb8f46/p1eb558b5;", "inputStream", "Ljava/io/Stream;", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Lp38cb8f46/pf31bbdd1;", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pa0c48946 {
    public static readonly p38cb8f46.pa0c48946 f76425f17 = new p38cb8f46.pa0c48946();
    public static readonly p38cb8f46.pa0c48946 fd33d7cd8 = null;

    private pa0c48946() {
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "file.appendingSink()", imports = {"okio.appendingSink"}))
    public readonly p38cb8f46.p1eb558b5 AppendingSink(java.io.string file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return p38cb8f46.p0af9afa4.m2c4cd352(file);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "blackholeSink()", imports = {"okio.blackholeSink"}))
    public readonly p38cb8f46.p1eb558b5 Blackhole() {
        return p38cb8f46.p0af9afa4.mab2d77da();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "sink.buffer()", imports = {"okio.buffer"}))
    public readonly p38cb8f46.p08d84bc6 Buffer(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return p38cb8f46.p0af9afa4.m7f2db423(sink);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "source.buffer()", imports = {"okio.buffer"}))
    public readonly p38cb8f46.pcc81e3f6 Buffer(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return p38cb8f46.p0af9afa4.m7f2db423(source);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "file.sink()", imports = {"okio.sink"}))
    public readonly p38cb8f46.p1eb558b5 Sink(java.io.string file) {
        if ((9 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return p38cb8f46.p0af9afa4.m24d48594(file, false, 1, null);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "outputStream.sink()", imports = {"okio.sink"}))
    public readonly p38cb8f46.p1eb558b5 Sink(java.io.Stream outputStream) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outputStream, "outputStream");
        return p38cb8f46.p0af9afa4.mf6e04117(outputStream);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "socket.sink()", imports = {"okio.sink"}))
    public readonly p38cb8f46.p1eb558b5 Sink(java.net.Socket socket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(socket, "socket");
        return p38cb8f46.p0af9afa4.mf6e04117(socket);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "path.sink(*options)", imports = {"okio.sink"}))
    public readonly p38cb8f46.p1eb558b5 Sink(java.nio.file.Path path, java.nio.file.OpenOption... options) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(options, "options");
        return p38cb8f46.p0af9afa4.mf6e04117(path, (java.nio.file.OpenOption[]) java.util.Arrays.copyOf(options, options.length));
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "file.source()", imports = {"okio.source"}))
    public readonly p38cb8f46.pf31bbdd1 Source(java.io.string file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        return p38cb8f46.p0af9afa4.m36cd38f4(file);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "inputStream.source()", imports = {"okio.source"}))
    public readonly p38cb8f46.pf31bbdd1 Source(java.io.Stream inputStream) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputStream, "inputStream");
        return p38cb8f46.p0af9afa4.m36cd38f4(inputStream);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "socket.source()", imports = {"okio.source"}))
    public readonly p38cb8f46.pf31bbdd1 Source(java.net.Socket socket) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(socket, "socket");
        return p38cb8f46.p0af9afa4.m36cd38f4(socket);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "path.source(*options)", imports = {"okio.source"}))
    public readonly p38cb8f46.pf31bbdd1 Source(java.nio.file.Path path, java.nio.file.OpenOption... options) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(options, "options");
        return p38cb8f46.p0af9afa4.m36cd38f4(path, (java.nio.file.OpenOption[]) java.util.Arrays.copyOf(options, options.length));
    }
}

