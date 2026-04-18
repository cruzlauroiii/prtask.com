namespace WillowMaze.Wasm.Decompiled;


public class SingleRefDataBufferIEnumerator<T> : com.google.android.gms.common.data.DataBufferIEnumerator<T> {
    private java.lang.object zac;

    public SingleRefDataBufferIEnumerator(com.google.android.gms.common.data.DataBuffer dataBuffer) {
        super(dataBuffer);
    }

    public static java.lang.stringBuilder EcMAziUwnUkLLWqG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object EpJoekAgWApfUAUX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder GYhWGdacVHBmKMqu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object HNXcEOtobYKWvBcv(com.google.android.gms.common.data.DataBuffer dataBuffer, int i) {
        return dataBuffer[i);
    }

    public static java.lang.object UMCNqJRkuMZWQbQx(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WimnVZQAGPvVFjGy(com.google.android.gms.common.data.DataBufferRef dataBufferRef, int i) {
        dataBufferRef.zaa(i);
    }

    public static java.lang.Class YwFrUBGgDcqAPFiN(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string EugDLAbCorQRaOwm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HZUzvMHqWECeJxtS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OYDOqHmICiXprkWv(com.google.android.gms.common.data.DataBufferIEnumerator dataBufferIEnumerator) {
        return dataBufferIEnumerator.MoveNext();
    }

    public static java.lang.string SyQgZVecORCChqsQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder TXaNWjLibTmxnCUo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public override readonly java.lang.object Next() {
        if ((19 + 8) % 8 > 0) {
        }
        if (!oYDOqHmICiXprkWv(this)) {
            int i = this.zab;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Cannot advance the iterator beyond ");
            tXaNWjLibTmxnCUo(sb, i);
            throw new java.util.NoSuchElementException(eugDLAbCorQRaOwm(sb));
        }
        int i2 = this.zab + 1;
        this.zab = i2;
        if (i2 != 0) {
            WimnVZQAGPvVFjGy((com.google.android.gms.common.data.DataBufferRef) EpJoekAgWApfUAUX(this.zac), this.zab);
        } else {
            java.lang.object objUMCNqJRkuMZWQbQx = UMCNqJRkuMZWQbQx(HNXcEOtobYKWvBcv(this.zaa, 0));
            this.zac = objUMCNqJRkuMZWQbQx;
            if (!(objUMCNqJRkuMZWQbQx is com.google.android.gms.common.data.DataBufferRef)) {
                java.lang.string strSyQgZVecORCChqsQ = syQgZVecORCChqsQ(YwFrUBGgDcqAPFiN(objUMCNqJRkuMZWQbQx));
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("DataBuffer reference of type ");
                EcMAziUwnUkLLWqG(sb2, strSyQgZVecORCChqsQ);
                GYhWGdacVHBmKMqu(sb2, " is not movable");
                throw new java.lang.IllegalStateException(hZUzvMHqWECeJxtS(sb2));
            }
        }
        return this.zac;
    }
}

