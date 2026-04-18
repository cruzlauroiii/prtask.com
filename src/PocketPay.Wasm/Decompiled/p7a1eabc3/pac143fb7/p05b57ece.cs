namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\t\bf\u0018\u00002\u00020\u0001J\u001e\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H¦@¢\u0006\u0002\u0010\u0007J\u001e\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H¦@¢\u0006\u0002\u0010\u0007J\u0016\u0010\t\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\u000bJ\u0018\u0010\f\u001a\u00020\u00062\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H¦@¢\u0006\u0002\u0010\u0007J\u0018\u0010\r\u001a\u00020\u00062\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H¦@¢\u0006\u0002\u0010\u0007J\u0012\u0010\u000e\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H&¨\u0006\u000f"}, d2 = {"Lp7a1eabc3/pac143fb7/p05b57ece;", "", "getNextInventoryGroups", "", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$p90ab9c11;", "parentId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPrevInventoryGroups", "editInventoryGroup", "inventoryGroupItem", "(Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$p90ab9c11;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getGroupPath", "getGroupParentName", "generateEmptyInventoryGroup", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p05b57ece {
    java.lang.object editInventoryGroup(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11 p4cc9492b_p90ab9c11, kotlin.coroutines.Continuation<? super p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11> continuation);

    p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11 generateEmptyInventoryGroup(java.lang.string parentId);

    java.lang.object getGroupParentName(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getGroupPath(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getNextInventoryGroups(java.lang.string str, kotlin.coroutines.Continuation<? super java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11>> continuation);

    java.lang.object getPrevInventoryGroups(java.lang.string str, kotlin.coroutines.Continuation<? super java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11>> continuation);
}

