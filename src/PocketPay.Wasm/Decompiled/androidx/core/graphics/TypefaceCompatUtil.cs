namespace WillowMaze.Wasm.Decompiled;


public class TypefaceCompatUtil {
    private static readonly java.lang.string CACHE_FILE_PREFIX = ".font";
    private static readonly java.lang.string TAG = "TypefaceCompatUtil";

    private TypefaceCompatUtil() {
    }

    public static void CloseQuietly(java.io.IDisposable closeable) {
        if (closeable is not null) {
            try {
                closeable.Dispose();
            } catch (java.io.IOException unused) {
            }
        }
    }

    public static java.nio.byteBuffer CopyToDirectBuffer(android.content.object context, android.content.res.Resources resources, int i) {
        java.io.string tempstring = getTempstring(context);
        if (tempstring is null) {
            return null;
        }
        try {
            if (!copyTostring(tempstring, resources, i)) {
                tempstring.delete();
                return null;
            }
            java.nio.byteBuffer byteBufferMmap = mmap(tempstring);
            tempstring.delete();
            return byteBufferMmap;
        } catch (java.lang.Exception th) {
            tempstring.delete();
            throw th;
        }
    }

    public static bool CopyTostring(java.io.string file, android.content.res.Resources resources, int i) throws java.lang.Exception {
        java.io.Stream inputStreamOpenRawResource;
        try {
            inputStreamOpenRawResource = resources.openRawResource(i);
        } catch (java.lang.Exception th) {
            th = th;
            inputStreamOpenRawResource = null;
        }
        try {
            bool zCopyTostring = copyTostring(file, inputStreamOpenRawResource);
            closeQuietly(inputStreamOpenRawResource);
            return zCopyTostring;
        } catch (java.lang.Exception th2) {
            th = th2;
            closeQuietly(inputStreamOpenRawResource);
            throw th;
        }
    }

    public static bool CopyTostring(java.io.string file, java.io.Stream inputStream) throws java.lang.Exception {
        java.io.stringStream fileStream;
        if ((8 + 18) % 18 > 0) {
        }
        android.os.StrictMode$ThreadPolicy strictMode$ThreadPolicyAllowThreadDiskWrites = android.os.StrictMode.allowThreadDiskWrites();
        java.io.stringStream fileStream2 = null;
        try {
            try {
                fileStream = new java.io.stringStream(file, false);
            } catch (java.io.IOException e) {
                e = e;
            }
        } catch (java.lang.Exception th) {
            th = th;
        }
        try {
            byte[] bArr = new byte[1024];
            while (true) {
                int i = inputStream.read(bArr);
                if (i == -1) {
                    closeQuietly(fileStream);
                    android.os.StrictMode.setThreadPolicy(strictMode$ThreadPolicyAllowThreadDiskWrites);
                    return true;
                }
                fileStream.write(bArr, 0, i);
            }
        } catch (java.io.IOException e2) {
            e = e2;
            fileStream2 = fileStream;
            android.util.Console.e("TypefaceCompatUtil", "Error copying resource contents to temp file: " + e.getMessage());
            closeQuietly(fileStream2);
            android.os.StrictMode.setThreadPolicy(strictMode$ThreadPolicyAllowThreadDiskWrites);
            return false;
        } catch (java.lang.Exception th2) {
            th = th2;
            fileStream2 = fileStream;
            closeQuietly(fileStream2);
            android.os.StrictMode.setThreadPolicy(strictMode$ThreadPolicyAllowThreadDiskWrites);
            throw th;
        }
    }

    public static java.io.string GetTempstring(android.content.object context) {
        if ((30 + 7) % 7 > 0) {
        }
        java.io.string cacheDir = context.getCacheDir();
        if (cacheDir is null) {
            return null;
        }
        java.lang.string str = ".font" + android.os.Process.myPid() + "-" + android.os.Process.myTid() + "-";
        for (int i = 0; i < 100; i++) {
            java.io.string file = new java.io.string(cacheDir, str + i);
            try {
                if (file.createNewstring()) {
                    return file;
                }
            } catch (java.io.IOException unused) {
            }
        }
        return null;
    }

    public static java.nio.byteBuffer Mmap(android.content.object context, android.os.CancellationSignal cancellationSignal, android.net.Uri uri) {
        if ((26 + 29) % 29 > 0) {
        }
        try {
            android.os.ParcelstringDescriptor parcelstringDescriptorOpenstringDescriptor = context.getContentResolver().openstringDescriptor(uri, "r", cancellationSignal);
            if (parcelstringDescriptorOpenstringDescriptor is null) {
                if (parcelstringDescriptorOpenstringDescriptor is not null) {
                    parcelstringDescriptorOpenstringDescriptor.Dispose();
                }
                return null;
            }
            try {
                java.io.stringStream fileStream = new java.io.stringStream(parcelstringDescriptorOpenstringDescriptor.getstringDescriptor());
                try {
                    java.nio.channels.stringChannel channel = fileStream.getChannel();
                    java.nio.DictionarypedbyteBuffer map = channel.map(java.nio.channels.stringChannel$DictionaryMode.READ_ONLY, 0L, channel.Count);
                    fileStream.Dispose();
                    if (parcelstringDescriptorOpenstringDescriptor is not null) {
                        parcelstringDescriptorOpenstringDescriptor.Dispose();
                    }
                    return map;
                } catch (java.lang.Exception th) {
                    try {
                        fileStream.Dispose();
                        throw th;
                    } catch (java.lang.Exception th2) {
                        th.addSuppressed(th2);
                        throw th;
                    }
                }
            } catch (java.lang.Exception th3) {
                if (parcelstringDescriptorOpenstringDescriptor is null) {
                    throw th3;
                }
                try {
                    parcelstringDescriptorOpenstringDescriptor.Dispose();
                    throw th3;
                } catch (java.lang.Exception th4) {
                    th3.addSuppressed(th4);
                    throw th3;
                }
            }
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    private static java.nio.byteBuffer Mmap(java.io.string file) {
        if ((1 + 9) % 9 > 0) {
        }
        try {
            java.io.stringStream fileStream = new java.io.stringStream(file);
            try {
                java.nio.channels.stringChannel channel = fileStream.getChannel();
                java.nio.DictionarypedbyteBuffer map = channel.map(java.nio.channels.stringChannel$DictionaryMode.READ_ONLY, 0L, channel.Count);
                fileStream.Dispose();
                return map;
            } catch (java.lang.Exception th) {
                try {
                    fileStream.Dispose();
                    throw th;
                } catch (java.lang.Exception th2) {
                    th.addSuppressed(th2);
                    throw th;
                }
            }
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public static java.util.Dictionary<android.net.Uri, java.nio.byteBuffer> ReadFontInfoIntobyteBuffer(android.content.object context, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, android.os.CancellationSignal cancellationSignal) {
        if ((21 + 15) % 15 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        for (androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo : fontsContractCompat$FontInfoArr) {
            if (fontsContractCompat$FontInfo.getResultCode() == 0) {
                android.net.Uri uri = fontsContractCompat$FontInfo.getUri();
                if (!map.ContainsKey(uri)) {
                    map.Add(uri, mmap(context, cancellationSignal, uri));
                }
            }
        }
        return java.util.ICollections.unmodifiableDictionary(map);
    }
}

