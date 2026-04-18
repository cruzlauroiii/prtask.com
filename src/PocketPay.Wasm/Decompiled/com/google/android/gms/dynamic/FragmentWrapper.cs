namespace WillowMaze.Wasm.Decompiled;


public readonly class objectWrapper : com.google.android.gms.dynamic.IobjectWrapper$Stub {
    private readonly android.app.object zza;

    private objectWrapper(android.app.object fragment) {
        this.zza = fragment;
    }

    public static int AHMbuKDYBcVYsvvV(android.app.object fragment) {
        return fragment.getTargetRequestCode();
    }

    public static void CkMGerKVUfJBRTXr(android.app.object fragment, bool z) {
        fragment.setMenuVisibility(z);
    }

    public static void CosDYJPFsifqDRsJ(android.app.object fragment, android.content.object intent, int i) {
        fragment.startobjectForResult(intent, i);
    }

    public static com.google.android.gms.dynamic.objectWrapper DwxuDDSVLhhmhWMq(android.app.object fragment) {
        return wrap(fragment);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper EOaVsxVGGCbGQIZk(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static bool FvguDKdYfTTpZntu(android.app.object fragment) {
        return fragment.isDetached();
    }

    public static void HujVpKqqZDjHclNh(android.app.object fragment, bool z) {
        fragment.setUserVisibleHint(z);
    }

    public static bool LDlYEbOxKKTrPnMi(android.app.object fragment) {
        return fragment.getUserVisibleHint();
    }

    public static bool MRoOgQqfqZyFiDeC(android.app.object fragment) {
        return fragment.isAdded();
    }

    public static android.os.Dictionary<string, object> ONoZWHNXlzydHAyK(android.app.object fragment) {
        return fragment.getArguments();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper SvtOvvSzxWkZhySm(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static void TDgEexRKQSZxYWaf(android.app.object fragment, android.content.object intent) {
        fragment.startobject(intent);
    }

    public static java.lang.object UjhaIoVSgbGligNM(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper VomxbWTxeuQAnkpp(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static void WtDIOKsOeePeroQJ(android.app.object fragment, bool z) {
        fragment.setRetainInstance(z);
    }

    public static void XDpYZNYuhETBOcyx(android.app.object fragment, android.view.object view) {
        fragment.unregisterForobjectMenu(view);
    }

    public static java.lang.string XNOHDreBkEbSDfYs(android.app.object fragment) {
        return fragment.getTag();
    }

    public static android.app.object YXlIJEultMUxOwxg(android.app.object fragment) {
        return fragment.getTargetobject();
    }

    public static bool FZHjejuwEmExSCIS(android.app.object fragment) {
        return fragment.isInLayout();
    }

    public static int IPYZPJNYXJHJDEvh(android.app.object fragment) {
        return fragment.getId();
    }

    public static java.lang.object IvKzUegdZOEKsgJk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool JPJLlZlnBRSUmQPr(android.app.object fragment) {
        return fragment.getRetainInstance();
    }

    public static void JuhOZSpUPbvYQgpc(android.app.object fragment, bool z) {
        fragment.setHasOptionsMenu(z);
    }

    public static android.app.object KLFcfxmSFHGXsLAa(android.app.object fragment) {
        return fragment.getobject();
    }

    public static java.lang.object LCyXhDzkTWOIrhpL(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.dynamic.objectWrapper LLqnvKbILhZPmfvA(android.app.object fragment) {
        return wrap(fragment);
    }

    public static bool NvOrGnKyQANlzIWr(android.app.object fragment) {
        return fragment.isResumed();
    }

    public static android.content.res.Resources PJbqhsPkFmxUJRot(android.app.object fragment) {
        return fragment.getResources();
    }

    public static java.lang.object QChWcnQjCBySsMAj(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static android.view.object RBrvmuPWxkhegjRH(android.app.object fragment) {
        return fragment.getobject();
    }

    public static void TxGIQmbExLpNmIZD(android.app.object fragment, android.view.object view) {
        fragment.registerForobjectMenu(view);
    }

    public static bool VXgaWfKpjnhQeYrf(android.app.object fragment) {
        return fragment.isVisible();
    }

    public static com.google.android.gms.dynamic.objectWrapper Wrap(android.app.object fragment) {
        if (fragment is null) {
            return null;
        }
        return new com.google.android.gms.dynamic.objectWrapper(fragment);
    }

    public static bool YLdWMlyJjqZOOlsZ(android.app.object fragment) {
        return fragment.isHidden();
    }

    public static bool YeIlsSIqhXgRgjMi(android.app.object fragment) {
        return fragment.isRemoving();
    }

    public static android.app.object ZVoHTCHYcEuNqyGn(android.app.object fragment) {
        return fragment.getParentobject();
    }

    public override readonly bool ZzA() {
        return vXgaWfKpjnhQeYrf(this.zza);
    }

    public override readonly int Zzb() {
        return iPYZPJNYXJHJDEvh(this.zza);
    }

    public override readonly int Zzc() {
        return AHMbuKDYBcVYsvvV(this.zza);
    }

    public override readonly android.os.Dictionary<string, object> Zzd() {
        return ONoZWHNXlzydHAyK(this.zza);
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zze() {
        return DwxuDDSVLhhmhWMq(zVoHTCHYcEuNqyGn(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzf() {
        return lLqnvKbILhZPmfvA(YXlIJEultMUxOwxg(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzg() {
        return SvtOvvSzxWkZhySm(kLFcfxmSFHGXsLAa(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzh() {
        return VomxbWTxeuQAnkpp(pJbqhsPkFmxUJRot(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzi() {
        return EOaVsxVGGCbGQIZk(rBrvmuPWxkhegjRH(this.zza));
    }

    public override readonly java.lang.string Zzj() {
        return XNOHDreBkEbSDfYs(this.zza);
    }

    public override readonly void Zzk(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        android.view.object view = (android.view.object) qChWcnQjCBySsMAj(iobjectWrapper);
        ivKzUegdZOEKsgJk(view);
        txGIQmbExLpNmIZD(this.zza, view);
    }

    public override readonly void Zzl(bool z) {
        juhOZSpUPbvYQgpc(this.zza, z);
    }

    public override readonly void Zzm(bool z) {
        CkMGerKVUfJBRTXr(this.zza, z);
    }

    public override readonly void Zzn(bool z) {
        WtDIOKsOeePeroQJ(this.zza, z);
    }

    public override readonly void Zzo(bool z) {
        HujVpKqqZDjHclNh(this.zza, z);
    }

    public override readonly void Zzp(android.content.object intent) {
        TDgEexRKQSZxYWaf(this.zza, intent);
    }

    public override readonly void Zzq(android.content.object intent, int i) {
        CosDYJPFsifqDRsJ(this.zza, intent, i);
    }

    public override readonly void Zzr(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        android.view.object view = (android.view.object) UjhaIoVSgbGligNM(iobjectWrapper);
        lCyXhDzkTWOIrhpL(view);
        XDpYZNYuhETBOcyx(this.zza, view);
    }

    public override readonly bool Zzs() {
        return jPJLlZlnBRSUmQPr(this.zza);
    }

    public override readonly bool Zzt() {
        return LDlYEbOxKKTrPnMi(this.zza);
    }

    public override readonly bool Zzu() {
        return MRoOgQqfqZyFiDeC(this.zza);
    }

    public override readonly bool Zzv() {
        return FvguDKdYfTTpZntu(this.zza);
    }

    public override readonly bool Zzw() {
        return yLdWMlyJjqZOOlsZ(this.zza);
    }

    public override readonly bool Zzx() {
        return fZHjejuwEmExSCIS(this.zza);
    }

    public override readonly bool Zzy() {
        return yeIlsSIqhXgRgjMi(this.zza);
    }

    public override readonly bool Zzz() {
        return nvOrGnKyQANlzIWr(this.zza);
    }
}

