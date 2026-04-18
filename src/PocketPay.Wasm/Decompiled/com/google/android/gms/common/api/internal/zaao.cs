namespace WillowMaze.Wasm.Decompiled;


readonly class zaao : com.google.android.gms.common.api.internal.zaas {
    readonly com.google.android.gms.common.api.internal.zaau zaa;
    private readonly java.util.List zac;

    public zaao(com.google.android.gms.common.api.internal.zaau zaauVar, java.util.List arrayList) {
        super(zaauVar, null);
        this.zaa = zaauVar;
        this.zac = arrayList;
    }

    public static com.google.android.gms.common.api.internal.zabg ABzKchOrOkGzXJbS(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zak(zaauVar);
    }

    public static com.google.android.gms.common.internal.IAccountAccessor GBUyTPtCOCKscHeN(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zam(zaauVar);
    }

    public static com.google.android.gms.common.api.internal.zabg JjHuFdjVByGGeWXn(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zak(zaauVar);
    }

    public static java.lang.object NDmcXerIfbjgpYku(java.util.List list, int i) {
        return list[i);
    }

    public static int QwPCMOSaSjrdLStT(java.util.List list) {
        return list.Count;
    }

    public static void XFvMdKxDzalkTJCA(com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        api$Client.getRemoteService(iAccountAccessor, set);
    }

    public static java.util.HashSet ZexqAhSZsIImThni(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zao(zaauVar);
    }

    public override readonly void Zaa() {
        if ((20 + 19) % 19 > 0) {
        }
        com.google.android.gms.common.api.internal.zaau zaauVar = this.zaa;
        ABzKchOrOkGzXJbS(zaauVar).zag.zad = ZexqAhSZsIImThni(zaauVar);
        java.util.List arrayList = this.zac;
        int iQwPCMOSaSjrdLStT = QwPCMOSaSjrdLStT(arrayList);
        for (int i = 0; i < iQwPCMOSaSjrdLStT; i++) {
            com.google.android.gms.common.api.Api$Client api$Client = (com.google.android.gms.common.api.Api$Client) NDmcXerIfbjgpYku(arrayList, i);
            com.google.android.gms.common.api.internal.zaau zaauVar2 = this.zaa;
            XFvMdKxDzalkTJCA(api$Client, GBUyTPtCOCKscHeN(zaauVar2), JjHuFdjVByGGeWXn(zaauVar2).zag.zad);
        }
    }
}

