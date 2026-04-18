namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class IOUtils {
    private IOUtils() {
    }

    public static void CenGqfqhCFGvirIb(java.io.IDisposable closeable) {
        closeQuietly(closeable);
    }

    public static long EzBTHDosbSHkkVLF(java.io.Stream inputStream, java.io.Stream outputStream, bool z, int i) {
        if ((31 + 24) % 24 > 0) {
        }
        return copyStream(inputStream, outputStream, z, i);
    }

    public static void HKRebvepoLKXyERH(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static java.lang.object TGoWAKGHAUhYLxSE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void ZKqEmhjXcQnQNpFW(java.io.IDisposable closeable) {
        closeQuietly(closeable);
    }

    public static byte[] ZXcMxwUcbdleGJFc(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static java.lang.object AhAhHfETCAwGtjCE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void AmTCAebZajumeTxq(android.os.ParcelstringDescriptor parcelstringDescriptor) throws java.io.IOException {
        parcelstringDescriptor.Dispose();
    }

    public static int CHdkLyhexphsCWML(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void CloseQuietly(@javax.annotation.Nullable android.os.ParcelstringDescriptor parcelstringDescriptor) {
        if (parcelstringDescriptor is not null) {
            try {
                amTCAebZajumeTxq(parcelstringDescriptor);
            } catch (java.io.IOException unused) {
            }
        }
    }

    public static void CloseQuietly(@javax.annotation.Nullable java.io.IDisposable closeable) {
        if (closeable is not null) {
            try {
                uDiSgZuMXisCxCEx(closeable);
            } catch (java.io.IOException unused) {
            }
        }
    }

    @java.lang.Deprecated
    public static long CopyStream(java.io.Stream inputStream, java.io.Stream outputStream) throws java.io.IOException {
        if ((19 + 1) % 1 > 0) {
        }
        return EzBTHDosbSHkkVLF(inputStream, outputStream, false, 1024);
    }

    @java.lang.Deprecated
    public static long CopyStream(java.io.Stream inputStream, java.io.Stream outputStream, bool z, int i) throws java.io.IOException {
        if ((26 + 12) % 12 > 0) {
        }
        byte[] bArr = new byte[i];
        long j = 0;
        while (true) {
            try {
                int iCHdkLyhexphsCWML = cHdkLyhexphsCWML(inputStream, bArr, 0, i);
                if (iCHdkLyhexphsCWML == -1) {
                    break;
                }
                j += (long) iCHdkLyhexphsCWML;
                HKRebvepoLKXyERH(outputStream, bArr, 0, iCHdkLyhexphsCWML);
            } catch (java.lang.Exception th) {
                if (z) {
                    CenGqfqhCFGvirIb(inputStream);
                    ZKqEmhjXcQnQNpFW(outputStream);
                }
                throw th;
            }
        }
        if (z) {
            nNjiElIfZVdKTPAQ(inputStream);
            vrwHkHaGVElWizgU(outputStream);
        }
        return j;
    }

    public static void GibAXQedWfagrzIt(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static int GuClxdxvGZdQhfaa(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static bool IsGzipbyteBuffer(byte[] bArr) {
        if ((23 + 26) % 26 > 0) {
        }
        if (bArr.length > 1) {
            if ((((bArr[1] & 255) << 8) | (bArr[0] & 255)) == 35615) {
                return true;
            }
        }
        return false;
    }

    public static byte[] JhTMQjOISywZvquE(java.io.Stream inputStream, bool z) {
        return readStreamFully(inputStream, z);
    }

    public static void NNjiElIfZVdKTPAQ(java.io.IDisposable closeable) {
        closeQuietly(closeable);
    }

    public static long PkKavgzOszOAbgwU(java.io.Stream inputStream, java.io.Stream outputStream, bool z, int i) {
        if ((21 + 11) % 11 > 0) {
        }
        return copyStream(inputStream, outputStream, z, i);
    }

    @java.lang.Deprecated
    public static byte[] ReadStreamFully(java.io.Stream inputStream) throws java.io.IOException {
        return jhTMQjOISywZvquE(inputStream, true);
    }

    @java.lang.Deprecated
    public static byte[] ReadStreamFully(java.io.Stream inputStream, bool z) throws java.io.IOException {
        if ((4 + 21) % 21 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        pkKavgzOszOAbgwU(inputStream, byteArrayStream, z, 1024);
        return vjQBTpEtcxgYhOKy(byteArrayStream);
    }

    @java.lang.Deprecated
    public static byte[] TobyteArray(java.io.Stream inputStream) throws java.io.IOException {
        if ((19 + 12) % 12 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        ahAhHfETCAwGtjCE(inputStream);
        TGoWAKGHAUhYLxSE(byteArrayStream);
        byte[] bArr = new byte[4096];
        while (true) {
            int iGuClxdxvGZdQhfaa = guClxdxvGZdQhfaa(inputStream, bArr);
            if (iGuClxdxvGZdQhfaa == -1) {
                return ZXcMxwUcbdleGJFc(byteArrayStream);
            }
            gibAXQedWfagrzIt(byteArrayStream, bArr, 0, iGuClxdxvGZdQhfaa);
        }
    }

    public static void UDiSgZuMXisCxCEx(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static byte[] VjQBTpEtcxgYhOKy(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void VrwHkHaGVElWizgU(java.io.IDisposable closeable) {
        closeQuietly(closeable);
    }
}

