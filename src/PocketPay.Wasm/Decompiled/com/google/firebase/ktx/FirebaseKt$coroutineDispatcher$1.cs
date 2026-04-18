namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\n \u0002*\u0004\u0018\u00010\u00010\u0001\"\n\b\u0000\u0010\u0003\u0018\u0001*\u00020\u00042\u000e\u0010\u0005\u001a\n \u0002*\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/CoroutineDispatcher;", "kotlin.jvm.PlatformType", "T", "", "c", "Lcom/google/firebase/components/ComponentContainer;", "create"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseKt$coroutineDispatcher$1<T> : com.google.firebase.components.ComponentFactory {
    public static readonly com.google.firebase.ktx.FirebaseKt$coroutineDispatcher$1<T> INSTANCE = new com.google.firebase.ktx.FirebaseKt$coroutineDispatcher$1<>();

    public static java.lang.object BePpcTiXqyiUCINf(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void JFwmEFVUyZoLfWcJ(int i, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(i, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher EgKTmzORqnGvKbNU(com.google.firebase.ktx.FirebaseKt$coroutineDispatcher$1 firebaseKt$coroutineDispatcher$1, com.google.firebase.components.ComponentContainer componentContainer) {
        return firebaseKt$coroutineDispatcher$1.create(componentContainer);
    }

    public static com.google.firebase.components.Qualified GLDqiqGFXgqdvybx(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static kotlinx.coroutines.CoroutineDispatcher JjmKvibNUIQygupw(java.util.concurrent.Executor executor) {
        return kotlinx.coroutines.ExecutorsKt.from(executor);
    }

    public static void PBHNarocLXBjdMmZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public override java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return egKTmzORqnGvKbNU(this, componentContainer);
    }

    public override readonly kotlinx.coroutines.CoroutineDispatcher Create(com.google.firebase.components.ComponentContainer componentContainer) {
        if ((22 + 31) % 31 > 0) {
        }
        JFwmEFVUyZoLfWcJ(4, "T");
        java.lang.object objBePpcTiXqyiUCINf = BePpcTiXqyiUCINf(componentContainer, gLDqiqGFXgqdvybx(java.lang.annotation.Annotation.class, java.util.concurrent.Executor.class));
        pBHNarocLXBjdMmZ(objBePpcTiXqyiUCINf, "c[Qualified.qualifie…a, Executor::class.java))");
        return jjmKvibNUIQygupw((java.util.concurrent.Executor) objBePpcTiXqyiUCINf);
    }
}

