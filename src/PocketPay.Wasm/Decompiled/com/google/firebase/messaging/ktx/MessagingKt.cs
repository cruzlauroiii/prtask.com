namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\u001a/\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0019\b\u0004\u0010\t\u001a\u0013\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\f0\n¢\u0006\u0002\b\rH\u0087\bø\u0001\u0000\"\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00028F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000e"}, d2 = {"messaging", "Lcom/google/firebase/messaging/FirebaseMessaging;", "Lcom/google/firebase/ktx/Firebase;", "getMessaging", "(Lcom/google/firebase/ktx/Firebase;)Lcom/google/firebase/messaging/FirebaseMessaging;", "remoteMessage", "Lcom/google/firebase/messaging/RemoteMessage;", "to", "", "init", "Lkotlin/Function1;", "Lcom/google/firebase/messaging/RemoteMessage$Builder;", "", "Lkotlin/ExtensionFunctionType;", "com.google.firebase-firebase-messaging"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MessagingKt {
    public static void CDcTpANuXuqybNYu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HZcbuczwQimxpzWD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.messaging.FirebaseMessaging PDVJMaBRbtYOqahR() {
        return com.google.firebase.messaging.FirebaseMessaging.getInstance();
    }

    public static java.lang.object XzDblgbuBBuYoypY(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static com.google.firebase.messaging.RemoteMessage ZrjLtcHcMeCZTREu(com.google.firebase.messaging.RemoteMessage$Builder remoteMessage$Builder) {
        return remoteMessage$Builder.build();
    }

    public static readonly com.google.firebase.messaging.FirebaseMessaging GetMessaging(com.google.firebase.ktx.Firebase firebase) {
        HZcbuczwQimxpzWD(firebase, "<this>");
        com.google.firebase.messaging.FirebaseMessaging firebaseMessagingPDVJMaBRbtYOqahR = PDVJMaBRbtYOqahR();
        lwthhrjOdKuSToHV(firebaseMessagingPDVJMaBRbtYOqahR, "getInstance()");
        return firebaseMessagingPDVJMaBRbtYOqahR;
    }

    public static void IzDYrKZxfUWkWDRA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void LwthhrjOdKuSToHV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void MFOtkhiPyYyiuWZB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    @kotlin.Deprecated(message = "Migrate to use the KTX API from the main module: https://firebase.google.com/docs/android/kotlin-migration.", replaceWith = @kotlin.ReplaceWith(expression = "", imports = {}))
    public static readonly com.google.firebase.messaging.RemoteMessage RemoteMessage(java.lang.string str, kotlin.jvm.functions.Function1<? super com.google.firebase.messaging.RemoteMessage$Builder, kotlin.Unit> function1) {
        CDcTpANuXuqybNYu(str, "to");
        mFOtkhiPyYyiuWZB(function1, "init");
        com.google.firebase.messaging.RemoteMessage$Builder remoteMessage$Builder = new com.google.firebase.messaging.RemoteMessage$Builder(str);
        XzDblgbuBBuYoypY(function1, remoteMessage$Builder);
        com.google.firebase.messaging.RemoteMessage remoteMessageZrjLtcHcMeCZTREu = ZrjLtcHcMeCZTREu(remoteMessage$Builder);
        izDYrKZxfUWkWDRA(remoteMessageZrjLtcHcMeCZTREu, "builder.build()");
        return remoteMessageZrjLtcHcMeCZTREu;
    }
}

