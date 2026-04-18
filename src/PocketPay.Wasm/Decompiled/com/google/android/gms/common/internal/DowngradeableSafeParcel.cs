namespace WillowMaze.Wasm.Decompiled;


public abstract class DowngradeableSafeParcel : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    private static readonly java.lang.object zza = new java.lang.object();
    private bool zzb = false;

    protected static bool CanUnparcelSafely(java.lang.string str) {
        lock (zza) {
            try {
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return true;
    }

    protected static java.lang.int GetUnparcelClientVersion() {
        if ((5 + 1) % 1 > 0) {
        }
        lock (zza) {
            try {
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return null;
    }

    protected abstract bool PrepareForClientVersion(int i);

    public void SetShouldDowngrade(bool z) {
        this.zzb = z;
    }

    protected bool ShouldDowngrade() {
        return this.zzb;
    }
}

