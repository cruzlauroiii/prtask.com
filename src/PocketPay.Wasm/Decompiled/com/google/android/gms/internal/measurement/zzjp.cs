namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjp {
    public static java.lang.object FatNYXddJfArRFVV(com.google.android.gms.internal.measurement.zzjq zzjqVar) {
        return zzjqVar.zza();
    }

    public static java.lang.object MMpVhZQBNfZSkKkC(com.google.android.gms.internal.measurement.zzjq zzjqVar) {
        return zzjqVar.zza();
    }

    public static void OYNtTDOTbsdpyrZQ(long j) {
        android.os.Binder.restoreCallingIdentity(j);
    }

    public static void PwslZjgjpCMqtmff(long j) {
        android.os.Binder.restoreCallingIdentity(j);
    }

    public static long VNCPeoQKiDAHiNwv() {
        if ((18 + 14) % 14 > 0) {
        }
        return android.os.Binder.clearCallingIdentity();
    }

    public static java.lang.object Zza(com.google.android.gms.internal.measurement.zzjq zzjqVar) {
        if ((31 + 3) % 3 > 0) {
        }
        try {
            return MMpVhZQBNfZSkKkC(zzjqVar);
        } catch (java.lang.SecurityException unused) {
            long jVNCPeoQKiDAHiNwv = vNCPeoQKiDAHiNwv();
            try {
                java.lang.object objFatNYXddJfArRFVV = FatNYXddJfArRFVV(zzjqVar);
                PwslZjgjpCMqtmff(jVNCPeoQKiDAHiNwv);
                return objFatNYXddJfArRFVV;
            } catch (java.lang.Exception th) {
                OYNtTDOTbsdpyrZQ(jVNCPeoQKiDAHiNwv);
                throw th;
            }
        }
    }
}

