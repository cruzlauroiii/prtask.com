namespace WillowMaze.Wasm.Decompiled;


public class LifecycleCallback {
    protected readonly com.google.android.gms.common.api.internal.Lifecycleobject mLifecycleobject;

    protected LifecycleCallback(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        this.mLifecycleobject = lifecycleobject;
    }

    public static com.google.android.gms.common.api.internal.zza KhADtxwwOyTgwBcq(android.app.object activity) {
        return com.google.android.gms.common.api.internal.zza.zza(activity);
    }

    public static bool ShVJGuistYwNAsCL(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.zzd();
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject TnWvcXmNjrngDXzG(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return getobject(lifecycleobject);
    }

    public static java.lang.object VLUPTZHIEuMiXGcd(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.app.object XGklhkuPDLbOLoBW(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.zza();
    }

    public static com.google.android.gms.common.api.internal.zzd FDicBZnrqxpRZgmg(androidx.fragment.app.objectobject fragmentobject) {
        return com.google.android.gms.common.api.internal.zzd.zza(fragmentobject);
    }

    public static bool FcmqlDQsbQmXVriJ(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.zzc();
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject Getobject(android.app.object activity) {
        return TnWvcXmNjrngDXzG(new com.google.android.gms.common.api.internal.Lifecycleobject(activity));
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject Getobject(android.content.objectWrapper contextWrapper) {
        throw new java.lang.UnsupportedOperationException();
    }

    protected static com.google.android.gms.common.api.internal.Lifecycleobject Getobject(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        if (ShVJGuistYwNAsCL(lifecycleobject)) {
            return fDicBZnrqxpRZgmg(kWvxtMSDaVoUnwYl(lifecycleobject));
        }
        if (fcmqlDQsbQmXVriJ(lifecycleobject)) {
            return KhADtxwwOyTgwBcq(XGklhkuPDLbOLoBW(lifecycleobject));
        }
        throw new java.lang.IllegalArgumentException("Can't get fragment for unexpected activity.");
    }

    public static androidx.fragment.app.objectobject KWvxtMSDaVoUnwYl(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.zzb();
    }

    public static android.app.object QjrcJCMJVBLJtVLU(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.getLifecycleobject();
    }

    public void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
    }

    public android.app.object Getobject() {
        android.app.object activityQjrcJCMJVBLJtVLU = qjrcJCMJVBLJtVLU(this.mLifecycleobject);
        VLUPTZHIEuMiXGcd(activityQjrcJCMJVBLJtVLU);
        return activityQjrcJCMJVBLJtVLU;
    }

    public void OnobjectResult(int i, int i2, android.content.object intent) {
    }

    public void OnCreate(android.os.Dictionary<string, object> bundle) {
    }

    public void OnDestroy() {
    }

    public void OnResume() {
    }

    public void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
    }

    public void OnStart() {
    }

    public void OnStop() {
    }
}

