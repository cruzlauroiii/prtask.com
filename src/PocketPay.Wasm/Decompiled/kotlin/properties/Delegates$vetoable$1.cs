namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J)\u0010\u0002\u001a\u00020\u00032\n\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u00052\u0006\u0010\u0006\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010\b¨\u0006\t"}, d2 = {"kotlin/properties/Delegates$vetoable$1", "Lkotlin/properties/ObservableProperty;", "beforeChange", "", "property", "Lkotlin/reflect/KProperty;", "oldValue", "newValue", "(Lkotlin/reflect/KProperty;Ljava/lang/object;Ljava/lang/object;)Z", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class Delegates$vetoable$1<T> : kotlin.properties.ObservableProperty<T> {
    readonly kotlin.jvm.functions.Function3<kotlin.reflect.KProperty<object>, T, T, java.lang.bool> $onChange;

    public Delegates$vetoable$1(T t, kotlin.jvm.functions.Function3<? super kotlin.reflect.KProperty<object>, ? super T, ? super T, java.lang.bool> function3) {
        super(t);
        this.$onChange = function3;
    }

    public static void PZSbgEqpeKMsTRZa(java.lang.bool bool, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZSbgEqpeKMsTRZa(java.lang.bool bool, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZSbgEqpeKMsTRZa(java.lang.bool bool, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PZSbgEqpeKMsTRZa(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void BnmVIUZiYHttatdZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BnmVIUZiYHttatdZ(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BnmVIUZiYHttatdZ(java.lang.object obj, java.lang.string str, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BnmVIUZiYHttatdZ(java.lang.object obj, java.lang.string str, bool z, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RwmXlSAFEuVhNolA(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return function3.invoke(obj, obj2, obj3);
    }

    public static void RwmXlSAFEuVhNolA(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwmXlSAFEuVhNolA(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwmXlSAFEuVhNolA(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected override bool BeforeChange(kotlin.reflect.KProperty<object> property, T oldValue, T newValue) {
        bnmVIUZiYHttatdZ(property, "property");
        return PZSbgEqpeKMsTRZa((java.lang.bool) rwmXlSAFEuVhNolA(this.$onChange, property, oldValue, newValue));
    }
}

