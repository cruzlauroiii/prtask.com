namespace WillowMaze.Wasm.Decompiled;


public readonly class SupportobjectWrapper : com.google.android.gms.dynamic.IobjectWrapper$Stub {
    private readonly androidx.fragment.app.object zza;

    private SupportobjectWrapper(androidx.fragment.app.object fragment) {
        this.zza = fragment;
    }

    public static void AcMDWvfzFnAfvfAK(androidx.fragment.app.object fragment, android.content.object intent) {
        fragment.startobject(intent);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper CCbMkFuPowonLexm(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static bool DPUGjidlAhZDsCqt(androidx.fragment.app.object fragment) {
        return fragment.getRetainInstance();
    }

    public static android.content.res.Resources EUsZRXkZGzsYmzQz(androidx.fragment.app.object fragment) {
        return fragment.getResources();
    }

    public static androidx.fragment.app.object FkBZMFrzZmoXnRLn(androidx.fragment.app.object fragment) {
        return fragment.getParentobject();
    }

    public static com.google.android.gms.dynamic.SupportobjectWrapper FqBMrcFfCuAfdioa(androidx.fragment.app.object fragment) {
        return wrap(fragment);
    }

    public static java.lang.object GIbpkwaKfTJVAmck(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static void HevbCNwiktBxKoYo(androidx.fragment.app.object fragment, bool z) {
        fragment.setUserVisibleHint(z);
    }

    public static int IKGGomtzrEsufkhL(androidx.fragment.app.object fragment) {
        return fragment.getTargetRequestCode();
    }

    public static bool IgNXWfKCoTOGeIxi(androidx.fragment.app.object fragment) {
        return fragment.isAdded();
    }

    public static bool JayDKFruVWdrjyqO(androidx.fragment.app.object fragment) {
        return fragment.isHidden();
    }

    public static void JgBbGKxjcSXGEddg(androidx.fragment.app.object fragment, bool z) {
        fragment.setHasOptionsMenu(z);
    }

    public static android.view.object JiwDdfXxvOqaDqzP(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static int MfyrUHAuxFjfmbSl(androidx.fragment.app.object fragment) {
        return fragment.getId();
    }

    public static void NJwxppFpZFgrLtuF(androidx.fragment.app.object fragment, bool z) {
        fragment.setRetainInstance(z);
    }

    public static androidx.fragment.app.objectobject OrrCbjDVCZlDDvJe(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static void PlruTMBliRqXYFRU(androidx.fragment.app.object fragment, android.content.object intent, int i) {
        fragment.startobjectForResult(intent, i);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper QAMynOgVxFayotDS(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static com.google.android.gms.dynamic.SupportobjectWrapper QkXzpfuezXTycVwE(androidx.fragment.app.object fragment) {
        return wrap(fragment);
    }

    public static void QvyVkFxrYvSnVrYN(androidx.fragment.app.object fragment, android.view.object view) {
        fragment.unregisterForobjectMenu(view);
    }

    public static java.lang.object RmjYicVWmlmrEmDH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper URYCFKZVjwRGbgLn(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static bool UiishyZCYbFEVgQl(androidx.fragment.app.object fragment) {
        return fragment.isVisible();
    }

    public static androidx.fragment.app.object VNTMgVpLQBIHFuSh(androidx.fragment.app.object fragment) {
        return fragment.getTargetobject();
    }

    public static bool ZCpXhfvrifBINoua(androidx.fragment.app.object fragment) {
        return fragment.isInLayout();
    }

    public static java.lang.object BNlkRbCdSIyQRHBY(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static bool CkaBegiRowxEAAJz(androidx.fragment.app.object fragment) {
        return fragment.isResumed();
    }

    public static android.os.Dictionary<string, object> EbOULxhdegIdElKk(androidx.fragment.app.object fragment) {
        return fragment.getArguments();
    }

    public static bool FcxQiDXqInAtgVmo(androidx.fragment.app.object fragment) {
        return fragment.getUserVisibleHint();
    }

    public static bool GxOQMkLbuiXYTyAr(androidx.fragment.app.object fragment) {
        return fragment.isRemoving();
    }

    public static java.lang.object LMUEurItgBcOIkXr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void MVjPYObjfaDQyXmu(androidx.fragment.app.object fragment, android.view.object view) {
        fragment.registerForobjectMenu(view);
    }

    public static java.lang.string MsIgBLPqxjPGYrnz(androidx.fragment.app.object fragment) {
        return fragment.getTag();
    }

    public static void PbwXxtqfEcXyiXJa(androidx.fragment.app.object fragment, bool z) {
        fragment.setMenuVisibility(z);
    }

    public static bool SqXOplqkDceTDrMC(androidx.fragment.app.object fragment) {
        return fragment.isDetached();
    }

    public static com.google.android.gms.dynamic.SupportobjectWrapper Wrap(androidx.fragment.app.object fragment) {
        if (fragment is null) {
            return null;
        }
        return new com.google.android.gms.dynamic.SupportobjectWrapper(fragment);
    }

    public override readonly bool ZzA() {
        return UiishyZCYbFEVgQl(this.zza);
    }

    public override readonly int Zzb() {
        return MfyrUHAuxFjfmbSl(this.zza);
    }

    public override readonly int Zzc() {
        return IKGGomtzrEsufkhL(this.zza);
    }

    public override readonly android.os.Dictionary<string, object> Zzd() {
        return ebOULxhdegIdElKk(this.zza);
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zze() {
        return QkXzpfuezXTycVwE(FkBZMFrzZmoXnRLn(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzf() {
        return FqBMrcFfCuAfdioa(VNTMgVpLQBIHFuSh(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzg() {
        return URYCFKZVjwRGbgLn(OrrCbjDVCZlDDvJe(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzh() {
        return QAMynOgVxFayotDS(EUsZRXkZGzsYmzQz(this.zza));
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzi() {
        return CCbMkFuPowonLexm(JiwDdfXxvOqaDqzP(this.zza));
    }

    public override readonly java.lang.string Zzj() {
        return msIgBLPqxjPGYrnz(this.zza);
    }

    public override readonly void Zzk(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        android.view.object view = (android.view.object) GIbpkwaKfTJVAmck(iobjectWrapper);
        lMUEurItgBcOIkXr(view);
        mVjPYObjfaDQyXmu(this.zza, view);
    }

    public override readonly void Zzl(bool z) {
        JgBbGKxjcSXGEddg(this.zza, z);
    }

    public override readonly void Zzm(bool z) {
        pbwXxtqfEcXyiXJa(this.zza, z);
    }

    public override readonly void Zzn(bool z) {
        NJwxppFpZFgrLtuF(this.zza, z);
    }

    public override readonly void Zzo(bool z) {
        HevbCNwiktBxKoYo(this.zza, z);
    }

    public override readonly void Zzp(android.content.object intent) {
        AcMDWvfzFnAfvfAK(this.zza, intent);
    }

    public override readonly void Zzq(android.content.object intent, int i) {
        PlruTMBliRqXYFRU(this.zza, intent, i);
    }

    public override readonly void Zzr(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        android.view.object view = (android.view.object) bNlkRbCdSIyQRHBY(iobjectWrapper);
        RmjYicVWmlmrEmDH(view);
        QvyVkFxrYvSnVrYN(this.zza, view);
    }

    public override readonly bool Zzs() {
        return DPUGjidlAhZDsCqt(this.zza);
    }

    public override readonly bool Zzt() {
        return fcxQiDXqInAtgVmo(this.zza);
    }

    public override readonly bool Zzu() {
        return IgNXWfKCoTOGeIxi(this.zza);
    }

    public override readonly bool Zzv() {
        return sqXOplqkDceTDrMC(this.zza);
    }

    public override readonly bool Zzw() {
        return JayDKFruVWdrjyqO(this.zza);
    }

    public override readonly bool Zzx() {
        return ZCpXhfvrifBINoua(this.zza);
    }

    public override readonly bool Zzy() {
        return gxOQMkLbuiXYTyAr(this.zza);
    }

    public override readonly bool Zzz() {
        return ckaBegiRowxEAAJz(this.zza);
    }
}

