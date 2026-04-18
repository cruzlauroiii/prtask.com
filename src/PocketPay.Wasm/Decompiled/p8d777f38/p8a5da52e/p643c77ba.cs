namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eJ\u001a\u0010\u0002\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\u00040\u0003H§@¢\u0006\u0002\u0010\u0006J$\u0010\u0007\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00040\u00032\b\b\u0001\u0010\t\u001a\u00020\nH§@¢\u0006\u0002\u0010\u000bJ$\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\u00040\u00032\b\b\u0001\u0010\t\u001a\u00020\nH§@¢\u0006\u0002\u0010\u000b¨\u0006\u000f"}, d2 = {"Lp8d777f38/p8a5da52e/p643c77ba;", "", "getRegions", "Lretrofit2/Response;", "", "Lpad5f82e8/p07214c67/p960db2ed/p9c442011;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getMeasures", "Lpad5f82e8/p07214c67/p7a1eabc3/p41e5b820;", "region", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getTaxes", "Lpad5f82e8/p07214c67/p7a1eabc3/p09e6c013;", "Companion", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p643c77ba {
    public static readonly p8d777f38.p8a5da52e.p643c77ba$p910eef8c f1a19b0ed = null;
    public static readonly p8d777f38.p8a5da52e.p643c77ba$p910eef8c f34fa47ef = null;
    public static readonly p8d777f38.p8a5da52e.p643c77ba$p910eef8c f910eef8c = p8d777f38.p8a5da52e.p643c77ba$p910eef8c.$$INSTANCE;
    public static readonly p8d777f38.p8a5da52e.p643c77ba$p910eef8c f925e7794 = null;

    @paa20ed97.p80791b3a.p7528035a("api/v1/directory/measurement/units")
    java.lang.object getMeasures(@paa20ed97.p80791b3a.p66c1b4c7("region") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pad5f82e8.p07214c67.p7a1eabc3.p41e5b820>>> continuation);

    @paa20ed97.p80791b3a.p7528035a("api/v1/directory/region")
    java.lang.object getRegions(kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pad5f82e8.p07214c67.p960db2ed.p9c442011>>> continuation);

    @paa20ed97.p80791b3a.p7528035a("api/v1/directory/tax")
    java.lang.object getTaxes(@paa20ed97.p80791b3a.p66c1b4c7("region") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pad5f82e8.p07214c67.p7a1eabc3.p09e6c013>>> continuation);
}

