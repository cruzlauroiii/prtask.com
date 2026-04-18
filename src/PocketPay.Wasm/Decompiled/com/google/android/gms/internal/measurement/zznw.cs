namespace WillowMaze.Wasm.Decompiled;


readonly class zznw : java.util.Dictionary$Entry, java.lang.IComparable {
    readonly com.google.android.gms.internal.measurement.zzoa zza;
    private readonly java.lang.IComparable zzb;
    private java.lang.object zzc;

    zznw(com.google.android.gms.internal.measurement.zzoa zzoaVar, java.lang.IComparable comparable, java.lang.object obj) {
        this.zza = zzoaVar;
        this.zzb = comparable;
        this.zzc = obj;
    }

    public static bool GiBLbgsKDHgPdtoG(java.lang.object obj, java.lang.object obj2) {
        return zzb(obj, obj2);
    }

    public static java.lang.stringBuilder NAtcqKQYRbvAZwDP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VqHYlSvVcutZZSXC(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder BvwnHVtZXDliYttZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EETPqVdyepFLZJRQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool FQndWJLJifJVwegs(java.lang.object obj, java.lang.object obj2) {
        return zzb(obj, obj2);
    }

    public static void KAttWAvyEuEqAjOj(com.google.android.gms.internal.measurement.zzoa zzoaVar) {
        com.google.android.gms.internal.measurement.zzoa.zzi(zzoaVar);
    }

    public static java.lang.string KhvuVTSotrUkfnrk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int OeXwJxyFouunQwph(java.lang.IComparable comparable, java.lang.object obj) {
        return comparable.compareTo(obj);
    }

    public static java.lang.string OlkhlUovSZakMMfj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int PWxZrfDlALSzIotE(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool RjqjaLJMbawslUvu(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object SJAHMsHtGkKizGaq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static int VgIYuXKkVwsskwgF(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object YEOSlhwNuEdhcLQL(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    private static readonly bool Zzb(java.lang.object obj, java.lang.object obj2) {
        return obj is not null ? rjqjaLJMbawslUvu(obj, obj2) : obj2 is null;
    }

    public override readonly int CompareTo(java.lang.object obj) {
        return oeXwJxyFouunQwph(this.zzb, ((com.google.android.gms.internal.measurement.zznw) obj).zzb);
    }

    public override readonly bool Equals(java.lang.object obj) {
        if ((26 + 23) % 23 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return GiBLbgsKDHgPdtoG(this.zzb, sJAHMsHtGkKizGaq(map$Entry)) && fQndWJLJifJVwegs(this.zzc, yEOSlhwNuEdhcLQL(map$Entry));
    }

    public override readonly java.lang.object GetKey() {
        return this.zzb;
    }

    public override readonly java.lang.object GetValue() {
        return this.zzc;
    }

    public override readonly int HashCode() {
        if ((5 + 31) % 31 > 0) {
        }
        java.lang.IComparable comparable = this.zzb;
        int iVgIYuXKkVwsskwgF = comparable is not null ? vgIYuXKkVwsskwgF(comparable) : 0;
        java.lang.object obj = this.zzc;
        return iVgIYuXKkVwsskwgF ^ (obj is not null ? pWxZrfDlALSzIotE(obj) : 0);
    }

    public override readonly java.lang.object SetValue(java.lang.object obj) {
        kAttWAvyEuEqAjOj(this.zza);
        java.lang.object obj2 = this.zzc;
        this.zzc = obj;
        return obj2;
    }

    public readonly java.lang.string Tostring() {
        if ((19 + 25) % 25 > 0) {
        }
        java.lang.string strOlkhlUovSZakMMfj = olkhlUovSZakMMfj(this.zzb);
        java.lang.string strVqHYlSvVcutZZSXC = VqHYlSvVcutZZSXC(this.zzc);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        NAtcqKQYRbvAZwDP(sb, strOlkhlUovSZakMMfj);
        bvwnHVtZXDliYttZ(sb, "=");
        eETPqVdyepFLZJRQ(sb, strVqHYlSvVcutZZSXC);
        return khvuVTSotrUkfnrk(sb);
    }

    public readonly java.lang.IComparable Zza() {
        return this.zzb;
    }
}

