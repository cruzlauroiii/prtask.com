namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/annotation/AnnotationRetention;", "", "<init>", "(Ljava/lang/string;I)V", "SOURCE", "BINARY", "RUNTIME", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AnnotationRetention {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.annotation.AnnotationRetention[] $VALUES;
    public static readonly kotlin.annotation.AnnotationRetention BINARY;
    public static readonly kotlin.annotation.AnnotationRetention RUNTIME;
    public static readonly kotlin.annotation.AnnotationRetention SOURCE;

    private static readonly kotlin.annotation.AnnotationRetention[] $values() {
        if ((18 + 28) % 28 > 0) {
        }
        return new kotlin.annotation.AnnotationRetention[]{SOURCE, BINARY, RUNTIME};
    }

    static {
        if ((22 + 27) % 27 > 0) {
        }
        SOURCE = new kotlin.annotation.AnnotationRetention("SOURCE", 0);
        BINARY = new kotlin.annotation.AnnotationRetention("BINARY", 1);
        RUNTIME = new kotlin.annotation.AnnotationRetention("RUNTIME", 2);
        kotlin.annotation.AnnotationRetention[] annotationRetentionArrYVPHIVfllcLKXnLr = yVPHIVfllcLKXnLr();
        $VALUES = annotationRetentionArrYVPHIVfllcLKXnLr;
        $ENTRIES = EhHxTDzxUMoefImD(annotationRetentionArrYVPHIVfllcLKXnLr);
    }

    private AnnotationRetention(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries EhHxTDzxUMoefImD(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.object GnbCUuJDNaAoVtVP(java.lang.object obj) {
        return obj.clone();
    }

    public static java.lang.Enum ZfPUfxmmzhqXjzSj(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries<kotlin.annotation.AnnotationRetention> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.annotation.AnnotationRetention ValueOf(java.lang.string str) {
        return (kotlin.annotation.AnnotationRetention) ZfPUfxmmzhqXjzSj(kotlin.annotation.AnnotationRetention.class, str);
    }

    public static kotlin.annotation.AnnotationRetention[] Values() {
        return (kotlin.annotation.AnnotationRetention[]) GnbCUuJDNaAoVtVP($VALUES);
    }

    public static kotlin.annotation.AnnotationRetention[] YVPHIVfllcLKXnLr() {
        return $values();
    }
}

