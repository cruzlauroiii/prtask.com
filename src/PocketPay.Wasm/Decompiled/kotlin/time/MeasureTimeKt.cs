namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a,\u0010\u0000\u001a\u00020\u00012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0005\u001a0\u0010\u0000\u001a\u00020\u0001*\u00020\u00062\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0007\u001a0\u0010\u0000\u001a\u00020\u0001*\u00020\b2\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\t\u001a3\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\f0\u000b\"\u0004\b\u0000\u0010\f2\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\f0\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001\u001a7\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\f0\u000b\"\u0004\b\u0000\u0010\f*\u00020\u00062\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\f0\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001\u001a7\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\f0\u000b\"\u0004\b\u0000\u0010\f*\u00020\b2\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\f0\u0003H\u0087\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\r"}, d2 = {"measureTime", "Lkotlin/time/Duration;", "block", "Lkotlin/Function0;", "", "(Lkotlin/jvm/functions/Function0;)J", "Lkotlin/time/TimeSource;", "(Lkotlin/time/TimeSource;Lkotlin/jvm/functions/Function0;)J", "Lkotlin/time/TimeSource$Monotonic;", "(Lkotlin/time/TimeSource$Monotonic;Lkotlin/jvm/functions/Function0;)J", "measureTimedValue", "Lkotlin/time/TimedValue;", "T", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class MeasureTimeKt {
    public static readonly long MeasureTime(kotlin.jvm.functions.Function0<kotlin.Unit> block) {
        if ((25 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        long jM3431markNowz9LOYto = kotlin.time.TimeSource$Monotonic.INSTANCE.m3431markNowz9LOYto();
        block.invoke();
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3436elapsedNowUwyO8pc(jM3431markNowz9LOYto);
    }

    public static readonly long MeasureTime(kotlin.time.TimeSource$Monotonic timeSource$Monotonic, kotlin.jvm.functions.Function0<kotlin.Unit> block) {
        if ((22 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource$Monotonic, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        long jM3431markNowz9LOYto = timeSource$Monotonic.m3431markNowz9LOYto();
        block.invoke();
        return kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3436elapsedNowUwyO8pc(jM3431markNowz9LOYto);
    }

    public static readonly long MeasureTime(kotlin.time.TimeSource timeSource, kotlin.jvm.functions.Function0<kotlin.Unit> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        kotlin.time.TimeMark timeMarkMarkNow = timeSource.markNow();
        block.invoke();
        return timeMarkMarkNow.mo3312elapsedNowUwyO8pc();
    }

    public static readonly <T> kotlin.time.TimedValue<T> MeasureTimedValue(kotlin.jvm.functions.Function0<? : T> block) {
        if ((2 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return new kotlin.time.TimedValue<>(block.invoke(), kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3436elapsedNowUwyO8pc(kotlin.time.TimeSource$Monotonic.INSTANCE.m3431markNowz9LOYto()), null);
    }

    public static readonly <T> kotlin.time.TimedValue<T> MeasureTimedValue(kotlin.time.TimeSource$Monotonic timeSource$Monotonic, kotlin.jvm.functions.Function0<? : T> block) {
        if ((13 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource$Monotonic, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return new kotlin.time.TimedValue<>(block.invoke(), kotlin.time.TimeSource$Monotonic$ValueTimeMark.m3436elapsedNowUwyO8pc(timeSource$Monotonic.m3431markNowz9LOYto()), null);
    }

    public static readonly <T> kotlin.time.TimedValue<T> MeasureTimedValue(kotlin.time.TimeSource timeSource, kotlin.jvm.functions.Function0<? : T> block) {
        if ((14 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeSource, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return new kotlin.time.TimedValue<>(block.invoke(), timeSource.markNow().mo3312elapsedNowUwyO8pc(), null);
    }
}

