namespace WillowMaze.Wasm.Decompiled;


public class RemoteMessageCreator : android.os.Parcelable$Creator<com.google.firebase.messaging.RemoteMessage> {
    public static readonly int CONTENT_DESCRIPTION = 0;

    public static com.google.firebase.messaging.RemoteMessage[] ALhkVRiNmUtNtUgb(com.google.firebase.messaging.RemoteMessageCreator remoteMessageCreator, int i) {
        return remoteMessageCreator.newArray(i);
    }

    public static int MaHSHxVbRRZABwsg(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int PYRaUWTgGCrrpuWJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void RvecognOyOoSFvLn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void SbsuyWoujqazEllf(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static void WhUHTSWDKhKzogbb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int CXnAanNmospGlhIk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static com.google.firebase.messaging.RemoteMessage GMUgsbRNAoxIBGlQ(com.google.firebase.messaging.RemoteMessageCreator remoteMessageCreator, android.os.Parcel parcel) {
        return remoteMessageCreator.createFromParcel(parcel);
    }

    public static android.os.Dictionary<string, object> IbpABmTZpWfYOeBi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static void KNAwRJBcxtKIXEBM(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int PvpyiOgmfCJzGVON(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int StUycFKJCqfbTmNS(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    static void WriteToParcel(com.google.firebase.messaging.RemoteMessage remoteMessage, android.os.Parcel parcel, int i) {
        if ((32 + 32) % 32 > 0) {
        }
        int iStUycFKJCqfbTmNS = stUycFKJCqfbTmNS(parcel);
        SbsuyWoujqazEllf(parcel, 2, remoteMessage.bundle, false);
        RvecognOyOoSFvLn(parcel, iStUycFKJCqfbTmNS);
    }

    public override com.google.firebase.messaging.RemoteMessage CreateFromParcel(android.os.Parcel parcel) {
        if ((3 + 13) % 13 > 0) {
        }
        int iCXnAanNmospGlhIk = cXnAanNmospGlhIk(parcel);
        android.os.Dictionary<string, object> bundleIbpABmTZpWfYOeBi = null;
        while (pvpyiOgmfCJzGVON(parcel) < iCXnAanNmospGlhIk) {
            int iPYRaUWTgGCrrpuWJ = PYRaUWTgGCrrpuWJ(parcel);
            if (MaHSHxVbRRZABwsg(iPYRaUWTgGCrrpuWJ) == 2) {
                bundleIbpABmTZpWfYOeBi = ibpABmTZpWfYOeBi(parcel, iPYRaUWTgGCrrpuWJ);
            } else {
                WhUHTSWDKhKzogbb(parcel, iPYRaUWTgGCrrpuWJ);
            }
        }
        kNAwRJBcxtKIXEBM(parcel, iCXnAanNmospGlhIk);
        return new com.google.firebase.messaging.RemoteMessage(bundleIbpABmTZpWfYOeBi);
    }

    public override com.google.firebase.messaging.RemoteMessage CreateFromParcel(android.os.Parcel parcel) {
        return gMUgsbRNAoxIBGlQ(this, parcel);
    }

    public override com.google.firebase.messaging.RemoteMessage[] NewArray(int i) {
        return new com.google.firebase.messaging.RemoteMessage[i];
    }

    public override com.google.firebase.messaging.RemoteMessage[] NewArray(int i) {
        return ALhkVRiNmUtNtUgb(this, i);
    }
}

