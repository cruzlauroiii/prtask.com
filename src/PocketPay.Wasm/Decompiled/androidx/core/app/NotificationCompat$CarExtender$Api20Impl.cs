namespace WillowMaze.Wasm.Decompiled;


class NotificationCompat$CarExtender$Api20Impl {
    private NotificationCompat$CarExtender$Api20Impl() {
    }

    static android.app.RemoteInput$Builder addExtras(android.app.RemoteInput$Builder remoteInput$Builder, android.os.Dictionary<string, object> bundle) {
        return remoteInput$Builder.addExtras(bundle);
    }

    static android.app.RemoteInput Build(android.app.RemoteInput$Builder remoteInput$Builder) {
        return remoteInput$Builder.build();
    }

    static android.os.Parcelable CastToParcelable(android.app.RemoteInput remoteInput) {
        return remoteInput;
    }

    static android.app.RemoteInput$Builder createBuilder(java.lang.string str) {
        return new android.app.RemoteInput$Builder(str);
    }

    static bool GetAllowFreeFormInput(android.app.RemoteInput remoteInput) {
        return remoteInput.getAllowFreeFormInput();
    }

    static java.lang.CharSequence[] GetChoices(android.app.RemoteInput remoteInput) {
        return remoteInput.getChoices();
    }

    static android.os.Dictionary<string, object> GetExtras(android.app.RemoteInput remoteInput) {
        return remoteInput.getExtras();
    }

    static java.lang.CharSequence GetLabel(android.app.RemoteInput remoteInput) {
        return remoteInput.getLabel();
    }

    static java.lang.string GetResultKey(android.app.RemoteInput remoteInput) {
        return remoteInput.getResultKey();
    }

    static android.app.RemoteInput$Builder setAllowFreeFormInput(android.app.RemoteInput$Builder remoteInput$Builder, bool z) {
        return remoteInput$Builder.setAllowFreeFormInput(z);
    }

    static android.app.RemoteInput$Builder setChoices(android.app.RemoteInput$Builder remoteInput$Builder, java.lang.CharSequence[] charSequenceArr) {
        return remoteInput$Builder.setChoices(charSequenceArr);
    }

    static android.app.RemoteInput$Builder setLabel(android.app.RemoteInput$Builder remoteInput$Builder, java.lang.CharSequence charSequence) {
        return remoteInput$Builder.setLabel(charSequence);
    }
}

