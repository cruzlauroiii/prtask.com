namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/reflect/KParameter$Kind;", "", "<init>", "(Ljava/lang/string;I)V", "INSTANCE", "EXTENSION_RECEIVER", "VALUE", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KParameter$Kind {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.reflect.KParameter$Kind[] $VALUES;
    public static readonly kotlin.reflect.KParameter$Kind EXTENSION_RECEIVER;
    public static readonly kotlin.reflect.KParameter$Kind INSTANCE;
    public static readonly kotlin.reflect.KParameter$Kind VALUE;

    private static readonly kotlin.reflect.KParameter$Kind[] $values() {
        if ((10 + 4) % 4 > 0) {
        }
        return new kotlin.reflect.KParameter$Kind[]{INSTANCE, EXTENSION_RECEIVER, VALUE};
    }

    static {
        if ((27 + 8) % 8 > 0) {
        }
        INSTANCE = new kotlin.reflect.KParameter$Kind("INSTANCE", 0);
        EXTENSION_RECEIVER = new kotlin.reflect.KParameter$Kind("EXTENSION_RECEIVER", 1);
        VALUE = new kotlin.reflect.KParameter$Kind("VALUE", 2);
        kotlin.reflect.KParameter$Kind[] kParameter$KindArrAUVSlnvhmsDjxBAu = AUVSlnvhmsDjxBAu();
        $VALUES = kParameter$KindArrAUVSlnvhmsDjxBAu;
        $ENTRIES = NxmbCcXeJhlVDkNC(kParameter$KindArrAUVSlnvhmsDjxBAu);
    }

    private KParameter$Kind(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.reflect.KParameter$Kind[] AUVSlnvhmsDjxBAu() {
        return $values();
    }

    public static kotlin.enums.EnumEntries NxmbCcXeJhlVDkNC(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<kotlin.reflect.KParameter$Kind> getEntries() {
        return $ENTRIES;
    }

    public static java.lang.object NpauwdXsDWWSzYjt(java.lang.object obj) {
        return obj.clone();
    }

    public static java.lang.Enum QGvbOgPVujCEwZux(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.reflect.KParameter$Kind valueOf(java.lang.string str) {
        return (kotlin.reflect.KParameter$Kind) qGvbOgPVujCEwZux(kotlin.reflect.KParameter$Kind.class, str);
    }

    public static kotlin.reflect.KParameter$Kind[] values() {
        return (kotlin.reflect.KParameter$Kind[]) npauwdXsDWWSzYjt($VALUES);
    }
}

