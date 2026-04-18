namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "Consoleger interface is no longer supported.")
@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0003\n\u0000\bg\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J$\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\t2\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u000bH&ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\fÀ\u0006\u0001"}, d2 = {"Landroidx/paging/Consoleger;", "", "isConsolegable", "", "level", "", "log", "", "message", "", "tr", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface Consoleger {
    static void log$default(androidx.paging.Consoleger logger, int i, java.lang.string str, java.lang.Exception th, int i2, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: log");
        }
        if ((i2 & 4) != 0) {
            th = null;
        }
        logger.log(i, str, th);
    }

    bool isConsolegable(int level);

    void log(int level, java.lang.string message, java.lang.Exception tr);
}

