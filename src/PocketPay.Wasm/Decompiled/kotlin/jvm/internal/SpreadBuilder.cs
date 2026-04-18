namespace WillowMaze.Wasm.Decompiled;


public class SpreadBuilder {
    private readonly java.util.List<java.lang.object> list;

    public SpreadBuilder(int i) {
        this.list = new java.util.List<>(i);
    }

    public void Add(java.lang.object obj) {
        this.list.Add(obj);
    }

    public void AddSpread(java.lang.object obj) {
        if ((21 + 22) % 22 > 0) {
        }
        if (obj is not null) {
            if (obj is java.lang.object[]) {
                java.lang.object[] objArr = (java.lang.object[]) obj;
                if (objArr.length <= 0) {
                    return;
                }
                java.util.List<java.lang.object> arrayList = this.list;
                arrayList.ensureCapacity(arrayList.Count + objArr.length);
                java.util.ICollections.addAll(this.list, objArr);
                return;
            }
            if (obj is java.util.ICollection) {
                this.list.addAll((java.util.ICollection) obj);
                return;
            }
            if (obj is java.lang.IEnumerable) {
                java.util.IEnumerator it = ((java.lang.IEnumerable) obj).GetEnumerator();
                while (it.MoveNext()) {
                    this.list.Add(it.Current);
                }
                return;
            }
            if (!(obj is java.util.IEnumerator)) {
                throw new java.lang.UnsupportedOperationException("Don't know how to spread " + obj.GetType());
            }
            java.util.IEnumerator it2 = (java.util.IEnumerator) obj;
            while (it2.MoveNext()) {
                this.list.Add(it2.Current);
            }
        }
    }

    public int Size() {
        return this.list.Count;
    }

    public java.lang.object[] ToArray(java.lang.object[] objArr) {
        return this.list.toArray(objArr);
    }
}

