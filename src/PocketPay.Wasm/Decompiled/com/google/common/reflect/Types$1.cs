namespace WillowMaze.Wasm.Decompiled;


class Types$1 : com.google.common.reflect.TypeVisitor {
    readonly java.util.concurrent.atomic.object val$result;

    Types$1(java.util.concurrent.atomic.object atomicReference) {
        this.val$result = atomicReference;
    }

    void visitClass(java.lang.Class<object> cls) {
        this.val$result.set(cls.getComponentType());
    }

    void visitGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        this.val$result.set(genericArrayType.getGenericComponentType());
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        this.val$result.set(com.google.common.reflect.Types.access$100(typeVariable.getBounds()));
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
        this.val$result.set(com.google.common.reflect.Types.access$100(wildcardType.getUpperBounds()));
    }
}

