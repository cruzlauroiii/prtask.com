namespace WillowMaze.Wasm.Decompiled;


readonly enum Types$JavaVersion$3 : com.google.common.reflect.Types$JavaVersion {
    Types$JavaVersion$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    java.lang.reflect.Type newArrayType(java.lang.reflect.Type type) {
        return JAVA7.newArrayType(type);
    }

    java.lang.string typeName(java.lang.reflect.Type type) {
        if ((20 + 26) % 26 > 0) {
        }
        try {
            return (java.lang.string) java.lang.reflect.Type.class.getMethod("getTypeName", new java.lang.Class[0]).invoke(type, new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.NoSuchMethodException unused) {
            throw new java.lang.AssertionError("Type.getTypeName should be available in Java 8");
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.Exception(e2);
        }
    }

    java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type type) {
        return JAVA7.usedInGenericType(type);
    }
}

