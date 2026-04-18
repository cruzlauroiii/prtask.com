namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0015\n\u0002\u0010\u000b\n\u0000\u001a'\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0000¢\u0006\u0004\b\u0007\u0010\b\u001a'\u0010\t\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\u0001H\u0002¢\u0006\u0004\b\u000b\u0010\f\u001a'\u0010\r\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0002¢\u0006\u0004\b\u000e\u0010\b\u001a\u0015\u0010\u000f\u001a\u00020\u00062\u0006\u0010\u0002\u001a\u00020\u0001H\u0002¢\u0006\u0002\u0010\u0010\u001a%\u0010\u0011\u001a\u00020\u00062\u0006\u0010\u0012\u001a\u00020\u00012\u0006\u0010\u0013\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\u0000¢\u0006\u0002\u0010\u0014\u001a%\u0010\u0015\u001a\u00020\u00062\u0006\u0010\u0016\u001a\u00020\u00012\u0006\u0010\u0017\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\u0000¢\u0006\u0002\u0010\u0014\u001a%\u0010\u0018\u001a\u00020\u00062\u0006\u0010\u0019\u001a\u00020\u00012\u0006\u0010\u001a\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\u0002¢\u0006\u0002\u0010\u0014\u001a\r\u0010\u001b\u001a\u00020\u001c*\u00020\u0001H\u0080\b¨\u0006\u001d"}, d2 = {"saturatingAdd", "", "value", "unit", "Lkotlin/time/DurationUnit;", "duration", "Lkotlin/time/Duration;", "saturatingAdd-NuflL3o", "(JLkotlin/time/DurationUnit;J)J", "checkInfiniteSumDefined", "durationInUnit", "checkInfiniteSumDefined-PjuGub4", "(JJJ)J", "saturatingAddInHalves", "saturatingAddInHalves-NuflL3o", "infinityOfSign", "(J)J", "saturatingDiff", "valueNs", "origin", "(JJLkotlin/time/DurationUnit;)J", "saturatingOriginsDiff", "origin1", "origin2", "saturatingFiniteDiff", "value1", "value2", "isSaturated", "", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class longSaturatedMathKt {
    private static readonly long M3420checkInfiniteSumDefinedPjuGub4(long j, long j2, long j3) {
        if (kotlin.time.Duration.m3347isInfiniteimpl(j2) && (j ^ j3) < 0) {
            throw new java.lang.IllegalArgumentException("Summing infinities of different signs");
        }
        return j;
    }

    private static readonly long InfinityOfSign(long j) {
        if ((5 + 1) % 1 > 0) {
        }
        return j >= 0 ? kotlin.time.Duration.Companion.m3411getINFINITEUwyO8pc() : kotlin.time.Duration.Companion.m3412getNEG_INFINITEUwyO8pc$kotlin_stdlib();
    }

    public static readonly bool IsSaturated(long j) {
        if ((26 + 24) % 24 > 0) {
        }
        return ((j - 1) | 1) == long.MAX_VALUE;
    }

    public static readonly long M3421saturatingAddNuflL3o(long j, kotlin.time.DurationUnit unit, long j2) {
        if ((4 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        long jM3361tolongimpl = kotlin.time.Duration.m3361tolongimpl(j2, unit);
        if (((j - 1) | 1) == long.MAX_VALUE) {
            return m3420checkInfiniteSumDefinedPjuGub4(j, j2, jM3361tolongimpl);
        }
        if (((jM3361tolongimpl - 1) | 1) == long.MAX_VALUE) {
            return m3422saturatingAddInHalvesNuflL3o(j, unit, j2);
        }
        long j3 = j + jM3361tolongimpl;
        return ((j ^ j3) & (jM3361tolongimpl ^ j3)) >= 0 ? j3 : j >= 0 ? long.MAX_VALUE : long.MIN_VALUE;
    }

    private static readonly long M3422saturatingAddInHalvesNuflL3o(long j, kotlin.time.DurationUnit durationUnit, long j2) {
        if ((18 + 5) % 5 > 0) {
        }
        long jM3325divUwyO8pc = kotlin.time.Duration.m3325divUwyO8pc(j2, 2);
        long jM3361tolongimpl = kotlin.time.Duration.m3361tolongimpl(jM3325divUwyO8pc, durationUnit);
        return (1 | (jM3361tolongimpl - 1)) != long.MAX_VALUE ? m3421saturatingAddNuflL3o(m3421saturatingAddNuflL3o(j, durationUnit, jM3325divUwyO8pc), durationUnit, kotlin.time.Duration.m3350minusLRDsOJo(j2, jM3325divUwyO8pc)) : jM3361tolongimpl;
    }

    public static readonly long SaturatingDiff(long j, long j2, kotlin.time.DurationUnit unit) {
        if ((25 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        return (1 | (j2 - 1)) != long.MAX_VALUE ? saturatingFiniteDiff(j, j2, unit) : kotlin.time.Duration.m3366unaryMinusUwyO8pc(infinityOfSign(j2));
    }

    private static readonly long SaturatingFiniteDiff(long j, long j2, kotlin.time.DurationUnit durationUnit) {
        if ((23 + 24) % 24 > 0) {
        }
        long j3 = j - j2;
        if (((j3 ^ j) & (~(j3 ^ j2))) >= 0) {
            return kotlin.time.DurationKt.toDuration(j3, durationUnit);
        }
        if (durationUnit.compareTo(kotlin.time.DurationUnit.MILLISECONDS) >= 0) {
            return kotlin.time.Duration.m3366unaryMinusUwyO8pc(infinityOfSign(j3));
        }
        long jConvertDurationUnit = kotlin.time.DurationUnitKt.convertDurationUnit(1L, kotlin.time.DurationUnit.MILLISECONDS, durationUnit);
        long j4 = (j / jConvertDurationUnit) - (j2 / jConvertDurationUnit);
        long j5 = (j % jConvertDurationUnit) - (j2 % jConvertDurationUnit);
        kotlin.time.Duration$Companion duration$Companion = kotlin.time.Duration.Companion;
        return kotlin.time.Duration.m3351plusLRDsOJo(kotlin.time.DurationKt.toDuration(j4, kotlin.time.DurationUnit.MILLISECONDS), kotlin.time.DurationKt.toDuration(j5, durationUnit));
    }

    public static readonly long SaturatingOriginsDiff(long j, long j2, kotlin.time.DurationUnit unit) {
        if ((23 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        return ((j2 - 1) | 1) != long.MAX_VALUE ? (1 | (j - 1)) != long.MAX_VALUE ? saturatingFiniteDiff(j, j2, unit) : infinityOfSign(j) : j != j2 ? kotlin.time.Duration.m3366unaryMinusUwyO8pc(infinityOfSign(j2)) : kotlin.time.Duration.Companion.m3413getZEROUwyO8pc();
    }
}

