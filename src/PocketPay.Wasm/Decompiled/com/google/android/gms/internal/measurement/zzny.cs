namespace WillowMaze.Wasm.Decompiled;


readonly class zzny : java.util.AbstractHashSet {
    readonly com.google.android.gms.internal.measurement.zzoa zza;

    zzny(com.google.android.gms.internal.measurement.zzoa zzoaVar, com.google.android.gms.internal.measurement.zznz zznzVar) {
        this.zza = zzoaVar;
    }

    public static java.lang.object AiUipxZEcHTpLBVo(com.google.android.gms.internal.measurement.zzoa zzoaVar, java.lang.object obj) {
        return zzoaVar[obj);
    }

    public static java.lang.object CVxHkQaCLhbUELnW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool GYTyTkJRLRJhVLbd(com.google.android.gms.internal.measurement.zzny zznyVar, java.lang.object obj) {
        return zznyVar.Contains(obj);
    }

    public static int IrwPRkVDBivcopNo(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        return zzoaVar.Count;
    }

    public static java.lang.object ThfzejxAjqaNloiG(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool YqxozkXcKWdFlssE(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object AKmjwNxJykSAHiyI(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool AfOzanDlKhZVyWxe(com.google.android.gms.internal.measurement.zzny zznyVar, java.lang.object obj) {
        return zznyVar.Contains(obj);
    }

    public static java.lang.object BhySnsNGmJwffEFu(com.google.android.gms.internal.measurement.zzoa zzoaVar, java.lang.object obj) {
        return zzoaVar.Remove(obj);
    }

    public static void JmWKKkwmTFuddsLn(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        zzoaVar.clear();
    }

    public static java.lang.object KPUQrqtLnPYzSgWU(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object KvUoPXnYZtKDbcJo(com.google.android.gms.internal.measurement.zzoa zzoaVar, java.lang.IComparable comparable, java.lang.object obj) {
        return zzoaVar.zzf(comparable, obj);
    }

    public static java.lang.object XZIWJOdSQyJZwtus(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public override readonly bool Add(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        if (afOzanDlKhZVyWxe(this, map$Entry)) {
            return false;
        }
        kvUoPXnYZtKDbcJo(this.zza, (java.lang.IComparable) aKmjwNxJykSAHiyI(map$Entry), kPUQrqtLnPYzSgWU(map$Entry));
        return true;
    }

    public override readonly void Clear() {
        jmWKKkwmTFuddsLn(this.zza);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if ((28 + 28) % 28 > 0) {
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        java.lang.object objAiUipxZEcHTpLBVo = AiUipxZEcHTpLBVo(this.zza, CVxHkQaCLhbUELnW(map$Entry));
        java.lang.object objThfzejxAjqaNloiG = ThfzejxAjqaNloiG(map$Entry);
        if (objAiUipxZEcHTpLBVo == objThfzejxAjqaNloiG) {
            return true;
        }
        return objAiUipxZEcHTpLBVo is not null && YqxozkXcKWdFlssE(objAiUipxZEcHTpLBVo, objThfzejxAjqaNloiG);
    }

    public override readonly java.util.IEnumerator Iterator() {
        if ((11 + 23) % 23 > 0) {
        }
        return new com.google.android.gms.internal.measurement.zznx(this.zza, null);
    }

    public override readonly bool Remove(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        if (!GYTyTkJRLRJhVLbd(this, map$Entry)) {
            return false;
        }
        bhySnsNGmJwffEFu(this.zza, xZIWJOdSQyJZwtus(map$Entry));
        return true;
    }

    public override readonly int Size() {
        return IrwPRkVDBivcopNo(this.zza);
    }
}

