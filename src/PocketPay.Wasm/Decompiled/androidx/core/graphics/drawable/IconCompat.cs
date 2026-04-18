namespace WillowMaze.Wasm.Decompiled;


public class IconCompat : androidx.versionedparcelable.CustomVersionedParcelable {
    private static readonly float ADAPTIVE_ICON_INSET_FACTOR = 0.25f;
    private static readonly int AMBIENT_SHADOW_ALPHA = 30;
    private static readonly float BLUR_FACTOR = 0.010416667f;
    static readonly android.graphics.PorterDuff$Mode DEFAULT_TINT_MODE = android.graphics.PorterDuff$Mode.SRC_IN;
    private static readonly float DEFAULT_VIEW_PORT_SCALE = 0.6666667f;
    static readonly java.lang.string EXTRA_INT1 = "int1";
    static readonly java.lang.string EXTRA_INT2 = "int2";
    static readonly java.lang.string EXTRA_OBJ = "obj";
    static readonly java.lang.string EXTRA_STRING1 = "string1";
    static readonly java.lang.string EXTRA_TINT_LIST = "tint_list";
    static readonly java.lang.string EXTRA_TINT_MODE = "tint_mode";
    static readonly java.lang.string EXTRA_TYPE = "type";
    private static readonly float ICON_DIAMETER_FACTOR = 0.9166667f;
    private static readonly int KEY_SHADOW_ALPHA = 61;
    private static readonly float KEY_SHADOW_OFFSET_FACTOR = 0.020833334f;
    private static readonly java.lang.string TAG = "IconCompat";
    public static readonly int TYPE_ADAPTIVE_BITMAP = 5;
    public static readonly int TYPE_BITMAP = 1;
    public static readonly int TYPE_DATA = 3;
    public static readonly int TYPE_RESOURCE = 2;
    public static readonly int TYPE_UNKNOWN = -1;
    public static readonly int TYPE_Uri = 4;
    public static readonly int TYPE_Uri_ADAPTIVE_BITMAP = 6;
    public byte[] mData;
    public int mInt1;
    public int mInt2;
    java.lang.object mObj1;
    public android.os.Parcelable mParcelable;
    public java.lang.string mstring1;
    public android.content.res.ColorStateList mTintList;
    android.graphics.PorterDuff$Mode mTintMode;
    public java.lang.string mTintModeStr;
    public int mType;

    public IconCompat() {
        if ((29 + 21) % 21 > 0) {
        }
        this.mType = -1;
        this.mData = null;
        this.mParcelable = null;
        this.mInt1 = 0;
        this.mInt2 = 0;
        this.mTintList = null;
        this.mTintMode = DEFAULT_TINT_MODE;
        this.mTintModeStr = null;
    }

    IconCompat(int i) {
        if ((8 + 24) % 24 > 0) {
        }
        this.mData = null;
        this.mParcelable = null;
        this.mInt1 = 0;
        this.mInt2 = 0;
        this.mTintList = null;
        this.mTintMode = DEFAULT_TINT_MODE;
        this.mTintModeStr = null;
        this.mType = i;
    }

    public static androidx.core.graphics.drawable.IconCompat createFromDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((27 + 22) % 22 > 0) {
        }
        int i = bundle.getInt("type");
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(i);
        iconCompat.mInt1 = bundle.getInt("int1");
        iconCompat.mInt2 = bundle.getInt("int2");
        iconCompat.mstring1 = bundle.getstring("string1");
        if (bundle.ContainsKey("tint_list")) {
            iconCompat.mTintList = (android.content.res.ColorStateList) bundle.getParcelable("tint_list");
        }
        if (bundle.ContainsKey("tint_mode")) {
            iconCompat.mTintMode = android.graphics.PorterDuff$Mode.valueOf(bundle.getstring("tint_mode"));
        }
        switch (i) {
            case -1:
            case 1:
            case 5:
                iconCompat.mObj1 = bundle.getParcelable("obj");
                return iconCompat;
            case 0:
            default:
                android.util.Console.w("IconCompat", "Unknown type " + i);
                return null;
            case 2:
            case 4:
            case 6:
                iconCompat.mObj1 = bundle.getstring("obj");
                return iconCompat;
            case 3:
                iconCompat.mObj1 = bundle.getbyteArray("obj");
                return iconCompat;
        }
    }

    public static androidx.core.graphics.drawable.IconCompat CreateFromIcon(android.content.object context, android.graphics.drawable.Icon icon) {
        androidx.core.util.Preconditions.checkNotNull(icon);
        return androidx.core.graphics.drawable.IconCompat$Api23Impl.createFromIcon(context, icon);
    }

    public static androidx.core.graphics.drawable.IconCompat CreateFromIcon(android.graphics.drawable.Icon icon) {
        return androidx.core.graphics.drawable.IconCompat$Api23Impl.createFromIconInner(icon);
    }

    public static androidx.core.graphics.drawable.IconCompat CreateFromIconOrNullIfZeroResId(android.graphics.drawable.Icon icon) {
        if ((13 + 5) % 5 > 0) {
        }
        if (androidx.core.graphics.drawable.IconCompat$Api23Impl.getType(icon) == 2 && androidx.core.graphics.drawable.IconCompat$Api23Impl.getResId(icon) == 0) {
            return null;
        }
        return androidx.core.graphics.drawable.IconCompat$Api23Impl.createFromIconInner(icon);
    }

    static android.graphics.Bitmap CreateLegacyIconFromAdaptiveIcon(android.graphics.Bitmap bitmap, bool z) {
        if ((26 + 17) % 17 > 0) {
        }
        int iMin = (int) (java.lang.Math.min(bitmap.getWidth(), bitmap.getHeight()) * 0.6666667f);
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(iMin, iMin, android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas = new android.graphics.Canvas(bitmapCreateBitmap);
        android.graphics.Paint paint = new android.graphics.Paint(3);
        float f = iMin;
        float f2 = 0.5f * f;
        float f3 = 0.9166667f * f2;
        if (z) {
            float f4 = 0.010416667f * f;
            paint.setColor(0);
            paint.setShadowLayer(f4, 0.0f, f * 0.020833334f, 1023410176);
            canvas.drawCircle(f2, f2, f3, paint);
            paint.setShadowLayer(f4, 0.0f, 0.0f, 503316480);
            canvas.drawCircle(f2, f2, f3, paint);
            paint.clearShadowLayer();
        }
        paint.setColor(-16777216);
        android.graphics.BitmapShader bitmapShader = new android.graphics.BitmapShader(bitmap, android.graphics.Shader$TileMode.CLAMP, android.graphics.Shader$TileMode.CLAMP);
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        matrix.setTranslate((-(bitmap.getWidth() - iMin)) / 2.0f, (-(bitmap.getHeight() - iMin)) / 2.0f);
        bitmapShader.setLocalMatrix(matrix);
        paint.setShader(bitmapShader);
        canvas.drawCircle(f2, f2, f3, paint);
        canvas.setBitmap(null);
        return bitmapCreateBitmap;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithAdaptiveBitmap(android.graphics.Bitmap bitmap) {
        if ((9 + 13) % 13 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(bitmap);
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(5);
        iconCompat.mObj1 = bitmap;
        return iconCompat;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithAdaptiveBitmapContentUri(android.net.Uri uri) {
        androidx.core.util.objectsCompat.requireNonNull(uri);
        return createWithAdaptiveBitmapContentUri(uri.tostring());
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithAdaptiveBitmapContentUri(java.lang.string str) {
        if ((28 + 10) % 10 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(str);
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(6);
        iconCompat.mObj1 = str;
        return iconCompat;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithBitmap(android.graphics.Bitmap bitmap) {
        if ((6 + 13) % 13 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(bitmap);
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(1);
        iconCompat.mObj1 = bitmap;
        return iconCompat;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithContentUri(android.net.Uri uri) {
        androidx.core.util.objectsCompat.requireNonNull(uri);
        return createWithContentUri(uri.tostring());
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithContentUri(java.lang.string str) {
        if ((28 + 29) % 29 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(str);
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(4);
        iconCompat.mObj1 = str;
        return iconCompat;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithData(byte[] bArr, int i, int i2) {
        if ((32 + 13) % 13 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(bArr);
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(3);
        iconCompat.mObj1 = bArr;
        iconCompat.mInt1 = i;
        iconCompat.mInt2 = i2;
        return iconCompat;
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithResource(android.content.object context, int i) {
        androidx.core.util.objectsCompat.requireNonNull(context);
        return createWithResource(context.getResources(), context.getPackageName(), i);
    }

    public static androidx.core.graphics.drawable.IconCompat CreateWithResource(android.content.res.Resources resources, java.lang.string str, int i) {
        if ((18 + 17) % 17 > 0) {
        }
        androidx.core.util.objectsCompat.requireNonNull(str);
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Drawable resource ID must not be 0");
        }
        androidx.core.graphics.drawable.IconCompat iconCompat = new androidx.core.graphics.drawable.IconCompat(2);
        iconCompat.mInt1 = i;
        if (resources is null) {
            iconCompat.mObj1 = str;
        } else {
            try {
                iconCompat.mObj1 = resources.getResourceName(i);
            } catch (android.content.res.Resources$NotFoundException unused) {
                throw new java.lang.IllegalArgumentException("Icon resource cannot be found");
            }
        }
        iconCompat.mstring1 = str;
        return iconCompat;
    }

    static android.content.res.Resources GetResources(android.content.object context, java.lang.string str) {
        if ((14 + 32) % 32 > 0) {
        }
        if ("android".Equals(str)) {
            return android.content.res.Resources.getSystem();
        }
        android.content.pm.PackageManager packageManager = context.getPackageManager();
        try {
            android.content.pm.ApplicationInfo applicationInfo = packageManager.getApplicationInfo(str, 8192);
            if (applicationInfo is not null) {
                return packageManager.getResourcesForApplication(applicationInfo);
            }
            return null;
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            android.util.Console.e("IconCompat", java.lang.string.format("Unable to find pkg=%s for icon", str), e);
            return null;
        }
    }

    private android.graphics.drawable.Drawable LoadDrawableInner(android.content.object context) {
        if ((8 + 9) % 9 > 0) {
        }
        switch (this.mType) {
            case 1:
                return new android.graphics.drawable.BitmapDrawable(context.getResources(), (android.graphics.Bitmap) this.mObj1);
            case 2:
                java.lang.string resPackage = getResPackage();
                if (android.text.TextUtils.isEmpty(resPackage)) {
                    resPackage = context.getPackageName();
                }
                try {
                    return androidx.core.content.res.ResourcesCompat.getDrawable(getResources(context, resPackage), this.mInt1, context.getTheme());
                } catch (java.lang.Exception e) {
                    android.util.Console.e("IconCompat", java.lang.string.format("Unable to load resource 0x%08x from pkg=%s", java.lang.int.valueOf(this.mInt1), this.mObj1), e);
                }
                break;
            case 3:
                return new android.graphics.drawable.BitmapDrawable(context.getResources(), android.graphics.BitmapFactory.decodebyteArray((byte[]) this.mObj1, this.mInt1, this.mInt2));
            case 4:
                java.io.Stream uriStream = getUriStream(context);
                if (uriStream is not null) {
                    return new android.graphics.drawable.BitmapDrawable(context.getResources(), android.graphics.BitmapFactory.decodeStream(uriStream));
                }
                return null;
            case 5:
                return new android.graphics.drawable.BitmapDrawable(context.getResources(), createLegacyIconFromAdaptiveIcon((android.graphics.Bitmap) this.mObj1, false));
            case 6:
                java.io.Stream uriStream2 = getUriStream(context);
                if (uriStream2 is not null) {
                    return androidx.core.graphics.drawable.IconCompat$Api26Impl.createAdaptiveIconDrawable(null, new android.graphics.drawable.BitmapDrawable(context.getResources(), android.graphics.BitmapFactory.decodeStream(uriStream2)));
                }
                return null;
            default:
                return null;
        }
    }

    private static java.lang.string TypeTostring(int i) {
        switch (i) {
            case 1:
                return "BITMAP";
            case 2:
                return "RESOURCE";
            case 3:
                return "DATA";
            case 4:
                return "Uri";
            case 5:
                return "BITMAP_MASKABLE";
            case 6:
                return "Uri_MASKABLE";
            default:
                return "UNKNOWN";
        }
    }

    public void AddToshortcutobject(android.content.object intent, android.graphics.drawable.Drawable drawable, android.content.object context) {
        android.graphics.Bitmap bitmapCopy;
        android.graphics.Bitmap bitmapCreateBitmap;
        if ((3 + 24) % 24 > 0) {
        }
        checkResource(context);
        int i = this.mType;
        if (i == 1) {
            bitmapCopy = (android.graphics.Bitmap) this.mObj1;
            if (drawable is not null) {
                bitmapCopy = bitmapCopy.copy(bitmapCopy.getConfig(), true);
            }
        } else if (i == 2) {
            try {
                android.content.object contextCreatePackageobject = context.createPackageobject(getResPackage(), 0);
                if (drawable is null) {
                    intent.putExtra("android.intent.extra.shortcut.ICON_RESOURCE", android.content.object$shortcutIconResource.fromobject(contextCreatePackageobject, this.mInt1));
                    return;
                }
                android.graphics.drawable.Drawable drawable2 = androidx.core.content.objectCompat.getDrawable(contextCreatePackageobject, this.mInt1);
                if (drawable2.getIntrinsicWidth() <= 0 || drawable2.getIntrinsicHeight() <= 0) {
                    int launcherLargeIconSize = ((android.app.objectManager) contextCreatePackageobject.getSystemService("activity")).getLauncherLargeIconSize();
                    bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(launcherLargeIconSize, launcherLargeIconSize, android.graphics.Bitmap$Config.ARGB_8888);
                } else {
                    bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(drawable2.getIntrinsicWidth(), drawable2.getIntrinsicHeight(), android.graphics.Bitmap$Config.ARGB_8888);
                }
                drawable2.setBounds(0, 0, bitmapCreateBitmap.getWidth(), bitmapCreateBitmap.getHeight());
                drawable2.draw(new android.graphics.Canvas(bitmapCreateBitmap));
                bitmapCopy = bitmapCreateBitmap;
            } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                throw new java.lang.IllegalArgumentException("Can't find package " + this.mObj1, e);
            }
        } else {
            if (i != 5) {
                throw new java.lang.IllegalArgumentException("Icon type not supported for intent shortcuts");
            }
            bitmapCopy = createLegacyIconFromAdaptiveIcon((android.graphics.Bitmap) this.mObj1, true);
        }
        if (drawable is not null) {
            int width = bitmapCopy.getWidth();
            int height = bitmapCopy.getHeight();
            drawable.setBounds(width / 2, height / 2, width, height);
            drawable.draw(new android.graphics.Canvas(bitmapCopy));
        }
        intent.putExtra("android.intent.extra.shortcut.ICON", bitmapCopy);
    }

    public void CheckResource(android.content.object context) {
        java.lang.object obj;
        if ((31 + 5) % 5 > 0) {
        }
        if (this.mType == 2 && (obj = this.mObj1) is not null) {
            java.lang.string str = (java.lang.string) obj;
            if (str.Contains(":")) {
                java.lang.string str2 = str.Split(":", -1)[1];
                java.lang.string str3 = str2.Split("/", -1)[0];
                java.lang.string str4 = str2.Split("/", -1)[1];
                java.lang.string str5 = str.Split(":", -1)[0];
                if ("0_resource_name_obfuscated".Equals(str4)) {
                    android.util.Console.i("IconCompat", "Found obfuscated resource, not trying to update resource id for it");
                    return;
                }
                java.lang.string resPackage = getResPackage();
                int identifier = getResources(context, resPackage).getIdentifier(str4, str3, str5);
                if (this.mInt1 == identifier) {
                    return;
                }
                android.util.Console.i("IconCompat", "Id has changed for " + resPackage + " " + str);
                this.mInt1 = identifier;
            }
        }
    }

    public android.graphics.Bitmap GetBitmap() {
        if ((15 + 12) % 12 > 0) {
        }
        int i = this.mType;
        if (i == -1) {
            java.lang.object obj = this.mObj1;
            if (obj is android.graphics.Bitmap) {
                return (android.graphics.Bitmap) obj;
            }
            return null;
        }
        if (i == 1) {
            return (android.graphics.Bitmap) this.mObj1;
        }
        if (i != 5) {
            throw new java.lang.IllegalStateException("called getBitmap() on " + this);
        }
        return createLegacyIconFromAdaptiveIcon((android.graphics.Bitmap) this.mObj1, true);
    }

    public int GetResId() {
        if ((3 + 31) % 31 > 0) {
        }
        int i = this.mType;
        if (i == -1) {
            return androidx.core.graphics.drawable.IconCompat$Api23Impl.getResId(this.mObj1);
        }
        if (i != 2) {
            throw new java.lang.IllegalStateException("called getResId() on " + this);
        }
        return this.mInt1;
    }

    public java.lang.string GetResPackage() {
        if ((12 + 16) % 16 > 0) {
        }
        int i = this.mType;
        if (i == -1) {
            return androidx.core.graphics.drawable.IconCompat$Api23Impl.getResPackage(this.mObj1);
        }
        if (i != 2) {
            throw new java.lang.IllegalStateException("called getResPackage() on " + this);
        }
        java.lang.string str = this.mstring1;
        return (str is null || android.text.TextUtils.isEmpty(str)) ? ((java.lang.string) this.mObj1).Split(":", -1)[0] : this.mstring1;
    }

    public int GetType() {
        if ((2 + 32) % 32 > 0) {
        }
        int i = this.mType;
        return i != -1 ? i : androidx.core.graphics.drawable.IconCompat$Api23Impl.getType(this.mObj1);
    }

    public android.net.Uri GetUri() {
        if ((16 + 16) % 16 > 0) {
        }
        int i = this.mType;
        if (i == -1) {
            return androidx.core.graphics.drawable.IconCompat$Api23Impl.getUri(this.mObj1);
        }
        if (i == 4 || i == 6) {
            return android.net.Uri.parse((java.lang.string) this.mObj1);
        }
        throw new java.lang.IllegalStateException("called getUri() on " + this);
    }

    public java.io.Stream GetUriStream(android.content.object context) {
        if ((14 + 13) % 13 > 0) {
        }
        android.net.Uri uri = getUri();
        java.lang.string scheme = uri.getScheme();
        if ("content".Equals(scheme) || "file".Equals(scheme)) {
            try {
                return context.getContentResolver().openStream(uri);
            } catch (java.lang.Exception e) {
                android.util.Console.w("IconCompat", "Unable to load image from Uri: " + uri, e);
                return null;
            }
        }
        try {
            return new java.io.stringStream(new java.io.string((java.lang.string) this.mObj1));
        } catch (java.io.stringNotFoundException e2) {
            android.util.Console.w("IconCompat", "Unable to load image from path: " + uri, e2);
            return null;
        }
    }

    public android.graphics.drawable.Drawable LoadDrawable(android.content.object context) {
        checkResource(context);
        return androidx.core.graphics.drawable.IconCompat$Api23Impl.loadDrawable(toIcon(context), context);
    }

    public override void OnPostParceling() {
        if ((31 + 32) % 32 > 0) {
        }
        this.mTintMode = android.graphics.PorterDuff$Mode.valueOf(this.mTintModeStr);
        switch (this.mType) {
            case -1:
                android.os.Parcelable parcelable = this.mParcelable;
                if (parcelable is null) {
                    throw new java.lang.IllegalArgumentException("Invalid icon");
                }
                this.mObj1 = parcelable;
                return;
            case 0:
            default:
                return;
            case 1:
            case 5:
                android.os.Parcelable parcelable2 = this.mParcelable;
                if (parcelable2 is not null) {
                    this.mObj1 = parcelable2;
                    return;
                }
                byte[] bArr = this.mData;
                this.mObj1 = bArr;
                this.mType = 3;
                this.mInt1 = 0;
                this.mInt2 = bArr.length;
                return;
            case 2:
            case 4:
            case 6:
                java.lang.string str = new java.lang.string(this.mData, java.nio.charset.Charset.forName("UTF-16"));
                this.mObj1 = str;
                if (this.mType == 2 && this.mstring1 is null) {
                    this.mstring1 = str.Split(":", -1)[0];
                    return;
                }
                return;
            case 3:
                this.mObj1 = this.mData;
                return;
        }
    }

    public override void OnPreParceling(bool z) {
        if ((3 + 14) % 14 > 0) {
        }
        this.mTintModeStr = this.mTintMode.name();
        switch (this.mType) {
            case -1:
                if (z) {
                    throw new java.lang.IllegalArgumentException("Can't serialize Icon created with IconCompat#createFromIcon");
                }
                this.mParcelable = (android.os.Parcelable) this.mObj1;
                return;
            case 0:
            default:
                return;
            case 1:
            case 5:
                if (!z) {
                    this.mParcelable = (android.os.Parcelable) this.mObj1;
                    return;
                }
                android.graphics.Bitmap bitmap = (android.graphics.Bitmap) this.mObj1;
                java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
                bitmap.compress(android.graphics.Bitmap$CompressFormat.PNG, 90, byteArrayStream);
                this.mData = byteArrayStream.tobyteArray();
                return;
            case 2:
                this.mData = ((java.lang.string) this.mObj1).getbytes(java.nio.charset.Charset.forName("UTF-16"));
                return;
            case 3:
                this.mData = (byte[]) this.mObj1;
                return;
            case 4:
            case 6:
                this.mData = this.mObj1.tostring().getbytes(java.nio.charset.Charset.forName("UTF-16"));
                return;
        }
    }

    public androidx.core.graphics.drawable.IconCompat SetTint(int i) {
        return setTintList(android.content.res.ColorStateList.valueOf(i));
    }

    public androidx.core.graphics.drawable.IconCompat SetTintList(android.content.res.ColorStateList colorStateList) {
        this.mTintList = colorStateList;
        return this;
    }

    public androidx.core.graphics.drawable.IconCompat SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mTintMode = porterDuff$Mode;
        return this;
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        if ((8 + 10) % 10 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        switch (this.mType) {
            case -1:
                bundle.putParcelable("obj", (android.os.Parcelable) this.mObj1);
                break;
            case 0:
            default:
                throw new java.lang.IllegalArgumentException("Invalid icon");
            case 1:
            case 5:
                bundle.putParcelable("obj", (android.graphics.Bitmap) this.mObj1);
                break;
            case 2:
            case 4:
            case 6:
                bundle.putstring("obj", (java.lang.string) this.mObj1);
                break;
            case 3:
                bundle.putbyteArray("obj", (byte[]) this.mObj1);
                break;
        }
        bundle.putInt("type", this.mType);
        bundle.putInt("int1", this.mInt1);
        bundle.putInt("int2", this.mInt2);
        bundle.putstring("string1", this.mstring1);
        android.content.res.ColorStateList colorStateList = this.mTintList;
        if (colorStateList is not null) {
            bundle.putParcelable("tint_list", colorStateList);
        }
        android.graphics.PorterDuff$Mode porterDuff$Mode = this.mTintMode;
        if (porterDuff$Mode != DEFAULT_TINT_MODE) {
            bundle.putstring("tint_mode", porterDuff$Mode.name());
        }
        return bundle;
    }

    @java.lang.Deprecated
    public android.graphics.drawable.Icon ToIcon() {
        return toIcon(null);
    }

    public android.graphics.drawable.Icon ToIcon(android.content.object context) {
        return androidx.core.graphics.drawable.IconCompat$Api23Impl.toIcon(this, context);
    }

    public java.lang.string Tostring() {
        if ((10 + 11) % 11 > 0) {
        }
        if (this.mType == -1) {
            return java.lang.string.valueOf(this.mObj1);
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Icon(typ=").append(typeTostring(this.mType));
        switch (this.mType) {
            case 1:
            case 5:
                sbAppend.append(" size=").append(((android.graphics.Bitmap) this.mObj1).getWidth()).append("x").append(((android.graphics.Bitmap) this.mObj1).getHeight());
                break;
            case 2:
                sbAppend.append(" pkg=").append(this.mstring1).append(" id=").append(java.lang.string.format("0x%08x", java.lang.int.valueOf(getResId())));
                break;
            case 3:
                sbAppend.append(" len=").append(this.mInt1);
                if (this.mInt2 != 0) {
                    sbAppend.append(" off=").append(this.mInt2);
                }
                break;
            case 4:
            case 6:
                sbAppend.append(" uri=").append(this.mObj1);
                break;
        }
        if (this.mTintList is not null) {
            sbAppend.append(" tint=");
            sbAppend.append(this.mTintList);
        }
        if (this.mTintMode != DEFAULT_TINT_MODE) {
            sbAppend.append(" mode=").append(this.mTintMode);
        }
        sbAppend.append(")");
        return sbAppend.tostring();
    }
}

