var DbName = 'prtask-sync';
var StoreName = 'automerge-docs';
var DbVersion = 1;

function openDb() {
    return new Promise(function (resolve, reject) {
        var request = indexedDB.open(DbName, DbVersion);
        request.onupgradeneeded = function (event) {
            var db = event.target.result;
            if (!db.objectStoreNames.contains(StoreName)) {
                db.createObjectStore(StoreName, { keyPath: 'docId' });
            }
        };
        request.onsuccess = function (event) { resolve(event.target.result); };
        request.onerror = function (event) { reject(event.target.error); };
    });
}

async function saveDocument(docId, bytes) {
    var db = await openDb();
    return new Promise(function (resolve, reject) {
        var tx = db.transaction(StoreName, 'readwrite');
        var store = tx.objectStore(StoreName);
        store.put({ docId: docId, bytes: bytes, updatedAt: Date.now() });
        tx.oncomplete = function () { resolve(); };
        tx.onerror = function (event) { reject(event.target.error); };
    });
}

async function loadDocument(docId) {
    var db = await openDb();
    return new Promise(function (resolve, reject) {
        var tx = db.transaction(StoreName, 'readonly');
        var store = tx.objectStore(StoreName);
        var request = store.get(docId);
        request.onsuccess = function (event) { resolve(event.target.result || null); };
        request.onerror = function (event) { reject(event.target.error); };
    });
}

async function deleteDocument(docId) {
    var db = await openDb();
    return new Promise(function (resolve, reject) {
        var tx = db.transaction(StoreName, 'readwrite');
        var store = tx.objectStore(StoreName);
        store.delete(docId);
        tx.oncomplete = function () { resolve(); };
        tx.onerror = function (event) { reject(event.target.error); };
    });
}

async function listDocuments() {
    var db = await openDb();
    return new Promise(function (resolve, reject) {
        var tx = db.transaction(StoreName, 'readonly');
        var store = tx.objectStore(StoreName);
        var request = store.getAll();
        request.onsuccess = function (event) { resolve(event.target.result); };
        request.onerror = function (event) { reject(event.target.error); };
    });
}

window.prtaskIndexedDb = {
    saveDocument: saveDocument,
    loadDocument: loadDocument,
    deleteDocument: deleteDocument,
    listDocuments: listDocuments
};
