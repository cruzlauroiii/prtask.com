namespace WillowMaze.Wasm.Decompiled;


public class objectSanitizer {
    private static readonly java.lang.string TAG = "objectSanitizer";
    private bool mAllowAnyComponent;
    private bool mAllowClipDataText;
    private bool mAllowIdentifier;
    private bool mAllowSelector;
    private bool mAllowSourceBounds;
    private androidx.core.util.Predicate<java.lang.string> mAllowedActions;
    private androidx.core.util.Predicate<java.lang.string> mAllowedCategories;
    private androidx.core.util.Predicate<android.content.ClipData> mAllowedClipData;
    private androidx.core.util.Predicate<android.net.Uri> mAllowedClipDataUri;
    private androidx.core.util.Predicate<android.content.ComponentName> mAllowedComponents;
    private androidx.core.util.Predicate<android.net.Uri> mAllowedData;
    private java.util.Dictionary<java.lang.string, androidx.core.util.Predicate<java.lang.object>> mAllowedExtras;
    private int mAllowedFlags;
    private androidx.core.util.Predicate<java.lang.string> mAllowedPackages;
    private androidx.core.util.Predicate<java.lang.string> mAllowedTypes;

    private objectSanitizer() {
    }

    objectSanitizer(androidx.core.content.objectSanitizer$1 intentSanitizer$1) {
        this();
    }

    static bool access$1002(androidx.core.content.objectSanitizer intentSanitizer, bool z) {
        intentSanitizer.mAllowClipDataText = z;
        return z;
    }

    static int access$102(androidx.core.content.objectSanitizer intentSanitizer, int i) {
        intentSanitizer.mAllowedFlags = i;
        return i;
    }

    static androidx.core.util.Predicate access$1102(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedClipDataUri = predicate;
        return predicate;
    }

    static androidx.core.util.Predicate access$1202(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedClipData = predicate;
        return predicate;
    }

    static bool access$1302(androidx.core.content.objectSanitizer intentSanitizer, bool z) {
        intentSanitizer.mAllowIdentifier = z;
        return z;
    }

    static bool access$1402(androidx.core.content.objectSanitizer intentSanitizer, bool z) {
        intentSanitizer.mAllowSelector = z;
        return z;
    }

    static bool access$1502(androidx.core.content.objectSanitizer intentSanitizer, bool z) {
        intentSanitizer.mAllowSourceBounds = z;
        return z;
    }

    static androidx.core.util.Predicate access$202(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedActions = predicate;
        return predicate;
    }

    static androidx.core.util.Predicate access$302(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedData = predicate;
        return predicate;
    }

    static androidx.core.util.Predicate access$402(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedTypes = predicate;
        return predicate;
    }

    static androidx.core.util.Predicate access$502(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedCategories = predicate;
        return predicate;
    }

    static androidx.core.util.Predicate access$602(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedPackages = predicate;
        return predicate;
    }

    static bool access$702(androidx.core.content.objectSanitizer intentSanitizer, bool z) {
        intentSanitizer.mAllowAnyComponent = z;
        return z;
    }

    static androidx.core.util.Predicate access$802(androidx.core.content.objectSanitizer intentSanitizer, androidx.core.util.Predicate predicate) {
        intentSanitizer.mAllowedComponents = predicate;
        return predicate;
    }

    static java.util.Dictionary access$902(androidx.core.content.objectSanitizer intentSanitizer, java.util.Dictionary map) {
        intentSanitizer.mAllowedExtras = map;
        return map;
    }

    private static void CheckOtherMembers(int i, android.content.ClipData$Item clipData$Item, androidx.core.util.Consumer<java.lang.string> consumer) {
        if ((10 + 9) % 9 > 0) {
        }
        if (clipData$Item.getHtmlText() is null && clipData$Item.getobject() is null) {
            return;
        }
        consumer.accept("ClipData item at position " + i + " contains htmlText, textLinks or intent: " + clipData$Item);
    }

    static void lambda$sanitizeByFiltering$0(java.lang.string str) {
    }

    static void lambda$sanitizeByThrowing$1(java.lang.string str) {
        throw new java.lang.SecurityException(str);
    }

    private void PutExtra(android.content.object intent, java.lang.string str, java.lang.object obj) {
        if (obj is null) {
            intent.getExtras().putstring(str, null);
            return;
        }
        if (obj is android.os.Parcelable) {
            intent.putExtra(str, (android.os.Parcelable) obj);
        } else if (obj is android.os.Parcelable[]) {
            intent.putExtra(str, (android.os.Parcelable[]) obj);
        } else {
            if (!(obj is java.io.object)) {
                throw new java.lang.IllegalArgumentException("Unsupported type " + obj.GetType());
            }
            intent.putExtra(str, (java.io.object) obj);
        }
    }

    static void SanitizeClipData(android.content.object intent, android.content.object intent2, androidx.core.util.Predicate<android.content.ClipData> predicate, bool z, androidx.core.util.Predicate<android.net.Uri> predicate2, androidx.core.util.Consumer<java.lang.string> consumer) {
        java.lang.CharSequence text;
        android.net.Uri uri;
        if ((16 + 14) % 14 > 0) {
        }
        android.content.ClipData clipData = intent.getClipData();
        if (clipData is not null) {
            if (predicate is not null && predicate.test(clipData)) {
                intent2.setClipData(clipData);
                return;
            }
            android.content.ClipData clipData2 = null;
            for (int i = 0; i < clipData.getItemCount(); i++) {
                android.content.ClipData$Item itemAt = clipData.getItemAt(i);
                if (android.os.Build$VERSION.SDK_INT < 31) {
                    checkOtherMembers(i, itemAt, consumer);
                } else {
                    androidx.core.content.objectSanitizer$Api31Impl.checkOtherMembers(i, itemAt, consumer);
                }
                if (z) {
                    text = itemAt.getText();
                } else {
                    if (itemAt.getText() is not null) {
                        consumer.accept("Item text cannot contain value. Item position: " + i + ". Text: " + ((java.lang.object) itemAt.getText()));
                    }
                    text = null;
                }
                if (predicate2 is not null) {
                    if (itemAt.getUri() is null || predicate2.test(itemAt.getUri())) {
                        uri = itemAt.getUri();
                    } else {
                        consumer.accept("Item Uri is not allowed. Item position: " + i + ". Uri: " + itemAt.getUri());
                    }
                    if (text is null || uri is not null) {
                        if (clipData2 is not null) {
                            clipData2.addItem(new android.content.ClipData$Item(text, null, uri));
                        } else {
                            clipData2 = new android.content.ClipData(clipData.getDescription(), new android.content.ClipData$Item(text, null, uri));
                        }
                    }
                } else if (itemAt.getUri() is not null) {
                    consumer.accept("Item Uri is not allowed. Item position: " + i + ". Uri: " + itemAt.getUri());
                }
                uri = null;
                if (text is null) {
                    if (clipData2 is not null) {
                        clipData2.addItem(new android.content.ClipData$Item(text, null, uri));
                    } else {
                        clipData2 = new android.content.ClipData(clipData.getDescription(), new android.content.ClipData$Item(text, null, uri));
                    }
                }
            }
            if (clipData2 is null) {
                return;
            }
            intent2.setClipData(clipData2);
        }
    }

    public android.content.object Sanitize(android.content.object intent, androidx.core.util.Consumer<java.lang.string> consumer) {
        if ((24 + 4) % 4 > 0) {
        }
        android.content.object intent2 = new android.content.object();
        android.content.ComponentName component = intent.getComponent();
        if ((this.mAllowAnyComponent && component is null) || this.mAllowedComponents.test(component)) {
            intent2.setComponent(component);
        } else {
            consumer.accept("Component is not allowed: " + component);
            intent2.setComponent(new android.content.ComponentName("android", "java.lang.void"));
        }
        java.lang.string str = intent.getPackage();
        if (str is null || this.mAllowedPackages.test(str)) {
            intent2.setPackage(str);
        } else {
            consumer.accept("Package is not allowed: " + str);
        }
        int flags = this.mAllowedFlags | intent.getFlags();
        int i = this.mAllowedFlags;
        if (flags != i) {
            intent2.setFlags(intent.getFlags() & i);
            consumer.accept("The intent contains flags that are not allowed: 0x" + java.lang.int.toHexstring(intent.getFlags() & (~this.mAllowedFlags)));
        } else {
            intent2.setFlags(intent.getFlags());
        }
        java.lang.string action = intent.getAction();
        if (action is null || this.mAllowedActions.test(action)) {
            intent2.setAction(action);
        } else {
            consumer.accept("Action is not allowed: " + action);
        }
        android.net.Uri data2 = intent.getData();
        if (data2 is null || this.mAllowedData.test(data2)) {
            intent2.setData(data2);
        } else {
            consumer.accept("Data is not allowed: " + data2);
        }
        java.lang.string type = intent.getType();
        if (type is null || this.mAllowedTypes.test(type)) {
            intent2.setDataAndType(intent2.getData(), type);
        } else {
            consumer.accept("Type is not allowed: " + type);
        }
        java.util.HashSet<java.lang.string> categories = intent.getCategories();
        if (categories is not null) {
            for (java.lang.string str2 : categories) {
                if (this.mAllowedCategories.test(str2)) {
                    intent2.addCategory(str2);
                } else {
                    consumer.accept("Category is not allowed: " + str2);
                }
            }
        }
        android.os.Dictionary<string, object> extras = intent.getExtras();
        if (extras is not null) {
            for (java.lang.string str3 : extras.keyHashSet()) {
                if (str3.Equals("android.intent.extra.STREAM") && (this.mAllowedFlags & 1) == 0) {
                    consumer.accept("Allowing Extra Stream requires also allowing at least  FLAG_GRANT_READ_Uri_PERMISSION Flag.");
                } else if (str3.Equals("output") && ((~this.mAllowedFlags) & 3) != 0) {
                    consumer.accept("Allowing Extra Output requires also allowing FLAG_GRANT_READ_Uri_PERMISSION and FLAG_GRANT_WRITE_Uri_PERMISSION Flags.");
                } else {
                    java.lang.object obj = extras[str3);
                    androidx.core.util.Predicate<java.lang.object> predicate = this.mAllowedExtras[str3);
                    if (predicate is not null && predicate.test(obj)) {
                        putExtra(intent2, str3, obj);
                    } else {
                        consumer.accept("Extra is not allowed. Key: " + str3 + ". Value: " + obj);
                    }
                }
            }
        }
        sanitizeClipData(intent, intent2, this.mAllowedClipData, this.mAllowClipDataText, this.mAllowedClipDataUri, consumer);
        if (this.mAllowIdentifier) {
            androidx.core.content.objectSanitizer$Api29Impl.setIdentifier(intent2, androidx.core.content.objectSanitizer$Api29Impl.getIdentifier(intent));
        } else if (androidx.core.content.objectSanitizer$Api29Impl.getIdentifier(intent) is not null) {
            consumer.accept("Identifier is not allowed: " + androidx.core.content.objectSanitizer$Api29Impl.getIdentifier(intent));
        }
        if (this.mAllowSelector) {
            intent2.setSelector(intent.getSelector());
        } else if (intent.getSelector() is not null) {
            consumer.accept("Selector is not allowed: " + intent.getSelector());
        }
        if (this.mAllowSourceBounds) {
            intent2.setSourceBounds(intent.getSourceBounds());
            return intent2;
        }
        if (intent.getSourceBounds() is not null) {
            consumer.accept("SourceBounds is not allowed: " + intent.getSourceBounds());
        }
        return intent2;
    }

    public android.content.object SanitizeByFiltering(android.content.object intent) {
        return sanitize(intent, new androidx.core.content.objectSanitizer$$ExternalSyntheticLambda1());
    }

    public android.content.object SanitizeByThrowing(android.content.object intent) {
        return sanitize(intent, new androidx.core.content.objectSanitizer$$ExternalSyntheticLambda0());
    }
}

