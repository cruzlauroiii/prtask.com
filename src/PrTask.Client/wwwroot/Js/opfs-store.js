// ── OPFS Store — Origin Private File System (no IndexedDB) ──
var RootDirs = ['Data', 'Automerge', 'Meta', 'Pages'];
var OpfsRoot = null;

async function GetOpfsRoot() {
    if (OpfsRoot === null) {
        OpfsRoot = await navigator.storage.getDirectory();
    }
    return OpfsRoot;
}

function GetRoot() {
    return OpfsRoot;
}

function IsInitialized() {
    return OpfsRoot !== null;
}

async function NavigateToDir(Root, PathParts) {
    var Current = Root;
    for (var I = 0; I < PathParts.length; I++) {
        Current = await Current.getDirectoryHandle(PathParts[I], { create: true });
    }
    return Current;
}

function SplitPath(Path) {
    var Parts = Path.replace(/\\/g, '/').split('/').filter(function (P) { return P.length > 0; });
    return {
        DirParts: Parts.slice(0, Parts.length - 1),
        FileName: Parts[Parts.length - 1]
    };
}

async function PrtaskOpfsInit() {
    await GetOpfsRoot();
    var Root = GetRoot();
    for (var I = 0; I < RootDirs.length; I++) {
        await Root.getDirectoryHandle(RootDirs[I], { create: true });
    }
}

async function PrtaskOpfsWriteFile(Path, Content) {
    var Root = GetRoot();
    if (Root === null) return;
    if (Root === null) return;
    if (Root === null) return;
    var Parsed = SplitPath(Path);
    var Dir = await NavigateToDir(Root, Parsed.DirParts);
    var FileHandle = await Dir.getFileHandle(Parsed.FileName, { create: true });
    var Writable = await FileHandle.createWritable();
    await Writable.write(Content);
    await Writable.close();
}

async function PrtaskOpfsReadFile(Path) {
    try {
        var Root = GetRoot();
        if (Root === null) return null;
        var Parsed = SplitPath(Path);
        var Dir = await NavigateToDir(Root, Parsed.DirParts);
        var FileHandle = await Dir.getFileHandle(Parsed.FileName);
        var File = await FileHandle.getFile();
        return await File.text();
    } catch (E) {
        if (E.name === 'NotFoundError') return null;
        throw E;
    }
}

async function PrtaskOpfsDeleteFile(Path) {
    try {
        var Root = GetRoot();
        if (Root === null) return;
        if (Root === null) return;
        if (Root === null) return;
        var Parsed = SplitPath(Path);
        var Dir = await NavigateToDir(Root, Parsed.DirParts);
        await Dir.removeEntry(Parsed.FileName);
    } catch (E) {
        if (E.name === 'NotFoundError') return;
        throw E;
    }
}

async function PrtaskOpfsListFiles(Directory) {
    try {
        var Root = GetRoot();
        if (Root === null) return [];
        if (Root === null) return [];
        if (Root === null) return [];
        var Parts = Directory.replace(/\\/g, '/').split('/').filter(function (P) { return P.length > 0; });
        var Dir = await NavigateToDir(Root, Parts);
        var Names = [];
        for await (var Entry of Dir.values()) {
            Names.push(Entry.name);
        }
        return Names;
    } catch (E) {
        if (E.name === 'NotFoundError') return [];
        throw E;
    }
}

async function PrtaskOpfsFileExists(Path) {
    try {
        var Root = GetRoot();
        if (Root === null) return false;
        if (Root === null) return false;
        if (Root === null) return false;
        var Parsed = SplitPath(Path);
        var Dir = await NavigateToDir(Root, Parsed.DirParts);
        await Dir.getFileHandle(Parsed.FileName);
        return true;
    } catch (E) {
        if (E.name === 'NotFoundError') return false;
        throw E;
    }
}

async function PrtaskOpfsWriteBytes(Path, Bytes) {
    var Root = GetRoot();
    if (Root === null) return;
    if (Root === null) return;
    if (Root === null) return;
    var Parsed = SplitPath(Path);
    var Dir = await NavigateToDir(Root, Parsed.DirParts);
    var FileHandle = await Dir.getFileHandle(Parsed.FileName, { create: true });
    var Writable = await FileHandle.createWritable();
    await Writable.write(Bytes);
    await Writable.close();
}

async function PrtaskOpfsReadBytes(Path) {
    try {
        var Root = GetRoot();
        if (Root === null) return null;
        if (Root === null) return null;
        if (Root === null) return null;
        var Parsed = SplitPath(Path);
        var Dir = await NavigateToDir(Root, Parsed.DirParts);
        var FileHandle = await Dir.getFileHandle(Parsed.FileName);
        var File = await FileHandle.getFile();
        var Buffer = await File.arrayBuffer();
        return new Uint8Array(Buffer);
    } catch (E) {
        if (E.name === 'NotFoundError') return null;
        throw E;
    }
}

async function PrtaskOpfsGetDirectoryHandle() {
    return GetRoot();
}

async function PrtaskOpfsIsInitialized() {
    return IsInitialized();
}

async function PrtaskOpfsIsInitialized() {
    return IsInitialized();
}

async function PrtaskOpfsIsInitialized() {
    return IsInitialized();
}

async function PrtaskOpfsRequestPermission() {
    return true;
}

async function ReadJsonFile(Path) {
    var Text = await PrtaskOpfsReadFile(Path);
    if (Text === null) return null;
    return JSON.parse(Text);
}

async function WriteJsonFile(Path, Data) {
    await PrtaskOpfsWriteFile(Path, JSON.stringify(Data));
}

async function PrtaskOpfsGetRecords(Collection) {
    var Records = await ReadJsonFile('Data/' + Collection + '.json');
    if (Records === null) return [];
    return Records;
}

async function PrtaskOpfsGetRecord(Collection, Id) {
    var Records = await PrtaskOpfsGetRecords(Collection);
    for (var I = 0; I < Records.length; I++) {
        if (Records[I].Id === Id) return Records[I];
    }
    return null;
}

async function PrtaskOpfsSaveRecord(Collection, Record) {
    var Path = 'Data/' + Collection + '.json';
    var Records = await ReadJsonFile(Path);
    if (Records === null) {
        Records = [Record];
    } else {
        var Found = false;
        for (var I = 0; I < Records.length; I++) {
            if (Records[I].Id === Record.Id) {
                Records[I] = Record;
                Found = true;
                break;
            }
        }
        if (!Found) {
            Records.push(Record);
        }
    }
    await WriteJsonFile(Path, Records);
}

async function PrtaskOpfsDeleteRecord(Collection, Id) {
    var Path = 'Data/' + Collection + '.json';
    var Records = await ReadJsonFile(Path);
    if (Records === null) return;
    var Filtered = Records.filter(function (R) { return R.Id !== Id; });
    await WriteJsonFile(Path, Filtered);
}

async function PrtaskOpfsQueueMutation(Mutation) {
    if (!IsInitialized()) return;
    var Path = 'Meta/Queue.json';
    var Queue = await ReadJsonFile(Path);
    if (Queue === null) Queue = [];
    Queue.push(Mutation);
    await WriteJsonFile(Path, Queue);
}

async function PrtaskOpfsGetQueue() {
    var Queue = await ReadJsonFile('Meta/Queue.json');
    if (Queue === null) return [];
    return Queue;
}

async function PrtaskOpfsClearQueue() {
    await WriteJsonFile('Meta/Queue.json', []);
}

async function PrtaskOpfsGetMeta(Key) {
    var Meta = await ReadJsonFile('Meta/Sync.json');
    if (Meta === null) return null;
    return Meta.hasOwnProperty(Key) ? Meta[Key] : null;
}

async function PrtaskOpfsSetMeta(Key, Value) {
    var Path = 'Meta/Sync.json';
    var Meta = await ReadJsonFile(Path);
    if (Meta === null) Meta = {};
    Meta[Key] = Value;
    await WriteJsonFile(Path, Meta);
}

async function PrtaskCheckGitInit(DirHandle) {
    try {
        await DirHandle.getDirectoryHandle('.git');
        return true;
    } catch (E) {
        return false;
    }
}

// ── Auto-init OPFS on load ─────────────────────────────────────

(async function () {
    try {
        await GetOpfsRoot();
        var Root = GetRoot();
        for (var I = 0; I < RootDirs.length; I++) {
            await Root.getDirectoryHandle(RootDirs[I], { create: true });
        }
    } catch (E) { /* OPFS not available */ }
})();

async function PrtaskCheckGitInit(DirHandle) {
    try {
        await DirHandle.getDirectoryHandle('.git');
        return true;
    } catch {
        return false;
    }
}

async function PrtaskCheckGitInit(DirHandle) {
    try {
        await DirHandle.getDirectoryHandle('.git');
        return true;
    } catch {
        return false;
    }
}

async function PrtaskCheckGitInit(DirHandle) {
    try {
        await DirHandle.getDirectoryHandle('.git');
        return true;
    } catch {
        return false;
    }
}

// Auto-restore directory handle from IndexedDB on load (silent, no prompt)
(async function () {
    try {
        var Handle = await LoadHandleFromDb();
        if (Handle !== null) {
            var Perm = await Handle.queryPermission({ mode: 'readwrite' });
            if (Perm === 'granted') {
                StoredDirectoryHandle = Handle;
            }
        }
    } catch (E) { /* ignore — user will Init manually */ }
})();

window.PrtaskOpfs = {
    Init: PrtaskOpfsInit,
    IsInitialized: PrtaskOpfsIsInitialized,
    CheckGitInit: PrtaskCheckGitInit,
    CheckGitInit: PrtaskCheckGitInit,
    CheckGitInit: PrtaskCheckGitInit,
    IsInitialized: PrtaskOpfsIsInitialized,
    CheckGitInit: PrtaskCheckGitInit,
    WriteFile: PrtaskOpfsWriteFile,
    ReadFile: PrtaskOpfsReadFile,
    DeleteFile: PrtaskOpfsDeleteFile,
    ListFiles: PrtaskOpfsListFiles,
    FileExists: PrtaskOpfsFileExists,
    WriteBytes: PrtaskOpfsWriteBytes,
    ReadBytes: PrtaskOpfsReadBytes,
    GetRecords: PrtaskOpfsGetRecords,
    GetRecord: PrtaskOpfsGetRecord,
    SaveRecord: PrtaskOpfsSaveRecord,
    DeleteRecord: PrtaskOpfsDeleteRecord,
    QueueMutation: PrtaskOpfsQueueMutation,
    GetQueue: PrtaskOpfsGetQueue,
    ClearQueue: PrtaskOpfsClearQueue,
    GetMeta: PrtaskOpfsGetMeta,
    SetMeta: PrtaskOpfsSetMeta,
    GetDirectoryHandle: PrtaskOpfsGetDirectoryHandle,
    RequestPermission: PrtaskOpfsRequestPermission
};


