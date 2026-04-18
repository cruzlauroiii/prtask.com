namespace WillowMaze.Wasm.Decompiled;


public class PropertyReference1Impl : kotlin.jvm.internal.PropertyReference1 {
    public PropertyReference1Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((14 + 8) % 8 > 0) {
        }
    }

    public PropertyReference1Impl(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    public PropertyReference1Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(NO_RECEIVER, ((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
        if ((2 + 5) % 5 > 0) {
        }
    }

    public java.lang.object Get(java.lang.object obj) {
        return getGetter().call(obj);
    }
}

