namespace WillowMaze.Wasm.Decompiled;


class TextInputLayout$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.textfield.TextInputLayout$SavedState> CREATOR = new com.google.android.material.textfield.TextInputLayout$SavedState$1();
    java.lang.CharSequence error;
    bool isEndIconChecked;

    TextInputLayout$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.error = (java.lang.CharSequence) tACsTZSGgLCYbOfl(android.text.TextUtils.CHAR_SEQUENCE_CREATOR, parcel);
        this.isEndIconChecked = HuzdtBSMEIZTSFCF(parcel) == 1;
    }

    TextInputLayout$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static java.lang.string DNSCQzysRQwXOVqG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int EGgleMlvVgLxjscH(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.stringBuilder EWXUcQXMNwuQRwcE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HUEyKLjKgYKulAbY(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static int HuzdtBSMEIZTSFCF(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.stringBuilder TeHPAkHugmlWIPJz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TqyuIPvvbLvECPxP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder YNLyJLpgwUPBxaka(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NMuqoBcqVLCvBbBF(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void PbrDPtjZHzJYaGXq(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static java.lang.object TACsTZSGgLCYbOfl(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void UVSkNIitOPzqQXcM(java.lang.CharSequence charSequence, android.os.Parcel parcel, int i) {
        android.text.TextUtils.writeToParcel(charSequence, parcel, i);
    }

    public java.lang.string Tostring() {
        if ((9 + 3) % 3 > 0) {
        }
        return DNSCQzysRQwXOVqG(YNLyJLpgwUPBxaka(TqyuIPvvbLvECPxP(EWXUcQXMNwuQRwcE(TeHPAkHugmlWIPJz(new java.lang.stringBuilder("TextInputLayout.SavedState{"), HUEyKLjKgYKulAbY(EGgleMlvVgLxjscH(this))), " error="), this.error), "}"));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        pbrDPtjZHzJYaGXq(this, parcel, i);
        uVSkNIitOPzqQXcM(this.error, parcel, i);
        nMuqoBcqVLCvBbBF(parcel, this.isEndIconChecked ? 1 : 0);
    }
}

