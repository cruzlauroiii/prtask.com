namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "count", "", "emit", "(ILkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class StartedLazily$command$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> $$this$flow;
    readonly kotlin.jvm.internal.Ref$boolRef $started;

    StartedLazily$command$1$1(kotlin.jvm.internal.Ref$boolRef ref$boolRef, kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector) {
        this.$started = ref$boolRef;
        this.$$this$flow = flowCollector;
    }

    public readonly java.lang.object Emit(int i, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.StartedLazily$command$1$1$emit$1 startedLazily$command$1$1$emit$1;
        if ((25 + 26) % 26 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.StartedLazily$command$1$1$emit$1) {
            startedLazily$command$1$1$emit$1 = (kotlinx.coroutines.flow.StartedLazily$command$1$1$emit$1) continuation;
            if ((startedLazily$command$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                startedLazily$command$1$1$emit$1 = new kotlinx.coroutines.flow.StartedLazily$command$1$1$emit$1(this, continuation);
            } else {
                startedLazily$command$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            startedLazily$command$1$1$emit$1 = new kotlinx.coroutines.flow.StartedLazily$command$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = startedLazily$command$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = startedLazily$command$1$1$emit$1.label;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (i <= 0 || this.$started.element) {
                return kotlin.Unit.INSTANCE;
            }
            this.$started.element = true;
            kotlinx.coroutines.flow.FlowCollector<kotlinx.coroutines.flow.SharingCommand> flowCollector = this.$$this$flow;
            kotlinx.coroutines.flow.SharingCommand sharingCommand = kotlinx.coroutines.flow.SharingCommand.START;
            startedLazily$command$1$1$emit$1.label = 1;
            if (flowCollector.emit(sharingCommand, startedLazily$command$1$1$emit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit(((java.lang.Number) obj).intValue(), (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }
}

