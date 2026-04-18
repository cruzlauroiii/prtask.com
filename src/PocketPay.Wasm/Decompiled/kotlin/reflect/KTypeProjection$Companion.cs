namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\fH\u0007J\u0010\u0010\r\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\fH\u0007J\u0010\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\fH\u0007R\u0016\u0010\u0004\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0006\u0010\u0003R\u0011\u0010\u0007\u001a\u00020\u00058F¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u000f"}, d2 = {"Lkotlin/reflect/KTypeProjection$Companion;", "", "<init>", "()V", "star", "Lkotlin/reflect/KTypeProjection;", "getStar$annotations", "STAR", "getSTAR", "()Lkotlin/reflect/KTypeProjection;", "invariant", "type", "Lkotlin/reflect/KType;", "contravariant", "covariant", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KTypeProjection$Companion {
    private KTypeProjection$Companion() {
    }

    public KTypeProjection$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void TIzEqpbfwfQGfDae(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TIzEqpbfwfQGfDae(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TIzEqpbfwfQGfDae(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIzEqpbfwfQGfDae(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TUqZZypuUwrfYguO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TUqZZypuUwrfYguO(java.lang.object obj, java.lang.string str, float f, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TUqZZypuUwrfYguO(java.lang.object obj, java.lang.string str, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TUqZZypuUwrfYguO(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGYEQtLCQVDqxGGA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GGYEQtLCQVDqxGGA(java.lang.object obj, java.lang.string str, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGYEQtLCQVDqxGGA(java.lang.object obj, java.lang.string str, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGYEQtLCQVDqxGGA(java.lang.object obj, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void getStar$annotations() {
    }

    public static void getStar$annotations(char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void getStar$annotations(float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void getStar$annotations(short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public readonly kotlin.reflect.KTypeProjection Contravariant(kotlin.reflect.KType type) {
        TUqZZypuUwrfYguO(type, "type");
        return new kotlin.reflect.KTypeProjection(kotlin.reflect.KVariance.IN, type);
    }

    @kotlin.jvm.JvmStatic
    public readonly kotlin.reflect.KTypeProjection Covariant(kotlin.reflect.KType type) {
        gGYEQtLCQVDqxGGA(type, "type");
        return new kotlin.reflect.KTypeProjection(kotlin.reflect.KVariance.OUT, type);
    }

    public readonly kotlin.reflect.KTypeProjection GetSTAR() {
        return kotlin.reflect.KTypeProjection.star;
    }

    @kotlin.jvm.JvmStatic
    public readonly kotlin.reflect.KTypeProjection Invariant(kotlin.reflect.KType type) {
        TIzEqpbfwfQGfDae(type, "type");
        return new kotlin.reflect.KTypeProjection(kotlin.reflect.KVariance.INVARIANT, type);
    }
}

