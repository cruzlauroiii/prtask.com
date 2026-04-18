namespace WillowMaze.Wasm.Decompiled;


public readonly class zzt : android.os.Parcelable$Creator {
    public static java.lang.string BJntwuMIrMCauuax(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static android.os.IBinder EujOjMeNLsnCvnIH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readIBinder(parcel, i);
    }

    public static int FSoZoMfRgtkffNrU(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void JbSFgwPlktTQfCIf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int VDUcWKsPmOiBapkX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Parcelable YuujUxGDqyxkzSmW(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static bool CwZrvZemPsLdpIXV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static bool GNlZWAopGQBnxLLB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int HKzPnaZbpGBgLoYq(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool RDbUItbZgvUsbcph(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static bool UkAHVcUSWAbZuJhr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void VAHQEeKrZHzaPjXC(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int ZWxqzPsRthxXNlba(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((23 + 23) % 23 > 0) {
        }
        int iVDUcWKsPmOiBapkX = VDUcWKsPmOiBapkX(parcel);
        java.lang.string strBJntwuMIrMCauuax = null;
        android.os.IBinder iBinderEujOjMeNLsnCvnIH = null;
        com.google.android.gms.common.zzr zzrVar = null;
        bool zRDbUItbZgvUsbcph = false;
        bool zCwZrvZemPsLdpIXV = false;
        bool zUkAHVcUSWAbZuJhr = false;
        bool zGNlZWAopGQBnxLLB = false;
        while (FSoZoMfRgtkffNrU(parcel) < iVDUcWKsPmOiBapkX) {
            int iZWxqzPsRthxXNlba = zWxqzPsRthxXNlba(parcel);
            switch (hKzPnaZbpGBgLoYq(iZWxqzPsRthxXNlba)) {
                case 1:
                    strBJntwuMIrMCauuax = BJntwuMIrMCauuax(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 2:
                    zRDbUItbZgvUsbcph = rDbUItbZgvUsbcph(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 3:
                    zCwZrvZemPsLdpIXV = cwZrvZemPsLdpIXV(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 4:
                    iBinderEujOjMeNLsnCvnIH = EujOjMeNLsnCvnIH(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 5:
                    zUkAHVcUSWAbZuJhr = ukAHVcUSWAbZuJhr(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 6:
                    zGNlZWAopGQBnxLLB = gNlZWAopGQBnxLLB(parcel, iZWxqzPsRthxXNlba);
                    break;
                case 7:
                    zzrVar = (com.google.android.gms.common.zzr) YuujUxGDqyxkzSmW(parcel, iZWxqzPsRthxXNlba, com.google.android.gms.common.zzr.CREATOR);
                    break;
                default:
                    JbSFgwPlktTQfCIf(parcel, iZWxqzPsRthxXNlba);
                    break;
            }
        }
        vAHQEeKrZHzaPjXC(parcel, iVDUcWKsPmOiBapkX);
        return new com.google.android.gms.common.zzs(strBJntwuMIrMCauuax, zRDbUItbZgvUsbcph, zCwZrvZemPsLdpIXV, iBinderEujOjMeNLsnCvnIH, zUkAHVcUSWAbZuJhr, zGNlZWAopGQBnxLLB, zzrVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.zzs[i];
    }
}

