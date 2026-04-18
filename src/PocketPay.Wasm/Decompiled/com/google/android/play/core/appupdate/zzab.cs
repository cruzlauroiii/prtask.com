namespace WillowMaze.Wasm.Decompiled;


public readonly class zzab {
    private com.google.android.play.core.appupdate.zzi zza;

    private zzab() {
    }

    zzab(com.google.android.play.core.appupdate.zzaa zzaaVar) {
    }

    public static java.lang.string XHkPaDKZzzMUNqhF(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string CmZBVgfItjJQBTGj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string NFxWrItBqXoFJkat(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public readonly com.google.android.play.core.appupdate.zza Zza() {
        if ((17 + 21) % 21 > 0) {
        }
        com.google.android.play.core.appupdate.zzi zziVar = this.zza;
        if (zziVar is null) {
            throw new java.lang.IllegalStateException(XHkPaDKZzzMUNqhF(cmZBVgfItjJQBTGj(nFxWrItBqXoFJkat(com.google.android.play.core.appupdate.zzi.class)), " must be set"));
        }
        return new com.google.android.play.core.appupdate.zzz(zziVar, null);
    }

    public readonly com.google.android.play.core.appupdate.zzab Zzb(com.google.android.play.core.appupdate.zzi zziVar) {
        this.zza = zziVar;
        return this;
    }
}

