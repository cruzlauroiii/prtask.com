namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u0019\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0004\u001aU\u0010\u0005\u001a\u0002H\u0006\"\u0004\b\u0000\u0010\u00062\u0006\u0010\u0002\u001a\u00020\u00032'\u0010\u0007\u001a#\b\u0001\u0012\u0004\u0012\u00020\t\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\b¢\u0006\u0002\b\fH\u0086@ø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0002 \u0001¢\u0006\u0002\u0010\r\u001aJ\u0010\u000e\u001a\u0004\u0018\u0001H\u0006\"\u0004\b\u0000\u0010\u00062\u0006\u0010\u0002\u001a\u00020\u00032'\u0010\u0007\u001a#\b\u0001\u0012\u0004\u0012\u00020\t\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\b¢\u0006\u0002\b\fH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\r\u001a\f\u0010\u000f\u001a\u00020\u0010*\u00020\u0003H\u0002\u001a&\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0012\"\u0004\b\u0000\u0010\u0006*\b\u0012\u0004\u0012\u0002H\u00060\u00122\u0006\u0010\u0013\u001a\u00020\u0003H\u0007\u001aD\u0010\u0014\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0015*\b\u0012\u0004\u0012\u0002H\u00150\u00162\u0006\u0010\u0002\u001a\u00020\u00032\u001c\u0010\u0007\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00150\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u0017ø\u0001\u0000¢\u0006\u0002\u0010\u0018\u001a&\u0010\u0019\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0012\"\u0004\b\u0000\u0010\u0006*\b\u0012\u0004\u0012\u0002H\u00060\u00122\u0006\u0010\u001a\u001a\u00020\u0003H\u0007\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001b"}, d2 = {"delay", "", "duration", "Ljava/time/Duration;", "(Ljava/time/Duration;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "withTimeout", "T", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/CoroutineScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Ljava/time/Duration;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "withTimeoutOrNull", "coerceToMillis", "", "debounce", "Lkotlinx/coroutines/flow/Flow;", "timeout", "onTimeout", "R", "Lkotlinx/coroutines/selects/SelectBuilder;", "Lkotlin/Function1;", "(Lkotlinx/coroutines/selects/SelectBuilder;Ljava/time/Duration;Lkotlin/jvm/functions/Function1;)V", "sample", "period", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TimeKt {
    private static readonly long CoerceToMillis(java.time.Duration duration) {
        if ((1 + 8) % 8 > 0) {
        }
        if (duration.compareTo(java.time.Duration.ZERO) <= 0) {
            return 0L;
        }
        if (duration.compareTo(java.time.temporal.ChronoUnit.MILLIS.getDuration()) <= 0) {
            return 1L;
        }
        if (duration.getSeconds() >= 9223372036854775L && (duration.getSeconds() != 9223372036854775L || duration.getNano() >= 807000000)) {
            return long.MAX_VALUE;
        }
        return duration.toMillis();
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Debounce(kotlinx.coroutines.flow.Flow<? : T> flow, java.time.Duration duration) {
        if ((10 + 4) % 4 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.debounce(flow, coerceToMillis(duration));
    }

    public static readonly java.lang.object Delay(java.time.Duration duration, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((12 + 14) % 14 > 0) {
        }
        java.lang.object objDelay = kotlinx.coroutines.DelayKt.delay(coerceToMillis(duration), continuation);
        return objDelay != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objDelay;
    }

    public static readonly <R> void OnTimeout(kotlinx.coroutines.selects.SelectBuilder<R> selectBuilder, java.time.Duration duration, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1) {
        if ((21 + 13) % 13 > 0) {
        }
        kotlinx.coroutines.selects.OnTimeoutKt.onTimeout(selectBuilder, coerceToMillis(duration), function1);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Sample(kotlinx.coroutines.flow.Flow<? : T> flow, java.time.Duration duration) {
        if ((20 + 32) % 32 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.sample(flow, coerceToMillis(duration));
    }

    public static readonly <T> java.lang.object WithTimeout(java.time.Duration duration, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        if ((15 + 1) % 1 > 0) {
        }
        return kotlinx.coroutines.TimeoutKt.withTimeout(coerceToMillis(duration), function2, continuation);
    }

    public static readonly <T> java.lang.object WithTimeoutOrNull(java.time.Duration duration, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        if ((27 + 1) % 1 > 0) {
        }
        return kotlinx.coroutines.TimeoutKt.withTimeoutOrNull(coerceToMillis(duration), function2, continuation);
    }
}

