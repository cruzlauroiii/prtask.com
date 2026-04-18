namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaMetadataCompat : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.MediaMetadataCompat> CREATOR;
    static readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.int> METADATA_KEYS_TYPE;
    public static readonly java.lang.string METADATA_KEY_ADVERTISEMENT = "android.media.metadata.ADVERTISEMENT";
    public static readonly java.lang.string METADATA_KEY_ALBUM = "android.media.metadata.ALBUM";
    public static readonly java.lang.string METADATA_KEY_ALBUM_ART = "android.media.metadata.ALBUM_ART";
    public static readonly java.lang.string METADATA_KEY_ALBUM_ARTIST = "android.media.metadata.ALBUM_ARTIST";
    public static readonly java.lang.string METADATA_KEY_ALBUM_ART_Uri = "android.media.metadata.ALBUM_ART_Uri";
    public static readonly java.lang.string METADATA_KEY_ART = "android.media.metadata.ART";
    public static readonly java.lang.string METADATA_KEY_ARTIST = "android.media.metadata.ARTIST";
    public static readonly java.lang.string METADATA_KEY_ART_Uri = "android.media.metadata.ART_Uri";
    public static readonly java.lang.string METADATA_KEY_AUTHOR = "android.media.metadata.AUTHOR";
    public static readonly java.lang.string METADATA_KEY_BT_FOLDER_TYPE = "android.media.metadata.BT_FOLDER_TYPE";
    public static readonly java.lang.string METADATA_KEY_COMPILATION = "android.media.metadata.COMPILATION";
    public static readonly java.lang.string METADATA_KEY_COMPOSER = "android.media.metadata.COMPOSER";
    public static readonly java.lang.string METADATA_KEY_DATE = "android.media.metadata.DATE";
    public static readonly java.lang.string METADATA_KEY_DISC_NUMBER = "android.media.metadata.DISC_NUMBER";
    public static readonly java.lang.string METADATA_KEY_DISPLAY_DESCRIPTION = "android.media.metadata.DISPLAY_DESCRIPTION";
    public static readonly java.lang.string METADATA_KEY_DISPLAY_ICON = "android.media.metadata.DISPLAY_ICON";
    public static readonly java.lang.string METADATA_KEY_DISPLAY_ICON_Uri = "android.media.metadata.DISPLAY_ICON_Uri";
    public static readonly java.lang.string METADATA_KEY_DISPLAY_SUBTITLE = "android.media.metadata.DISPLAY_SUBTITLE";
    public static readonly java.lang.string METADATA_KEY_DISPLAY_TITLE = "android.media.metadata.DISPLAY_TITLE";
    public static readonly java.lang.string METADATA_KEY_DOWNLOAD_STATUS = "android.media.metadata.DOWNLOAD_STATUS";
    public static readonly java.lang.string METADATA_KEY_DURATION = "android.media.metadata.DURATION";
    public static readonly java.lang.string METADATA_KEY_GENRE = "android.media.metadata.GENRE";
    public static readonly java.lang.string METADATA_KEY_MEDIA_ID = "android.media.metadata.MEDIA_ID";
    public static readonly java.lang.string METADATA_KEY_MEDIA_Uri = "android.media.metadata.MEDIA_Uri";
    public static readonly java.lang.string METADATA_KEY_NUM_TRACKS = "android.media.metadata.NUM_TRACKS";
    public static readonly java.lang.string METADATA_KEY_RATING = "android.media.metadata.RATING";
    public static readonly java.lang.string METADATA_KEY_TITLE = "android.media.metadata.TITLE";
    public static readonly java.lang.string METADATA_KEY_TRACK_NUMBER = "android.media.metadata.TRACK_NUMBER";
    public static readonly java.lang.string METADATA_KEY_USER_RATING = "android.media.metadata.USER_RATING";
    public static readonly java.lang.string METADATA_KEY_WRITER = "android.media.metadata.WRITER";
    public static readonly java.lang.string METADATA_KEY_YEAR = "android.media.metadata.YEAR";
    static readonly int METADATA_TYPE_BITMAP = 2;
    static readonly int METADATA_TYPE_LONG = 0;
    static readonly int METADATA_TYPE_RATING = 3;
    static readonly int METADATA_TYPE_TEXT = 1;
    private static readonly java.lang.string[] PREFERRED_BITMAP_ORDER;
    private static readonly java.lang.string[] PREFERRED_DESCRIPTION_ORDER;
    private static readonly java.lang.string[] PREFERRED_Uri_ORDER;
    private static readonly java.lang.string TAG = "MediaMetadata";
    readonly android.os.Dictionary<string, object> mDictionary<string, object>;
    private android.support.v4.media.MediaDescriptionCompat mDescription;
    private java.lang.object mMetadataObj;

    static {
        if ((19 + 9) % 9 > 0) {
        }
        androidx.collection.ArrayDictionary<java.lang.string, java.lang.int> arrayDictionary = new androidx.collection.ArrayDictionary<>();
        METADATA_KEYS_TYPE = arrayDictionary;
        java.lang.int numGmrHFvXjLmzaZQts = gmrHFvXjLmzaZQts(1);
        ZOPOuDUHdaTuYGVH(arrayDictionary, "android.media.metadata.TITLE", numGmrHFvXjLmzaZQts);
        gQCyhtelMmSJdnHZ(arrayDictionary, "android.media.metadata.ARTIST", numGmrHFvXjLmzaZQts);
        java.lang.int numCsvzBGxhPxXDubMQ = CsvzBGxhPxXDubMQ(0);
        LByEilzGxffmmAxq(arrayDictionary, "android.media.metadata.DURATION", numCsvzBGxhPxXDubMQ);
        AjAgdNOTmdpBmJFR(arrayDictionary, "android.media.metadata.ALBUM", numGmrHFvXjLmzaZQts);
        vMxZYnRxSUANlXyK(arrayDictionary, "android.media.metadata.AUTHOR", numGmrHFvXjLmzaZQts);
        DkpfEXNLIjFHiPBR(arrayDictionary, "android.media.metadata.WRITER", numGmrHFvXjLmzaZQts);
        hNksXdqppBCNgAiu(arrayDictionary, "android.media.metadata.COMPOSER", numGmrHFvXjLmzaZQts);
        OjdIJuyfAbkIJEDZ(arrayDictionary, "android.media.metadata.COMPILATION", numGmrHFvXjLmzaZQts);
        DQbcWeWsXGePbFGl(arrayDictionary, "android.media.metadata.DATE", numGmrHFvXjLmzaZQts);
        kwRtbOsqxjTFbKvG(arrayDictionary, "android.media.metadata.YEAR", numCsvzBGxhPxXDubMQ);
        MgpVTthrKpKFzfzb(arrayDictionary, "android.media.metadata.GENRE", numGmrHFvXjLmzaZQts);
        JyEOVlohmwtUDdZg(arrayDictionary, "android.media.metadata.TRACK_NUMBER", numCsvzBGxhPxXDubMQ);
        nRkvwlNGftbxXMrJ(arrayDictionary, "android.media.metadata.NUM_TRACKS", numCsvzBGxhPxXDubMQ);
        ELlVfvHFrEVHnEWB(arrayDictionary, "android.media.metadata.DISC_NUMBER", numCsvzBGxhPxXDubMQ);
        tyRAaradIKoVGwIz(arrayDictionary, "android.media.metadata.ALBUM_ARTIST", numGmrHFvXjLmzaZQts);
        java.lang.int numUDRufJpooxiVPceG = UDRufJpooxiVPceG(2);
        kEEzccbFdQfSgfBE(arrayDictionary, "android.media.metadata.ART", numUDRufJpooxiVPceG);
        ncEIQwqxzoDmOYHw(arrayDictionary, "android.media.metadata.ART_Uri", numGmrHFvXjLmzaZQts);
        AgsPsZpMeQtqXnpr(arrayDictionary, "android.media.metadata.ALBUM_ART", numUDRufJpooxiVPceG);
        TtmDtnItFkbnuwiY(arrayDictionary, "android.media.metadata.ALBUM_ART_Uri", numGmrHFvXjLmzaZQts);
        java.lang.int numKPZxPkeuZwpspxqh = KPZxPkeuZwpspxqh(3);
        YFyGzQpjRdeRMWJN(arrayDictionary, "android.media.metadata.USER_RATING", numKPZxPkeuZwpspxqh);
        bUCTbybPJAQlhvUS(arrayDictionary, "android.media.metadata.RATING", numKPZxPkeuZwpspxqh);
        AHqhZNZtfAhEeplB(arrayDictionary, "android.media.metadata.DISPLAY_TITLE", numGmrHFvXjLmzaZQts);
        NgRBVJsFfHedCwNC(arrayDictionary, "android.media.metadata.DISPLAY_SUBTITLE", numGmrHFvXjLmzaZQts);
        hPhhIQbPqvecwevw(arrayDictionary, "android.media.metadata.DISPLAY_DESCRIPTION", numGmrHFvXjLmzaZQts);
        ZANwQtPYKRRwiHtl(arrayDictionary, "android.media.metadata.DISPLAY_ICON", numUDRufJpooxiVPceG);
        MuXDlhAbPkpVyEXF(arrayDictionary, "android.media.metadata.DISPLAY_ICON_Uri", numGmrHFvXjLmzaZQts);
        VazDVYEyRNGKRGgM(arrayDictionary, "android.media.metadata.MEDIA_ID", numGmrHFvXjLmzaZQts);
        HuBqleDYgDlQtORE(arrayDictionary, "android.media.metadata.BT_FOLDER_TYPE", numCsvzBGxhPxXDubMQ);
        ZrNyFkgHxfUcvmyT(arrayDictionary, "android.media.metadata.MEDIA_Uri", numGmrHFvXjLmzaZQts);
        pMnwZBhfFytSyoXl(arrayDictionary, "android.media.metadata.ADVERTISEMENT", numCsvzBGxhPxXDubMQ);
        yuvdMupISaeIIAeK(arrayDictionary, "android.media.metadata.DOWNLOAD_STATUS", numCsvzBGxhPxXDubMQ);
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = "android.media.metadata.TITLE";
        strArr[1] = "android.media.metadata.ARTIST";
        strArr[2] = "android.media.metadata.ALBUM";
        strArr[3] = "android.media.metadata.ALBUM_ARTIST";
        strArr[4] = "android.media.metadata.WRITER";
        strArr[5] = "android.media.metadata.AUTHOR";
        strArr[6] = "android.media.metadata.COMPOSER";
        PREFERRED_DESCRIPTION_ORDER = strArr;
        java.lang.string[] strArr2 = new java.lang.string[3];
        strArr2[0] = "android.media.metadata.DISPLAY_ICON";
        strArr2[1] = "android.media.metadata.ART";
        strArr2[2] = "android.media.metadata.ALBUM_ART";
        PREFERRED_BITMAP_ORDER = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[3];
        strArr3[0] = "android.media.metadata.DISPLAY_ICON_Uri";
        strArr3[1] = "android.media.metadata.ART_Uri";
        strArr3[2] = "android.media.metadata.ALBUM_ART_Uri";
        PREFERRED_Uri_ORDER = strArr3;
        CREATOR = new android.support.v4.media.MediaMetadataCompat$1();
    }

    MediaMetadataCompat(android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>(bundle);
        this.mDictionary<string, object> = bundle2;
        JiDCaxcIKLZRaisr(bundle2);
    }

    MediaMetadataCompat(android.os.Parcel parcel) {
        this.mDictionary<string, object> = GhjrJkuytPIuQbDQ(parcel, aNNRuaETZnsaVXNM(android.support.v4.media.session.MediaSessionCompat.class));
    }

    public static java.lang.object AHqhZNZtfAhEeplB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void AHqhZNZtfAhEeplB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHqhZNZtfAhEeplB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AHqhZNZtfAhEeplB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AgsPsZpMeQtqXnpr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void AgsPsZpMeQtqXnpr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AgsPsZpMeQtqXnpr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgsPsZpMeQtqXnpr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AjAgdNOTmdpBmJFR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void AjAgdNOTmdpBmJFR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AjAgdNOTmdpBmJFR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AjAgdNOTmdpBmJFR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BUlkVkcwWlZnoJZs(java.lang.object obj, android.os.Parcel parcel, int i) {
        android.support.v4.media.MediaMetadataCompatApi21.writeToParcel(obj, parcel, i);
    }

    public static void BUlkVkcwWlZnoJZs(java.lang.object obj, android.os.Parcel parcel, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BUlkVkcwWlZnoJZs(java.lang.object obj, android.os.Parcel parcel, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BUlkVkcwWlZnoJZs(java.lang.object obj, android.os.Parcel parcel, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BcEzTksVVnQSEFtr(java.lang.object obj) {
        return obj.tostring();
    }

    public static void BcEzTksVVnQSEFtr(java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcEzTksVVnQSEFtr(java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcEzTksVVnQSEFtr(java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BfieTofdmoWrtMlc(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static void BfieTofdmoWrtMlc(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BfieTofdmoWrtMlc(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, java.lang.string str2, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BfieTofdmoWrtMlc(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, bool z, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence CSiEZEvngSYoCHEk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void CSiEZEvngSYoCHEk(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CSiEZEvngSYoCHEk(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSiEZEvngSYoCHEk(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CsvzBGxhPxXDubMQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void CsvzBGxhPxXDubMQ(int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CsvzBGxhPxXDubMQ(int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CsvzBGxhPxXDubMQ(int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder DCHdHttePddeneuw(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str) {
        return mediaDescriptionCompat$Builder.setMediaId(str);
    }

    public static void DCHdHttePddeneuw(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, char c, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCHdHttePddeneuw(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCHdHttePddeneuw(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.string str, bool z, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder DKMYmrZHpyPKcUwY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setTitle(charSequence);
    }

    public static void DKMYmrZHpyPKcUwY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DKMYmrZHpyPKcUwY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DKMYmrZHpyPKcUwY(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DQbcWeWsXGePbFGl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void DQbcWeWsXGePbFGl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQbcWeWsXGePbFGl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQbcWeWsXGePbFGl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DkpfEXNLIjFHiPBR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void DkpfEXNLIjFHiPBR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DkpfEXNLIjFHiPBR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkpfEXNLIjFHiPBR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder ECYMpokYGBAyUhHt(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri) {
        return mediaDescriptionCompat$Builder.setMediaUri(uri);
    }

    public static void ECYMpokYGBAyUhHt(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECYMpokYGBAyUhHt(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECYMpokYGBAyUhHt(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ELlVfvHFrEVHnEWB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void ELlVfvHFrEVHnEWB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELlVfvHFrEVHnEWB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ELlVfvHFrEVHnEWB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLQEVskTURQsHbRn(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static void GLQEVskTURQsHbRn(android.os.Parcel parcel, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLQEVskTURQsHbRn(android.os.Parcel parcel, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GLQEVskTURQsHbRn(android.os.Parcel parcel, int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> GhjrJkuytPIuQbDQ(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readDictionary<string, object>(classLoader);
    }

    public static void GhjrJkuytPIuQbDQ(android.os.Parcel parcel, java.lang.ClassLoader classLoader, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GhjrJkuytPIuQbDQ(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GhjrJkuytPIuQbDQ(android.os.Parcel parcel, java.lang.ClassLoader classLoader, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GqPEtchDdKVubmSm(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void GqPEtchDdKVubmSm(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqPEtchDdKVubmSm(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqPEtchDdKVubmSm(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HuBqleDYgDlQtORE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void HuBqleDYgDlQtORE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HuBqleDYgDlQtORE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HuBqleDYgDlQtORE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JiDCaxcIKLZRaisr(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void JiDCaxcIKLZRaisr(android.os.Dictionary<string, object> bundle, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JiDCaxcIKLZRaisr(android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JiDCaxcIKLZRaisr(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JyEOVlohmwtUDdZg(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void JyEOVlohmwtUDdZg(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JyEOVlohmwtUDdZg(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JyEOVlohmwtUDdZg(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.RatingCompat KAzaNHFbPXQVksKD(java.lang.object obj) {
        return android.support.v4.media.RatingCompat.fromRating(obj);
    }

    public static void KAzaNHFbPXQVksKD(java.lang.object obj, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KAzaNHFbPXQVksKD(java.lang.object obj, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KAzaNHFbPXQVksKD(java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KPZxPkeuZwpspxqh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KPZxPkeuZwpspxqh(int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KPZxPkeuZwpspxqh(int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KPZxPkeuZwpspxqh(int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KqcAYeoCkHjTfZyV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, android.os.Parcel parcel, int i) {
        mediaMetadataCompat.writeToParcel(parcel, i);
    }

    public static void KqcAYeoCkHjTfZyV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, android.os.Parcel parcel, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KqcAYeoCkHjTfZyV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KqcAYeoCkHjTfZyV(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, android.os.Parcel parcel, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LByEilzGxffmmAxq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void LByEilzGxffmmAxq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LByEilzGxffmmAxq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LByEilzGxffmmAxq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LaoZOpZQQjuDxoxM(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static void LaoZOpZQQjuDxoxM(android.os.Dictionary<string, object> bundle, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaoZOpZQQjuDxoxM(android.os.Dictionary<string, object> bundle, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LaoZOpZQQjuDxoxM(android.os.Dictionary<string, object> bundle, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MgpVTthrKpKFzfzb(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void MgpVTthrKpKFzfzb(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MgpVTthrKpKFzfzb(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgpVTthrKpKFzfzb(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MuXDlhAbPkpVyEXF(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void MuXDlhAbPkpVyEXF(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MuXDlhAbPkpVyEXF(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MuXDlhAbPkpVyEXF(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcel MvmaqjCFcDJRYioX() {
        return android.os.Parcel.obtain();
    }

    public static void MvmaqjCFcDJRYioX(char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvmaqjCFcDJRYioX(char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvmaqjCFcDJRYioX(float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NgRBVJsFfHedCwNC(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void NgRBVJsFfHedCwNC(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NgRBVJsFfHedCwNC(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NgRBVJsFfHedCwNC(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NuCmnIVrjpyzreXZ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void NuCmnIVrjpyzreXZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, short s, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void NuCmnIVrjpyzreXZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuCmnIVrjpyzreXZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, char c, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder OLEoMAxSJSplPUTO(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle) {
        return mediaDescriptionCompat$Builder.setExtras(bundle);
    }

    public static void OLEoMAxSJSplPUTO(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLEoMAxSJSplPUTO(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OLEoMAxSJSplPUTO(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OjdIJuyfAbkIJEDZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void OjdIJuyfAbkIJEDZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjdIJuyfAbkIJEDZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OjdIJuyfAbkIJEDZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence PEpROHUmxvEsOnGL(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getText(str);
    }

    public static void PEpROHUmxvEsOnGL(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, char c, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PEpROHUmxvEsOnGL(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PEpROHUmxvEsOnGL(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder RGxRiMsmDifnvhgh(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setDescription(charSequence);
    }

    public static void RGxRiMsmDifnvhgh(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGxRiMsmDifnvhgh(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGxRiMsmDifnvhgh(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RMIcAvEgAYmczQDQ(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getText(str);
    }

    public static void RMIcAvEgAYmczQDQ(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RMIcAvEgAYmczQDQ(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMIcAvEgAYmczQDQ(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap RhtpnhfTyrJjQiXi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getBitmap(str);
    }

    public static void RhtpnhfTyrJjQiXi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RhtpnhfTyrJjQiXi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RhtpnhfTyrJjQiXi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SFapVFVuLYsYlfEF(android.os.Parcel parcel) {
        return android.support.v4.media.MediaMetadataCompatApi21.createFromParcel(parcel);
    }

    public static void SFapVFVuLYsYlfEF(android.os.Parcel parcel, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFapVFVuLYsYlfEF(android.os.Parcel parcel, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFapVFVuLYsYlfEF(android.os.Parcel parcel, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SGWSOLQFBpgQsGWP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle) {
        parcel.writeDictionary<string, object>(bundle);
    }

    public static void SGWSOLQFBpgQsGWP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGWSOLQFBpgQsGWP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SGWSOLQFBpgQsGWP(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcel SKbqIXswXpxYryvw() {
        return android.os.Parcel.obtain();
    }

    public static void SKbqIXswXpxYryvw(char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKbqIXswXpxYryvw(int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SKbqIXswXpxYryvw(java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TtmDtnItFkbnuwiY(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void TtmDtnItFkbnuwiY(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtmDtnItFkbnuwiY(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TtmDtnItFkbnuwiY(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UDRufJpooxiVPceG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UDRufJpooxiVPceG(int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UDRufJpooxiVPceG(int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UDRufJpooxiVPceG(int i, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VazDVYEyRNGKRGgM(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void VazDVYEyRNGKRGgM(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VazDVYEyRNGKRGgM(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VazDVYEyRNGKRGgM(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnALqTkivhVbXkho(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void WnALqTkivhVbXkho(android.os.Parcel parcel, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnALqTkivhVbXkho(android.os.Parcel parcel, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnALqTkivhVbXkho(android.os.Parcel parcel, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XTFjAodnFHxTntXu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getstring(str);
    }

    public static void XTFjAodnFHxTntXu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XTFjAodnFHxTntXu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XTFjAodnFHxTntXu(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence XhqJsLxkxnjDLoTs(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getText(str);
    }

    public static void XhqJsLxkxnjDLoTs(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XhqJsLxkxnjDLoTs(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhqJsLxkxnjDLoTs(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjPeSVzGuDAPzfdd(android.os.Dictionary<string, object> bundle, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjPeSVzGuDAPzfdd(android.os.Dictionary<string, object> bundle, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjPeSVzGuDAPzfdd(android.os.Dictionary<string, object> bundle, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XjPeSVzGuDAPzfdd(android.os.Dictionary<string, object> bundle) {
        return bundle.Count == 0;
    }

    public static void YCJalUzeBcXEMlhK(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YCJalUzeBcXEMlhK(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YCJalUzeBcXEMlhK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YCJalUzeBcXEMlhK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.object YFyGzQpjRdeRMWJN(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void YFyGzQpjRdeRMWJN(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YFyGzQpjRdeRMWJN(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YFyGzQpjRdeRMWJN(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxjijYLlanYkZajD(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxjijYLlanYkZajD(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxjijYLlanYkZajD(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YxjijYLlanYkZajD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.object ZANwQtPYKRRwiHtl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void ZANwQtPYKRRwiHtl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZANwQtPYKRRwiHtl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZANwQtPYKRRwiHtl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZOPOuDUHdaTuYGVH(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void ZOPOuDUHdaTuYGVH(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOPOuDUHdaTuYGVH(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOPOuDUHdaTuYGVH(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZrNyFkgHxfUcvmyT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void ZrNyFkgHxfUcvmyT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZrNyFkgHxfUcvmyT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrNyFkgHxfUcvmyT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader ANNRuaETZnsaVXNM(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void ANNRuaETZnsaVXNM(java.lang.Class cls, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANNRuaETZnsaVXNM(java.lang.Class cls, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANNRuaETZnsaVXNM(java.lang.Class cls, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat AjakrFVXTwNqtwET(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder) {
        return mediaDescriptionCompat$Builder.build();
    }

    public static void AjakrFVXTwNqtwET(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AjakrFVXTwNqtwET(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AjakrFVXTwNqtwET(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BUCTbybPJAQlhvUS(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void BUCTbybPJAQlhvUS(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BUCTbybPJAQlhvUS(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BUCTbybPJAQlhvUS(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet BeJDBBpDHhCCwFND(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static void BeJDBBpDHhCCwFND(android.os.Dictionary<string, object> bundle, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BeJDBBpDHhCCwFND(android.os.Dictionary<string, object> bundle, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BeJDBBpDHhCCwFND(android.os.Dictionary<string, object> bundle, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri CsejuHNFHfDShvvV(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void CsejuHNFHfDShvvV(java.lang.string str, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CsejuHNFHfDShvvV(java.lang.string str, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CsejuHNFHfDShvvV(java.lang.string str, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EAoPPIoWjKJcJXbl(java.lang.CharSequence charSequence, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAoPPIoWjKJcJXbl(java.lang.CharSequence charSequence, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAoPPIoWjKJcJXbl(java.lang.CharSequence charSequence, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EAoPPIoWjKJcJXbl(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.support.v4.media.MediaMetadataCompat FromMediaMetadata(java.lang.object obj) {
        if ((12 + 13) % 13 > 0) {
        }
        if (obj is null) {
            return null;
        }
        android.os.Parcel parcelMvmaqjCFcDJRYioX = MvmaqjCFcDJRYioX();
        BUlkVkcwWlZnoJZs(obj, parcelMvmaqjCFcDJRYioX, 0);
        GLQEVskTURQsHbRn(parcelMvmaqjCFcDJRYioX, 0);
        android.support.v4.media.MediaMetadataCompat mediaMetadataCompat = (android.support.v4.media.MediaMetadataCompat) GqPEtchDdKVubmSm(CREATOR, parcelMvmaqjCFcDJRYioX);
        WnALqTkivhVbXkho(parcelMvmaqjCFcDJRYioX);
        mediaMetadataCompat.mMetadataObj = obj;
        return mediaMetadataCompat;
    }

    public static void FromMediaMetadata(java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaMetadata(java.lang.object obj, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FromMediaMetadata(java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder gABaVWutBXXZKmvg(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri) {
        return mediaDescriptionCompat$Builder.setIconUri(uri);
    }

    public static void GABaVWutBXXZKmvg(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GABaVWutBXXZKmvg(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GABaVWutBXXZKmvg(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.net.Uri uri, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GQCyhtelMmSJdnHZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void GQCyhtelMmSJdnHZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GQCyhtelMmSJdnHZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GQCyhtelMmSJdnHZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GmrHFvXjLmzaZQts(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GmrHFvXjLmzaZQts(int i, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmrHFvXjLmzaZQts(int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmrHFvXjLmzaZQts(int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GvaGimHmabRudVGK(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static void GvaGimHmabRudVGK(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GvaGimHmabRudVGK(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GvaGimHmabRudVGK(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HNksXdqppBCNgAiu(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void HNksXdqppBCNgAiu(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNksXdqppBCNgAiu(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNksXdqppBCNgAiu(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HPhhIQbPqvecwevw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void HPhhIQbPqvecwevw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HPhhIQbPqvecwevw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPhhIQbPqvecwevw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JKuGFiEpOKeLGLIk(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static void JKuGFiEpOKeLGLIk(android.os.Parcel parcel, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JKuGFiEpOKeLGLIk(android.os.Parcel parcel, int i, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JKuGFiEpOKeLGLIk(android.os.Parcel parcel, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JMVpXaECKjAgqOKt(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void JMVpXaECKjAgqOKt(android.os.Parcel parcel, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMVpXaECKjAgqOKt(android.os.Parcel parcel, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMVpXaECKjAgqOKt(android.os.Parcel parcel, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KEEzccbFdQfSgfBE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void KEEzccbFdQfSgfBE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KEEzccbFdQfSgfBE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KEEzccbFdQfSgfBE(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static long KZsYcrabiokBkDGE(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        if ((31 + 32) % 32 > 0) {
        }
        return bundle.getlong(str, j);
    }

    public static void KZsYcrabiokBkDGE(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, byte b, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KZsYcrabiokBkDGE(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KZsYcrabiokBkDGE(android.os.Dictionary<string, object> bundle, java.lang.string str, long j, short s, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KmCEieQsYjvYaARa(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getstring(str);
    }

    public static void KmCEieQsYjvYaARa(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KmCEieQsYjvYaARa(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmCEieQsYjvYaARa(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable KvzUDFdBwcnotNnz(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void KvzUDFdBwcnotNnz(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KvzUDFdBwcnotNnz(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KvzUDFdBwcnotNnz(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KwRtbOsqxjTFbKvG(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void KwRtbOsqxjTFbKvG(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KwRtbOsqxjTFbKvG(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KwRtbOsqxjTFbKvG(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static long LorVxjCAmdAFgncw(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        if ((11 + 26) % 26 > 0) {
        }
        return mediaMetadataCompat.getlong(str);
    }

    public static void LorVxjCAmdAFgncw(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LorVxjCAmdAFgncw(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LorVxjCAmdAFgncw(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MeukDkfFHhyceSDi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getText(str);
    }

    public static void MeukDkfFHhyceSDi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MeukDkfFHhyceSDi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MeukDkfFHhyceSDi(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder nNGlMFyeQKHHPUyx(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap) {
        return mediaDescriptionCompat$Builder.setIconBitmap(bitmap);
    }

    public static void NNGlMFyeQKHHPUyx(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNGlMFyeQKHHPUyx(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NNGlMFyeQKHHPUyx(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, android.graphics.Bitmap bitmap, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NRkvwlNGftbxXMrJ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void NRkvwlNGftbxXMrJ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRkvwlNGftbxXMrJ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRkvwlNGftbxXMrJ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NYReBiOaUINhJgVR(java.lang.CharSequence charSequence, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NYReBiOaUINhJgVR(java.lang.CharSequence charSequence, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NYReBiOaUINhJgVR(java.lang.CharSequence charSequence, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NYReBiOaUINhJgVR(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object NcEIQwqxzoDmOYHw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void NcEIQwqxzoDmOYHw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NcEIQwqxzoDmOYHw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NcEIQwqxzoDmOYHw(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PMnwZBhfFytSyoXl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void PMnwZBhfFytSyoXl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PMnwZBhfFytSyoXl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PMnwZBhfFytSyoXl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable SfJSJPkqUZzschFw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void SfJSJPkqUZzschFw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SfJSJPkqUZzschFw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SfJSJPkqUZzschFw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TyRAaradIKoVGwIz(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void TyRAaradIKoVGwIz(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TyRAaradIKoVGwIz(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TyRAaradIKoVGwIz(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UgWBFuThdraErEbA(java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UgWBFuThdraErEbA(java.lang.CharSequence charSequence, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UgWBFuThdraErEbA(java.lang.CharSequence charSequence, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UgWBFuThdraErEbA(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void UoyIovcmUjVldSmB(java.lang.CharSequence charSequence, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UoyIovcmUjVldSmB(java.lang.CharSequence charSequence, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UoyIovcmUjVldSmB(java.lang.CharSequence charSequence, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UoyIovcmUjVldSmB(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object VMxZYnRxSUANlXyK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void VMxZYnRxSUANlXyK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMxZYnRxSUANlXyK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMxZYnRxSUANlXyK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VjHKjWXoWIUIkJsU(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void VjHKjWXoWIUIkJsU(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, short s, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void VjHKjWXoWIUIkJsU(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, short s, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjHKjWXoWIUIkJsU(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, java.lang.string str3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VotCEoPdhgJPrGxR(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        return mediaMetadataCompat.getstring(str);
    }

    public static void VotCEoPdhgJPrGxR(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VotCEoPdhgJPrGxR(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, java.lang.string str2, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VotCEoPdhgJPrGxR(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, bool z, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence WwKUSMfCEnVguwsZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void WwKUSMfCEnVguwsZ(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WwKUSMfCEnVguwsZ(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WwKUSMfCEnVguwsZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri XoHioXShThfTRLKe(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void XoHioXShThfTRLKe(java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoHioXShThfTRLKe(java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoHioXShThfTRLKe(java.lang.string str, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long YqwHIMUNwuPAKSLH(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str) {
        if ((3 + 1) % 1 > 0) {
        }
        return mediaMetadataCompat.getlong(str);
    }

    public static void YqwHIMUNwuPAKSLH(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqwHIMUNwuPAKSLH(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YqwHIMUNwuPAKSLH(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YuvdMupISaeIIAeK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void YuvdMupISaeIIAeK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuvdMupISaeIIAeK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YuvdMupISaeIIAeK(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAfWuBeDeOgGtgBD(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAfWuBeDeOgGtgBD(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZAfWuBeDeOgGtgBD(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZAfWuBeDeOgGtgBD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static android.support.v4.media.MediaDescriptionCompat$Builder znBjRdedRQTGLvNe(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence) {
        return mediaDescriptionCompat$Builder.setSubtitle(charSequence);
    }

    public static void ZnBjRdedRQTGLvNe(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnBjRdedRQTGLvNe(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnBjRdedRQTGLvNe(android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder, java.lang.CharSequence charSequence, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public bool ContainsKey(java.lang.string str) {
        return YCJalUzeBcXEMlhK(this.mDictionary<string, object>, str);
    }

    public override int DescribeContents() {
        return 0;
    }

    public android.graphics.Bitmap GetBitmap(java.lang.string str) {
        try {
            return (android.graphics.Bitmap) sfJSJPkqUZzschFw(this.mDictionary<string, object>, str);
        } catch (java.lang.Exception e) {
            vjHKjWXoWIUIkJsU("MediaMetadata", "Failed to retrieve a key as Bitmap.", e);
            return null;
        }
    }

    public android.os.Dictionary<string, object> getDictionary<string, object>() {
        return new android.os.Dictionary<string, object>(this.mDictionary<string, object>);
    }

    public android.support.v4.media.MediaDescriptionCompat GetDescription() {
        android.graphics.Bitmap bitmapRhtpnhfTyrJjQiXi;
        android.net.Uri uriCsejuHNFHfDShvvV;
        if ((22 + 4) % 4 > 0) {
        }
        android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat = this.mDescription;
        if (mediaDescriptionCompat is not null) {
            return mediaDescriptionCompat;
        }
        java.lang.string strXTFjAodnFHxTntXu = XTFjAodnFHxTntXu(this, "android.media.metadata.MEDIA_ID");
        java.lang.CharSequence[] charSequenceArr = new java.lang.CharSequence[3];
        java.lang.CharSequence charSequenceRMIcAvEgAYmczQDQ = RMIcAvEgAYmczQDQ(this, "android.media.metadata.DISPLAY_TITLE");
        if (uoyIovcmUjVldSmB(charSequenceRMIcAvEgAYmczQDQ)) {
            int i = 0;
            int i2 = 0;
            while (i < 3) {
                java.lang.string[] strArr = PREFERRED_DESCRIPTION_ORDER;
                if (i2 >= strArr.length) {
                    break;
                }
                int i3 = i2 + 1;
                java.lang.CharSequence charSequenceMeukDkfFHhyceSDi = meukDkfFHhyceSDi(this, strArr[i2]);
                if (!ugWBFuThdraErEbA(charSequenceMeukDkfFHhyceSDi)) {
                    int i4 = i + 1;
                    charSequenceArr[i] = charSequenceMeukDkfFHhyceSDi;
                    i = i4;
                }
                i2 = i3;
            }
        } else {
            charSequenceArr[0] = charSequenceRMIcAvEgAYmczQDQ;
            charSequenceArr[1] = PEpROHUmxvEsOnGL(this, "android.media.metadata.DISPLAY_SUBTITLE");
            charSequenceArr[2] = XhqJsLxkxnjDLoTs(this, "android.media.metadata.DISPLAY_DESCRIPTION");
        }
        int i5 = 0;
        while (true) {
            java.lang.string[] strArr2 = PREFERRED_BITMAP_ORDER;
            if (i5 < strArr2.length) {
                bitmapRhtpnhfTyrJjQiXi = RhtpnhfTyrJjQiXi(this, strArr2[i5]);
                if (bitmapRhtpnhfTyrJjQiXi is not null) {
                    break;
                }
                i5++;
            } else {
                bitmapRhtpnhfTyrJjQiXi = null;
                break;
            }
        }
        int i6 = 0;
        while (true) {
            java.lang.string[] strArr3 = PREFERRED_Uri_ORDER;
            if (i6 < strArr3.length) {
                java.lang.string strKmCEieQsYjvYaARa = kmCEieQsYjvYaARa(this, strArr3[i6]);
                if (!nYReBiOaUINhJgVR(strKmCEieQsYjvYaARa)) {
                    uriCsejuHNFHfDShvvV = csejuHNFHfDShvvV(strKmCEieQsYjvYaARa);
                    break;
                }
                i6++;
            } else {
                uriCsejuHNFHfDShvvV = null;
                break;
            }
        }
        java.lang.string strVotCEoPdhgJPrGxR = votCEoPdhgJPrGxR(this, "android.media.metadata.MEDIA_Uri");
        android.net.Uri uriXoHioXShThfTRLKe = eAoPPIoWjKJcJXbl(strVotCEoPdhgJPrGxR) ? null : xoHioXShThfTRLKe(strVotCEoPdhgJPrGxR);
        android.support.v4.media.MediaDescriptionCompat$Builder mediaDescriptionCompat$Builder = new android.support.v4.media.MediaDescriptionCompat$Builder();
        DCHdHttePddeneuw(mediaDescriptionCompat$Builder, strXTFjAodnFHxTntXu);
        DKMYmrZHpyPKcUwY(mediaDescriptionCompat$Builder, charSequenceArr[0]);
        znBjRdedRQTGLvNe(mediaDescriptionCompat$Builder, charSequenceArr[1]);
        RGxRiMsmDifnvhgh(mediaDescriptionCompat$Builder, charSequenceArr[2]);
        nNGlMFyeQKHHPUyx(mediaDescriptionCompat$Builder, bitmapRhtpnhfTyrJjQiXi);
        gABaVWutBXXZKmvg(mediaDescriptionCompat$Builder, uriCsejuHNFHfDShvvV);
        ECYMpokYGBAyUhHt(mediaDescriptionCompat$Builder, uriXoHioXShThfTRLKe);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        if (zAfWuBeDeOgGtgBD(this.mDictionary<string, object>, "android.media.metadata.BT_FOLDER_TYPE")) {
            BfieTofdmoWrtMlc(bundle, "android.media.extra.BT_FOLDER_TYPE", lorVxjCAmdAFgncw(this, "android.media.metadata.BT_FOLDER_TYPE"));
        }
        if (YxjijYLlanYkZajD(this.mDictionary<string, object>, "android.media.metadata.DOWNLOAD_STATUS")) {
            gvaGimHmabRudVGK(bundle, "android.media.extra.DOWNLOAD_STATUS", yqwHIMUNwuPAKSLH(this, "android.media.metadata.DOWNLOAD_STATUS"));
        }
        if (!XjPeSVzGuDAPzfdd(bundle)) {
            OLEoMAxSJSplPUTO(mediaDescriptionCompat$Builder, bundle);
        }
        android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompatAjakrFVXTwNqtwET = ajakrFVXTwNqtwET(mediaDescriptionCompat$Builder);
        this.mDescription = mediaDescriptionCompatAjakrFVXTwNqtwET;
        return mediaDescriptionCompatAjakrFVXTwNqtwET;
    }

    public long Getlong(java.lang.string str) {
        if ((25 + 1) % 1 > 0) {
        }
        return kZsYcrabiokBkDGE(this.mDictionary<string, object>, str, 0L);
    }

    public java.lang.object GetMediaMetadata() {
        if ((12 + 22) % 22 > 0) {
        }
        if (this.mMetadataObj is null) {
            android.os.Parcel parcelSKbqIXswXpxYryvw = SKbqIXswXpxYryvw();
            KqcAYeoCkHjTfZyV(this, parcelSKbqIXswXpxYryvw, 0);
            jKuGFiEpOKeLGLIk(parcelSKbqIXswXpxYryvw, 0);
            this.mMetadataObj = SFapVFVuLYsYlfEF(parcelSKbqIXswXpxYryvw);
            jMVpXaECKjAgqOKt(parcelSKbqIXswXpxYryvw);
        }
        return this.mMetadataObj;
    }

    public android.support.v4.media.RatingCompat GetRating(java.lang.string str) {
        try {
            return KAzaNHFbPXQVksKD(kvzUDFdBwcnotNnz(this.mDictionary<string, object>, str));
        } catch (java.lang.Exception e) {
            NuCmnIVrjpyzreXZ("MediaMetadata", "Failed to retrieve a key as Rating.", e);
            return null;
        }
    }

    public java.lang.string Getstring(java.lang.string str) {
        java.lang.CharSequence charSequenceWwKUSMfCEnVguwsZ = wwKUSMfCEnVguwsZ(this.mDictionary<string, object>, str);
        if (charSequenceWwKUSMfCEnVguwsZ is null) {
            return null;
        }
        return BcEzTksVVnQSEFtr(charSequenceWwKUSMfCEnVguwsZ);
    }

    public java.lang.CharSequence GetText(java.lang.string str) {
        return CSiEZEvngSYoCHEk(this.mDictionary<string, object>, str);
    }

    public java.util.HashSet<java.lang.string> KeyHashSet() {
        return beJDBBpDHhCCwFND(this.mDictionary<string, object>);
    }

    public int Size() {
        return LaoZOpZQQjuDxoxM(this.mDictionary<string, object>);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        SGWSOLQFBpgQsGWP(parcel, this.mDictionary<string, object>);
    }
}

