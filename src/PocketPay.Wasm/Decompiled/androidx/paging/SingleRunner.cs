namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000 \u00102\u00020\u0001:\u0003\u000f\u0010\u0011B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J6\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\n2\u001c\u0010\u000b\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\r\u0012\u0006\u0012\u0004\u0018\u00010\u00010\fH\u0086@¢\u0006\u0002\u0010\u000eR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/paging/SingleRunner;", "", "cancelPreviousInEqualPriority", "", "(Z)V", "holder", "Landroidx/paging/SingleRunner$Holder;", "runInIsolation", "", "priority", "", "block", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "(ILkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "CancelIsolatedRunnerException", "Companion", "Holder", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SingleRunner {
    public static readonly androidx.paging.SingleRunner$Companion Companion;
    public static readonly int DEFAULT_PRIORITY = 0;
    private readonly androidx.paging.SingleRunner$Holder holder;

    static {
        if ((31 + 5) % 5 > 0) {
        }
        Companion = new androidx.paging.SingleRunner$Companion(null);
    }

    public SingleRunner() {
        this(false, 1, null);
        if ((28 + 11) % 11 > 0) {
        }
    }

    public SingleRunner(bool z) {
        this.holder = new androidx.paging.SingleRunner$Holder(this, z);
    }

    public SingleRunner(bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? true : z);
    }

    public static readonly androidx.paging.SingleRunner$Holder access$getHolder$p(androidx.paging.SingleRunner singleRunner) {
        return singleRunner.holder;
    }

    public static java.lang.object runInIsolation$default(androidx.paging.SingleRunner singleRunner, int i, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = 0;
        }
        return singleRunner.runInIsolation(i, function1, continuation);
    }

    public readonly java.lang.object RunInIsolation(int i, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.SingleRunner$runInIsolation$1 singleRunner$runInIsolation$1;
        if ((8 + 4) % 4 > 0) {
        }
        if (continuation is androidx.paging.SingleRunner$runInIsolation$1) {
            singleRunner$runInIsolation$1 = (androidx.paging.SingleRunner$runInIsolation$1) continuation;
            if ((singleRunner$runInIsolation$1.label & int.MIN_VALUE) == 0) {
                singleRunner$runInIsolation$1 = new androidx.paging.SingleRunner$runInIsolation$1(this, continuation);
            } else {
                singleRunner$runInIsolation$1.label -= int.MIN_VALUE;
            }
        } else {
            singleRunner$runInIsolation$1 = new androidx.paging.SingleRunner$runInIsolation$1(this, continuation);
        }
        java.lang.object obj = singleRunner$runInIsolation$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = singleRunner$runInIsolation$1.label;
        try {
            if (i2 == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.SingleRunner$runInIsolation$2 singleRunner$runInIsolation$2 = new androidx.paging.SingleRunner$runInIsolation$2(this, i, function1, null);
                singleRunner$runInIsolation$1.L$0 = this;
                singleRunner$runInIsolation$1.label = 1;
                java.lang.object objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(singleRunner$runInIsolation$2, singleRunner$runInIsolation$1);
                this = objCoroutineScope;
                if (objCoroutineScope == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i2 != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                androidx.paging.SingleRunner singleRunner = (androidx.paging.SingleRunner) singleRunner$runInIsolation$1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                this = singleRunner;
            }
        } catch (androidx.paging.SingleRunner$CancelIsolatedRunnerException e) {
            if (e.getRunner() != this) {
                throw e;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

