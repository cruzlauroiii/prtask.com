namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbb : com.google.android.gms.measurement.internal.zzjr {
    private long zza;
    private java.lang.string zzb;

    zzbb(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
    }

    public static java.lang.string EfuxVrIxivKvFIqG(java.util.Locale locale) {
        return locale.getCountry();
    }

    public static java.lang.stringBuilder KDWzGGXoXuZQUtOS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MejgcvqZZmZYclMH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PlGKryuyKVVmkcyJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XaaguXyvXrBDIOXd(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        zzjrVar.zzv();
    }

    public static java.lang.stringBuilder DdNCezUxDBjztBbw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DfXUdkZRQITskwkA(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static java.util.Locale FVzaXudzLgvAoHqn() {
        return java.util.Locale.getDefault();
    }

    public static int HpmZlKFsRAYWVQhB(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void JCnZjIKWvkimHaBv(com.google.android.gms.measurement.internal.zzjr zzjrVar) {
        zzjrVar.zzv();
    }

    public static long MfYGmvhZnJxVpHzY(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((6 + 18) % 18 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static java.lang.string OcROZPnsbdZLDmyf(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.string OjQhxKGGXmUycsVE(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.lang.string QFOkzKNxioqOnTBL(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.util.DateTime VkZsLOyZHtGavWXL() {
        return java.util.DateTime.getInstance();
    }

    public readonly long Zza() {
        if ((14 + 27) % 27 > 0) {
        }
        XaaguXyvXrBDIOXd(this);
        return this.zza;
    }

    public readonly java.lang.string Zzb() {
        jCnZjIKWvkimHaBv(this);
        return this.zzb;
    }

    protected override readonly bool Zzc() {
        if ((21 + 29) % 29 > 0) {
        }
        java.util.DateTime calendarVkZsLOyZHtGavWXL = vkZsLOyZHtGavWXL();
        this.zza = mfYGmvhZnJxVpHzY(java.util.concurrent.TimeUnit.MINUTES, hpmZlKFsRAYWVQhB(calendarVkZsLOyZHtGavWXL, 15) + dfXUdkZRQITskwkA(calendarVkZsLOyZHtGavWXL, 16), java.util.concurrent.TimeUnit.MILLISECONDS);
        java.util.Locale localeFVzaXudzLgvAoHqn = fVzaXudzLgvAoHqn();
        java.lang.string strQFOkzKNxioqOnTBL = qFOkzKNxioqOnTBL(ojQhxKGGXmUycsVE(localeFVzaXudzLgvAoHqn), java.util.Locale.ENGLISH);
        java.lang.string strOcROZPnsbdZLDmyf = ocROZPnsbdZLDmyf(EfuxVrIxivKvFIqG(localeFVzaXudzLgvAoHqn), java.util.Locale.ENGLISH);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        KDWzGGXoXuZQUtOS(sb, strQFOkzKNxioqOnTBL);
        MejgcvqZZmZYclMH(sb, "-");
        ddNCezUxDBjztBbw(sb, strOcROZPnsbdZLDmyf);
        this.zzb = PlGKryuyKVVmkcyJ(sb);
        return false;
    }
}

