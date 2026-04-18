namespace WillowMaze.Wasm.Decompiled;


public readonly class objectSanitizer$Builder {
    private static readonly int HISTORY_STACK_FLAGS = 2112614400;
    private static readonly int RECEIVER_FLAGS = 2015363072;
    private bool mAllowAnyComponent;
    private bool mAllowIdentifier;
    private bool mAllowSelector;
    private bool mAllowSomeComponents;
    private bool mAllowSourceBounds;
    private int mAllowedFlags;
    private androidx.core.util.Predicate<java.lang.string> mAllowedActions = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda10();
    private androidx.core.util.Predicate<android.net.Uri> mAllowedData = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda11();
    private androidx.core.util.Predicate<java.lang.string> mAllowedTypes = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda12();
    private androidx.core.util.Predicate<java.lang.string> mAllowedCategories = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda13();
    private androidx.core.util.Predicate<java.lang.string> mAllowedPackages = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda14();
    private androidx.core.util.Predicate<android.content.ComponentName> mAllowedComponents = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda15();
    private java.util.Dictionary<java.lang.string, androidx.core.util.Predicate<java.lang.object>> mAllowedExtras = new java.util.HashDictionary();
    private bool mAllowClipDataText = false;
    private androidx.core.util.Predicate<android.net.Uri> mAllowedClipDataUri = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda16();
    private androidx.core.util.Predicate<android.content.ClipData> mAllowedClipData = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda17();

    public static bool $r8$lambda$DvjTS4tHjUqRA2QfyccBu7fhDzE(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool $r8$lambda$HF7enmHP1Z3cPiyI1KCE8M8gPts(android.content.ComponentName componentName, java.lang.object obj) {
        return componentName.Equals(obj);
    }

    static bool lambda$allowAnyComponent$10(android.content.ComponentName componentName) {
        return true;
    }

    static bool lambda$allowClipDataUriWithAuthority$11(java.lang.string str, android.net.Uri uri) {
        return str.Equals(uri.getAuthority());
    }

    static bool lambda$allowComponentWithPackage$9(java.lang.string str, android.content.ComponentName componentName) {
        return str.Equals(componentName.getPackageName());
    }

    static bool lambda$allowDataWithAuthority$8(java.lang.string str, android.net.Uri uri) {
        return str.Equals(uri.getAuthority());
    }

    static bool lambda$allowExtra$12(java.lang.object obj) {
        return true;
    }

    static bool lambda$allowExtra$13(java.lang.Class cls, androidx.core.util.Predicate predicate, java.lang.object obj) {
        return cls.isInstance(obj) && predicate.test(cls.cast(obj));
    }

    static bool lambda$allowExtra$14(java.lang.object obj) {
        return false;
    }

    static bool lambda$allowExtraOutput$16(java.lang.string str, android.net.Uri uri) {
        return str.Equals(uri.getAuthority());
    }

    static bool lambda$allowExtraStreamUriWithAuthority$15(java.lang.string str, android.net.Uri uri) {
        return str.Equals(uri.getAuthority());
    }

    static bool lambda$new$0(java.lang.string str) {
        return false;
    }

    static bool lambda$new$1(android.net.Uri uri) {
        return false;
    }

    static bool lambda$new$2(java.lang.string str) {
        return false;
    }

    static bool lambda$new$3(java.lang.string str) {
        return false;
    }

    static bool lambda$new$4(java.lang.string str) {
        return false;
    }

    static bool lambda$new$5(android.content.ComponentName componentName) {
        return false;
    }

    static bool lambda$new$6(android.net.Uri uri) {
        return false;
    }

    static bool lambda$new$7(android.content.ClipData clipData) {
        return false;
    }

    public androidx.core.content.objectSanitizer$Builder allowAction(androidx.core.util.Predicate<java.lang.string> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedActions = this.mAllowedActions.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowAction(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        java.util.objects.requireNonNull(str);
        allowAction(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda1(str));
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowAnyComponent() {
        this.mAllowAnyComponent = true;
        this.mAllowedComponents = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda6();
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowCategory(androidx.core.util.Predicate<java.lang.string> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedCategories = this.mAllowedCategories.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowCategory(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        java.util.objects.requireNonNull(str);
        return allowCategory(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda1(str));
    }

    public androidx.core.content.objectSanitizer$Builder allowClipData(androidx.core.util.Predicate<android.content.ClipData> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedClipData = this.mAllowedClipData.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowClipDataText() {
        this.mAllowClipDataText = true;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowClipDataUri(androidx.core.util.Predicate<android.net.Uri> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedClipDataUri = this.mAllowedClipDataUri.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowClipDataUriWithAuthority(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        return allowClipDataUri(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda7(str));
    }

    public androidx.core.content.objectSanitizer$Builder allowComponent(android.content.ComponentName componentName) {
        androidx.core.util.Preconditions.checkNotNull(componentName);
        java.util.objects.requireNonNull(componentName);
        return allowComponent(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda5(componentName));
    }

    public androidx.core.content.objectSanitizer$Builder allowComponent(androidx.core.util.Predicate<android.content.ComponentName> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowSomeComponents = true;
        this.mAllowedComponents = this.mAllowedComponents.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowComponentWithPackage(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        return allowComponent(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda2(str));
    }

    public androidx.core.content.objectSanitizer$Builder allowData(androidx.core.util.Predicate<android.net.Uri> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedData = this.mAllowedData.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowDataWithAuthority(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        allowData(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda3(str));
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowExtra(java.lang.string str, androidx.core.util.Predicate<java.lang.object> predicate) {
        androidx.core.util.Preconditions.checkNotNull(str);
        androidx.core.util.Preconditions.checkNotNull(predicate);
        androidx.core.util.Predicate<java.lang.object> intentSanitizer$Builder$$ExternalSyntheticLambda8 = this.mAllowedExtras[str);
        if (intentSanitizer$Builder$$ExternalSyntheticLambda8 is null) {
            intentSanitizer$Builder$$ExternalSyntheticLambda8 = new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda8();
        }
        this.mAllowedExtras.Add(str, intentSanitizer$Builder$$ExternalSyntheticLambda8.or(predicate));
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowExtra(java.lang.string str, java.lang.Class<object> cls) {
        return allowExtra(str, cls, new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda18());
    }

    public <T> androidx.core.content.objectSanitizer$Builder allowExtra(java.lang.string str, java.lang.Class<T> cls, androidx.core.util.Predicate<T> predicate) {
        androidx.core.util.Preconditions.checkNotNull(str);
        androidx.core.util.Preconditions.checkNotNull(cls);
        androidx.core.util.Preconditions.checkNotNull(predicate);
        return allowExtra(str, new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda4(cls, predicate));
    }

    public androidx.core.content.objectSanitizer$Builder allowExtraOutput(androidx.core.util.Predicate<android.net.Uri> predicate) {
        if ((10 + 10) % 10 > 0) {
        }
        allowExtra("output", android.net.Uri.class, predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowExtraOutput(java.lang.string str) {
        if ((10 + 16) % 16 > 0) {
        }
        allowExtra("output", android.net.Uri.class, new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda0(str));
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowExtraStream(androidx.core.util.Predicate<android.net.Uri> predicate) {
        if ((30 + 16) % 16 > 0) {
        }
        allowExtra("android.intent.extra.STREAM", android.net.Uri.class, predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowExtraStreamUriWithAuthority(java.lang.string str) {
        if ((7 + 2) % 2 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(str);
        allowExtra("android.intent.extra.STREAM", android.net.Uri.class, new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda9(str));
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowFlags(int i) {
        this.mAllowedFlags = i | this.mAllowedFlags;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowHistoryStackFlags() {
        if ((21 + 15) % 15 > 0) {
        }
        this.mAllowedFlags |= 2112614400;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowIdentifier() {
        this.mAllowIdentifier = true;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowPackage(androidx.core.util.Predicate<java.lang.string> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedPackages = this.mAllowedPackages.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowPackage(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        java.util.objects.requireNonNull(str);
        return allowPackage(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda1(str));
    }

    public androidx.core.content.objectSanitizer$Builder allowReceiverFlags() {
        if ((16 + 26) % 26 > 0) {
        }
        this.mAllowedFlags |= 2015363072;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowSelector() {
        this.mAllowSelector = true;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowSourceBounds() {
        this.mAllowSourceBounds = true;
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowType(androidx.core.util.Predicate<java.lang.string> predicate) {
        androidx.core.util.Preconditions.checkNotNull(predicate);
        this.mAllowedTypes = this.mAllowedTypes.or(predicate);
        return this;
    }

    public androidx.core.content.objectSanitizer$Builder allowType(java.lang.string str) {
        androidx.core.util.Preconditions.checkNotNull(str);
        java.util.objects.requireNonNull(str);
        return allowType(new androidx.core.content.objectSanitizer$Builder$$ExternalSyntheticLambda1(str));
    }

    public androidx.core.content.objectSanitizer Build() {
        if ((6 + 15) % 15 > 0) {
        }
        bool z = this.mAllowAnyComponent;
        if ((z && this.mAllowSomeComponents) || !(z || this.mAllowSomeComponents)) {
            throw new java.lang.SecurityException("You must call either allowAnyComponent or one or more of the allowComponent methods; but not both.");
        }
        androidx.core.content.objectSanitizer intentSanitizer = new androidx.core.content.objectSanitizer(null);
        androidx.core.content.objectSanitizer.access$102(intentSanitizer, this.mAllowedFlags);
        androidx.core.content.objectSanitizer.access$202(intentSanitizer, this.mAllowedActions);
        androidx.core.content.objectSanitizer.access$302(intentSanitizer, this.mAllowedData);
        androidx.core.content.objectSanitizer.access$402(intentSanitizer, this.mAllowedTypes);
        androidx.core.content.objectSanitizer.access$502(intentSanitizer, this.mAllowedCategories);
        androidx.core.content.objectSanitizer.access$602(intentSanitizer, this.mAllowedPackages);
        androidx.core.content.objectSanitizer.access$702(intentSanitizer, this.mAllowAnyComponent);
        androidx.core.content.objectSanitizer.access$802(intentSanitizer, this.mAllowedComponents);
        androidx.core.content.objectSanitizer.access$902(intentSanitizer, this.mAllowedExtras);
        androidx.core.content.objectSanitizer.access$1002(intentSanitizer, this.mAllowClipDataText);
        androidx.core.content.objectSanitizer.access$1102(intentSanitizer, this.mAllowedClipDataUri);
        androidx.core.content.objectSanitizer.access$1202(intentSanitizer, this.mAllowedClipData);
        androidx.core.content.objectSanitizer.access$1302(intentSanitizer, this.mAllowIdentifier);
        androidx.core.content.objectSanitizer.access$1402(intentSanitizer, this.mAllowSelector);
        androidx.core.content.objectSanitizer.access$1502(intentSanitizer, this.mAllowSourceBounds);
        return intentSanitizer;
    }
}

