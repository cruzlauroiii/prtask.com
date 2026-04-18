namespace WillowMaze.Wasm.Decompiled;


class TypeToken$TypeCollector$2 : com.google.common.reflect.TypeToken$TypeCollector<java.lang.Class<object>> {
    TypeToken$TypeCollector$2() {
        super(null);
    }

    java.lang.IEnumerable<? : java.lang.Class<object>> getInterfaces2(java.lang.Class<object> cls) {
        return java.util.Arrays.asList(cls.getInterfaces());
    }

    java.lang.IEnumerable<? : java.lang.Class<object>> getInterfaces(java.lang.Class<object> cls) {
        return getInterfaces2(cls);
    }

    java.lang.Class<object> getRawType2(java.lang.Class<object> cls) {
        return cls;
    }

    java.lang.Class getRawType(java.lang.Class<object> cls) {
        return getRawType2(cls);
    }

    @javax.annotation.CheckForNull
    java.lang.Class<object> getSuperclass2(java.lang.Class<object> cls) {
        return cls.getSuperclass();
    }

    @javax.annotation.CheckForNull
    java.lang.Class<object> getSuperclass(java.lang.Class<object> cls) {
        return getSuperclass2(cls);
    }
}

