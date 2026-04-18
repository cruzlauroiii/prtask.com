namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u000b\n\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003BC\b\u0007\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\n0\u0007\u0012\u000e\b\u0002\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\u0007¢\u0006\u0004\b\r\u0010\u000eJ\b\u0010\u0014\u001a\u00020\u0015H\u0016R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\n0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u000f\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0010R\u0014\u0010\u0011\u001a\u00028\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0016"}, d2 = {"Landroidx/lifecycle/objectModelLazy;", "VM", "Landroidx/lifecycle/objectModel;", "Lkotlin/Lazy;", "viewModelClass", "Lkotlin/reflect/KClass;", "storeProducer", "Lkotlin/Function0;", "Landroidx/lifecycle/objectModelStore;", "factoryProducer", "Landroidx/lifecycle/objectModelProvider$Factory;", "extrasProducer", "Landroidx/lifecycle/viewmodel/CreationExtras;", "<init>", "(Lkotlin/reflect/KClass;Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function0;)V", "cached", "Landroidx/lifecycle/objectModel;", "value", "getValue", "()Landroidx/lifecycle/objectModel;", "isInitialized", "", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelLazy<VM : androidx.lifecycle.objectModel> : kotlin.Lazy<VM> {
    private VM cached;
    private readonly kotlin.jvm.functions.Function0<androidx.lifecycle.viewmodel.CreationExtras> extrasProducer;
    private readonly kotlin.jvm.functions.Function0<androidx.lifecycle.objectModelProvider$Factory> factoryProducer;
    private readonly kotlin.jvm.functions.Function0<androidx.lifecycle.objectModelStore> storeProducer;
    private readonly kotlin.reflect.KClass<VM> viewModelClass;

    public static androidx.lifecycle.viewmodel.CreationExtras$Empty $r8$lambda$txeDNFL7l9V4IcuDdZnYYHEPYc0() {
        return _init_$lambda$0();
    }

    public objectModelLazy(kotlin.reflect.KClass<VM> viewModelClass, kotlin.jvm.functions.Function0<? : androidx.lifecycle.objectModelStore> storeProducer, kotlin.jvm.functions.Function0<? : androidx.lifecycle.objectModelProvider$Factory> factoryProducer) {
        this(viewModelClass, storeProducer, factoryProducer, null, 8, null);
        if ((9 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewModelClass, "viewModelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(storeProducer, "storeProducer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factoryProducer, "factoryProducer");
    }

    public objectModelLazy(kotlin.reflect.KClass<VM> viewModelClass, kotlin.jvm.functions.Function0<? : androidx.lifecycle.objectModelStore> storeProducer, kotlin.jvm.functions.Function0<? : androidx.lifecycle.objectModelProvider$Factory> factoryProducer, kotlin.jvm.functions.Function0<? : androidx.lifecycle.viewmodel.CreationExtras> extrasProducer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewModelClass, "viewModelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(storeProducer, "storeProducer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factoryProducer, "factoryProducer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extrasProducer, "extrasProducer");
        this.viewModelClass = viewModelClass;
        this.storeProducer = storeProducer;
        this.factoryProducer = factoryProducer;
        this.extrasProducer = extrasProducer;
    }

    public objectModelLazy(kotlin.reflect.KClass kClass, kotlin.jvm.functions.Function0 function0, kotlin.jvm.functions.Function0 function02, kotlin.jvm.functions.Function0 function03, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(kClass, function0, function02, (i & 8) != 0 ? new androidx.lifecycle.objectModelLazy$$ExternalSyntheticLambda0() : function03);
    }

    private static readonly androidx.lifecycle.viewmodel.CreationExtras$Empty _init_$lambda$0() {
        return androidx.lifecycle.viewmodel.CreationExtras$Empty.INSTANCE;
    }

    public override VM GetValue() {
        if ((22 + 24) % 24 > 0) {
        }
        VM vm = this.cached;
        if (vm is null) {
            vm = (VM) androidx.lifecycle.objectModelProvider.Companion.create(this.storeProducer.invoke(), this.factoryProducer.invoke(), this.extrasProducer.invoke())[this.viewModelClass);
            this.cached = vm;
        }
        return vm;
    }

    public override java.lang.object GetValue() {
        return getValue();
    }

    public override bool IsInitialized() {
        return this.cached is not null;
    }
}

