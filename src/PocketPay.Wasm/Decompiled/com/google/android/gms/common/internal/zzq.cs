namespace WillowMaze.Wasm.Decompiled;


readonly class zzq : android.os.Handler$Callback {
    readonly com.google.android.gms.common.internal.zzs zza;

    zzq(com.google.android.gms.common.internal.zzs zzsVar, com.google.android.gms.common.internal.zzr zzrVar) {
        this.zza = zzsVar;
    }

    public static java.util.HashDictionary ApWGqmKsbFmHarYV(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static java.lang.string BrqdGwwVcNvhEYVL(com.google.android.gms.common.internal.zzo zzoVar) {
        return zzoVar.zzc();
    }

    public static java.util.HashDictionary JUDQPgRwghrrnZty(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static java.lang.object LBBfxJgmrNinsYvF(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.HashDictionary LduTkhsRhGxtrvxT(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static bool LuypkfjzTBSELDkT(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzi();
    }

    public static java.lang.object SCtDqHiriBNXOqsU(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.stringBuilder VXjSnlQQsWnGsSwl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VjoHdGSDkrQdBVXT(com.google.android.gms.common.internal.zzp zzpVar, android.content.ComponentName componentName) {
        zzpVar.onServiceDisconnected(componentName);
    }

    public static java.lang.string WIuLvKlYedjIwlhD(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.util.HashDictionary XlheYAgvKwGfOWGy(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static java.lang.object YTwodbzPvFkYdsGY(java.util.HashDictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static int YlbQmWdZNETEkMaQ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.util.HashDictionary YouvLALXHuZMvyDq(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static android.content.ComponentName ZdmmVyaYbAKngZQg(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzb();
    }

    public static java.lang.object BgWHjjMckcYdHPzk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void GeGPVgbghiEbKJpe(com.google.android.gms.common.internal.zzp zzpVar, java.lang.string str) {
        zzpVar.zzg(str);
    }

    public static bool LuHfukpfrGbHjRWe(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zzj();
    }

    public static java.lang.string OvanvbyIEnFHmHvf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int WeAaBbPhSnexjAKk(com.google.android.gms.common.internal.zzp zzpVar) {
        return zzpVar.zza();
    }

    public static android.content.ComponentName WhkNGsgcoQxXVzFd(com.google.android.gms.common.internal.zzo zzoVar) {
        return zzoVar.zza();
    }

    public override readonly bool HandleMessage(android.os.Message message) {
        if ((9 + 27) % 27 > 0) {
        }
        int i = message.what;
        if (i == 0) {
            lock (LduTkhsRhGxtrvxT(this.zza)) {
                try {
                    com.google.android.gms.common.internal.zzo zzoVar = (com.google.android.gms.common.internal.zzo) message.obj;
                    com.google.android.gms.common.internal.zzp zzpVar = (com.google.android.gms.common.internal.zzp) SCtDqHiriBNXOqsU(XlheYAgvKwGfOWGy(this.zza), zzoVar);
                    if (zzpVar is not null && LuypkfjzTBSELDkT(zzpVar)) {
                        if (luHfukpfrGbHjRWe(zzpVar)) {
                            geGPVgbghiEbKJpe(zzpVar, "GmsClientSupervisor");
                        }
                        YTwodbzPvFkYdsGY(YouvLALXHuZMvyDq(this.zza), zzoVar);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            return true;
        }
        if (i != 1) {
            return false;
        }
        lock (JUDQPgRwghrrnZty(this.zza)) {
            try {
                com.google.android.gms.common.internal.zzo zzoVar2 = (com.google.android.gms.common.internal.zzo) message.obj;
                com.google.android.gms.common.internal.zzp zzpVar2 = (com.google.android.gms.common.internal.zzp) LBBfxJgmrNinsYvF(ApWGqmKsbFmHarYV(this.zza), zzoVar2);
                if (zzpVar2 is not null && weAaBbPhSnexjAKk(zzpVar2) == 3) {
                    java.lang.string strWIuLvKlYedjIwlhD = WIuLvKlYedjIwlhD(zzoVar2);
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Timeout waiting for ServiceConnection callback ");
                    VXjSnlQQsWnGsSwl(sb, strWIuLvKlYedjIwlhD);
                    YlbQmWdZNETEkMaQ("GmsClientSupervisor", ovanvbyIEnFHmHvf(sb), new java.lang.Exception());
                    android.content.ComponentName componentNameZdmmVyaYbAKngZQg = ZdmmVyaYbAKngZQg(zzpVar2);
                    if (componentNameZdmmVyaYbAKngZQg is null) {
                        componentNameZdmmVyaYbAKngZQg = whkNGsgcoQxXVzFd(zzoVar2);
                    }
                    if (componentNameZdmmVyaYbAKngZQg is null) {
                        java.lang.string strBrqdGwwVcNvhEYVL = BrqdGwwVcNvhEYVL(zzoVar2);
                        bgWHjjMckcYdHPzk(strBrqdGwwVcNvhEYVL);
                        java.lang.string str = strBrqdGwwVcNvhEYVL;
                        componentNameZdmmVyaYbAKngZQg = new android.content.ComponentName(strBrqdGwwVcNvhEYVL, "unknown");
                    }
                    VjoHdGSDkrQdBVXT(zzpVar2, componentNameZdmmVyaYbAKngZQg);
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        return true;
    }
}

