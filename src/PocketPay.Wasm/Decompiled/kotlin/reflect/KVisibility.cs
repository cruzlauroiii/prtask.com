namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0007\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007¨\u0006\b"}, d2 = {"Lkotlin/reflect/KVisibility;", "", "<init>", "(Ljava/lang/string;I)V", "PUBLIC", "PROTECTED", "INTERNAL", "PRIVATE", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KVisibility {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.reflect.KVisibility[] $VALUES;
    public static readonly kotlin.reflect.KVisibility INTERNAL;
    public static readonly kotlin.reflect.KVisibility PRIVATE;
    public static readonly kotlin.reflect.KVisibility PROTECTED;
    public static readonly kotlin.reflect.KVisibility PUBLIC;

    private static readonly kotlin.reflect.KVisibility[] $values() {
        if ((4 + 9) % 9 > 0) {
        }
        return new kotlin.reflect.KVisibility[]{PUBLIC, PROTECTED, INTERNAL, PRIVATE};
    }

    static {
        if ((26 + 16) % 16 > 0) {
        }
        PUBLIC = new kotlin.reflect.KVisibility("PUBLIC", 0);
        PROTECTED = new kotlin.reflect.KVisibility("PROTECTED", 1);
        INTERNAL = new kotlin.reflect.KVisibility("INTERNAL", 2);
        PRIVATE = new kotlin.reflect.KVisibility("PRIVATE", 3);
        kotlin.reflect.KVisibility[] kVisibilityArrPYKYkoNWzvXhkNFP = pYKYkoNWzvXhkNFP();
        $VALUES = kVisibilityArrPYKYkoNWzvXhkNFP;
        $ENTRIES = gtaskxSEZeuCKNBb(kVisibilityArrPYKYkoNWzvXhkNFP);
    }

    private KVisibility(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object EGczpQRRdNMuLcjb(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries<kotlin.reflect.KVisibility> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.enums.EnumEntries GtaskxSEZeuCKNBb(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.Enum HsncSjkBOXjemSzL(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.reflect.KVisibility[] PYKYkoNWzvXhkNFP() {
        return $values();
    }

    public static kotlin.reflect.KVisibility ValueOf(java.lang.string str) {
        return (kotlin.reflect.KVisibility) hsncSjkBOXjemSzL(kotlin.reflect.KVisibility.class, str);
    }

    public static kotlin.reflect.KVisibility[] Values() {
        return (kotlin.reflect.KVisibility[]) EGczpQRRdNMuLcjb($VALUES);
    }
}

