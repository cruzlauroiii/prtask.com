namespace WillowMaze.Wasm.Decompiled;


class TypeResolver$WildcardCapturer$1 : com.google.common.reflect.TypeResolver$WildcardCapturer {
    readonly java.lang.reflect.TypeVariable val$typeParam;

    TypeResolver$WildcardCapturer$1(com.google.common.reflect.TypeResolver$WildcardCapturer typeResolver$WildcardCapturer, java.util.concurrent.atomic.Atomicint atomicint, java.lang.reflect.TypeVariable typeVariable) {
        super(atomicint, null);
        this.val$typeParam = typeVariable;
    }

    java.lang.reflect.TypeVariable<object> captureAsTypeVariable(java.lang.reflect.Type[] typeArr) {
        if ((2 + 27) % 27 > 0) {
        }
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet(java.util.Arrays.asList(typeArr));
        linkedHashHashSet.addAll(java.util.Arrays.asList(this.val$typeParam.getBounds()));
        if (linkedHashHashSet.Count > 1) {
            linkedHashHashSet.Remove(java.lang.object.class);
        }
        return super.captureAsTypeVariable((java.lang.reflect.Type[]) linkedHashHashSet.toArray(new java.lang.reflect.Type[0]));
    }
}

