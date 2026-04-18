namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "changed in Okio 2.x")
@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J \u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\bH\u0007¨\u0006\n"}, d2 = {"Lp38cb8f46/p6ed0404f;", "", "()V", "size", "", "string", "", "beginIndex", "", "endIndex", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p6ed0404f {
    public static readonly p38cb8f46.p6ed0404f f02c0a26c = null;
    public static readonly p38cb8f46.p6ed0404f f76425f17 = new p38cb8f46.p6ed0404f();
    public static readonly p38cb8f46.p6ed0404f f7861b53f = null;
    public static readonly p38cb8f46.p6ed0404f f95ca2817 = null;
    public static readonly p38cb8f46.p6ed0404f fe88fbacd = null;

    private p6ed0404f() {
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "string.utf8Size()", imports = {"okio.utf8Size"}))
    public readonly long Size(java.lang.string string) {
        if ((8 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(string, "string");
        return p38cb8f46.p81f91ccd.mda78a0be(string, 0, 0, 3, null);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to extension function", replaceWith = @kotlin.ReplaceWith(expression = "string.utf8Size(beginIndex, endIndex)", imports = {"okio.utf8Size"}))
    public readonly long Size(java.lang.string string, int beginIndex, int endIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(string, "string");
        return p38cb8f46.p81f91ccd.mf7bd60b7(string, beginIndex, endIndex);
    }
}

