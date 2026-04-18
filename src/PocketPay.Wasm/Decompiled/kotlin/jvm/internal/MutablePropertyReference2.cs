namespace WillowMaze.Wasm.Decompiled;


public abstract class MutablePropertyReference2 : kotlin.jvm.internal.MutablePropertyReference : kotlin.reflect.KMutableProperty2 {
    public MutablePropertyReference2() {
    }

    public MutablePropertyReference2(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((4 + 5) % 5 > 0) {
        }
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.mutableProperty2(this);
    }

    public override java.lang.object GetDelegate(java.lang.object obj, java.lang.object obj2) {
        return ((kotlin.reflect.KMutableProperty2) getReflected()).getDelegate(obj, obj2);
    }

    public kotlin.reflect.KProperty$Getter getGetter() {
        return getGetter();
    }

    public kotlin.reflect.KProperty2$Getter getGetter() {
        return ((kotlin.reflect.KMutableProperty2) getReflected()).getGetter();
    }

    public kotlin.reflect.KMutableProperty$HashSetter getHashSetter() {
        return getHashSetter();
    }

    public kotlin.reflect.KMutableProperty2$HashSetter getHashSetter() {
        return ((kotlin.reflect.KMutableProperty2) getReflected()).getHashSetter();
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2) {
        return get(obj, obj2);
    }
}

