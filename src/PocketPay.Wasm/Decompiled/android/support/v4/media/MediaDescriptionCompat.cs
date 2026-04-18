namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaDescriptionCompat : android.os.Parcelable {
    public static readonly long BT_FOLDER_TYPE_ALBUMS = 2;
    public static readonly long BT_FOLDER_TYPE_ARTISTS = 3;
    public static readonly long BT_FOLDER_TYPE_GENRES = 4;
    public static readonly long BT_FOLDER_TYPE_MIXED = 0;
    public static readonly long BT_FOLDER_TYPE_PLAYLISTS = 5;
    public static readonly long BT_FOLDER_TYPE_TITLES = 1;
    public static readonly long BT_FOLDER_TYPE_YEARS = 6;
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.MediaDescriptionCompat> CREATOR = new android.support.v4.media.MediaDescriptionCompat$1();
    public static readonly java.lang.string DESCRIPTION_KEY_MEDIA_Uri = "android.support.v4.media.description.MEDIA_Uri";
    public static readonly java.lang.string DESCRIPTION_KEY_NULL_BUNDLE_FLAG = "android.support.v4.media.description.NULL_BUNDLE_FLAG";
    public static readonly java.lang.string EXTRA_BT_FOLDER_TYPE = "android.media.extra.BT_FOLDER_TYPE";
    public static readonly java.lang.string EXTRA_DOWNLOAD_STATUS = "android.media.extra.DOWNLOAD_STATUS";
    public static readonly long STATUS_DOWNLOADED = 2;
    public static readonly long STATUS_DOWNLOADING = 1;
    public static readonly long STATUS_NOT_DOWNLOADED = 0;
    private readonly java.lang.CharSequence mDescription;
    private java.lang.object mDescriptionObj;
    private readonly android.os.Dictionary<string, object> mExtras;
    private readonly android.graphics.Bitmap mIcon;
    private readonly android.net.Uri mIconUri;
    private readonly java.lang.string mMediaId;
    private readonly android.net.Uri mMediaUri;
    private readonly java.lang.CharSequence mSubtitle;
    private readonly java.lang.CharSequence mTitle;

    MediaDescriptionCompat(android.os.Parcel parcel) {
        if ((25 + 25) % 25 > 0) {
        }
        this.mMediaId = SzVJTATSJaWxKbYs(parcel);
        this.mTitle = (java.lang.CharSequence) bxbVEzqOsoDibjxh(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        this.mSubtitle = (java.lang.CharSequence) ksZqNSXckIaReaeM(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        this.mDescription = (java.lang.CharSequence) PaDJfnoqBfgzthyT(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        java.lang.ClassLoader classLoaderDxVpQywMkYTxoucP = DxVpQywMkYTxoucP(IucsWoeTbvcNrgnO(this));
        this.mIcon = (android.graphics.Bitmap) OzvlmctTtyQUsDOu(parcel, classLoaderDxVpQywMkYTxoucP);
        this.mIconUri = (android.net.Uri) zvcKOlLVWvGIQlkd(parcel, classLoaderDxVpQywMkYTxoucP);
        this.mExtras = spRVnSunRAsWwEjk(parcel, classLoaderDxVpQywMkYTxoucP);
        this.mMediaUri = (android.net.Uri) MPnJKxmBeMbIftoz(parcel, classLoaderDxVpQywMkYTxoucP);
    }

    MediaDescriptionCompat(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.CharSequence charSequence3, android.graphics.Bitmap bitmap, android.net.Uri uri, android.os.Dictionary<string, object> bundle, android.net.Uri uri2) {
        this.mMediaId = str;
        this.mTitle = charSequence;
        this.mSubtitle = charSequence2;
        this.mDescription = charSequence3;
        this.mIcon = bitmap;
        this.mIconUri = uri;
        this.mExtras = bundle;
        this.mMediaUri = uri2;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder AjTPbUmupeoRkuOX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap) {
        return mediaDescriptionCompat$Builder.setIconBitmap(bitmap);
    }

    public static void AjTPbUmupeoRkuOX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AjTPbUmupeoRkuOX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AjTPbUmupeoRkuOX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder BIEPhzOxBlPvMncY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri) {
        return mediaDescriptionCompat$Builder.setMediaUri(uri);
    }

    public static void BIEPhzOxBlPvMncY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIEPhzOxBlPvMncY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIEPhzOxBlPvMncY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BfdYimKeLPxunNiv(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        return mediaDescriptionCompat.getMediaDescription();
    }

    public static void BfdYimKeLPxunNiv(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BfdYimKeLPxunNiv(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BfdYimKeLPxunNiv(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat CHAKomYFQxfqGKex(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder) {
        return mediaDescriptionCompat$Builder.build();
    }

    public static void CHAKomYFQxfqGKex(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CHAKomYFQxfqGKex(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CHAKomYFQxfqGKex(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DYduFfBAXGnZioXn(java.lang.object obj, android.net.Uri uri) {
        android.support.v4.media.MediaDescriptionCompatApi23$Builder.setMediaUri(obj, uri);
    }

    public static void DYduFfBAXGnZioXn(java.lang.object obj, android.net.Uri uri, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYduFfBAXGnZioXn(java.lang.object obj, android.net.Uri uri, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYduFfBAXGnZioXn(java.lang.object obj, android.net.Uri uri, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable DjEZAVPGauYrEFTA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void DjEZAVPGauYrEFTA(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DjEZAVPGauYrEFTA(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DjEZAVPGauYrEFTA(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DkZMRhhjxqUihZTm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void DkZMRhhjxqUihZTm(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DkZMRhhjxqUihZTm(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DkZMRhhjxqUihZTm(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap DmNHnzVNsmFWmxxg(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getIconBitmap(obj);
    }

    public static void DmNHnzVNsmFWmxxg(java.lang.object obj, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DmNHnzVNsmFWmxxg(java.lang.object obj, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DmNHnzVNsmFWmxxg(java.lang.object obj, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader DxVpQywMkYTxoucP(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void DxVpQywMkYTxoucP(java.lang.Class cls, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxVpQywMkYTxoucP(java.lang.Class cls, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DxVpQywMkYTxoucP(java.lang.Class cls, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> FnZuzvQyCILRiRam(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getExtras(obj);
    }

    public static void FnZuzvQyCILRiRam(java.lang.object obj, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnZuzvQyCILRiRam(java.lang.object obj, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnZuzvQyCILRiRam(java.lang.object obj, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence HSnDDyQutnQLNBoJ(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getTitle(obj);
    }

    public static void HSnDDyQutnQLNBoJ(java.lang.object obj, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HSnDDyQutnQLNBoJ(java.lang.object obj, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HSnDDyQutnQLNBoJ(java.lang.object obj, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IUOqStgwGbbLyUix(java.lang.object obj, java.lang.CharSequence charSequence) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setSubtitle(obj, charSequence);
    }

    public static void IUOqStgwGbbLyUix(java.lang.object obj, java.lang.CharSequence charSequence, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUOqStgwGbbLyUix(java.lang.object obj, java.lang.CharSequence charSequence, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUOqStgwGbbLyUix(java.lang.object obj, java.lang.CharSequence charSequence, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class IucsWoeTbvcNrgnO(java.lang.object obj) {
        return obj.GetType();
    }

    public static void IucsWoeTbvcNrgnO(java.lang.object obj, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IucsWoeTbvcNrgnO(java.lang.object obj, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IucsWoeTbvcNrgnO(java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder JUdivjtbjmoYFHJz(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str) {
        return mediaDescriptionCompat$Builder.setMediaId(str);
    }

    public static void JUdivjtbjmoYFHJz(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, byte b, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JUdivjtbjmoYFHJz(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JUdivjtbjmoYFHJz(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, bool z, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmPSUQwtUOUFzemA(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void LmPSUQwtUOUFzemA(android.os.Dictionary<string, object> bundle, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LmPSUQwtUOUFzemA(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LmPSUQwtUOUFzemA(android.os.Dictionary<string, object> bundle, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri MPJprLQYpMfcMuYR(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi23.getMediaUri(obj);
    }

    public static void MPJprLQYpMfcMuYR(java.lang.object obj, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPJprLQYpMfcMuYR(java.lang.object obj, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MPJprLQYpMfcMuYR(java.lang.object obj, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable MPnJKxmBeMbIftoz(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void MPnJKxmBeMbIftoz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MPnJKxmBeMbIftoz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPnJKxmBeMbIftoz(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtLxvMwmMtTmYWuZ(java.lang.object obj, java.lang.string str) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setMediaId(obj, str);
    }

    public static void MtLxvMwmMtTmYWuZ(java.lang.object obj, java.lang.string str, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MtLxvMwmMtTmYWuZ(java.lang.object obj, java.lang.string str, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtLxvMwmMtTmYWuZ(java.lang.object obj, java.lang.string str, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVhfPIAEXmLFwPDh(java.lang.object obj, java.lang.CharSequence charSequence) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setTitle(obj, charSequence);
    }

    public static void NVhfPIAEXmLFwPDh(java.lang.object obj, java.lang.CharSequence charSequence, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVhfPIAEXmLFwPDh(java.lang.object obj, java.lang.CharSequence charSequence, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVhfPIAEXmLFwPDh(java.lang.object obj, java.lang.CharSequence charSequence, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable OzvlmctTtyQUsDOu(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void OzvlmctTtyQUsDOu(android.os.Parcel parcel, java.lang.ClassLoader classLoader, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzvlmctTtyQUsDOu(android.os.Parcel parcel, java.lang.ClassLoader classLoader, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzvlmctTtyQUsDOu(android.os.Parcel parcel, java.lang.ClassLoader classLoader, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PNsFfWXvTCEYRvRu(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void PNsFfWXvTCEYRvRu(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PNsFfWXvTCEYRvRu(java.lang.stringBuilder sb, java.lang.object obj, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PNsFfWXvTCEYRvRu(java.lang.stringBuilder sb, java.lang.object obj, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PNtupbVooqyupndj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static void PNtupbVooqyupndj(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PNtupbVooqyupndj(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PNtupbVooqyupndj(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PaDJfnoqBfgzthyT(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void PaDJfnoqBfgzthyT(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PaDJfnoqBfgzthyT(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PaDJfnoqBfgzthyT(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SzVJTATSJaWxKbYs(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void SzVJTATSJaWxKbYs(android.os.Parcel parcel, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SzVJTATSJaWxKbYs(android.os.Parcel parcel, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SzVJTATSJaWxKbYs(android.os.Parcel parcel, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TduEUTzlvrolFvWu(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21$Builder.build(obj);
    }

    public static void TduEUTzlvrolFvWu(java.lang.object obj, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TduEUTzlvrolFvWu(java.lang.object obj, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TduEUTzlvrolFvWu(java.lang.object obj, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder UpFggPqjPSrawARX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri) {
        return mediaDescriptionCompat$Builder.setIconUri(uri);
    }

    public static void UpFggPqjPSrawARX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UpFggPqjPSrawARX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpFggPqjPSrawARX(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UqIhsrrKJpHUoIIV() {
        return android.support.v4.media.MediaDescriptionCompatApi21$Builder.newInstance();
    }

    public static void UqIhsrrKJpHUoIIV(byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqIhsrrKJpHUoIIV(int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqIhsrrKJpHUoIIV(int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VtgcfYbsMAaOafTd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VtgcfYbsMAaOafTd(java.lang.stringBuilder sb, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtgcfYbsMAaOafTd(java.lang.stringBuilder sb, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtgcfYbsMAaOafTd(java.lang.stringBuilder sb, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEEdFZDajebbFKfq(java.lang.object obj, android.os.Parcel parcel, int i) {
        android.support.v4.media.MediaDescriptionCompatApi21.writeToParcel(obj, parcel, i);
    }

    public static void YEEdFZDajebbFKfq(java.lang.object obj, android.os.Parcel parcel, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEEdFZDajebbFKfq(java.lang.object obj, android.os.Parcel parcel, int i, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEEdFZDajebbFKfq(java.lang.object obj, android.os.Parcel parcel, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder ZuoARZwLmQynHWhY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle) {
        return mediaDescriptionCompat$Builder.setExtras(bundle);
    }

    public static void ZuoARZwLmQynHWhY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZuoARZwLmQynHWhY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZuoARZwLmQynHWhY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BxbVEzqOsoDibjxh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void BxbVEzqOsoDibjxh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BxbVEzqOsoDibjxh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxbVEzqOsoDibjxh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri DOPeZshqzCFfdHbq(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getIconUri(obj);
    }

    public static void DOPeZshqzCFfdHbq(java.lang.object obj, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DOPeZshqzCFfdHbq(java.lang.object obj, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DOPeZshqzCFfdHbq(java.lang.object obj, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EAhHHEZcudAAkjuB(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getMediaId(obj);
    }

    public static void EAhHHEZcudAAkjuB(java.lang.object obj, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EAhHHEZcudAAkjuB(java.lang.object obj, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAhHHEZcudAAkjuB(java.lang.object obj, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EFkMhVYwEYeKPYKg(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EFkMhVYwEYeKPYKg(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EFkMhVYwEYeKPYKg(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EFkMhVYwEYeKPYKg(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void FIaTVnOEkJkJubYg(java.lang.object obj, android.graphics.Bitmap bitmap) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setIconBitmap(obj, bitmap);
    }

    public static void FIaTVnOEkJkJubYg(java.lang.object obj, android.graphics.Bitmap bitmap, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIaTVnOEkJkJubYg(java.lang.object obj, android.graphics.Bitmap bitmap, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIaTVnOEkJkJubYg(java.lang.object obj, android.graphics.Bitmap bitmap, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FPGcxHQGeyjAkWXF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void FPGcxHQGeyjAkWXF(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FPGcxHQGeyjAkWXF(java.lang.stringBuilder sb, java.lang.object obj, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FPGcxHQGeyjAkWXF(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat FromMediaDescription(java.lang.object obj) {
        android.net.Uri uri;
        if ((7 + 11) % 11 > 0) {
        }
        android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompatCHAKomYFQxfqGKex = null;
        android.os.Dictionary<string, object> bundle = null;
        if (obj is not null) {
            android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder = new android.support.v4.media.MediaDescriptionCompat$Builder();
            JUdivjtbjmoYFHJz(mediaDescriptionCompat$Builder, eAhHHEZcudAAkjuB(obj));
            pcfMZXlvnKCHpVWN(mediaDescriptionCompat$Builder, HSnDDyQutnQLNBoJ(obj));
            roPPubVjnhqJHknp(mediaDescriptionCompat$Builder, vVfQMYMmDZtYZbpp(obj));
            jwQiSQbcIDPIYJZS(mediaDescriptionCompat$Builder, mlYRErgotLqAgjXR(obj));
            AjTPbUmupeoRkuOX(mediaDescriptionCompat$Builder, DmNHnzVNsmFWmxxg(obj));
            UpFggPqjPSrawARX(mediaDescriptionCompat$Builder, dOPeZshqzCFfdHbq(obj));
            android.os.Dictionary<string, object> bundleFnZuzvQyCILRiRam = FnZuzvQyCILRiRam(obj);
            if (bundleFnZuzvQyCILRiRam is null) {
                uri = null;
            } else {
                LmPSUQwtUOUFzemA(bundleFnZuzvQyCILRiRam);
                uri = (android.net.Uri) DjEZAVPGauYrEFTA(bundleFnZuzvQyCILRiRam, "android.support.v4.media.description.MEDIA_Uri");
            }
            if (uri is null) {
                bundle = bundleFnZuzvQyCILRiRam;
            } else if (!eFkMhVYwEYeKPYKg(bundleFnZuzvQyCILRiRam, "android.support.v4.media.description.NULL_BUNDLE_FLAG") || oUjjiDEIddQvcYGK(bundleFnZuzvQyCILRiRam) != 2) {
                mEVOMRqXOvQPFjIw(bundleFnZuzvQyCILRiRam, "android.support.v4.media.description.MEDIA_Uri");
                PNtupbVooqyupndj(bundleFnZuzvQyCILRiRam, "android.support.v4.media.description.NULL_BUNDLE_FLAG");
                bundle = bundleFnZuzvQyCILRiRam;
            }
            ZuoARZwLmQynHWhY(mediaDescriptionCompat$Builder, bundle);
            if (uri is null) {
                rKyWktfEOzsSMpjW(mediaDescriptionCompat$Builder, MPJprLQYpMfcMuYR(obj));
            } else {
                BIEPhzOxBlPvMncY(mediaDescriptionCompat$Builder, uri);
            }
            mediaDescriptionCompatCHAKomYFQxfqGKex = CHAKomYFQxfqGKex(mediaDescriptionCompat$Builder);
            mediaDescriptionCompatCHAKomYFQxfqGKex.mDescriptionObj = obj;
        }
        return mediaDescriptionCompatCHAKomYFQxfqGKex;
    }

    public static void FromMediaDescription(java.lang.object obj, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaDescription(java.lang.object obj, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaDescription(java.lang.object obj, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GLgSxlvWSjMEnWkK(java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setExtras(obj, bundle);
    }

    public static void GLgSxlvWSjMEnWkK(java.lang.object obj, android.os.Dictionary<string, object> bundle, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GLgSxlvWSjMEnWkK(java.lang.object obj, android.os.Dictionary<string, object> bundle, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLgSxlvWSjMEnWkK(java.lang.object obj, android.os.Dictionary<string, object> bundle, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder jwQiSQbcIDPIYJZS(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setDescription(charSequence);
    }

    public static void JwQiSQbcIDPIYJZS(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JwQiSQbcIDPIYJZS(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwQiSQbcIDPIYJZS(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KsZqNSXckIaReaeM(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void KsZqNSXckIaReaeM(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KsZqNSXckIaReaeM(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KsZqNSXckIaReaeM(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MEVOMRqXOvQPFjIw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static void MEVOMRqXOvQPFjIw(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MEVOMRqXOvQPFjIw(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MEVOMRqXOvQPFjIw(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MlYRErgotLqAgjXR(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getDescription(obj);
    }

    public static void MlYRErgotLqAgjXR(java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MlYRErgotLqAgjXR(java.lang.object obj, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MlYRErgotLqAgjXR(java.lang.object obj, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NXpRlDESHYbJUpUc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NXpRlDESHYbJUpUc(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NXpRlDESHYbJUpUc(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXpRlDESHYbJUpUc(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHYbmGXUkeaLbxqW(java.lang.object obj, java.lang.CharSequence charSequence) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setDescription(obj, charSequence);
    }

    public static void OHYbmGXUkeaLbxqW(java.lang.object obj, java.lang.CharSequence charSequence, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OHYbmGXUkeaLbxqW(java.lang.object obj, java.lang.CharSequence charSequence, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OHYbmGXUkeaLbxqW(java.lang.object obj, java.lang.CharSequence charSequence, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OUjjiDEIddQvcYGK(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static void OUjjiDEIddQvcYGK(android.os.Dictionary<string, object> bundle, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUjjiDEIddQvcYGK(android.os.Dictionary<string, object> bundle, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUjjiDEIddQvcYGK(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder pcfMZXlvnKCHpVWN(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setTitle(charSequence);
    }

    public static void PcfMZXlvnKCHpVWN(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcfMZXlvnKCHpVWN(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcfMZXlvnKCHpVWN(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder rKyWktfEOzsSMpjW(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri) {
        return mediaDescriptionCompat$Builder.setMediaUri(uri);
    }

    public static void RKyWktfEOzsSMpjW(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RKyWktfEOzsSMpjW(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RKyWktfEOzsSMpjW(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder roPPubVjnhqJHknp(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setSubtitle(charSequence);
    }

    public static void RoPPubVjnhqJHknp(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RoPPubVjnhqJHknp(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RoPPubVjnhqJHknp(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> SpRVnSunRAsWwEjk(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readDictionary<string, object>(classLoader);
    }

    public static void SpRVnSunRAsWwEjk(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SpRVnSunRAsWwEjk(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SpRVnSunRAsWwEjk(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UBtmGCziKVoGWbqT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UBtmGCziKVoGWbqT(java.lang.stringBuilder sb, java.lang.string str, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UBtmGCziKVoGWbqT(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBtmGCziKVoGWbqT(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence VVfQMYMmDZtYZbpp(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompatApi21.getSubtitle(obj);
    }

    public static void VVfQMYMmDZtYZbpp(java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VVfQMYMmDZtYZbpp(java.lang.object obj, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VVfQMYMmDZtYZbpp(java.lang.object obj, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsSMuFXivsNTfaDB(java.lang.object obj, android.net.Uri uri) {
        android.support.v4.media.MediaDescriptionCompatApi21$Builder.setIconUri(obj, uri);
    }

    public static void WsSMuFXivsNTfaDB(java.lang.object obj, android.net.Uri uri, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsSMuFXivsNTfaDB(java.lang.object obj, android.net.Uri uri, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsSMuFXivsNTfaDB(java.lang.object obj, android.net.Uri uri, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable ZvcKOlLVWvGIQlkd(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void ZvcKOlLVWvGIQlkd(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZvcKOlLVWvGIQlkd(android.os.Parcel parcel, java.lang.ClassLoader classLoader, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvcKOlLVWvGIQlkd(android.os.Parcel parcel, java.lang.ClassLoader classLoader, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public java.lang.CharSequence GetDescription() {
        return this.mDescription;
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mExtras;
    }

    public android.graphics.Bitmap GetIconBitmap() {
        return this.mIcon;
    }

    public android.net.Uri GetIconUri() {
        return this.mIconUri;
    }

    public java.lang.object GetMediaDescription() {
        if ((16 + 3) % 3 > 0) {
        }
        java.lang.object objTduEUTzlvrolFvWu = this.mDescriptionObj;
        if (objTduEUTzlvrolFvWu is null) {
            java.lang.object objUqIhsrrKJpHUoIIV = UqIhsrrKJpHUoIIV();
            MtLxvMwmMtTmYWuZ(objUqIhsrrKJpHUoIIV, this.mMediaId);
            NVhfPIAEXmLFwPDh(objUqIhsrrKJpHUoIIV, this.mTitle);
            IUOqStgwGbbLyUix(objUqIhsrrKJpHUoIIV, this.mSubtitle);
            oHYbmGXUkeaLbxqW(objUqIhsrrKJpHUoIIV, this.mDescription);
            fIaTVnOEkJkJubYg(objUqIhsrrKJpHUoIIV, this.mIcon);
            wsSMuFXivsNTfaDB(objUqIhsrrKJpHUoIIV, this.mIconUri);
            gLgSxlvWSjMEnWkK(objUqIhsrrKJpHUoIIV, this.mExtras);
            DYduFfBAXGnZioXn(objUqIhsrrKJpHUoIIV, this.mMediaUri);
            objTduEUTzlvrolFvWu = TduEUTzlvrolFvWu(objUqIhsrrKJpHUoIIV);
            this.mDescriptionObj = objTduEUTzlvrolFvWu;
        }
        return objTduEUTzlvrolFvWu;
    }

    public java.lang.string GetMediaId() {
        return this.mMediaId;
    }

    public android.net.Uri GetMediaUri() {
        return this.mMediaUri;
    }

    public java.lang.CharSequence GetSubtitle() {
        return this.mSubtitle;
    }

    public java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public java.lang.string Tostring() {
        if ((24 + 28) % 28 > 0) {
        }
        return VtgcfYbsMAaOafTd(PNsFfWXvTCEYRvRu(nXpRlDESHYbJUpUc(DkZMRhhjxqUihZTm(uBtmGCziKVoGWbqT(fPGcxHQGeyjAkWXF(new java.lang.stringBuilder(), this.mTitle), ", "), this.mSubtitle), ", "), this.mDescription));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        YEEdFZDajebbFKfq(BfdYimKeLPxunNiv(this), parcel, i);
    }
}

