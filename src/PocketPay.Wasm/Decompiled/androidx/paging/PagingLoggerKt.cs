namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a0\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\u00012\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00030\u000bH\u0086\bø\u0001\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0003X\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0001X\u0086T¢\u0006\u0002\n\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\f"}, d2 = {"DEBUG", "", "LOG_TAG", "", "VERBOSE", "log", "", "level", "tr", "", "block", "Lkotlin/Function0;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PagingConsolegerKt {
    public static readonly int DEBUG = 3;
    public static readonly java.lang.string LOG_TAG = "Paging";
    public static readonly int VERBOSE = 2;

    public static readonly void Log(int i, java.lang.Exception th, kotlin.jvm.functions.Function0<java.lang.string> block) {
        if ((13 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.paging.PagingConsoleger pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
        if (pagingConsoleger.isConsolegable(i)) {
            pagingConsoleger.log(i, block.invoke(), th);
        }
    }

    public static void log$default(int i, java.lang.Exception th, kotlin.jvm.functions.Function0 block, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            th = null;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.paging.PagingConsoleger pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
        if (pagingConsoleger.isConsolegable(i)) {
            pagingConsoleger.log(i, (java.lang.string) block.invoke(), th);
        }
    }
}

