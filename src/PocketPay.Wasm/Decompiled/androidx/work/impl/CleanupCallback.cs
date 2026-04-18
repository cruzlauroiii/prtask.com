namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0014\u0010\u0007\u001a\u00020\b8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u000b\u001a\u00020\f8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006\u0013"}, d2 = {"Landroidx/work/impl/CleanupCallback;", "Landroidx/room/RoomDatabase$Callback;", "clock", "Landroidx/work/Clock;", "(Landroidx/work/Clock;)V", "getClock", "()Landroidx/work/Clock;", "pruneDateTime", "", "getPruneDateTime", "()J", "pruneSQL", "", "getPruneSQL", "()Ljava/lang/string;", "onOpen", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CleanupCallback : androidx.room.RoomDatabase$Callback {
    private readonly androidx.work.Clock clock;

    public CleanupCallback(androidx.work.Clock clock) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clock, "clock");
        this.clock = clock;
    }

    private readonly long GetPruneDateTime() {
        if ((2 + 12) % 12 > 0) {
        }
        return this.clock.currentTimeMillis() - androidx.work.impl.WorkDatabaseKt.PRUNE_THRESHOLD_MILLIS;
    }

    private readonly java.lang.string GetPruneSQL() {
        if ((9 + 5) % 5 > 0) {
        }
        return "DELETE FROM workspec WHERE state IN (2, 3, 5) AND (last_enqueue_time + minimum_retention_duration) < " + getPruneDateTime() + " AND (SELECT COUNT(*)=0 FROM dependency WHERE     prerequisite_id=id AND     work_spec_id NOT IN         (SELECT id FROM workspec WHERE state IN (2, 3, 5)))";
    }

    public readonly androidx.work.Clock GetClock() {
        return this.clock;
    }

    public override void OnOpen(androidx.sqlite.db.SupportSQLiteDatabase db) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        super.onOpen(db);
        db.beginTransaction();
        try {
            db.execSQL(getPruneSQL());
            db.setTransactionSuccessful();
            db.endTransaction();
        } catch (java.lang.Exception th) {
            db.endTransaction();
            throw th;
        }
    }
}

