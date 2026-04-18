namespace WillowMaze.Wasm.Decompiled;


class Searchobject$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.appcompat.widget.Searchobject$SavedState> CREATOR = new androidx.appcompat.widget.Searchobject$SavedState$1();
    bool isIconified;

    public Searchobject$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.isIconified = GlTNxolggDFWrbxO((java.lang.bool) ACbboTuXLFYLPIit(parcel, null));
    }

    Searchobject$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static java.lang.object ACbboTuXLFYLPIit(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readValue(classLoader);
    }

    public static void ATSQOcBYTdqsdFqJ(android.os.Parcel parcel, java.lang.object obj) {
        parcel.writeValue(obj);
    }

    public static java.lang.stringBuilder DYhMNcVLuCtDFsur(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.string DyqPfxMpoqJxEfHG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool GlTNxolggDFWrbxO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder LRWTTQFPUtrkuzOC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TEZGVXMliyvBIXBR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YZNbNPqCoCiGHySJ(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static int DSiLivzhogttPLab(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.bool DkQVLaZdZhUuYrED(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder VMKNBRQKFmyJsgwK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZoBLpMtWfBFZNnOV(int i) {
        return java.lang.int.toHexstring(i);
    }

    public java.lang.string Tostring() {
        if ((10 + 25) % 25 > 0) {
        }
        return DyqPfxMpoqJxEfHG(vMKNBRQKFmyJsgwK(DYhMNcVLuCtDFsur(LRWTTQFPUtrkuzOC(TEZGVXMliyvBIXBR(new java.lang.stringBuilder("Searchobject.SavedState{"), zoBLpMtWfBFZNnOV(dSiLivzhogttPLab(this))), " isIconified="), this.isIconified), "}"));
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        YZNbNPqCoCiGHySJ(this, parcel, i);
        ATSQOcBYTdqsdFqJ(parcel, dkQVLaZdZhUuYrED(this.isIconified));
    }
}

