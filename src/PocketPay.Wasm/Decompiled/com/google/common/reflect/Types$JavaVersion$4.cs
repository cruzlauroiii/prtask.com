namespace WillowMaze.Wasm.Decompiled;


readonly enum Types$JavaVersion$4 : com.google.common.reflect.Types$JavaVersion {
    Types$JavaVersion$4(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool jdkTypeDuplicatesOwnerName() {
        return false;
    }

    java.lang.reflect.Type newArrayType(java.lang.reflect.Type type) {
        return JAVA8.newArrayType(type);
    }

    java.lang.string typeName(java.lang.reflect.Type type) {
        return JAVA8.typeName(type);
    }

    java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type type) {
        return JAVA8.usedInGenericType(type);
    }
}

