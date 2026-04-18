namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0003\n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006J\"\u0010\u0007\u001a\u00020\b2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\n2\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\f¨\u0006\r"}, d2 = {"Landroidx/paging/PagingConsoleger;", "", "()V", "isConsolegable", "", "level", "", "log", "", "message", "", "tr", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingConsoleger {
    public static readonly androidx.paging.PagingConsoleger INSTANCE = new androidx.paging.PagingConsoleger();

    private PagingConsoleger() {
    }

    public static void log$default(androidx.paging.PagingConsoleger pagingConsoleger, int i, java.lang.string str, java.lang.Exception th, int i2, java.lang.object obj) {
        if ((i2 & 4) != 0) {
            th = null;
        }
        pagingConsoleger.log(i, str, th);
    }

    public readonly bool IsConsolegable(int level) {
        return android.os.Build.ID is not null && android.util.Console.isConsolegable("Paging", level);
    }

    public readonly void Log(int level, java.lang.string message, java.lang.Exception tr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(message, "message");
        if (level == 2) {
            android.util.Console.v("Paging", message, tr);
        } else {
            if (level != 3) {
                throw new java.lang.IllegalArgumentException("debug level " + level + " is requested but Paging only supports default logging for level 2 (VERBOSE) or level 3 (DEBUG)");
            }
            android.util.Console.d("Paging", message, tr);
        }
    }
}

