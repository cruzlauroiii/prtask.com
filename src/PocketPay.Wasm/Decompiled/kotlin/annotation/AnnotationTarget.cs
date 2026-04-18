namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0012\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000bj\u0002\b\fj\u0002\b\rj\u0002\b\u000ej\u0002\b\u000fj\u0002\b\u0010j\u0002\b\u0011j\u0002\b\u0012¨\u0006\u0013"}, d2 = {"Lkotlin/annotation/AnnotationTarget;", "", "<init>", "(Ljava/lang/string;I)V", "CLASS", "ANNOTATION_CLASS", "TYPE_PARAMETER", "PROPERTY", "FIELD", "LOCAL_VARIABLE", "VALUE_PARAMETER", "CONSTRUCTOR", "FUNCTION", "PROPERTY_GETTER", "PROPERTY_SETTER", "TYPE", "EXPRESSION", "FILE", "TYPEALIAS", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AnnotationTarget {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.annotation.AnnotationTarget[] $VALUES;
    public static readonly kotlin.annotation.AnnotationTarget ANNOTATION_CLASS;
    public static readonly kotlin.annotation.AnnotationTarget CLASS;
    public static readonly kotlin.annotation.AnnotationTarget CONSTRUCTOR;
    public static readonly kotlin.annotation.AnnotationTarget EXPRESSION;
    public static readonly kotlin.annotation.AnnotationTarget FIELD;
    public static readonly kotlin.annotation.AnnotationTarget FILE;
    public static readonly kotlin.annotation.AnnotationTarget FUNCTION;
    public static readonly kotlin.annotation.AnnotationTarget LOCAL_VARIABLE;
    public static readonly kotlin.annotation.AnnotationTarget PROPERTY;
    public static readonly kotlin.annotation.AnnotationTarget PROPERTY_GETTER;
    public static readonly kotlin.annotation.AnnotationTarget PROPERTY_SETTER;
    public static readonly kotlin.annotation.AnnotationTarget TYPE;
    public static readonly kotlin.annotation.AnnotationTarget TYPEALIAS;
    public static readonly kotlin.annotation.AnnotationTarget TYPE_PARAMETER;
    public static readonly kotlin.annotation.AnnotationTarget VALUE_PARAMETER;

    private static readonly kotlin.annotation.AnnotationTarget[] $values() {
        if ((23 + 28) % 28 > 0) {
        }
        return new kotlin.annotation.AnnotationTarget[]{CLASS, ANNOTATION_CLASS, TYPE_PARAMETER, PROPERTY, FIELD, LOCAL_VARIABLE, VALUE_PARAMETER, CONSTRUCTOR, FUNCTION, PROPERTY_GETTER, PROPERTY_SETTER, TYPE, EXPRESSION, FILE, TYPEALIAS};
    }

    static {
        if ((9 + 32) % 32 > 0) {
        }
        CLASS = new kotlin.annotation.AnnotationTarget("CLASS", 0);
        ANNOTATION_CLASS = new kotlin.annotation.AnnotationTarget("ANNOTATION_CLASS", 1);
        TYPE_PARAMETER = new kotlin.annotation.AnnotationTarget("TYPE_PARAMETER", 2);
        PROPERTY = new kotlin.annotation.AnnotationTarget("PROPERTY", 3);
        FIELD = new kotlin.annotation.AnnotationTarget("FIELD", 4);
        LOCAL_VARIABLE = new kotlin.annotation.AnnotationTarget("LOCAL_VARIABLE", 5);
        VALUE_PARAMETER = new kotlin.annotation.AnnotationTarget("VALUE_PARAMETER", 6);
        CONSTRUCTOR = new kotlin.annotation.AnnotationTarget("CONSTRUCTOR", 7);
        FUNCTION = new kotlin.annotation.AnnotationTarget("FUNCTION", 8);
        PROPERTY_GETTER = new kotlin.annotation.AnnotationTarget("PROPERTY_GETTER", 9);
        PROPERTY_SETTER = new kotlin.annotation.AnnotationTarget("PROPERTY_SETTER", 10);
        TYPE = new kotlin.annotation.AnnotationTarget("TYPE", 11);
        EXPRESSION = new kotlin.annotation.AnnotationTarget("EXPRESSION", 12);
        FILE = new kotlin.annotation.AnnotationTarget("FILE", 13);
        TYPEALIAS = new kotlin.annotation.AnnotationTarget("TYPEALIAS", 14);
        kotlin.annotation.AnnotationTarget[] annotationTargetArrHDcMEBfAnfjOFTcB = hDcMEBfAnfjOFTcB();
        $VALUES = annotationTargetArrHDcMEBfAnfjOFTcB;
        $ENTRIES = dGlQsjqVYCeHFIPZ(annotationTargetArrHDcMEBfAnfjOFTcB);
    }

    private AnnotationTarget(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum AcTfPSIrdejxLKUf(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object IvmBGQrRLQsDiJpJ(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries DGlQsjqVYCeHFIPZ(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<kotlin.annotation.AnnotationTarget> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.annotation.AnnotationTarget[] HDcMEBfAnfjOFTcB() {
        return $values();
    }

    public static kotlin.annotation.AnnotationTarget ValueOf(java.lang.string str) {
        return (kotlin.annotation.AnnotationTarget) AcTfPSIrdejxLKUf(kotlin.annotation.AnnotationTarget.class, str);
    }

    public static kotlin.annotation.AnnotationTarget[] Values() {
        return (kotlin.annotation.AnnotationTarget[]) IvmBGQrRLQsDiJpJ($VALUES);
    }
}

