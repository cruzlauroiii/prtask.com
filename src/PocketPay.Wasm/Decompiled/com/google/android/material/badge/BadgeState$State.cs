namespace WillowMaze.Wasm.Decompiled;


public readonly class BadgeState$State : android.os.Parcelable {
    private static readonly int BADGE_NUMBER_NONE = -1;
    public static readonly android.os.Parcelable$Creator<com.google.android.material.badge.BadgeState$State> CREATOR = new com.google.android.material.badge.BadgeState$State$1();
    private static readonly int NOT_SET = -2;
    private java.lang.int additionalHorizontalOffset;
    private java.lang.int additionalVerticalOffset;
    private int alpha;
    private java.lang.bool autoAdjustToWithinGrandparentBounds;
    private java.lang.int backgroundColor;
    private java.lang.int badgeGravity;
    private java.lang.int badgeHorizontalPadding;
    private int badgeResId;
    private java.lang.int badgeShapeAppearanceOverlayResId;
    private java.lang.int badgeShapeAppearanceResId;
    private java.lang.int badgeTextAppearanceResId;
    private java.lang.int badgeTextColor;
    private java.lang.int badgeVerticalPadding;
    private java.lang.int badgeWithTextShapeAppearanceOverlayResId;
    private java.lang.int badgeWithTextShapeAppearanceResId;
    private int contentDescriptionExceedsMaxBadgeNumberRes;
    private java.lang.CharSequence contentDescriptionForText;
    private java.lang.CharSequence contentDescriptionNumberless;
    private int contentDescriptionQuantitystrings;
    private java.lang.int horizontalOffsetWithText;
    private java.lang.int horizontalOffsetWithoutText;
    private java.lang.bool isVisible;
    private java.lang.int largeFontVerticalOffsetAdjustment;
    private int maxcharCount;
    private int maxNumber;
    private int number;
    private java.util.Locale numberLocale;
    private java.lang.string text;
    private java.lang.int verticalOffsetWithText;
    private java.lang.int verticalOffsetWithoutText;

    public BadgeState$State() {
        this.alpha = 255;
        this.number = -2;
        this.maxcharCount = -2;
        this.maxNumber = -2;
        this.isVisible = oVKlHACBhohOrwUn(true);
    }

    BadgeState$State(android.os.Parcel parcel) {
        this.alpha = 255;
        this.number = -2;
        this.maxcharCount = -2;
        this.maxNumber = -2;
        this.isVisible = TrtWdoFgiaszssdn(true);
        this.badgeResId = GlhMROXhNUQslRaW(parcel);
        this.backgroundColor = (java.lang.int) tstzlQFzwGjTcMJU(parcel);
        this.badgeTextColor = (java.lang.int) NYRZmiviUihfDhfF(parcel);
        this.badgeTextAppearanceResId = (java.lang.int) daoLYxAZWPDXwwIw(parcel);
        this.badgeShapeAppearanceResId = (java.lang.int) nCAjnRehfMKDrENY(parcel);
        this.badgeShapeAppearanceOverlayResId = (java.lang.int) JkoGXKiatbCCQZUO(parcel);
        this.badgeWithTextShapeAppearanceResId = (java.lang.int) pSgUPCuInmzebdAh(parcel);
        this.badgeWithTextShapeAppearanceOverlayResId = (java.lang.int) QJQcynzfYVveaLSb(parcel);
        this.alpha = fbFEzizJGdViwGDN(parcel);
        this.text = PSzFQRNNGZXXvamr(parcel);
        this.number = qPHgkpmRSPWomwuw(parcel);
        this.maxcharCount = ZJQvglrEkCpNxwqc(parcel);
        this.maxNumber = AONOPCrlZwjCUvKf(parcel);
        this.contentDescriptionForText = dInymkZuIFLeSOxy(parcel);
        this.contentDescriptionNumberless = TAkhUhUNlQMyrXue(parcel);
        this.contentDescriptionQuantitystrings = XYlvMjWOpvedWBvI(parcel);
        this.badgeGravity = (java.lang.int) kOzRMaCiPjiWYqSc(parcel);
        this.badgeHorizontalPadding = (java.lang.int) ioVoyeGNYjZtcEUo(parcel);
        this.badgeVerticalPadding = (java.lang.int) YkuNeKsRVJXOnTQn(parcel);
        this.horizontalOffsetWithoutText = (java.lang.int) aWMmtqBnRzUWoHgx(parcel);
        this.verticalOffsetWithoutText = (java.lang.int) MWkHEeGNLfLfjrJZ(parcel);
        this.horizontalOffsetWithText = (java.lang.int) LMQelEXeksjtoLqJ(parcel);
        this.verticalOffsetWithText = (java.lang.int) eICQWfKNjBUPxPFy(parcel);
        this.largeFontVerticalOffsetAdjustment = (java.lang.int) JkyzUdhmDsOnwMVo(parcel);
        this.additionalHorizontalOffset = (java.lang.int) xymefUnxuSJNaJep(parcel);
        this.additionalVerticalOffset = (java.lang.int) HTktTLAAgsULtxSO(parcel);
        this.isVisible = (java.lang.bool) tJfOwBLsKjIPBehV(parcel);
        this.numberLocale = (java.util.Locale) ZBSKzEEtdPsZWaNG(parcel);
        this.autoAdjustToWithinGrandparentBounds = (java.lang.bool) uRqdvcKVlGdCpCcY(parcel);
    }

    public static int AONOPCrlZwjCUvKf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void AONOPCrlZwjCUvKf(android.os.Parcel parcel, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AONOPCrlZwjCUvKf(android.os.Parcel parcel, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AONOPCrlZwjCUvKf(android.os.Parcel parcel, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkKXRuYKIMgzqMYC(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void DkKXRuYKIMgzqMYC(android.os.Parcel parcel, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkKXRuYKIMgzqMYC(android.os.Parcel parcel, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkKXRuYKIMgzqMYC(android.os.Parcel parcel, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DwziBOhctbvBoPLW(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void DwziBOhctbvBoPLW(android.os.Parcel parcel, java.lang.string str, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DwziBOhctbvBoPLW(android.os.Parcel parcel, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwziBOhctbvBoPLW(android.os.Parcel parcel, java.lang.string str, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FPxjVYFpnyVgAYSJ(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void FPxjVYFpnyVgAYSJ(android.os.Parcel parcel, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPxjVYFpnyVgAYSJ(android.os.Parcel parcel, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FPxjVYFpnyVgAYSJ(android.os.Parcel parcel, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GlhMROXhNUQslRaW(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void GlhMROXhNUQslRaW(android.os.Parcel parcel, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlhMROXhNUQslRaW(android.os.Parcel parcel, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlhMROXhNUQslRaW(android.os.Parcel parcel, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object HTktTLAAgsULtxSO(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void HTktTLAAgsULtxSO(android.os.Parcel parcel, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HTktTLAAgsULtxSO(android.os.Parcel parcel, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HTktTLAAgsULtxSO(android.os.Parcel parcel, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IFzDrUzKEOTMTadv(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void IFzDrUzKEOTMTadv(android.os.Parcel parcel, java.lang.string str, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IFzDrUzKEOTMTadv(android.os.Parcel parcel, java.lang.string str, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFzDrUzKEOTMTadv(android.os.Parcel parcel, java.lang.string str, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IRUCIoVdYPyuriZs(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void IRUCIoVdYPyuriZs(android.os.Parcel parcel, java.io.object serializable, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRUCIoVdYPyuriZs(android.os.Parcel parcel, java.io.object serializable, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRUCIoVdYPyuriZs(android.os.Parcel parcel, java.io.object serializable, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JiDuPIdUDeGKHtMP(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void JiDuPIdUDeGKHtMP(android.os.Parcel parcel, java.io.object serializable, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JiDuPIdUDeGKHtMP(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JiDuPIdUDeGKHtMP(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object JkoGXKiatbCCQZUO(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void JkoGXKiatbCCQZUO(android.os.Parcel parcel, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkoGXKiatbCCQZUO(android.os.Parcel parcel, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JkoGXKiatbCCQZUO(android.os.Parcel parcel, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object JkyzUdhmDsOnwMVo(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void JkyzUdhmDsOnwMVo(android.os.Parcel parcel, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkyzUdhmDsOnwMVo(android.os.Parcel parcel, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JkyzUdhmDsOnwMVo(android.os.Parcel parcel, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object LMQelEXeksjtoLqJ(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void LMQelEXeksjtoLqJ(android.os.Parcel parcel, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMQelEXeksjtoLqJ(android.os.Parcel parcel, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LMQelEXeksjtoLqJ(android.os.Parcel parcel, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object MWkHEeGNLfLfjrJZ(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void MWkHEeGNLfLfjrJZ(android.os.Parcel parcel, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MWkHEeGNLfLfjrJZ(android.os.Parcel parcel, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MWkHEeGNLfLfjrJZ(android.os.Parcel parcel, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object NYRZmiviUihfDhfF(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void NYRZmiviUihfDhfF(android.os.Parcel parcel, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NYRZmiviUihfDhfF(android.os.Parcel parcel, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NYRZmiviUihfDhfF(android.os.Parcel parcel, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OnXWkwFtSgEycFnD(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void OnXWkwFtSgEycFnD(android.os.Parcel parcel, java.io.object serializable, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnXWkwFtSgEycFnD(android.os.Parcel parcel, java.io.object serializable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OnXWkwFtSgEycFnD(android.os.Parcel parcel, java.io.object serializable, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PSzFQRNNGZXXvamr(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void PSzFQRNNGZXXvamr(android.os.Parcel parcel, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PSzFQRNNGZXXvamr(android.os.Parcel parcel, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PSzFQRNNGZXXvamr(android.os.Parcel parcel, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object QJQcynzfYVveaLSb(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void QJQcynzfYVveaLSb(android.os.Parcel parcel, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QJQcynzfYVveaLSb(android.os.Parcel parcel, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QJQcynzfYVveaLSb(android.os.Parcel parcel, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RAWpoFYnaMYjDSro(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void RAWpoFYnaMYjDSro(android.os.Parcel parcel, java.io.object serializable, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RAWpoFYnaMYjDSro(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RAWpoFYnaMYjDSro(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPbEDPSHOVxaUK(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void RRYPbEDPSHOVxaUK(android.os.Parcel parcel, java.io.object serializable, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPbEDPSHOVxaUK(android.os.Parcel parcel, java.io.object serializable, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPbEDPSHOVxaUK(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWJnZgWMOctMmWmH(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void SWJnZgWMOctMmWmH(android.os.Parcel parcel, java.io.object serializable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SWJnZgWMOctMmWmH(android.os.Parcel parcel, java.io.object serializable, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWJnZgWMOctMmWmH(android.os.Parcel parcel, java.io.object serializable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbZuLyZPQkoyHhVk(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void SbZuLyZPQkoyHhVk(android.os.Parcel parcel, java.io.object serializable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SbZuLyZPQkoyHhVk(android.os.Parcel parcel, java.io.object serializable, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SbZuLyZPQkoyHhVk(android.os.Parcel parcel, java.io.object serializable, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SqvkUXZdNXQwhcUM(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void SqvkUXZdNXQwhcUM(android.os.Parcel parcel, int i, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqvkUXZdNXQwhcUM(android.os.Parcel parcel, int i, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqvkUXZdNXQwhcUM(android.os.Parcel parcel, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TAkhUhUNlQMyrXue(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void TAkhUhUNlQMyrXue(android.os.Parcel parcel, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TAkhUhUNlQMyrXue(android.os.Parcel parcel, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TAkhUhUNlQMyrXue(android.os.Parcel parcel, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool TrtWdoFgiaszssdn(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void TrtWdoFgiaszssdn(bool z, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TrtWdoFgiaszssdn(bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TrtWdoFgiaszssdn(bool z, bool z2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHwpRShUesVOOEsK(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void XHwpRShUesVOOEsK(android.os.Parcel parcel, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHwpRShUesVOOEsK(android.os.Parcel parcel, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHwpRShUesVOOEsK(android.os.Parcel parcel, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XYlvMjWOpvedWBvI(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void XYlvMjWOpvedWBvI(android.os.Parcel parcel, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYlvMjWOpvedWBvI(android.os.Parcel parcel, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYlvMjWOpvedWBvI(android.os.Parcel parcel, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YbqwvwWJDFiLrVBz(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void YbqwvwWJDFiLrVBz(android.os.Parcel parcel, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YbqwvwWJDFiLrVBz(android.os.Parcel parcel, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YbqwvwWJDFiLrVBz(android.os.Parcel parcel, int i, java.lang.string str, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object YkuNeKsRVJXOnTQn(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void YkuNeKsRVJXOnTQn(android.os.Parcel parcel, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkuNeKsRVJXOnTQn(android.os.Parcel parcel, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YkuNeKsRVJXOnTQn(android.os.Parcel parcel, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object ZBSKzEEtdPsZWaNG(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void ZBSKzEEtdPsZWaNG(android.os.Parcel parcel, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZBSKzEEtdPsZWaNG(android.os.Parcel parcel, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZBSKzEEtdPsZWaNG(android.os.Parcel parcel, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZJQvglrEkCpNxwqc(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void ZJQvglrEkCpNxwqc(android.os.Parcel parcel, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZJQvglrEkCpNxwqc(android.os.Parcel parcel, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZJQvglrEkCpNxwqc(android.os.Parcel parcel, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object AWMmtqBnRzUWoHgx(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void AWMmtqBnRzUWoHgx(android.os.Parcel parcel, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AWMmtqBnRzUWoHgx(android.os.Parcel parcel, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AWMmtqBnRzUWoHgx(android.os.Parcel parcel, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeResId;
    }

    static void access$000(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$002(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.badgeResId = i;
        return i;
    }

    static void access$002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$100(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.alpha;
    }

    static void access$100(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$1000(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.maxNumber;
    }

    static void access$1000(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$1002(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.maxNumber = i;
        return i;
    }

    static void access$1002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$1002(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$102(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.alpha = i;
        return i;
    }

    static void access$102(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1100(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeShapeAppearanceResId;
    }

    static void access$1100(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1100(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1100(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeShapeAppearanceResId = num;
        return num;
    }

    static void access$1102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1200(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeShapeAppearanceOverlayResId;
    }

    static void access$1200(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeShapeAppearanceOverlayResId = num;
        return num;
    }

    static void access$1202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1300(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeWithTextShapeAppearanceResId;
    }

    static void access$1300(com.google.android.material.badge.BadgeState$State badgeState$State, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeWithTextShapeAppearanceResId = num;
        return num;
    }

    static void access$1302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1400(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeWithTextShapeAppearanceOverlayResId;
    }

    static void access$1400(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeWithTextShapeAppearanceOverlayResId = num;
        return num;
    }

    static void access$1402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1500(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.backgroundColor;
    }

    static void access$1500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.backgroundColor = num;
        return num;
    }

    static void access$1502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1600(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeTextAppearanceResId;
    }

    static void access$1600(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeTextAppearanceResId = num;
        return num;
    }

    static void access$1602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1700(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeTextColor;
    }

    static void access$1700(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1700(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1700(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeTextColor = num;
        return num;
    }

    static void access$1702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1800(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeGravity;
    }

    static void access$1800(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1800(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1800(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeGravity = num;
        return num;
    }

    static void access$1802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1900(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeHorizontalPadding;
    }

    static void access$1900(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$1902(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeHorizontalPadding = num;
        return num;
    }

    static void access$1902(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1902(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1902(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$200(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.number;
    }

    static void access$200(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2000(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.badgeVerticalPadding;
    }

    static void access$2000(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2000(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2000(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2002(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.badgeVerticalPadding = num;
        return num;
    }

    static void access$2002(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2002(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2002(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static int access$202(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.number = i;
        return i;
    }

    static void access$202(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2100(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.horizontalOffsetWithoutText;
    }

    static void access$2100(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2100(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2100(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.horizontalOffsetWithoutText = num;
        return num;
    }

    static void access$2102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$2102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$2102(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2200(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.verticalOffsetWithoutText;
    }

    static void access$2200(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2200(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2200(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.verticalOffsetWithoutText = num;
        return num;
    }

    static void access$2202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2202(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2300(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.horizontalOffsetWithText;
    }

    static void access$2300(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2300(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2300(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.horizontalOffsetWithText = num;
        return num;
    }

    static void access$2302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2400(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.verticalOffsetWithText;
    }

    static void access$2400(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2400(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2400(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.verticalOffsetWithText = num;
        return num;
    }

    static void access$2402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2500(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.largeFontVerticalOffsetAdjustment;
    }

    static void access$2500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$2500(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.largeFontVerticalOffsetAdjustment = num;
        return num;
    }

    static void access$2502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2600(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.additionalHorizontalOffset;
    }

    static void access$2600(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2600(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2600(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.additionalHorizontalOffset = num;
        return num;
    }

    static void access$2602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$2602(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2700(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.additionalVerticalOffset;
    }

    static void access$2700(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2700(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2700(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.int access$2702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        badgeState$State.additionalVerticalOffset = num;
        return num;
    }

    static void access$2702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2702(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$2800(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.autoAdjustToWithinGrandparentBounds;
    }

    static void access$2800(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2800(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$2800(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$2802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        badgeState$State.autoAdjustToWithinGrandparentBounds = bool;
        return bool;
    }

    static void access$2802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.util.Locale access$2900(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.numberLocale;
    }

    static void access$2900(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$2900(com.google.android.material.badge.BadgeState$State badgeState$State, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2900(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.util.Locale access$2902(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale) {
        badgeState$State.numberLocale = locale;
        return locale;
    }

    static void access$2902(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$2902(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2902(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static java.lang.string access$300(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.text;
    }

    static void access$300(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static java.lang.string access$302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str) {
        badgeState$State.text = str;
        return str;
    }

    static void access$302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, byte b, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static java.lang.CharSequence access$400(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.contentDescriptionForText;
    }

    static void access$400(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.CharSequence access$402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        badgeState$State.contentDescriptionForText = charSequence;
        return charSequence;
    }

    static void access$402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$402(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static java.lang.CharSequence access$500(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.contentDescriptionNumberless;
    }

    static void access$500(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.CharSequence access$502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        badgeState$State.contentDescriptionNumberless = charSequence;
        return charSequence;
    }

    static void access$502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$600(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.contentDescriptionQuantitystrings;
    }

    static void access$600(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$602(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.contentDescriptionQuantitystrings = i;
        return i;
    }

    static void access$602(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$602(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$602(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$700(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.contentDescriptionExceedsMaxBadgeNumberRes;
    }

    static void access$700(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static int access$702(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.contentDescriptionExceedsMaxBadgeNumberRes = i;
        return i;
    }

    static void access$702(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$702(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$702(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$800(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.isVisible;
    }

    static void access$800(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.bool access$802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        badgeState$State.isVisible = bool;
        return bool;
    }

    static void access$802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$802(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static int access$900(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return badgeState$State.maxcharCount;
    }

    static void access$900(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$902(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        badgeState$State.maxcharCount = i;
        return i;
    }

    static void access$902(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$902(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$902(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHfpgLgCZzxpuBfj(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void BHfpgLgCZzxpuBfj(android.os.Parcel parcel, java.io.object serializable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHfpgLgCZzxpuBfj(android.os.Parcel parcel, java.io.object serializable, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHfpgLgCZzxpuBfj(android.os.Parcel parcel, java.io.object serializable, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DInymkZuIFLeSOxy(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void DInymkZuIFLeSOxy(android.os.Parcel parcel, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DInymkZuIFLeSOxy(android.os.Parcel parcel, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DInymkZuIFLeSOxy(android.os.Parcel parcel, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DYBXcQWMpIeYlFkp(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void DYBXcQWMpIeYlFkp(android.os.Parcel parcel, java.io.object serializable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYBXcQWMpIeYlFkp(android.os.Parcel parcel, java.io.object serializable, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYBXcQWMpIeYlFkp(android.os.Parcel parcel, java.io.object serializable, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object DaoLYxAZWPDXwwIw(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void DaoLYxAZWPDXwwIw(android.os.Parcel parcel, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DaoLYxAZWPDXwwIw(android.os.Parcel parcel, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DaoLYxAZWPDXwwIw(android.os.Parcel parcel, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object EICQWfKNjBUPxPFy(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void EICQWfKNjBUPxPFy(android.os.Parcel parcel, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EICQWfKNjBUPxPFy(android.os.Parcel parcel, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EICQWfKNjBUPxPFy(android.os.Parcel parcel, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FbFEzizJGdViwGDN(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void FbFEzizJGdViwGDN(android.os.Parcel parcel, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbFEzizJGdViwGDN(android.os.Parcel parcel, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FbFEzizJGdViwGDN(android.os.Parcel parcel, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object IoVoyeGNYjZtcEUo(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void IoVoyeGNYjZtcEUo(android.os.Parcel parcel, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IoVoyeGNYjZtcEUo(android.os.Parcel parcel, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoVoyeGNYjZtcEUo(android.os.Parcel parcel, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHwGjndgNdQckkls(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void KHwGjndgNdQckkls(android.os.Parcel parcel, java.io.object serializable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KHwGjndgNdQckkls(android.os.Parcel parcel, java.io.object serializable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHwGjndgNdQckkls(android.os.Parcel parcel, java.io.object serializable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object KOzRMaCiPjiWYqSc(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void KOzRMaCiPjiWYqSc(android.os.Parcel parcel, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KOzRMaCiPjiWYqSc(android.os.Parcel parcel, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOzRMaCiPjiWYqSc(android.os.Parcel parcel, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MkYLkjPJuJnXYUSw(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void MkYLkjPJuJnXYUSw(android.os.Parcel parcel, java.io.object serializable, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MkYLkjPJuJnXYUSw(android.os.Parcel parcel, java.io.object serializable, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MkYLkjPJuJnXYUSw(android.os.Parcel parcel, java.io.object serializable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object NCAjnRehfMKDrENY(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void NCAjnRehfMKDrENY(android.os.Parcel parcel, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NCAjnRehfMKDrENY(android.os.Parcel parcel, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NCAjnRehfMKDrENY(android.os.Parcel parcel, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OVKlHACBhohOrwUn(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OVKlHACBhohOrwUn(bool z, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OVKlHACBhohOrwUn(bool z, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OVKlHACBhohOrwUn(bool z, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object PSgUPCuInmzebdAh(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void PSgUPCuInmzebdAh(android.os.Parcel parcel, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSgUPCuInmzebdAh(android.os.Parcel parcel, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PSgUPCuInmzebdAh(android.os.Parcel parcel, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QPHgkpmRSPWomwuw(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void QPHgkpmRSPWomwuw(android.os.Parcel parcel, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QPHgkpmRSPWomwuw(android.os.Parcel parcel, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPHgkpmRSPWomwuw(android.os.Parcel parcel, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QmJZdRPRDxPLAAzX(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void QmJZdRPRDxPLAAzX(android.os.Parcel parcel, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QmJZdRPRDxPLAAzX(android.os.Parcel parcel, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmJZdRPRDxPLAAzX(android.os.Parcel parcel, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SOpIxdYmxzaCBaKR(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void SOpIxdYmxzaCBaKR(android.os.Parcel parcel, java.io.object serializable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SOpIxdYmxzaCBaKR(android.os.Parcel parcel, java.io.object serializable, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SOpIxdYmxzaCBaKR(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SdIqQuAdPcwlZVYC(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void SdIqQuAdPcwlZVYC(android.os.Parcel parcel, java.io.object serializable, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SdIqQuAdPcwlZVYC(android.os.Parcel parcel, java.io.object serializable, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SdIqQuAdPcwlZVYC(android.os.Parcel parcel, java.io.object serializable, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqxEllHfnPNpSRMi(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void SqxEllHfnPNpSRMi(android.os.Parcel parcel, java.io.object serializable, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqxEllHfnPNpSRMi(android.os.Parcel parcel, java.io.object serializable, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqxEllHfnPNpSRMi(android.os.Parcel parcel, java.io.object serializable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object TJfOwBLsKjIPBehV(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void TJfOwBLsKjIPBehV(android.os.Parcel parcel, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TJfOwBLsKjIPBehV(android.os.Parcel parcel, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TJfOwBLsKjIPBehV(android.os.Parcel parcel, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object TstzlQFzwGjTcMJU(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void TstzlQFzwGjTcMJU(android.os.Parcel parcel, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TstzlQFzwGjTcMJU(android.os.Parcel parcel, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TstzlQFzwGjTcMJU(android.os.Parcel parcel, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UCgnMoLRZskvGmPL(java.lang.object obj) {
        return obj.tostring();
    }

    public static void UCgnMoLRZskvGmPL(java.lang.object obj, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UCgnMoLRZskvGmPL(java.lang.object obj, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCgnMoLRZskvGmPL(java.lang.object obj, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UJrydilShnDUNpcp(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void UJrydilShnDUNpcp(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJrydilShnDUNpcp(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UJrydilShnDUNpcp(android.os.Parcel parcel, java.io.object serializable, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object URqdvcKVlGdCpCcY(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void URqdvcKVlGdCpCcY(android.os.Parcel parcel, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URqdvcKVlGdCpCcY(android.os.Parcel parcel, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void URqdvcKVlGdCpCcY(android.os.Parcel parcel, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UVOGkfiKiRjHqZej(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void UVOGkfiKiRjHqZej(android.os.Parcel parcel, java.lang.string str, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UVOGkfiKiRjHqZej(android.os.Parcel parcel, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UVOGkfiKiRjHqZej(android.os.Parcel parcel, java.lang.string str, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VOkGTaueBQaRwHGa(java.lang.object obj) {
        return obj.tostring();
    }

    public static void VOkGTaueBQaRwHGa(java.lang.object obj, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VOkGTaueBQaRwHGa(java.lang.object obj, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VOkGTaueBQaRwHGa(java.lang.object obj, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGeGCJMQqcxeREkd(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void XGeGCJMQqcxeREkd(android.os.Parcel parcel, java.io.object serializable, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGeGCJMQqcxeREkd(android.os.Parcel parcel, java.io.object serializable, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGeGCJMQqcxeREkd(android.os.Parcel parcel, java.io.object serializable, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XTiWchJtGTNEAppd(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void XTiWchJtGTNEAppd(android.os.Parcel parcel, java.io.object serializable, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XTiWchJtGTNEAppd(android.os.Parcel parcel, java.io.object serializable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XTiWchJtGTNEAppd(android.os.Parcel parcel, java.io.object serializable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.object XymefUnxuSJNaJep(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static void XymefUnxuSJNaJep(android.os.Parcel parcel, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XymefUnxuSJNaJep(android.os.Parcel parcel, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XymefUnxuSJNaJep(android.os.Parcel parcel, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZptcIofJaylissOU(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void ZptcIofJaylissOU(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZptcIofJaylissOU(android.os.Parcel parcel, java.io.object serializable, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZptcIofJaylissOU(android.os.Parcel parcel, java.io.object serializable, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZsRRtJBKiJpqTKWu(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void ZsRRtJBKiJpqTKWu(android.os.Parcel parcel, java.io.object serializable, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsRRtJBKiJpqTKWu(android.os.Parcel parcel, java.io.object serializable, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZsRRtJBKiJpqTKWu(android.os.Parcel parcel, java.io.object serializable, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZvlNLPOeBnkTBGfm(android.os.Parcel parcel, java.io.object serializable) {
        parcel.writeobject(serializable);
    }

    public static void ZvlNLPOeBnkTBGfm(android.os.Parcel parcel, java.io.object serializable, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvlNLPOeBnkTBGfm(android.os.Parcel parcel, java.io.object serializable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvlNLPOeBnkTBGfm(android.os.Parcel parcel, java.io.object serializable, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        DkKXRuYKIMgzqMYC(parcel, this.badgeResId);
        dYBXcQWMpIeYlFkp(parcel, this.backgroundColor);
        OnXWkwFtSgEycFnD(parcel, this.badgeTextColor);
        JiDuPIdUDeGKHtMP(parcel, this.badgeTextAppearanceResId);
        IRUCIoVdYPyuriZs(parcel, this.badgeShapeAppearanceResId);
        SWJnZgWMOctMmWmH(parcel, this.badgeShapeAppearanceOverlayResId);
        xGeGCJMQqcxeREkd(parcel, this.badgeWithTextShapeAppearanceResId);
        sqxEllHfnPNpSRMi(parcel, this.badgeWithTextShapeAppearanceOverlayResId);
        SqvkUXZdNXQwhcUM(parcel, this.alpha);
        DwziBOhctbvBoPLW(parcel, this.text);
        YbqwvwWJDFiLrVBz(parcel, this.number);
        FPxjVYFpnyVgAYSJ(parcel, this.maxcharCount);
        qmJZdRPRDxPLAAzX(parcel, this.maxNumber);
        java.lang.CharSequence charSequence = this.contentDescriptionForText;
        IFzDrUzKEOTMTadv(parcel, charSequence is null ? null : uCgnMoLRZskvGmPL(charSequence));
        java.lang.CharSequence charSequence2 = this.contentDescriptionNumberless;
        uVOGkfiKiRjHqZej(parcel, charSequence2 is not null ? vOkGTaueBQaRwHGa(charSequence2) : null);
        XHwpRShUesVOOEsK(parcel, this.contentDescriptionQuantitystrings);
        RAWpoFYnaMYjDSro(parcel, this.badgeGravity);
        mkYLkjPJuJnXYUSw(parcel, this.badgeHorizontalPadding);
        SbZuLyZPQkoyHhVk(parcel, this.badgeVerticalPadding);
        sdIqQuAdPcwlZVYC(parcel, this.horizontalOffsetWithoutText);
        zsRRtJBKiJpqTKWu(parcel, this.verticalOffsetWithoutText);
        sOpIxdYmxzaCBaKR(parcel, this.horizontalOffsetWithText);
        xTiWchJtGTNEAppd(parcel, this.verticalOffsetWithText);
        RRYPbEDPSHOVxaUK(parcel, this.largeFontVerticalOffsetAdjustment);
        kHwGjndgNdQckkls(parcel, this.additionalHorizontalOffset);
        bHfpgLgCZzxpuBfj(parcel, this.additionalVerticalOffset);
        zvlNLPOeBnkTBGfm(parcel, this.isVisible);
        uJrydilShnDUNpcp(parcel, this.numberLocale);
        zptcIofJaylissOU(parcel, this.autoAdjustToWithinGrandparentBounds);
    }
}

