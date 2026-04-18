namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pin.repository.PinRepositoryImpl$checkConsoleout$1", m533f = "PinRepositoryImpl.kt", m534i = {}, m535l = {23}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p291d804a$pe3fc2d35$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int fbd527777;
    int fd304ba20;
    int fde1ad784;
    readonly p8a6f5038.pb3f20355.p291d804a this$0;

    p291d804a$pe3fc2d35$1(p8a6f5038.pb3f20355.p291d804a p291d804aVar, kotlin.coroutines.Continuation<? super p8a6f5038.pb3f20355.p291d804a$pe3fc2d35$1> continuation) {
        super(2, continuation);
        this.this$0 = p291d804aVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8a6f5038.pb3f20355.p291d804a$pe3fc2d35$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8a6f5038.pb3f20355.p291d804a$pe3fc2d35$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((8 + 31) % 31 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p8a6f5038.pb3f20355.p291d804a$pe3fc2d35$1 p291d804a_pe3fc2d35_1 = this;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.DelayKt.delay(300000L, p291d804a_pe3fc2d35_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p2b3583e6.p69bb0e1a.m82fdc3ea(p8a6f5038.pb3f20355.p291d804a.m3cc2c630(this.this$0), kotlin.Unit.INSTANCE);
        return kotlin.Unit.INSTANCE;
    }
}

