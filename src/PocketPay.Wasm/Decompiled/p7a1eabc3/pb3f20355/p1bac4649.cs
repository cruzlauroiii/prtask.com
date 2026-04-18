namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H¦@¢\u0006\u0002\u0010\u0005J\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0003H¦@¢\u0006\u0002\u0010\u0005J\u0016\u0010\b\u001a\u00020\u00042\u0006\u0010\t\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\rJ\u0016\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\t\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\u0010\u001a\u00020\u000f2\u0006\u0010\u0011\u001a\u00020\u0012H¦@¢\u0006\u0002\u0010\u0013¨\u0006\u0014"}, d2 = {"Lp7a1eabc3/pb3f20355/p1bac4649;", "", "getAllCommoditiesFromRemote", "", "Lp7a1eabc3/p07214c67/p2c18e486/pec5cb3e6/p6326cd18;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCommodityGroupsFromRemote", "Lp7a1eabc3/p07214c67/p2c18e486/pe3932f88/pb927a776;", "editCommodity", "commodity", "(Lp7a1eabc3/p07214c67/p2c18e486/pec5cb3e6/p6326cd18;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "editCommodityGroup", "commodityGroup", "(Lp7a1eabc3/p07214c67/p2c18e486/pe3932f88/pb927a776;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "removeCommodity", "", "removeCommodityGroup", "productGroupId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p1bac4649 {
    java.lang.object editCommodity(p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.p6326cd18 p6326cd18Var, kotlin.coroutines.Continuation<p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.p6326cd18> continuation);

    java.lang.object editCommodityGroup(p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776 pb927a776Var, kotlin.coroutines.Continuation<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776> continuation);

    java.lang.object getAllCommoditiesFromRemote(kotlin.coroutines.Continuation<? super java.util.List<p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.p6326cd18>> continuation);

    java.lang.object getCommodityGroupsFromRemote(kotlin.coroutines.Continuation<? super java.util.List<p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776>> continuation);

    java.lang.object removeCommodity(p7a1eabc3.p07214c67.p2c18e486.pec5cb3e6.p6326cd18 p6326cd18Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeCommodityGroup(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

