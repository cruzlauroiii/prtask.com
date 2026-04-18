namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0006\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\u0005\u001a\u00020\u0006X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$CallbackException;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "callbackName", "Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$CallbackName;", "cause", "", "(Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$CallbackName;Ljava/lang/Exception;)V", "getCallbackName", "()Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$CallbackName;", "getCause", "()Ljava/lang/Exception;", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FrameworkSQLiteOpenHelper$OpenHelper$CallbackException : java.lang.Exception {
    private readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName callbackName;
    private readonly java.lang.Exception cause;

    public FrameworkSQLiteOpenHelper$OpenHelper$CallbackException(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName callbackName, java.lang.Exception cause) {
        super(cause);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callbackName, "callbackName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cause, "cause");
        this.callbackName = callbackName;
        this.cause = cause;
    }

    public readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName getCallbackName() {
        return this.callbackName;
    }

    public override java.lang.Exception GetCause() {
        return this.cause;
    }
}

