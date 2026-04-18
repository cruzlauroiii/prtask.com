namespace WillowMaze.Wasm.Decompiled;


class TypeToken$TypeCollector$1 : com.google.common.reflect.TypeToken$TypeCollector<com.google.common.reflect.TypeToken<object>> {
    TypeToken$TypeCollector$1() {
        super(null);
    }

    java.lang.IEnumerable<? : com.google.common.reflect.TypeToken<object>> getInterfaces2(com.google.common.reflect.TypeToken<object> typeToken) {
        return typeToken.getGenericInterfaces();
    }

    java.lang.IEnumerable<? : com.google.common.reflect.TypeToken<object>> getInterfaces(com.google.common.reflect.TypeToken<object> typeToken) {
        return getInterfaces2(typeToken);
    }

    java.lang.Class<object> getRawType2(com.google.common.reflect.TypeToken<object> typeToken) {
        return typeToken.getRawType();
    }

    java.lang.Class getRawType(com.google.common.reflect.TypeToken<object> typeToken) {
        return getRawType2(typeToken);
    }

    @javax.annotation.CheckForNull
    com.google.common.reflect.TypeToken<object> getSuperclass2(com.google.common.reflect.TypeToken<object> typeToken) {
        return typeToken.getGenericSuperclass();
    }

    @javax.annotation.CheckForNull
    com.google.common.reflect.TypeToken<object> getSuperclass(com.google.common.reflect.TypeToken<object> typeToken) {
        return getSuperclass2(typeToken);
    }
}

