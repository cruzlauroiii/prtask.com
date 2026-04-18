namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b6\u0018\u00002\u00020\u0001:\u0002\u000e\u000fB)\b\u0004\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u000e\u0010\u0005\u001a\n\u0012\u0004\u0012\u00020\u0003\u0018\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0019\u0010\u0005\u001a\n\u0012\u0004\u0012\u00020\u0003\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r\u0082\u0001\u0002\u0010\u0011¨\u0006\u0012"}, d2 = {"Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b;", "", "inventoryId", "", "inventoryName", "inventoryBarCodes", "", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/util/List;)V", "getInventoryId", "()Ljava/lang/string;", "getInventoryName", "getInventoryBarCodes", "()Ljava/util/List;", "CommodityItem", "CommodityGroupItem", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$p90ab9c11;", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class p4cc9492b {
    private readonly java.lang.string f2b2eed7c;
    private readonly java.util.List<java.lang.string> f3687212b;
    private readonly java.util.List f406f2caa;
    private readonly java.lang.string f5af753a4;
    private readonly java.util.List f6c5a83ff;
    private readonly java.lang.string f6dbf02ac;
    private readonly java.util.List f7b979094;
    private readonly java.lang.string f84aa9876;
    private readonly java.util.List fd1ee56a6;
    private readonly java.lang.string fd7e53e3f;
    private readonly java.lang.string fff3b0af8;

    private p4cc9492b(java.lang.string str, java.lang.string str2, java.util.List<java.lang.string> list) {
        this.f84aa9876 = str;
        this.f2b2eed7c = str2;
        this.f3687212b = list;
    }

    public p4cc9492b(java.lang.string str, java.lang.string str2, java.util.List list, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, str2, list);
    }

    public readonly java.util.List<java.lang.string> GetInventoryBarCodes() {
        return this.f3687212b;
    }

    public readonly java.lang.string GetInventoryId() {
        return this.f84aa9876;
    }

    public readonly java.lang.string GetInventoryName() {
        return this.f2b2eed7c;
    }
}

