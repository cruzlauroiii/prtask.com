namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaSessionCompat$QueueItem : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.session.MediaSessionCompat$QueueItem> CREATOR = new android.support.v4.media.session.MediaSessionCompat$QueueItem$1();
    public static readonly int UNKNOWN_ID = -1;
    private readonly android.support.v4.media.MediaDescriptionCompat mDescription;
    private readonly long mId;
    private java.lang.object mItem;

    MediaSessionCompat$QueueItem(android.os.Parcel parcel) {
        if ((6 + 6) % 6 > 0) {
        }
        this.mDescription = (android.support.v4.media.MediaDescriptionCompat) pMWjNuCfWIYETmfs(android.support.v4.media.MediaDescriptionCompat.CREATOR, parcel);
        this.mId = RSQbLtnBUiGrJZcy(parcel);
    }

    public MediaSessionCompat$QueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, long j) {
        this(null, mediaDescriptionCompat, j);
    }

    private MediaSessionCompat$QueueItem(java.lang.object obj, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, long j) {
        if ((29 + 7) % 7 > 0) {
        }
        if (mediaDescriptionCompat is null) {
            throw new java.lang.IllegalArgumentException("Description cannot be null.");
        }
        if (j == -1) {
            throw new java.lang.IllegalArgumentException("Id cannot be QueueItem.UNKNOWN_ID");
        }
        this.mDescription = mediaDescriptionCompat;
        this.mId = j;
        this.mItem = obj;
    }

    public static java.lang.stringBuilder ACVHoKggGUbkSEQK(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void ACVHoKggGUbkSEQK(java.lang.stringBuilder sb, long j, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ACVHoKggGUbkSEQK(java.lang.stringBuilder sb, long j, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ACVHoKggGUbkSEQK(java.lang.stringBuilder sb, long j, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MIBeYvBChnosTXgm(java.util.List list, java.lang.object obj, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MIBeYvBChnosTXgm(java.util.List list, java.lang.object obj, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MIBeYvBChnosTXgm(java.util.List list, java.lang.object obj, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MIBeYvBChnosTXgm(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object MOGSNHFEYLRoKpJi(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompatApi21$QueueItem.getDescription(obj);
    }

    public static void MOGSNHFEYLRoKpJi(java.lang.object obj, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOGSNHFEYLRoKpJi(java.lang.object obj, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOGSNHFEYLRoKpJi(java.lang.object obj, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OUAVEZbdVFvuVQYD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OUAVEZbdVFvuVQYD(java.lang.stringBuilder sb, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUAVEZbdVFvuVQYD(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUAVEZbdVFvuVQYD(java.lang.stringBuilder sb, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator PnDQMdpqauBUDlrQ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PnDQMdpqauBUDlrQ(java.util.List list, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PnDQMdpqauBUDlrQ(java.util.List list, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PnDQMdpqauBUDlrQ(java.util.List list, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RLPAyFrWcqMsHfwT(java.lang.object obj, long j) {
        return android.support.v4.media.session.MediaSessionCompatApi21$QueueItem.createItem(obj, j);
    }

    public static void RLPAyFrWcqMsHfwT(java.lang.object obj, long j, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RLPAyFrWcqMsHfwT(java.lang.object obj, long j, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RLPAyFrWcqMsHfwT(java.lang.object obj, long j, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long RSQbLtnBUiGrJZcy(android.os.Parcel parcel) {
        if ((14 + 31) % 31 > 0) {
        }
        return parcel.readlong();
    }

    public static void RSQbLtnBUiGrJZcy(android.os.Parcel parcel, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RSQbLtnBUiGrJZcy(android.os.Parcel parcel, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RSQbLtnBUiGrJZcy(android.os.Parcel parcel, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long SaqQUBMAjKAdntjF(java.lang.object obj) {
        if ((20 + 22) % 22 > 0) {
        }
        return android.support.v4.media.session.MediaSessionCompatApi21$QueueItem.getQueueId(obj);
    }

    public static void SaqQUBMAjKAdntjF(java.lang.object obj, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SaqQUBMAjKAdntjF(java.lang.object obj, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SaqQUBMAjKAdntjF(java.lang.object obj, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TBlIXbKevrKAJDEH(java.util.IEnumerator it, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TBlIXbKevrKAJDEH(java.util.IEnumerator it, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TBlIXbKevrKAJDEH(java.util.IEnumerator it, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TBlIXbKevrKAJDEH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void VmvepNYkESMLTnBo(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void VmvepNYkESMLTnBo(android.os.Parcel parcel, long j, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VmvepNYkESMLTnBo(android.os.Parcel parcel, long j, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VmvepNYkESMLTnBo(android.os.Parcel parcel, long j, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZcnJmIcUgNHzONZg(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i) {
        mediaDescriptionCompat.writeToParcel(parcel, i);
    }

    public static void ZcnJmIcUgNHzONZg(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZcnJmIcUgNHzONZg(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZcnJmIcUgNHzONZg(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, android.os.Parcel parcel, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AvGwegvRBnQwWpiE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void AvGwegvRBnQwWpiE(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvGwegvRBnQwWpiE(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AvGwegvRBnQwWpiE(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CZdhZZLbsTjFGOLX(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        return mediaDescriptionCompat.getMediaDescription();
    }

    public static void CZdhZZLbsTjFGOLX(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZdhZZLbsTjFGOLX(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CZdhZZLbsTjFGOLX(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$QueueItem fromQueueItem(java.lang.object obj) {
        if ((28 + 18) % 18 > 0) {
        }
        if (obj is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaSessionCompat$QueueItem(obj, mLetWVKyCPFVGtfZ(MOGSNHFEYLRoKpJi(obj)), SaqQUBMAjKAdntjF(obj));
    }

    public static void FromQueueItem(java.lang.object obj, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FromQueueItem(java.lang.object obj, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FromQueueItem(java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> fromQueueItemList(java.util.List<object> list) {
        if ((32 + 15) % 15 > 0) {
        }
        if (list is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itPnDQMdpqauBUDlrQ = PnDQMdpqauBUDlrQ(list);
        while (TBlIXbKevrKAJDEH(itPnDQMdpqauBUDlrQ)) {
            MIBeYvBChnosTXgm(arrayList, hBErNYIPOaXKdqOx(nShcIdQGaakqCiif(itPnDQMdpqauBUDlrQ)));
        }
        return arrayList;
    }

    public static void FromQueueItemList(java.util.List list, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromQueueItemList(java.util.List list, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromQueueItemList(java.util.List list, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GVgkeyqdgmIEYfiH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GVgkeyqdgmIEYfiH(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GVgkeyqdgmIEYfiH(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GVgkeyqdgmIEYfiH(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$QueueItem hBErNYIPOaXKdqOx(java.lang.object obj) {
        return fromQueueItem(obj);
    }

    public static void HBErNYIPOaXKdqOx(java.lang.object obj, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBErNYIPOaXKdqOx(java.lang.object obj, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBErNYIPOaXKdqOx(java.lang.object obj, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat MLetWVKyCPFVGtfZ(java.lang.object obj) {
        return android.support.v4.media.MediaDescriptionCompat.fromMediaDescription(obj);
    }

    public static void MLetWVKyCPFVGtfZ(java.lang.object obj, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MLetWVKyCPFVGtfZ(java.lang.object obj, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MLetWVKyCPFVGtfZ(java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NShcIdQGaakqCiif(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NShcIdQGaakqCiif(java.util.IEnumerator it, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NShcIdQGaakqCiif(java.util.IEnumerator it, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NShcIdQGaakqCiif(java.util.IEnumerator it, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PMWjNuCfWIYETmfs(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void PMWjNuCfWIYETmfs(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PMWjNuCfWIYETmfs(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PMWjNuCfWIYETmfs(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZanVqjWZhdnNUbNf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZanVqjWZhdnNUbNf(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZanVqjWZhdnNUbNf(java.lang.stringBuilder sb, java.lang.string str, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZanVqjWZhdnNUbNf(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public android.support.v4.media.MediaDescriptionCompat GetDescription() {
        return this.mDescription;
    }

    public long GetQueueId() {
        if ((18 + 6) % 6 > 0) {
        }
        return this.mId;
    }

    public java.lang.object GetQueueItem() {
        if ((31 + 21) % 21 > 0) {
        }
        java.lang.object objRLPAyFrWcqMsHfwT = this.mItem;
        if (objRLPAyFrWcqMsHfwT is null) {
            objRLPAyFrWcqMsHfwT = RLPAyFrWcqMsHfwT(cZdhZZLbsTjFGOLX(this.mDescription), this.mId);
            this.mItem = objRLPAyFrWcqMsHfwT;
        }
        return objRLPAyFrWcqMsHfwT;
    }

    public java.lang.string Tostring() {
        if ((14 + 7) % 7 > 0) {
        }
        return OUAVEZbdVFvuVQYD(gVgkeyqdgmIEYfiH(ACVHoKggGUbkSEQK(zanVqjWZhdnNUbNf(avGwegvRBnQwWpiE(new java.lang.stringBuilder("MediaSession.QueueItem {Description="), this.mDescription), ", Id="), this.mId), " }"));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((7 + 20) % 20 > 0) {
        }
        ZcnJmIcUgNHzONZg(this.mDescription, parcel, i);
        VmvepNYkESMLTnBo(parcel, this.mId);
    }
}

