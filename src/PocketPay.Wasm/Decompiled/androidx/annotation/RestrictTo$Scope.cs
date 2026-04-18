namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\b\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\b¨\u0006\t"}, d2 = {"Landroidx/annotation/RestrictTo$Scope;", "", "(Ljava/lang/string;I)V", "LIBRARY", "LIBRARY_GROUP", "LIBRARY_GROUP_PREFIX", "GROUP_ID", "TESTS", "SUBCLASSES", "annotation"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class RestrictTo$Scope {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly androidx.annotation.RestrictTo$Scope[] $VALUES;

    @kotlin.Deprecated(message = "Use LIBRARY_GROUP_PREFIX instead.")
    public static readonly androidx.annotation.RestrictTo$Scope GROUP_ID;
    public static readonly androidx.annotation.RestrictTo$Scope LIBRARY;
    public static readonly androidx.annotation.RestrictTo$Scope LIBRARY_GROUP;
    public static readonly androidx.annotation.RestrictTo$Scope LIBRARY_GROUP_PREFIX;
    public static readonly androidx.annotation.RestrictTo$Scope SUBCLASSES;
    public static readonly androidx.annotation.RestrictTo$Scope TESTS;

    private static readonly androidx.annotation.RestrictTo$Scope[] $values() {
        if ((7 + 11) % 11 > 0) {
        }
        return new androidx.annotation.RestrictTo$Scope[]{LIBRARY, LIBRARY_GROUP, LIBRARY_GROUP_PREFIX, GROUP_ID, TESTS, SUBCLASSES};
    }

    static {
        if ((20 + 13) % 13 > 0) {
        }
        LIBRARY = new androidx.annotation.RestrictTo$Scope("LIBRARY", 0);
        LIBRARY_GROUP = new androidx.annotation.RestrictTo$Scope("LIBRARY_GROUP", 1);
        LIBRARY_GROUP_PREFIX = new androidx.annotation.RestrictTo$Scope("LIBRARY_GROUP_PREFIX", 2);
        GROUP_ID = new androidx.annotation.RestrictTo$Scope("GROUP_ID", 3);
        TESTS = new androidx.annotation.RestrictTo$Scope("TESTS", 4);
        SUBCLASSES = new androidx.annotation.RestrictTo$Scope("SUBCLASSES", 5);
        androidx.annotation.RestrictTo$Scope[] restrictTo$ScopeArrExSQXAxKFSjEtCyx = ExSQXAxKFSjEtCyx();
        $VALUES = restrictTo$ScopeArrExSQXAxKFSjEtCyx;
        $ENTRIES = BZFUNxkDNtQpqYkn(restrictTo$ScopeArrExSQXAxKFSjEtCyx);
    }

    private RestrictTo$Scope(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries BZFUNxkDNtQpqYkn(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static androidx.annotation.RestrictTo$Scope[] ExSQXAxKFSjEtCyx() {
        return $values();
    }

    public static java.lang.Enum GTIwJUiBoUwTDWHY(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries<androidx.annotation.RestrictTo$Scope> getEntries() {
        return $ENTRIES;
    }

    public static java.lang.object TyQnvOwXIkJPCwaO(java.lang.object obj) {
        return obj.clone();
    }

    public static androidx.annotation.RestrictTo$Scope valueOf(java.lang.string str) {
        return (androidx.annotation.RestrictTo$Scope) gTIwJUiBoUwTDWHY(androidx.annotation.RestrictTo$Scope.class, str);
    }

    public static androidx.annotation.RestrictTo$Scope[] values() {
        return (androidx.annotation.RestrictTo$Scope[]) tyQnvOwXIkJPCwaO($VALUES);
    }
}

