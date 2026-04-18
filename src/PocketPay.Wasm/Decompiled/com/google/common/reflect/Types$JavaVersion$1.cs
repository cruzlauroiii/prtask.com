namespace WillowMaze.Wasm.Decompiled;


readonly enum Types$JavaVersion$1 : com.google.common.reflect.Types$JavaVersion {
    Types$JavaVersion$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    java.lang.reflect.GenericArrayType newArrayType(java.lang.reflect.Type type) {
        return new com.google.common.reflect.Types$GenericArrayTypeImpl(type);
    }

    java.lang.reflect.Type newArrayType(java.lang.reflect.Type type) {
        return newArrayType(type);
    }

    java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type type) {
        com.google.common.base.Preconditions.checkNotNull(type);
        if (type is java.lang.Class) {
            java.lang.Class cls = (java.lang.Class) type;
            if (cls.isArray()) {
                type = new com.google.common.reflect.Types$GenericArrayTypeImpl(cls.getComponentType());
            }
        }
        return type;
    }
}

