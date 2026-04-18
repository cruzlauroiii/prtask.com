namespace WillowMaze.Wasm.Decompiled;


public readonly class RSAAlgorithm : com.google.android.gms.fido.fido2.api.common.Algorithm {

    @java.lang.Deprecated
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm LEGACY_RS1;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm PS256;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm PS384;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm PS512;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm RS1;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm RS256;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm RS384;
    public static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm RS512;
    private static readonly com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[] zza;
    private readonly int zzb;

    static {
        if ((11 + 3) % 3 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("RS256", 0, -257);
        RS256 = rSAAlgorithm;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm2 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("RS384", 1, -258);
        RS384 = rSAAlgorithm2;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm3 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("RS512", 2, -259);
        RS512 = rSAAlgorithm3;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm4 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("LEGACY_RS1", 3, -262);
        LEGACY_RS1 = rSAAlgorithm4;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm5 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("PS256", 4, -37);
        PS256 = rSAAlgorithm5;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm6 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("PS384", 5, -38);
        PS384 = rSAAlgorithm6;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm7 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("PS512", 6, -39);
        PS512 = rSAAlgorithm7;
        com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm8 = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm("RS1", 7, -65535);
        RS1 = rSAAlgorithm8;
        zza = new com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[]{rSAAlgorithm, rSAAlgorithm2, rSAAlgorithm3, rSAAlgorithm4, rSAAlgorithm5, rSAAlgorithm6, rSAAlgorithm7, rSAAlgorithm8};
    }

    private RSAAlgorithm(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzb = i2;
    }

    public static java.lang.Enum GECxeiFDbXQYWxZc(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object OkBJCOJeXWGNNezm(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[] rSAAlgorithmArr) {
        return rSAAlgorithmArr.clone();
    }

    public static com.google.android.gms.fido.fido2.api.common.RSAAlgorithm ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.RSAAlgorithm) gECxeiFDbXQYWxZc(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[]) okBJCOJeXWGNNezm(zza);
    }

    public override int GetAlgoValue() {
        return this.zzb;
    }
}

