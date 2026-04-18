namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "registration.presentation.userRole.errors.CheckRegisteredAccountErrorobjectModel$checkRegisteredAccount$1", m533f = "CheckRegisteredAccountErrorobjectModel.kt", m534i = {}, m535l = {32}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p83bd6b5d$p2b8b299b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f0ca1321e;
    int f38c2ca4a;
    int fd304ba20;
    readonly p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d this$0;

    p83bd6b5d$p2b8b299b$1(p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d p83bd6b5dVar, kotlin.coroutines.Continuation<? super p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d$p2b8b299b$1> continuation) {
        super(2, continuation);
        this.this$0 = p83bd6b5dVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d$p2b8b299b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d$p2b8b299b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d.m5e146e53(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                if (p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d.mf14814ed(this.this$0).updateRegistrationUserData(this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d.md1b709a2(this.this$0).startSplashFlow();
        } catch (pad5f82e8.p07214c67.p9efab239.pb78344dc unused) {
            p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d.m74e3994c(this.this$0).startRegistrationFlow();
        } catch (java.lang.Exception e) {
            p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d.m5e146e53(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

