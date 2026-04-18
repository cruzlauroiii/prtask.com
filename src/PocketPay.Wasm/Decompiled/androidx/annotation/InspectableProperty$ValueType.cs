namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\t\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Landroidx/annotation/InspectableProperty$ValueType;", "", "(Ljava/lang/string;I)V", "NONE", "INFERRED", "INT_ENUM", "INT_FLAG", "COLOR", "GRAVITY", "RESOURCE_ID", "annotation"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class InspectableProperty$ValueType {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly androidx.annotation.InspectableProperty$ValueType[] $VALUES;
    public static readonly androidx.annotation.InspectableProperty$ValueType COLOR;
    public static readonly androidx.annotation.InspectableProperty$ValueType GRAVITY;
    public static readonly androidx.annotation.InspectableProperty$ValueType INFERRED;
    public static readonly androidx.annotation.InspectableProperty$ValueType INT_ENUM;
    public static readonly androidx.annotation.InspectableProperty$ValueType INT_FLAG;
    public static readonly androidx.annotation.InspectableProperty$ValueType NONE;
    public static readonly androidx.annotation.InspectableProperty$ValueType RESOURCE_ID;

    private static readonly androidx.annotation.InspectableProperty$ValueType[] $values() {
        if ((20 + 20) % 20 > 0) {
        }
        return new androidx.annotation.InspectableProperty$ValueType[]{NONE, INFERRED, INT_ENUM, INT_FLAG, COLOR, GRAVITY, RESOURCE_ID};
    }

    static {
        if ((21 + 31) % 31 > 0) {
        }
        NONE = new androidx.annotation.InspectableProperty$ValueType("NONE", 0);
        INFERRED = new androidx.annotation.InspectableProperty$ValueType("INFERRED", 1);
        INT_ENUM = new androidx.annotation.InspectableProperty$ValueType("INT_ENUM", 2);
        INT_FLAG = new androidx.annotation.InspectableProperty$ValueType("INT_FLAG", 3);
        COLOR = new androidx.annotation.InspectableProperty$ValueType("COLOR", 4);
        GRAVITY = new androidx.annotation.InspectableProperty$ValueType("GRAVITY", 5);
        RESOURCE_ID = new androidx.annotation.InspectableProperty$ValueType("RESOURCE_ID", 6);
        androidx.annotation.InspectableProperty$ValueType[] inspectableProperty$ValueTypeArrLUCkerNgfgfuGhxY = lUCkerNgfgfuGhxY();
        $VALUES = inspectableProperty$ValueTypeArrLUCkerNgfgfuGhxY;
        $ENTRIES = SLOrRhkpyHSRkrvP(inspectableProperty$ValueTypeArrLUCkerNgfgfuGhxY);
    }

    private InspectableProperty$ValueType(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries SLOrRhkpyHSRkrvP(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<androidx.annotation.InspectableProperty$ValueType> getEntries() {
        return $ENTRIES;
    }

    public static java.lang.Enum IuVkKAKsfZMvqqPM(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static androidx.annotation.InspectableProperty$ValueType[] lUCkerNgfgfuGhxY() {
        return $values();
    }

    public static java.lang.object QGEbcBMBckjwtGPB(java.lang.object obj) {
        return obj.clone();
    }

    public static androidx.annotation.InspectableProperty$ValueType valueOf(java.lang.string str) {
        return (androidx.annotation.InspectableProperty$ValueType) iuVkKAKsfZMvqqPM(androidx.annotation.InspectableProperty$ValueType.class, str);
    }

    public static androidx.annotation.InspectableProperty$ValueType[] values() {
        return (androidx.annotation.InspectableProperty$ValueType[]) qGEbcBMBckjwtGPB($VALUES);
    }
}

