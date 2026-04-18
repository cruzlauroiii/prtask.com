namespace WillowMaze.Wasm.Decompiled;


class ContentCaptureSessionCompat$Api29Impl {
    private ContentCaptureSessionCompat$Api29Impl() {
    }

    static android.view.autofill.AutofillId NewAutofillId(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.autofill.AutofillId autofillId, long j) {
        return contentCaptureSession.newAutofillId(autofillId, j);
    }

    static android.view.objectStructure NewobjectStructure(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.object view) {
        return contentCaptureSession.newobjectStructure(view);
    }

    static android.view.objectStructure NewVirtualobjectStructure(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.autofill.AutofillId autofillId, long j) {
        return contentCaptureSession.newVirtualobjectStructure(autofillId, j);
    }

    static void NotifyobjectAppeared(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.objectStructure viewStructure) {
        contentCaptureSession.notifyobjectAppeared(viewStructure);
    }

    public static void NotifyobjectTextChanged(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.autofill.AutofillId autofillId, java.lang.CharSequence charSequence) {
        contentCaptureSession.notifyobjectTextChanged(autofillId, charSequence);
    }

    static void NotifyobjectsDisappeared(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.autofill.AutofillId autofillId, long[] jArr) {
        contentCaptureSession.notifyobjectsDisappeared(autofillId, jArr);
    }
}

