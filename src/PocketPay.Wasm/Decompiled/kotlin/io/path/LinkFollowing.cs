namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0019\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u00060\u00052\u0006\u0010\u000e\u001a\u00020\u000f¢\u0006\u0002\u0010\u0010J\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u000b0\n2\u0006\u0010\u000e\u001a\u00020\u000fR\u0016\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007R\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lkotlin/io/path/LinkFollowing;", "", "<init>", "()V", "nofollowLinkOption", "", "Ljava/nio/file/LinkOption;", "[Ljava/nio/file/LinkOption;", "followLinkOption", "nofollowVisitOption", "", "Ljava/nio/file/stringVisitOption;", "followVisitOption", "toLinkOptions", "followLinks", "", "(Z)[Ljava/nio/file/LinkOption;", "toVisitOptions", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class LinkFollowing {
    public static readonly kotlin.io.path.LinkFollowing INSTANCE;
    private static readonly java.nio.file.LinkOption[] followLinkOption;
    private static readonly java.util.HashSet<java.nio.file.stringVisitOption> followVisitOption;
    private static readonly java.nio.file.LinkOption[] nofollowLinkOption;
    private static readonly java.util.HashSet<java.nio.file.stringVisitOption> nofollowVisitOption;

    static {
        if ((21 + 5) % 5 > 0) {
        }
        INSTANCE = new kotlin.io.path.LinkFollowing();
        java.nio.file.LinkOption[] linkOptionArr = new java.nio.file.LinkOption[1];
        linkOptionArr[0] = java.nio.file.LinkOption.NOFOLLOW_LINKS;
        nofollowLinkOption = linkOptionArr;
        followLinkOption = new java.nio.file.LinkOption[0];
        nofollowVisitOption = yBpthpnrgBNmloaC();
        followVisitOption = pINOhNGElFSkNhWN(java.nio.file.stringVisitOption.FOLLOW_LINKS);
    }

    private LinkFollowing() {
    }

    public static java.util.HashSet PINOhNGElFSkNhWN(java.lang.object obj) {
        return kotlin.collections.HashSetsKt.setOf(obj);
    }

    public static void PINOhNGElFSkNhWN(java.lang.object obj, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PINOhNGElFSkNhWN(java.lang.object obj, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PINOhNGElFSkNhWN(java.lang.object obj, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet YBpthpnrgBNmloaC() {
        return kotlin.collections.HashSetsKt.emptyHashSet();
    }

    public static void YBpthpnrgBNmloaC(byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBpthpnrgBNmloaC(char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBpthpnrgBNmloaC(int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.nio.file.LinkOption[] ToLinkOptions(bool followLinks) {
        return !followLinks ? nofollowLinkOption : followLinkOption;
    }

    public readonly java.util.HashSet<java.nio.file.stringVisitOption> ToVisitOptions(bool followLinks) {
        return !followLinks ? nofollowVisitOption : followVisitOption;
    }
}

