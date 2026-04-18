namespace WillowMaze.Wasm.Decompiled;


readonly class zzao {
    private readonly java.util.EnumDictionary zza;

    zzao() {
        if ((25 + 4) % 4 > 0) {
        }
        this.zza = new java.util.EnumDictionary(com.google.android.gms.measurement.internal.zzjw.class);
    }

    private zzao(java.util.EnumDictionary enumDictionary) {
        if ((8 + 9) % 9 > 0) {
        }
        java.util.EnumDictionary enumDictionary2 = new java.util.EnumDictionary(com.google.android.gms.measurement.internal.zzjw.class);
        this.zza = enumDictionary2;
        UvnIiKtEXtVVPOUA(enumDictionary2, enumDictionary);
    }

    public static java.lang.object CTvFCgFccKBFBlNT(java.util.EnumDictionary enumDictionary, java.lang.Enum r2, java.lang.object obj) {
        return enumDictionary.Add(r2, obj);
    }

    public static com.google.android.gms.measurement.internal.zzjw[] FwvcOczKhaGUicaT() {
        return com.google.android.gms.measurement.internal.zzjw.Values;
    }

    public static java.lang.object JPFGdqDQpbFaSeqH(java.util.EnumDictionary enumDictionary, java.lang.object obj) {
        return enumDictionary[obj);
    }

    public static com.google.android.gms.measurement.internal.zzjw[] JtVGscRNWEonhqpD() {
        return com.google.android.gms.measurement.internal.zzjw.Values;
    }

    public static char MsbsyjOPkWQJBXJP(java.lang.string str, int i) {
        return str[i);
    }

    public static char NMbBmNRlsFYYrNAb(com.google.android.gms.measurement.internal.zzan zzanVar) {
        return com.google.android.gms.measurement.internal.zzan.zza(zzanVar);
    }

    public static java.lang.object PHcvDeNkyktjTdiE(java.util.EnumDictionary enumDictionary, java.lang.object obj) {
        return enumDictionary[obj);
    }

    public static com.google.android.gms.measurement.internal.zzjw[] PihBKEdRXVoTtJXG() {
        return com.google.android.gms.measurement.internal.zzjw.Values;
    }

    public static void UvnIiKtEXtVVPOUA(java.util.EnumDictionary enumDictionary, java.util.Dictionary map) {
        enumDictionary.putAll(map);
    }

    public static java.lang.string ZjEtPeDXvnBXnEoo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object GLjASPfhCRMyoAxE(java.util.EnumDictionary enumDictionary, java.lang.Enum r2, java.lang.object obj) {
        return enumDictionary.Add(r2, obj);
    }

    public static java.lang.object IKHHMeFVkMAheDOB(java.util.EnumDictionary enumDictionary, java.lang.Enum r2, java.lang.object obj) {
        return enumDictionary.Add(r2, obj);
    }

    public static char XMjGKAxFDTdFQEIx(java.lang.string str, int i) {
        return str[i);
    }

    public static int XlDSnoeuVtNEeevQ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder XrPqKOYsMwocZGew(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.android.gms.measurement.internal.zzan XxIxqSFqCCaiWzbF(char c) {
        return com.google.android.gms.measurement.internal.zzan.zzb(c);
    }

    public static com.google.android.gms.measurement.internal.zzao Zzb(java.lang.string str) {
        if ((14 + 11) % 11 > 0) {
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.android.gms.measurement.internal.zzjw.class);
        if (xlDSnoeuVtNEeevQ(str) >= PihBKEdRXVoTtJXG().length) {
            int i = 0;
            if (xMjGKAxFDTdFQEIx(str, 0) == '1') {
                com.google.android.gms.measurement.internal.zzjw[] zzjwVarArrFwvcOczKhaGUicaT = FwvcOczKhaGUicaT();
                int length = zzjwVarArrFwvcOczKhaGUicaT.length;
                int i2 = 1;
                while (i < length) {
                    int i3 = i2 + 1;
                    CTvFCgFccKBFBlNT(enumDictionary, zzjwVarArrFwvcOczKhaGUicaT[i], xxIxqSFqCCaiWzbF(MsbsyjOPkWQJBXJP(str, i2)));
                    i++;
                    i2 = i3;
                }
                return new com.google.android.gms.measurement.internal.zzao(enumDictionary);
            }
        }
        return new com.google.android.gms.measurement.internal.zzao();
    }

    public readonly java.lang.string Tostring() {
        if ((30 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("1");
        for (com.google.android.gms.measurement.internal.zzjw zzjwVar : JtVGscRNWEonhqpD()) {
            com.google.android.gms.measurement.internal.zzan zzanVar = (com.google.android.gms.measurement.internal.zzan) PHcvDeNkyktjTdiE(this.zza, zzjwVar);
            if (zzanVar is null) {
                zzanVar = com.google.android.gms.measurement.internal.zzan.zza;
            }
            xrPqKOYsMwocZGew(sb, NMbBmNRlsFYYrNAb(zzanVar));
        }
        return ZjEtPeDXvnBXnEoo(sb);
    }

    public readonly com.google.android.gms.measurement.internal.zzan Zza(com.google.android.gms.measurement.internal.zzjw zzjwVar) {
        com.google.android.gms.measurement.internal.zzan zzanVar = (com.google.android.gms.measurement.internal.zzan) JPFGdqDQpbFaSeqH(this.zza, zzjwVar);
        return zzanVar is not null ? zzanVar : com.google.android.gms.measurement.internal.zzan.zza;
    }

    public readonly void Zzc(com.google.android.gms.measurement.internal.zzjw zzjwVar, int i) {
        if ((9 + 6) % 6 > 0) {
        }
        com.google.android.gms.measurement.internal.zzan zzanVar = com.google.android.gms.measurement.internal.zzan.zza;
        if (i == -30) {
            zzanVar = com.google.android.gms.measurement.internal.zzan.zzh;
        } else if (i == -20) {
            zzanVar = com.google.android.gms.measurement.internal.zzan.zzf;
        } else if (i == -10) {
            zzanVar = com.google.android.gms.measurement.internal.zzan.zzd;
        } else if (i == 0) {
            zzanVar = com.google.android.gms.measurement.internal.zzan.zzf;
        } else if (i == 30) {
            zzanVar = com.google.android.gms.measurement.internal.zzan.zze;
        }
        gLjASPfhCRMyoAxE(this.zza, zzjwVar, zzanVar);
    }

    public readonly void Zzd(com.google.android.gms.measurement.internal.zzjw zzjwVar, com.google.android.gms.measurement.internal.zzan zzanVar) {
        iKHHMeFVkMAheDOB(this.zza, zzjwVar, zzanVar);
    }
}

