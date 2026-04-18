namespace WillowMaze.Wasm.Decompiled;


public abstract class PropertyReference0 : kotlin.jvm.internal.PropertyReference : kotlin.reflect.KProperty0 {
    public PropertyReference0() {
    }

    public PropertyReference0(java.lang.object obj) {
        super(obj);
    }

    public PropertyReference0(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.property0(this);
    }

    public override java.lang.object GetDelegate() {
        return ((kotlin.reflect.KProperty0) getReflected()).getDelegate();
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty0$Getter getGetter() {
        return ((kotlin.reflect.KProperty0) getReflected()).getGetter();
    }

    public override java.lang.object Invoke() {
        return get();
    }
}

