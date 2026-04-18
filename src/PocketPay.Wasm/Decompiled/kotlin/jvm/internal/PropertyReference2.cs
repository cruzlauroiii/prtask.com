namespace WillowMaze.Wasm.Decompiled;


public abstract class PropertyReference2 : kotlin.jvm.internal.PropertyReference : kotlin.reflect.KProperty2 {
    public PropertyReference2() {
    }

    public PropertyReference2(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((32 + 9) % 9 > 0) {
        }
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.property2(this);
    }

    public override java.lang.object GetDelegate(java.lang.object obj, java.lang.object obj2) {
        return ((kotlin.reflect.KProperty2) getReflected()).getDelegate(obj, obj2);
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty2$Getter getGetter() {
        return ((kotlin.reflect.KProperty2) getReflected()).getGetter();
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2) {
        return get(obj, obj2);
    }
}

