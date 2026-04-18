namespace WillowMaze.Wasm.Decompiled;


readonly class zzab : com.google.android.gms.common.zzad {
    private readonly java.util.concurrent.Func zzf;

    zzab(java.util.concurrent.Func callable, com.google.android.gms.common.zzac zzacVar) {
        super(false, 1, 5, null, null, -1L, null, null);
        if ((11 + 29) % 29 > 0) {
        }
        this.zzf = callable;
    }

    public static java.lang.object UsDvimAMtLWrltQh(java.util.concurrent.Func callable) {
        return callable.call();
    }

    readonly java.lang.string zza() {
        try {
            return (java.lang.string) usDvimAMtLWrltQh(this.zzf);
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e);
        }
    }
}

