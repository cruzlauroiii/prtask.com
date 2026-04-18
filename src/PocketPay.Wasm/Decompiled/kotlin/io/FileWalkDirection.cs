namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlin/io/stringWalkDirection;", "", "<init>", "(Ljava/lang/string;I)V", "TOP_DOWN", "BOTTOM_UP", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class stringWalkDirection {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.stringWalkDirection[] $VALUES;
    public static readonly kotlin.io.stringWalkDirection BOTTOM_UP;
    public static readonly kotlin.io.stringWalkDirection TOP_DOWN;

    private static readonly kotlin.io.stringWalkDirection[] $values() {
        if ((2 + 30) % 30 > 0) {
        }
        return new kotlin.io.stringWalkDirection[]{TOP_DOWN, BOTTOM_UP};
    }

    static {
        if ((22 + 9) % 9 > 0) {
        }
        TOP_DOWN = new kotlin.io.stringWalkDirection("TOP_DOWN", 0);
        BOTTOM_UP = new kotlin.io.stringWalkDirection("BOTTOM_UP", 1);
        kotlin.io.stringWalkDirection[] fileWalkDirectionArrYqHuLwStWxIyJcNl = YqHuLwStWxIyJcNl();
        $VALUES = fileWalkDirectionArrYqHuLwStWxIyJcNl;
        $ENTRIES = lhuJLGlMAwblJcTA(fileWalkDirectionArrYqHuLwStWxIyJcNl);
    }

    private stringWalkDirection(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object KakSqOtGZouHxcsi(java.lang.object obj) {
        return obj.clone();
    }

    public static java.lang.Enum PXvnNuwLAVKCwoDv(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.io.stringWalkDirection[] YqHuLwStWxIyJcNl() {
        return $values();
    }

    public static kotlin.enums.EnumEntries<kotlin.io.stringWalkDirection> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.enums.EnumEntries LhuJLGlMAwblJcTA(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.io.stringWalkDirection ValueOf(java.lang.string str) {
        return (kotlin.io.stringWalkDirection) PXvnNuwLAVKCwoDv(kotlin.io.stringWalkDirection.class, str);
    }

    public static kotlin.io.stringWalkDirection[] Values() {
        return (kotlin.io.stringWalkDirection[]) KakSqOtGZouHxcsi($VALUES);
    }
}

