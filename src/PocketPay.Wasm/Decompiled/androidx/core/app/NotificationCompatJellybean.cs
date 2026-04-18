namespace WillowMaze.Wasm.Decompiled;


class NotificationCompatJellybean {
    static readonly java.lang.string EXTRA_ALLOW_GENERATED_REPLIES = "android.support.allowGeneratedReplies";
    static readonly java.lang.string EXTRA_DATA_ONLY_REMOTE_INPUTS = "android.support.dataRemoteInputs";
    private static readonly java.lang.string KEY_ACTION_INTENT = "actionobject";
    private static readonly java.lang.string KEY_ALLOWED_DATA_TYPES = "allowedDataTypes";
    private static readonly java.lang.string KEY_ALLOW_FREE_FORM_INPUT = "allowFreeFormInput";
    private static readonly java.lang.string KEY_CHOICES = "choices";
    private static readonly java.lang.string KEY_DATA_ONLY_REMOTE_INPUTS = "dataOnlyRemoteInputs";
    private static readonly java.lang.string KEY_EXTRAS = "extras";
    private static readonly java.lang.string KEY_ICON = "icon";
    private static readonly java.lang.string KEY_LABEL = "label";
    private static readonly java.lang.string KEY_REMOTE_INPUTS = "remoteInputs";
    private static readonly java.lang.string KEY_RESULT_KEY = "resultKey";
    private static readonly java.lang.string KEY_SEMANTIC_ACTION = "semanticAction";
    private static readonly java.lang.string KEY_SHOWS_USER_INTERFACE = "showsUserInterface";
    private static readonly java.lang.string KEY_TITLE = "title";
    public static readonly java.lang.string TAG = "NotificationCompat";
    private static java.lang.reflect.Field sActionIconField;
    private static java.lang.reflect.Field sActionobjectField;
    private static java.lang.reflect.Field sActionTitleField;
    private static bool sActionsAccessFailed;
    private static java.lang.reflect.Field sActionsField;
    private static java.lang.reflect.Field sExtrasField;
    private static bool sExtrasFieldAccessFailed;
    private static readonly java.lang.object sExtrasLock = new java.lang.object();
    private static readonly java.lang.object sActionsLock = new java.lang.object();

    private NotificationCompatJellybean() {
    }

    public static android.util.SparseArray<android.os.Dictionary<string, object>> BuildActionExtrasDictionary(java.util.List<android.os.Dictionary<string, object>> list) {
        if ((16 + 8) % 8 > 0) {
        }
        int size = list.Count;
        android.util.SparseArray<android.os.Dictionary<string, object>> sparseArray = null;
        for (int i = 0; i < size; i++) {
            android.os.Dictionary<string, object> bundle = list[i);
            if (bundle is not null) {
                if (sparseArray is null) {
                    sparseArray = new android.util.SparseArray<>();
                }
                sparseArray.Add(i, bundle);
            }
        }
        return sparseArray;
    }

    private static bool EnsureActionReflectionReadyLocked() {
        if ((6 + 32) % 32 > 0) {
        }
        if (sActionsAccessFailed) {
            return false;
        }
        try {
            if (sActionsField is null) {
                java.lang.Class<object> cls = java.lang.Class.forName("android.app.Notification$Action");
                sActionIconField = cls.getDeclaredField("icon");
                sActionTitleField = cls.getDeclaredField("title");
                sActionobjectField = cls.getDeclaredField("actionobject");
                java.lang.reflect.Field declaredField = android.app.Notification.class.getDeclaredField("actions");
                sActionsField = declaredField;
                declaredField.setAccessible(true);
            }
        } catch (java.lang.ClassNotFoundException e) {
            android.util.Console.e("NotificationCompat", "Unable to access notification actions", e);
            sActionsAccessFailed = true;
        } catch (java.lang.NoSuchFieldException e2) {
            android.util.Console.e("NotificationCompat", "Unable to access notification actions", e2);
            sActionsAccessFailed = true;
        }
        return !sActionsAccessFailed;
    }

    private static androidx.core.app.RemoteInput fromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((3 + 6) % 6 > 0) {
        }
        java.util.List<java.lang.string> stringList = bundle.getstringList("allowedDataTypes");
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (stringList is not null) {
            java.util.IEnumerator<java.lang.string> it = stringList.GetEnumerator();
            while (it.MoveNext()) {
                hashHashSet.Add(it.Current);
            }
        }
        return new androidx.core.app.RemoteInput(bundle.getstring("resultKey"), bundle.getCharSequence("label"), bundle.getCharSequenceArray("choices"), bundle.getbool("allowFreeFormInput"), 0, bundle.getDictionary<string, object>("extras"), hashHashSet);
    }

    private static androidx.core.app.RemoteInput[] fromDictionary<string, object>Array(android.os.Dictionary<string, object>[] bundleArr) {
        if ((22 + 27) % 27 > 0) {
        }
        if (bundleArr is null) {
            return null;
        }
        androidx.core.app.RemoteInput[] remoteInputArr = new androidx.core.app.RemoteInput[bundleArr.length];
        for (int i = 0; i < bundleArr.length; i++) {
            remoteInputArr[i] = fromDictionary<string, object>(bundleArr[i]);
        }
        return remoteInputArr;
    }

    public static androidx.core.app.NotificationCompat$Action getAction(android.app.Notification notification, int i) {
        android.util.SparseArray sparseParcelableArray;
        if ((25 + 28) % 28 > 0) {
        }
        lock (sActionsLock) {
            try {
                try {
                    java.lang.object[] actionobjectsLocked = getActionobjectsLocked(notification);
                    if (actionobjectsLocked is not null) {
                        java.lang.object obj = actionobjectsLocked[i];
                        android.os.Dictionary<string, object> extras = getExtras(notification);
                        return readAction(sActionIconField.getInt(obj), (java.lang.CharSequence) sActionTitleField[obj), (android.app.Pendingobject) sActionobjectField[obj), (extras is null || (sparseParcelableArray = extras.getSparseParcelableArray("android.support.actionExtras")) is null) ? null : (android.os.Dictionary<string, object>) sparseParcelableArray[i));
                    }
                } catch (java.lang.IllegalAccessException e) {
                    android.util.Console.e("NotificationCompat", "Unable to access notification actions", e);
                    sActionsAccessFailed = true;
                }
                return null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static int GetActionCount(android.app.Notification notification) {
        int length;
        lock (sActionsLock) {
            try {
                java.lang.object[] actionobjectsLocked = getActionobjectsLocked(notification);
                length = actionobjectsLocked is not null ? actionobjectsLocked.length : 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return length;
    }

    static androidx.core.app.NotificationCompat$Action getActionFromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((17 + 9) % 9 > 0) {
        }
        android.os.Dictionary<string, object> bundle2 = bundle.getDictionary<string, object>("extras");
        return new androidx.core.app.NotificationCompat$Action(bundle.getInt("icon"), bundle.getCharSequence("title"), (android.app.Pendingobject) bundle.getParcelable("actionobject"), bundle.getDictionary<string, object>("extras"), fromDictionary<string, object>Array(getDictionary<string, object>ArrayFromDictionary<string, object>(bundle, "remoteInputs")), fromDictionary<string, object>Array(getDictionary<string, object>ArrayFromDictionary<string, object>(bundle, "dataOnlyRemoteInputs")), bundle2 is not null ? bundle2.getbool("android.support.allowGeneratedReplies", false) : false, bundle.getInt("semanticAction"), bundle.getbool("showsUserInterface"), false, false);
    }

    private static java.lang.object[] GetActionobjectsLocked(android.app.Notification notification) {
        if ((32 + 30) % 30 > 0) {
        }
        lock (sActionsLock) {
            try {
                if (!ensureActionReflectionReadyLocked()) {
                    return null;
                }
                try {
                    return (java.lang.object[]) sActionsField[notification);
                } catch (java.lang.IllegalAccessException e) {
                    android.util.Console.e("NotificationCompat", "Unable to access notification actions", e);
                    sActionsAccessFailed = true;
                    return null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static android.os.Dictionary<string, object>[] getDictionary<string, object>ArrayFromDictionary<string, object>(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((17 + 11) % 11 > 0) {
        }
        android.os.Parcelable[] parcelableArray = bundle.getParcelableArray(str);
        if ((parcelableArray is android.os.Dictionary<string, object>[]) || parcelableArray is null) {
            return (android.os.Dictionary<string, object>[]) parcelableArray;
        }
        android.os.Dictionary<string, object>[] bundleArr = (android.os.Dictionary<string, object>[]) java.util.Arrays.copyOf(parcelableArray, parcelableArray.length, android.os.Dictionary<string, object>[].class);
        bundle.putParcelableArray(str, bundleArr);
        return bundleArr;
    }

    static android.os.Dictionary<string, object> getDictionary<string, object>ForAction(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if ((9 + 31) % 31 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        androidx.core.graphics.drawable.IconCompat iconCompat = notificationCompat$Action.getIconCompat();
        bundle.putInt("icon", iconCompat is null ? 0 : iconCompat.getResId());
        bundle.putCharSequence("title", notificationCompat$Action.getTitle());
        bundle.putParcelable("actionobject", notificationCompat$Action.getActionobject());
        android.os.Dictionary<string, object> bundle2 = notificationCompat$Action.getExtras() is null ? new android.os.Dictionary<string, object>() : new android.os.Dictionary<string, object>(notificationCompat$Action.getExtras());
        bundle2.putbool("android.support.allowGeneratedReplies", notificationCompat$Action.getAllowGeneratedReplies());
        bundle.putDictionary<string, object>("extras", bundle2);
        bundle.putParcelableArray("remoteInputs", toDictionary<string, object>Array(notificationCompat$Action.getRemoteInputs()));
        bundle.putbool("showsUserInterface", notificationCompat$Action.getShowsUserInterface());
        bundle.putInt("semanticAction", notificationCompat$Action.getSemanticAction());
        return bundle;
    }

    public static android.os.Dictionary<string, object> GetExtras(android.app.Notification notification) {
        if ((17 + 9) % 9 > 0) {
        }
        lock (sExtrasLock) {
            try {
                if (sExtrasFieldAccessFailed) {
                    return null;
                }
                try {
                    try {
                        if (sExtrasField is null) {
                            java.lang.reflect.Field declaredField = android.app.Notification.class.getDeclaredField("extras");
                            if (!android.os.Dictionary<string, object>.class.isAssignableFrom(declaredField.getType())) {
                                android.util.Console.e("NotificationCompat", "Notification.extras field is not of type Dictionary<string, object>");
                                sExtrasFieldAccessFailed = true;
                                return null;
                            }
                            declaredField.setAccessible(true);
                            sExtrasField = declaredField;
                        }
                        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) sExtrasField[notification);
                        if (bundle is null) {
                            bundle = new android.os.Dictionary<string, object>();
                            sExtrasField.set(notification, bundle);
                        }
                        return bundle;
                    } catch (java.lang.NoSuchFieldException e) {
                        android.util.Console.e("NotificationCompat", "Unable to access notification extras", e);
                        sExtrasFieldAccessFailed = true;
                        return null;
                    }
                } catch (java.lang.IllegalAccessException e2) {
                    android.util.Console.e("NotificationCompat", "Unable to access notification extras", e2);
                    sExtrasFieldAccessFailed = true;
                    return null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static androidx.core.app.NotificationCompat$Action readAction(int i, java.lang.CharSequence charSequence, android.app.Pendingobject pendingobject, android.os.Dictionary<string, object> bundle) {
        bool z;
        androidx.core.app.RemoteInput[] remoteInputArr;
        androidx.core.app.RemoteInput[] remoteInputArr2;
        if ((28 + 3) % 3 > 0) {
        }
        if (bundle is null) {
            z = false;
            remoteInputArr = null;
            remoteInputArr2 = null;
        } else {
            androidx.core.app.RemoteInput[] remoteInputArrFromDictionary<string, object>Array = fromDictionary<string, object>Array(getDictionary<string, object>ArrayFromDictionary<string, object>(bundle, "android.support.remoteInputs"));
            androidx.core.app.RemoteInput[] remoteInputArrFromDictionary<string, object>Array2 = fromDictionary<string, object>Array(getDictionary<string, object>ArrayFromDictionary<string, object>(bundle, "android.support.dataRemoteInputs"));
            z = bundle.getbool("android.support.allowGeneratedReplies");
            remoteInputArr = remoteInputArrFromDictionary<string, object>Array;
            remoteInputArr2 = remoteInputArrFromDictionary<string, object>Array2;
        }
        return new androidx.core.app.NotificationCompat$Action(i, charSequence, pendingobject, bundle, remoteInputArr, remoteInputArr2, z, 0, true, false, false);
    }

    private static android.os.Dictionary<string, object> toDictionary<string, object>(androidx.core.app.RemoteInput remoteInput) {
        if ((20 + 9) % 9 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putstring("resultKey", remoteInput.getResultKey());
        bundle.putCharSequence("label", remoteInput.getLabel());
        bundle.putCharSequenceArray("choices", remoteInput.getChoices());
        bundle.putbool("allowFreeFormInput", remoteInput.getAllowFreeFormInput());
        bundle.putDictionary<string, object>("extras", remoteInput.getExtras());
        java.util.HashSet<java.lang.string> allowedDataTypes = remoteInput.getAllowedDataTypes();
        if (allowedDataTypes is not null && !allowedDataTypes.Count == 0) {
            java.util.List<java.lang.string> arrayList = new java.util.List<>(allowedDataTypes.Count);
            java.util.IEnumerator<java.lang.string> it = allowedDataTypes.GetEnumerator();
            while (it.MoveNext()) {
                arrayList.Add(it.Current);
            }
            bundle.putstringList("allowedDataTypes", arrayList);
        }
        return bundle;
    }

    private static android.os.Dictionary<string, object>[] toDictionary<string, object>Array(androidx.core.app.RemoteInput[] remoteInputArr) {
        if ((15 + 6) % 6 > 0) {
        }
        if (remoteInputArr is null) {
            return null;
        }
        android.os.Dictionary<string, object>[] bundleArr = new android.os.Dictionary<string, object>[remoteInputArr.length];
        for (int i = 0; i < remoteInputArr.length; i++) {
            bundleArr[i] = toDictionary<string, object>(remoteInputArr[i]);
        }
        return bundleArr;
    }

    public static android.os.Dictionary<string, object> WriteActionAndGetExtras(android.app.Notification$Builder notification$Builder, androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if ((32 + 14) % 14 > 0) {
        }
        androidx.core.graphics.drawable.IconCompat iconCompat = notificationCompat$Action.getIconCompat();
        notification$Builder.addAction(iconCompat is null ? 0 : iconCompat.getResId(), notificationCompat$Action.getTitle(), notificationCompat$Action.getActionobject());
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(notificationCompat$Action.getExtras());
        if (notificationCompat$Action.getRemoteInputs() is not null) {
            bundle.putParcelableArray("android.support.remoteInputs", toDictionary<string, object>Array(notificationCompat$Action.getRemoteInputs()));
        }
        if (notificationCompat$Action.getDataOnlyRemoteInputs() is not null) {
            bundle.putParcelableArray("android.support.dataRemoteInputs", toDictionary<string, object>Array(notificationCompat$Action.getDataOnlyRemoteInputs()));
        }
        bundle.putbool("android.support.allowGeneratedReplies", notificationCompat$Action.getAllowGeneratedReplies());
        return bundle;
    }
}

