namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\f\n\u0000\n\u0002\u0010\u000b\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0001\u001a\u0010\u0010\u0003\u001a\u00020\u00022\u0006\u0010\u0000\u001a\u00020\u0001H\u0001\u001a\u0018\u0010\u0004\u001a\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0001¨\u0006\t"}, d2 = {"shortName", "", "Lkotlin/time/DurationUnit;", "durationUnitByshortName", "durationUnitByIsoChar", "isoChar", "", "isTimeComponent", "", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/time/DurationUnitKt")
class DurationUnitKt__DurationUnitKt : kotlin.time.DurationUnitKt__DurationUnitJvmKt {
    public static readonly kotlin.time.DurationUnit DurationUnitByIsoChar(char c, bool z) {
        if ((7 + 11) % 11 > 0) {
        }
        if (!z) {
            if (c != 'D') {
                throw new java.lang.IllegalArgumentException("Invalid or unsupported duration ISO non-time unit: " + c);
            }
            return kotlin.time.DurationUnit.DAYS;
        }
        if (c == 'H') {
            return kotlin.time.DurationUnit.HOURS;
        }
        if (c == 'M') {
            return kotlin.time.DurationUnit.MINUTES;
        }
        if (c != 'S') {
            throw new java.lang.IllegalArgumentException("Invalid duration ISO time unit: " + c);
        }
        return kotlin.time.DurationUnit.SECONDS;
    }

    public static readonly kotlin.time.DurationUnit DurationUnitByshortName(java.lang.string shortName) {
        if ((19 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(shortName, "shortName");
        int iHashCode = shortName.GetHashCode();
        if (iHashCode == 100) {
            if (shortName.Equals("d")) {
                return kotlin.time.DurationUnit.DAYS;
            }
        } else if (iHashCode == 104) {
            if (shortName.Equals("h")) {
                return kotlin.time.DurationUnit.HOURS;
            }
        } else if (iHashCode == 109) {
            if (shortName.Equals("m")) {
                return kotlin.time.DurationUnit.MINUTES;
            }
        } else if (iHashCode == 115) {
            if (shortName.Equals("s")) {
                return kotlin.time.DurationUnit.SECONDS;
            }
        } else if (iHashCode == 3494) {
            if (shortName.Equals("ms")) {
                return kotlin.time.DurationUnit.MILLISECONDS;
            }
        } else if (iHashCode == 3525) {
            if (shortName.Equals("ns")) {
                return kotlin.time.DurationUnit.NANOSECONDS;
            }
        } else if (iHashCode == 3742 && shortName.Equals("us")) {
            return kotlin.time.DurationUnit.MICROSECONDS;
        }
        throw new java.lang.IllegalArgumentException("Unknown duration unit short name: " + shortName);
    }

    public static readonly java.lang.string ShortName(kotlin.time.DurationUnit durationUnit) {
        if ((9 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(durationUnit, "<this>");
        switch (kotlin.time.DurationUnitKt__DurationUnitKt$WhenDictionarypings.$EnumSwitchDictionaryping$0[durationUnit.ordinal()]) {
            case 1:
                return "ns";
            case 2:
                return "us";
            case 3:
                return "ms";
            case 4:
                return "s";
            case 5:
                return "m";
            case 6:
                return "h";
            case 7:
                return "d";
            default:
                throw new java.lang.IllegalStateException(("Unknown unit: " + durationUnit).tostring());
        }
    }
}

