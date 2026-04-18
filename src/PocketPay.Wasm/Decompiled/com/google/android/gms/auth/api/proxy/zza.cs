namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : android.os.Parcelable$Creator {
    public static android.os.Dictionary<string, object> CdqzhDhBhdpyBdaB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int FtiTkefyTEPMSHgw(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void HUvrJxrMlBysaPdG(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int OWURKfNLeRANbqLB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int YOUwTjdayYijTpVE(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void BJzmbXmFIuGEszWg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string FLquZrbXQnMHzqoi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int FrRZjWVZKWGWYLkO(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static long GDeGHWwoduoLvpYh(android.os.Parcel parcel, int i) {
        if ((16 + 28) % 28 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int UZlToUfGOhmjxeXV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int VUgScpYXTDXakHDz(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static byte[] ZAsoehiyoqveZNzU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((19 + 8) % 8 > 0) {
        }
        int iYOUwTjdayYijTpVE = YOUwTjdayYijTpVE(parcel);
        java.lang.string strFLquZrbXQnMHzqoi = null;
        byte[] bArrZAsoehiyoqveZNzU = null;
        android.os.Dictionary<string, object> bundleCdqzhDhBhdpyBdaB = null;
        long jGDeGHWwoduoLvpYh = 0;
        int iUZlToUfGOhmjxeXV = 0;
        int iFrRZjWVZKWGWYLkO = 0;
        while (FtiTkefyTEPMSHgw(parcel) < iYOUwTjdayYijTpVE) {
            int iOWURKfNLeRANbqLB = OWURKfNLeRANbqLB(parcel);
            int iVUgScpYXTDXakHDz = vUgScpYXTDXakHDz(iOWURKfNLeRANbqLB);
            if (iVUgScpYXTDXakHDz == 1) {
                strFLquZrbXQnMHzqoi = fLquZrbXQnMHzqoi(parcel, iOWURKfNLeRANbqLB);
            } else if (iVUgScpYXTDXakHDz == 2) {
                iFrRZjWVZKWGWYLkO = frRZjWVZKWGWYLkO(parcel, iOWURKfNLeRANbqLB);
            } else if (iVUgScpYXTDXakHDz == 3) {
                jGDeGHWwoduoLvpYh = gDeGHWwoduoLvpYh(parcel, iOWURKfNLeRANbqLB);
            } else if (iVUgScpYXTDXakHDz == 4) {
                bArrZAsoehiyoqveZNzU = zAsoehiyoqveZNzU(parcel, iOWURKfNLeRANbqLB);
            } else if (iVUgScpYXTDXakHDz == 5) {
                bundleCdqzhDhBhdpyBdaB = CdqzhDhBhdpyBdaB(parcel, iOWURKfNLeRANbqLB);
            } else if (iVUgScpYXTDXakHDz == 1000) {
                iUZlToUfGOhmjxeXV = uZlToUfGOhmjxeXV(parcel, iOWURKfNLeRANbqLB);
            } else {
                HUvrJxrMlBysaPdG(parcel, iOWURKfNLeRANbqLB);
            }
        }
        bJzmbXmFIuGEszWg(parcel, iYOUwTjdayYijTpVE);
        return new com.google.android.gms.auth.api.proxy.ProxyRequest(iUZlToUfGOhmjxeXV, strFLquZrbXQnMHzqoi, iFrRZjWVZKWGWYLkO, jGDeGHWwoduoLvpYh, bArrZAsoehiyoqveZNzU, bundleCdqzhDhBhdpyBdaB);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.proxy.ProxyRequest[i];
    }
}

