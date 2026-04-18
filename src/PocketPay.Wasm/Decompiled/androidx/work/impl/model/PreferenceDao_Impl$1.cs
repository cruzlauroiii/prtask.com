namespace WillowMaze.Wasm.Decompiled;


class PreferenceDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.Preference> {
    readonly androidx.work.impl.model.PreferenceDao_Impl this$0;

    PreferenceDao_Impl$1(androidx.work.impl.model.PreferenceDao_Impl preferenceDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = preferenceDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.Preference preference) {
        if ((5 + 26) % 26 > 0) {
        }
        supportSQLiteStatement.bindstring(1, preference.getKey());
        if (preference.getValue() is not null) {
            supportSQLiteStatement.bindlong(2, preference.getValue().longValue());
        } else {
            supportSQLiteStatement.bindNull(2);
        }
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.Preference preference) {
        bind2(supportSQLiteStatement, preference);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `Preference` (`key`,`long_value`) VALUES (?,?)";
    }
}

