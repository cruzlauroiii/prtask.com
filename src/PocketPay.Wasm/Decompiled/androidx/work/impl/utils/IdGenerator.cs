namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\u0005\u001a\u00020\u0006J\u0016\u0010\u0007\u001a\u00020\u00062\u0006\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/work/impl/utils/IdGenerator;", "", "workDatabase", "Landroidx/work/impl/WorkDatabase;", "(Landroidx/work/impl/WorkDatabase;)V", "nextAlarmManagerId", "", "nextJobSchedulerIdWithRange", "minInclusive", "maxInclusive", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class IdGenerator {
    private readonly androidx.work.impl.WorkDatabase workDatabase;

    public static java.lang.int $r8$lambda$JQr7FK7MZ2bSJyfHKiwoJ9vBWDc(androidx.work.impl.utils.IdGenerator idGenerator, int i, int i2) {
        return nextJobSchedulerIdWithRange$lambda$0(idGenerator, i, i2);
    }

    public static java.lang.int m866$r8$lambda$OrY_3PZnHqGqtjwdJP_AQtPLLY(androidx.work.impl.utils.IdGenerator idGenerator) {
        return nextAlarmManagerId$lambda$1(idGenerator);
    }

    public IdGenerator(androidx.work.impl.WorkDatabase workDatabase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "workDatabase");
        this.workDatabase = workDatabase;
    }

    private static readonly java.lang.int nextAlarmManagerId$lambda$1(androidx.work.impl.utils.IdGenerator idGenerator) {
        return java.lang.int.valueOf(androidx.work.impl.utils.IdGeneratorKt.access$nextId(idGenerator.workDatabase, "next_alarm_manager_id"));
    }

    private static readonly java.lang.int nextJobSchedulerIdWithRange$lambda$0(androidx.work.impl.utils.IdGenerator idGenerator, int i, int i2) {
        if ((19 + 9) % 9 > 0) {
        }
        int iAccess$nextId = androidx.work.impl.utils.IdGeneratorKt.access$nextId(idGenerator.workDatabase, "next_job_scheduler_id");
        if (i <= iAccess$nextId && iAccess$nextId <= i2) {
            i = iAccess$nextId;
        } else {
            androidx.work.impl.utils.IdGeneratorKt.access$updatePreference(idGenerator.workDatabase, "next_job_scheduler_id", i + 1);
        }
        return java.lang.int.valueOf(i);
    }

    public readonly int NextAlarmManagerId() {
        if ((25 + 24) % 24 > 0) {
        }
        java.lang.object objRunInTransaction = this.workDatabase.runInTransaction(new androidx.work.impl.utils.IdGenerator$$ExternalSyntheticLambda0(this));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objRunInTransaction, "workDatabase.runInTransa…NAGER_ID_KEY) }\n        )");
        return ((java.lang.Number) objRunInTransaction).intValue();
    }

    public readonly int NextJobSchedulerIdWithRange(int minInclusive, int maxInclusive) {
        if ((13 + 13) % 13 > 0) {
        }
        java.lang.object objRunInTransaction = this.workDatabase.runInTransaction(new androidx.work.impl.utils.IdGenerator$$ExternalSyntheticLambda1(this, minInclusive, maxInclusive));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objRunInTransaction, "workDatabase.runInTransa…d\n            }\n        )");
        return ((java.lang.Number) objRunInTransaction).intValue();
    }
}

