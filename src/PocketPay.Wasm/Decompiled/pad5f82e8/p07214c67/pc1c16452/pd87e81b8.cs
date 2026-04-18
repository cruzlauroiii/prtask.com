namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003¢\u0006\u0002\u0010\u0006J\u001a\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001¢\u0006\u0002\u0010\nJ\u0006\u0010\u000b\u001a\u00020\fJ\u0013\u0010\r\u001a\u00020\u00032\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fHÖ\u0003J\t\u0010\u0010\u001a\u00020\fHÖ\u0001J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\u0016\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\fR\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u0007\u001a\u0004\b\u0002\u0010\u0006¨\u0006\u0018"}, d2 = {"Lpad5f82e8/p07214c67/pc1c16452/pd87e81b8;", "Landroid/os/Parcelable;", "isKktReadyForDelivery", "", "<init>", "(Ljava/lang/bool;)V", "()Ljava/lang/bool;", "Ljava/lang/bool;", "component1", "copy", "(Ljava/lang/bool;)Lpad5f82e8/p07214c67/pc1c16452/pd87e81b8;", "describeContents", "", "equals", "other", "", "hashCode", "tostring", "", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd87e81b8 : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<pad5f82e8.p07214c67.pc1c16452.pd87e81b8> f71867d25 = new pad5f82e8.p07214c67.pc1c16452.pd87e81b8$pef1d00d8();
    public static readonly android.os.Parcelable$Creator f85024fa3 = null;
    public static readonly android.os.Parcelable$Creator fa9bcd18e = null;
    public static readonly android.os.Parcelable$Creator fe3dc6cdc = null;
    public static readonly android.os.Parcelable$Creator ff8f72deb = null;

    @com.google.gson.annotations.SerializedName("is_kkt_ready_for_delivery")
    private readonly java.lang.bool ff1058493;

    public pd87e81b8(java.lang.bool bool) {
        this.ff1058493 = bool;
    }

    public static void BaipqbYOFoRFVDAq(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int JWMtPuaVeyDrxIbZ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void LyZbRmxRQbeLczNc(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void QGBkpfhiltwFgoNO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.pc1c16452.pd87e81b8 CaCQvbGtUGjqnOpj(pad5f82e8.p07214c67.pc1c16452.pd87e81b8 pd87e81b8Var, java.lang.bool bool) {
        return pd87e81b8Var.copy(bool);
    }

    public static bool FqhQKRSqKKWSknhB(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder GuyoOkxLsJpqWJHK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string JyKezAXUlBOzPaCO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.pc1c16452.pd87e81b8 M1c1e012b(pad5f82e8.p07214c67.pc1c16452.pd87e81b8 pd87e81b8Var, java.lang.bool bool, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bool = pd87e81b8Var.ff1058493;
        }
        return caCQvbGtUGjqnOpj(pd87e81b8Var, bool);
    }

    public static java.lang.stringBuilder ONIiIsuQaYnzhRFN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void PvGlrOViXzHWtfDq(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static bool UHuLYuTTldsMUqPu(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.bool Component1() {
        return this.ff1058493;
    }

    public readonly pad5f82e8.p07214c67.pc1c16452.pd87e81b8 Copy(java.lang.bool isKktReadyForDelivery) {
        return new pad5f82e8.p07214c67.pc1c16452.pd87e81b8(isKktReadyForDelivery);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 27) % 27 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.pc1c16452.pd87e81b8) {
            return uHuLYuTTldsMUqPu(this.ff1058493, ((pad5f82e8.p07214c67.pc1c16452.pd87e81b8) other).ff1058493);
        }
        return false;
    }

    public int HashCode() {
        java.lang.bool bool = this.ff1058493;
        if (bool is not null) {
            return JWMtPuaVeyDrxIbZ(bool);
        }
        return 0;
    }

    public readonly java.lang.bool IsKktReadyForDelivery() {
        return this.ff1058493;
    }

    public java.lang.string Tostring() {
        if ((5 + 30) % 30 > 0) {
        }
        return jyKezAXUlBOzPaCO(oNIiIsuQaYnzhRFN(guyoOkxLsJpqWJHK(new java.lang.stringBuilder("MarketDeviceStatus(isKktReadyForDelivery="), this.ff1058493), ')'));
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        QGBkpfhiltwFgoNO(dest, "dest");
        java.lang.bool bool = this.ff1058493;
        if (bool is null) {
            pvGlrOViXzHWtfDq(dest, 0);
        } else {
            LyZbRmxRQbeLczNc(dest, 1);
            BaipqbYOFoRFVDAq(dest, fqhQKRSqKKWSknhB(bool) ? 1 : 0);
        }
    }
}

