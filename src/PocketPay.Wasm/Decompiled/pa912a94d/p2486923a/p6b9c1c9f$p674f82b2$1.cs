namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "statistics.presentation.StatisticsobjectModel$loadStatisticsInfo$1", m533f = "StatisticsobjectModel.kt", m534i = {}, m535l = {36}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6b9c1c9f$p674f82b2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int f06ee3af5;
    int f1a427f63;
    int fb4e92b69;
    int fd304ba20;
    readonly pa912a94d.p2486923a.p6b9c1c9f this$0;

    p6b9c1c9f$p674f82b2$1(pa912a94d.p2486923a.p6b9c1c9f p6b9c1c9fVar, kotlin.coroutines.Continuation<? super pa912a94d.p2486923a.p6b9c1c9f$p674f82b2$1> continuation) {
        super(2, continuation);
        this.this$0 = p6b9c1c9fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pa912a94d.p2486923a.p6b9c1c9f$p674f82b2$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pa912a94d.p2486923a.p6b9c1c9f$p674f82b2$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveDataMd00c9606;
        pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c;
        if ((18 + 31) % 31 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                mutableLiveDataMd00c9606 = pa912a94d.p2486923a.p6b9c1c9f.md00c9606(this.this$0);
                pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c2 = pad5f82e8.p07214c67.pa4ecfc70.f910eef8c;
                this.L$0 = mutableLiveDataMd00c9606;
                this.L$1 = pa4ecfc70_p910eef8c2;
                this.fd304ba20 = 1;
                java.lang.object statisticInfo = pa912a94d.p2486923a.p6b9c1c9f.maa7198cc(this.this$0).getStatisticInfo(pa912a94d.p2486923a.p6b9c1c9f.m9dce1ee0(this.this$0).getFilter(), this);
                if (statisticInfo == coroutine_suspended) {
                    return coroutine_suspended;
                }
                pa4ecfc70_p910eef8c = pa4ecfc70_p910eef8c2;
                obj = statisticInfo;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                pa4ecfc70_p910eef8c = (pad5f82e8.p07214c67.pa4ecfc70$p910eef8c) this.L$1;
                mutableLiveDataMd00c9606 = (androidx.lifecycle.MutableLiveData) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            mutableLiveDataMd00c9606.postValue(pa4ecfc70_p910eef8c.success(obj));
        } catch (java.lang.Exception e) {
            pa912a94d.p2486923a.p6b9c1c9f.md00c9606(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

