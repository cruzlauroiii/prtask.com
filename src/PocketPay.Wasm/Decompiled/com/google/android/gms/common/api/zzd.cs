namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : android.os.Parcelable$Creator {
    public static int JProTpKtebySNYmE(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int AfJNgzYdPLTqTmTr(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void BMPlpQmeshvRfcoC(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int HklVVyRUZbCrzgNC(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string LLBxlrccbPmDXgAI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int NFtqoBdASsJTCOiM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void TVNutXBmXCFSXwvl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int XhwmbTmufeaDHIhm(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 31) % 31 > 0) {
        }
        int iXhwmbTmufeaDHIhm = xhwmbTmufeaDHIhm(parcel);
        java.lang.string strLLBxlrccbPmDXgAI = null;
        int iNFtqoBdASsJTCOiM = 0;
        while (afJNgzYdPLTqTmTr(parcel) < iXhwmbTmufeaDHIhm) {
            int iJProTpKtebySNYmE = JProTpKtebySNYmE(parcel);
            int iHklVVyRUZbCrzgNC = hklVVyRUZbCrzgNC(iJProTpKtebySNYmE);
            if (iHklVVyRUZbCrzgNC == 1) {
                iNFtqoBdASsJTCOiM = nFtqoBdASsJTCOiM(parcel, iJProTpKtebySNYmE);
            } else if (iHklVVyRUZbCrzgNC == 2) {
                strLLBxlrccbPmDXgAI = lLBxlrccbPmDXgAI(parcel, iJProTpKtebySNYmE);
            } else {
                tVNutXBmXCFSXwvl(parcel, iJProTpKtebySNYmE);
            }
        }
        bMPlpQmeshvRfcoC(parcel, iXhwmbTmufeaDHIhm);
        return new com.google.android.gms.common.api.Scope(iNFtqoBdASsJTCOiM, strLLBxlrccbPmDXgAI);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.api.Scope[i];
    }
}

