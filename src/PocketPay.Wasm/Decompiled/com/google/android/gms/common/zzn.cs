namespace WillowMaze.Wasm.Decompiled;


readonly class zzn : com.google.android.gms.common.zzm {
    private readonly byte[] zza;

    zzn(byte[] bArr) {
        super(lnUxmRelZSQVpWHa(bArr, 0, 25));
        if ((2 + 30) % 30 > 0) {
        }
        this.zza = bArr;
    }

    public static byte[] LnUxmRelZSQVpWHa(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    readonly byte[] zzf() {
        return this.zza;
    }
}

