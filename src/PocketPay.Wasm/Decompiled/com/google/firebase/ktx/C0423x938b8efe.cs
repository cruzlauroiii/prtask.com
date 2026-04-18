namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\n \u0002*\u0004\u0018\u00010\u00010\u0001\"\n\b\u0000\u0010\u0003\u0018\u0001*\u00020\u00042\u000e\u0010\u0005\u001a\n \u0002*\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0002\b\u0007¨\u0006\b"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/CoroutineDispatcher;", "kotlin.jvm.PlatformType", "T", "", "c", "Lcom/google/firebase/components/ComponentContainer;", "create", "com/google/firebase/ktx/FirebaseKt$coroutineDispatcher$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0423x938b8efe<T> : com.google.firebase.components.ComponentFactory {
    public static readonly com.google.firebase.ktx.C0423x938b8efe<T> INSTANCE = new com.google.firebase.ktx.C0423x938b8efe<>();

    public static kotlinx.coroutines.CoroutineDispatcher GUrjqnEyOxbFHZYE(com.google.firebase.ktx.C0423x938b8efe c0423x938b8efe, com.google.firebase.components.ComponentContainer componentContainer) {
        return c0423x938b8efe.create(componentContainer);
    }

    public static java.lang.object STJNzqvfeTRzFqfp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void TzAUQmFqlvRZTgAy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher ATRmgdENBhZgNdnK(java.util.concurrent.Executor executor) {
        return kotlinx.coroutines.ExecutorsKt.from(executor);
    }

    public static com.google.firebase.components.Qualified UCndvOTezHcPhVog(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public override java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return GUrjqnEyOxbFHZYE(this, componentContainer);
    }

    public override readonly kotlinx.coroutines.CoroutineDispatcher Create(com.google.firebase.components.ComponentContainer componentContainer) {
        java.lang.object objSTJNzqvfeTRzFqfp = STJNzqvfeTRzFqfp(componentContainer, uCndvOTezHcPhVog(com.google.firebase.annotations.concurrent.UiThread.class, java.util.concurrent.Executor.class));
        TzAUQmFqlvRZTgAy(objSTJNzqvfeTRzFqfp, "c[Qualified.qualifie…a, Executor::class.java))");
        return aTRmgdENBhZgNdnK((java.util.concurrent.Executor) objSTJNzqvfeTRzFqfp);
    }
}

