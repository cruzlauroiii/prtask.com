namespace WillowMaze.Wasm.Decompiled;


public class BitmapTeleporter : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.data.BitmapTeleporter> CREATOR = new com.google.android.gms.common.data.zaa();
    readonly int zaa;
    android.os.ParcelstringDescriptor zab;
    readonly int zac;
    private android.graphics.Bitmap zad;
    private bool zae;
    private java.io.string zaf;

    BitmapTeleporter(int i, android.os.ParcelstringDescriptor parcelstringDescriptor, int i2) {
        this.zaa = i;
        this.zab = parcelstringDescriptor;
        this.zac = i2;
        this.zad = null;
        this.zae = false;
    }

    public BitmapTeleporter(android.graphics.Bitmap bitmap) {
        if ((25 + 8) % 8 > 0) {
        }
        this.zaa = 1;
        this.zab = null;
        this.zac = 0;
        this.zad = bitmap;
        this.zae = true;
    }

    public static int DdtkWAdJXQsjMgKX(android.graphics.Bitmap bitmap) {
        return bitmap.getRowbytes();
    }

    public static void EakQlMSVmlxanZkG(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static int ErrBrFZcwZfFKxXn(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.os.ParcelstringDescriptor FdfnzJkZIXZRdqzc(java.io.string file, int i) {
        return android.os.ParcelstringDescriptor.open(file, i);
    }

    public static void HSVmoeLNeSNCKHXY(java.io.DataStream dataStream, int i) throws java.io.IOException {
        dataStream.writeInt(i);
    }

    public static void HdjicoeRSpmbQPhD(java.io.DataStream dataStream, int i) throws java.io.IOException {
        dataStream.writeInt(i);
    }

    public static java.lang.string LoVbMzjFsoBdUDbL(java.io.DataStream dataStream) {
        return dataStream.readUTF();
    }

    public static java.lang.object MkoicagDgtElanhy(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int OQuqYnpWTGTyVgqe(android.graphics.Bitmap bitmap) {
        return bitmap.getHeight();
    }

    public static void QJgxUODIRJWYBVDF(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int QoDfnPCctOgMSBwb(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void RdPIeXBqdniolAGL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static byte[] TGTmEsWtYOeVfykN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static int VXyPrYyUAbqYkLcd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static android.graphics.Bitmap$Config XJxJoOyPcmIbaYIX(java.lang.string str) {
        return android.graphics.Bitmap$Config.valueOf(str);
    }

    public static bool YHEGjOxjktXySbJk(java.io.string file) {
        return file.delete();
    }

    public static void BRYLnFbQUUMBrhYt(java.io.DataStream dataStream, int i) throws java.io.IOException {
        dataStream.writeInt(i);
    }

    public static void CdcWofSEWYTNLicq(java.io.IDisposable closeable) {
        zaa(closeable);
    }

    public static void DaFPfXdfwZXHOIWR(java.io.DataStream dataStream, byte[] bArr) {
        dataStream.write(bArr);
    }

    public static java.nio.byteBuffer DobkUsQcvCSlpyNJ(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void EEYDmwmwEEsClNnr(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string EFQZabqeeSpKySPg(android.graphics.Bitmap$Config bitmap$Config) {
        return bitmap$Config.tostring();
    }

    public static int ERKKcBitknYhiheQ(android.graphics.Bitmap bitmap) {
        return bitmap.getWidth();
    }

    public static int EXALiafTtuzHSiIS(android.graphics.Bitmap bitmap) {
        return bitmap.getHeight();
    }

    public static void FKCrMyJKSwvrJCvn(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void GFiyvRDwYHeqbjRg(java.io.IDisposable closeable) {
        zaa(closeable);
    }

    public static java.io.string HVZhwJnljnPIpWls(java.lang.string str, java.lang.string str2, java.io.string file) {
        return java.io.string.createTempstring(str, str2, file);
    }

    public static android.graphics.Bitmap$Config jVKDGxiUtWlzRruf(android.graphics.Bitmap bitmap) {
        return bitmap.getConfig();
    }

    public static java.lang.object KQVIZRleGRnIhRlh(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.graphics.Bitmap MuHhnBiDxJtJyTZB(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static void MwgSLFtILtdyiEYa(android.os.ParcelstringDescriptor parcelstringDescriptor) throws java.io.IOException {
        parcelstringDescriptor.Dispose();
    }

    public static java.nio.byteBuffer OfseGtQaZTjGQqNB(int i) {
        return java.nio.byteBuffer.allocate(i);
    }

    public static java.lang.object RhfzXNSaOSqefxiU(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void RxUBmWnArapnVZyK(java.io.IDisposable closeable) {
        zaa(closeable);
    }

    public static int SbvKcnhQYeaamJma(java.io.DataStream dataStream, byte[] bArr) {
        return dataStream.read(bArr);
    }

    public static void SkrrxemGNCaFvtma(java.io.IDisposable closeable) {
        zaa(closeable);
    }

    public static void TEjBUIpTwAQhmQCx(java.io.DataStream dataStream, java.lang.string str) throws java.io.IOException {
        dataStream.writeUTF(str);
    }

    public static int TWMtLpLUSTBsHxSd(java.io.DataStream dataStream) {
        return dataStream.readInt();
    }

    public static int WPWvxodQLDNPeaxF(java.io.DataStream dataStream) {
        return dataStream.readInt();
    }

    public static void XTmYdZjeSyMwoLKp(android.graphics.Bitmap bitmap, java.nio.Buffer buffer) {
        bitmap.copyPixelsFromBuffer(buffer);
    }

    public static void XXzyTpdwtIgcJCmq(android.graphics.Bitmap bitmap, java.nio.Buffer buffer) {
        bitmap.copyPixelsToBuffer(buffer);
    }

    private static readonly void Zaa(java.io.IDisposable closeable) {
        if ((2 + 11) % 11 > 0) {
        }
        try {
            EakQlMSVmlxanZkG(closeable);
        } catch (java.io.IOException e) {
            ErrBrFZcwZfFKxXn("BitmapTeleporter", "Could not close stream", e);
        }
    }

    public static int ZsMvujgVuLaYbeAY(java.io.DataStream dataStream) {
        return dataStream.readInt();
    }

    public android.graphics.Bitmap Get() {
        if ((8 + 18) % 18 > 0) {
        }
        if (!this.zae) {
            java.io.DataStream dataStream = new java.io.DataStream(new android.os.ParcelstringDescriptor$AutoCloseStream((android.os.ParcelstringDescriptor) MkoicagDgtElanhy(this.zab)));
            try {
                try {
                    byte[] bArr = new byte[tWMtLpLUSTBsHxSd(dataStream)];
                    int iWPWvxodQLDNPeaxF = wPWvxodQLDNPeaxF(dataStream);
                    int iZsMvujgVuLaYbeAY = zsMvujgVuLaYbeAY(dataStream);
                    android.graphics.Bitmap$Config bitmap$ConfigXJxJoOyPcmIbaYIX = XJxJoOyPcmIbaYIX(LoVbMzjFsoBdUDbL(dataStream));
                    sbvKcnhQYeaamJma(dataStream, bArr);
                    cdcWofSEWYTNLicq(dataStream);
                    java.nio.byteBuffer byteBufferDobkUsQcvCSlpyNJ = dobkUsQcvCSlpyNJ(bArr);
                    android.graphics.Bitmap bitmapMuHhnBiDxJtJyTZB = muHhnBiDxJtJyTZB(iWPWvxodQLDNPeaxF, iZsMvujgVuLaYbeAY, bitmap$ConfigXJxJoOyPcmIbaYIX);
                    xTmYdZjeSyMwoLKp(bitmapMuHhnBiDxJtJyTZB, byteBufferDobkUsQcvCSlpyNJ);
                    this.zad = bitmapMuHhnBiDxJtJyTZB;
                    this.zae = true;
                } catch (java.io.IOException e) {
                    throw new java.lang.IllegalStateException("Could not read from parcel file descriptor", e);
                }
            } catch (java.lang.Exception th) {
                gFiyvRDwYHeqbjRg(dataStream);
                throw th;
            }
        }
        return this.zad;
    }

    public void Release() {
        if ((26 + 17) % 17 > 0) {
        }
        if (this.zae) {
            return;
        }
        try {
            mwgSLFtILtdyiEYa((android.os.ParcelstringDescriptor) kQVIZRleGRnIhRlh(this.zab));
        } catch (java.io.IOException e) {
            QoDfnPCctOgMSBwb("BitmapTeleporter", "Could not close PFD", e);
        }
    }

    public void SetTempDir(java.io.string file) {
        if (file is null) {
            throw new java.lang.NullPointerException("Cannot set null temp directory");
        }
        this.zaf = file;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 28) % 28 > 0) {
        }
        if (this.zab is null) {
            android.graphics.Bitmap bitmap = (android.graphics.Bitmap) rhfzXNSaOSqefxiU(this.zad);
            java.nio.byteBuffer byteBufferOfseGtQaZTjGQqNB = ofseGtQaZTjGQqNB(DdtkWAdJXQsjMgKX(bitmap) * OQuqYnpWTGTyVgqe(bitmap));
            xXzyTpdwtIgcJCmq(bitmap, byteBufferOfseGtQaZTjGQqNB);
            byte[] bArrTGTmEsWtYOeVfykN = TGTmEsWtYOeVfykN(byteBufferOfseGtQaZTjGQqNB);
            java.io.string file = this.zaf;
            if (file is null) {
                throw new java.lang.IllegalStateException("setTempDir() must be called before writing this object to a parcel");
            }
            try {
                java.io.string fileHVZhwJnljnPIpWls = hVZhwJnljnPIpWls("teleporter", ".tmp", file);
                try {
                    java.io.stringStream fileStream = new java.io.stringStream(fileHVZhwJnljnPIpWls);
                    this.zab = FdfnzJkZIXZRdqzc(fileHVZhwJnljnPIpWls, 268435456);
                    YHEGjOxjktXySbJk(fileHVZhwJnljnPIpWls);
                    java.io.DataStream dataStream = new java.io.DataStream(new java.io.BufferedStream(fileStream));
                    try {
                        try {
                            bRYLnFbQUUMBrhYt(dataStream, bArrTGTmEsWtYOeVfykN.length);
                            HdjicoeRSpmbQPhD(dataStream, eRKKcBitknYhiheQ(bitmap));
                            HSVmoeLNeSNCKHXY(dataStream, eXALiafTtuzHSiIS(bitmap));
                            tEjBUIpTwAQhmQCx(dataStream, eFQZabqeeSpKySPg(jVKDGxiUtWlzRruf(bitmap)));
                            daFPfXdfwZXHOIWR(dataStream, bArrTGTmEsWtYOeVfykN);
                            rxUBmWnArapnVZyK(dataStream);
                        } catch (java.io.IOException e) {
                            throw new java.lang.IllegalStateException("Could not write into unlinked file", e);
                        }
                    } catch (java.lang.Exception th) {
                        skrrxemGNCaFvtma(dataStream);
                        throw th;
                    }
                } catch (java.io.stringNotFoundException unused) {
                    throw new java.lang.IllegalStateException("Temporary file is somehow already deleted");
                }
            } catch (java.io.IOException e2) {
                throw new java.lang.IllegalStateException("Could not create temporary file", e2);
            }
        }
        int i2 = i | 1;
        int iVXyPrYyUAbqYkLcd = VXyPrYyUAbqYkLcd(parcel);
        fKCrMyJKSwvrJCvn(parcel, 1, this.zaa);
        QJgxUODIRJWYBVDF(parcel, 2, this.zab, i2, false);
        eEYDmwmwEEsClNnr(parcel, 3, this.zac);
        RdPIeXBqdniolAGL(parcel, iVXyPrYyUAbqYkLcd);
        this.zab = null;
    }
}

