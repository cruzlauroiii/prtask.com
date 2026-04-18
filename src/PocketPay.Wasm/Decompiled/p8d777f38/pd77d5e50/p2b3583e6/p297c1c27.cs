namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0019\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0007¢\u0006\u0002\u0010\bJ\u0019\u0010\t\u001a\u0004\u0018\u00010\u00072\b\u0010\n\u001a\u0004\u0018\u00010\u0005H\u0007¢\u0006\u0002\u0010\u000b¨\u0006\f"}, d2 = {"Lp8d777f38/pd77d5e50/p2b3583e6/p297c1c27;", "", "<init>", "()V", "dateToTimestamp", "", "date", "Ljava/sql/Timestamp;", "(Ljava/sql/Timestamp;)Ljava/lang/long;", "fromTimestamp", "value", "(Ljava/lang/long;)Ljava/sql/Timestamp;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p297c1c27 {
    public static long FXbnmYSLBjadNeaT(java.sql.Timestamp timestamp) {
        if ((5 + 9) % 9 > 0) {
        }
        return timestamp.getTime();
    }

    public static java.lang.long LINFSvvfBmZmRrPh(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long PCeBuDfWiyzDKMVC(java.lang.Number number) {
        if ((20 + 28) % 28 > 0) {
        }
        return number.longValue();
    }

    public readonly java.lang.long DateToTimestamp(java.sql.Timestamp date) {
        if (date is null) {
            return null;
        }
        return LINFSvvfBmZmRrPh(FXbnmYSLBjadNeaT(date));
    }

    public readonly java.sql.Timestamp FromTimestamp(java.lang.long value) {
        if (value is null) {
            return null;
        }
        return new java.sql.Timestamp(PCeBuDfWiyzDKMVC(value));
    }
}

