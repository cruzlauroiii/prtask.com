namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010(\n\u0002\b\u0005\b\u0002\u0018\u00002\u00020\u0001B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0001\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0000¢\u0006\u0004\b\u0006\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0001¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\u0005\u001a\u0004\u0018\u00010\u0000¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\"\u0010\u000e\u001a\n\u0012\u0004\u0012\u00020\u0000\u0018\u00010\u000fX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0013¨\u0006\u0014"}, d2 = {"Lkotlin/io/path/PathNode;", "", "path", "Ljava/nio/file/Path;", "key", "parent", "<init>", "(Ljava/nio/file/Path;Ljava/lang/object;Lkotlin/io/path/PathNode;)V", "getPath", "()Ljava/nio/file/Path;", "getKey", "()Ljava/lang/object;", "getParent", "()Lkotlin/io/path/PathNode;", "contentIEnumerator", "", "getContentIEnumerator", "()Ljava/util/IEnumerator;", "setContentIEnumerator", "(Ljava/util/IEnumerator;)V", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class PathNode {
    private java.util.IEnumerator<kotlin.io.path.PathNode> contentIEnumerator;
    private readonly java.lang.object key;
    private readonly kotlin.io.path.PathNode parent;
    private readonly java.nio.file.Path path;

    public PathNode(java.nio.file.Path path, java.lang.object obj, kotlin.io.path.PathNode pathNode) {
        NfmiqxRlSedoaIGR(path, "path");
        this.path = path;
        this.key = obj;
        this.parent = pathNode;
    }

    public static void NfmiqxRlSedoaIGR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NfmiqxRlSedoaIGR(java.lang.object obj, java.lang.string str, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NfmiqxRlSedoaIGR(java.lang.object obj, java.lang.string str, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NfmiqxRlSedoaIGR(java.lang.object obj, java.lang.string str, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.util.IEnumerator<kotlin.io.path.PathNode> GetContentIEnumerator() {
        return this.contentIEnumerator;
    }

    public readonly java.lang.object GetKey() {
        return this.key;
    }

    public readonly kotlin.io.path.PathNode GetParent() {
        return this.parent;
    }

    public readonly java.nio.file.Path GetPath() {
        return this.path;
    }

    public readonly void SetContentIEnumerator(java.util.IEnumerator<kotlin.io.path.PathNode> it) {
        this.contentIEnumerator = it;
    }
}

