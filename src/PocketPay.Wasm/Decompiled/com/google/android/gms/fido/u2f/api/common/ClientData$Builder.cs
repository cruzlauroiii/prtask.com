namespace WillowMaze.Wasm.Decompiled;


public class ClientData$Builder : java.lang.Cloneable {
    private java.lang.string zza;
    private java.lang.string zzb;
    private java.lang.string zzc;
    private com.google.android.gms.fido.u2f.api.common.ChannelIdValue zzd;

    ClientData$Builder() {
        this.zzd = com.google.android.gms.fido.u2f.api.common.ChannelIdValue.ABSENT;
    }

    ClientData$Builder(java.lang.string str, java.lang.string str2, java.lang.string str3, com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        this.zza = str;
        this.zzb = str2;
        this.zzc = str3;
        this.zzd = channelIdValue;
    }

    public static com.google.android.gms.fido.u2f.api.common.ClientData$Builder nZLDTRvdSoYugIeC(com.google.android.gms.fido.u2f.api.common.ClientData$Builder clientData$Builder) {
        return clientData$Builder.clone();
    }

    public static void NZLDTRvdSoYugIeC(com.google.android.gms.fido.u2f.api.common.ClientData$Builder clientData$Builder, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NZLDTRvdSoYugIeC(com.google.android.gms.fido.u2f.api.common.ClientData$Builder clientData$Builder, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZLDTRvdSoYugIeC(com.google.android.gms.fido.u2f.api.common.ClientData$Builder clientData$Builder, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ClientData$Builder newInstance() {
        return new com.google.android.gms.fido.u2f.api.common.ClientData$Builder();
    }

    public static void NewInstance(java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NewInstance(bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NewInstance(bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData Build() {
        if ((22 + 18) % 18 > 0) {
        }
        return new com.google.android.gms.fido.u2f.api.common.ClientData(this.zza, this.zzb, this.zzc, this.zzd);
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData$Builder clone() {
        if ((16 + 22) % 22 > 0) {
        }
        return new com.google.android.gms.fido.u2f.api.common.ClientData$Builder(this.zza, this.zzb, this.zzc, this.zzd);
    }

    public readonly java.lang.object M867clone() throws java.lang.CloneNotSupportedException {
        return nZLDTRvdSoYugIeC(this);
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData$Builder setChallenge(java.lang.string str) {
        this.zzb = str;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData$Builder setChannelId(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        this.zzd = channelIdValue;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData$Builder setOrigin(java.lang.string str) {
        this.zzc = str;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.ClientData$Builder setType(java.lang.string str) {
        this.zza = str;
        return this;
    }
}

