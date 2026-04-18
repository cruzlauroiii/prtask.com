namespace WillowMaze.Wasm.Decompiled;


public readonly class objects$TostringHelper {
    private readonly java.util.List zza;
    private readonly java.lang.object zzb;

    objects$TostringHelper(java.lang.object obj, com.google.android.gms.common.internal.zzah zzahVar) {
        AkipPMkkBIEJFbHZ(obj);
        this.zzb = obj;
        this.zza = new java.util.List();
    }

    public static java.lang.object AkipPMkkBIEJFbHZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder DSkuNvspZDvWdxhn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EjQMAVvwjjBpScxQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FdNfJEHbByzhdvwJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool FrptKauKVxVnCdOu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder LnoyDZKKyXgmgCrg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NrUFRjlarXYtPdTQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder RMYvVBMhDEauZVwm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RiBKkzsBJfPxKHLh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class VzqfaxXYWfeSIIiB(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder WYIjeJdDLmHGqoEJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AYXoSvProIjmcqWk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder DnzwoqHaNdoOfLBs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object FuZmiKzvBtvEdzBy(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.stringBuilder KkXwThfXNHYBmjCV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NGwyNnzKWPYCHqMu(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object NpRVHwvKtAgkcfVm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string QFufINdYFCbETFnY(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public com.google.android.gms.common.internal.objects$TostringHelper add(java.lang.string str, java.lang.object obj) {
        npRVHwvKtAgkcfVm(str);
        java.lang.string strNrUFRjlarXYtPdTQ = NrUFRjlarXYtPdTQ(obj);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        kkXwThfXNHYBmjCV(sb, str);
        RMYvVBMhDEauZVwm(sb, "=");
        FdNfJEHbByzhdvwJ(sb, strNrUFRjlarXYtPdTQ);
        FrptKauKVxVnCdOu(this.zza, RiBKkzsBJfPxKHLh(sb));
        return this;
    }

    public java.lang.string Tostring() {
        if ((19 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
        LnoyDZKKyXgmgCrg(sb, qFufINdYFCbETFnY(VzqfaxXYWfeSIIiB(this.zzb)));
        dnzwoqHaNdoOfLBs(sb, '{');
        int iNGwyNnzKWPYCHqMu = nGwyNnzKWPYCHqMu(this.zza);
        for (int i = 0; i < iNGwyNnzKWPYCHqMu; i++) {
            WYIjeJdDLmHGqoEJ(sb, (java.lang.string) fuZmiKzvBtvEdzBy(this.zza, i));
            if (i < iNGwyNnzKWPYCHqMu - 1) {
                DSkuNvspZDvWdxhn(sb, ", ");
            }
        }
        aYXoSvProIjmcqWk(sb, '}');
        return EjQMAVvwjjBpScxQ(sb);
    }
}

