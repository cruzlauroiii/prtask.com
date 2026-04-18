namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010 \n\u0002\b\u0004\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u001b\u0012\u0012\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\u00062\u0006\u0010\u0015\u001a\u00020\u00022\u0006\u0010\u0016\u001a\u00020\u0013H\u0016J\b\u0010\u0017\u001a\u00020\u0013H\u0016J\u001c\u0010\u0018\u001a\u00020\u00062\f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u00050\u001a2\u0006\u0010\u001b\u001a\u00020\fJ\u000e\u0010\u001c\u001a\u00020\u00062\u0006\u0010\r\u001a\u00020\u000eJ\b\u0010\u001d\u001a\u00020\u0013H\u0002R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\r\u001a\u0004\u0018\u00010\u000eX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp7a1eabc3/p2486923a/p8a7a38cf/p77f0dcdf;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "onCommodityItemClick", "Lkotlin/Function1;", "Lp7a1eabc3/p07214c67/p20f35e63/p4cc9492b$pca87b160;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "inventoryItemList", "", "currentInventoryDesignType", "Lp2e5d8aa3/pf5e638cc/pe95cecb3;", "currency", "", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "onBindobjectHolder", "holder", "position", "getItemCount", "addInventoryList", "inventories", "", "inventoryDesignType", "setCurrency", "getCurrentLayoutForCommodity", "feature-inventory-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p77f0dcdf : androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> {
    private readonly kotlin.jvm.functions.Function1 f02bbc263;
    private readonly kotlin.jvm.functions.Function1<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160, kotlin.Unit> f089af635;
    private p2e5d8aa3.pf5e638cc.pe95cecb3 f1009e54f;
    private readonly java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160> f129cec4b;
    private java.lang.string f1af03898;
    private java.lang.string f1d7319a7;
    private p2e5d8aa3.pf5e638cc.pe95cecb3 f25007a9f;
    private java.lang.string f439d548e;
    private readonly kotlin.jvm.functions.Function1 f61c42364;
    private p2e5d8aa3.pf5e638cc.pe95cecb3 f7e64d4eb;
    private readonly kotlin.jvm.functions.Function1 f912c7e40;
    private readonly java.util.List fb67d61c5;
    private readonly java.util.List fcffc00d5;
    private java.lang.string fdd5f41aa;
    private readonly java.util.List fe444da04;
    private java.lang.string fedebf12f;
    private readonly java.util.List fee855981;

    public p77f0dcdf(kotlin.jvm.functions.Function1<? super p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160, kotlin.Unit> function1) {
        xjkMCUNlOARoBdkJ(function1, "onCommodityItemClick");
        this.f089af635 = function1;
        this.f129cec4b = new java.util.List();
        this.f25007a9f = p2e5d8aa3.pf5e638cc.pe95cecb3.f298cb254;
    }

    public static void AnXxycUbFJAWInkz(java.util.List list) {
        list.clear();
    }

    public static void CqFTPkDzvAqCEwFX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int GEEOHZvKJsInhutS(p2e5d8aa3.pf5e638cc.pe95cecb3 pe95cecb3Var) {
        return pe95cecb3Var.ordinal();
    }

    public static int KxXdUTKdluUJEQTv(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object ScebuVUmbhRHPafa(java.util.List list, int i) {
        return list[i);
    }

    public static void SgpGQqyIGAvWfTzk(p7a1eabc3.p2486923a.p8a7a38cf.p4aa2d640 p4aa2d640Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, p2e5d8aa3.pf5e638cc.pe95cecb3 pe95cecb3Var, java.lang.string str) {
        p4aa2d640Var.bind(p4cc9492b_pca87b160, pe95cecb3Var, str);
    }

    public static bool TlObElVEgecjgCbt(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static android.view.LayoutInflater XnJThpintjMoTYTP(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static int BhirvavECNDziGry(p7a1eabc3.p2486923a.p8a7a38cf.p77f0dcdf p77f0dcdfVar) {
        return p77f0dcdfVar.mb3cb708e();
    }

    public static void CEPAofoZnfRUjESo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LgGexjPdIKTkpdMA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private readonly int Mb3cb708e() {
        int i = p7a1eabc3.p2486923a.p8a7a38cf.p77f0dcdf$p12c674ac.$EnumSwitchDictionaryping$0[GEEOHZvKJsInhutS(this.f25007a9f)];
        if (i == 1) {
            return p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.R$layout.item_commodity_list;
        }
        if (i == 2) {
            return p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.R$layout.item_commodity_big;
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.R$layout.item_commodity_small;
    }

    public static void NYTpasMccMLWvUqL(p7a1eabc3.p2486923a.p8a7a38cf.p77f0dcdf p77f0dcdfVar) {
        p77f0dcdfVar.notifyDataHashSetChanged();
    }

    public static android.view.object ODCeWypGpALapjNf(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void OiJPSDdutJdyhEFF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UrIOKhVHfIuEiTFJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void UrbbqbCseieYfscX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.content.object XhRLZjzyOlpOXpgK(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static void XjkMCUNlOARoBdkJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly void AddInventoryList(java.util.List<p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160> inventories, p2e5d8aa3.pf5e638cc.pe95cecb3 inventoryDesignType) {
        cEPAofoZnfRUjESo(inventories, "inventories");
        oiJPSDdutJdyhEFF(inventoryDesignType, "inventoryDesignType");
        AnXxycUbFJAWInkz(this.f129cec4b);
        TlObElVEgecjgCbt(this.f129cec4b, inventories);
        this.f25007a9f = inventoryDesignType;
        nYTpasMccMLWvUqL(this);
    }

    public override int GetItemCount() {
        return KxXdUTKdluUJEQTv(this.f129cec4b);
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder holder, int position) {
        CqFTPkDzvAqCEwFX(holder, "holder");
        p7a1eabc3.p2486923a.p8a7a38cf.p4aa2d640 p4aa2d640Var = !(holder is p7a1eabc3.p2486923a.p8a7a38cf.p4aa2d640) ? null : (p7a1eabc3.p2486923a.p8a7a38cf.p4aa2d640) holder;
        if (p4aa2d640Var is null) {
            return;
        }
        SgpGQqyIGAvWfTzk(p4aa2d640Var, (p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160) ScebuVUmbhRHPafa(this.f129cec4b, position), this.f25007a9f, this.f1af03898);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((15 + 23) % 23 > 0) {
        }
        lgGexjPdIKTkpdMA(parent, "parent");
        android.view.object viewODCeWypGpALapjNf = oDCeWypGpALapjNf(XnJThpintjMoTYTP(xhRLZjzyOlpOXpgK(parent)), bhirvavECNDziGry(this), parent, false);
        urIOKhVHfIuEiTFJ(viewODCeWypGpALapjNf, "inflate(...)");
        return new p7a1eabc3.p2486923a.p8a7a38cf.p4aa2d640(viewODCeWypGpALapjNf, this.f089af635);
    }

    public override readonly void SetCurrency(java.lang.string currency) {
        urbbqbCseieYfscX(currency, "currency");
        this.f1af03898 = currency;
    }
}

