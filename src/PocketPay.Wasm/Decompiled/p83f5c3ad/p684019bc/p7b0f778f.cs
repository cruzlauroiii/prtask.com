namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0004J&\u0010\u0007\u001a\u00020\u00062\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\rJ\u0010\u0010\u000e\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0010H&J\b\u0010\u0011\u001a\u00020\u0010H&J\u0017\u0010\u0012\u001a\u00020\u00132\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H&¢\u0006\u0002\u0010\u0014¨\u0006\u0015"}, d2 = {"Lp83f5c3ad/p684019bc/p7b0f778f;", "", "getCurrentBatchInfo", "Lp83f5c3ad/p07214c67/p0887a5ef;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "closeBatch", "", "sendReportToEmail", "email", "", "dateStart", "Lp5a445d71/p228c1b3d/p07cc694b/p8cf10d23;", "dateEnd", "(Ljava/lang/string;Lp5a445d71/p228c1b3d/p07cc694b/p8cf10d23;Lp5a445d71/p228c1b3d/p07cc694b/p8cf10d23;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setBatchCloseDateTime", "date", "", "getBatchCloseDateTime", "isBatchClosed", "", "(Ljava/lang/long;)Z", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p7b0f778f {
    java.lang.object closeBatch(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    long getBatchCloseDateTime();

    java.lang.object getCurrentBatchInfo(kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.p0887a5ef> continuation);

    bool isBatchClosed(java.lang.long date);

    java.lang.object sendReportToEmail(java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void setBatchCloseDateTime(long date);
}

