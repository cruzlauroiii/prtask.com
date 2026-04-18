namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore$$ExternalSyntheticLambda12 : com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function {
    public readonly java.lang.string f$0;
    public readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason f$1;
    public readonly long f$2;

    public SQLiteEventStore$$ExternalSyntheticLambda12(java.lang.string str, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, long j) {
        this.f$0 = str;
        this.f$1 = logEventDropped$Reason;
        this.f$2 = j;
    }

    public static java.lang.object SUxqlsQMqoIOfdyI(java.lang.string str, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore.lambda$recordConsoleEventDropped$18(str, logEventDropped$Reason, j, sQLiteDatabase);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        if ((2 + 16) % 16 > 0) {
        }
        return SUxqlsQMqoIOfdyI(this.f$0, this.f$1, this.f$2, (android.database.sqlite.SQLiteDatabase) obj);
    }
}

