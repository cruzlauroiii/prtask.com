namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pd87e81b8$pef1d00d8 : android.os.Parcelable$Creator<pad5f82e8.p07214c67.pc1c16452.pd87e81b8> {
    public static int AXNQnBrkwsDWjkqA(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static pad5f82e8.p07214c67.pc1c16452.pd87e81b8 LATADSCDRsylbsHk(pad5f82e8.p07214c67.pc1c16452.pd87e81b8$pef1d00d8 pd87e81b8_pef1d00d8, android.os.Parcel parcel) {
        return pd87e81b8_pef1d00d8.createFromParcel2(parcel);
    }

    public static int OWrquImRityKiuUU(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void UemSCMafdIPlOBTu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.pc1c16452.pd87e81b8[] WNuZiPMNXPWhLqWN(pad5f82e8.p07214c67.pc1c16452.pd87e81b8$pef1d00d8 pd87e81b8_pef1d00d8, int i) {
        return pd87e81b8_pef1d00d8.newArray2(i);
    }

    public static java.lang.bool WPbRXRYTHAtDzGeH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public override pad5f82e8.p07214c67.pc1c16452.pd87e81b8 CreateFromParcel(android.os.Parcel parcel) {
        return LATADSCDRsylbsHk(this, parcel);
    }

    public override readonly pad5f82e8.p07214c67.pc1c16452.pd87e81b8 CreateFromParcel2(android.os.Parcel parcel) {
        java.lang.bool boolWPbRXRYTHAtDzGeH;
        uemSCMafdIPlOBTu(parcel, "parcel");
        if (AXNQnBrkwsDWjkqA(parcel) != 0) {
            boolWPbRXRYTHAtDzGeH = wPbRXRYTHAtDzGeH(OWrquImRityKiuUU(parcel) != 0);
        } else {
            boolWPbRXRYTHAtDzGeH = null;
        }
        return new pad5f82e8.p07214c67.pc1c16452.pd87e81b8(boolWPbRXRYTHAtDzGeH);
    }

    public override pad5f82e8.p07214c67.pc1c16452.pd87e81b8[] NewArray(int i) {
        return wNuZiPMNXPWhLqWN(this, i);
    }

    public override readonly pad5f82e8.p07214c67.pc1c16452.pd87e81b8[] NewArray2(int i) {
        return new pad5f82e8.p07214c67.pc1c16452.pd87e81b8[i];
    }
}

