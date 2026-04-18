namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J)\u0010\u0002\u001a\u00020\u00032\n\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u00052\u0006\u0010\u0006\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010\b¨\u0006\t"}, d2 = {"kotlin/properties/Delegates$observable$1", "Lkotlin/properties/ObservableProperty;", "afterChange", "", "property", "Lkotlin/reflect/KProperty;", "oldValue", "newValue", "(Lkotlin/reflect/KProperty;Ljava/lang/object;Ljava/lang/object;)V", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class Delegates$observable$1<T> : kotlin.properties.ObservableProperty<T> {
    readonly kotlin.jvm.functions.Function3<kotlin.reflect.KProperty<object>, T, T, kotlin.Unit> $onChange;

    public Delegates$observable$1(T t, kotlin.jvm.functions.Function3<? super kotlin.reflect.KProperty<object>, ? super T, ? super T, kotlin.Unit> function3) {
        super(t);
        this.$onChange = function3;
    }

    public static void MWkydqzgoAUmFwfO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MWkydqzgoAUmFwfO(java.lang.object obj, java.lang.string str, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWkydqzgoAUmFwfO(java.lang.object obj, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWkydqzgoAUmFwfO(java.lang.object obj, java.lang.string str, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XpZDeIYZsmFWXNdw(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return function3.invoke(obj, obj2, obj3);
    }

    public static void XpZDeIYZsmFWXNdw(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpZDeIYZsmFWXNdw(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XpZDeIYZsmFWXNdw(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override void AfterChange(kotlin.reflect.KProperty<object> property, T oldValue, T newValue) {
        MWkydqzgoAUmFwfO(property, "property");
        XpZDeIYZsmFWXNdw(this.$onChange, property, oldValue, newValue);
    }
}

