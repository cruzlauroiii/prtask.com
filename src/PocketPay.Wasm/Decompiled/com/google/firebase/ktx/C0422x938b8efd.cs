namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\n \u0002*\u0004\u0018\u00010\u00010\u0001\"\n\b\u0000\u0010\u0003\u0018\u0001*\u00020\u00042\u000e\u0010\u0005\u001a\n \u0002*\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0002\b\u0007¨\u0006\b"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/CoroutineDispatcher;", "kotlin.jvm.PlatformType", "T", "", "c", "Lcom/google/firebase/components/ComponentContainer;", "create", "com/google/firebase/ktx/FirebaseKt$coroutineDispatcher$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0422x938b8efd<T> : com.google.firebase.components.ComponentFactory {
    public static readonly com.google.firebase.ktx.C0422x938b8efd<T> INSTANCE = new com.google.firebase.ktx.C0422x938b8efd<>();

    public static com.google.firebase.components.Qualified ImzfGMkSWpzcrePj(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static kotlinx.coroutines.CoroutineDispatcher QkxfChCRtMLnwcoZ(com.google.firebase.ktx.C0422x938b8efd c0422x938b8efd, com.google.firebase.components.ComponentContainer componentContainer) {
        return c0422x938b8efd.create(componentContainer);
    }

    public static java.lang.object YcrZCXUDEyuqYUvR(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void HxwZjPwtmbKJmddl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher UBQSzXlxUmzHdpzO(java.util.concurrent.Executor executor) {
        return kotlinx.coroutines.ExecutorsKt.from(executor);
    }

    public override java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return QkxfChCRtMLnwcoZ(this, componentContainer);
    }

    public override readonly kotlinx.coroutines.CoroutineDispatcher Create(com.google.firebase.components.ComponentContainer componentContainer) {
        java.lang.object objYcrZCXUDEyuqYUvR = YcrZCXUDEyuqYUvR(componentContainer, ImzfGMkSWpzcrePj(com.google.firebase.annotations.concurrent.Blocking.class, java.util.concurrent.Executor.class));
        hxwZjPwtmbKJmddl(objYcrZCXUDEyuqYUvR, "c[Qualified.qualifie…a, Executor::class.java))");
        return uBQSzXlxUmzHdpzO((java.util.concurrent.Executor) objYcrZCXUDEyuqYUvR);
    }
}

