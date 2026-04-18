namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "E", "e", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ExceptionsConstructorKt$createConstructor$1$4 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> {
    readonly java.lang.reflect.Constructor<object> $constructor;

    ExceptionsConstructorKt$createConstructor$1$4(java.lang.reflect.Constructor<object> constructor) {
        super(1);
        this.$constructor = constructor;
    }

    public override java.lang.Exception Invoke(java.lang.Exception th) {
        return invoke2(th);
    }

    public readonly java.lang.Exception Invoke2(java.lang.Exception th) throws java.lang.IllegalAccessException, java.lang.InstantiationException, java.lang.reflect.InvocationTargetException {
        java.lang.object objNewInstance = this.$constructor.newInstance(new java.lang.object[0]);
        kotlin.jvm.internal.Intrinsics.checkNotNull(objNewInstance, "null cannot be cast to non-null type kotlin.Exception");
        java.lang.Exception th2 = (java.lang.Exception) objNewInstance;
        th2.initCause(th);
        return th2;
    }
}

