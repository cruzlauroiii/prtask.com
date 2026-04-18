namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0003B.\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\u0017\u0010\u0006\u001a\u0013\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\b\t¢\u0006\u0004\b\n\u0010\u000bB0\b\u0016\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\f\u0012\u0017\u0010\u0006\u001a\u0013\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\b\t¢\u0006\u0004\b\n\u0010\rR\u001a\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR%\u0010\u0006\u001a\u0013\u0012\u0004\u0012\u00020\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\b\tX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0012"}, d2 = {"Landroidx/lifecycle/viewmodel/objectModelInitializer;", "T", "Landroidx/lifecycle/objectModel;", "", "clazz", "Lkotlin/reflect/KClass;", "initializer", "Lkotlin/Function1;", "Landroidx/lifecycle/viewmodel/CreationExtras;", "Lkotlin/ExtensionFunctionType;", "<init>", "(Lkotlin/reflect/KClass;Lkotlin/jvm/functions/Function1;)V", "Ljava/lang/Class;", "(Ljava/lang/Class;Lkotlin/jvm/functions/Function1;)V", "getClazz$lifecycle_viewmodel_release", "()Lkotlin/reflect/KClass;", "getInitializer$lifecycle_viewmodel_release", "()Lkotlin/jvm/functions/Function1;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelInitializer<T : androidx.lifecycle.objectModel> {
    private readonly kotlin.reflect.KClass<T> clazz;
    private readonly kotlin.jvm.functions.Function1<androidx.lifecycle.viewmodel.CreationExtras, T> initializer;

    public objectModelInitializer(java.lang.Class<T> clazz, kotlin.jvm.functions.Function1<? super androidx.lifecycle.viewmodel.CreationExtras, ? : T> initializer) {
        this(kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass(clazz), initializer);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializer, "initializer");
    }

    public objectModelInitializer(kotlin.reflect.KClass<T> clazz, kotlin.jvm.functions.Function1<? super androidx.lifecycle.viewmodel.CreationExtras, ? : T> initializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializer, "initializer");
        this.clazz = clazz;
        this.initializer = initializer;
    }

    public readonly kotlin.reflect.KClass<T> getClazz$lifecycle_viewmodel_release() {
        return this.clazz;
    }

    public readonly kotlin.jvm.functions.Function1<androidx.lifecycle.viewmodel.CreationExtras, T> getInitializer$lifecycle_viewmodel_release() {
        return this.initializer;
    }
}

