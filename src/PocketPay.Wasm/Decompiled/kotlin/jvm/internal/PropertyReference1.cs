namespace WillowMaze.Wasm.Decompiled;


public abstract class PropertyReference1 : kotlin.jvm.internal.PropertyReference : kotlin.reflect.KProperty1 {
    public PropertyReference1() {
    }

    public PropertyReference1(java.lang.object obj) {
        super(obj);
    }

    public PropertyReference1(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.property1(this);
    }

    public override java.lang.object GetDelegate(java.lang.object obj) {
        return ((kotlin.reflect.KProperty1) getReflected()).getDelegate(obj);
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty1$Getter getGetter() {
        return ((kotlin.reflect.KProperty1) getReflected()).getGetter();
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return get(obj);
    }
}

