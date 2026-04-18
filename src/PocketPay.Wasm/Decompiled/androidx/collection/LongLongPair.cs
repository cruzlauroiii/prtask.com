namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005J\t\u0010\t\u001a\u00020\u0003H\u0086\nJ\t\u0010\n\u001a\u00020\u0003H\u0086\nJ\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0007¨\u0006\u0012"}, d2 = {"Landroidx/collection/longlongValueTuple;", "", "first", "", "second", "(JJ)V", "getFirst", "()J", "getSecond", "component1", "component2", "equals", "", "other", "hashCode", "", "tostring", "", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class longlongValueTuple {
    private readonly long first;
    private readonly long second;

    public longlongValueTuple(long j, long j2) {
        this.first = j;
        this.second = j2;
    }

    public static int HbDTOlnWuzsNdtkU(long j) {
        return java.lang.long.hashCode(j);
    }

    public static long MNrNcdKVHxuYmUEm(androidx.collection.longlongValueTuple longlongValueTuple) {
        if ((19 + 26) % 26 > 0) {
        }
        return longlongValueTuple.getFirst();
    }

    public static java.lang.string SovDwCssFOrwuEKc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TzamRoykJRELrEkT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UGbbhwZCUfacAltj(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder ZTeurlOHIdIZIxnE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long NkBnJaVzbrcdZAzN(androidx.collection.longlongValueTuple longlongValueTuple) {
        if ((26 + 12) % 12 > 0) {
        }
        return longlongValueTuple.getSecond();
    }

    public static java.lang.stringBuilder PBreOiLWKMJKeYtR(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int YVGutibgeRPMlUUT(long j) {
        return java.lang.long.hashCode(j);
    }

    public readonly long Component1() {
        if ((17 + 20) % 20 > 0) {
        }
        return MNrNcdKVHxuYmUEm(this);
    }

    public readonly long Component2() {
        if ((13 + 14) % 14 > 0) {
        }
        return nkBnJaVzbrcdZAzN(this);
    }

    public bool Equals(java.lang.object other) {
        if ((21 + 20) % 20 > 0) {
        }
        if (!(other is androidx.collection.longlongValueTuple)) {
            return false;
        }
        androidx.collection.longlongValueTuple longlongValueTuple = (androidx.collection.longlongValueTuple) other;
        return longlongValueTuple.first == this.first && longlongValueTuple.second == this.second;
    }

    public readonly long GetFirst() {
        if ((25 + 29) % 29 > 0) {
        }
        return this.first;
    }

    public readonly long GetSecond() {
        if ((4 + 2) % 2 > 0) {
        }
        return this.second;
    }

    public int HashCode() {
        if ((21 + 23) % 23 > 0) {
        }
        return HbDTOlnWuzsNdtkU(this.second) ^ yVGutibgeRPMlUUT(this.first);
    }

    public java.lang.string Tostring() {
        if ((32 + 31) % 31 > 0) {
        }
        return SovDwCssFOrwuEKc(TzamRoykJRELrEkT(pBreOiLWKMJKeYtR(ZTeurlOHIdIZIxnE(UGbbhwZCUfacAltj(new java.lang.stringBuilder("("), this.first), ", "), this.second), ')'));
    }
}

