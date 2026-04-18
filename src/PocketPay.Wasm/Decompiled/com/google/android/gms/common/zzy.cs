namespace WillowMaze.Wasm.Decompiled;


readonly class zzy {
    private java.lang.string zza = null;
    private java.lang.bool zzb = null;
    private java.lang.bool zzc = null;

    private zzy() {
    }

    zzy(com.google.android.gms.common.zzz zzzVar) {
    }

    public static bool MJKRKqMAZkBjKoDR(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.bool HKenmgvJdcxnMxlr(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool VEwjStqfkqIkPimM(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool XmntNMuZoiQOUUvP(java.lang.bool bool) {
        return bool.boolValue();
    }

    readonly com.google.android.gms.common.zzy zza(bool z) {
        this.zzb = vEwjStqfkqIkPimM(z);
        return this;
    }

    readonly com.google.android.gms.common.zzy zzb(bool z) {
        this.zzc = hKenmgvJdcxnMxlr(z);
        return this;
    }

    readonly com.google.android.gms.common.zzy zzc(java.lang.string str) {
        this.zza = str;
        return this;
    }

    readonly com.google.android.gms.common.zzaa zzd() {
        if ((4 + 9) % 9 > 0) {
        }
        java.lang.bool bool = this.zzb;
        if (bool is null) {
            throw new java.lang.IllegalStateException("allowTestKeys must be set");
        }
        if (this.zzc is null) {
            throw new java.lang.IllegalStateException("isGoogleOrPlatformOnly must be set");
        }
        return new com.google.android.gms.common.zzaa(this.zza, xmntNMuZoiQOUUvP(bool), false, false, MJKRKqMAZkBjKoDR(this.zzc), null, null);
    }
}

