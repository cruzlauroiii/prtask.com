namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : android.os.Parcelable$Creator {
    public static int LgkFFdCZFAwgJtcd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int LwnbydWKJVswrpLP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int SrAfNXkwFMPlIiWp(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int BGhofahFiyMOEvDZ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int CgBigDWnLcMxuslu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string DHRWcfnouYlcnerC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void LpaySCUHXADOrifp(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int OzUyESiOqlbwLgtQ(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void SeaFiXEGicFWyAcP(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((3 + 14) % 14 > 0) {
        }
        int iSrAfNXkwFMPlIiWp = SrAfNXkwFMPlIiWp(parcel);
        int iCgBigDWnLcMxuslu = 0;
        java.lang.string strDHRWcfnouYlcnerC = null;
        int iLwnbydWKJVswrpLP = 0;
        while (bGhofahFiyMOEvDZ(parcel) < iSrAfNXkwFMPlIiWp) {
            int iLgkFFdCZFAwgJtcd = LgkFFdCZFAwgJtcd(parcel);
            int iOzUyESiOqlbwLgtQ = ozUyESiOqlbwLgtQ(iLgkFFdCZFAwgJtcd);
            if (iOzUyESiOqlbwLgtQ == 1) {
                iCgBigDWnLcMxuslu = cgBigDWnLcMxuslu(parcel, iLgkFFdCZFAwgJtcd);
            } else if (iOzUyESiOqlbwLgtQ == 2) {
                strDHRWcfnouYlcnerC = dHRWcfnouYlcnerC(parcel, iLgkFFdCZFAwgJtcd);
            } else if (iOzUyESiOqlbwLgtQ == 3) {
                iLwnbydWKJVswrpLP = LwnbydWKJVswrpLP(parcel, iLgkFFdCZFAwgJtcd);
            } else {
                lpaySCUHXADOrifp(parcel, iLgkFFdCZFAwgJtcd);
            }
        }
        seaFiXEGicFWyAcP(parcel, iSrAfNXkwFMPlIiWp);
        return new com.google.android.gms.common.server.FavaDiagnosticsEntity(iCgBigDWnLcMxuslu, strDHRWcfnouYlcnerC, iLwnbydWKJVswrpLP);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.FavaDiagnosticsEntity[i];
    }
}

