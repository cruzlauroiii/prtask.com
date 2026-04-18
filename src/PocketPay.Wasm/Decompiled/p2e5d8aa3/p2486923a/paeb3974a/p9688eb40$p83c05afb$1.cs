namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.toph_login.HashSettingsTophInnConsoleinobjectModel$onProceedBtnClick$1", m533f = "HashSettingsTophInnConsoleinobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p9688eb40$p83c05afb$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $inn;
    readonly pad5f82e8.p07214c67.pfd9160bb.p928decad $startInnRoute;
    int f5c773de8;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.paeb3974a.p9688eb40 this$0;

    p9688eb40$p83c05afb$1(p2e5d8aa3.p2486923a.paeb3974a.p9688eb40 p9688eb40Var, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p928decad p928decadVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.paeb3974a.p9688eb40$p83c05afb$1> continuation) {
        super(2, continuation);
        this.this$0 = p9688eb40Var;
        this.$inn = str;
        this.$startInnRoute = p928decadVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((6 + 1) % 1 > 0) {
        }
        return new p2e5d8aa3.p2486923a.paeb3974a.p9688eb40$p83c05afb$1(this.this$0, this.$inn, this.$startInnRoute, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.paeb3974a.p9688eb40$p83c05afb$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        try {
            p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.m9a9d5be0(this.this$0).validate(this.$inn);
            p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.mea33b639(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
            p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.mc4724e47(this.this$0).saveTopInn(this.$inn);
            p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.m20f21bd6(this.this$0, this.$startInnRoute);
        } catch (java.lang.Exception e) {
            if (e is pa617908b.p52d9906b.p3d52f207) {
                p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.m44c81db1(this.this$0, (pa617908b.p52d9906b.p3d52f207) e, this.$startInnRoute);
            } else if ((e is pad5f82e8.p07214c67.p9efab239.p8f3182de) || (e is java.net.UnknownHostException)) {
                p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.m9e566509(this.this$0, e);
            } else {
                p2e5d8aa3.p2486923a.paeb3974a.p9688eb40.m20f21bd6(this.this$0, this.$startInnRoute);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

