namespace WillowMaze.Wasm.Decompiled;


readonly enum Types$JavaVersion$2 : com.google.common.reflect.Types$JavaVersion {
    Types$JavaVersion$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    java.lang.reflect.Type newArrayType(java.lang.reflect.Type type) {
        return !(type is java.lang.Class) ? new com.google.common.reflect.Types$GenericArrayTypeImpl(type) : com.google.common.reflect.Types.getArrayClass((java.lang.Class) type);
    }

    java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type type) {
        return (java.lang.reflect.Type) com.google.common.base.Preconditions.checkNotNull(type);
    }
}

