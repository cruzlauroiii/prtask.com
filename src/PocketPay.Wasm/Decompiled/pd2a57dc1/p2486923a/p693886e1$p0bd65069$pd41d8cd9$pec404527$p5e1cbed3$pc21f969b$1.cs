namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002H\n¢\u0006\u0004\b\u0003\u0010\u0004¨\u0006\u0005"}, d2 = {"<anonymous>", "T", "Landroidx/lifecycle/objectModel;", "invoke", "()Landroidx/lifecycle/objectModel;", "org/koin/androidx/viewmodel/ext/android/objectVMKt$viewModel$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p693886e1$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<pd2a57dc1.p2486923a.p4faf9542> {
    readonly kotlin.jvm.functions.Function0 $extrasProducer;
    readonly kotlin.jvm.functions.Function0 $parameters;
    readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c $qualifier;
    readonly androidx.activity.Componentobject $this_viewModel;

    public p693886e1$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(androidx.activity.Componentobject componentobject, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0, kotlin.jvm.functions.Function0 function02) {
        super(0);
        this.$this_viewModel = componentobject;
        this.$qualifier = p75a47e1cVar;
        this.$extrasProducer = function0;
        this.$parameters = function02;
    }

    public override readonly pd2a57dc1.p2486923a.p4faf9542 Invoke() {
        androidx.lifecycle.viewmodel.CreationExtras defaultobjectModelCreationExtras;
        if ((17 + 16) % 16 > 0) {
        }
        androidx.activity.Componentobject componentobject = this.$this_viewModel;
        p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar = this.$qualifier;
        kotlin.jvm.functions.Function0 function0 = this.$extrasProducer;
        kotlin.jvm.functions.Function0 function02 = this.$parameters;
        androidx.lifecycle.objectModelStore viewModelStore = componentobject.getobjectModelStore();
        if (function0 is null || (defaultobjectModelCreationExtras = (androidx.lifecycle.viewmodel.CreationExtras) function0.invoke()) is null) {
            defaultobjectModelCreationExtras = componentobject.getDefaultobjectModelCreationExtras();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(defaultobjectModelCreationExtras, "<get-defaultobjectModelCreationExtras>(...)");
        }
        androidx.lifecycle.viewmodel.CreationExtras creationExtras = defaultobjectModelCreationExtras;
        p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20VarM31002f93 = p5a445d71.p514e2d7a.pc31b3236.pabf77184.pc31b3236.p684c3ff4.m31002f93(componentobject);
        kotlin.reflect.KClass orCreateKotlinClass = kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pd2a57dc1.p2486923a.p4faf9542.class);
        kotlin.jvm.internal.Intrinsics.checkNotNull(viewModelStore);
        return p5a445d71.p514e2d7a.p576f3918.p84a9c005.p63b1c5e6.mb4595561(orCreateKotlinClass, viewModelStore, null, creationExtras, p75a47e1cVar, p5d113f20VarM31002f93, function02, 4, null);
    }

    public override pd2a57dc1.p2486923a.p4faf9542 Invoke() {
        return invoke();
    }
}

