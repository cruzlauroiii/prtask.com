namespace WillowMaze.Wasm.Decompiled;


public readonly class zzm : android.os.Parcelable$Creator {
    public static int BKHyaMWsHGYovnIb(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static bool ByeKPmzGodpdhoqj(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Parcelable IwOMHwCNBgYHsJwK(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int PPdkDaFcIQwRkHHa(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void REwSYKwGgGpTKOFV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool TqOQRAvHTUsquHzw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int YlbblFhvynNEHeTn(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int[] BXsoCPqMsiVumJeY(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createIntArray(parcel, i);
    }

    public static int RFPdZyNvZiIeVGJX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int[] TukYgzfNedCPEsIS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createIntArray(parcel, i);
    }

    public static int ULWRNLAipDRVpQot(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void UPqxhKgSJzxouoQL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((28 + 13) % 13 > 0) {
        }
        int iRFPdZyNvZiIeVGJX = rFPdZyNvZiIeVGJX(parcel);
        com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration = null;
        int[] iArrBXsoCPqMsiVumJeY = null;
        int[] iArrTukYgzfNedCPEsIS = null;
        bool zTqOQRAvHTUsquHzw = false;
        bool zByeKPmzGodpdhoqj = false;
        int iBKHyaMWsHGYovnIb = 0;
        while (PPdkDaFcIQwRkHHa(parcel) < iRFPdZyNvZiIeVGJX) {
            int iYlbblFhvynNEHeTn = YlbblFhvynNEHeTn(parcel);
            switch (uLWRNLAipDRVpQot(iYlbblFhvynNEHeTn)) {
                case 1:
                    rootTelemetryConfiguration = (com.google.android.gms.common.internal.RootTelemetryConfiguration) IwOMHwCNBgYHsJwK(parcel, iYlbblFhvynNEHeTn, com.google.android.gms.common.internal.RootTelemetryConfiguration.CREATOR);
                    break;
                case 2:
                    zTqOQRAvHTUsquHzw = TqOQRAvHTUsquHzw(parcel, iYlbblFhvynNEHeTn);
                    break;
                case 3:
                    zByeKPmzGodpdhoqj = ByeKPmzGodpdhoqj(parcel, iYlbblFhvynNEHeTn);
                    break;
                case 4:
                    iArrBXsoCPqMsiVumJeY = bXsoCPqMsiVumJeY(parcel, iYlbblFhvynNEHeTn);
                    break;
                case 5:
                    iBKHyaMWsHGYovnIb = BKHyaMWsHGYovnIb(parcel, iYlbblFhvynNEHeTn);
                    break;
                case 6:
                    iArrTukYgzfNedCPEsIS = tukYgzfNedCPEsIS(parcel, iYlbblFhvynNEHeTn);
                    break;
                default:
                    uPqxhKgSJzxouoQL(parcel, iYlbblFhvynNEHeTn);
                    break;
            }
        }
        REwSYKwGgGpTKOFV(parcel, iRFPdZyNvZiIeVGJX);
        return new com.google.android.gms.common.internal.ConnectionTelemetryConfiguration(rootTelemetryConfiguration, zTqOQRAvHTUsquHzw, zByeKPmzGodpdhoqj, iArrBXsoCPqMsiVumJeY, iBKHyaMWsHGYovnIb, iArrTukYgzfNedCPEsIS);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.ConnectionTelemetryConfiguration[i];
    }
}

