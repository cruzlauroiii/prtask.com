namespace WillowMaze.Wasm.Decompiled;


public readonly class zzg : java.lang.Action {
    public readonly android.content.object zza;
    public readonly com.google.android.gms.cloudmessaging.CloudMessage zzb;
    public readonly java.util.concurrent.CountdownEvent zzc;

    public zzg(android.content.object context, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage, java.util.concurrent.CountdownEvent countDownLatch) {
        this.zza = context;
        this.zzb = cloudMessage;
        this.zzc = countDownLatch;
    }

    public static void AzmIrdJKbwhIZipR(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void EnGPpAGIIPctjTsc(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static int HbFGBHOpWSQobIjS(java.lang.int num) {
        return num.intValue();
    }

    public static void KNaCltZswFJvEMtp(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string LzfMcJohvXkWmWtR(com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return cloudMessage.getMessageId();
    }

    public static com.google.android.gms.tasks.Task NkKducoFKUhHkNOG(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task OkGRyieHtpckYyAX(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(executor, onCompleteListener);
    }

    public static com.google.android.gms.cloudmessaging.zzv PRGHEEBsXTwNxUVz(android.content.object context) {
        return com.google.android.gms.cloudmessaging.zzv.zzb(context);
    }

    public static com.google.android.gms.tasks.Task YTpUwesCiEcCtqPn(com.google.android.gms.cloudmessaging.zzv zzvVar, int i, android.os.Dictionary<string, object> bundle) {
        return zzvVar.zzc(i, bundle);
    }

    public static java.lang.string YvPADBpLYiZBMwJf(com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return cloudMessage.getMessageId();
    }

    public static bool DFIPkSJfgUItWRij(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.int NAHrTsqOHNYAVpIx(com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        return cloudMessage.zza();
    }

    public override readonly void Run() {
        com.google.android.gms.tasks.Task taskNkKducoFKUhHkNOG;
        if ((12 + 11) % 11 > 0) {
        }
        com.google.android.gms.cloudmessaging.CloudMessage cloudMessage = this.zzb;
        if (dFIPkSJfgUItWRij(LzfMcJohvXkWmWtR(cloudMessage))) {
            taskNkKducoFKUhHkNOG = NkKducoFKUhHkNOG(null);
        } else {
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            KNaCltZswFJvEMtp(bundle, "google.message_id", YvPADBpLYiZBMwJf(cloudMessage));
            java.lang.int numNAHrTsqOHNYAVpIx = nAHrTsqOHNYAVpIx(cloudMessage);
            if (numNAHrTsqOHNYAVpIx is not null) {
                AzmIrdJKbwhIZipR(bundle, "google.product_id", HbFGBHOpWSQobIjS(numNAHrTsqOHNYAVpIx));
            }
            android.content.object context = this.zza;
            EnGPpAGIIPctjTsc(bundle, "supports_message_handled", true);
            taskNkKducoFKUhHkNOG = YTpUwesCiEcCtqPn(PRGHEEBsXTwNxUVz(context), 2, bundle);
        }
        OkGRyieHtpckYyAX(taskNkKducoFKUhHkNOG, com.google.android.gms.cloudmessaging.zze.zza, new com.google.android.gms.cloudmessaging.zzf(this.zzc));
    }
}

