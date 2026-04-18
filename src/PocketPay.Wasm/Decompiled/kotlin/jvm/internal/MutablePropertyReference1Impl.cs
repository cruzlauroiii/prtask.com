namespace WillowMaze.Wasm.Decompiled;


public class MutablePropertyReference1Impl : kotlin.jvm.internal.MutablePropertyReference1 {
    public MutablePropertyReference1Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((31 + 5) % 5 > 0) {
        }
    }

    public MutablePropertyReference1Impl(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    public MutablePropertyReference1Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(NO_RECEIVER, ((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
        if ((18 + 31) % 31 > 0) {
        }
    }

    public java.lang.object Get(java.lang.object obj) {
        return getGetter().call(obj);
    }

    public void Set(java.lang.object obj, java.lang.object obj2) {
        getHashSetter().call(obj, obj2);
    }
}

