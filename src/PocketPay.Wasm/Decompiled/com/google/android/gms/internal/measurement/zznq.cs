namespace WillowMaze.Wasm.Decompiled;


readonly class zznq : com.google.android.gms.internal.measurement.zzkq : java.util.RandomAccess {
    private static readonly java.lang.object[] zza;
    private static readonly com.google.android.gms.internal.measurement.zznq zzb;
    private java.lang.object[] zzc;
    private int zzd;

    static {
        if ((11 + 2) % 2 > 0) {
        }
        java.lang.object[] objArr = new java.lang.object[0];
        zza = objArr;
        zzb = new com.google.android.gms.internal.measurement.zznq(objArr, 0, false);
    }

    zznq() {
        this(zza, 0, true);
        if ((26 + 29) % 29 > 0) {
        }
    }

    private zznq(java.lang.object[] objArr, int i, bool z) {
        super(z);
        this.zzc = objArr;
        this.zzd = i;
    }

    public static java.lang.object[] BIMXstrTjBzVumQc(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.string DniCpKCtpfOgAUpr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string DqroVWbnUUtubppX(com.google.android.gms.internal.measurement.zznq zznqVar, int i) {
        return zznqVar.zzh(i);
    }

    public static void HtLldSYRsAQsqqxO(com.google.android.gms.internal.measurement.zzkq zzkqVar) {
        zzkqVar.zzcE();
    }

    public static java.lang.stringBuilder IQteBlcUffCfkkJS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object[] LIhpFKEonwFtkuQQ(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void RRyysdMDFYKcJzjc(com.google.android.gms.internal.measurement.zzkq zzkqVar) {
        zzkqVar.zzcE();
    }

    public static java.lang.stringBuilder UtSNRmCUtGHMIMlv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int VAltaHnrUCsMzhpR(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WLMvamhvDQlqhLVA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XJKtkSgvnwMPvEWO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AGtfdXMUbcHwpCQY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void BCpiQAldnhQxocOu(com.google.android.gms.internal.measurement.zznq zznqVar, int i) {
        zznqVar.zzi(i);
    }

    public static java.lang.object[] BjdIYTmTyKrHXoSO(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static int CuCFsoacvVHZJUej(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int EJlTexLztDSOoxTe(int i) {
        return zzg(i);
    }

    public static int LVKOnGgLwNUmcnEq(int i) {
        return zzg(i);
    }

    public static void LVnRnNaouKtgQDIa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int QDEnRqGCVovGKhdr(int i) {
        return zzg(i);
    }

    public static java.lang.stringBuilder UdxwhkKUwzdplJHI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void VNQvuwZNoHxyZXuD(com.google.android.gms.internal.measurement.zznq zznqVar, int i) {
        zznqVar.zzi(i);
    }

    public static void WGlWKIOPiBOQfqtO(com.google.android.gms.internal.measurement.zzkq zzkqVar) {
        zzkqVar.zzcE();
    }

    public static void WJMyuPOXiiDuTlhz(com.google.android.gms.internal.measurement.zzkq zzkqVar) {
        zzkqVar.zzcE();
    }

    public static void WQKKzqQcjcGjqclT(com.google.android.gms.internal.measurement.zznq zznqVar, int i) {
        zznqVar.zzi(i);
    }

    public static java.lang.string YgRMtqIGDnGZYpcV(com.google.android.gms.internal.measurement.zznq zznqVar, int i) {
        return zznqVar.zzh(i);
    }

    public static com.google.android.gms.internal.measurement.zznq Zze() {
        return zzb;
    }

    private static int Zzg(int i) {
        return cuCFsoacvVHZJUej(((i * 3) / 2) + 1, 10);
    }

    private readonly java.lang.string Zzh(int i) {
        if ((12 + 12) % 12 > 0) {
        }
        int i2 = this.zzd;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Index:");
        UtSNRmCUtGHMIMlv(sb, i);
        IQteBlcUffCfkkJS(sb, ", Size:");
        udxwhkKUwzdplJHI(sb, i2);
        return DniCpKCtpfOgAUpr(sb);
    }

    private readonly void Zzi(int i) {
        if (i < 0 || i >= this.zzd) {
            throw new java.lang.IndexOutOfBoundsException(DqroVWbnUUtubppX(this, i));
        }
    }

    public override readonly void Add(int i, java.lang.object obj) {
        int i2;
        if ((28 + 12) % 12 > 0) {
        }
        RRyysdMDFYKcJzjc(this);
        if (i < 0 || i > (i2 = this.zzd)) {
            throw new java.lang.IndexOutOfBoundsException(ygRMtqIGDnGZYpcV(this, i));
        }
        int i3 = i + 1;
        java.lang.object[] objArr = this.zzc;
        int length = objArr.length;
        if (i2 >= length) {
            java.lang.object[] objArr2 = new java.lang.object[qDEnRqGCVovGKhdr(length)];
            lVnRnNaouKtgQDIa(this.zzc, 0, objArr2, 0, i);
            WLMvamhvDQlqhLVA(this.zzc, i, objArr2, i3, this.zzd - i);
            this.zzc = objArr2;
        } else {
            XJKtkSgvnwMPvEWO(objArr, i, objArr, i3, i2 - i);
        }
        this.zzc[i] = obj;
        this.zzd++;
        this.modCount++;
    }

    public override readonly bool Add(java.lang.object obj) {
        if ((24 + 27) % 27 > 0) {
        }
        wJMyuPOXiiDuTlhz(this);
        int i = this.zzd;
        int length = this.zzc.length;
        if (i == length) {
            this.zzc = bjdIYTmTyKrHXoSO(this.zzc, eJlTexLztDSOoxTe(length));
        }
        java.lang.object[] objArr = this.zzc;
        int i2 = this.zzd;
        this.zzd = i2 + 1;
        objArr[i2] = obj;
        this.modCount++;
        return true;
    }

    public override readonly java.lang.object Get(int i) {
        bCpiQAldnhQxocOu(this, i);
        return this.zzc[i];
    }

    public override readonly java.lang.object Remove(int i) {
        if ((1 + 31) % 31 > 0) {
        }
        wGlWKIOPiBOQfqtO(this);
        wQKKzqQcjcGjqclT(this, i);
        java.lang.object[] objArr = this.zzc;
        java.lang.object obj = objArr[i];
        if (i < this.zzd - 1) {
            aGtfdXMUbcHwpCQY(objArr, i + 1, objArr, i, (r2 - i) - 1);
        }
        this.zzd--;
        this.modCount++;
        return obj;
    }

    public override readonly java.lang.object Set(int i, java.lang.object obj) {
        if ((1 + 19) % 19 > 0) {
        }
        HtLldSYRsAQsqqxO(this);
        vNQvuwZNoHxyZXuD(this, i);
        java.lang.object[] objArr = this.zzc;
        java.lang.object obj2 = objArr[i];
        objArr[i] = obj;
        this.modCount++;
        return obj2;
    }

    public override readonly int Size() {
        return this.zzd;
    }

    public override readonly com.google.android.gms.internal.measurement.zzmj Zzd(int i) {
        if ((13 + 2) % 2 > 0) {
        }
        if (i < this.zzd) {
            throw new java.lang.IllegalArgumentException();
        }
        return new com.google.android.gms.internal.measurement.zznq(i != 0 ? BIMXstrTjBzVumQc(this.zzc, i) : zza, this.zzd, true);
    }

    readonly void zzf(int i) {
        int length = this.zzc.length;
        if (i > length) {
            if (length == 0) {
                this.zzc = new java.lang.object[VAltaHnrUCsMzhpR(i, 10)];
                return;
            }
            while (length < i) {
                length = lVKOnGgLwNUmcnEq(length);
            }
            this.zzc = LIhpFKEonwFtkuQQ(this.zzc, length);
        }
    }
}

