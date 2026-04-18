namespace WillowMaze.Wasm.Decompiled;


public readonly class EC2Algorithm : com.google.android.gms.fido.fido2.api.common.Algorithm {
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ED25519;
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ED256;
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ED512;
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ES256;
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ES384;
    public static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm ES512;
    private static readonly com.google.android.gms.fido.fido2.api.common.EC2Algorithm[] zza;
    private readonly int zzb;

    static {
        if ((18 + 10) % 10 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ED256", 0, -260);
        ED256 = eC2Algorithm;
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm2 = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ED512", 1, -261);
        ED512 = eC2Algorithm2;
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm3 = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ED25519", 2, -8);
        ED25519 = eC2Algorithm3;
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm4 = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ES256", 3, -7);
        ES256 = eC2Algorithm4;
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm5 = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ES384", 4, -35);
        ES384 = eC2Algorithm5;
        com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm6 = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm("ES512", 5, -36);
        ES512 = eC2Algorithm6;
        zza = new com.google.android.gms.fido.fido2.api.common.EC2Algorithm[]{eC2Algorithm, eC2Algorithm2, eC2Algorithm3, eC2Algorithm4, eC2Algorithm5, eC2Algorithm6};
    }

    private EC2Algorithm(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzb = i2;
    }

    public static java.lang.object RMqmfftfznQFphmt(com.google.android.gms.fido.fido2.api.common.EC2Algorithm[] eC2AlgorithmArr) {
        return eC2AlgorithmArr.clone();
    }

    public static java.lang.Enum UTdIhCkgsQUVHqeE(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.EC2Algorithm ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.EC2Algorithm) uTdIhCkgsQUVHqeE(com.google.android.gms.fido.fido2.api.common.EC2Algorithm.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.EC2Algorithm[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.EC2Algorithm[]) rMqmfftfznQFphmt(zza);
    }

    public override int GetAlgoValue() {
        return this.zzb;
    }
}

