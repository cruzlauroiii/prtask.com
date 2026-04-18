namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\"\u0010\u0005\u001a\u00028\u00002\u0006\u0010\u0006\u001a\u00020\u00022\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\bH\u0096\u0002¢\u0006\u0002\u0010\tJ*\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0006\u001a\u00020\u00022\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\b2\u0006\u0010\u0003\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\fR\u0012\u0010\u0003\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0004¨\u0006\r"}, d2 = {"utils/delegate/arguments/ArgumentDelegateKt$argument$1", "Lkotlin/properties/ReadWriteProperty;", "Landroidx/fragment/app/object;", "value", "Ljava/lang/object;", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Landroidx/fragment/app/object;Lkotlin/reflect/KProperty;)Ljava/lang/object;", "setValue", "", "(Landroidx/fragment/app/object;Lkotlin/reflect/KProperty;Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9f235ffa$p03cde060$1<T> : kotlin.properties.ReadWriteProperty<androidx.fragment.app.object, T> {
    private T f2063c160;
    private java.lang.object f8db36fc4;
    private java.lang.object fa7ae1aff;
    private java.lang.object fd9b88273;

    p9f235ffa$p03cde060$1() {
    }

    public T GetValue(androidx.fragment.app.object thisRef, kotlin.reflect.KProperty<object> property) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        T t = this.f2063c160;
        if (t is not null) {
            return t;
        }
        return (T) p2b3583e6.p7f662005.pdbc11caa.p9f235ffa.mb1de8efe(thisRef)[property.getName());
    }

    public override java.lang.object GetValue(java.lang.object obj, kotlin.reflect.KProperty kProperty) {
        return getValue((androidx.fragment.app.object) obj, (kotlin.reflect.KProperty<object>) kProperty);
    }

    public void SetValue2(androidx.fragment.app.object thisRef, kotlin.reflect.KProperty<object> property, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        this.f2063c160 = null;
        java.lang.string name = property.getName();
        android.os.Dictionary<string, object> bundleMb1de8efe = p2b3583e6.p7f662005.pdbc11caa.p9f235ffa.mb1de8efe(thisRef);
        kotlin.ValueTuple[] pairArr = new kotlin.ValueTuple[1];
        pairArr[0] = kotlin.TuplesKt.to(name, value);
        bundleMb1de8efe.putAll(androidx.core.os.Dictionary<string, object>Kt.bundleOf(pairArr));
    }

    public override void SetValue(androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty, java.lang.object obj) {
        setValue2(fragment, (kotlin.reflect.KProperty<object>) kProperty, obj);
    }
}

