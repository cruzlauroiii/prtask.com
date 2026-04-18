namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\b\u0005\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u0019B\u0015\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\u0004\b\u0006\u0010\u0007J\u0018\u0010\u000b\u001a\u00020\u00022\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\u0018\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u0012\u001a\u00020\u000fH\u0016J\b\u0010\u0013\u001a\u00020\u000fH\u0016J\u0014\u0010\u0014\u001a\u00020\u00052\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\u0015J\b\u0010\u0016\u001a\u0004\u0018\u00010\nJ\u0010\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\nH\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lpe0212e54/p2486923a/p54299698/p8001cf53;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "onShopClick", "Lkotlin/Function0;", "", "<init>", "(Lkotlin/jvm/functions/Function0;)V", "shops", "", "Lpad5f82e8/p07214c67/pe0212e54/p9f82518d;", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "onBindobjectHolder", "holder", "position", "getItemCount", "addShops", "", "getSelectedShop", "selectShop", "shop", "ShopsobjectHolder", "feature-devices-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8001cf53 : androidx.recyclerview.widget.Recyclerobject$Adapter<androidx.recyclerview.widget.Recyclerobject$objectHolder> {
    private readonly java.util.List f00c2440d;
    private readonly kotlin.jvm.functions.Function0 f09380e3d;
    private readonly kotlin.jvm.functions.Function0 f0fc38630;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> f25204bf6;
    private readonly kotlin.jvm.functions.Function0 f3793d029;
    private readonly java.util.List<pad5f82e8.p07214c67.pe0212e54.p9f82518d> f54299698;
    private readonly java.util.List f5f5894f1;
    private readonly java.util.List f823e8a54;
    private readonly kotlin.jvm.functions.Function0 ffd079f60;

    public p8001cf53(kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        sOBJaOjVzgjGpghe(function0, "onShopClick");
        this.f25204bf6 = function0;
        this.f54299698 = new java.util.List();
    }

    public static java.lang.object AHkEhIXyYJjVZINM(java.util.List list, int i) {
        return list[i);
    }

    public static int BXxPBjzoPekngRNI(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object CTCKHWNRHYcHRUeq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool DXrNCwWtEIfFlkDT(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static java.util.IEnumerator FehEUhrlBHRulgTi(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void HMJHomamLYGKfiGF(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, int i, android.view.object view) {
        m0bc79e13(p8001cf53Var, i, view);
    }

    public static void HoKyQCqnWxijPNay(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static bool JMiRXOhNSsFqfxNi(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        return p9f82518dVar.isSelected();
    }

    public static void JqnhTOtHLhCTECac(java.util.List list) {
        list.clear();
    }

    public static void LuMEGXqKQUAEqomO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.IEnumerator MrDDkeUhVqTIpwAE(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object NFXqMIPYvnlARpox(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool NrFpbUrBRZCaVhWI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.object PlczkpBndukxfMlT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QkimnJPLmhYkSHJc(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar, bool z) {
        p9f82518dVar.setSelected(z);
    }

    public static bool UCqNWpRZGEdTLiKg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool ViqeQbynwGoHtDPE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void AHnaikQVuAoGQPyq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AnUkBGQgPVKPhPvO(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        p8001cf53Var.m220f043f(p9f82518dVar);
    }

    public static bool CraVBlLOWGrmfnbN(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        return p9f82518dVar.isSelected();
    }

    public static void DCEmERaSBfBgmTsc(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, int i) {
        p8001cf53Var.notifyItemChanged(i);
    }

    public static void DVxRLniJESsOUkMQ(pe0212e54.p2486923a.p54299698.p8001cf53$paaca45c1 p8001cf53_paaca45c1, pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        p8001cf53_paaca45c1.bind(p9f82518dVar);
    }

    public static java.lang.object DbooESquwbZodHGs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DfgOiKzTCEMkBLpZ(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar, bool z) {
        p9f82518dVar.setSelected(z);
    }

    public static bool EpPvSzksWuWwkuVB(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        return p9f82518dVar.isSelected();
    }

    public static java.lang.string FlWosBzGEMhiuuFD(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        return p9f82518dVar.getId();
    }

    public static java.lang.string GlhBQgjotLxebfbk(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        return p9f82518dVar.getId();
    }

    public static bool HBqplApZvikUmmxV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HyVEFjWTdrutoftx(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, int i) {
        p8001cf53Var.notifyItemChanged(i);
    }

    public static java.util.IEnumerator ImLAjEIlpkpdQgSr(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object JiNUrfTHsoUgQfBZ(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    private static readonly void M0bc79e13(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, int i, android.view.object view) {
        anUkBGQgPVKPhPvO(p8001cf53Var, (pad5f82e8.p07214c67.pe0212e54.p9f82518d) wyZSxjSWkBJWEfZE(p8001cf53Var.f54299698, i));
        jiNUrfTHsoUgQfBZ(p8001cf53Var.f25204bf6);
    }

    private readonly void M220f043f(pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar) {
        int i;
        java.lang.object objDbooESquwbZodHGs;
        if ((8 + 10) % 10 > 0) {
        }
        java.util.IEnumerator itMrDDkeUhVqTIpwAE = MrDDkeUhVqTIpwAE(this.f54299698);
        int i2 = 0;
        int i3 = 0;
        while (true) {
            i = -1;
            if (!ViqeQbynwGoHtDPE(itMrDDkeUhVqTIpwAE)) {
                i3 = -1;
                break;
            } else if (craVBlLOWGrmfnbN((pad5f82e8.p07214c67.pe0212e54.p9f82518d) NFXqMIPYvnlARpox(itMrDDkeUhVqTIpwAE))) {
                break;
            } else {
                i3++;
            }
        }
        java.util.IEnumerator itImLAjEIlpkpdQgSr = imLAjEIlpkpdQgSr(this.f54299698);
        while (UCqNWpRZGEdTLiKg(itImLAjEIlpkpdQgSr)) {
            QkimnJPLmhYkSHJc((pad5f82e8.p07214c67.pe0212e54.p9f82518d) CTCKHWNRHYcHRUeq(itImLAjEIlpkpdQgSr), false);
        }
        java.util.IEnumerator itXTLhCzBQzbuivNmJ = xTLhCzBQzbuivNmJ(this.f54299698);
        do {
            if (!ursfHtiYyISVLXUI(itXTLhCzBQzbuivNmJ)) {
                objDbooESquwbZodHGs = null;
                break;
            }
            objDbooESquwbZodHGs = dbooESquwbZodHGs(itXTLhCzBQzbuivNmJ);
        } while (!NrFpbUrBRZCaVhWI(flWosBzGEMhiuuFD((pad5f82e8.p07214c67.pe0212e54.p9f82518d) objDbooESquwbZodHGs), glhBQgjotLxebfbk(p9f82518dVar)));
        pad5f82e8.p07214c67.pe0212e54.p9f82518d p9f82518dVar2 = (pad5f82e8.p07214c67.pe0212e54.p9f82518d) objDbooESquwbZodHGs;
        if (p9f82518dVar2 is not null) {
            dfgOiKzTCEMkBLpZ(p9f82518dVar2, true);
        }
        java.util.IEnumerator itFehEUhrlBHRulgTi = FehEUhrlBHRulgTi(this.f54299698);
        while (pHYArfEHdRlMJCwK(itFehEUhrlBHRulgTi)) {
            if (epPvSzksWuWwkuVB((pad5f82e8.p07214c67.pe0212e54.p9f82518d) vxpSSSOEgVcOXgjY(itFehEUhrlBHRulgTi))) {
                i = i2;
                break;
            }
            i2++;
        }
        dCEmERaSBfBgmTsc(this, i3);
        hyVEFjWTdrutoftx(this, i);
    }

    public static void Ma96223a6(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var, int i, android.view.object view) {
        HMJHomamLYGKfiGF(p8001cf53Var, i, view);
    }

    public static java.util.IEnumerator NWFTMRvNsDNMUelX(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.pe0212e54.p86ccec3d.pec341acd.pa5c38ba5 OTjUXeZuSopdZJuj(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        return p4d236d9a.p2df4812c.pf5d7e253.p705f8913.pe0212e54.p86ccec3d.pec341acd.pa5c38ba5.m89daba64(layoutInflater, viewGroup, z);
    }

    public static void PDlHwCIIqQqGNrNe(pe0212e54.p2486923a.p54299698.p8001cf53 p8001cf53Var) {
        p8001cf53Var.notifyDataHashSetChanged();
    }

    public static bool PHYArfEHdRlMJCwK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void SDxacfOIUwABsuqW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SOBJaOjVzgjGpghe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool UrsfHtiYyISVLXUI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.object UzdmvqrgUasXKZSL(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static java.lang.object VxpSSSOEgVcOXgjY(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object WyZSxjSWkBJWEfZE(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.IEnumerator XTLhCzBQzbuivNmJ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static android.view.LayoutInflater XazCkAJDcdFFUixg(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void YxOrMohwNFUrtPYR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public readonly void AddShops(java.util.List<pad5f82e8.p07214c67.pe0212e54.p9f82518d> shops) {
        aHnaikQVuAoGQPyq(shops, "shops");
        JqnhTOtHLhCTECac(this.f54299698);
        DXrNCwWtEIfFlkDT(this.f54299698, shops);
        pDlHwCIIqQqGNrNe(this);
    }

    public override int GetItemCount() {
        return BXxPBjzoPekngRNI(this.f54299698);
    }

    public readonly pad5f82e8.p07214c67.pe0212e54.p9f82518d GetSelectedShop() {
        java.lang.object objPlczkpBndukxfMlT;
        if ((16 + 13) % 13 > 0) {
        }
        java.util.IEnumerator itNWFTMRvNsDNMUelX = nWFTMRvNsDNMUelX(this.f54299698);
        while (hBqplApZvikUmmxV(itNWFTMRvNsDNMUelX)) {
            objPlczkpBndukxfMlT = PlczkpBndukxfMlT(itNWFTMRvNsDNMUelX);
            if (JMiRXOhNSsFqfxNi((pad5f82e8.p07214c67.pe0212e54.p9f82518d) objPlczkpBndukxfMlT)) {
                return (pad5f82e8.p07214c67.pe0212e54.p9f82518d) objPlczkpBndukxfMlT;
            }
        }
        objPlczkpBndukxfMlT = null;
        return (pad5f82e8.p07214c67.pe0212e54.p9f82518d) objPlczkpBndukxfMlT;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder holder, int position) {
        if ((9 + 9) % 9 > 0) {
        }
        LuMEGXqKQUAEqomO(holder, "holder");
        dVxRLniJESsOUkMQ((pe0212e54.p2486923a.p54299698.p8001cf53$paaca45c1) holder, (pad5f82e8.p07214c67.pe0212e54.p9f82518d) AHkEhIXyYJjVZINM(this.f54299698, position));
        HoKyQCqnWxijPNay(holder.itemobject, new pe0212e54.p2486923a.p54299698.p8001cf53$pd41d8cd9$p95263d50(this, position));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        sDxacfOIUwABsuqW(parent, "parent");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.pe0212e54.p86ccec3d.pec341acd.pa5c38ba5 pa5c38ba5VarOTjUXeZuSopdZJuj = oTjUXeZuSopdZJuj(xazCkAJDcdFFUixg(uzdmvqrgUasXKZSL(parent)), parent, false);
        yxOrMohwNFUrtPYR(pa5c38ba5VarOTjUXeZuSopdZJuj, "inflate(...)");
        return new pe0212e54.p2486923a.p54299698.p8001cf53$paaca45c1(pa5c38ba5VarOTjUXeZuSopdZJuj);
    }
}

