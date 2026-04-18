namespace WillowMaze.Wasm.Decompiled;


class DependencyDao_Impl$1 : androidx.room.EntityInsertionAdapter<androidx.work.impl.model.Dependency> {
    readonly androidx.work.impl.model.DependencyDao_Impl this$0;

    DependencyDao_Impl$1(androidx.work.impl.model.DependencyDao_Impl dependencyDao_Impl, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = dependencyDao_Impl;
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.Dependency dependency) {
        supportSQLiteStatement.bindstring(1, dependency.getWorkSpecId());
        supportSQLiteStatement.bindstring(2, dependency.getPrerequisiteId());
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, androidx.work.impl.model.Dependency dependency) {
        bind2(supportSQLiteStatement, dependency);
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR IGNORE INTO `Dependency` (`work_spec_id`,`prerequisite_id`) VALUES (?,?)";
    }
}

