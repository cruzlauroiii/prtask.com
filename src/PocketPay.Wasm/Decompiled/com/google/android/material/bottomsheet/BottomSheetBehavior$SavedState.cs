namespace WillowMaze.Wasm.Decompiled;


protected class BottomSheetBehavior$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState> CREATOR = new com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState$1();
    bool fitToContents;
    bool hideable;
    int peekHeight;
    bool skipCollapsed;
    readonly int state;

    public BottomSheetBehavior$SavedState(android.os.Parcel parcel) {
        this(parcel, (java.lang.ClassLoader) null);
    }

    public BottomSheetBehavior$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        if ((5 + 32) % 32 > 0) {
        }
        this.state = tdbXBKRiYjzYdhWZ(parcel);
        this.peekHeight = VqvHFuJjKHHVFuzi(parcel);
        this.fitToContents = dWEvFfGCrmsBizxu(parcel) == 1;
        this.hideable = LwGkttXpWGvifDzk(parcel) == 1;
        this.skipCollapsed = TwjurRVGjfCvLCBQ(parcel) == 1;
    }

    @java.lang.Deprecated
    public BottomSheetBehavior$SavedState(android.os.Parcelable parcelable, int i) {
        super(parcelable);
        this.state = i;
    }

    public BottomSheetBehavior$SavedState(android.os.Parcelable parcelable, com.google.android.material.bottomsheet.BottomSheetBehavior<object> bottomSheetBehavior) {
        super(parcelable);
        this.state = bottomSheetBehavior.state;
        this.peekHeight = wQNJRPitimDbdRQW(bottomSheetBehavior);
        this.fitToContents = lgGICNUQzjCsTwpl(bottomSheetBehavior);
        this.hideable = bottomSheetBehavior.hideable;
        this.skipCollapsed = TxzoCspaaIOrnQOW(bottomSheetBehavior);
    }

    public static void ALEPBNsaPVWEqpRL(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void ALEPBNsaPVWEqpRL(android.os.Parcel parcel, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ALEPBNsaPVWEqpRL(android.os.Parcel parcel, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ALEPBNsaPVWEqpRL(android.os.Parcel parcel, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LwGkttXpWGvifDzk(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void LwGkttXpWGvifDzk(android.os.Parcel parcel, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwGkttXpWGvifDzk(android.os.Parcel parcel, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LwGkttXpWGvifDzk(android.os.Parcel parcel, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RBdxWrgonhbHyvnp(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void RBdxWrgonhbHyvnp(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RBdxWrgonhbHyvnp(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RBdxWrgonhbHyvnp(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, short s, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TwjurRVGjfCvLCBQ(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void TwjurRVGjfCvLCBQ(android.os.Parcel parcel, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwjurRVGjfCvLCBQ(android.os.Parcel parcel, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TwjurRVGjfCvLCBQ(android.os.Parcel parcel, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TxzoCspaaIOrnQOW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxzoCspaaIOrnQOW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxzoCspaaIOrnQOW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TxzoCspaaIOrnQOW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return com.google.android.material.bottomsheet.BottomSheetBehavior.access$2000(bottomSheetBehavior);
    }

    public static int VqvHFuJjKHHVFuzi(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void VqvHFuJjKHHVFuzi(android.os.Parcel parcel, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VqvHFuJjKHHVFuzi(android.os.Parcel parcel, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VqvHFuJjKHHVFuzi(android.os.Parcel parcel, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmkuShqliwSxAotS(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void YmkuShqliwSxAotS(android.os.Parcel parcel, int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmkuShqliwSxAotS(android.os.Parcel parcel, int i, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmkuShqliwSxAotS(android.os.Parcel parcel, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrMAccEOrwzmBGgY(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void ZrMAccEOrwzmBGgY(android.os.Parcel parcel, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZrMAccEOrwzmBGgY(android.os.Parcel parcel, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrMAccEOrwzmBGgY(android.os.Parcel parcel, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DWEvFfGCrmsBizxu(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void DWEvFfGCrmsBizxu(android.os.Parcel parcel, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWEvFfGCrmsBizxu(android.os.Parcel parcel, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWEvFfGCrmsBizxu(android.os.Parcel parcel, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EoQTBEgHdyzxPWzN(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void EoQTBEgHdyzxPWzN(android.os.Parcel parcel, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoQTBEgHdyzxPWzN(android.os.Parcel parcel, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EoQTBEgHdyzxPWzN(android.os.Parcel parcel, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LgGICNUQzjCsTwpl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LgGICNUQzjCsTwpl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LgGICNUQzjCsTwpl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LgGICNUQzjCsTwpl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return com.google.android.material.bottomsheet.BottomSheetBehavior.access$1400(bottomSheetBehavior);
    }

    public static int TdbXBKRiYjzYdhWZ(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void TdbXBKRiYjzYdhWZ(android.os.Parcel parcel, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TdbXBKRiYjzYdhWZ(android.os.Parcel parcel, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TdbXBKRiYjzYdhWZ(android.os.Parcel parcel, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WQNJRPitimDbdRQW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return com.google.android.material.bottomsheet.BottomSheetBehavior.access$1900(bottomSheetBehavior);
    }

    public static void WQNJRPitimDbdRQW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WQNJRPitimDbdRQW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WQNJRPitimDbdRQW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkgVcTAYXHOsuMVu(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void YkgVcTAYXHOsuMVu(android.os.Parcel parcel, int i, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkgVcTAYXHOsuMVu(android.os.Parcel parcel, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YkgVcTAYXHOsuMVu(android.os.Parcel parcel, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        RBdxWrgonhbHyvnp(this, parcel, i);
        ZrMAccEOrwzmBGgY(parcel, this.state);
        eoQTBEgHdyzxPWzN(parcel, this.peekHeight);
        YmkuShqliwSxAotS(parcel, this.fitToContents ? 1 : 0);
        ykgVcTAYXHOsuMVu(parcel, this.hideable ? 1 : 0);
        ALEPBNsaPVWEqpRL(parcel, this.skipCollapsed ? 1 : 0);
    }
}

