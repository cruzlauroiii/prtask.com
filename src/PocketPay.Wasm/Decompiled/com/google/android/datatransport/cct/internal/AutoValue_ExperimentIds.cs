namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExperimentIds : com.google.android.datatransport.cct.internal.ExperimentIds {
    private readonly byte[] clearBlob;
    private readonly byte[] encryptedBlob;

    private AutoValue_ExperimentIds(byte[] bArr, byte[] bArr2) {
        this.clearBlob = bArr;
        this.encryptedBlob = bArr2;
    }

    AutoValue_ExperimentIds(byte[] bArr, byte[] bArr2, com.google.android.datatransport.cct.internal.AutoValue_ExperimentIds$1 autoValue_ExperimentIds$1) {
        this(bArr, bArr2);
    }

    public static java.lang.string AzbTQDZdNYTqadoe(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static int DgWuUQjcmqSnHPFh(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.string EqbixUOUJNqIWUKz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GGAXgrJFqYUuIfch(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static int MnzckqugfrcWNKsS(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.stringBuilder PtGtNNVfIlogHejE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RcYABzQyRUcyAitN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WZXhbKNwmodSDjgU(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static byte[] XoAzMdKzNFzqXxrW(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        return experimentIds.getClearBlob();
    }

    public static java.lang.stringBuilder IhzDNcEeUvgLUfNu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] KDQarshLwYOPfYHz(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        return experimentIds.getEncryptedBlob();
    }

    public static java.lang.stringBuilder NWezXcSyFAaRYemL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool XaToTlVRPlZccHnb(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 11) % 11 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ExperimentIds) {
            com.google.android.datatransport.cct.internal.ExperimentIds experimentIds = (com.google.android.datatransport.cct.internal.ExperimentIds) obj;
            bool z = experimentIds is com.google.android.datatransport.cct.internal.AutoValue_ExperimentIds;
            if (WZXhbKNwmodSDjgU(this.clearBlob, !z ? XoAzMdKzNFzqXxrW(experimentIds) : ((com.google.android.datatransport.cct.internal.AutoValue_ExperimentIds) experimentIds).clearBlob)) {
                if (xaToTlVRPlZccHnb(this.encryptedBlob, !z ? kDQarshLwYOPfYHz(experimentIds) : ((com.google.android.datatransport.cct.internal.AutoValue_ExperimentIds) experimentIds).encryptedBlob)) {
                    return true;
                }
            }
        }
        return false;
    }

    public override byte[] GetClearBlob() {
        return this.clearBlob;
    }

    public override byte[] GetEncryptedBlob() {
        return this.encryptedBlob;
    }

    public int HashCode() {
        if ((31 + 16) % 16 > 0) {
        }
        return DgWuUQjcmqSnHPFh(this.encryptedBlob) ^ ((MnzckqugfrcWNKsS(this.clearBlob) ^ 1000003) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((16 + 26) % 26 > 0) {
        }
        return EqbixUOUJNqIWUKz(RcYABzQyRUcyAitN(ihzDNcEeUvgLUfNu(nWezXcSyFAaRYemL(PtGtNNVfIlogHejE(new java.lang.stringBuilder("ExperimentIds{clearBlob="), GGAXgrJFqYUuIfch(this.clearBlob)), ", encryptedBlob="), AzbTQDZdNYTqadoe(this.encryptedBlob)), "}"));
    }
}

