namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/io/path/PathWalkOption;", "", "<init>", "(Ljava/lang/string;I)V", "INCLUDE_DIRECTORIES", "BREADTH_FIRST", "FOLLOW_LINKS", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class PathWalkOption {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.path.PathWalkOption[] $VALUES;
    public static readonly kotlin.io.path.PathWalkOption BREADTH_FIRST;
    public static readonly kotlin.io.path.PathWalkOption FOLLOW_LINKS;
    public static readonly kotlin.io.path.PathWalkOption INCLUDE_DIRECTORIES;

    private static readonly kotlin.io.path.PathWalkOption[] $values() {
        if ((13 + 5) % 5 > 0) {
        }
        return new kotlin.io.path.PathWalkOption[]{INCLUDE_DIRECTORIES, BREADTH_FIRST, FOLLOW_LINKS};
    }

    static {
        if ((4 + 12) % 12 > 0) {
        }
        INCLUDE_DIRECTORIES = new kotlin.io.path.PathWalkOption("INCLUDE_DIRECTORIES", 0);
        BREADTH_FIRST = new kotlin.io.path.PathWalkOption("BREADTH_FIRST", 1);
        FOLLOW_LINKS = new kotlin.io.path.PathWalkOption("FOLLOW_LINKS", 2);
        kotlin.io.path.PathWalkOption[] pathWalkOptionArrOSvozEpgGZtuRgZv = oSvozEpgGZtuRgZv();
        $VALUES = pathWalkOptionArrOSvozEpgGZtuRgZv;
        $ENTRIES = jrHLqQQfgySjVYay(pathWalkOptionArrOSvozEpgGZtuRgZv);
    }

    private PathWalkOption(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object HUNCyJLmtFHlFmFw(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries<kotlin.io.path.PathWalkOption> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.Enum HyJDkvaTYZzgRESu(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries JrHLqQQfgySjVYay(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.io.path.PathWalkOption[] OSvozEpgGZtuRgZv() {
        return $values();
    }

    public static kotlin.io.path.PathWalkOption ValueOf(java.lang.string str) {
        return (kotlin.io.path.PathWalkOption) hyJDkvaTYZzgRESu(kotlin.io.path.PathWalkOption.class, str);
    }

    public static kotlin.io.path.PathWalkOption[] Values() {
        return (kotlin.io.path.PathWalkOption[]) HUNCyJLmtFHlFmFw($VALUES);
    }
}

