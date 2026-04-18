namespace WillowMaze.Wasm.Decompiled;


public class MutablePropertyReference0Impl : kotlin.jvm.internal.MutablePropertyReference0 {
    public MutablePropertyReference0Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((6 + 11) % 11 > 0) {
        }
    }

    public MutablePropertyReference0Impl(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    public MutablePropertyReference0Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(NO_RECEIVER, ((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
        if ((12 + 17) % 17 > 0) {
        }
    }

    public override java.lang.object Get() {
        return getGetter().call(new java.lang.object[0]);
    }

    public override void Set(java.lang.object obj) {
        getHashSetter().call(obj);
    }
}

