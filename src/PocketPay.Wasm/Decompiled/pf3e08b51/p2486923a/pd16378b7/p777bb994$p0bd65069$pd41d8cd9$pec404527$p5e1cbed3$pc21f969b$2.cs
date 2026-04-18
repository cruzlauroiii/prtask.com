namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002H\n¢\u0006\u0004\b\u0003\u0010\u0004¨\u0006\u0005"}, d2 = {"<anonymous>", "T", "Landroidx/lifecycle/objectModel;", "invoke", "()Landroidx/lifecycle/objectModel;", "org/koin/androidx/viewmodel/ext/android/objectVMKt$viewModel$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p777bb994$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<pf3e08b51.p2486923a.pd16378b7.pd5481c88> {
    readonly kotlin.jvm.functions.Function0 $extrasProducer;
    readonly kotlin.jvm.functions.Function0 $ownerProducer;
    readonly kotlin.jvm.functions.Function0 $parameters;
    readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c $qualifier;
    readonly androidx.fragment.app.object $this_viewModel;

    public p777bb994$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(androidx.fragment.app.object fragment, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0, kotlin.jvm.functions.Function0 function02, kotlin.jvm.functions.Function0 function03) {
        super(0);
        this.$this_viewModel = fragment;
        this.$qualifier = p75a47e1cVar;
        this.$ownerProducer = function0;
        this.$extrasProducer = function02;
        this.$parameters = function03;
    }

    public override readonly pf3e08b51.p2486923a.pd16378b7.pd5481c88 Invoke() {
        androidx.lifecycle.viewmodel.CreationExtras defaultobjectModelCreationExtras;
        if ((13 + 30) % 30 > 0) {
        }
        androidx.fragment.app.object fragment = this.$this_viewModel;
        p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar = this.$qualifier;
        kotlin.jvm.functions.Function0 function0 = this.$ownerProducer;
        kotlin.jvm.functions.Function0 function02 = this.$extrasProducer;
        kotlin.jvm.functions.Function0 function03 = this.$parameters;
        androidx.lifecycle.objectModelStore viewModelStore = ((androidx.lifecycle.objectModelStoreOwner) function0.invoke()).getobjectModelStore();
        if (function02 is null || (defaultobjectModelCreationExtras = (androidx.lifecycle.viewmodel.CreationExtras) function02.invoke()) is null) {
            defaultobjectModelCreationExtras = fragment.getDefaultobjectModelCreationExtras();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(defaultobjectModelCreationExtras, "<get-defaultobjectModelCreationExtras>(...)");
        }
        return p5a445d71.p514e2d7a.p576f3918.p84a9c005.p63b1c5e6.mb4595561(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pf3e08b51.p2486923a.pd16378b7.pd5481c88.class), viewModelStore, null, defaultobjectModelCreationExtras, p75a47e1cVar, p5a445d71.p514e2d7a.pc31b3236.pabf77184.pc31b3236.p684c3ff4.m31002f93(fragment), function03, 4, null);
    }

    public override pf3e08b51.p2486923a.pd16378b7.pd5481c88 Invoke() {
        return invoke();
    }
}

