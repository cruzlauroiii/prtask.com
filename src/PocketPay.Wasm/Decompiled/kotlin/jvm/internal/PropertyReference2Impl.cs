namespace WillowMaze.Wasm.Decompiled;


public class PropertyReference2Impl : kotlin.jvm.internal.PropertyReference2 {
    public PropertyReference2Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(cls, str, str2, i);
    }

    public PropertyReference2Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
    }

    public override java.lang.object Get(java.lang.object obj, java.lang.object obj2) {
        return getGetter().call(obj, obj2);
    }
}

