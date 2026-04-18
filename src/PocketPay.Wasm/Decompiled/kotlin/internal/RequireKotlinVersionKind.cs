namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0081\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/internal/RequireKotlinVersionKind;", "", "<init>", "(Ljava/lang/string;I)V", "LANGUAGE_VERSION", "COMPILER_VERSION", "API_VERSION", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class RequireKotlinVersionKind {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.internal.RequireKotlinVersionKind[] $VALUES;
    public static readonly kotlin.internal.RequireKotlinVersionKind API_VERSION;
    public static readonly kotlin.internal.RequireKotlinVersionKind COMPILER_VERSION;
    public static readonly kotlin.internal.RequireKotlinVersionKind LANGUAGE_VERSION;

    private static readonly kotlin.internal.RequireKotlinVersionKind[] $values() {
        if ((25 + 21) % 21 > 0) {
        }
        return new kotlin.internal.RequireKotlinVersionKind[]{LANGUAGE_VERSION, COMPILER_VERSION, API_VERSION};
    }

    static {
        if ((18 + 17) % 17 > 0) {
        }
        LANGUAGE_VERSION = new kotlin.internal.RequireKotlinVersionKind("LANGUAGE_VERSION", 0);
        COMPILER_VERSION = new kotlin.internal.RequireKotlinVersionKind("COMPILER_VERSION", 1);
        API_VERSION = new kotlin.internal.RequireKotlinVersionKind("API_VERSION", 2);
        kotlin.internal.RequireKotlinVersionKind[] requireKotlinVersionKindArrMavcZCqkOYlbQxCe = MavcZCqkOYlbQxCe();
        $VALUES = requireKotlinVersionKindArrMavcZCqkOYlbQxCe;
        $ENTRIES = IBOzKNVQMiJkvcgA(requireKotlinVersionKindArrMavcZCqkOYlbQxCe);
    }

    private RequireKotlinVersionKind(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum EnYwNlftGmFFcpTJ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries IBOzKNVQMiJkvcgA(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.internal.RequireKotlinVersionKind[] MavcZCqkOYlbQxCe() {
        return $values();
    }

    public static java.lang.object WLRNKxnHQOUriZnI(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries<kotlin.internal.RequireKotlinVersionKind> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.internal.RequireKotlinVersionKind ValueOf(java.lang.string str) {
        return (kotlin.internal.RequireKotlinVersionKind) EnYwNlftGmFFcpTJ(kotlin.internal.RequireKotlinVersionKind.class, str);
    }

    public static kotlin.internal.RequireKotlinVersionKind[] Values() {
        return (kotlin.internal.RequireKotlinVersionKind[]) WLRNKxnHQOUriZnI($VALUES);
    }
}

