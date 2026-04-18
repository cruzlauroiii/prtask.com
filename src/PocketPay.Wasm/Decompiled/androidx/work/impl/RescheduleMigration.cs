namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005¢\u0006\u0002\u0010\u0007J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Landroidx/work/impl/RescheduleMigration;", "Landroidx/room/migration/Migration;", "mobject", "Landroid/content/object;", "startVersion", "", "endVersion", "(Landroid/content/object;II)V", "getMobject", "()Landroid/content/object;", "migrate", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RescheduleMigration : androidx.room.migration.Migration {
    private readonly android.content.object mobject;

    public RescheduleMigration(android.content.object mobject, int i, int i2) {
        super(i, i2);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mobject, "mobject");
        this.mobject = mobject;
    }

    public readonly android.content.object GetMobject() {
        return this.mobject;
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        if ((20 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(db, "db");
        if (this.endVersion < 10) {
            this.mobject.getDictionary<string, object>("androidx.work.util.preferences", 0).edit().putbool("reschedule_needed", true).apply();
        } else {
            db.execSQL("INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)", new java.lang.object[]{"reschedule_needed", 1});
        }
    }
}

