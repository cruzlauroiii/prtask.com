namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J \u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0005H&J \u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000b2\b\b\u0002\u0010\b\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\fJ\u0016\u0010\r\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\u000e¨\u0006\u000f"}, d2 = {"Lpad5f82e8/pac143fb7/p1e11b989/p4757fe07/p606d2648;", "", "createPosition", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "price", "Ljava/math/decimal;", "positionName", "", "quantity", "createPositionWithCommodityItem", "commodity", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "(Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;Ljava/math/decimal;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "createPaybackPositionWithCommodityItemFromBarcode", "(Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p606d2648 {
    java.lang.object createPaybackPositionWithCommodityItemFromBarcode(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.pd031d465> continuation);

    pad5f82e8.p07214c67.p1e11b989.pd031d465 createPosition(java.math.decimal price, java.lang.string positionName, java.math.decimal quantity);

    java.lang.object createPositionWithCommodityItem(p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, java.math.decimal bigDecimal, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.pd031d465> continuation);
}

