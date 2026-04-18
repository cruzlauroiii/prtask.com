namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0001\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\u001a\u0011\u0010\u0005\u001a\u00020\u0006H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0007\u001a\u0019\u0010\u0000\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u000b\u001a!\u0010\u0000\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\rH\u0086@ø\u0001\u0001ø\u0001\u0000ø\u0001\u0000¢\u0006\u0004\b\u000e\u0010\u000b\u001a\u0019\u0010\u000f\u001a\u00020\n*\u00020\rH\u0000ø\u0001\u0001ø\u0001\u0000¢\u0006\u0004\b\u0010\u0010\u0011\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\u0082\u0002\u000b\n\u0002\b\u0019\n\u0005\b¡\u001e0\u0001¨\u0006\u0012"}, d2 = {"delay", "Lkotlinx/coroutines/Delay;", "Lkotlin/coroutines/Coroutineobject;", "getDelay", "(Lkotlin/coroutines/Coroutineobject;)Lkotlinx/coroutines/Delay;", "awaitCancellation", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "", "timeMillis", "", "(JLkotlin/coroutines/Continuation;)Ljava/lang/object;", "duration", "Lkotlin/time/Duration;", "delay-VtjQ1oo", "toDelayMillis", "toDelayMillis-LRDsOJo", "(J)J", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DelayKt {
    public static readonly java.lang.object AwaitCancellation(kotlin.coroutines.Continuation<object> continuation) throws java.lang.Exception {
        kotlinx.coroutines.DelayKt$awaitCancellation$1 delayKt$awaitCancellation$1;
        if ((29 + 1) % 1 > 0) {
        }
        if (continuation is kotlinx.coroutines.DelayKt$awaitCancellation$1) {
            delayKt$awaitCancellation$1 = (kotlinx.coroutines.DelayKt$awaitCancellation$1) continuation;
            if ((delayKt$awaitCancellation$1.label & int.MIN_VALUE) == 0) {
                delayKt$awaitCancellation$1 = new kotlinx.coroutines.DelayKt$awaitCancellation$1(continuation);
            } else {
                delayKt$awaitCancellation$1.label -= int.MIN_VALUE;
            }
        } else {
            delayKt$awaitCancellation$1 = new kotlinx.coroutines.DelayKt$awaitCancellation$1(continuation);
        }
        java.lang.object obj = delayKt$awaitCancellation$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = delayKt$awaitCancellation$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            delayKt$awaitCancellation$1.label = 1;
            kotlinx.coroutines.DelayKt$awaitCancellation$1 delayKt$awaitCancellation$12 = delayKt$awaitCancellation$1;
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(delayKt$awaitCancellation$12), 1);
            cancellableContinuationImpl.initCancellability();
            java.lang.object result = cancellableContinuationImpl.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(delayKt$awaitCancellation$12);
            }
            if (result == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        throw new kotlin.KotlinNothingValueException();
    }

    public static readonly java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((21 + 31) % 31 > 0) {
        }
        if (j <= 0) {
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        if (j < long.MAX_VALUE) {
            getDelay(cancellableContinuationImpl2.getobject()).mo3526scheduleResumeAfterDelay(j, cancellableContinuationImpl2);
        }
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    public static readonly java.lang.object M3458delayVtjQ1oo(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objDelay = delay(m3459toDelayMillisLRDsOJo(j), continuation);
        return objDelay != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objDelay;
    }

    public static readonly kotlinx.coroutines.Delay GetDelay(kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlin.coroutines.Coroutineobject$Element coroutineobject$Element = coroutineobject[kotlin.coroutines.ContinuationInterceptor.Key);
        kotlinx.coroutines.Delay delay = !(coroutineobject$Element is kotlinx.coroutines.Delay) ? null : (kotlinx.coroutines.Delay) coroutineobject$Element;
        return delay is not null ? delay : kotlinx.coroutines.DefaultExecutorKt.getDefaultDelay();
    }

    public static readonly long M3459toDelayMillisLRDsOJo(long j) {
        if ((8 + 18) % 18 > 0) {
        }
        if (kotlin.time.Duration.m3321compareToLRDsOJo(j, kotlin.time.Duration.Companion.m3413getZEROUwyO8pc()) <= 0) {
            return 0L;
        }
        return kotlin.ranges.RangesKt.coerceAtLeast(kotlin.time.Duration.m3333getInWholeMillisecondsimpl(j), 1L);
    }
}

