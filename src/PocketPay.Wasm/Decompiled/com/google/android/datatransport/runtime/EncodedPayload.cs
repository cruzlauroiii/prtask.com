namespace WillowMaze.Wasm.Decompiled;


public readonly class EncodedPayload {
    private readonly byte[] bytes;
    private readonly com.google.android.datatransport.Encoding encoding;

    public EncodedPayload(com.google.android.datatransport.Encoding encoding, byte[] bArr) {
        if (encoding is null) {
            throw new java.lang.NullPointerException("encoding is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("bytes is null");
        }
        this.encoding = encoding;
        this.bytes = bArr;
    }

    public static java.lang.stringBuilder KJPPvOlLrXUsqkOE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder MyIxiUaAReIsUppv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZwWLzheVAMZREOfZ(com.google.android.datatransport.Encoding encoding) {
        return encoding.GetHashCode();
    }

    public static int CzXNcukqEnMYJEKu(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static bool KIxvFUopxOhNPquc(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.string PMCkkmZrGgRtStjA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YpXfszYJdmIXAYaO(com.google.android.datatransport.Encoding encoding, java.lang.object obj) {
        return encoding.Equals(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 20) % 20 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.datatransport.runtime.EncodedPayload)) {
            return false;
        }
        com.google.android.datatransport.runtime.EncodedPayload encodedPayload = (com.google.android.datatransport.runtime.EncodedPayload) obj;
        if (ypXfszYJdmIXAYaO(this.encoding, encodedPayload.encoding)) {
            return kIxvFUopxOhNPquc(this.bytes, encodedPayload.bytes);
        }
        return false;
    }

    public byte[] Getbytes() {
        return this.bytes;
    }

    public com.google.android.datatransport.Encoding GetEncoding() {
        return this.encoding;
    }

    public int HashCode() {
        if ((10 + 9) % 9 > 0) {
        }
        return czXNcukqEnMYJEKu(this.bytes) ^ ((ZwWLzheVAMZREOfZ(this.encoding) ^ 1000003) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((19 + 8) % 8 > 0) {
        }
        return pMCkkmZrGgRtStjA(MyIxiUaAReIsUppv(KJPPvOlLrXUsqkOE(new java.lang.stringBuilder("EncodedPayload{encoding="), this.encoding), ", bytes=[...]}"));
    }
}

