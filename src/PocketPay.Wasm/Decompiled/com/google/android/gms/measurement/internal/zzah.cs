namespace WillowMaze.Wasm.Decompiled;


public readonly class zzah : android.os.Parcelable$Creator {
    public static int CIpEslNKQCbtgxzG(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int OuEADdNfJLTlDkVi(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static long QaQKlpnlCDorBURm(android.os.Parcel parcel, int i) {
        if ((22 + 31) % 31 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int KzEjerfKSyGXZyOf(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int MKecKSYrSgEKblsX(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void QVcYlppHXeAGoBuo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void QwhqwwGkHZmfePJZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static long RhpFqUoWqcXuSalq(android.os.Parcel parcel, int i) {
        if ((29 + 18) % 18 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int YkfeNQDviigCbaVv(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((9 + 6) % 6 > 0) {
        }
        int iOuEADdNfJLTlDkVi = OuEADdNfJLTlDkVi(parcel);
        long jRhpFqUoWqcXuSalq = 0;
        long jQaQKlpnlCDorBURm = 0;
        int iYkfeNQDviigCbaVv = 0;
        while (CIpEslNKQCbtgxzG(parcel) < iOuEADdNfJLTlDkVi) {
            int iKzEjerfKSyGXZyOf = kzEjerfKSyGXZyOf(parcel);
            int iMKecKSYrSgEKblsX = mKecKSYrSgEKblsX(iKzEjerfKSyGXZyOf);
            if (iMKecKSYrSgEKblsX == 1) {
                jRhpFqUoWqcXuSalq = rhpFqUoWqcXuSalq(parcel, iKzEjerfKSyGXZyOf);
            } else if (iMKecKSYrSgEKblsX == 2) {
                iYkfeNQDviigCbaVv = ykfeNQDviigCbaVv(parcel, iKzEjerfKSyGXZyOf);
            } else if (iMKecKSYrSgEKblsX == 3) {
                jQaQKlpnlCDorBURm = QaQKlpnlCDorBURm(parcel, iKzEjerfKSyGXZyOf);
            } else {
                qVcYlppHXeAGoBuo(parcel, iKzEjerfKSyGXZyOf);
            }
        }
        qwhqwwGkHZmfePJZ(parcel, iOuEADdNfJLTlDkVi);
        return new com.google.android.gms.measurement.internal.zzag(jRhpFqUoWqcXuSalq, iYkfeNQDviigCbaVv, jQaQKlpnlCDorBURm);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzag[i];
    }
}

