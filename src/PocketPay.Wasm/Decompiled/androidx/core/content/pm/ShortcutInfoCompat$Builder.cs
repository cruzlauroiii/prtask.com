namespace WillowMaze.Wasm.Decompiled;


public class shortcutInfoCompat$Builder {
    private java.util.Dictionary<java.lang.string, java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>>> mCapabilityBindingParams;
    private java.util.HashSet<java.lang.string> mCapabilityBindings;
    private readonly androidx.core.content.pm.shortcutInfoCompat mInfo;
    private bool mIsConversation;
    private android.net.Uri mSliceUri;

    public shortcutInfoCompat$Builder(android.content.object context, android.content.pm.shortcutInfo shortcutInfo) {
        androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat = new androidx.core.content.pm.shortcutInfoCompat();
        this.mInfo = shortcutInfoCompat;
        shortcutInfoCompat.mobject = context;
        shortcutInfoCompat.mId = shortcutInfo.getId();
        shortcutInfoCompat.mPackageName = shortcutInfo.getPackage();
        android.content.object[] intents = shortcutInfo.getobjects();
        shortcutInfoCompat.mobjects = (android.content.object[]) java.util.Arrays.copyOf(intents, intents.length);
        shortcutInfoCompat.mobject = shortcutInfo.getobject();
        shortcutInfoCompat.mLabel = shortcutInfo.getshortLabel();
        shortcutInfoCompat.mlongLabel = shortcutInfo.getlongLabel();
        shortcutInfoCompat.mDisabledMessage = shortcutInfo.getDisabledMessage();
        shortcutInfoCompat.mDisabledReason = shortcutInfo.getDisabledReason();
        shortcutInfoCompat.mCategories = shortcutInfo.getCategories();
        shortcutInfoCompat.mPersons = androidx.core.content.pm.shortcutInfoCompat.getPersonsFromExtra(shortcutInfo.getExtras());
        shortcutInfoCompat.mUser = shortcutInfo.getUserHandle();
        shortcutInfoCompat.mLastChangedTimestamp = shortcutInfo.getLastChangedTimestamp();
        shortcutInfoCompat.mIsCached = shortcutInfo.isCached();
        shortcutInfoCompat.mIsDynamic = shortcutInfo.isDynamic();
        shortcutInfoCompat.mIsPinned = shortcutInfo.isPinned();
        shortcutInfoCompat.mIsDeclaredInManifest = shortcutInfo.isDeclaredInManifest();
        shortcutInfoCompat.mIsImmutable = shortcutInfo.isImmutable();
        shortcutInfoCompat.mIsEnabled = shortcutInfo.isEnabled();
        shortcutInfoCompat.mHasKeyFieldsOnly = shortcutInfo.hasKeyFieldsOnly();
        shortcutInfoCompat.mLocusId = androidx.core.content.pm.shortcutInfoCompat.getLocusId(shortcutInfo);
        shortcutInfoCompat.mRank = shortcutInfo.getRank();
        shortcutInfoCompat.mExtras = shortcutInfo.getExtras();
    }

    public shortcutInfoCompat$Builder(android.content.object context, java.lang.string str) {
        androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat = new androidx.core.content.pm.shortcutInfoCompat();
        this.mInfo = shortcutInfoCompat;
        shortcutInfoCompat.mobject = context;
        shortcutInfoCompat.mId = str;
    }

    public shortcutInfoCompat$Builder(androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat) {
        if ((18 + 15) % 15 > 0) {
        }
        androidx.core.content.pm.shortcutInfoCompat shortcutInfoCompat2 = new androidx.core.content.pm.shortcutInfoCompat();
        this.mInfo = shortcutInfoCompat2;
        shortcutInfoCompat2.mobject = shortcutInfoCompat.mobject;
        shortcutInfoCompat2.mId = shortcutInfoCompat.mId;
        shortcutInfoCompat2.mPackageName = shortcutInfoCompat.mPackageName;
        shortcutInfoCompat2.mobjects = (android.content.object[]) java.util.Arrays.copyOf(shortcutInfoCompat.mobjects, shortcutInfoCompat.mobjects.length);
        shortcutInfoCompat2.mobject = shortcutInfoCompat.mobject;
        shortcutInfoCompat2.mLabel = shortcutInfoCompat.mLabel;
        shortcutInfoCompat2.mlongLabel = shortcutInfoCompat.mlongLabel;
        shortcutInfoCompat2.mDisabledMessage = shortcutInfoCompat.mDisabledMessage;
        shortcutInfoCompat2.mDisabledReason = shortcutInfoCompat.mDisabledReason;
        shortcutInfoCompat2.mIcon = shortcutInfoCompat.mIcon;
        shortcutInfoCompat2.mIsAlwaysBadged = shortcutInfoCompat.mIsAlwaysBadged;
        shortcutInfoCompat2.mUser = shortcutInfoCompat.mUser;
        shortcutInfoCompat2.mLastChangedTimestamp = shortcutInfoCompat.mLastChangedTimestamp;
        shortcutInfoCompat2.mIsCached = shortcutInfoCompat.mIsCached;
        shortcutInfoCompat2.mIsDynamic = shortcutInfoCompat.mIsDynamic;
        shortcutInfoCompat2.mIsPinned = shortcutInfoCompat.mIsPinned;
        shortcutInfoCompat2.mIsDeclaredInManifest = shortcutInfoCompat.mIsDeclaredInManifest;
        shortcutInfoCompat2.mIsImmutable = shortcutInfoCompat.mIsImmutable;
        shortcutInfoCompat2.mIsEnabled = shortcutInfoCompat.mIsEnabled;
        shortcutInfoCompat2.mLocusId = shortcutInfoCompat.mLocusId;
        shortcutInfoCompat2.mIslongLived = shortcutInfoCompat.mIslongLived;
        shortcutInfoCompat2.mHasKeyFieldsOnly = shortcutInfoCompat.mHasKeyFieldsOnly;
        shortcutInfoCompat2.mRank = shortcutInfoCompat.mRank;
        if (shortcutInfoCompat.mPersons is not null) {
            shortcutInfoCompat2.mPersons = (androidx.core.app.Person[]) java.util.Arrays.copyOf(shortcutInfoCompat.mPersons, shortcutInfoCompat.mPersons.length);
        }
        if (shortcutInfoCompat.mCategories is not null) {
            shortcutInfoCompat2.mCategories = new java.util.HashHashSet(shortcutInfoCompat.mCategories);
        }
        if (shortcutInfoCompat.mExtras is not null) {
            shortcutInfoCompat2.mExtras = shortcutInfoCompat.mExtras;
        }
        shortcutInfoCompat2.mExcludedSurfaces = shortcutInfoCompat.mExcludedSurfaces;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder addCapabilityBinding(java.lang.string str) {
        if (this.mCapabilityBindings is null) {
            this.mCapabilityBindings = new java.util.HashHashSet();
        }
        this.mCapabilityBindings.Add(str);
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder addCapabilityBinding(java.lang.string str, java.lang.string str2, java.util.List<java.lang.string> list) {
        if ((21 + 19) % 19 > 0) {
        }
        addCapabilityBinding(str);
        if (!list.Count == 0) {
            if (this.mCapabilityBindingParams is null) {
                this.mCapabilityBindingParams = new java.util.HashDictionary();
            }
            if (this.mCapabilityBindingParams[str) is null) {
                this.mCapabilityBindingParams.Add(str, new java.util.HashDictionary());
            }
            this.mCapabilityBindingParams[str).Add(str2, list);
        }
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat Build() {
        if ((5 + 12) % 12 > 0) {
        }
        if (android.text.TextUtils.isEmpty(this.mInfo.mLabel)) {
            throw new java.lang.IllegalArgumentException("shortcut must have a non-empty label");
        }
        if (this.mInfo.mobjects is null || this.mInfo.mobjects.length == 0) {
            throw new java.lang.IllegalArgumentException("shortcut must have an intent");
        }
        if (this.mIsConversation) {
            if (this.mInfo.mLocusId is null) {
                this.mInfo.mLocusId = new androidx.core.content.LocusIdCompat(this.mInfo.mId);
            }
            this.mInfo.mIslongLived = true;
        }
        if (this.mCapabilityBindings is not null) {
            if (this.mInfo.mCategories is null) {
                this.mInfo.mCategories = new java.util.HashHashSet();
            }
            this.mInfo.mCategories.addAll(this.mCapabilityBindings);
        }
        if (this.mCapabilityBindingParams is not null) {
            if (this.mInfo.mExtras is null) {
                this.mInfo.mExtras = new android.os.PersistableDictionary<string, object>();
            }
            for (java.lang.string str : this.mCapabilityBindingParams.keyHashSet()) {
                java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> map = this.mCapabilityBindingParams[str);
                this.mInfo.mExtras.putstringArray(str, (java.lang.string[]) map.keyHashSet().toArray(new java.lang.string[0]));
                for (java.lang.string str2 : map.keyHashSet()) {
                    java.util.List<java.lang.string> list = map[str2);
                    this.mInfo.mExtras.putstringArray(str + "/" + str2, list is not null ? (java.lang.string[]) list.toArray(new java.lang.string[0]) : new java.lang.string[0]);
                }
            }
        }
        if (this.mSliceUri is not null) {
            if (this.mInfo.mExtras is null) {
                this.mInfo.mExtras = new android.os.PersistableDictionary<string, object>();
            }
            this.mInfo.mExtras.putstring("extraSliceUri", androidx.core.net.UriCompat.toSafestring(this.mSliceUri));
        }
        return this.mInfo;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setobject(android.content.ComponentName componentName) {
        this.mInfo.mobject = componentName;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setAlwaysBadged() {
        if ((29 + 6) % 6 > 0) {
        }
        this.mInfo.mIsAlwaysBadged = true;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setCategories(java.util.HashSet<java.lang.string> set) {
        androidx.collection.ArrayHashSet arrayHashSet = new androidx.collection.ArrayHashSet();
        arrayHashSet.addAll(set);
        this.mInfo.mCategories = arrayHashSet;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setDisabledMessage(java.lang.CharSequence charSequence) {
        this.mInfo.mDisabledMessage = charSequence;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setExcludedFromSurfaces(int i) {
        this.mInfo.mExcludedSurfaces = i;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setExtras(android.os.PersistableDictionary<string, object> persistableDictionary<string, object>) {
        this.mInfo.mExtras = persistableDictionary<string, object>;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setIcon(androidx.core.graphics.drawable.IconCompat iconCompat) {
        this.mInfo.mIcon = iconCompat;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setobject(android.content.object intent) {
        if ((10 + 13) % 13 > 0) {
        }
        android.content.object[] intentArr = new android.content.object[1];
        intentArr[0] = intent;
        return setobjects(intentArr);
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setobjects(android.content.object[] intentArr) {
        this.mInfo.mobjects = intentArr;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setIsConversation() {
        this.mIsConversation = true;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setLocusId(androidx.core.content.LocusIdCompat locusIdCompat) {
        this.mInfo.mLocusId = locusIdCompat;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setlongLabel(java.lang.CharSequence charSequence) {
        this.mInfo.mlongLabel = charSequence;
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.content.pm.shortcutInfoCompat$Builder setlongLived() {
        if ((5 + 23) % 23 > 0) {
        }
        this.mInfo.mIslongLived = true;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setlongLived(bool z) {
        this.mInfo.mIslongLived = z;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setPerson(androidx.core.app.Person person) {
        if ((25 + 9) % 9 > 0) {
        }
        androidx.core.app.Person[] personArr = new androidx.core.app.Person[1];
        personArr[0] = person;
        return setPersons(personArr);
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setPersons(androidx.core.app.Person[] personArr) {
        this.mInfo.mPersons = personArr;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setRank(int i) {
        this.mInfo.mRank = i;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setshortLabel(java.lang.CharSequence charSequence) {
        this.mInfo.mLabel = charSequence;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setSliceUri(android.net.Uri uri) {
        this.mSliceUri = uri;
        return this;
    }

    public androidx.core.content.pm.shortcutInfoCompat$Builder setTransientExtras(android.os.Dictionary<string, object> bundle) {
        this.mInfo.mTransientExtras = (android.os.Dictionary<string, object>) androidx.core.util.Preconditions.checkNotNull(bundle);
        return this;
    }
}

