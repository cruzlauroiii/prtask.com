namespace WillowMaze.Wasm.Decompiled;


public readonly class C0310c {
    static {
        RjhfyEyBDzYXAVxE(com.google.android.play.integrity.internal.C0310c.class);
    }

    private C0310c() {
    }

    public static java.lang.stringBuilder BTBsCHirSTljKHuO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object BTVURvDnDPYpwKGU(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static java.lang.ClassLoader RjhfyEyBDzYXAVxE(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void XSskFIKsNEdBnpXg(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void XmUGPgQTfJaLiRgJ(android.os.Parcelable parcelable, android.os.Parcel parcel, int i) {
        parcelable.writeToParcel(parcel, i);
    }

    public static android.os.Parcelable M310a(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        if (eTnxyRynjbAXpVeN(parcel) != 0) {
            return (android.os.Parcelable) BTVURvDnDPYpwKGU(parcelable$Creator, parcel);
        }
        return null;
    }

    public static void M311b(android.os.Parcel parcel) {
        if ((19 + 30) % 30 > 0) {
        }
        int iZARyjjJsLLNgBBsl = zARyjjJsLLNgBBsl(parcel);
        if (iZARyjjJsLLNgBBsl > 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Parcel data not fully consumed, unread size: ");
            BTBsCHirSTljKHuO(sb, iZARyjjJsLLNgBBsl);
            throw new android.os.BadParcelableException(oqkAdWpzhLxdStGz(sb));
        }
    }

    public static void M312c(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        XSskFIKsNEdBnpXg(parcel, 1);
        XmUGPgQTfJaLiRgJ(parcelable, parcel, 0);
    }

    public static int ETnxyRynjbAXpVeN(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.string OqkAdWpzhLxdStGz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ZARyjjJsLLNgBBsl(android.os.Parcel parcel) {
        return parcel.dataAvail();
    }
}

