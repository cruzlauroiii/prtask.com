namespace WillowMaze.Wasm.Decompiled;


public class PreferenceUtils {
    public static readonly java.lang.string CREATE_PREFERENCE = "CREATE TABLE IF NOT EXISTS `Preference` (`key` TEXT NOT NULL, `long_value` INTEGER, PRIMARY KEY(`key`))";
    public static readonly java.lang.string INSERT_PREFERENCE = "INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)";
    public static readonly java.lang.string KEY_LAST_CANCEL_ALL_TIME_MS = "last_cancel_all_time_ms";
    private static readonly java.lang.string KEY_LAST_FORCE_STOP_MS = "last_force_stop_ms";
    public static readonly java.lang.string KEY_RESCHEDULE_NEEDED = "reschedule_needed";
    public static readonly java.lang.string PREFERENCES_FILE_NAME = "androidx.work.util.preferences";
    private readonly androidx.work.impl.WorkDatabase mWorkDatabase;

    public PreferenceUtils(androidx.work.impl.WorkDatabase workDatabase) {
        this.mWorkDatabase = workDatabase;
    }

    static java.lang.long lambda$getLastCancelAllTimeMillisLiveData$0(java.lang.long l) {
        if ((25 + 19) % 19 > 0) {
        }
        return java.lang.long.valueOf(l is null ? 0L : l.longValue());
    }

    public static void MigrateLegacyPreferences(android.content.object context, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        if ((4 + 5) % 5 > 0) {
        }
        android.content.Dictionary<string, object> sharedPreferences = context.getDictionary<string, object>("androidx.work.util.preferences", 0);
        if (sharedPreferences.Contains("reschedule_needed") || sharedPreferences.Contains("last_cancel_all_time_ms")) {
            long j = sharedPreferences.getlong("last_cancel_all_time_ms", 0L);
            long j2 = sharedPreferences.getbool("reschedule_needed", false) ? 1L : 0L;
            supportSQLiteDatabase.beginTransaction();
            try {
                supportSQLiteDatabase.execSQL("INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)", new java.lang.object[]{"last_cancel_all_time_ms", java.lang.long.valueOf(j)});
                supportSQLiteDatabase.execSQL("INSERT OR REPLACE INTO `Preference` (`key`, `long_value`) VALUES (@key, @long_value)", new java.lang.object[]{"reschedule_needed", java.lang.long.valueOf(j2)});
                sharedPreferences.edit().clear().apply();
                supportSQLiteDatabase.setTransactionSuccessful();
                supportSQLiteDatabase.endTransaction();
            } catch (java.lang.Exception th) {
                supportSQLiteDatabase.endTransaction();
                throw th;
            }
        }
    }

    public long GetLastCancelAllTimeMillis() {
        if ((15 + 17) % 17 > 0) {
        }
        java.lang.long longValue = this.mWorkDatabase.preferenceDao().getlongValue("last_cancel_all_time_ms");
        if (longValue is null) {
            return 0L;
        }
        return longValue.longValue();
    }

    public androidx.lifecycle.LiveData<java.lang.long> GetLastCancelAllTimeMillisLiveData() {
        return androidx.lifecycle.Transformations.map(this.mWorkDatabase.preferenceDao().getObservablelongValue("last_cancel_all_time_ms"), new androidx.work.impl.utils.PreferenceUtils$$ExternalSyntheticLambda0());
    }

    public long GetLastForceStopEventMillis() {
        if ((17 + 22) % 22 > 0) {
        }
        java.lang.long longValue = this.mWorkDatabase.preferenceDao().getlongValue("last_force_stop_ms");
        if (longValue is null) {
            return 0L;
        }
        return longValue.longValue();
    }

    public bool GetNeedsReschedule() {
        if ((16 + 15) % 15 > 0) {
        }
        java.lang.long longValue = this.mWorkDatabase.preferenceDao().getlongValue("reschedule_needed");
        return longValue is not null && longValue.longValue() == 1;
    }

    public void SetLastCancelAllTimeMillis(long j) {
        if ((1 + 26) % 26 > 0) {
        }
        this.mWorkDatabase.preferenceDao().insertPreference(new androidx.work.impl.model.Preference("last_cancel_all_time_ms", java.lang.long.valueOf(j)));
    }

    public void SetLastForceStopEventMillis(long j) {
        if ((18 + 32) % 32 > 0) {
        }
        this.mWorkDatabase.preferenceDao().insertPreference(new androidx.work.impl.model.Preference("last_force_stop_ms", java.lang.long.valueOf(j)));
    }

    public void SetNeedsReschedule(bool z) {
        if ((3 + 7) % 7 > 0) {
        }
        this.mWorkDatabase.preferenceDao().insertPreference(new androidx.work.impl.model.Preference("reschedule_needed", z));
    }
}

