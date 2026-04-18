namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkj : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzlw zza;
    public readonly java.util.List zzb;

    public zzkj(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.util.List list) {
        this.zza = zzlwVar;
        this.zzb = list;
    }

    public static android.util.SparseArray BUcwDRHySKWPJsSv(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zze();
    }

    public static java.util.IEnumerator BmOafdAvsQwMMnXa(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object FUcwDzNSfHEbOCWC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MBllkWDdYnplreyz(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        zzlwVar.zzU();
    }

    public static java.lang.object NVpqxQGKHbQpfsfi(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static long PeorexPQQNScslIc(java.lang.long l) {
        if ((13 + 20) % 20 > 0) {
        }
        return l.longValue();
    }

    public static java.util.PriorityQueue DVEOPZEClENVzHDE(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        return zzlwVar.zzy();
    }

    public static com.google.android.gms.measurement.internal.zzht FwIZyxKqOaSlaMyn(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzm();
    }

    public static bool GcKtkcwVCNTfOYtY(android.util.SparseArray sparseArray, int i) {
        return sparseArray.Contains(i);
    }

    public static void MtbUrgMBipEPbAqv(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static bool PvcCgClXfrIaXSGU(java.util.PriorityQueue priorityQueue, java.lang.object obj) {
        return priorityQueue.Add(obj);
    }

    public static bool XPGzIxhHxDOcfHRY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override readonly void Run() {
        if ((30 + 23) % 23 > 0) {
        }
        com.google.android.gms.measurement.internal.zzlw zzlwVar = this.zza;
        mtbUrgMBipEPbAqv(zzlwVar);
        java.util.List list = this.zzb;
        android.util.SparseArray sparseArrayBUcwDRHySKWPJsSv = BUcwDRHySKWPJsSv(fwIZyxKqOaSlaMyn(zzlwVar.zzu));
        java.util.IEnumerator itBmOafdAvsQwMMnXa = BmOafdAvsQwMMnXa(list);
        while (xPGzIxhHxDOcfHRY(itBmOafdAvsQwMMnXa)) {
            com.google.android.gms.measurement.internal.zzov zzovVar = (com.google.android.gms.measurement.internal.zzov) FUcwDzNSfHEbOCWC(itBmOafdAvsQwMMnXa);
            int i = zzovVar.zzc;
            if (!gcKtkcwVCNTfOYtY(sparseArrayBUcwDRHySKWPJsSv, i) || PeorexPQQNScslIc((java.lang.long) NVpqxQGKHbQpfsfi(sparseArrayBUcwDRHySKWPJsSv, i)) < zzovVar.zzb) {
                pvcCgClXfrIaXSGU(dVEOPZEClENVzHDE(zzlwVar), zzovVar);
            }
        }
        MBllkWDdYnplreyz(zzlwVar);
    }
}

