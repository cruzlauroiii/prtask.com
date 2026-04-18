namespace WillowMaze.Wasm.Decompiled;


public readonly class zzn : android.os.Parcelable$Creator {
    public static int KiGsLDSBsepJVUaX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int NzWjgZJnICDbNUoE(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int UVGflyzeghPchuDw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool CzJRdlPPjtBVgRQQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void MILrTimpMMIgngbN(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int QgUElcXclbEcrtGB(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static long RYlyWrBTlDUZovFG(android.os.Parcel parcel, int i) {
        if ((11 + 12) % 12 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void XinckWDuKWGtDhCt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((5 + 3) % 3 > 0) {
        }
        int iKiGsLDSBsepJVUaX = KiGsLDSBsepJVUaX(parcel);
        bool zCzJRdlPPjtBVgRQQ = false;
        long jRYlyWrBTlDUZovFG = 0;
        while (qgUElcXclbEcrtGB(parcel) < iKiGsLDSBsepJVUaX) {
            int iUVGflyzeghPchuDw = UVGflyzeghPchuDw(parcel);
            int iNzWjgZJnICDbNUoE = NzWjgZJnICDbNUoE(iUVGflyzeghPchuDw);
            if (iNzWjgZJnICDbNUoE == 2) {
                jRYlyWrBTlDUZovFG = rYlyWrBTlDUZovFG(parcel, iUVGflyzeghPchuDw);
            } else if (iNzWjgZJnICDbNUoE == 6) {
                zCzJRdlPPjtBVgRQQ = czJRdlPPjtBVgRQQ(parcel, iUVGflyzeghPchuDw);
            } else {
                xinckWDuKWGtDhCt(parcel, iUVGflyzeghPchuDw);
            }
        }
        mILrTimpMMIgngbN(parcel, iKiGsLDSBsepJVUaX);
        return new com.google.android.gms.location.DeviceOrientationRequest(jRYlyWrBTlDUZovFG, zCzJRdlPPjtBVgRQQ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.DeviceOrientationRequest[i];
    }
}

