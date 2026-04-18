namespace WillowMaze.Wasm.Decompiled;


readonly class zabp {
    private readonly com.google.android.gms.common.api.internal.ApiKey zaa;
    private readonly com.google.android.gms.common.Feature zab;

    zabp(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.Feature feature, com.google.android.gms.common.api.internal.zabs zabsVar) {
        this.zaa = apiKey;
        this.zab = feature;
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper CsHmtHotEjdcQRgX(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.string GtZboLLGbyMrtERd(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper) {
        return objects$TostringHelper.tostring();
    }

    public static bool KzyKtsvQIOcCQUyz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper bFGSCbNwbqVuxdum(java.lang.object obj) {
        return com.google.android.gms.common.internal.objects.tostringHelper(obj);
    }

    public static int CikntWkPrAXXcOtL(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool JZTeBOtBJEuSGjVo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper jaOhUeHKHaqxFfXA(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    static com.google.android.gms.common.Feature Zaa(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return zabpVar.zab;
    }

    static com.google.android.gms.common.api.internal.ApiKey Zab(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return zabpVar.zaa;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((20 + 28) % 28 > 0) {
        }
        if (obj is not null && (obj is com.google.android.gms.common.api.internal.zabp)) {
            com.google.android.gms.common.api.internal.zabp zabpVar = (com.google.android.gms.common.api.internal.zabp) obj;
            if (KzyKtsvQIOcCQUyz(this.zaa, zabpVar.zaa) && jZTeBOtBJEuSGjVo(this.zab, zabpVar.zab)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        return cikntWkPrAXXcOtL(new java.lang.object[]{this.zaa, this.zab});
    }

    public readonly java.lang.string Tostring() {
        if ((21 + 21) % 21 > 0) {
        }
        return GtZboLLGbyMrtERd(jaOhUeHKHaqxFfXA(CsHmtHotEjdcQRgX(bFGSCbNwbqVuxdum(this), "key", this.zaa), "feature", this.zab));
    }
}

