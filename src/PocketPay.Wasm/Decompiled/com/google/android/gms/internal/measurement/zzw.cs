namespace WillowMaze.Wasm.Decompiled;


public readonly class zzw : com.google.android.gms.internal.measurement.zzai {
    readonly java.util.Dictionary zza;
    private readonly com.google.android.gms.internal.measurement.zzj zzb;

    public zzw(com.google.android.gms.internal.measurement.zzj zzjVar) {
        super("require");
        this.zza = new java.util.HashDictionary();
        this.zzb = zzjVar;
    }

    public static java.lang.object BseOKeiGbZZdBUXm(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string IfRTDRnncEHXBxTd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string JdyClNISvqMQkKbu(com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzapVar.zzi();
    }

    public static java.lang.object LwAHPCNFyZmQIdhC(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object RAADZekOrncBKbkY(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool VOWteOtoxiVQvriq(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object XAiZVpiXPYnuKJgB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool EyLiOfSVvwVLvNYR(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string HHQqAZJnXSBHglEE(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void OLBNGjrABDsrFzNP(java.lang.string str, int i, java.util.List list) {
        com.google.android.gms.internal.measurement.zzh.zzh(str, i, list);
    }

    public static java.lang.object WzZBKpsWMTZQhPKw(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static com.google.android.gms.internal.measurement.zzap ZKRyaawZMiJTRGsT(com.google.android.gms.internal.measurement.zzg zzgVar, com.google.android.gms.internal.measurement.zzap zzapVar) {
        return zzgVar.zzb(zzapVar);
    }

    public override readonly com.google.android.gms.internal.measurement.zzap Zza(com.google.android.gms.internal.measurement.zzg zzgVar, java.util.List list) {
        com.google.android.gms.internal.measurement.zzap zzapVar;
        if ((14 + 11) % 11 > 0) {
        }
        oLBNGjrABDsrFzNP("require", 1, list);
        java.lang.string strJdyClNISvqMQkKbu = JdyClNISvqMQkKbu(zKRyaawZMiJTRGsT(zzgVar, (com.google.android.gms.internal.measurement.zzap) LwAHPCNFyZmQIdhC(list, 0)));
        java.util.Dictionary map = this.zza;
        if (eyLiOfSVvwVLvNYR(map, strJdyClNISvqMQkKbu)) {
            return (com.google.android.gms.internal.measurement.zzap) RAADZekOrncBKbkY(map, strJdyClNISvqMQkKbu);
        }
        java.util.Dictionary map2 = this.zzb.zza;
        if (VOWteOtoxiVQvriq(map2, strJdyClNISvqMQkKbu)) {
            try {
                zzapVar = (com.google.android.gms.internal.measurement.zzap) wzZBKpsWMTZQhPKw((java.util.concurrent.Func) BseOKeiGbZZdBUXm(map2, strJdyClNISvqMQkKbu));
            } catch (java.lang.Exception unused) {
                throw new java.lang.IllegalStateException(hHQqAZJnXSBHglEE("Failed to create API implementation: ", IfRTDRnncEHXBxTd(strJdyClNISvqMQkKbu)));
            }
        } else {
            zzapVar = com.google.android.gms.internal.measurement.zzap.zzf;
        }
        if (zzapVar is com.google.android.gms.internal.measurement.zzai) {
            XAiZVpiXPYnuKJgB(this.zza, strJdyClNISvqMQkKbu, (com.google.android.gms.internal.measurement.zzai) zzapVar);
        }
        return zzapVar;
    }
}

