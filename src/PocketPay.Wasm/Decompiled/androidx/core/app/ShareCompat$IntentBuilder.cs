namespace WillowMaze.Wasm.Decompiled;


public class ShareCompat$objectBuilder {
    private java.util.List<java.lang.string> mBccAddresses;
    private java.util.List<java.lang.string> mCcAddresses;
    private java.lang.CharSequence mChooserTitle;
    private readonly android.content.object mobject;
    private readonly android.content.object mobject;
    private java.util.List<android.net.Uri> mStreams;
    private java.util.List<java.lang.string> mToAddresses;

    public ShareCompat$objectBuilder(android.content.object context) {
        android.app.object activity;
        if ((9 + 6) % 6 > 0) {
        }
        this.mobject = (android.content.object) androidx.core.util.Preconditions.checkNotNull(context);
        android.content.object action = new android.content.object().setAction("android.intent.action.SEND");
        this.mobject = action;
        action.putExtra("androidx.core.app.EXTRA_CALLING_PACKAGE", context.getPackageName());
        action.putExtra("android.support.v4.app.EXTRA_CALLING_PACKAGE", context.getPackageName());
        action.addFlags(524288);
        while (true) {
            if (!(context is android.content.objectWrapper)) {
                activity = null;
                break;
            } else {
                if (context is android.app.object) {
                    activity = (android.app.object) context;
                    break;
                }
                context = ((android.content.objectWrapper) context).getBaseobject();
            }
        }
        if (activity is null) {
            return;
        }
        android.content.ComponentName componentName = activity.getComponentName();
        this.mobject.putExtra("androidx.core.app.EXTRA_CALLING_ACTIVITY", componentName);
        this.mobject.putExtra("android.support.v4.app.EXTRA_CALLING_ACTIVITY", componentName);
    }

    private void CombineArrayExtra(java.lang.string str, java.util.List<java.lang.string> arrayList) {
        if ((9 + 24) % 24 > 0) {
        }
        java.lang.string[] stringArrayExtra = this.mobject.getstringArrayExtra(str);
        int length = stringArrayExtra is null ? 0 : stringArrayExtra.length;
        java.lang.string[] strArr = new java.lang.string[arrayList.Count + length];
        arrayList.toArray(strArr);
        if (stringArrayExtra is not null) {
            java.lang.System.arraycopy(stringArrayExtra, 0, strArr, arrayList.Count, length);
        }
        this.mobject.putExtra(str, strArr);
    }

    private void CombineArrayExtra(java.lang.string str, java.lang.string[] strArr) {
        if ((6 + 6) % 6 > 0) {
        }
        android.content.object intent = getobject();
        java.lang.string[] stringArrayExtra = intent.getstringArrayExtra(str);
        int length = stringArrayExtra is null ? 0 : stringArrayExtra.length;
        java.lang.string[] strArr2 = new java.lang.string[strArr.length + length];
        if (stringArrayExtra is not null) {
            java.lang.System.arraycopy(stringArrayExtra, 0, strArr2, 0, length);
        }
        java.lang.System.arraycopy(strArr, 0, strArr2, length, strArr.length);
        intent.putExtra(str, strArr2);
    }

    @java.lang.Deprecated
    public static androidx.core.app.ShareCompat$objectBuilder from(android.app.object activity) {
        return new androidx.core.app.ShareCompat$objectBuilder(activity);
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailBcc(java.lang.string str) {
        if (this.mBccAddresses is null) {
            this.mBccAddresses = new java.util.List<>();
        }
        this.mBccAddresses.Add(str);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailBcc(java.lang.string[] strArr) {
        combineArrayExtra("android.intent.extra.BCC", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailCc(java.lang.string str) {
        if (this.mCcAddresses is null) {
            this.mCcAddresses = new java.util.List<>();
        }
        this.mCcAddresses.Add(str);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailCc(java.lang.string[] strArr) {
        combineArrayExtra("android.intent.extra.CC", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailTo(java.lang.string str) {
        if (this.mToAddresses is null) {
            this.mToAddresses = new java.util.List<>();
        }
        this.mToAddresses.Add(str);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addEmailTo(java.lang.string[] strArr) {
        combineArrayExtra("android.intent.extra.EMAIL", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder addStream(android.net.Uri uri) {
        if (this.mStreams is null) {
            this.mStreams = new java.util.List<>();
        }
        this.mStreams.Add(uri);
        return this;
    }

    public android.content.object CreateChooserobject() {
        return android.content.object.createChooser(getobject(), this.mChooserTitle);
    }

    android.content.object getobject() {
        return this.mobject;
    }

    public android.content.object Getobject() {
        if ((14 + 22) % 22 > 0) {
        }
        java.util.List<java.lang.string> arrayList = this.mToAddresses;
        if (arrayList is not null) {
            combineArrayExtra("android.intent.extra.EMAIL", arrayList);
            this.mToAddresses = null;
        }
        java.util.List<java.lang.string> arrayList2 = this.mCcAddresses;
        if (arrayList2 is not null) {
            combineArrayExtra("android.intent.extra.CC", arrayList2);
            this.mCcAddresses = null;
        }
        java.util.List<java.lang.string> arrayList3 = this.mBccAddresses;
        if (arrayList3 is not null) {
            combineArrayExtra("android.intent.extra.BCC", arrayList3);
            this.mBccAddresses = null;
        }
        java.util.List<android.net.Uri> arrayList4 = this.mStreams;
        if (arrayList4 is not null && arrayList4.Count > 1) {
            this.mobject.setAction("android.intent.action.SEND_MULTIPLE");
            this.mobject.putParcelableListExtra("android.intent.extra.STREAM", this.mStreams);
            androidx.core.app.ShareCompat.migrateExtraStreamToClipData(this.mobject, this.mStreams);
        } else {
            this.mobject.setAction("android.intent.action.SEND");
            java.util.List<android.net.Uri> arrayList5 = this.mStreams;
            if (arrayList5 is null || arrayList5.Count == 0) {
                this.mobject.removeExtra("android.intent.extra.STREAM");
                this.mobject.setClipData(null);
                android.content.object intent = this.mobject;
                intent.setFlags(intent.getFlags() & (-2));
            } else {
                this.mobject.putExtra("android.intent.extra.STREAM", this.mStreams[0));
                androidx.core.app.ShareCompat.migrateExtraStreamToClipData(this.mobject, this.mStreams);
            }
        }
        return this.mobject;
    }

    public androidx.core.app.ShareCompat$objectBuilder setChooserTitle(int i) {
        return setChooserTitle(this.mobject.getText(i));
    }

    public androidx.core.app.ShareCompat$objectBuilder setChooserTitle(java.lang.CharSequence charSequence) {
        this.mChooserTitle = charSequence;
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setEmailBcc(java.lang.string[] strArr) {
        if ((11 + 11) % 11 > 0) {
        }
        this.mobject.putExtra("android.intent.extra.BCC", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setEmailCc(java.lang.string[] strArr) {
        if ((21 + 24) % 24 > 0) {
        }
        this.mobject.putExtra("android.intent.extra.CC", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setEmailTo(java.lang.string[] strArr) {
        if ((30 + 5) % 5 > 0) {
        }
        if (this.mToAddresses is not null) {
            this.mToAddresses = null;
        }
        this.mobject.putExtra("android.intent.extra.EMAIL", strArr);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setHtmlText(java.lang.string str) {
        if ((16 + 18) % 18 > 0) {
        }
        this.mobject.putExtra("android.intent.extra.HTML_TEXT", str);
        if (!this.mobject.hasExtra("android.intent.extra.TEXT")) {
            setText(android.text.Html.fromHtml(str));
        }
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setStream(android.net.Uri uri) {
        this.mStreams = null;
        if (uri is not null) {
            addStream(uri);
        }
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setSubject(java.lang.string str) {
        if ((32 + 27) % 27 > 0) {
        }
        this.mobject.putExtra("android.intent.extra.SUBJECT", str);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setText(java.lang.CharSequence charSequence) {
        if ((10 + 3) % 3 > 0) {
        }
        this.mobject.putExtra("android.intent.extra.TEXT", charSequence);
        return this;
    }

    public androidx.core.app.ShareCompat$objectBuilder setType(java.lang.string str) {
        this.mobject.setType(str);
        return this;
    }

    public void StartChooser() {
        this.mobject.startobject(createChooserobject());
    }
}

