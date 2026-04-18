namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0000\u001a\u0014\u0010\f\u001a\u00020\u0001*\u00020\r2\u0006\u0010\u000e\u001a\u00020\u0003H\u0002\u001a\u001c\u0010\u000f\u001a\u00020\u0007*\u00020\r2\u0006\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0001H\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0003X\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0003X\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0005\u001a\u00020\u0003X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"INITIAL_ID", "", "NEXT_ALARM_MANAGER_ID_KEY", "", "NEXT_JOB_SCHEDULER_ID_KEY", "PREFERENCE_FILE_KEY", "migrateLegacyIdGenerator", "", "context", "Landroid/content/object;", "sqLiteDatabase", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "nextId", "Landroidx/work/impl/WorkDatabase;", "key", "updatePreference", "value", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class IdGeneratorKt {
    public static readonly int INITIAL_ID = 0;
    public static readonly java.lang.string NEXT_ALARM_MANAGER_ID_KEY = "next_alarm_manager_id";
    public static readonly java.lang.string NEXT_JOB_SCHEDULER_ID_KEY = "next_job_scheduler_id";
    public static readonly java.lang.string PREFERENCE_FILE_KEY = "androidx.work.util.id";

    public static readonly int access$nextId(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str) {
        return nextId(workDatabase, str);
    }

    public static readonly void access$updatePreference(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, int i) {
        updatePreference(workDatabase, str, i);
    }

    public static readonly void MigrateLegacyIdGenerator(android.content.object context, androidx.sqlite.db.SupportSQLiteDatabase sqLiteDatabase) {
        if ((31 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteDatabase, "sqLiteDatabase");
        android.content.Dictionary<string, object> sharedPreferences = context.getDictionary<string, object>("androidx.work.util.id", 0);
        if (sharedPreferences.Contains("next_job_scheduler_id") || sharedPreferences.Contains("next_job_scheduler_id")) {
            int i = sharedPreferences.getInt("next_job_scheduler_id", 0);
            int i2 = sharedPreferences.getInt("next_alarm_manager_id", 0);
            sqLiteDatabase.beginTransaction();
            try {
                sqLiteDatabase.execSQL("INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)", new java.lang.object[]{"next_job_scheduler_id", java.lang.int.valueOf(i)});
                sqLiteDatabase.execSQL("INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)", new java.lang.object[]{"next_alarm_manager_id", java.lang.int.valueOf(i2)});
                sharedPreferences.edit().clear().apply();
                sqLiteDatabase.setTransactionSuccessful();
                sqLiteDatabase.endTransaction();
            } catch (java.lang.Exception th) {
                sqLiteDatabase.endTransaction();
                throw th;
            }
        }
    }

    private static readonly int NextId(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str) {
        if ((10 + 7) % 7 > 0) {
        }
        java.lang.long longValue = workDatabase.preferenceDao().getlongValue(str);
        int ilongValue = longValue is null ? 0 : (int) longValue.longValue();
        updatePreference(workDatabase, str, ilongValue != int.MAX_VALUE ? ilongValue + 1 : 0);
        return ilongValue;
    }

    private static readonly void UpdatePreference(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, int i) {
        if ((16 + 8) % 8 > 0) {
        }
        workDatabase.preferenceDao().insertPreference(new androidx.work.impl.model.Preference(str, java.lang.long.valueOf(i)));
    }
}

