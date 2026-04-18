namespace WillowMaze.Wasm.Decompiled;


public abstract class MutablePropertyReference1 : kotlin.jvm.internal.MutablePropertyReference : kotlin.reflect.KMutableProperty1 {
    public MutablePropertyReference1() {
    }

    public MutablePropertyReference1(java.lang.object obj) {
        super(obj);
    }

    public MutablePropertyReference1(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.mutableProperty1(this);
    }

    public override java.lang.object GetDelegate(java.lang.object obj) {
        return ((kotlin.reflect.KMutableProperty1) getReflected()).getDelegate(obj);
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty1$Getter getGetter() {
        return ((kotlin.reflect.KMutableProperty1) getReflected()).getGetter();
    }

    public kotlin.reflect.KMutableProperty$HashSetter getHashSetter() {
        return getHashSetter();
    }

    public kotlin.reflect.KMutableProperty1$HashSetter getHashSetter() {
        return ((kotlin.reflect.KMutableProperty1) getReflected()).getHashSetter();
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return get(obj);
    }
}

