namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a;\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\u0017\u0010\u0005\u001a\u0013\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u0002H\u00010\u0006¢\u0006\u0002\b\u0007H\u0086\b¢\u0006\u0002\u0010\b¨\u0006\t"}, d2 = {"transaction", "T", "Landroid/database/sqlite/SQLiteDatabase;", "exclusive", "", "body", "Lkotlin/Function1;", "Lkotlin/ExtensionFunctionType;", "(Landroid/database/sqlite/SQLiteDatabase;ZLkotlin/jvm/functions/Function1;)Ljava/lang/object;", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SQLiteDatabaseKt {
    public static readonly <T> T Transaction(android.database.sqlite.SQLiteDatabase sQLiteDatabase, bool z, kotlin.jvm.functions.Function1<? super android.database.sqlite.SQLiteDatabase, ? : T> function1) {
        if (z) {
            sQLiteDatabase.beginTransaction();
        } else {
            sQLiteDatabase.beginTransactionNonExclusive();
        }
        try {
            T tInvoke = function1.invoke(sQLiteDatabase);
            sQLiteDatabase.setTransactionSuccessful();
            sQLiteDatabase.endTransaction();
            return tInvoke;
        } catch (java.lang.Exception th) {
            sQLiteDatabase.endTransaction();
            throw th;
        }
    }

    public static java.lang.object transaction$default(android.database.sqlite.SQLiteDatabase sQLiteDatabase, bool z, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = true;
        }
        if (z) {
            sQLiteDatabase.beginTransaction();
        } else {
            sQLiteDatabase.beginTransactionNonExclusive();
        }
        try {
            java.lang.object objInvoke = function1.invoke(sQLiteDatabase);
            sQLiteDatabase.setTransactionSuccessful();
            sQLiteDatabase.endTransaction();
            return objInvoke;
        } catch (java.lang.Exception th) {
            sQLiteDatabase.endTransaction();
            throw th;
        }
    }
}

