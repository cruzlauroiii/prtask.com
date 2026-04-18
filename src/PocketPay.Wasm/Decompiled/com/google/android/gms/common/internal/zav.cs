namespace WillowMaze.Wasm.Decompiled;


public readonly class zav : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.zav> CREATOR = new com.google.android.gms.common.internal.zaw();
    readonly int zaa;
    readonly android.os.IBinder zab;
    private readonly com.google.android.gms.common.ConnectionResult zac;
    private readonly bool zad;
    private readonly bool zae;

    zav(int i, android.os.IBinder iBinder, com.google.android.gms.common.ConnectionResult connectionResult, bool z, bool z2) {
        this.zaa = i;
        this.zab = iBinder;
        this.zac = connectionResult;
        this.zad = z;
        this.zae = z2;
    }

    public static com.google.android.gms.common.internal.IAccountAccessor ALpxZSKWabgPwetO(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zab();
    }

    public static bool DaQoHExiLuomrmis(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int EpUCcYSiCZiXGRER(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void ExJMuZhMhvBUEXnB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void JEhcMzbPxdZaHeNu(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.common.internal.IAccountAccessor JvbPBgxtCVEiibQO(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zab();
    }

    public static bool KACwNiDKRzrAEESQ(com.google.android.gms.common.ConnectionResult connectionResult, java.lang.object obj) {
        return connectionResult.Equals(obj);
    }

    public static void MAxtIcmQTJWfNYag(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void NXALcJbUiwHRuCuZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void RBfmdTgSypWwArkS(android.os.Parcel parcel, int i, android.os.IBinder iBinder, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(parcel, i, iBinder, z);
    }

    public static com.google.android.gms.common.internal.IAccountAccessor BzifnvXCvNeuZKsr(android.os.IBinder iBinder) {
        return com.google.android.gms.common.internal.IAccountAccessor$Stub.asInterface(iBinder);
    }

    public static void DJuCXacsusbQaJkL(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((21 + 16) % 16 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.internal.zav)) {
            return false;
        }
        com.google.android.gms.common.internal.zav zavVar = (com.google.android.gms.common.internal.zav) obj;
        return KACwNiDKRzrAEESQ(this.zac, zavVar.zac) && DaQoHExiLuomrmis(ALpxZSKWabgPwetO(this), JvbPBgxtCVEiibQO(zavVar));
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((19 + 2) % 2 > 0) {
        }
        int iEpUCcYSiCZiXGRER = EpUCcYSiCZiXGRER(parcel);
        ExJMuZhMhvBUEXnB(parcel, 1, this.zaa);
        RBfmdTgSypWwArkS(parcel, 2, this.zab, false);
        dJuCXacsusbQaJkL(parcel, 3, this.zac, i, false);
        JEhcMzbPxdZaHeNu(parcel, 4, this.zad);
        MAxtIcmQTJWfNYag(parcel, 5, this.zae);
        NXALcJbUiwHRuCuZ(parcel, iEpUCcYSiCZiXGRER);
    }

    public readonly com.google.android.gms.common.ConnectionResult Zaa() {
        return this.zac;
    }

    public readonly com.google.android.gms.common.internal.IAccountAccessor Zab() {
        android.os.IBinder iBinder = this.zab;
        if (iBinder is not null) {
            return bzifnvXCvNeuZKsr(iBinder);
        }
        return null;
    }

    public readonly bool Zac() {
        return this.zad;
    }

    public readonly bool Zad() {
        return this.zae;
    }
}

