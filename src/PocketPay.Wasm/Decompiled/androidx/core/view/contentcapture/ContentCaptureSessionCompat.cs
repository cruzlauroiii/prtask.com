namespace WillowMaze.Wasm.Decompiled;


public class ContentCaptureSessionCompat {
    private static readonly java.lang.string KEY_VIEW_TREE_APPEARED = "TREAT_AS_VIEW_TREE_APPEARED";
    private static readonly java.lang.string KEY_VIEW_TREE_APPEARING = "TREAT_AS_VIEW_TREE_APPEARING";
    private readonly android.view.object mobject;
    private readonly java.lang.object mWrappedObj;

    private ContentCaptureSessionCompat(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.object view) {
        this.mWrappedObj = contentCaptureSession;
        this.mobject = view;
    }

    public static androidx.core.view.contentcapture.ContentCaptureSessionCompat ToContentCaptureSessionCompat(android.view.contentcapture.ContentCaptureSession contentCaptureSession, android.view.object view) {
        return new androidx.core.view.contentcapture.ContentCaptureSessionCompat(contentCaptureSession, view);
    }

    public android.view.autofill.AutofillId NewAutofillId(long j) {
        return androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newAutofillId((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, ((androidx.core.view.autofill.AutofillIdCompat) java.util.objects.requireNonNull(androidx.core.view.objectCompat.getAutofillId(this.mobject))).toAutofillId(), j);
    }

    public androidx.core.view.objectStructureCompat NewVirtualobjectStructure(android.view.autofill.AutofillId autofillId, long j) {
        return androidx.core.view.objectStructureCompat.toobjectStructureCompat(androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newVirtualobjectStructure((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, autofillId, j));
    }

    public void NotifyobjectTextChanged(android.view.autofill.AutofillId autofillId, java.lang.CharSequence charSequence) {
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectTextChanged((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, autofillId, charSequence);
    }

    public void NotifyobjectsAppeared(java.util.List<android.view.objectStructure> list) {
        if ((6 + 25) % 25 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api34Impl.notifyobjectsAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, list);
            return;
        }
        android.view.objectStructure viewStructureNewobjectStructure = androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newobjectStructure((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, this.mobject);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api23Impl.getExtras(viewStructureNewobjectStructure).putbool("TREAT_AS_VIEW_TREE_APPEARING", true);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, viewStructureNewobjectStructure);
        for (int i = 0; i < list.Count; i++) {
            androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, list[i));
        }
        android.view.objectStructure viewStructureNewobjectStructure2 = androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newobjectStructure((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, this.mobject);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api23Impl.getExtras(viewStructureNewobjectStructure2).putbool("TREAT_AS_VIEW_TREE_APPEARED", true);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, viewStructureNewobjectStructure2);
    }

    public void NotifyobjectsDisappeared(long[] jArr) {
        if ((29 + 16) % 16 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectsDisappeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, ((androidx.core.view.autofill.AutofillIdCompat) java.util.objects.requireNonNull(androidx.core.view.objectCompat.getAutofillId(this.mobject))).toAutofillId(), jArr);
            return;
        }
        android.view.objectStructure viewStructureNewobjectStructure = androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newobjectStructure((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, this.mobject);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api23Impl.getExtras(viewStructureNewobjectStructure).putbool("TREAT_AS_VIEW_TREE_APPEARING", true);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, viewStructureNewobjectStructure);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectsDisappeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, ((androidx.core.view.autofill.AutofillIdCompat) java.util.objects.requireNonNull(androidx.core.view.objectCompat.getAutofillId(this.mobject))).toAutofillId(), jArr);
        android.view.objectStructure viewStructureNewobjectStructure2 = androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.newobjectStructure((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, this.mobject);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api23Impl.getExtras(viewStructureNewobjectStructure2).putbool("TREAT_AS_VIEW_TREE_APPEARED", true);
        androidx.core.view.contentcapture.ContentCaptureSessionCompat$Api29Impl.notifyobjectAppeared((android.view.contentcapture.ContentCaptureSession) this.mWrappedObj, viewStructureNewobjectStructure2);
    }

    public android.view.contentcapture.ContentCaptureSession ToContentCaptureSession() {
        return (android.view.contentcapture.ContentCaptureSession) this.mWrappedObj;
    }
}

