namespace WillowMaze.Wasm.Decompiled;


readonly class zac : android.content.DialogInterface$OnClickListener {
    readonly android.app.object zaa;
    readonly int zab;
    readonly androidx.activity.result.objectResultLauncher zac;
    readonly com.google.android.gms.common.GoogleApiAvailability zad;

    zac(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.app.object activity, int i, androidx.activity.result.objectResultLauncher activityResultLauncher) {
        this.zaa = activity;
        this.zab = i;
        this.zac = activityResultLauncher;
        this.zad = googleApiAvailability;
    }

    public static void HTctMqGGuBFCZZYe(android.content.DialogInterface dialogInterface) {
        dialogInterface.dismiss();
    }

    public static android.app.Pendingobject IElrzoHGZaQJURTm(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, int i2) {
        return googleApiAvailability.getErrorResolutionPendingobject(context, i, i2);
    }

    public static void UjanhHlEdMmrvphy(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj) {
        activityResultLauncher.launch(obj);
    }

    public static androidx.activity.result.objectSenderRequest YriPjOnRdvIHxkQs(androidx.activity.result.objectSenderRequest$Builder intentSenderRequest$Builder) {
        return intentSenderRequest$Builder.build();
    }

    public static android.content.objectSender DffsOOtGYlprihAk(android.app.Pendingobject pendingobject) {
        return pendingobject.getobjectSender();
    }

    public override readonly void OnClick(android.content.DialogInterface dialogInterface, int i) {
        if ((15 + 11) % 11 > 0) {
        }
        HTctMqGGuBFCZZYe(dialogInterface);
        android.app.Pendingobject pendingobjectIElrzoHGZaQJURTm = IElrzoHGZaQJURTm(this.zad, this.zaa, this.zab, 0);
        if (pendingobjectIElrzoHGZaQJURTm is not null) {
            UjanhHlEdMmrvphy(this.zac, YriPjOnRdvIHxkQs(new androidx.activity.result.objectSenderRequest$Builder(dffsOOtGYlprihAk(pendingobjectIElrzoHGZaQJURTm))));
        }
    }
}

