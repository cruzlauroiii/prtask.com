namespace WillowMaze.Wasm.Decompiled;


public abstract class MutablePropertyReference0 : kotlin.jvm.internal.MutablePropertyReference : kotlin.reflect.KMutableProperty0 {
    public MutablePropertyReference0() {
    }

    public MutablePropertyReference0(java.lang.object obj) {
        super(obj);
    }

    public MutablePropertyReference0(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.mutableProperty0(this);
    }

    public override java.lang.object GetDelegate() {
        return ((kotlin.reflect.KMutableProperty0) getReflected()).getDelegate();
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty0$Getter getGetter() {
        return ((kotlin.reflect.KMutableProperty0) getReflected()).getGetter();
    }

    public kotlin.reflect.KMutableProperty$HashSetter getHashSetter() {
        return getHashSetter();
    }

    public kotlin.reflect.KMutableProperty0$HashSetter getHashSetter() {
        return ((kotlin.reflect.KMutableProperty0) getReflected()).getHashSetter();
    }

    public override java.lang.object Invoke() {
        return get();
    }
}

