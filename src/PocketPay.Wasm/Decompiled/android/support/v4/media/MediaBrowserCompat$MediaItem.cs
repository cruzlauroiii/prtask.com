namespace WillowMaze.Wasm.Decompiled;


public class MediaBrowserCompat$MediaItem : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.MediaBrowserCompat$MediaItem> CREATOR = new android.support.v4.media.MediaBrowserCompat$MediaItem$1();
    public static readonly int FLAG_BROWSABLE = 1;
    public static readonly int FLAG_PLAYABLE = 2;
    private readonly android.support.v4.media.MediaDescriptionCompat mDescription;
    private readonly int mFlags;

    MediaBrowserCompat$MediaItem(android.os.Parcel parcel) {
        this.mFlags = GWWoETQUVmuQmxxJ(parcel);
        this.mDescription = (android.support.v4.media.MediaDescriptionCompat) fcwkeyEtbirTghCh(android.support.v4.media.MediaDescriptionCompat.CREATOR, parcel);
    }

    public MediaBrowserCompat$MediaItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) {
        if (mediaDescriptionCompat is null) {
            throw new java.lang.IllegalArgumentException("description cannot be null");
        }
        if (xfUWXRdaUcTujuwj(bxkWvZZbaCePMYpO(mediaDescriptionCompat))) {
            throw new java.lang.IllegalArgumentException("description must have a non-empty media id");
        }
        this.mFlags = i;
        this.mDescription = mediaDescriptionCompat;
    }

    public static java.lang.object FqKPIdSAACjhBOGp(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21$MediaItem.getDescription(obj);
    }

    public static void FqKPIdSAACjhBOGp(java.lang.object obj, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqKPIdSAACjhBOGp(java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FqKPIdSAACjhBOGp(java.lang.object obj, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GWWoETQUVmuQmxxJ(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void GWWoETQUVmuQmxxJ(android.os.Parcel parcel, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWWoETQUVmuQmxxJ(android.os.Parcel parcel, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GWWoETQUVmuQmxxJ(android.os.Parcel parcel, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JhHpbHOPUaPsfhzs(java.util.IEnumerator it, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JhHpbHOPUaPsfhzs(java.util.IEnumerator it, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JhHpbHOPUaPsfhzs(java.util.IEnumerator it, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool JhHpbHOPUaPsfhzs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.support.v4.media.MediaBrowserCompat$MediaItem LhLWaDJTlGWCnIOe(java.lang.object obj) {
        return fromMediaItem(obj);
    }

    public static void LhLWaDJTlGWCnIOe(java.lang.object obj, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhLWaDJTlGWCnIOe(java.lang.object obj, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LhLWaDJTlGWCnIOe(java.lang.object obj, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LuTCcAryUDBhmmgH(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i) {
        mediaDescriptionCompat.writeToParcel(parcel, i);
    }

    public static void LuTCcAryUDBhmmgH(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LuTCcAryUDBhmmgH(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LuTCcAryUDBhmmgH(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator TJukKQnOyigIrKYx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TJukKQnOyigIrKYx(java.util.List list, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJukKQnOyigIrKYx(java.util.List list, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJukKQnOyigIrKYx(java.util.List list, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UGVjBmNKDpEqFqff(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void UGVjBmNKDpEqFqff(java.lang.stringBuilder sb, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UGVjBmNKDpEqFqff(java.lang.stringBuilder sb, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UGVjBmNKDpEqFqff(java.lang.stringBuilder sb, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UZPOBkyWpgZnOEac(java.util.List list, java.lang.object obj, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UZPOBkyWpgZnOEac(java.util.List list, java.lang.object obj, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UZPOBkyWpgZnOEac(java.util.List list, java.lang.object obj, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UZPOBkyWpgZnOEac(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string WeapeWCbUfZFekkc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WeapeWCbUfZFekkc(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WeapeWCbUfZFekkc(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WeapeWCbUfZFekkc(java.lang.stringBuilder sb, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat YmYIoMHyNbCawOzl(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompat.fromMediaDescription(obj);
    }

    public static void YmYIoMHyNbCawOzl(java.lang.object obj, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YmYIoMHyNbCawOzl(java.lang.object obj, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmYIoMHyNbCawOzl(java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BxkWvZZbaCePMYpO(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        return mediaDescriptionCompat.getMediaId();
    }

    public static void BxkWvZZbaCePMYpO(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BxkWvZZbaCePMYpO(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BxkWvZZbaCePMYpO(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ChBbNqHSQUnkqYAx(java.util.List list) {
        return list.Count;
    }

    public static void ChBbNqHSQUnkqYAx(java.util.List list, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ChBbNqHSQUnkqYAx(java.util.List list, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChBbNqHSQUnkqYAx(java.util.List list, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FcwkeyEtbirTghCh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void FcwkeyEtbirTghCh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FcwkeyEtbirTghCh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcwkeyEtbirTghCh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FkNinExnIskVsJJj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FkNinExnIskVsJJj(java.util.IEnumerator it, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkNinExnIskVsJJj(java.util.IEnumerator it, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FkNinExnIskVsJJj(java.util.IEnumerator it, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaBrowserCompat$MediaItem fromMediaItem(java.lang.object obj) {
        if ((18 + 25) % 25 > 0) {
        }
        if (obj is null) {
            return null;
        }
        return new android.support.v4.media.MediaBrowserCompat$MediaItem(YmYIoMHyNbCawOzl(FqKPIdSAACjhBOGp(obj)), pNKjJDNmSKfuhqaf(obj));
    }

    public static void FromMediaItem(java.lang.object obj, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaItem(java.lang.object obj, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaItem(java.lang.object obj, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> fromMediaItemList(java.util.List<object> list) {
        if ((3 + 3) % 3 > 0) {
        }
        if (list is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List(chBbNqHSQUnkqYAx(list));
        java.util.IEnumerator itTJukKQnOyigIrKYx = TJukKQnOyigIrKYx(list);
        while (JhHpbHOPUaPsfhzs(itTJukKQnOyigIrKYx)) {
            UZPOBkyWpgZnOEac(arrayList, LhLWaDJTlGWCnIOe(fkNinExnIskVsJJj(itTJukKQnOyigIrKYx)));
        }
        return arrayList;
    }

    public static void FromMediaItemList(java.util.List list, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaItemList(java.util.List list, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaItemList(java.util.List list, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JGGnvSGzhEPGMAyq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JGGnvSGzhEPGMAyq(java.lang.stringBuilder sb, java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JGGnvSGzhEPGMAyq(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JGGnvSGzhEPGMAyq(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCkNfwBwMmrpDDwG(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void MCkNfwBwMmrpDDwG(android.os.Parcel parcel, int i, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MCkNfwBwMmrpDDwG(android.os.Parcel parcel, int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCkNfwBwMmrpDDwG(android.os.Parcel parcel, int i, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PNKjJDNmSKfuhqaf(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21$MediaItem.getFlags(obj);
    }

    public static void PNKjJDNmSKfuhqaf(java.lang.object obj, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNKjJDNmSKfuhqaf(java.lang.object obj, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PNKjJDNmSKfuhqaf(java.lang.object obj, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RYoHZCKcZdmjPQoN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void RYoHZCKcZdmjPQoN(java.lang.stringBuilder sb, java.lang.object obj, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYoHZCKcZdmjPQoN(java.lang.stringBuilder sb, java.lang.object obj, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYoHZCKcZdmjPQoN(java.lang.stringBuilder sb, java.lang.object obj, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UxJgdvvpyqBptKIf(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        return mediaDescriptionCompat.getMediaId();
    }

    public static void UxJgdvvpyqBptKIf(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UxJgdvvpyqBptKIf(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UxJgdvvpyqBptKIf(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WtGRCSzupYmwreWl(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void WtGRCSzupYmwreWl(java.lang.stringBuilder sb, char c, float f, char c2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtGRCSzupYmwreWl(java.lang.stringBuilder sb, char c, float f, char c2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtGRCSzupYmwreWl(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, char c2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XfUWXRdaUcTujuwj(java.lang.CharSequence charSequence, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XfUWXRdaUcTujuwj(java.lang.CharSequence charSequence, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfUWXRdaUcTujuwj(java.lang.CharSequence charSequence, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XfUWXRdaUcTujuwj(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public override int DescribeContents() {
        return 0;
    }

    public android.support.v4.media.MediaDescriptionCompat GetDescription() {
        return this.mDescription;
    }

    public int GetFlags() {
        return this.mFlags;
    }

    public java.lang.string GetMediaId() {
        return uxJgdvvpyqBptKIf(this.mDescription);
    }

    public bool IsBrowsable() {
        return (this.mFlags & 1) != 0;
    }

    public bool IsPlayable() {
        return (this.mFlags & 2) != 0;
    }

    public java.lang.string Tostring() {
        if ((18 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("MediaItem{mFlags=");
        UGVjBmNKDpEqFqff(sb, this.mFlags);
        rYoHZCKcZdmjPQoN(jGGnvSGzhEPGMAyq(sb, ", mDescription="), this.mDescription);
        wtGRCSzupYmwreWl(sb, '}');
        return WeapeWCbUfZFekkc(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        mCkNfwBwMmrpDDwG(parcel, this.mFlags);
        LuTCcAryUDBhmmgH(this.mDescription, parcel, i);
    }
}

