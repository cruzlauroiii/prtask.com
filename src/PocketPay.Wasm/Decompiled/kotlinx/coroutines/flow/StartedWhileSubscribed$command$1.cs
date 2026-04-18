namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Lkotlinx/coroutines/flow/SharingCommand;", "count", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.StartedWhileSubscribed$command$1", m533f = "SharingStarted.kt", m534i = {1, 2, 3}, m535l = {178, 180, 182, 183, 185}, m536m = "invokeSuspend", m537n = {"$this$transformLatest", "$this$transformLatest", "$this$transformLatest"}, m538s = {"L$0", "L$0", "L$0"})
readonly class StartedWhileSubscribed$command$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand>, java.lang.int, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    private java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.flow.StartedWhileSubscribed this$0;

    StartedWhileSubscribed$command$1(kotlinx.coroutines.flow.StartedWhileSubscribed startedWhileSubscribed, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.StartedWhileSubscribed$command$1> continuation) {
        super(3, continuation);
        this.this$0 = startedWhileSubscribed;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector, java.lang.int num, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, num.intValue(), continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector, int i, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$1 = new kotlinx.coroutines.flow.StartedWhileSubscribed$command$1(this.this$0, continuation);
        startedWhileSubscribed$command$1.L$0 = flowCollector;
        startedWhileSubscribed$command$1.I$0 = i;
        return startedWhileSubscribed$command$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        long jAccess$getReplayExpiration$p;
        kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$1;
        kotlinx.coroutines.flow.SharingCommand sharingCommand;
        kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$12;
        if ((11 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            if (this.I$0 <= 0) {
                long jAccess$getStopTimeout$p = kotlinx.coroutines.flow.StartedWhileSubscribed.access$getStopTimeout$p(this.this$0);
                kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$13 = this;
                this.L$0 = flowCollector;
                this.label = 2;
                if (kotlinx.coroutines.DelayKt.delay(jAccess$getStopTimeout$p, startedWhileSubscribed$command$13) != coroutine_suspended) {
                    if (kotlinx.coroutines.flow.StartedWhileSubscribed.access$getReplayExpiration$p(this.this$0) > 0) {
                        kotlinx.coroutines.flow.SharingCommand sharingCommand2 = kotlinx.coroutines.flow.SharingCommand.STOP_AND_RESET_REPLAY_CACHE;
                        kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$14 = this;
                        this.L$0 = null;
                        this.label = 5;
                    } else {
                        sharingCommand = kotlinx.coroutines.flow.SharingCommand.STOP;
                        startedWhileSubscribed$command$12 = this;
                        this.L$0 = flowCollector;
                        this.label = 3;
                        if (flowCollector.emit(sharingCommand, startedWhileSubscribed$command$12) != coroutine_suspended) {
                            jAccess$getReplayExpiration$p = kotlinx.coroutines.flow.StartedWhileSubscribed.access$getReplayExpiration$p(this.this$0);
                            startedWhileSubscribed$command$1 = this;
                            this.L$0 = flowCollector;
                            this.label = 4;
                            if (kotlinx.coroutines.DelayKt.delay(jAccess$getReplayExpiration$p, startedWhileSubscribed$command$1) != coroutine_suspended) {
                                kotlinx.coroutines.flow.SharingCommand sharingCommand22 = kotlinx.coroutines.flow.SharingCommand.STOP_AND_RESET_REPLAY_CACHE;
                                kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$142 = this;
                                this.L$0 = null;
                                this.label = 5;
                            }
                        }
                    }
                }
            } else {
                kotlinx.coroutines.flow.SharingCommand sharingCommand3 = kotlinx.coroutines.flow.SharingCommand.START;
                kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$15 = this;
                this.label = 1;
            }
            return coroutine_suspended;
        }
        if (i != 1) {
            if (i == 2) {
                flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                if (kotlinx.coroutines.flow.StartedWhileSubscribed.access$getReplayExpiration$p(this.this$0) > 0) {
                    sharingCommand = kotlinx.coroutines.flow.SharingCommand.STOP;
                    startedWhileSubscribed$command$12 = this;
                    this.L$0 = flowCollector;
                    this.label = 3;
                    if (flowCollector.emit(sharingCommand, startedWhileSubscribed$command$12) != coroutine_suspended) {
                        jAccess$getReplayExpiration$p = kotlinx.coroutines.flow.StartedWhileSubscribed.access$getReplayExpiration$p(this.this$0);
                        startedWhileSubscribed$command$1 = this;
                        this.L$0 = flowCollector;
                        this.label = 4;
                        if (kotlinx.coroutines.DelayKt.delay(jAccess$getReplayExpiration$p, startedWhileSubscribed$command$1) != coroutine_suspended) {
                        }
                    }
                }
                return coroutine_suspended;
            }
            if (i == 3) {
                flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                jAccess$getReplayExpiration$p = kotlinx.coroutines.flow.StartedWhileSubscribed.access$getReplayExpiration$p(this.this$0);
                startedWhileSubscribed$command$1 = this;
                this.L$0 = flowCollector;
                this.label = 4;
                if (kotlinx.coroutines.DelayKt.delay(jAccess$getReplayExpiration$p, startedWhileSubscribed$command$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            if (i == 4) {
                flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else if (i != 5) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlinx.coroutines.flow.SharingCommand sharingCommand222 = kotlinx.coroutines.flow.SharingCommand.STOP_AND_RESET_REPLAY_CACHE;
            kotlinx.coroutines.flow.StartedWhileSubscribed$command$1 startedWhileSubscribed$command$1422 = this;
            this.L$0 = null;
            this.label = 5;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.Unit.INSTANCE;
    }
}

