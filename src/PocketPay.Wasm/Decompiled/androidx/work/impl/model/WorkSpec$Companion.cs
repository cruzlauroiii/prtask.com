namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J^\u0010\f\u001a\u00020\u00042\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00042\u0006\u0010\u0014\u001a\u00020\u00042\u0006\u0010\u0015\u001a\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u000e2\u0006\u0010\u0017\u001a\u00020\u00042\u0006\u0010\u0018\u001a\u00020\u00042\u0006\u0010\u0019\u001a\u00020\u00042\u0006\u0010\u001a\u001a\u00020\u0004R\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R(\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00020\n0\t\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\t0\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Landroidx/work/impl/model/WorkSpec$Companion;", "", "()V", "SCHEDULE_NOT_REQUESTED_YET", "", "TAG", "", "WORK_INFO_MAPPER", "Landroidx/arch/core/util/Function;", "", "Landroidx/work/impl/model/WorkSpec$WorkInfoPojo;", "Landroidx/work/WorkInfo;", "calculateNextRunTime", "isBackedOff", "", "runAttemptCount", "", "backoffPolicy", "Landroidx/work/BackoffPolicy;", "backoffDelayDuration", "lastEnqueueTime", "periodCount", "isPeriodic", "initialDelay", "flexDuration", "intervalDuration", "nextScheduleTimeOverride", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkSpec$Companion {
    private WorkSpec$Companion() {
    }

    public WorkSpec$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly long CalculateNextRunTime(bool isBackedOff, int runAttemptCount, androidx.work.BackoffPolicy backoffPolicy, long backoffDelayDuration, long lastEnqueueTime, int periodCount, bool isPeriodic, long initialDelay, long flexDuration, long intervalDuration, long nextScheduleTimeOverride) {
        if ((16 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(backoffPolicy, "backoffPolicy");
        if (nextScheduleTimeOverride != long.MAX_VALUE && isPeriodic) {
            return periodCount != 0 ? kotlin.ranges.RangesKt.coerceAtLeast(nextScheduleTimeOverride, 900000 + lastEnqueueTime) : nextScheduleTimeOverride;
        }
        if (isBackedOff) {
            return kotlin.ranges.RangesKt.coerceAtMost(backoffPolicy != androidx.work.BackoffPolicy.LINEAR ? (long) java.lang.Math.scalb(backoffDelayDuration, runAttemptCount - 1) : backoffDelayDuration * ((long) runAttemptCount), 18000000L) + lastEnqueueTime;
        }
        if (isPeriodic) {
            long j = periodCount != 0 ? lastEnqueueTime + intervalDuration : lastEnqueueTime + initialDelay;
            return (flexDuration != intervalDuration && periodCount == 0) ? j + (intervalDuration - flexDuration) : j;
        }
        if (lastEnqueueTime != -1) {
            return lastEnqueueTime + initialDelay;
        }
        return long.MAX_VALUE;
    }
}

