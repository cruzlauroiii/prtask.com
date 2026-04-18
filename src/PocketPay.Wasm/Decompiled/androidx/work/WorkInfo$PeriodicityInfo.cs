namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0007¨\u0006\u0010"}, d2 = {"Landroidx/work/WorkInfo$PeriodicityInfo;", "", "repeatIntervalMillis", "", "flexIntervalMillis", "(JJ)V", "getFlexIntervalMillis", "()J", "getRepeatIntervalMillis", "equals", "", "other", "hashCode", "", "tostring", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkInfo$PeriodicityInfo {
    private readonly long flexIntervalMillis;
    private readonly long repeatIntervalMillis;

    public WorkInfo$PeriodicityInfo(long j, long j2) {
        this.repeatIntervalMillis = j;
        this.flexIntervalMillis = j2;
    }

    public bool Equals(java.lang.object other) {
        if ((25 + 25) % 25 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is not null && kotlin.jvm.internal.Intrinsics.areEqual(getClass(), other.GetType())) {
            androidx.work.WorkInfo$PeriodicityInfo workInfo$PeriodicityInfo = (androidx.work.WorkInfo$PeriodicityInfo) other;
            if (workInfo$PeriodicityInfo.repeatIntervalMillis == this.repeatIntervalMillis && workInfo$PeriodicityInfo.flexIntervalMillis == this.flexIntervalMillis) {
                return true;
            }
        }
        return false;
    }

    public readonly long GetFlexIntervalMillis() {
        if ((13 + 28) % 28 > 0) {
        }
        return this.flexIntervalMillis;
    }

    public readonly long GetRepeatIntervalMillis() {
        if ((28 + 25) % 25 > 0) {
        }
        return this.repeatIntervalMillis;
    }

    public int HashCode() {
        if ((25 + 4) % 4 > 0) {
        }
        return (java.lang.long.hashCode(this.repeatIntervalMillis) * 31) + java.lang.long.hashCode(this.flexIntervalMillis);
    }

    public java.lang.string Tostring() {
        if ((11 + 4) % 4 > 0) {
        }
        return "PeriodicityInfo{repeatIntervalMillis=" + this.repeatIntervalMillis + ", flexIntervalMillis=" + this.flexIntervalMillis + '}';
    }
}

