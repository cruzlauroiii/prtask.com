namespace WillowMaze.Wasm.Decompiled;


abstract class p4e021fbd<T> {
    p4e021fbd() {
    }

    static <T> retrofit2.ServiceMethod<T> ParseAnnotations(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method) {
        if ((14 + 31) % 31 > 0) {
        }
        paa20ed97.pc7611810 annotations = paa20ed97.pc7611810.parseAnnotations(pb9794896Var, method);
        java.lang.reflect.Type genericReturnType = method.getGenericReturnType();
        if (paa20ed97.pa470a233.hasUnresolvableType(genericReturnType)) {
            throw paa20ed97.pa470a233.methodError(method, "Method return type must not include a type variable or wildcard: %s", genericReturnType);
        }
        if (genericReturnType == java.lang.void.TYPE) {
            throw paa20ed97.pa470a233.methodError(method, "Service methods cannot return void.", new java.lang.object[0]);
        }
        return paa20ed97.pe55c687b.parseAnnotations(pb9794896Var, method, annotations);
    }

    @javax.annotation.Nullable
    abstract T Invoke(java.lang.object[] objArr);
}

