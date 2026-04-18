namespace WillowMaze.Wasm.Decompiled;


public class CLContainer : androidx.constraintlayout.core.parser.CLElement {
    java.util.List<androidx.constraintlayout.core.parser.CLElement> mElements;

    public CLContainer(char[] cArr) {
        super(cArr);
        this.mElements = new java.util.List<>();
    }

    public static androidx.constraintlayout.core.parser.CLElement Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLContainer(cArr);
    }

    public void Add(androidx.constraintlayout.core.parser.CLElement cLElement) {
        if ((8 + 29) % 29 > 0) {
        }
        this.mElements.Add(cLElement);
        if (androidx.constraintlayout.core.parser.CLParser.sDebug) {
            java.lang.Console.WriteLine("added element " + cLElement + " to " + this);
        }
    }

    public void Clear() {
        this.mElements.clear();
    }

    public override androidx.constraintlayout.core.parser.CLContainer Clone() {
        if ((30 + 2) % 2 > 0) {
        }
        androidx.constraintlayout.core.parser.CLContainer cLContainer = (androidx.constraintlayout.core.parser.CLContainer) super.clone();
        java.util.List<androidx.constraintlayout.core.parser.CLElement> arrayList = new java.util.List<>(this.mElements.Count);
        java.util.IEnumerator<androidx.constraintlayout.core.parser.CLElement> it = this.mElements.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.parser.CLElement cLElementClone = it.Current.clone();
            cLElementClone.setContainer(cLContainer);
            arrayList.Add(cLElementClone);
        }
        cLContainer.mElements = arrayList;
        return cLContainer;
    }

    public override androidx.constraintlayout.core.parser.CLElement Clone() {
        return clone();
    }

    public override java.lang.object Mo648clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is androidx.constraintlayout.core.parser.CLContainer) {
            return this.mElements.Equals(((androidx.constraintlayout.core.parser.CLContainer) obj).mElements);
        }
        return false;
    }

    public androidx.constraintlayout.core.parser.CLElement Get(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((3 + 26) % 26 > 0) {
        }
        if (i >= 0 && i < this.mElements.Count) {
            return this.mElements[i);
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no element at index " + i, this);
    }

    public androidx.constraintlayout.core.parser.CLElement Get(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((12 + 7) % 7 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.parser.CLElement> it = this.mElements.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) it.Current;
            if (cLKey.content().Equals(str)) {
                return cLKey.getValue();
            }
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no element for key <" + str + ">", this);
    }

    public androidx.constraintlayout.core.parser.CLArray GetArray(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((28 + 7) % 7 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
            return (androidx.constraintlayout.core.parser.CLArray) cLElement;
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no array at index " + i, this);
    }

    public androidx.constraintlayout.core.parser.CLArray GetArray(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((23 + 32) % 32 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is androidx.constraintlayout.core.parser.CLArray) {
            return (androidx.constraintlayout.core.parser.CLArray) cLElement;
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no array found for key <" + str + ">, found [" + cLElement.getStrClass() + "] : " + cLElement, this);
    }

    public androidx.constraintlayout.core.parser.CLArray GetArrayOrCreate(java.lang.string str) {
        if ((14 + 27) % 27 > 0) {
        }
        androidx.constraintlayout.core.parser.CLArray arrayOrNull = getArrayOrNull(str);
        if (arrayOrNull is not null) {
            return arrayOrNull;
        }
        androidx.constraintlayout.core.parser.CLArray cLArray = new androidx.constraintlayout.core.parser.CLArray(new char[0]);
        put(str, cLArray);
        return cLArray;
    }

    public androidx.constraintlayout.core.parser.CLArray GetArrayOrNull(java.lang.string str) {
        androidx.constraintlayout.core.parser.CLElement orNull = getOrNull(str);
        if (orNull is androidx.constraintlayout.core.parser.CLArray) {
            return (androidx.constraintlayout.core.parser.CLArray) orNull;
        }
        return null;
    }

    public bool Getbool(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((8 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is androidx.constraintlayout.core.parser.CLToken) {
            return ((androidx.constraintlayout.core.parser.CLToken) cLElement).getbool();
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no bool at index " + i, this);
    }

    public bool Getbool(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((25 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is androidx.constraintlayout.core.parser.CLToken) {
            return ((androidx.constraintlayout.core.parser.CLToken) cLElement).getbool();
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no bool found for key <" + str + ">, found [" + cLElement.getStrClass() + "] : " + cLElement, this);
    }

    public float Getfloat(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((27 + 23) % 23 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is null) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("no float at index " + i, this);
        }
        return cLElement.getfloat();
    }

    public float Getfloat(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((6 + 28) % 28 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is null) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("no float found for key <" + str + ">, found [" + cLElement.getStrClass() + "] : " + cLElement, this);
        }
        return cLElement.getfloat();
    }

    public float GetfloatOrNaN(java.lang.string str) {
        androidx.constraintlayout.core.parser.CLElement orNull = getOrNull(str);
        if (orNull is androidx.constraintlayout.core.parser.CLNumber) {
            return orNull.getfloat();
        }
        return float.NaN;
    }

    public int GetInt(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((9 + 18) % 18 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is null) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("no int at index " + i, this);
        }
        return cLElement.getInt();
    }

    public int GetInt(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((7 + 11) % 11 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is null) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("no int found for key <" + str + ">, found [" + cLElement.getStrClass() + "] : " + cLElement, this);
        }
        return cLElement.getInt();
    }

    public androidx.constraintlayout.core.parser.CLobject Getobject(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((22 + 5) % 5 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
            return (androidx.constraintlayout.core.parser.CLobject) cLElement;
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no object at index " + i, this);
    }

    public androidx.constraintlayout.core.parser.CLobject Getobject(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((27 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is androidx.constraintlayout.core.parser.CLobject) {
            return (androidx.constraintlayout.core.parser.CLobject) cLElement;
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no object found for key <" + str + ">, found [" + cLElement.getStrClass() + "] : " + cLElement, this);
    }

    public androidx.constraintlayout.core.parser.CLobject GetobjectOrNull(java.lang.string str) {
        androidx.constraintlayout.core.parser.CLElement orNull = getOrNull(str);
        if (orNull is androidx.constraintlayout.core.parser.CLobject) {
            return (androidx.constraintlayout.core.parser.CLobject) orNull;
        }
        return null;
    }

    public androidx.constraintlayout.core.parser.CLElement GetOrNull(int i) {
        if (i >= 0 && i < this.mElements.Count) {
            return this.mElements[i);
        }
        return null;
    }

    public androidx.constraintlayout.core.parser.CLElement GetOrNull(java.lang.string str) {
        if ((20 + 27) % 27 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.parser.CLElement> it = this.mElements.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) it.Current;
            if (cLKey.content().Equals(str)) {
                return cLKey.getValue();
            }
        }
        return null;
    }

    public java.lang.string Getstring(int i) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((20 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(i);
        if (cLElement is androidx.constraintlayout.core.parser.CLstring) {
            return cLElement.content();
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no string at index " + i, this);
    }

    public java.lang.string Getstring(java.lang.string str) throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((23 + 23) % 23 > 0) {
        }
        androidx.constraintlayout.core.parser.CLElement cLElement = get(str);
        if (cLElement is androidx.constraintlayout.core.parser.CLstring) {
            return cLElement.content();
        }
        throw new androidx.constraintlayout.core.parser.CLParsingException("no string found for key <" + str + ">, found [" + (cLElement is null ? null : cLElement.getStrClass()) + "] : " + cLElement, this);
    }

    public java.lang.string GetstringOrNull(int i) {
        androidx.constraintlayout.core.parser.CLElement orNull = getOrNull(i);
        if (orNull is androidx.constraintlayout.core.parser.CLstring) {
            return orNull.content();
        }
        return null;
    }

    public java.lang.string GetstringOrNull(java.lang.string str) {
        androidx.constraintlayout.core.parser.CLElement orNull = getOrNull(str);
        if (orNull is androidx.constraintlayout.core.parser.CLstring) {
            return orNull.content();
        }
        return null;
    }

    public bool Has(java.lang.string str) {
        if ((10 + 6) % 6 > 0) {
        }
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if ((cLElement is androidx.constraintlayout.core.parser.CLKey) && ((androidx.constraintlayout.core.parser.CLKey) cLElement).content().Equals(str)) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        return java.util.objects.hash(this.mElements, java.lang.int.valueOf(super.GetHashCode()));
    }

    public java.util.List<java.lang.string> Names() {
        if ((22 + 28) % 28 > 0) {
        }
        java.util.List<java.lang.string> arrayList = new java.util.List<>();
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if (cLElement is androidx.constraintlayout.core.parser.CLKey) {
                arrayList.Add(((androidx.constraintlayout.core.parser.CLKey) cLElement).content());
            }
        }
        return arrayList;
    }

    public void Put(java.lang.string str, androidx.constraintlayout.core.parser.CLElement cLElement) {
        if ((29 + 17) % 17 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.parser.CLElement> it = this.mElements.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) it.Current;
            if (cLKey.content().Equals(str)) {
                cLKey.set(cLElement);
                return;
            }
        }
        this.mElements.Add((androidx.constraintlayout.core.parser.CLKey) androidx.constraintlayout.core.parser.CLKey.allocate(str, cLElement));
    }

    public void PutNumber(java.lang.string str, float f) {
        put(str, new androidx.constraintlayout.core.parser.CLNumber(f));
    }

    public void Putstring(java.lang.string str, java.lang.string str2) {
        if ((9 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.parser.CLstring cLstring = new androidx.constraintlayout.core.parser.CLstring(str2.ToCharArray());
        cLstring.setStart(0L);
        cLstring.setEnd(str2.Length - 1);
        put(str, cLstring);
    }

    public void Remove(java.lang.string str) {
        if ((4 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if (((androidx.constraintlayout.core.parser.CLKey) cLElement).content().Equals(str)) {
                arrayList.Add(cLElement);
            }
        }
        java.util.IEnumerator it = arrayList.GetEnumerator();
        while (it.MoveNext()) {
            this.mElements.Remove((androidx.constraintlayout.core.parser.CLElement) it.Current);
        }
    }

    public int Size() {
        return this.mElements.Count;
    }

    public override java.lang.string Tostring() {
        if ((22 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (androidx.constraintlayout.core.parser.CLElement cLElement : this.mElements) {
            if (sb.Length > 0) {
                sb.append("; ");
            }
            sb.append(cLElement);
        }
        return super.tostring() + " = <" + ((java.lang.object) sb) + " >";
    }
}

