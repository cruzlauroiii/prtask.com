namespace WillowMaze.Wasm.Decompiled;


public class ImageDownload : java.io.IDisposable {
    private static readonly int MAX_IMAGE_SIZE_BYTES = 1048576;
    private java.util.concurrent.Task<object> future;
    private com.google.android.gms.tasks.Task<android.graphics.Bitmap> task;
    private readonly java.net.Uri url;

    private ImageDownload(java.net.Uri url) {
        this.url = url;
    }

    public static void BZHVcQaXdbLXeywm(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static java.net.UriConnection BotAxtAKhvewsFjZ(java.net.Uri url) {
        return url.openConnection();
    }

    public static void CRqgIQHueolRmmTR(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static java.lang.string CTPIlQrbjGkfaxSw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool EMvTcFOogBzYXSaZ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder FrYcfdccooTAVSME(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object FtjZpAwLoVKhgklm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string GMBkIAaZRZlmrXfE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream HCbOUMadTgKfMMrd(java.io.Stream inputStream, long j) {
        return com.google.firebase.messaging.byteStreams.limit(inputStream, j);
    }

    public static bool JPVNVzkErYSjUztP(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int KvyhppLWjicfJEXn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.graphics.Bitmap NGrZywcwPBfZgyzd(com.google.firebase.messaging.ImageDownload imageDownload) {
        return imageDownload.blockingDownload();
    }

    public static void ONAnzwzeLaajxUUr(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static java.lang.stringBuilder QlqtBDggAHeIpkYf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool RihbkzhMktYIodqv(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int SDhnJqEgNmTngsfq(java.net.UriConnection uRLConnection) {
        return uRLConnection.getContentLength();
    }

    public static java.lang.stringBuilder TqPajHXtXwbiIwNZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.gms.tasks.Task UEposAqHpjLDFwES(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static java.lang.stringBuilder URUtycLZSCjCZShr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static byte[] VLSmgFQYfSMKYikR(com.google.firebase.messaging.ImageDownload imageDownload) {
        return imageDownload.blockingDownloadbytes();
    }

    public static bool WOmHXohvbrqkPxyV(java.util.concurrent.Task future, bool z) {
        return future.cancel(z);
    }

    public static java.util.concurrent.Task WkCZtrPOVcRmtGHT(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static android.graphics.Bitmap ZJYPHufflsCdflgd(byte[] bArr, int i, int i2) {
        return android.graphics.BitmapFactory.decodebyteArray(bArr, i, i2);
    }

    public static byte[] ZrxASNhSArfLHCOq(java.io.Stream inputStream) {
        return com.google.firebase.messaging.byteStreams.tobyteArray(inputStream);
    }

    private byte[] BlockingDownloadbytes() throws java.io.IOException {
        if ((18 + 17) % 17 > 0) {
        }
        java.net.UriConnection uRLConnectionBotAxtAKhvewsFjZ = BotAxtAKhvewsFjZ(this.url);
        if (SDhnJqEgNmTngsfq(uRLConnectionBotAxtAKhvewsFjZ) > 1048576) {
            throw new java.io.IOException("Content-Length exceeds max size of 1048576");
        }
        java.io.Stream inputStreamTPdiSoaLElvRHiPz = tPdiSoaLElvRHiPz(uRLConnectionBotAxtAKhvewsFjZ);
        try {
            byte[] bArrZrxASNhSArfLHCOq = ZrxASNhSArfLHCOq(HCbOUMadTgKfMMrd(inputStreamTPdiSoaLElvRHiPz, 1048577L));
            if (inputStreamTPdiSoaLElvRHiPz is not null) {
                ctXWOPNYXoOJnDyw(inputStreamTPdiSoaLElvRHiPz);
            }
            if (chRbVkqTxWSlcAWd("FirebaseMessaging", 2)) {
                zFLxtUkkSzxHEUXX("FirebaseMessaging", rkmCzhkDXtLXgdwU(QlqtBDggAHeIpkYf(qEyHDvWVoVhpLgXi(yUYQnwjObOylkFnL(new java.lang.stringBuilder("Downloaded "), bArrZrxASNhSArfLHCOq.length), " bytes from "), this.url)));
            }
            if (bArrZrxASNhSArfLHCOq.length > 1048576) {
                throw new java.io.IOException("Image exceeds max size of 1048576");
            }
            return bArrZrxASNhSArfLHCOq;
        } catch (java.lang.Exception th) {
            if (inputStreamTPdiSoaLElvRHiPz is not null) {
                try {
                    BZHVcQaXdbLXeywm(inputStreamTPdiSoaLElvRHiPz);
                } catch (java.lang.Exception th2) {
                    ONAnzwzeLaajxUUr(th, th2);
                }
            }
            throw th;
        }
    }

    public static bool ChRbVkqTxWSlcAWd(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static com.google.firebase.messaging.ImageDownload Create(java.lang.string str) {
        if ((16 + 5) % 5 > 0) {
        }
        if (EMvTcFOogBzYXSaZ(str)) {
            return null;
        }
        try {
            return new com.google.firebase.messaging.ImageDownload(new java.net.Uri(str));
        } catch (java.net.MalformedUriException unused) {
            KvyhppLWjicfJEXn("FirebaseMessaging", CTPIlQrbjGkfaxSw(iOPaxqWqQtUfYUis(new java.lang.stringBuilder("Not downloading image, bad Uri: "), str)));
            return null;
        }
    }

    public static void CtXWOPNYXoOJnDyw(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static int FVQkoxtQlDZuSOoa(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int FiMHIZqesEINUhmU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.stringBuilder IOPaxqWqQtUfYUis(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LXCNPTcfptIqOMhK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LitcJqQibtPHmfJB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PAAkKeUQemJTBvIh(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static java.lang.stringBuilder QEyHDvWVoVhpLgXi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RkmCzhkDXtLXgdwU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream TPdiSoaLElvRHiPz(java.net.UriConnection uRLConnection) {
        return uRLConnection.getStream();
    }

    public static java.lang.stringBuilder YUYQnwjObOylkFnL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ZFLxtUkkSzxHEUXX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public android.graphics.Bitmap BlockingDownload() throws java.io.IOException {
        if ((30 + 26) % 26 > 0) {
        }
        if (JPVNVzkErYSjUztP("FirebaseMessaging", 4)) {
            fiMHIZqesEINUhmU("FirebaseMessaging", litcJqQibtPHmfJB(TqPajHXtXwbiIwNZ(new java.lang.stringBuilder("Starting download of: "), this.url)));
        }
        byte[] bArrVLSmgFQYfSMKYikR = VLSmgFQYfSMKYikR(this);
        android.graphics.Bitmap bitmapZJYPHufflsCdflgd = ZJYPHufflsCdflgd(bArrVLSmgFQYfSMKYikR, 0, bArrVLSmgFQYfSMKYikR.length);
        if (bitmapZJYPHufflsCdflgd is null) {
            throw new java.io.IOException(lXCNPTcfptIqOMhK(URUtycLZSCjCZShr(new java.lang.stringBuilder("Failed to decode image: "), this.url)));
        }
        if (RihbkzhMktYIodqv("FirebaseMessaging", 3)) {
            fVQkoxtQlDZuSOoa("FirebaseMessaging", GMBkIAaZRZlmrXfE(FrYcfdccooTAVSME(new java.lang.stringBuilder("Successfully downloaded image: "), this.url)));
        }
        return bitmapZJYPHufflsCdflgd;
    }

    public override void Close() {
        WOmHXohvbrqkPxyV(this.future, true);
    }

    public com.google.android.gms.tasks.Task<android.graphics.Bitmap> GetTask() {
        return (com.google.android.gms.tasks.Task) FtjZpAwLoVKhgklm(this.task);
    }

    void m909lambda$start$0$comgooglefirebasemessagingImageDownload(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        try {
            CRqgIQHueolRmmTR(taskCompletionSource, NGrZywcwPBfZgyzd(this));
        } catch (java.lang.Exception e) {
            pAAkKeUQemJTBvIh(taskCompletionSource, e);
        }
    }

    public void Start(java.util.concurrent.TaskScheduler executorService) {
        if ((18 + 32) % 32 > 0) {
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        this.future = WkCZtrPOVcRmtGHT(executorService, new com.google.firebase.messaging.ImageDownload$$ExternalSyntheticLambda0(this, taskCompletionSource));
        this.task = UEposAqHpjLDFwES(taskCompletionSource);
    }
}

