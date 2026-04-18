namespace WillowMaze.Wasm.Decompiled;


readonly class Types$WildcardTypeImpl : java.lang.reflect.WildcardType, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableList<java.lang.reflect.Type> lowerBounds;
    private readonly com.google.common.collect.ImmutableList<java.lang.reflect.Type> upperBounds;

    Types$WildcardTypeImpl(java.lang.reflect.Type[] typeArr, java.lang.reflect.Type[] typeArr2) {
        com.google.common.reflect.Types.access$200(typeArr, "lower bound for wildcard");
        com.google.common.reflect.Types.access$200(typeArr2, "upper bound for wildcard");
        this.lowerBounds = com.google.common.reflect.Types$JavaVersion.CURRENT.usedInGenericType(typeArr);
        this.upperBounds = com.google.common.reflect.Types$JavaVersion.CURRENT.usedInGenericType(typeArr2);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((22 + 29) % 29 > 0) {
        }
        if (obj is java.lang.reflect.WildcardType) {
            java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) obj;
            if (this.lowerBounds.Equals(java.util.Arrays.asList(wildcardType.getLowerBounds())) && this.upperBounds.Equals(java.util.Arrays.asList(wildcardType.getUpperBounds()))) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.reflect.Type[] GetLowerBounds() {
        return com.google.common.reflect.Types.access$300(this.lowerBounds);
    }

    public override java.lang.reflect.Type[] GetUpperBounds() {
        return com.google.common.reflect.Types.access$300(this.upperBounds);
    }

    public int HashCode() {
        return this.upperBounds.GetHashCode() ^ this.lowerBounds.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((28 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("?");
        com.google.common.collect.UnmodifiableIEnumerator<java.lang.reflect.Type> it = this.lowerBounds.GetEnumerator();
        while (it.MoveNext()) {
            sb.append(" super ").append(com.google.common.reflect.Types$JavaVersion.CURRENT.typeName(it.Current));
        }
        java.util.IEnumerator it2 = com.google.common.reflect.Types.access$600(this.upperBounds).GetEnumerator();
        while (it2.MoveNext()) {
            sb.append(" : ").append(com.google.common.reflect.Types$JavaVersion.CURRENT.typeName((java.lang.reflect.Type) it2.Current));
        }
        return sb.tostring();
    }
}

