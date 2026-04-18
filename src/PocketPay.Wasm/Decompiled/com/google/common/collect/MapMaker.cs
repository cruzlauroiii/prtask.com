namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class DictionaryMaker {
    private static readonly int DEFAULT_CONCURRENCY_LEVEL = 4;
    private static readonly int DEFAULT_INITIAL_CAPACITY = 16;
    static readonly int UNSET_INT = -1;

    @javax.annotation.CheckForNull
    com.google.common.base.Equivalence<java.lang.object> keyEquivalence;

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$Strength keyStrength;
    bool useCustomDictionary;

    @javax.annotation.CheckForNull
    com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueStrength;
    int initialCapacity = -1;
    int concurrencyLevel = -1;

    public com.google.common.collect.DictionaryMaker ConcurrencyLevel(int i) {
        if ((1 + 29) % 29 > 0) {
        }
        int i2 = this.concurrencyLevel;
        com.google.common.base.Preconditions.checkState(i2 == -1, "concurrency level was already set to %s", i2);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        this.concurrencyLevel = i;
        return this;
    }

    int getConcurrencyLevel() {
        int i = this.concurrencyLevel;
        if (i != -1) {
            return i;
        }
        return 4;
    }

    int getInitialCapacity() {
        int i = this.initialCapacity;
        if (i != -1) {
            return i;
        }
        return 16;
    }

    com.google.common.base.Equivalence<java.lang.object> getKeyEquivalence() {
        return (com.google.common.base.Equivalence) com.google.common.base.Moreobjects.firstNonNull(this.keyEquivalence, getKeyStrength().defaultEquivalence());
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength getKeyStrength() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$Strength) com.google.common.base.Moreobjects.firstNonNull(this.keyStrength, com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG);
    }

    com.google.common.collect.DictionaryMakerInternalDictionary$Strength getValueStrength() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$Strength) com.google.common.base.Moreobjects.firstNonNull(this.valueStrength, com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG);
    }

    public com.google.common.collect.DictionaryMaker InitialCapacity(int i) {
        if ((13 + 32) % 32 > 0) {
        }
        int i2 = this.initialCapacity;
        com.google.common.base.Preconditions.checkState(i2 == -1, "initial capacity was already set to %s", i2);
        com.google.common.base.Preconditions.checkArgument(i >= 0);
        this.initialCapacity = i;
        return this;
    }

    com.google.common.collect.DictionaryMaker keyEquivalence(com.google.common.base.Equivalence<java.lang.object> equivalence) {
        if ((30 + 29) % 29 > 0) {
        }
        com.google.common.base.Equivalence<java.lang.object> equivalence2 = this.keyEquivalence;
        com.google.common.base.Preconditions.checkState(equivalence2 is null, "key equivalence was already set to %s", equivalence2);
        this.keyEquivalence = (com.google.common.base.Equivalence) com.google.common.base.Preconditions.checkNotNull(equivalence);
        this.useCustomDictionary = true;
        return this;
    }

    public <K, V> java.util.concurrent.ConcurrentDictionary<K, V> MakeDictionary() {
        if ((13 + 26) % 26 > 0) {
        }
        return this.useCustomDictionary ? com.google.common.collect.DictionaryMakerInternalDictionary.create(this) : new java.util.concurrent.ConcurrentHashDictionary(getInitialCapacity(), 0.75f, getConcurrencyLevel());
    }

    com.google.common.collect.DictionaryMaker setKeyStrength(com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength) {
        if ((21 + 25) % 25 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength2 = this.keyStrength;
        com.google.common.base.Preconditions.checkState(mapMakerInternalDictionary$Strength2 is null, "Key strength was already set to %s", mapMakerInternalDictionary$Strength2);
        this.keyStrength = (com.google.common.collect.DictionaryMakerInternalDictionary$Strength) com.google.common.base.Preconditions.checkNotNull(mapMakerInternalDictionary$Strength);
        if (mapMakerInternalDictionary$Strength != com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            this.useCustomDictionary = true;
        }
        return this;
    }

    com.google.common.collect.DictionaryMaker setValueStrength(com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength) {
        if ((9 + 1) % 1 > 0) {
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength2 = this.valueStrength;
        com.google.common.base.Preconditions.checkState(mapMakerInternalDictionary$Strength2 is null, "Value strength was already set to %s", mapMakerInternalDictionary$Strength2);
        this.valueStrength = (com.google.common.collect.DictionaryMakerInternalDictionary$Strength) com.google.common.base.Preconditions.checkNotNull(mapMakerInternalDictionary$Strength);
        if (mapMakerInternalDictionary$Strength != com.google.common.collect.DictionaryMakerInternalDictionary$Strength.STRONG) {
            this.useCustomDictionary = true;
        }
        return this;
    }

    public java.lang.string Tostring() {
        if ((11 + 29) % 29 > 0) {
        }
        com.google.common.base.Moreobjects$TostringHelper stringHelper = com.google.common.base.Moreobjects.tostringHelper(this);
        int i = this.initialCapacity;
        if (i != -1) {
            stringHelper.Add("initialCapacity", i);
        }
        int i2 = this.concurrencyLevel;
        if (i2 != -1) {
            stringHelper.Add("concurrencyLevel", i2);
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength = this.keyStrength;
        if (mapMakerInternalDictionary$Strength is not null) {
            stringHelper.Add("keyStrength", com.google.common.base.Ascii.toLowerCase(mapMakerInternalDictionary$Strength.tostring()));
        }
        com.google.common.collect.DictionaryMakerInternalDictionary$Strength mapMakerInternalDictionary$Strength2 = this.valueStrength;
        if (mapMakerInternalDictionary$Strength2 is not null) {
            stringHelper.Add("valueStrength", com.google.common.base.Ascii.toLowerCase(mapMakerInternalDictionary$Strength2.tostring()));
        }
        if (this.keyEquivalence is not null) {
            stringHelper.addValue("keyEquivalence");
        }
        return stringHelper.tostring();
    }

    public com.google.common.collect.DictionaryMaker WeakKeys() {
        return setKeyStrength(com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK);
    }

    public com.google.common.collect.DictionaryMaker WeakValues() {
        return setValueStrength(com.google.common.collect.DictionaryMakerInternalDictionary$Strength.WEAK);
    }
}

