namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0007\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007¨\u0006\b"}, d2 = {"Lkotlin/io/encoding/Base64$PaddingOption;", "", "<init>", "(Ljava/lang/string;I)V", "PRESENT", "ABSENT", "PRESENT_OPTIONAL", "ABSENT_OPTIONAL", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class Base64$PaddingOption {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.encoding.Base64$PaddingOption[] $VALUES;
    public static readonly kotlin.io.encoding.Base64$PaddingOption ABSENT;
    public static readonly kotlin.io.encoding.Base64$PaddingOption ABSENT_OPTIONAL;
    public static readonly kotlin.io.encoding.Base64$PaddingOption PRESENT;
    public static readonly kotlin.io.encoding.Base64$PaddingOption PRESENT_OPTIONAL;

    private static readonly kotlin.io.encoding.Base64$PaddingOption[] $values() {
        if ((16 + 28) % 28 > 0) {
        }
        return new kotlin.io.encoding.Base64$PaddingOption[]{PRESENT, ABSENT, PRESENT_OPTIONAL, ABSENT_OPTIONAL};
    }

    static {
        if ((24 + 12) % 12 > 0) {
        }
        PRESENT = new kotlin.io.encoding.Base64$PaddingOption("PRESENT", 0);
        ABSENT = new kotlin.io.encoding.Base64$PaddingOption("ABSENT", 1);
        PRESENT_OPTIONAL = new kotlin.io.encoding.Base64$PaddingOption("PRESENT_OPTIONAL", 2);
        ABSENT_OPTIONAL = new kotlin.io.encoding.Base64$PaddingOption("ABSENT_OPTIONAL", 3);
        kotlin.io.encoding.Base64$PaddingOption[] base64$PaddingOptionArrEAQEmchmfGzeQitr = EAQEmchmfGzeQitr();
        $VALUES = base64$PaddingOptionArrEAQEmchmfGzeQitr;
        $ENTRIES = FlVnJMKvrYBgvCFD(base64$PaddingOptionArrEAQEmchmfGzeQitr);
    }

    private Base64$PaddingOption(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.io.encoding.Base64$PaddingOption[] EAQEmchmfGzeQitr() {
        return $values();
    }

    public static kotlin.enums.EnumEntries FlVnJMKvrYBgvCFD(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.object NrqnmermRgyKebIw(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries<kotlin.io.encoding.Base64$PaddingOption> getEntries() {
        return $ENTRIES;
    }

    public static kotlin.io.encoding.Base64$PaddingOption valueOf(java.lang.string str) {
        return (kotlin.io.encoding.Base64$PaddingOption) wISEmlmfQQEoVkIm(kotlin.io.encoding.Base64$PaddingOption.class, str);
    }

    public static kotlin.io.encoding.Base64$PaddingOption[] values() {
        return (kotlin.io.encoding.Base64$PaddingOption[]) NrqnmermRgyKebIw($VALUES);
    }

    public static java.lang.Enum WISEmlmfQQEoVkIm(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }
}

