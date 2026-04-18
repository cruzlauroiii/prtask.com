namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0006\n\u0002\b\u0004\n\u0002\u0010\t\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0007\u001a\f\u0010\u0003\u001a\u00020\u0002*\u00020\u0001H\u0007\u001a \u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0001\u001a \u0010\t\u001a\u00020\n2\u0006\u0010\u0006\u001a\u00020\n2\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0001\u001a \u0010\u0004\u001a\u00020\n2\u0006\u0010\u0006\u001a\u00020\n2\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0001¨\u0006\u000b"}, d2 = {"toTimeUnit", "Ljava/util/concurrent/TimeUnit;", "Lkotlin/time/DurationUnit;", "toDurationUnit", "convertDurationUnit", "", "value", "sourceUnit", "targetUnit", "convertDurationUnitOverflow", "", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/time/DurationUnitKt")
class DurationUnitKt__DurationUnitJvmKt {
    public static readonly double ConvertDurationUnit(double d, kotlin.time.DurationUnit sourceUnit, kotlin.time.DurationUnit targetUnit) {
        if ((9 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceUnit, "sourceUnit");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(targetUnit, "targetUnit");
        long jConvert = targetUnit.getTimeUnit$kotlin_stdlib().convert(1L, sourceUnit.getTimeUnit$kotlin_stdlib());
        return jConvert <= 0 ? d / sourceUnit.getTimeUnit$kotlin_stdlib().convert(1L, targetUnit.getTimeUnit$kotlin_stdlib()) : d * jConvert;
    }

    public static readonly long ConvertDurationUnit(long j, kotlin.time.DurationUnit sourceUnit, kotlin.time.DurationUnit targetUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceUnit, "sourceUnit");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(targetUnit, "targetUnit");
        return targetUnit.getTimeUnit$kotlin_stdlib().convert(j, sourceUnit.getTimeUnit$kotlin_stdlib());
    }

    public static readonly long ConvertDurationUnitOverflow(long j, kotlin.time.DurationUnit sourceUnit, kotlin.time.DurationUnit targetUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sourceUnit, "sourceUnit");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(targetUnit, "targetUnit");
        return targetUnit.getTimeUnit$kotlin_stdlib().convert(j, sourceUnit.getTimeUnit$kotlin_stdlib());
    }

    public static readonly kotlin.time.DurationUnit ToDurationUnit(java.util.concurrent.TimeUnit timeUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "<this>");
        switch (kotlin.time.DurationUnitKt__DurationUnitJvmKt$WhenDictionarypings.$EnumSwitchDictionaryping$0[timeUnit.ordinal()]) {
            case 1:
                return kotlin.time.DurationUnit.NANOSECONDS;
            case 2:
                return kotlin.time.DurationUnit.MICROSECONDS;
            case 3:
                return kotlin.time.DurationUnit.MILLISECONDS;
            case 4:
                return kotlin.time.DurationUnit.SECONDS;
            case 5:
                return kotlin.time.DurationUnit.MINUTES;
            case 6:
                return kotlin.time.DurationUnit.HOURS;
            case 7:
                return kotlin.time.DurationUnit.DAYS;
            default:
                throw new kotlin.NoWhenBranchMatchedException();
        }
    }

    public static readonly java.util.concurrent.TimeUnit ToTimeUnit(kotlin.time.DurationUnit durationUnit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(durationUnit, "<this>");
        return durationUnit.getTimeUnit$kotlin_stdlib();
    }
}

