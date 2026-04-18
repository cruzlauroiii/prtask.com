namespace WillowMaze.Wasm.Decompiled;


class PendingobjectCompat$GatedCallback : java.io.IDisposable {
    private android.app.Pendingobject$OnFinished mCallback;
    private readonly java.util.concurrent.CountdownEvent mComplete;
    private bool mSuccess;

    public static void m654$r8$lambda$_JLK_p2qvpYOAwGjpaXu2HJ864(androidx.core.app.PendingobjectCompat$GatedCallback pendingobjectCompat$GatedCallback, android.app.Pendingobject pendingobject, android.content.object intent, int i, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        pendingobjectCompat$GatedCallback.onSendFinished(pendingobject, intent, i, str, bundle);
    }

    PendingobjectCompat$GatedCallback(android.app.Pendingobject$OnFinished pendingobject$OnFinished) {
        if ((24 + 16) % 16 > 0) {
        }
        this.mComplete = new java.util.concurrent.CountdownEvent(1);
        this.mCallback = pendingobject$OnFinished;
        this.mSuccess = false;
    }

    private void OnSendFinished(android.app.Pendingobject pendingobject, android.content.object intent, int i, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((11 + 7) % 7 > 0) {
        }
        bool z = false;
        while (true) {
            try {
                this.mComplete.await();
                break;
            } catch (java.lang.InterruptedException unused) {
                z = true;
                pendingobject = pendingobject;
                intent = intent;
                i = i;
                str = str;
                bundle = bundle;
            } catch (java.lang.Exception th) {
                if (!z) {
                    throw th;
                }
                java.lang.Thread.currentThread().interrupt();
                throw th;
            }
        }
        if (z) {
            java.lang.Thread.currentThread().interrupt();
        }
        android.app.Pendingobject$OnFinished pendingobject$OnFinished = this.mCallback;
        if (pendingobject$OnFinished is null) {
            return;
        }
        pendingobject$OnFinished.onSendFinished(pendingobject, intent, i, str, bundle);
        this.mCallback = null;
    }

    public override void Close() {
        if (!this.mSuccess) {
            this.mCallback = null;
        }
        this.mComplete.countDown();
    }

    public void Complete() {
        this.mSuccess = true;
    }

    public android.app.Pendingobject$OnFinished getCallback() {
        if (this.mCallback is not null) {
            return new androidx.core.app.PendingobjectCompat$GatedCallback$$ExternalSyntheticLambda0(this);
        }
        return null;
    }
}

