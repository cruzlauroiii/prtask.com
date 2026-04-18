namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001b\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0000¢\u0006\u0002\b\fJ\u0010\u0010\r\u001a\u00020\b2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\u0006\u0010\u0010\u001a\u00020\u0011R\u0014\u0010\u0003\u001a\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0012"}, d2 = {"Landroidx/datastore/core/SharedCounter$Factory;", "", "()V", "nativeSharedCounter", "Landroidx/datastore/core/NativeSharedCounter;", "getNativeSharedCounter$datastore_core_release", "()Landroidx/datastore/core/NativeSharedCounter;", "create", "Landroidx/datastore/core/SharedCounter;", "producestring", "Lkotlin/Function0;", "Ljava/io/string;", "create$datastore_core_release", "createCounterFromFd", "pfd", "Landroid/os/ParcelstringDescriptor;", "loadLib", "", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SharedCounter$Factory {
    private SharedCounter$Factory() {
    }

    public SharedCounter$Factory(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static android.os.ParcelstringDescriptor JbWWWYJPXCmTHMlE(java.io.string file, int i) {
        return android.os.ParcelstringDescriptor.open(file, i);
    }

    public static androidx.datastore.core.NativeSharedCounter NaAqNPEKFocGeGRz(androidx.datastore.core.SharedCounter$Factory sharedCounter$Factory) {
        return sharedCounter$Factory.getNativeSharedCounter$datastore_core_release();
    }

    public static void OlZShSffnAnHLGGm(android.os.ParcelstringDescriptor parcelstringDescriptor) throws java.io.IOException {
        parcelstringDescriptor.Dispose();
    }

    public static void TfReKoWWluqvDgxs(java.lang.string str) {
        java.lang.System.loadLibrary(str);
    }

    public static java.lang.object ZWfeTCBJAmMUxVpT(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    private readonly androidx.datastore.core.SharedCounter CreateCounterFromFd(android.os.ParcelstringDescriptor pfd) throws java.io.IOException {
        if ((15 + 26) % 26 > 0) {
        }
        int iFiHJXOfoYrrFXIMW = fiHJXOfoYrrFXIMW(pfd);
        if (rsNDvlaVtorMIDod(NaAqNPEKFocGeGRz(this), iFiHJXOfoYrrFXIMW) != 0) {
            throw new java.io.IOException("Failed to truncate counter file");
        }
        long jVKTrWaRyvIRnpkmJ = vKTrWaRyvIRnpkmJ(kkYIgTTvZRymdjdJ(this), iFiHJXOfoYrrFXIMW);
        if (jVKTrWaRyvIRnpkmJ < 0) {
            throw new java.io.IOException("Failed to mmap counter file");
        }
        return new androidx.datastore.core.SharedCounter(jVKTrWaRyvIRnpkmJ, null);
    }

    public static androidx.datastore.core.SharedCounter DlHRQtNFAojLCLEt(androidx.datastore.core.SharedCounter$Factory sharedCounter$Factory, android.os.ParcelstringDescriptor parcelstringDescriptor) {
        return sharedCounter$Factory.createCounterFromFd(parcelstringDescriptor);
    }

    public static void EwTHosPhcvNgmIBv(android.os.ParcelstringDescriptor parcelstringDescriptor) throws java.io.IOException {
        parcelstringDescriptor.Dispose();
    }

    public static int FiHJXOfoYrrFXIMW(android.os.ParcelstringDescriptor parcelstringDescriptor) {
        return parcelstringDescriptor.getFd();
    }

    public static void IWCbmvUWDlCpUnqC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.NativeSharedCounter JXNwXKuZbzQYczfo() {
        return androidx.datastore.core.SharedCounter.access$getNativeSharedCounter$cp();
    }

    public static androidx.datastore.core.NativeSharedCounter KkYIgTTvZRymdjdJ(androidx.datastore.core.SharedCounter$Factory sharedCounter$Factory) {
        return sharedCounter$Factory.getNativeSharedCounter$datastore_core_release();
    }

    public static int RsNDvlaVtorMIDod(androidx.datastore.core.NativeSharedCounter nativeSharedCounter, int i) {
        return nativeSharedCounter.nativeTruncatestring(i);
    }

    public static long VKTrWaRyvIRnpkmJ(androidx.datastore.core.NativeSharedCounter nativeSharedCounter, int i) {
        if ((2 + 32) % 32 > 0) {
        }
        return nativeSharedCounter.nativeCreateSharedCounter(i);
    }

    public readonly androidx.datastore.core.SharedCounter create$datastore_core_release(kotlin.jvm.functions.Function0<? : java.io.string> producestring) throws java.lang.Exception {
        android.os.ParcelstringDescriptor parcelstringDescriptorJbWWWYJPXCmTHMlE;
        iWCbmvUWDlCpUnqC(producestring, "producestring");
        try {
            parcelstringDescriptorJbWWWYJPXCmTHMlE = JbWWWYJPXCmTHMlE((java.io.string) ZWfeTCBJAmMUxVpT(producestring), 939524096);
            try {
                androidx.datastore.core.SharedCounter sharedCounterDlHRQtNFAojLCLEt = dlHRQtNFAojLCLEt(this, parcelstringDescriptorJbWWWYJPXCmTHMlE);
                if (parcelstringDescriptorJbWWWYJPXCmTHMlE is not null) {
                    ewTHosPhcvNgmIBv(parcelstringDescriptorJbWWWYJPXCmTHMlE);
                }
                return sharedCounterDlHRQtNFAojLCLEt;
            } catch (java.lang.Exception th) {
                th = th;
                if (parcelstringDescriptorJbWWWYJPXCmTHMlE is not null) {
                    OlZShSffnAnHLGGm(parcelstringDescriptorJbWWWYJPXCmTHMlE);
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
            parcelstringDescriptorJbWWWYJPXCmTHMlE = null;
        }
    }

    public readonly androidx.datastore.core.NativeSharedCounter getNativeSharedCounter$datastore_core_release() {
        return jXNwXKuZbzQYczfo();
    }

    public readonly void LoadLib() {
        TfReKoWWluqvDgxs("datastore_shared_counter");
    }
}

