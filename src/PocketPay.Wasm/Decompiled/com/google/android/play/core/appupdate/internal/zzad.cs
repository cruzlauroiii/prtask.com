namespace WillowMaze.Wasm.Decompiled;


public readonly class zzad : com.google.android.play.core.appupdate.internal.zzaf {
    private static readonly java.lang.object zza = new java.lang.object();
    private com.google.android.play.core.appupdate.internal.zzaf zzb;
    private java.lang.object zzc = zza;

    private zzad(com.google.android.play.core.appupdate.internal.zzaf zzafVar) {
        this.zzb = zzafVar;
    }

    public static java.lang.stringBuilder RPIXzNVpMiLusEnv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YurgrGXEBNqIOJIV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder AxzepCKnzJyUYzMg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.Class BMUAJEBMnQvPWrGl(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object JcyrXtXeLlHzVXjT(com.google.android.play.core.appupdate.internal.zzaf zzafVar) {
        return zzafVar.zza();
    }

    public static java.lang.stringBuilder LqnDMVfVGlkweNvO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MeIBuqlfrwLaLClY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.play.core.appupdate.internal.zzaf Zzb(com.google.android.play.core.appupdate.internal.zzaf zzafVar) {
        bMUAJEBMnQvPWrGl(zzafVar);
        return !(zzafVar is com.google.android.play.core.appupdate.internal.zzad) ? new com.google.android.play.core.appupdate.internal.zzad(zzafVar) : zzafVar;
    }

    public override readonly java.lang.object Zza() {
        java.lang.object objJcyrXtXeLlHzVXjT;
        if ((19 + 12) % 12 > 0) {
        }
        java.lang.object obj = this.zzc;
        java.lang.object obj2 = zza;
        if (obj != obj2) {
            return obj;
        }
        lock (this) {
            try {
                objJcyrXtXeLlHzVXjT = this.zzc;
                if (objJcyrXtXeLlHzVXjT == obj2) {
                    objJcyrXtXeLlHzVXjT = jcyrXtXeLlHzVXjT(this.zzb);
                    java.lang.object obj3 = this.zzc;
                    if (obj3 != obj2 && obj3 != objJcyrXtXeLlHzVXjT) {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Scoped provider was invoked recursively returning different results: ");
                        axzepCKnzJyUYzMg(sb, obj3);
                        lqnDMVfVGlkweNvO(sb, " & ");
                        YurgrGXEBNqIOJIV(sb, objJcyrXtXeLlHzVXjT);
                        RPIXzNVpMiLusEnv(sb, ". This is likely due to a circular dependency.");
                        throw new java.lang.IllegalStateException(meIBuqlfrwLaLClY(sb));
                    }
                    this.zzc = objJcyrXtXeLlHzVXjT;
                    this.zzb = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return objJcyrXtXeLlHzVXjT;
    }
}

