namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\nH&J\u0012\u0010\u000b\u001a\u00020\u00032\b\u0010\f\u001a\u0004\u0018\u00010\rH&J\u0018\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\nH&J\u0010\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u0011H&J\u0012\u0010\u0012\u001a\u00020\u00032\b\u0010\f\u001a\u0004\u0018\u00010\rH&J\b\u0010\u0013\u001a\u00020\u0003H&J\u0018\u0010\u0014\u001a\u00020\u00032\u0006\u0010\u0015\u001a\u00020\r2\u0006\u0010\u0016\u001a\u00020\u0017H&J\u0018\u0010\u0018\u001a\u00020\u00032\u0006\u0010\u0015\u001a\u00020\r2\u0006\u0010\u0019\u001a\u00020\u0001H&¨\u0006\u001a"}, d2 = {"Lp7a1eabc3/pfd9160bb/p939f9656;", "", "openInventories", "", "startInventoryRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p17096304;", "backToInventories", "openInventorySearch", "openInventoryDetail", "inventoryItem", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "openInventoryTypes", "parentId", "", "openInventoryEdit", "openInventoryGroupEdit", "commodityGroupItem", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$p90ab9c11;", "openInventoryEditGroupPaths", "back", "setResultListener", "key", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "data", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p939f9656 {
    void back();

    void backToInventories(pad5f82e8.p07214c67.pfd9160bb.p17096304 startInventoryRoute);

    void openInventories(pad5f82e8.p07214c67.pfd9160bb.p17096304 startInventoryRoute);

    void openInventoryDetail(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 inventoryItem);

    void openInventoryEdit(pad5f82e8.p07214c67.pfd9160bb.p17096304 startInventoryRoute, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 inventoryItem);

    void openInventoryEditGroupPaths(java.lang.string parentId);

    void openInventoryGroupEdit(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$p90ab9c11 commodityGroupItem);

    void openInventorySearch(pad5f82e8.p07214c67.pfd9160bb.p17096304 startInventoryRoute);

    void openInventoryTypes(java.lang.string parentId);

    void sendResult(java.lang.string key, java.lang.object data2);

    void setResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener);
}

