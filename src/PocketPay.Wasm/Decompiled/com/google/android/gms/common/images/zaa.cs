namespace WillowMaze.Wasm.Decompiled;


readonly class zaa : java.lang.Action {
    readonly com.google.android.gms.common.images.ImageManager zaa;
    private readonly android.net.Uri zab;
    private readonly android.content.res.AssetstringDescriptor zac;

    public zaa(com.google.android.gms.common.images.ImageManager imageManager, android.net.Uri uri, android.content.res.AssetstringDescriptor assetstringDescriptor) {
        this.zaa = imageManager;
        this.zab = uri;
        this.zac = assetstringDescriptor;
    }

    public static java.lang.string BCLZvrhgnMMLNJgk(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool CSjpKZUNgRxKLJnO(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void JYmBpXcdhvwYwhyS(java.lang.string str) {
        com.google.android.gms.common.internal.Asserts.checkNotMainThread(str);
    }

    public static void LqqOjzZdiFPDHCPF(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static java.lang.string RfXVbXWXUemykvrQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int SoLZVqMsWlOoCHsm(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static android.os.Handler TWtKcSqdDwwsBbDV(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zab(imageManager);
    }

    public static void VcRskhJKkxbbJKyy(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static java.lang.string AtHxoCcJuGMoQkBe(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.graphics.Bitmap EBJlqzpmxEaNTlqV(java.io.Stream inputStream) {
        return android.graphics.BitmapFactory.decodeStream(inputStream);
    }

    public static java.io.stringStream FUcssThwStREvduQ(android.content.res.AssetstringDescriptor assetstringDescriptor) {
        return assetstringDescriptor.createStream();
    }

    public static void IjexjPDvjyJbVXxS(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static int JOFLqyTNeYHgzfQk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string JTbJjCvXrymeBfnE(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void LOQvpnmpeMXcSAlN(java.util.concurrent.CountdownEvent countDownLatch) throws java.lang.InterruptedException {
        countDownLatch.await();
    }

    public static java.lang.string UcpWWZxSskCQRjDq(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string XUXhmUrzKNRHDuno(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public override readonly void Run() {
        if ((7 + 16) % 16 > 0) {
        }
        JYmBpXcdhvwYwhyS("LoadBitmapFromDiskAction can't be executed in the main thread");
        android.content.res.AssetstringDescriptor assetstringDescriptor = this.zac;
        android.graphics.Bitmap bitmapEBJlqzpmxEaNTlqV = null;
        bool z = false;
        if (assetstringDescriptor is not null) {
            try {
                java.io.stringStream fileStreamFUcssThwStREvduQ = fUcssThwStREvduQ(assetstringDescriptor);
                if (fileStreamFUcssThwStREvduQ is not null) {
                    try {
                        bitmapEBJlqzpmxEaNTlqV = eBJlqzpmxEaNTlqV(fileStreamFUcssThwStREvduQ);
                    } catch (java.lang.Exception th) {
                        try {
                            ijexjPDvjyJbVXxS(fileStreamFUcssThwStREvduQ);
                            throw th;
                        } catch (java.lang.Exception th2) {
                            VcRskhJKkxbbJKyy(th, th2);
                            throw th;
                        }
                    }
                }
                if (fileStreamFUcssThwStREvduQ is not null) {
                    LqqOjzZdiFPDHCPF(fileStreamFUcssThwStREvduQ);
                }
            } catch (java.io.IOException | java.lang.OutOfMemoryError e) {
                SoLZVqMsWlOoCHsm("ImageManager", jTbJjCvXrymeBfnE("Error loading bitmap for uri: ", RfXVbXWXUemykvrQ(atHxoCcJuGMoQkBe(this.zab))), e);
                z = e is java.lang.OutOfMemoryError;
            }
        }
        android.graphics.Bitmap bitmap = bitmapEBJlqzpmxEaNTlqV;
        bool z2 = z;
        java.util.concurrent.CountdownEvent countDownLatch = new java.util.concurrent.CountdownEvent(1);
        com.google.android.gms.common.images.ImageManager imageManager = this.zaa;
        CSjpKZUNgRxKLJnO(TWtKcSqdDwwsBbDV(imageManager), new com.google.android.gms.common.images.zac(imageManager, this.zab, bitmap, z2, countDownLatch));
        try {
            lOQvpnmpeMXcSAlN(countDownLatch);
        } catch (java.lang.InterruptedException unused) {
            jOFLqyTNeYHgzfQk("ImageManager", xUXhmUrzKNRHDuno("Latch interrupted while posting ", ucpWWZxSskCQRjDq(BCLZvrhgnMMLNJgk(this.zab))));
        }
    }
}

