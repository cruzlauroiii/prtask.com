namespace WillowMaze.Wasm.Decompiled;


public readonly class zzi : android.os.Parcelable$Creator {
    public static int MeedgPNSSccdCbvF(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void QgNDWjGYByaQLaca(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int RRVuJPPYKqFEGjqJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int BpdJJXyLDEiXzRYx(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.util.List FBqDFRWJzxwSjNeQ(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static void VBdTgrIFmQxktYGh(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Dictionary<string, object> VycQatQWaqDOfOPE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int YBvTcfdyhsyOpyDb(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((28 + 29) % 29 > 0) {
        }
        int iMeedgPNSSccdCbvF = MeedgPNSSccdCbvF(parcel);
        java.util.List arrayListFBqDFRWJzxwSjNeQ = null;
        android.os.Dictionary<string, object> bundleVycQatQWaqDOfOPE = null;
        while (yBvTcfdyhsyOpyDb(parcel) < iMeedgPNSSccdCbvF) {
            int iRRVuJPPYKqFEGjqJ = RRVuJPPYKqFEGjqJ(parcel);
            int iBpdJJXyLDEiXzRYx = bpdJJXyLDEiXzRYx(iRRVuJPPYKqFEGjqJ);
            if (iBpdJJXyLDEiXzRYx == 1) {
                arrayListFBqDFRWJzxwSjNeQ = fBqDFRWJzxwSjNeQ(parcel, iRRVuJPPYKqFEGjqJ, com.google.android.gms.location.objectTransitionEvent.CREATOR);
            } else if (iBpdJJXyLDEiXzRYx == 2) {
                bundleVycQatQWaqDOfOPE = vycQatQWaqDOfOPE(parcel, iRRVuJPPYKqFEGjqJ);
            } else {
                QgNDWjGYByaQLaca(parcel, iRRVuJPPYKqFEGjqJ);
            }
        }
        vBdTgrIFmQxktYGh(parcel, iMeedgPNSSccdCbvF);
        return new com.google.android.gms.location.objectTransitionResult(arrayListFBqDFRWJzxwSjNeQ, bundleVycQatQWaqDOfOPE);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.objectTransitionResult[i];
    }
}

