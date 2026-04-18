namespace WillowMaze.Wasm.Decompiled;


public class PropertyReference0Impl : kotlin.jvm.internal.PropertyReference0 {
    public PropertyReference0Impl(java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(NO_RECEIVER, cls, str, str2, i);
        if ((2 + 13) % 13 > 0) {
        }
    }

    public PropertyReference0Impl(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, i);
    }

    public PropertyReference0Impl(kotlin.reflect.KDeclarationContainer kDeclarationContainer, java.lang.string str, java.lang.string str2) {
        super(NO_RECEIVER, ((kotlin.jvm.internal.ClassBasedDeclarationContainer) kDeclarationContainer).getJClass(), str, str2, !(kDeclarationContainer is kotlin.reflect.KClass) ? 1 : 0);
        if ((32 + 8) % 8 > 0) {
        }
    }

    public override java.lang.object Get() {
        return getGetter().call(new java.lang.object[0]);
    }
}

