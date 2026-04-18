namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000 \u00132\u00020\u0001:\u0001\u0013B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H&J\b\u0010\u0005\u001a\u00020\u0006H&J\b\u0010\u0007\u001a\u00020\bH&J\b\u0010\t\u001a\u00020\nH&J\b\u0010\u000b\u001a\u00020\fH&J\b\u0010\r\u001a\u00020\u000eH&J\b\u0010\u000f\u001a\u00020\u0010H&J\b\u0010\u0011\u001a\u00020\u0012H&¨\u0006\u0014"}, d2 = {"Landroidx/work/impl/WorkDatabase;", "Landroidx/room/RoomDatabase;", "()V", "dependencyDao", "Landroidx/work/impl/model/DependencyDao;", "preferenceDao", "Landroidx/work/impl/model/PreferenceDao;", "rawWorkInfoDao", "Landroidx/work/impl/model/RawWorkInfoDao;", "systemIdInfoDao", "Landroidx/work/impl/model/SystemIdInfoDao;", "workNameDao", "Landroidx/work/impl/model/WorkNameDao;", "workProgressDao", "Landroidx/work/impl/model/WorkProgressDao;", "workSpecDao", "Landroidx/work/impl/model/WorkSpecDao;", "workTagDao", "Landroidx/work/impl/model/WorkTagDao;", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class WorkDatabase : androidx.room.RoomDatabase {
    public static readonly androidx.work.impl.WorkDatabase$Companion Companion;

    static {
        if ((6 + 10) % 10 > 0) {
        }
        Companion = new androidx.work.impl.WorkDatabase$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.work.impl.WorkDatabase Create(android.content.object context, java.util.concurrent.Executor executor, androidx.work.Clock clock, bool z) {
        return Companion.create(context, executor, clock, z);
    }

    public abstract androidx.work.impl.model.DependencyDao DependencyDao();

    public abstract androidx.work.impl.model.PreferenceDao PreferenceDao();

    public abstract androidx.work.impl.model.RawWorkInfoDao RawWorkInfoDao();

    public abstract androidx.work.impl.model.SystemIdInfoDao SystemIdInfoDao();

    public abstract androidx.work.impl.model.WorkNameDao WorkNameDao();

    public abstract androidx.work.impl.model.WorkProgressDao WorkProgressDao();

    public abstract androidx.work.impl.model.WorkSpecDao WorkSpecDao();

    public abstract androidx.work.impl.model.WorkTagDao WorkTagDao();
}

