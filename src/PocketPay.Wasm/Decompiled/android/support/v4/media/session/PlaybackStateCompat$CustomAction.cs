namespace WillowMaze.Wasm.Decompiled;


public readonly class PlaybackStateCompat$CustomAction : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.session.PlaybackStateCompat$CustomAction> CREATOR = new android.support.v4.media.session.PlaybackStateCompat$CustomAction$1();
    private readonly java.lang.string mAction;
    private java.lang.object mCustomActionObj;
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly int mIcon;
    private readonly java.lang.CharSequence mName;

    PlaybackStateCompat$CustomAction(android.os.Parcel parcel) {
        this.mAction = gpEGNFImbBVYNEIA(parcel);
        this.mName = (java.lang.CharSequence) WuuSkvBjAfPkmBZf(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        this.mIcon = EUONgpYpiNybvLpa(parcel);
        this.mExtras = gvviikzzldpausfs(parcel, NAYpabjTbZbnVfxW(android.support.v4.media.session.MediaSessionCompat.class));
    }

    PlaybackStateCompat$CustomAction(java.lang.string str, java.lang.CharSequence charSequence, int i, android.os.Dictionary<string, object> bundle) {
        this.mAction = str;
        this.mName = charSequence;
        this.mIcon = i;
        this.mExtras = bundle;
    }

    public static java.lang.stringBuilder BCgfxqcsnULJkTyv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BCgfxqcsnULJkTyv(java.lang.stringBuilder sb, java.lang.string str, short s, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BCgfxqcsnULJkTyv(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BCgfxqcsnULJkTyv(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EUONgpYpiNybvLpa(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void EUONgpYpiNybvLpa(android.os.Parcel parcel, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUONgpYpiNybvLpa(android.os.Parcel parcel, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUONgpYpiNybvLpa(android.os.Parcel parcel, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GjRqToQzgQkcYVvL(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i) {
        android.text.TextUtils.writeToParcel(charSequence, parcel, i);
    }

    public static void GjRqToQzgQkcYVvL(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GjRqToQzgQkcYVvL(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjRqToQzgQkcYVvL(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KTAjtJZdpOoOdRzt(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void KTAjtJZdpOoOdRzt(android.os.Parcel parcel, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTAjtJZdpOoOdRzt(android.os.Parcel parcel, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KTAjtJZdpOoOdRzt(android.os.Parcel parcel, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader NAYpabjTbZbnVfxW(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void NAYpabjTbZbnVfxW(java.lang.Class cls, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NAYpabjTbZbnVfxW(java.lang.Class cls, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NAYpabjTbZbnVfxW(java.lang.Class cls, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PQgiBmFeQuxvtFEr(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21$CustomAction.getAction(obj);
    }

    public static void PQgiBmFeQuxvtFEr(java.lang.object obj, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PQgiBmFeQuxvtFEr(java.lang.object obj, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQgiBmFeQuxvtFEr(java.lang.object obj, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCCvFEHHrmTvHXNa(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void RCCvFEHHrmTvHXNa(android.os.Parcel parcel, java.lang.string str, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCCvFEHHrmTvHXNa(android.os.Parcel parcel, java.lang.string str, java.lang.string str2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCCvFEHHrmTvHXNa(android.os.Parcel parcel, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SPZdoKXxjRKVXJzg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void SPZdoKXxjRKVXJzg(java.lang.stringBuilder sb, java.lang.object obj, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SPZdoKXxjRKVXJzg(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SPZdoKXxjRKVXJzg(java.lang.stringBuilder sb, java.lang.object obj, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ThGSlBQDcTTHTfIP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle) {
        parcel.writeDictionary<string, object>(bundle);
    }

    public static void ThGSlBQDcTTHTfIP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThGSlBQDcTTHTfIP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThGSlBQDcTTHTfIP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WteJMkZdXrZLcmcu(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21$CustomAction.getIcon(obj);
    }

    public static void WteJMkZdXrZLcmcu(java.lang.object obj, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WteJMkZdXrZLcmcu(java.lang.object obj, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WteJMkZdXrZLcmcu(java.lang.object obj, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WuuSkvBjAfPkmBZf(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void WuuSkvBjAfPkmBZf(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WuuSkvBjAfPkmBZf(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WuuSkvBjAfPkmBZf(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AevhqTkNkNbmVYRC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void AevhqTkNkNbmVYRC(java.lang.stringBuilder sb, java.lang.object obj, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AevhqTkNkNbmVYRC(java.lang.stringBuilder sb, java.lang.object obj, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AevhqTkNkNbmVYRC(java.lang.stringBuilder sb, java.lang.object obj, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AqphVeeSfcYtorPi(java.lang.string str, java.lang.CharSequence charSequence, int i, android.os.Dictionary<string, object> bundle) {
        return android.support.v4.media.session.PlaybackStateCompatApi21$CustomAction.newInstance(str, charSequence, i, bundle);
    }

    public static void AqphVeeSfcYtorPi(java.lang.string str, java.lang.CharSequence charSequence, int i, android.os.Dictionary<string, object> bundle, java.lang.string str2, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AqphVeeSfcYtorPi(java.lang.string str, java.lang.CharSequence charSequence, int i, android.os.Dictionary<string, object> bundle, java.lang.string str2, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AqphVeeSfcYtorPi(java.lang.string str, java.lang.CharSequence charSequence, int i, android.os.Dictionary<string, object> bundle, bool z, int i2, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DDsrttIadZQfnWaM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DDsrttIadZQfnWaM(java.lang.stringBuilder sb, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DDsrttIadZQfnWaM(java.lang.stringBuilder sb, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DDsrttIadZQfnWaM(java.lang.stringBuilder sb, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat$CustomAction fromCustomAction(java.lang.object obj) {
        if ((3 + 17) % 17 > 0) {
        }
        if (obj is null) {
            return null;
        }
        android.support.v4.media.session.PlaybackStateCompat$CustomAction playbackStateCompat$CustomAction = new android.support.v4.media.session.PlaybackStateCompat$CustomAction(PQgiBmFeQuxvtFEr(obj), rSorHIQvYCybAYzx(obj), WteJMkZdXrZLcmcu(obj), viSRLYBWFOVyYmiY(obj));
        playbackStateCompat$CustomAction.mCustomActionObj = obj;
        return playbackStateCompat$CustomAction;
    }

    public static void FromCustomAction(java.lang.object obj, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FromCustomAction(java.lang.object obj, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromCustomAction(java.lang.object obj, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GpEGNFImbBVYNEIA(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void GpEGNFImbBVYNEIA(android.os.Parcel parcel, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpEGNFImbBVYNEIA(android.os.Parcel parcel, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GpEGNFImbBVYNEIA(android.os.Parcel parcel, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> Gvviikzzldpausfs(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readDictionary<string, object>(classLoader);
    }

    public static void Gvviikzzldpausfs(android.os.Parcel parcel, java.lang.ClassLoader classLoader, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Gvviikzzldpausfs(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Gvviikzzldpausfs(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IphtKvoIiXYYtVyZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IphtKvoIiXYYtVyZ(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IphtKvoIiXYYtVyZ(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IphtKvoIiXYYtVyZ(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RSorHIQvYCybAYzx(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21$CustomAction.getName(obj);
    }

    public static void RSorHIQvYCybAYzx(java.lang.object obj, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RSorHIQvYCybAYzx(java.lang.object obj, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RSorHIQvYCybAYzx(java.lang.object obj, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> ViSRLYBWFOVyYmiY(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompatApi21$CustomAction.getExtras(obj);
    }

    public static void ViSRLYBWFOVyYmiY(java.lang.object obj, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViSRLYBWFOVyYmiY(java.lang.object obj, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViSRLYBWFOVyYmiY(java.lang.object obj, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XHoSmGMuzyFTmzQL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XHoSmGMuzyFTmzQL(java.lang.stringBuilder sb, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHoSmGMuzyFTmzQL(java.lang.stringBuilder sb, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHoSmGMuzyFTmzQL(java.lang.stringBuilder sb, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public java.lang.string GetAction() {
        return this.mAction;
    }

    public java.lang.object GetCustomAction() {
        if ((25 + 7) % 7 > 0) {
        }
        java.lang.object objAqphVeeSfcYtorPi = this.mCustomActionObj;
        if (objAqphVeeSfcYtorPi is null) {
            objAqphVeeSfcYtorPi = aqphVeeSfcYtorPi(this.mAction, this.mName, this.mIcon, this.mExtras);
            this.mCustomActionObj = objAqphVeeSfcYtorPi;
        }
        return objAqphVeeSfcYtorPi;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public int GetIcon() {
        return this.mIcon;
    }

    public java.lang.CharSequence GetName() {
        return this.mName;
    }

    public java.lang.string Tostring() {
        if ((16 + 12) % 12 > 0) {
        }
        return xHoSmGMuzyFTmzQL(SPZdoKXxjRKVXJzg(iphtKvoIiXYYtVyZ(dDsrttIadZQfnWaM(BCgfxqcsnULJkTyv(aevhqTkNkNbmVYRC(new java.lang.stringBuilder("Action:mName='"), this.mName), ", mIcon="), this.mIcon), ", mExtras="), this.mExtras));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        RCCvFEHHrmTvHXNa(parcel, this.mAction);
        GjRqToQzgQkcYVvL(this.mName, parcel, i);
        KTAjtJZdpOoOdRzt(parcel, this.mIcon);
        ThGSlBQDcTTHTfIP(parcel, this.mExtras);
    }
}

