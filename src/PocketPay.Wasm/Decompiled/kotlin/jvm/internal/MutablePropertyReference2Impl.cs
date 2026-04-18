namespace WillowMaze.Wasm.Decompiled;


public class MutablePropertyReference2Impl : kotlin.jvm.internal.MutablePropertyReference2 {
    public MutablePropertyReference2Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(cls, str, str2, i);
    }

    public MutablePropertyReference2Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
    }

    public override java.lang.object Get(java.lang.object obj, java.lang.object obj2) {
        return getGetter().call(obj, obj2);
    }

    public override void Set(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        getHashSetter().call(obj, obj2, obj3);
    }
}

