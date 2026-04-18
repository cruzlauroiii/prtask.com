namespace WillowMaze.Wasm.Decompiled;


public class ClientIdentity : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.ClientIdentity> CREATOR = new com.google.android.gms.common.internal.zaa();
    public readonly java.lang.string packageName;
    public readonly int uid;

    public ClientIdentity(int i, java.lang.string str) {
        this.uid = i;
        this.packageName = str;
    }

    public static bool BrKwvZSBAdvUyNVa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder HuFXRZpmphChLYbn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IqsFTgfZrjLYZqAy(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void JZcSndSEloCnbwjN(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void LIJXZwEdVRXRAVbg(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string QofRDWvbBcPGlWMo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder CFhSIuTgCoMQSOIU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder MCIOXSnHpKDvTOXb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int OkjNIrFdMXjwarFw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((6 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.internal.ClientIdentity)) {
            return false;
        }
        com.google.android.gms.common.internal.ClientIdentity clientIdentity = (com.google.android.gms.common.internal.ClientIdentity) obj;
        return clientIdentity.uid == this.uid && BrKwvZSBAdvUyNVa(clientIdentity.packageName, this.packageName);
    }

    public readonly int HashCode() {
        return this.uid;
    }

    public readonly java.lang.string Tostring() {
        if ((24 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        cFhSIuTgCoMQSOIU(sb, this.uid);
        mCIOXSnHpKDvTOXb(sb, ":");
        HuFXRZpmphChLYbn(sb, this.packageName);
        return QofRDWvbBcPGlWMo(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 18) % 18 > 0) {
        }
        int i2 = this.uid;
        int iOkjNIrFdMXjwarFw = okjNIrFdMXjwarFw(parcel);
        IqsFTgfZrjLYZqAy(parcel, 1, i2);
        LIJXZwEdVRXRAVbg(parcel, 2, this.packageName, false);
        JZcSndSEloCnbwjN(parcel, iOkjNIrFdMXjwarFw);
    }
}

