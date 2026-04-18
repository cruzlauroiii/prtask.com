//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

const e=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,4,1,96,0,0,3,2,1,0,10,8,1,6,0,6,64,25,11,11])),t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),n=Symbol.for("wasm promise_control");function i(e,t){let o=null;const i=new Promise(function(n,i){o={isDone:!1,promise:null,resolve:t=>{o.isDone||(o.isDone=!0,n(t),e&&e())},reject:e=>{o.isDone||(o.isDone=!0,i(e),t&&t())}}});o.promise=i;const r=i;return r[n]=o,{promise:r,promise_control:o}}function r(e){return e[n]}function s(e){e&&function(e){return void 0!==e[n]}(e)||Fe(!1,"Promise is not controllable")}const a="__mono_message__",l=["debug","log","trace","warn","info","error"],c="MONO_WASM: ";let d,u,f,m,g,p;function h(e){m=e}function b(e){if(Oe.diagnosticTracing){const t="function"==typeof e?e():e;console.debug(c+t)}}function w(e,...t){console.info(c+e,...t)}function y(e,...t){console.info(e,...t)}function v(e,...t){console.warn(c+e,...t)}function _(e,...t){if(t&&t.length>0&&t[0]&&"object"==typeof t[0]){if(t[0].silent)return;if(t[0].toString)return void console.error(c+e,t[0].toString())}console.error(c+e,...t)}function E(e,t,o){return function(...n){try{let i=n[0];if(void 0===i)i="undefined";else if(null===i)i="null";else if("function"==typeof i)i=i.toString();else if("string"!=typeof i)try{i=JSON.stringify(i)}catch(e){i=i.toString()}t(o?JSON.stringify({method:e,payload:i,arguments:n.slice(1)}):[e+i,...n.slice(1)])}catch(e){f.error(`proxyConsole failed: ${e}`)}}}function R(e,t,o){u=t,m=e,f={...t};const n=`${o}/console`.replace("https://","wss://").replace("http://","ws://");d=new WebSocket(n),d.addEventListener("error",x),d.addEventListener("close",A),function(){for(const e of l)u[e]=E(`console.${e}`,T,!0)}()}function j(e){let t=30;const o=()=>{d?0==d.bufferedAmount||0==t?(e&&y(e),function(){for(const e of l)u[e]=E(`console.${e}`,f.log,!1)}(),d.removeEventListener("error",x),d.removeEventListener("close",A),d.close(1e3,e),d=void 0):(t--,globalThis.setTimeout(o,100)):e&&f&&f.log(e)};o()}function T(e){d&&d.readyState===WebSocket.OPEN?d.send(e):f.log(e)}function x(e){f.error(`[${m}] proxy console websocket error: ${e}`,e)}function A(e){f.debug(`[${m}] proxy console websocket closed: ${e}`,e)}function S(){Oe.preferredIcuAsset=D(Oe.config);let e="invariant"==Oe.config.globalizationMode;if(!e)if(Oe.preferredIcuAsset)Oe.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===Oe.config.globalizationMode||"all"===Oe.config.globalizationMode||"sharded"===Oe.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}Oe.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,Oe.preferredIcuAsset=null}const t="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",o=Oe.config.environmentVariables;if(void 0===o[t]&&e&&(o[t]="1"),void 0===o.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(o.TZ=e)}catch(e){w("failed to detect timezone, will fallback to UTC")}}function D(e){var t;if((null===(t=e.resources)||void 0===t?void 0:t.icu)&&"invariant"!=e.globalizationMode){const t=e.applicationCulture||(Me?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale);e.applicationCulture||(e.applicationCulture=t);const o=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(o.length>=1)return o[0].name}else t&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const t=e.split("-")[0];return"en"===t||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(t)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(t)):n="icudt.dat";if(n)for(let e=0;e<o.length;e++){const t=o[e];if(t.virtualPath===n)return t.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const k=class{constructor(e){this.url=e}toString(){return this.url}};async function M(e,t){try{const o="function"==typeof globalThis.fetch;if(Ae){const n=e.startsWith("file://");if(!n&&o)return globalThis.fetch(e,t||{credentials:"same-origin"});g||(p=await import(/*! webpackIgnore: true */"url"),g=await import(/*! webpackIgnore: true */"fs")),n&&(e=p.fileURLToPath(e));const i=await g.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>i,json:()=>JSON.parse(i),text:()=>{throw new Error("NotImplementedException")}}}if(o)return globalThis.fetch(e,t||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(t){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t},text:()=>{throw t}}}throw new Error("No fetch implementation available")}function C(e){return"string"!=typeof e&&Fe(!1,"url must be a string"),!P(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}const I=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,O=/[a-zA-Z]:[\\/]/;function P(e){return Ae||Ce?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||O.test(e):I.test(e)}let U,L=0;const N=[],$=[],z=new Map,W={"js-module-threads":!0,"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},F={...W,"js-module-library-initializer":!0},B={...W,dotnetwasm:!0,heap:!0,manifest:!0},V={...F,manifest:!0},H={...F,dotnetwasm:!0},J={dotnetwasm:!0,symbols:!0},q={...F,dotnetwasm:!0,symbols:!0},Q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=Oe.preferredIcuAsset)}function Z(e,t,o){null!=t||(t=[]),Fe(1==t.length,`Expect to have one ${o} asset in resources`);const n=t[0];return n.behavior=o,K(n),e.push(n),n}function K(e){B[e.behavior]&&z.set(e.behavior,e)}function X(e){Fe(B[e],`Unknown single asset behavior ${e}`);const t=z.get(e);if(t&&!t.resolvedUrl)if(t.resolvedUrl=Oe.locateFile(t.name),W[t.behavior]){const e=me(t);e?("string"!=typeof e&&Fe(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),t.resolvedUrl=e):t.resolvedUrl=le(t.resolvedUrl,t.behavior)}else if("dotnetwasm"!==t.behavior)throw new Error(`Unknown single asset behavior ${e}`);return t}function Y(e){const t=X(e);return Fe(t,`Single asset for ${e} not found`),t}let ee=!1;async function te(){if(!ee){ee=!0,Oe.diagnosticTracing&&b("mono_download_assets");try{const e=[],t=[],o=(e,t)=>{!q[e.behavior]&&G(e)&&Oe.expected_instantiated_assets_count++,!H[e.behavior]&&G(e)&&(Oe.expected_downloaded_assets_count++,t.push(re(e)))};for(const t of N)o(t,e);for(const e of $)o(e,t);Oe.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...t]).then(()=>{Oe.allDownloadsFinished.promise_control.resolve()}).catch(e=>{throw Oe.err("Error in mono_download_assets: "+e),Ke(1,e),e}),await Oe.runtimeModuleLoaded.promise;const n=async e=>{const t=await e;if(t.buffer){if(!q[t.behavior]){t.buffer&&"object"==typeof t.buffer||Fe(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof t.resolvedUrl&&Fe(!1,"resolvedUrl must be string");const e=t.resolvedUrl,o=await t.buffer,n=new Uint8Array(o);ge(t),await Ie.beforeOnRuntimeInitialized.promise,await Ie.afterInstantiateWasm.promise,Ie.instantiate_asset(t,e,n)}}else J[t.behavior]?("symbols"===t.behavior&&(await Ie.instantiate_symbols_asset(t),ge(t)),J[t.behavior]&&++Oe.actual_downloaded_assets_count):(t.isOptional||Fe(!1,"Expected asset to have the downloaded buffer"),!H[t.behavior]&&G(t)&&Oe.expected_downloaded_assets_count--,!q[t.behavior]&&G(t)&&Oe.expected_instantiated_assets_count--)},i=[],r=[];for(const t of e)i.push(n(t));for(const e of t)r.push(n(e));Promise.all(i).then(()=>{ke||Ie.coreAssetsInMemory.promise_control.resolve()}).catch(e=>{throw Oe.err("Error in mono_download_assets: "+e),Ke(1,e),e}),Promise.all(r).then(async()=>{ke||(await Ie.coreAssetsInMemory.promise,Ie.allAssetsInMemory.promise_control.resolve())}).catch(e=>{throw Oe.err("Error in mono_download_assets: "+e),Ke(1,e),e})}catch(e){throw Oe.err("Error in mono_download_assets: "+e),e}}}let oe=!1;function ne(){if(oe)return;oe=!0;const e=Oe.config,t=[];if(e.assets)for(const t of e.assets)"object"!=typeof t&&Fe(!1,`asset must be object, it was ${typeof t} : ${t}`),"string"!=typeof t.behavior&&Fe(!1,"asset behavior must be known string"),"string"!=typeof t.name&&Fe(!1,"asset name must be string"),t.resolvedUrl&&"string"!=typeof t.resolvedUrl&&Fe(!1,"asset resolvedUrl could be string"),t.hash&&"string"!=typeof t.hash&&Fe(!1,"asset resolvedUrl could be string"),t.pendingDownload&&"object"!=typeof t.pendingDownload&&Fe(!1,"asset pendingDownload could be object"),t.isCore?N.push(t):$.push(t),K(t);else if(e.resources){const o=e.resources;o.wasmNative||Fe(!1,"resources.wasmNative must be defined"),o.jsModuleNative||Fe(!1,"resources.jsModuleNative must be defined"),o.jsModuleRuntime||Fe(!1,"resources.jsModuleRuntime must be defined"),Z($,o.wasmNative,"dotnetwasm"),Z(t,o.jsModuleNative,"js-module-native"),Z(t,o.jsModuleRuntime,"js-module-runtime"),o.jsModuleDiagnostics&&Z(t,o.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,t,o)=>{const n=e;n.behavior=t,o?(n.isCore=!0,N.push(n)):$.push(n)};if(o.coreAssembly)for(let e=0;e<o.coreAssembly.length;e++)n(o.coreAssembly[e],"assembly",!0);if(o.assembly)for(let e=0;e<o.assembly.length;e++)n(o.assembly[e],"assembly",!o.coreAssembly);if(0!=e.debugLevel&&Oe.isDebuggingSupported()){if(o.corePdb)for(let e=0;e<o.corePdb.length;e++)n(o.corePdb[e],"pdb",!0);if(o.pdb)for(let e=0;e<o.pdb.length;e++)n(o.pdb[e],"pdb",!o.corePdb)}if(e.loadAllSatelliteResources&&o.satelliteResources)for(const e in o.satelliteResources)for(let t=0;t<o.satelliteResources[e].length;t++){const i=o.satelliteResources[e][t];i.culture=e,n(i,"resource",!o.coreAssembly)}if(o.coreVfs)for(let e=0;e<o.coreVfs.length;e++)n(o.coreVfs[e],"vfs",!0);if(o.vfs)for(let e=0;e<o.vfs.length;e++)n(o.vfs[e],"vfs",!o.coreVfs);const i=D(e);if(i&&o.icu)for(let e=0;e<o.icu.length;e++){const t=o.icu[e];t.name===i&&n(t,"icu",!1)}if(o.wasmSymbols)for(let e=0;e<o.wasmSymbols.length;e++)n(o.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let t=0;t<e.appsettings.length;t++){const o=e.appsettings[t],n=pe(o);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||$.push({name:o,behavior:"vfs",cache:"no-cache",useCredentials:!0})}e.assets=[...N,...$,...t]}async function ie(e){const t=await re(e);return await t.pendingDownloadInternal.response,t.buffer}async function re(e){try{return await se(e)}catch(t){if(!Oe.enableDownloadRetry)throw t;if(Ce||Ae)throw t;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw t;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw t;if(t&&404==t.status)throw t;e.pendingDownloadInternal=void 0,await Oe.allDownloadsQueued.promise;try{return Oe.diagnosticTracing&&b(`Retrying download '${e.name}'`),await se(e)}catch(t){return e.pendingDownloadInternal=void 0,await new Promise(e=>globalThis.setTimeout(e,100)),Oe.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await se(e)}}}async function se(e){for(;U;)await U.promise;try{++L,L==Oe.maxParallelDownloads&&(Oe.diagnosticTracing&&b("Throttling further parallel downloads"),U=i());const t=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const t=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>t,json:()=>JSON.parse(new TextDecoder("utf-8").decode(t)),text:()=>{throw new Error("NotImplementedException")},headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const t=e.loadRemote&&Oe.config.remoteSources?Oe.config.remoteSources:[""];let o;for(let n of t){n=n.trim(),"./"===n&&(n="");const t=ae(e,n);e.name===t?Oe.diagnosticTracing&&b(`Attempting to download '${t}'`):Oe.diagnosticTracing&&b(`Attempting to download '${t}' for ${e.name}`);try{e.resolvedUrl=t;const n=ue(e);if(e.pendingDownloadInternal=n,o=await n.response,!o||!o.ok)continue;return o}catch(e){o||(o={ok:!1,url:t,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&Oe.config.ignorePdbLoadErrors;if(o||Fe(!1,`Response undefined ${e.name}`),!n){const t=new Error(`download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`);throw t.status=o.status,t}w(`optional download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`)}(e);return t?(J[e.behavior]||(e.buffer=await t.arrayBuffer(),++Oe.actual_downloaded_assets_count),e):e}finally{if(--L,U&&L==Oe.maxParallelDownloads-1){Oe.diagnosticTracing&&b("Resuming more parallel downloads");const e=U;U=void 0,e.promise_control.resolve()}}}function ae(e,t){let o;return null==t&&Fe(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?o=e.resolvedUrl:(o=""===t?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:t+e.name,o=le(Oe.locateFile(o),e.behavior)),o&&"string"==typeof o||Fe(!1,"attemptUrl need to be path or url string"),o}function le(e,t){return Oe.modulesUniqueQuery&&V[t]&&(e+=Oe.modulesUniqueQuery),e}let ce=0;const de=new Set;function ue(e){try{e.resolvedUrl||Fe(!1,"Request's resolvedUrl must be set");const t=function(e){let t=e.resolvedUrl;if(Oe.loadBootResource){const o=me(e);if(o instanceof Promise)return o;"string"==typeof o&&(t=o)}const o={};return e.cache?o.cache=e.cache:Oe.config.disableNoCacheFetch||(o.cache="no-cache"),e.useCredentials?o.credentials="include":!Oe.config.disableIntegrityCheck&&e.hash&&(o.integrity=e.hash),Oe.fetch_like(t,o)}(e),o={name:e.name,url:e.resolvedUrl,response:t};return de.add(e.name),o.response.then(()=>{"assembly"==e.behavior&&Oe.loadedAssemblies.push(e.name),ce++,Oe.onDownloadResourceProgress&&Oe.onDownloadResourceProgress(ce,de.size)}),o}catch(t){const o={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(o)}}}const fe={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs","js-module-threads":"dotnetjs"};function me(e){var t;if(Oe.loadBootResource){const o=null!==(t=e.hash)&&void 0!==t?t:"",n=e.resolvedUrl,i=fe[e.behavior];if(i){const t=Oe.loadBootResource(i,e.name,n,o,e.behavior);return"string"==typeof t?C(t):t}}}function ge(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function pe(e){let t=e.lastIndexOf("/");return t>=0&&t++,e.substring(t)}async function he(e){e&&await Promise.all((null!=e?e:[]).map(e=>async function(e){try{const t=e.name;if(!e.moduleExports){const o=le(Oe.locateFile(t),"js-module-library-initializer");Oe.diagnosticTracing&&b(`Attempting to import '${o}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */o)}Oe.libraryInitializers.push({scriptName:t,exports:e.moduleExports})}catch(t){v(`Failed to import library initializer '${e}': ${t}`)}}(e)))}async function be(e,t){if(!Oe.libraryInitializers)return;const o=[];for(let n=0;n<Oe.libraryInitializers.length;n++){const i=Oe.libraryInitializers[n];i.exports[e]&&o.push(we(i.scriptName,e,()=>i.exports[e](...t)))}await Promise.all(o)}async function we(e,t,o){try{await o()}catch(o){throw v(`Failed to invoke '${t}' on library initializer '${e}': ${o}`),Ke(1,o),o}}function ye(e,t){if(e===t)return e;const o={...t};return void 0!==o.assets&&o.assets!==e.assets&&(o.assets=[...e.assets||[],...o.assets||[]]),void 0!==o.resources&&(o.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},o.resources)),void 0!==o.environmentVariables&&(o.environmentVariables={...e.environmentVariables||{},...o.environmentVariables||{}}),void 0!==o.runtimeOptions&&o.runtimeOptions!==e.runtimeOptions&&(o.runtimeOptions=[...e.runtimeOptions||[],...o.runtimeOptions||[]]),Object.assign(e,o)}function ve(e,t){if(e===t)return e;const o={...t};return o.config&&(e.config||(e.config={}),o.config=ye(e.config,o.config)),Object.assign(e,o)}function _e(e,t){if(e===t)return e;const o={...t};return void 0!==o.coreAssembly&&(o.coreAssembly=[...e.coreAssembly||[],...o.coreAssembly||[]]),void 0!==o.assembly&&(o.assembly=[...e.assembly||[],...o.assembly||[]]),void 0!==o.lazyAssembly&&(o.lazyAssembly=[...e.lazyAssembly||[],...o.lazyAssembly||[]]),void 0!==o.corePdb&&(o.corePdb=[...e.corePdb||[],...o.corePdb||[]]),void 0!==o.pdb&&(o.pdb=[...e.pdb||[],...o.pdb||[]]),void 0!==o.jsModuleWorker&&(o.jsModuleWorker=[...e.jsModuleWorker||[],...o.jsModuleWorker||[]]),void 0!==o.jsModuleNative&&(o.jsModuleNative=[...e.jsModuleNative||[],...o.jsModuleNative||[]]),void 0!==o.jsModuleDiagnostics&&(o.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...o.jsModuleDiagnostics||[]]),void 0!==o.jsModuleRuntime&&(o.jsModuleRuntime=[...e.jsModuleRuntime||[],...o.jsModuleRuntime||[]]),void 0!==o.wasmSymbols&&(o.wasmSymbols=[...e.wasmSymbols||[],...o.wasmSymbols||[]]),void 0!==o.wasmNative&&(o.wasmNative=[...e.wasmNative||[],...o.wasmNative||[]]),void 0!==o.icu&&(o.icu=[...e.icu||[],...o.icu||[]]),void 0!==o.satelliteResources&&(o.satelliteResources=function(e,t){if(e===t)return e;for(const o in t)e[o]=[...e[o]||[],...t[o]||[]];return e}(e.satelliteResources||{},o.satelliteResources||{})),void 0!==o.modulesAfterConfigLoaded&&(o.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...o.modulesAfterConfigLoaded||[]]),void 0!==o.modulesAfterRuntimeReady&&(o.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...o.modulesAfterRuntimeReady||[]]),void 0!==o.extensions&&(o.extensions={...e.extensions||{},...o.extensions||{}}),void 0!==o.vfs&&(o.vfs=[...e.vfs||[],...o.vfs||[]]),Object.assign(e,o)}function Ee(){const e=Oe.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleWorker:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){Oe.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const t of e.assets){const o={};switch(t.behavior){case"assembly":o.assembly=[t];break;case"pdb":o.pdb=[t];break;case"resource":o.satelliteResources={},o.satelliteResources[t.culture]=[t];break;case"icu":o.icu=[t];break;case"symbols":o.wasmSymbols=[t];break;case"vfs":o.vfs=[t];break;case"dotnetwasm":o.wasmNative=[t];break;case"js-module-threads":o.jsModuleWorker=[t];break;case"js-module-runtime":o.jsModuleRuntime=[t];break;case"js-module-native":o.jsModuleNative=[t];break;case"js-module-diagnostics":o.jsModuleDiagnostics=[t];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${t.behavior} of asset ${t.name}`)}_e(e.resources,o)}}e.debugLevel,e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Ie.diagnosticTracing=Oe.diagnosticTracing=!!e.diagnosticTracing,Ie.waitForDebugger=e.waitForDebugger,Oe.maxParallelDownloads=e.maxParallelDownloads||Oe.maxParallelDownloads,Oe.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:Oe.enableDownloadRetry}let Re=!1;async function je(e){var t;if(Re)return void await Oe.afterConfigLoaded.promise;let o;try{if(e.configSrc||Oe.config&&0!==Object.keys(Oe.config).length&&(Oe.config.assets||Oe.config.resources)||(e.configSrc="dotnet.boot.js"),o=e.configSrc,Re=!0,o&&(Oe.diagnosticTracing&&b("mono_wasm_load_config"),await async function(e){const t=e.configSrc,o=Oe.locateFile(t);let n=null;void 0!==Oe.loadBootResource&&(n=Oe.loadBootResource("manifest",t,o,"","manifest"));let i,r=null;if(n)if("string"==typeof n)n.includes(".json")?(r=await s(C(n)),i=await xe(r)):i=(await import(C(n))).config;else{const e=await n;"function"==typeof e.json?(r=e,i=await xe(r)):i=e.config}else o.includes(".json")?(r=await s(le(o,"manifest")),i=await xe(r)):i=(await import(le(o,"manifest"))).config;function s(e){return Oe.fetch_like(e,{method:"GET",credentials:"include",cache:"no-cache"})}Oe.config.applicationEnvironment&&(i.applicationEnvironment=Oe.config.applicationEnvironment),ye(Oe.config,i)}(e)),Ee(),await he(null===(t=Oe.config.resources)||void 0===t?void 0:t.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[Oe.config]),e.onConfigLoaded)try{await e.onConfigLoaded(Oe.config,Ue),Ee()}catch(e){throw _("onConfigLoaded() failed",e),e}Ee(),Oe.afterConfigLoaded.promise_control.resolve(Oe.config)}catch(t){const n=`Failed to load config file ${o} ${t} ${null==t?void 0:t.stack}`;throw Oe.config=e.config=Object.assign(Oe.config,{message:n,error:t,isError:!0}),Ke(1,new Error(n)),t}}function Te(){return!!globalThis.navigator&&(Oe.isChromium||Oe.isFirefox)}async function xe(e){const t=Oe.config,o=await e.json();t.applicationEnvironment||o.applicationEnvironment||(o.applicationEnvironment=e.headers.get("Blazor-Environment")||e.headers.get("DotNet-Environment")||void 0),o.environmentVariables||(o.environmentVariables={});const n=e.headers.get("DOTNET-MODIFIABLE-ASSEMBLIES");n&&(o.environmentVariables.DOTNET_MODIFIABLE_ASSEMBLIES=n);const i=e.headers.get("ASPNETCORE-BROWSER-TOOLS");return i&&(o.environmentVariables.__ASPNETCORE_BROWSER_TOOLS=i),o}"function"==typeof importScripts&&(globalThis.dotnetSidecar=!0);const Ae="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,Se="function"==typeof importScripts,De=Se&&"undefined"!=typeof dotnetSidecar,ke=Se&&!De,Me="object"==typeof window||Se&&!Ae,Ce=!Me&&!Ae;let Ie={},Oe={},Pe={},Ue={},Le={},Ne=!1;const $e={},ze={config:$e},We={mono:{},binding:{},internal:Le,module:ze,loaderHelpers:Oe,runtimeHelpers:Ie,diagnosticHelpers:Pe,api:Ue};function Fe(e,t){if(e)return;const o="Assert failed: "+("function"==typeof t?t():t),n=new Error(o);_(o,n),Ie.nativeAbort(n)}function Be(){return void 0!==Oe.exitCode}function Ve(){return Ie.runtimeReady&&!Be()}function He(){Be()&&Fe(!1,`.NET runtime already exited with ${Oe.exitCode} ${Oe.exitReason}. You can use dotnet.runMain() which doesn't exit the runtime.`),Ie.runtimeReady||Fe(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function Je(){Me&&(globalThis.addEventListener("unhandledrejection",Ye),globalThis.addEventListener("error",et))}let qe,Qe;function Ge(e){Qe&&Qe(e),Ke(e,Oe.exitReason)}function Ze(e){qe&&qe(e||Oe.exitReason),Ke(1,e||Oe.exitReason)}function Ke(e,t){var o;const n=t&&"object"==typeof t;e=n&&"number"==typeof t.status?t.status:void 0===e?-1:e;const i=n&&"string"==typeof t.message?t.message:""+t;(t=n?t:Ie.ExitStatus?function(e,t){const o=new Ie.ExitStatus(e);return o.message=t,o.toString=()=>t,o}(e,i):new Error("Exit with code "+e+" "+i)).status=e,t.message||(t.message=i);const r=""+(t.stack||(new Error).stack);try{Object.defineProperty(t,"stack",{get:()=>r})}catch(e){}const s=!!t.silent;if(t.silent=!0,Be())Oe.diagnosticTracing&&b("mono_exit called after exit");else{try{ze.onAbort==Ze&&(ze.onAbort=qe),ze.onExit==Ge&&(ze.onExit=Qe),Me&&(globalThis.removeEventListener("unhandledrejection",Ye),globalThis.removeEventListener("error",et)),Ie.runtimeReady?(Ie.jiterpreter_dump_stats&&Ie.jiterpreter_dump_stats(!1),0===e&&(null===(o=Oe.config)||void 0===o?void 0:o.interopCleanupOnExit)&&Ie.forceDisposeProxies(!0,!0)):(Oe.diagnosticTracing&&b(`abort_startup, reason: ${t}`),function(e){Oe.allDownloadsQueued.promise_control.reject(e),Oe.allDownloadsFinished.promise_control.reject(e),Oe.afterConfigLoaded.promise_control.reject(e),Oe.wasmCompilePromise.promise_control.reject(e),Oe.runtimeModuleLoaded.promise_control.reject(e),Ie.dotnetReady&&(Ie.dotnetReady.promise_control.reject(e),Ie.afterInstantiateWasm.promise_control.reject(e),Ie.afterPreRun.promise_control.reject(e),Ie.beforeOnRuntimeInitialized.promise_control.reject(e),Ie.afterOnRuntimeInitialized.promise_control.reject(e),Ie.afterPostRun.promise_control.reject(e))}(t))}catch(e){v("mono_exit A failed",e)}try{s||(function(e,t){if(0!==e&&t){const e=Ie.ExitStatus&&t instanceof Ie.ExitStatus?b:_;"string"==typeof t?e(t):(void 0===t.stack&&(t.stack=(new Error).stack+""),t.message?e(Ie.stringify_as_error_with_stack?Ie.stringify_as_error_with_stack(t.message+"\n"+t.stack):t.message+"\n"+t.stack):e(JSON.stringify(t)))}!ke&&Oe.config&&(Oe.config.logExitCode?Oe.config.forwardConsole?j("WASM EXIT "+e):y("WASM EXIT "+e):Oe.config.forwardConsole&&j())}(e,t),function(e){if(Me&&!ke&&Oe.config&&Oe.config.appendElementOnExit&&document){const t=document.createElement("label");t.id="tests_done",0!==e&&(t.style.background="red"),t.innerHTML=""+e,document.body.appendChild(t)}}(e))}catch(e){v("mono_exit B failed",e)}Oe.exitCode=e,Oe.exitReason||(Oe.exitReason=t),!ke&&Ie.runtimeReady&&ze.runtimeKeepalivePop()}if(Oe.config&&Oe.config.asyncFlushOnExit&&0===e)throw(async()=>{try{await async function(){try{const e=await import(/*! webpackIgnore: true */"process"),t=e=>new Promise((t,o)=>{e.on("error",o),e.end("","utf8",t)}),o=t(e.stderr),n=t(e.stdout);let i;const r=new Promise(e=>{i=setTimeout(()=>e("timeout"),1e3)});await Promise.race([Promise.all([n,o]),r]),clearTimeout(i)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Xe(e,t)}})(),t;Xe(e,t)}function Xe(e,t){if(Ie.runtimeReady&&Ie.nativeExit)try{Ie.nativeExit(e)}catch(e){!Ie.ExitStatus||e instanceof Ie.ExitStatus||v("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!Me)throw Ae?process.exit(e):Ie.quit&&Ie.quit(e,t),t}function Ye(e){tt(e,e.reason,"rejection")}function et(e){tt(e,e.error,"error")}function tt(e,t,o){e.preventDefault();try{t||(t=new Error("Unhandled "+o)),void 0===t.stack&&(t.stack=(new Error).stack),t.stack=t.stack+"",t.silent||(_("Unhandled error:",t),Ke(1,t))}catch(e){}}!function(n){if(Ne)throw new Error("Loader module already loaded");Ne=!0,Ie=n.runtimeHelpers,Oe=n.loaderHelpers,Pe=n.diagnosticHelpers,Ue=n.api,Le=n.internal,Object.assign(Ue,{INTERNAL:Le,invokeLibraryInitializers:be}),Object.assign(n.module,{config:ye($e,{environmentVariables:{}})});const a={mono_wasm_bindings_is_ready:!1,config:n.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"87bc0b04e21d786669142109a5128c95618b75ed",config:n.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:i(),allDownloadsQueued:i(),allDownloadsFinished:i(),wasmCompilePromise:i(),runtimeModuleLoaded:i(),loadingWorkers:i(),is_exited:Be,is_runtime_running:Ve,assert_runtime_running:He,mono_exit:Ke,createPromiseController:i,getPromiseController:r,assertIsControllablePromise:s,mono_download_assets:te,resolve_single_asset_path:Y,setup_proxy_console:R,set_thread_prefix:h,installUnhandledErrorHandler:Je,retrieve_asset_download:ie,invokeLibraryInitializers:be,isDebuggingSupported:Te,exceptions:e,simd:o,relaxedSimd:t};Object.assign(Ie,a),Object.assign(Oe,l)}(We);let ot,nt,it,rt=!1,st=!1;async function at(e){if(!st){if(st=!0,Me&&Oe.config.forwardConsole&&void 0!==globalThis.WebSocket&&R("main",globalThis.console,globalThis.location.origin),ze||Fe(!1,"Null moduleConfig"),Oe.config||Fe(!1,"Null moduleConfig.config"),"function"==typeof e){const t=e(We.api);if(t.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(ze,t),ve(ze,t)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");ve(ze,e)}await async function(e){if(Ae){const e=await import(/*! webpackIgnore: true */"process"),t=14;if(e.versions.node.split(".")[0]<t)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${t}. See also https://aka.ms/dotnet-wasm-features`)}const t=/*! webpackIgnore: true */import.meta.url,o=t.indexOf("?");var n;if(o>0&&(Oe.modulesUniqueQuery=t.substring(o)),Oe.scriptUrl=t.replace(/\\/g,"/").replace(/[?#].*/,""),Oe.scriptDirectory=(n=Oe.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",Oe.locateFile=e=>"URL"in globalThis&&globalThis.URL!==k?new URL(e,Oe.scriptDirectory).toString():P(e)?e:Oe.scriptDirectory+e,Oe.fetch_like=M,Oe.out=console.log,Oe.err=console.error,Oe.onDownloadResourceProgress=e.onDownloadResourceProgress,Me&&globalThis.navigator){const e=globalThis.navigator,t=e.userAgentData&&e.userAgentData.brands;t&&t.length>0?Oe.isChromium=t.some(e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand):e.userAgent&&(Oe.isChromium=e.userAgent.includes("Chrome"),Oe.isFirefox=e.userAgent.includes("Firefox"))}void 0===globalThis.URL&&(globalThis.URL=k)}(ze)}}async function lt(e){return await at(e),Oe.config.exitOnUnhandledError&&Je(),qe=ze.onAbort,Qe=ze.onExit,ze.onAbort=Ze,ze.onExit=Ge,ze.ENVIRONMENT_IS_PTHREAD?async function(){(function(){const e=new MessageChannel,t=e.port1,o=e.port2;t.addEventListener("message",e=>{var n,i;n=JSON.parse(e.data.config),i=JSON.parse(e.data.monoThreadInfo),rt?Oe.diagnosticTracing&&b("mono config already received"):(ye(Oe.config,n),Ie.monoThreadInfo=i,Ee(),Oe.diagnosticTracing&&b("mono config received"),rt=!0,Oe.afterConfigLoaded.promise_control.resolve(Oe.config),Me&&n.forwardConsole&&void 0!==globalThis.WebSocket&&Oe.setup_proxy_console("worker-idle",console,globalThis.location.origin)),t.close(),o.close()},{once:!0}),t.start(),self.postMessage({[a]:{monoCmd:"preload",port:o}},[o])})(),await Oe.afterConfigLoaded.promise,function(){const e=Oe.config;e.assets||Fe(!1,"config.assets must be defined");for(const t of e.assets)K(t),Q[t.behavior]&&$.push(t)}(),setTimeout(async()=>{try{await te()}catch(e){Ke(1,e)}},0);const e=ct(),t=await Promise.all(e);return await dt(t),ze}():async function(){var e;await je(ze),ne();const t=ct();(async function(){try{const e=Y("dotnetwasm");await re(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||Fe(!1,"Can't load dotnet.native.wasm");const t=await e.pendingDownloadInternal.response,o=t.headers&&t.headers.get?t.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===o)n=await WebAssembly.compileStreaming(t);else{Me&&"application/wasm"!==o&&v('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await t.arrayBuffer();Oe.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Ce?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,Oe.wasmCompilePromise.promise_control.resolve(n)}catch(e){Oe.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout(async()=>{try{S(),await te()}catch(e){Ke(1,e)}},0);const o=await Promise.all(t);return await dt(o),await Ie.dotnetReady.promise,await he(null===(e=Oe.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[We.api]),Ue}()}function ct(){const e=Y("js-module-runtime"),t=Y("js-module-native");if(ot&&nt)return[ot,nt,it];"object"==typeof e.moduleExports?ot=e.moduleExports:(Oe.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),ot=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof t.moduleExports?nt=t.moduleExports:(Oe.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),nt=import(/*! webpackIgnore: true */t.resolvedUrl));const o=X("js-module-diagnostics");return o&&("object"==typeof o.moduleExports?it=o.moduleExports:(Oe.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),it=import(/*! webpackIgnore: true */o.resolvedUrl))),[ot,nt,it]}async function dt(e){const{initializeExports:t,initializeReplacements:o,configureRuntimeStartup:n,configureEmscriptenStartup:i,configureWorkerStartup:r,setRuntimeGlobals:s,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];s(We),t(We),c&&c.setRuntimeGlobals(We),await n(ze),Oe.runtimeModuleLoaded.promise_control.resolve(),l(()=>(Object.assign(ze,{__dotnet_runtime:{initializeReplacements:o,configureEmscriptenStartup:i,configureWorkerStartup:r,passEmscriptenInternals:a}}),ze)).catch(e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize. See also https://aka.ms/dotnet-wasm-features");throw e})}const ut=new class{withModuleConfig(e){try{return ve(ze,e),this}catch(e){throw Ke(1,e),e}}withInterpreterPgo(e,t){try{return ye($e,{interpreterPgo:e,interpreterPgoSaveDelay:t}),$e.runtimeOptions?$e.runtimeOptions.push("--interp-pgo-recording"):$e.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Ke(1,e),e}}withConfig(e){try{return ye($e,e),this}catch(e){throw Ke(1,e),e}}withConfigSrc(e){try{return e&&"string"==typeof e||Fe(!1,"must be file path or URL"),ve(ze,{configSrc:e}),this}catch(e){throw Ke(1,e),e}}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||Fe(!1,"must be directory path"),ye($e,{virtualWorkingDirectory:e}),this}catch(e){throw Ke(1,e),e}}withEnvironmentVariable(e,t){try{const o={};return o[e]=t,ye($e,{environmentVariables:o}),this}catch(e){throw Ke(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||Fe(!1,"must be dictionary object"),ye($e,{environmentVariables:e}),this}catch(e){throw Ke(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&Fe(!1,"must be boolean"),ye($e,{diagnosticTracing:e}),this}catch(e){throw Ke(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||Fe(!1,"must be number"),ye($e,{debugLevel:e}),this}catch(e){throw Ke(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||Fe(!1,"must be array of strings"),ye($e,{applicationArguments:e}),this}catch(e){throw Ke(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||Fe(!1,"must be array of strings"),$e.runtimeOptions?$e.runtimeOptions.push(...e):$e.runtimeOptions=e,this}catch(e){throw Ke(1,e),e}}withMainAssembly(e){try{return ye($e,{mainAssemblyName:e}),this}catch(e){throw Ke(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Ke(1,e),e}}withApplicationEnvironment(e){try{return ye($e,{applicationEnvironment:e}),this}catch(e){throw Ke(1,e),e}}withApplicationCulture(e){try{return ye($e,{applicationCulture:e}),this}catch(e){throw Ke(1,e),e}}withResourceLoader(e){try{return Oe.loadBootResource=e,this}catch(e){throw Ke(1,e),e}}async download(){try{await async function(){at(ze),await je(ze),ne(),S(),te(),await Oe.allDownloadsFinished.promise}()}catch(e){throw Ke(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await lt(ze),We.api}()),this.instance}catch(e){throw Ke(1,e),e}}run(){return this.runMainAndExit()}async runMainAndExit(){try{return ze.config||Fe(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Ke(1,e),e}}async runMain(){try{return ze.config||Fe(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMain()}catch(e){throw Ke(1,e),e}}},ft=Ke,mt=lt;Ce||"function"==typeof globalThis.URL||Fe(!1,"This browser/engine doesn't support URL API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),"function"!=typeof globalThis.BigInt64Array&&Fe(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),globalThis.performance&&"function"==typeof globalThis.performance.now||Fe(!1,"This browser/engine doesn't support performance.now. Please use a modern version."),Ce||globalThis.crypto&&"object"==typeof globalThis.crypto.subtle||Fe(!1,"This engine doesn't support crypto.subtle. Please use a modern version."),Ce||globalThis.crypto&&"function"==typeof globalThis.crypto.getRandomValues||Fe(!1,"This engine doesn't support crypto.getRandomValues. Please use a modern version."),Ae&&"function"!=typeof process.exit&&Fe(!1,"This engine doesn't support process.exit. Please use a modern version."),ut.withConfig(/*json-start*/{
  "mainAssemblyName": "PrTask.Client",
  "applicationEnvironment": "Development",
  "resources": {
    "hash": "sha256-O5XlGsVUU2UlKdr6VdNWN/5Nswj30s7jsZfTIRFrvig=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.2rms4weyxw.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.kl7gvzuey0.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.e98tyslgbd.wasm",
        "hash": "sha256-EnG1YQBUXPciaJTpEqUPjySbJiNkAjkxOOD4v/SpKyY=",
        "cache": "force-cache"
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt.dat",
        "name": "icudt.g3en5r9teb.dat",
        "hash": "sha256-5BfhzgOGQRjWj996AOsK8ZD97vgGxXD5Ucoy9h+kBH8=",
        "cache": "force-cache"
      }
    ],
    "coreAssembly": [
      {
        "virtualPath": "System.Runtime.InteropServices.JavaScript.wasm",
        "name": "System.Runtime.InteropServices.JavaScript.4n9r9mixxu.wasm",
        "hash": "sha256-kIoS/pjUye8pGCAbEQaGSjkQHmnSEn8PzQoRTg4frAg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.CoreLib.wasm",
        "name": "System.Private.CoreLib.tpkqo7jmbi.wasm",
        "hash": "sha256-YS8/Mr6b0wtyZTkqgwrwd9pf09gA1SMlTiI/+wyBxl8=",
        "cache": "force-cache"
      }
    ],
    "assembly": [
      {
        "virtualPath": "AspNetCore.SassCompiler.wasm",
        "name": "AspNetCore.SassCompiler.xuq25c1gwd.wasm",
        "hash": "sha256-edk4RqSmalUFHPEr7yXCGp2IY9F6rhM4oI2301rg2jI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Authorization.wasm",
        "name": "Microsoft.AspNetCore.Authorization.5bxlh6v1r6.wasm",
        "hash": "sha256-H6tIVeJf7oip4keTaTXYqpjpMKBzomzDIFGcjJIoBqg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.wasm",
        "name": "Microsoft.AspNetCore.Components.ufbvqn79qg.wasm",
        "hash": "sha256-Vu42E2lb1oqarpwo0di3H71yrBDhv98sameDTu6QiXk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.wasm",
        "name": "Microsoft.AspNetCore.Components.Forms.9weg94lsvm.wasm",
        "hash": "sha256-l8cAlG25SQ/AsD4zN3JytaWXzvWX7kLvpFDWzMsDqnQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Web.wasm",
        "name": "Microsoft.AspNetCore.Components.Web.af3npv0zkm.wasm",
        "hash": "sha256-6jkGLfjv/JDmVZ7NUepOOGlFtg/rPq9seE+QmtYvoqg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.wasm",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.qpzcluehil.wasm",
        "hash": "sha256-MjMCJD7ag9yiFMjqxDPkeoZ3jCwPjskV89BkPxLbJuI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Metadata.wasm",
        "name": "Microsoft.AspNetCore.Metadata.er49ged82l.wasm",
        "hash": "sha256-pqce7PkfldaV2b12lNrqsKlaQ/YqSD8dgTivFSwbKCo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.wasm",
        "name": "Microsoft.Extensions.Configuration.tudu6fmogb.wasm",
        "hash": "sha256-pWNMPZESNuUKpXdz9bL+i5Mz+duM0sLx00WajjKyBE0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.wasm",
        "name": "Microsoft.Extensions.Configuration.Abstractions.89aoj3wyx0.wasm",
        "hash": "sha256-FFfgkx69G124mRs/UQfe64TrMe4Rsq6HRFfnsd4YLP4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Binder.wasm",
        "name": "Microsoft.Extensions.Configuration.Binder.c0no7gga62.wasm",
        "hash": "sha256-hE7DrF7omnPgbblqN4LQEUaqXY/cpJRsCr0bDrTxcu8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.EnvironmentVariables.wasm",
        "name": "Microsoft.Extensions.Configuration.EnvironmentVariables.kvb06cnwof.wasm",
        "hash": "sha256-4N0fCPLLahrhmJobhR7V3yOmxfmZb1EG17umYakjWMA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.FileExtensions.wasm",
        "name": "Microsoft.Extensions.Configuration.FileExtensions.28urcllqdf.wasm",
        "hash": "sha256-Pl5hCQULXIGXsncDkYzDcSODNAQYP5muO4AXdMZH8kU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Json.wasm",
        "name": "Microsoft.Extensions.Configuration.Json.g7iqpxuoas.wasm",
        "hash": "sha256-VGQp7DI4J9LGZJu4FPLCcMBsjO0Ok8QOpx/ejAW5UTw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.pt8jzyf3zl.wasm",
        "hash": "sha256-bS78A9iabPICZ+qBJ9BtHe2V83XE4W7P5sMo/Y9PXMw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.50df5l6ut1.wasm",
        "hash": "sha256-lWjR2947abRgr2ujX8ED1jgCLYftZoPhsJFpgFeozaE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.wasm",
        "name": "Microsoft.Extensions.Diagnostics.8rrgx94tis.wasm",
        "hash": "sha256-fAobCQl6kIvt/tOZtM+voQjIC4VN8DUC1uLwGwJERw0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Diagnostics.Abstractions.wasm",
        "name": "Microsoft.Extensions.Diagnostics.Abstractions.un0vvhp4qn.wasm",
        "hash": "sha256-Ggg9V/ieJZQKYHiAF48oYaRJUtndfle+Y6EU/BKQMW4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Abstractions.wasm",
        "name": "Microsoft.Extensions.FileProviders.Abstractions.4rgixn4vhr.wasm",
        "hash": "sha256-sF19b8dX3yWwhYlp+wF61xbXT6Fed0GzYHO66SghXhs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileProviders.Physical.wasm",
        "name": "Microsoft.Extensions.FileProviders.Physical.fqyf2r1m4d.wasm",
        "hash": "sha256-l3vuh1Cp7/ky7zCdHKwz67LT32BHNjlOOKYvhQCkYwM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.FileSystemGlobbing.wasm",
        "name": "Microsoft.Extensions.FileSystemGlobbing.wqgakij3ly.wasm",
        "hash": "sha256-uIDCr1nyUsi4TyVpMkT9YX9v2SP9o9LtUWF0sG73yn8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Hosting.Abstractions.wasm",
        "name": "Microsoft.Extensions.Hosting.Abstractions.nprtm8dos6.wasm",
        "hash": "sha256-i/cbJoXIt+R/hdqhwSu8H8jPUpFty/R/l+Tk9DvDY6I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Http.wasm",
        "name": "Microsoft.Extensions.Http.wr9i64sff1.wasm",
        "hash": "sha256-BCgAFzLvxi77DFWmPmML2Ig/V46jg/wy9OyoSOWX6Vw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Localization.wasm",
        "name": "Microsoft.Extensions.Localization.10l7z3p8mz.wasm",
        "hash": "sha256-EeWiaAfm9vQx09EHJMo2iXjbPikZNnc6LHprK0UFHXY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Localization.Abstractions.wasm",
        "name": "Microsoft.Extensions.Localization.Abstractions.vphcrxwqey.wasm",
        "hash": "sha256-TXzJ8Bp7UN3ns6Kz8+Zep2YInEbs3AS/x4AjL2rk5dQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.wasm",
        "name": "Microsoft.Extensions.Logging.110t8iznb4.wasm",
        "hash": "sha256-m9pMKwz2EqD7MghXV1IifqL5B2D6X9K7yPTxWr/xKZ0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.wasm",
        "name": "Microsoft.Extensions.Logging.Abstractions.fx053lvd5i.wasm",
        "hash": "sha256-DeXmWIdJBPz/VvbIdqIFxDs+4kARuUyVuV0C3zgn0PM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.wasm",
        "name": "Microsoft.Extensions.Options.y8d2bg9egb.wasm",
        "hash": "sha256-kurwqt1gGmdq5AiWbMLQ8+cvJErlOfJEQ3JdmHbHPPc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.ConfigurationExtensions.wasm",
        "name": "Microsoft.Extensions.Options.ConfigurationExtensions.sj4vh1tcw0.wasm",
        "hash": "sha256-OLL7tRxlzbWUH07vS9BtPgXMn20nvvKrruVCvkC4LHI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Primitives.wasm",
        "name": "Microsoft.Extensions.Primitives.p97bsc9w07.wasm",
        "hash": "sha256-jdXQzOtzZU4IM3wWyQUu5MDUpBixLPoIWn4eRT/NpkE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Validation.wasm",
        "name": "Microsoft.Extensions.Validation.s9uws8ubz2.wasm",
        "hash": "sha256-QL0VVc1QNb9w2TW8hgjJ7fz6xIDOYHb325mkHrrn0hY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.wasm",
        "name": "Microsoft.JSInterop.gz1u6cmwu6.wasm",
        "hash": "sha256-dMTnnVj+THPGxhfXCe6UBxsfxRQsjbmgg1ZJi/JY25I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.WebAssembly.wasm",
        "name": "Microsoft.JSInterop.WebAssembly.1hwjckyk8l.wasm",
        "hash": "sha256-JadPv43A5rpxQnIlci8ckDUHDtu0m+mTcO2qcPPU/lY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reactive.wasm",
        "name": "System.Reactive.uf3cxq9a4s.wasm",
        "hash": "sha256-lurqzInE6vTnJTNO3+E8MzBx0+2iqgFpuY/9QtyOE44=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CSharp.wasm",
        "name": "Microsoft.CSharp.1bg7w2d9dw.wasm",
        "hash": "sha256-TcaPm380tAcNo4snoFvE7Dytk0D7ivgADp0XBTW4xBo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.VisualBasic.Core.wasm",
        "name": "Microsoft.VisualBasic.Core.043p7svcwm.wasm",
        "hash": "sha256-ACNllL3Tcgp9gRryHMtQyD9U1j8+Nwg+iAf9UIVrN2A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.VisualBasic.wasm",
        "name": "Microsoft.VisualBasic.0yc3hrysp5.wasm",
        "hash": "sha256-SIGRwc2liBxhKoh/rglbkjg74NBcNKlSAAJnq5raxVo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Win32.Primitives.wasm",
        "name": "Microsoft.Win32.Primitives.yr6op72bx6.wasm",
        "hash": "sha256-Tk2gfhGjJsgJjBsucuGiH8bf6yL3cucXkFn9TWce5+U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Win32.Registry.wasm",
        "name": "Microsoft.Win32.Registry.5j93f8ypbu.wasm",
        "hash": "sha256-/70gOXt2nGbC1OgwN1rAMrwNRTlSEbRPFKM37VF/qpM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.AppContext.wasm",
        "name": "System.AppContext.2zaa5sq23c.wasm",
        "hash": "sha256-8nQ3K31xVkD6C9jKyH7e/046AVIC49sB6vqJ0Wdpg8o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Buffers.wasm",
        "name": "System.Buffers.z8cao1rrbm.wasm",
        "hash": "sha256-fXfMuFCwWrb8bZ/nmUf9ArZj24WUz+g/OLFp9GRGQCs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Concurrent.wasm",
        "name": "System.Collections.Concurrent.xvduxagefz.wasm",
        "hash": "sha256-M7WOoSrdPdeUvl8agb6I6uvdoCV6Py59qWTnz90nJVU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Immutable.wasm",
        "name": "System.Collections.Immutable.4k6aqtii9e.wasm",
        "hash": "sha256-tM1WW6Bq36oZwBCQxvyLKtUCitXKgQauQ4jwilkvlvc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.NonGeneric.wasm",
        "name": "System.Collections.NonGeneric.t7s8rrwojx.wasm",
        "hash": "sha256-J3hnUJdt7eKtf/HkhSdKXwos9drLGl4kevh6JXYhF6c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Specialized.wasm",
        "name": "System.Collections.Specialized.ggw4fght52.wasm",
        "hash": "sha256-UHwINxfG/ZUFwYsiyaYSEUIBoCjkyWs7MKCC/ivY8qE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.wasm",
        "name": "System.Collections.z73yoxweew.wasm",
        "hash": "sha256-Mf9pEYIo9b3iRPiwfA3qEl1BxHofURgkxi7/pOQiE2M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Annotations.wasm",
        "name": "System.ComponentModel.Annotations.o07e6yhbdr.wasm",
        "hash": "sha256-CHkD6xjj7Lwvh7DIjab6X/XIS6DdKUliEknBpeq2nBM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.DataAnnotations.wasm",
        "name": "System.ComponentModel.DataAnnotations.31v0bsh6cf.wasm",
        "hash": "sha256-6fftQsZw5NS1p9KiZ7s9wZaYmeMUbqjaa11J0dbKP5U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.EventBasedAsync.wasm",
        "name": "System.ComponentModel.EventBasedAsync.ovcrwchac0.wasm",
        "hash": "sha256-DCYOjuar7RHo2T8zy9C9P7x61fyhNGOjHGBkmC2yk4c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Primitives.wasm",
        "name": "System.ComponentModel.Primitives.q56655l791.wasm",
        "hash": "sha256-rs1GanFyiHQGVQ14TZ0nn2BqO88MXDmeCwEd+ZEaJMU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.TypeConverter.wasm",
        "name": "System.ComponentModel.TypeConverter.tj1xzuio7n.wasm",
        "hash": "sha256-GeH/7zT28lgoEhQZwMuS+ITu1vQcJm9554HiFQiSHeU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.wasm",
        "name": "System.ComponentModel.8aej33ecjk.wasm",
        "hash": "sha256-EH4b56CnoOYQk/O8ISq95uRbzI2o6+6cMXVLTJxGFzM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Configuration.wasm",
        "name": "System.Configuration.zm9ue8q9e5.wasm",
        "hash": "sha256-taWkDFbdvQGT5Y5vb36cpa8IsPm4OE32oCve+RDDzMU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Console.wasm",
        "name": "System.Console.j5iwgqwcvp.wasm",
        "hash": "sha256-GSTK1G9Kt9TKwZ23bReGIXD7RfDPdNeAskLzQEc7Ykg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Core.wasm",
        "name": "System.Core.5d5rf7piq6.wasm",
        "hash": "sha256-F7HmYD9BeO2JzpEpYZxXqbkK2WlpKIzsiWSEPnPPUGc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.Common.wasm",
        "name": "System.Data.Common.9byx7s6g3y.wasm",
        "hash": "sha256-Cx2xk8IyjRv7LFFuLq2nVVznW8h2bGsT0LBe2KW4fdQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.DataSetExtensions.wasm",
        "name": "System.Data.DataSetExtensions.ffo7e05ivk.wasm",
        "hash": "sha256-leoYbO9G/MKlCz/AhTb9KmapZqs0vK6seCRvdh56r24=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.wasm",
        "name": "System.Data.mdblbxa4yf.wasm",
        "hash": "sha256-2tsVweg3kBQDOj6Cyr/Suk6QNKr0yXTNBcQlE6avq0E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Contracts.wasm",
        "name": "System.Diagnostics.Contracts.fcx0bf2q5s.wasm",
        "hash": "sha256-z89P2NHlhxtiYrrLR1ViomoUMYqVmOEjpGaDt8xkiTg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Debug.wasm",
        "name": "System.Diagnostics.Debug.bhicfldu5a.wasm",
        "hash": "sha256-ceRK5z1IjN7EZCJAP3w0xn7qgubuN4B93MU4jcyu+T4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.DiagnosticSource.wasm",
        "name": "System.Diagnostics.DiagnosticSource.2m8fzodk4h.wasm",
        "hash": "sha256-pvOrovaZVoKRgJemM9wVDtEKYHlbVnSWtaBLOpkvvcM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.FileVersionInfo.wasm",
        "name": "System.Diagnostics.FileVersionInfo.f0cwqghn33.wasm",
        "hash": "sha256-z25CKpgEJGBYKeNIn0MOsKnRl/hCkwlmpCZ859GtzJ0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Process.wasm",
        "name": "System.Diagnostics.Process.dlmxijl4wr.wasm",
        "hash": "sha256-X0GPw9QR3GG3v67Eq8tBUeeXJhSbLavFpG5R2MJDzN4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.StackTrace.wasm",
        "name": "System.Diagnostics.StackTrace.r1f1a256en.wasm",
        "hash": "sha256-b2SRB8jS0llleFkdRAuQ6MORUAKhpZypTtwS1VOqsOs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TextWriterTraceListener.wasm",
        "name": "System.Diagnostics.TextWriterTraceListener.k1s59zhjqf.wasm",
        "hash": "sha256-yP2r+1gIB7josOb0vMWnQdhcRkGVrZokFQfcRgRfuDs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Tools.wasm",
        "name": "System.Diagnostics.Tools.wlfayfrxl2.wasm",
        "hash": "sha256-fKQnq4MDuWizKInsdFe1q0qiRnALmZhfsS4fuTcLkNw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TraceSource.wasm",
        "name": "System.Diagnostics.TraceSource.yoj8ei52pp.wasm",
        "hash": "sha256-sjuRjlZEU6FL37pBS/tQlXbEy6vrXmyx3pkScMFIaQQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Tracing.wasm",
        "name": "System.Diagnostics.Tracing.kmcegbb8lk.wasm",
        "hash": "sha256-bANGnpSCasstyOhlUv/lOtfQUvTDsXhAEYCFfRA/hSw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.Primitives.wasm",
        "name": "System.Drawing.Primitives.qqfqpv662b.wasm",
        "hash": "sha256-Mkcb7NbfVC1FO6WWtGCyJujw/UkWnmJS1PQO3OOWli0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.wasm",
        "name": "System.Drawing.hh6koex0cs.wasm",
        "hash": "sha256-1X23T23M7b8sVSCQhjDcUWoYpXB7AM5Kza6pO8dJFqo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Dynamic.Runtime.wasm",
        "name": "System.Dynamic.Runtime.6ist1s7yrn.wasm",
        "hash": "sha256-jrbN2ZJntEteaQSjOu/CD62BrSt6hbTXwVO6X8c6VbA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Formats.Asn1.wasm",
        "name": "System.Formats.Asn1.diuv2i259w.wasm",
        "hash": "sha256-yykosJFzcK/BAskXZ8TymSwTr9aHeVElR62RobXlqWQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Formats.Tar.wasm",
        "name": "System.Formats.Tar.b4xfai9lye.wasm",
        "hash": "sha256-lQgIeLeJxA+wWZFsOonG9f6/9dXUiBaVYz4/b+1Na+g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.Calendars.wasm",
        "name": "System.Globalization.Calendars.vu1ieitqaw.wasm",
        "hash": "sha256-GYCb1vrgYcHrcmNEV8YsuqhmgOyLAUjlReh9AhelkvM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.Extensions.wasm",
        "name": "System.Globalization.Extensions.ez09sq74m8.wasm",
        "hash": "sha256-xt4OPVlFdurU3zTrL1IC4ha7k0qv+KveQ1BTyRk0RqE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.wasm",
        "name": "System.Globalization.sjkn7tuqoq.wasm",
        "hash": "sha256-yCKvEcm6wLF/LW+UwE5lfbO/3nJf22UIj48VBjEJieQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.Brotli.wasm",
        "name": "System.IO.Compression.Brotli.xuahgzmks8.wasm",
        "hash": "sha256-x9KQuG3iSv/iJ3CPSGgdsyttxfcd0SlaFp8unLXyqak=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.FileSystem.wasm",
        "name": "System.IO.Compression.FileSystem.n80i5gbu0l.wasm",
        "hash": "sha256-t2YsjYaAGEhZA6IMyjOswNHEdmDihF49O6ICalxgCL0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.ZipFile.wasm",
        "name": "System.IO.Compression.ZipFile.dtwdl4nx3g.wasm",
        "hash": "sha256-YVwCBc9IV89IOC77KWMcSTKb+amByu+/krtULy6bt44=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.Zstandard.wasm",
        "name": "System.IO.Compression.Zstandard.ub3grlm85t.wasm",
        "hash": "sha256-2kOF9DkenDFaNv6ki6E/HAF2QV4grSSdrdp+ZVpBIyw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.wasm",
        "name": "System.IO.Compression.mfl5rpbpfe.wasm",
        "hash": "sha256-PhVt54aF7ImnhD+atmQej2zCwvYXISCz+oRICEq6A/Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.AccessControl.wasm",
        "name": "System.IO.FileSystem.AccessControl.c9r5h6j1n3.wasm",
        "hash": "sha256-QBL3sIEE8upHkZ89TgHrECRQohS7QoZiYC4ThfccTtM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.DriveInfo.wasm",
        "name": "System.IO.FileSystem.DriveInfo.7qb7lggsza.wasm",
        "hash": "sha256-H6yUJCs4bDFvrpZO3rlTsSOhffe5V8/GKmo7w8fbYCw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.Primitives.wasm",
        "name": "System.IO.FileSystem.Primitives.6ghecvjjbr.wasm",
        "hash": "sha256-KlikUvm/RuGi1L4zdcVi7KJu+wTAXjtY3I1qKDHHjTs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.Watcher.wasm",
        "name": "System.IO.FileSystem.Watcher.ebgn5uaaz6.wasm",
        "hash": "sha256-Wi+ALK/EHJZrP502eImQbw53Rc9R726m7tGo2kNe4yQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.FileSystem.wasm",
        "name": "System.IO.FileSystem.lkqzuj3xzh.wasm",
        "hash": "sha256-uxTxKKDQTKfn7lkt+gJUJ4qQBimYHlHhgTlAZD/PM58=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.IsolatedStorage.wasm",
        "name": "System.IO.IsolatedStorage.dmh2541vhw.wasm",
        "hash": "sha256-S7VJaqDsnnfyj1H4yTmKkQqxdYMvEU/TCkQvD/80D9k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.MemoryMappedFiles.wasm",
        "name": "System.IO.MemoryMappedFiles.isvvr2coor.wasm",
        "hash": "sha256-Tkoh8he4MlCbFaMT5x6yD0II2r77iaG85dvt4vjaiqM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipelines.wasm",
        "name": "System.IO.Pipelines.ksm2jkvshf.wasm",
        "hash": "sha256-HG0TwxV7d2TO2kM7vlKU9edsFCw21mYaleyhQrInejU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipes.AccessControl.wasm",
        "name": "System.IO.Pipes.AccessControl.eao7bnq79j.wasm",
        "hash": "sha256-tn0EYwa11ccfL6J4JG6nO1LxXjBDBtM7jO3blY4jlI8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipes.wasm",
        "name": "System.IO.Pipes.rruptank8v.wasm",
        "hash": "sha256-B30fKVf7++1647kpub+kYTN7oL0j6NLWhX0h7t+x/rU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.UnmanagedMemoryStream.wasm",
        "name": "System.IO.UnmanagedMemoryStream.nlzq1n3jhp.wasm",
        "hash": "sha256-u4MiO4NIYQg/TtF7GaUkBKs/Fo0UVyjVXSDsZezK7Dc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.wasm",
        "name": "System.IO.wzv92t60cb.wasm",
        "hash": "sha256-xL+e0XHO3RD5N7mVQGZ8dlYvTAiSx/sfzYqgX8X57xQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.AsyncEnumerable.wasm",
        "name": "System.Linq.AsyncEnumerable.ags8xwvc1g.wasm",
        "hash": "sha256-9oxIfT0oYwiaWqjr4AHc97y6PcfRGo70ohI2oP/EPn0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Expressions.wasm",
        "name": "System.Linq.Expressions.4524vunkgr.wasm",
        "hash": "sha256-KPV/01pdoyin8pNFBbUjTJ2IV8kqM6kZlY/O/v030qs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Parallel.wasm",
        "name": "System.Linq.Parallel.bz1q5mueuq.wasm",
        "hash": "sha256-hyl+xoHeet1rNzgHev8+7fhKN3wEUuDn3e3mEtCCx50=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Queryable.wasm",
        "name": "System.Linq.Queryable.dyoikiql1s.wasm",
        "hash": "sha256-1UqBCTTWMrNxv/f0EBhGx2BO3qvTk9OSHP8NPfF/SIg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.wasm",
        "name": "System.Linq.5pxgucwlsn.wasm",
        "hash": "sha256-ZyPe/Vwa/fXnOFzfSYuYrUufOY2G0Sede40YgvFk9VU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Memory.wasm",
        "name": "System.Memory.4xiceo27cw.wasm",
        "hash": "sha256-OAdzYmgQC6LTTYdQludtKDmNysbsM2dd603kYqG7Az0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.Json.wasm",
        "name": "System.Net.Http.Json.ycimk065ue.wasm",
        "hash": "sha256-cjoY9UsAst5gD4yTlytPiSdaQLDAjVhvEn6oy55UG4A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.wasm",
        "name": "System.Net.Http.dnbmfij74y.wasm",
        "hash": "sha256-ecs9DWB9oEwZ9s3Vnjud5wjloigsg8/aOwCub57Xd9I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.HttpListener.wasm",
        "name": "System.Net.HttpListener.xyc689lou1.wasm",
        "hash": "sha256-11zqmmbX+vOG/sFuPKFr2wt2gX3Gs9wzb1hzryjaMC8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Mail.wasm",
        "name": "System.Net.Mail.jc7nyft88h.wasm",
        "hash": "sha256-Da1FtECXGnLjyuXdfR1FzIqyz7RCnTCD6CJVamJpFt0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.NameResolution.wasm",
        "name": "System.Net.NameResolution.oistjqmqa2.wasm",
        "hash": "sha256-oLBwhYiQPdohEv0/e+c8bfQIqSTRgAXKAKYlls8O4CM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.NetworkInformation.wasm",
        "name": "System.Net.NetworkInformation.e2jo99sw1m.wasm",
        "hash": "sha256-elzhEyQw+MCIhthgIJowXwn+x9IHvLB8VFOhUf+MNWU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Ping.wasm",
        "name": "System.Net.Ping.n956d95n0v.wasm",
        "hash": "sha256-K2HwdyLivIFp7+lbA8z/ut6O74N1IxBgHaBWO2kCPHo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Primitives.wasm",
        "name": "System.Net.Primitives.qwmn6y9ic6.wasm",
        "hash": "sha256-unGwBUYOiOR5OflSEDxzzKu1GM2r41fAVxrXi56iQSU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Quic.wasm",
        "name": "System.Net.Quic.mr94v50sgh.wasm",
        "hash": "sha256-jkIKN+7cKOrJYckvMynmqu3Gb/1C/+n5c8fNSNwWDMs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Requests.wasm",
        "name": "System.Net.Requests.s4zh93rtre.wasm",
        "hash": "sha256-HFG6bWhzJjUK5GtANU20RZg1ybmimGTnSz/Q9XdC45M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Security.wasm",
        "name": "System.Net.Security.ziukxt9409.wasm",
        "hash": "sha256-dUM61YUcPz+a9nWTGbeWmEfOerojA50Lu7wn+a6wwBQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.ServerSentEvents.wasm",
        "name": "System.Net.ServerSentEvents.1aqx3km1l7.wasm",
        "hash": "sha256-SVY00DAxwD4y5lU13hE/hAahL7/I1V5t5l55DO+HPhU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.ServicePoint.wasm",
        "name": "System.Net.ServicePoint.9foxka36pd.wasm",
        "hash": "sha256-5aWC3Ig0UvZmgBAJymeJH/HF87wkRSoMcviEEm4Bv9M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Sockets.wasm",
        "name": "System.Net.Sockets.iiwmz9xhwz.wasm",
        "hash": "sha256-5ppPmyWn0bbP0+BYKCZCX/Y10eO4+H3oirTYr9AvXuw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebClient.wasm",
        "name": "System.Net.WebClient.n5y2hazk8s.wasm",
        "hash": "sha256-a2Kkt3/v4cJ7YM3UbRJXjLEZakqa+sAUlRrWjcW7JPE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebHeaderCollection.wasm",
        "name": "System.Net.WebHeaderCollection.negef7qfpv.wasm",
        "hash": "sha256-j5Wndy2TU9keCXsitJ/9LA82CBrOGlHMuLeKrnqRy0s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebProxy.wasm",
        "name": "System.Net.WebProxy.z7qoywwcsx.wasm",
        "hash": "sha256-v3yK8sBnxYQ5XF4Hsk+3Nx5KewCru+O0EPseQXzMnio=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.Client.wasm",
        "name": "System.Net.WebSockets.Client.0yck5i7r54.wasm",
        "hash": "sha256-eKRCXO6BgwH7HMj4r5WeJt1pFALAs03wl3/xCIB1zn0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebSockets.wasm",
        "name": "System.Net.WebSockets.as99nux3qs.wasm",
        "hash": "sha256-NucWiOgy2tnoT0oRvpSz7UMj3EGzi5E6K8HwmcNe07U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.wasm",
        "name": "System.Net.fr0brx0wyf.wasm",
        "hash": "sha256-ZQg/iUwhjmfWyeGzweCkVAXkmIabXX71tLkKnpfPlYw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Numerics.Vectors.wasm",
        "name": "System.Numerics.Vectors.xbfwx8dpak.wasm",
        "hash": "sha256-nQY8gGbIUAgM2UOJZ7qQ6rzjYX2au+YqecYPSjRb/Yo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Numerics.wasm",
        "name": "System.Numerics.i4i1edba32.wasm",
        "hash": "sha256-/pu++O+rcAzwnHztirQwlaVStGo8upuwnJV3wXIYUCg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ObjectModel.wasm",
        "name": "System.ObjectModel.8yuq10hpw7.wasm",
        "hash": "sha256-0O/SJT8rRAa+62la1e5cQAi0k2vymHDLFmjC1QqNrkw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.DataContractSerialization.wasm",
        "name": "System.Private.DataContractSerialization.kztqn9inbn.wasm",
        "hash": "sha256-sMqx9YDGYVDfHktDMlncxWHgII0iVRP4ANioi/Unww4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Uri.wasm",
        "name": "System.Private.Uri.6pinntr32c.wasm",
        "hash": "sha256-ajkW03N7d2hJTCdRFo8bm/jH4qnh3ThPApbZYbJVpCk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.Linq.wasm",
        "name": "System.Private.Xml.Linq.n3gehewxau.wasm",
        "hash": "sha256-AzIN5hCiCOBb3Bffd1nrQ8P1uUSZtLonz2mYB17oCME=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.wasm",
        "name": "System.Private.Xml.24jc1mveom.wasm",
        "hash": "sha256-whRHzyLwYyIPfgOAKMHnp/YHCZhdMue2a5TvnUz4ynw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.DispatchProxy.wasm",
        "name": "System.Reflection.DispatchProxy.3vj5936sur.wasm",
        "hash": "sha256-MRfSy8gMKODqQr4YJbikniKXY1d8RoCIihHbkxxcN2I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.ILGeneration.wasm",
        "name": "System.Reflection.Emit.ILGeneration.ryj35la1pi.wasm",
        "hash": "sha256-0wAoFOj+rywUv7Hvz4NdKRP3lySM71aW652uBWBmb+E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.Lightweight.wasm",
        "name": "System.Reflection.Emit.Lightweight.9v73wsptc5.wasm",
        "hash": "sha256-a9VJfrzBcimP725Hkq+0TYiyW8EfXxKwnUX8JnYZC04=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Emit.wasm",
        "name": "System.Reflection.Emit.pje4ilifoc.wasm",
        "hash": "sha256-WzfD1iEVhKKW10jpQ4ws/dRyPa9MqlgpfgWzqbQUIco=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Extensions.wasm",
        "name": "System.Reflection.Extensions.yvi8rc56z0.wasm",
        "hash": "sha256-YnNyCQYe6u+yob9dCwN/gl7O0yPH4aBbHZ8+qFSaxk8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Metadata.wasm",
        "name": "System.Reflection.Metadata.y85kytl22w.wasm",
        "hash": "sha256-buKaGTtepQ6Gx8SK+6GOlSkRbalopBVc1+CcK/V2aiU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Primitives.wasm",
        "name": "System.Reflection.Primitives.n236t73qln.wasm",
        "hash": "sha256-8UFpU2ltE6n21xSHnx3iXR+QdZJg3hrQeotmJ/vkQHE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.TypeExtensions.wasm",
        "name": "System.Reflection.TypeExtensions.mi62fopoe5.wasm",
        "hash": "sha256-ghMel8H7KBr5XRbqqfSYAIm4vYdVAKM8WZqWfE9JKlY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.wasm",
        "name": "System.Reflection.usqkn7avw9.wasm",
        "hash": "sha256-rhe7IMSUffJnwynBce1khCqcFYd0cvKSRyKiaj8VmNI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.Reader.wasm",
        "name": "System.Resources.Reader.dmk1iev6ti.wasm",
        "hash": "sha256-Wyd/dA13sffZ0bk9D8eIjpZrUUmNIFq65wYochqLujo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.ResourceManager.wasm",
        "name": "System.Resources.ResourceManager.ngf0wifpw0.wasm",
        "hash": "sha256-RyYaUZUrqnYv6vXQZ9EMUS54MoejVO769Yf4PE4pujU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Resources.Writer.wasm",
        "name": "System.Resources.Writer.nfsgnlzp0p.wasm",
        "hash": "sha256-DbH/OH93NOrT34XUm0gYzd0zyh/grQNnTXbc+BOWo7g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.Unsafe.wasm",
        "name": "System.Runtime.CompilerServices.Unsafe.90mu9nqhvi.wasm",
        "hash": "sha256-6Q+y7O9sZgAjzHm+NlfKC705FjndP1QA3LFSqmgY0zc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.CompilerServices.VisualC.wasm",
        "name": "System.Runtime.CompilerServices.VisualC.uh2p56jai5.wasm",
        "hash": "sha256-4oW054NBn78ETMY46/PzzFeirVQKYW4rbx5xmsHN0GQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Extensions.wasm",
        "name": "System.Runtime.Extensions.r7m3u73d7u.wasm",
        "hash": "sha256-N10DauQvWWQID449cG1cEL1jleFi0zbIptn0zdmNYdo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Handles.wasm",
        "name": "System.Runtime.Handles.i0y71jslos.wasm",
        "hash": "sha256-8nSyMJtPcrIzJJgQ5CYaL9jjVhg5TmXFrtydxmTW2hc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.RuntimeInformation.wasm",
        "name": "System.Runtime.InteropServices.RuntimeInformation.9ejh66rob7.wasm",
        "hash": "sha256-jzWWVIlXpDb4NoWPb2tFvaDT6E5jgW69cVXYevbbFTc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.wasm",
        "name": "System.Runtime.InteropServices.bf87de9s38.wasm",
        "hash": "sha256-mSSvOWDAeyjPig0UdB7xvZ8/LdxxsYmtGPk0jkedS+g=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Intrinsics.wasm",
        "name": "System.Runtime.Intrinsics.7qzpno26hp.wasm",
        "hash": "sha256-4QeIEYQ/0irLtNF5VC45myrqGDfy/ynPrBbCJQaWKZ4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Loader.wasm",
        "name": "System.Runtime.Loader.zl7l2ql02v.wasm",
        "hash": "sha256-OayO/ZykcHyy3XpYnm4Def9hhrtKkFdeo0RYZ6HGUAU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Numerics.wasm",
        "name": "System.Runtime.Numerics.9mvs00zphr.wasm",
        "hash": "sha256-7wBr84pTOuWqwr7Y0y1clS6HBCBscaQOLf1bAIRvbHM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Formatters.wasm",
        "name": "System.Runtime.Serialization.Formatters.945504cll1.wasm",
        "hash": "sha256-18Z4H6S8ee2t4cPSjlBR0NzvErkqZGlVGLX6Fkpq0VM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Json.wasm",
        "name": "System.Runtime.Serialization.Json.j2njsqn0fu.wasm",
        "hash": "sha256-i69xflN3jGwJ7hsoSv+tGnyFuctOyBJvLm0uYvsencc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Primitives.wasm",
        "name": "System.Runtime.Serialization.Primitives.qhv1e0afoo.wasm",
        "hash": "sha256-roMcTWUi3WxnFGjPmwrZrXE9SZMuhOSo56pWaXBOQMU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Xml.wasm",
        "name": "System.Runtime.Serialization.Xml.bxh64wlacv.wasm",
        "hash": "sha256-P3RC891feY90C8E+MpP0bGvC4K8E+e+3P1fKiDJHT/I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.wasm",
        "name": "System.Runtime.Serialization.w8treoz8y9.wasm",
        "hash": "sha256-MNVO93oTHkus3vhOpApDyIi9UBI5mkfnyQ0tZgDegWY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.wasm",
        "name": "System.Runtime.1kbafdqrz1.wasm",
        "hash": "sha256-/4MeN0B72OHU/FcPlpql3+aIH78INCnajYZM2d6u/18=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.AccessControl.wasm",
        "name": "System.Security.AccessControl.0ruthgrzgm.wasm",
        "hash": "sha256-7KEESNo53b0M958AJc1wLAIQOo32Id+vALxlmueVerg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Claims.wasm",
        "name": "System.Security.Claims.mjve9ykfvr.wasm",
        "hash": "sha256-MgjJ9TTudZkL0wtkDZRfQpZf4GtvKDifB/nhZJ0EiRY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Algorithms.wasm",
        "name": "System.Security.Cryptography.Algorithms.xz691to12s.wasm",
        "hash": "sha256-rYCe02Tg2aUxFmNP+Wman87JhsAOappapycuzlzn8Jk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Cng.wasm",
        "name": "System.Security.Cryptography.Cng.a7meuyadiz.wasm",
        "hash": "sha256-GhLtHnJPfluerUAl+oGNRLf8f75cA9hxiJ/+/XO3CE8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Csp.wasm",
        "name": "System.Security.Cryptography.Csp.t8t1r0hpce.wasm",
        "hash": "sha256-s2rSl+Lk6q7DzPfZL7zzGW2d/4g1P0woygu6qZprcjA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Encoding.wasm",
        "name": "System.Security.Cryptography.Encoding.t16jf2jz51.wasm",
        "hash": "sha256-YUytNIJQBV0HxJwbB9npHytJN3cdmgmKbOex0DAvcnI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.OpenSsl.wasm",
        "name": "System.Security.Cryptography.OpenSsl.qfl0m20yol.wasm",
        "hash": "sha256-evXFXueXTxLO7YB3XpoQ38DfWwIJai+aZR3ctlohweA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.Primitives.wasm",
        "name": "System.Security.Cryptography.Primitives.mgl9e6tw5k.wasm",
        "hash": "sha256-5kovmX6RRKktteEEZoy1B41ckTayFH+YjgMQxPC+2EM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.X509Certificates.wasm",
        "name": "System.Security.Cryptography.X509Certificates.yh26tj3h2l.wasm",
        "hash": "sha256-Jiur3SpPs1YPAPMU0zfya/aeaAxoT9BkAqUQSGv6veg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.wasm",
        "name": "System.Security.Cryptography.hox795pdqm.wasm",
        "hash": "sha256-v6zKBsm5YdnknU3rGeARB2EUTEgF5Hx53L1sMh5PU4E=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Principal.Windows.wasm",
        "name": "System.Security.Principal.Windows.hixi4845us.wasm",
        "hash": "sha256-KZ4aGtN+nVsn2tX2BqpD513bEhAr2sOUvygJAbnsaCQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Principal.wasm",
        "name": "System.Security.Principal.l2dkjkc9tk.wasm",
        "hash": "sha256-072jCCDecc6WP0LFAKzcvKPhgc/jEsLUAgdgxKHNdME=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.SecureString.wasm",
        "name": "System.Security.SecureString.3gnortth5a.wasm",
        "hash": "sha256-syvu334IqSZTxGJPbUEqNLiBcwX1A2ctc8RztCGtamI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.wasm",
        "name": "System.Security.lgvtr7vqi5.wasm",
        "hash": "sha256-hSsPH5o5bNxAq0S9w3Cg9B9QRhzqL/KojODVJakwm8M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ServiceModel.Web.wasm",
        "name": "System.ServiceModel.Web.x7rtwdpho2.wasm",
        "hash": "sha256-DXOuH4Tcqf1UArv1Gn1rSv+ylDCTy3kfis8jS52Nk1s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ServiceProcess.wasm",
        "name": "System.ServiceProcess.ozri6ntlsy.wasm",
        "hash": "sha256-NPAfEIeT2ap41JM7kebTxgFamqEIXmB99gpYiuxKtPA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.CodePages.wasm",
        "name": "System.Text.Encoding.CodePages.0ehippl3my.wasm",
        "hash": "sha256-iPV8V3NKug87+MFsFwX+KuSrG34cjHsFu0GuHlctDKQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.Extensions.wasm",
        "name": "System.Text.Encoding.Extensions.fzijevkcib.wasm",
        "hash": "sha256-29CU/wPs/t5OyNpbrQv9CtnPXqlPE4G+j+gitndYw8A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.wasm",
        "name": "System.Text.Encoding.unaecgyhvy.wasm",
        "hash": "sha256-hqYO3jgUL2nFw5MNOb9nYwBs3jWssLM6bTx22pfLJuA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encodings.Web.wasm",
        "name": "System.Text.Encodings.Web.c7arfut36f.wasm",
        "hash": "sha256-aKMEO0JKtLN9WxVYbwH+7TUgeMi8ZZpceiSJr9ZSI5w=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Json.wasm",
        "name": "System.Text.Json.yszynahwbs.wasm",
        "hash": "sha256-Pid8F5AQc7n5z2+K3ii+RyiLrhZ1JQFvFjV0VKy0a5U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.RegularExpressions.wasm",
        "name": "System.Text.RegularExpressions.da0owmzpam.wasm",
        "hash": "sha256-db8UDau1n4I5JvqaRiWq1R3bZD1kPKaZvUjKAmw5aEQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.AccessControl.wasm",
        "name": "System.Threading.AccessControl.a9wqvr5ov6.wasm",
        "hash": "sha256-Mr+ah3ZuIaX0H3rfY1pElirM8+108bMM5gBgfCSjeQY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Channels.wasm",
        "name": "System.Threading.Channels.c36vdaxw32.wasm",
        "hash": "sha256-mNXRT+DWYDoJEI36IuYy7zKbY6Af3O5L+zlC1j5mvY0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Overlapped.wasm",
        "name": "System.Threading.Overlapped.awq6ebjtxr.wasm",
        "hash": "sha256-qhc5QOUMjUoy2QB8II/Ok9UwI9v7owR+iCr9e4q+qpo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Dataflow.wasm",
        "name": "System.Threading.Tasks.Dataflow.kg7yrm4yzx.wasm",
        "hash": "sha256-RC1ugu1eCfxH/FlA1IogX3QIF3G5uYUShCfWxBt2Gg4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Extensions.wasm",
        "name": "System.Threading.Tasks.Extensions.mm7ycqun0j.wasm",
        "hash": "sha256-4tCnyjTr8VPpPLxuOOCXdtwWj13MofJVWQ3p3nOjR10=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Parallel.wasm",
        "name": "System.Threading.Tasks.Parallel.zaz7968xuc.wasm",
        "hash": "sha256-hRBnsKwyFxyKESbCb1pZm2xJXAtQ+lcnfOe/MhaAhE4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.wasm",
        "name": "System.Threading.Tasks.g1j7jwfqvg.wasm",
        "hash": "sha256-JD9EWV6nuqc9CIgjQEfDXF+pK+ceyQmLF9N5osL8Tkw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Thread.wasm",
        "name": "System.Threading.Thread.9eltd2rtdq.wasm",
        "hash": "sha256-kXbQLeWxlucOrvipuCqknW4yD75ekgO9kvkfeQJ69LM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.ThreadPool.wasm",
        "name": "System.Threading.ThreadPool.gus01lmqfr.wasm",
        "hash": "sha256-+HgNchLmgD60qUo0YuGASvYdxMBYF+mYKgT+XEkfQ/8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Timer.wasm",
        "name": "System.Threading.Timer.t0wb1fer6u.wasm",
        "hash": "sha256-I6wsG7gWsTnfVRjk6r+2nwBO7YsGxdmc851IDnhkGsk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.wasm",
        "name": "System.Threading.uc6mjrumyw.wasm",
        "hash": "sha256-UpdqvYI9o/DTe3JwsDwj+vDzHzQ7eOtthCnEh5NTtXk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Transactions.Local.wasm",
        "name": "System.Transactions.Local.3sl6g08l8u.wasm",
        "hash": "sha256-w4Mi9nj8OFh+RqYsMugTSN6EgYNdYJJQYiLPoF9Qegg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Transactions.wasm",
        "name": "System.Transactions.ahedn35lo8.wasm",
        "hash": "sha256-coJaGO6DoOu9jbTxpenesVcJPtHaNkp5xM5RhjQ4zpA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ValueTuple.wasm",
        "name": "System.ValueTuple.m7kz7x4fpa.wasm",
        "hash": "sha256-7iNhFXR1R43Qn88l9chDFKjJ6meYAMPEXqVPu60IfW0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Web.HttpUtility.wasm",
        "name": "System.Web.HttpUtility.xrfcaqi9bx.wasm",
        "hash": "sha256-3SyM+ERZ9IF9B1j50Pgs3q9zr5/FGowxlF38y4EU8Pw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Web.wasm",
        "name": "System.Web.3lg4gqyfhr.wasm",
        "hash": "sha256-98Q0ATK1fb0Dx3G2ecvFUxc2DpPOne829Yyn8SeiEO0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Windows.wasm",
        "name": "System.Windows.j828fqhkm0.wasm",
        "hash": "sha256-rRvi+IC8Tj3jVBQ+huP8aYs2Cxc6nf8UlhJVqF652ns=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Linq.wasm",
        "name": "System.Xml.Linq.fhvi09k38y.wasm",
        "hash": "sha256-Hcw6RzOWOoLq1iFHhW4XunhMxJVOfArnhB5PrO4HElQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.ReaderWriter.wasm",
        "name": "System.Xml.ReaderWriter.txjo7co9in.wasm",
        "hash": "sha256-8VFsslxMvmJRhjxqKEMXTDVrO/RMc4mUWLd++SHXEaU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Serialization.wasm",
        "name": "System.Xml.Serialization.b0gckmqod5.wasm",
        "hash": "sha256-CyiCEhUkKTRnjJraXEGg3a1SHgUa9BaVC6Qq+Mk96ZU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XDocument.wasm",
        "name": "System.Xml.XDocument.gkolqs4wji.wasm",
        "hash": "sha256-YAYdIQbkmOGDttp7K1hThuB1+s4Z1MeuNidOx+Ra3e4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.XDocument.wasm",
        "name": "System.Xml.XPath.XDocument.udpa0qyk0n.wasm",
        "hash": "sha256-AmfVbWg3joJjJDj57N2c1KITTAvSQqo6RB+8OM77rSM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.wasm",
        "name": "System.Xml.XPath.y8vovza5xu.wasm",
        "hash": "sha256-Mn93WKYnDFVrSvM2eWsBvzM+tRUbFutvFCIyON/5+dk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XmlDocument.wasm",
        "name": "System.Xml.XmlDocument.3z3ihwh9hk.wasm",
        "hash": "sha256-YZoJzaTCMLvIZpwnx0eXZmOgbYPfX45MhJAK1rTiUk4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XmlSerializer.wasm",
        "name": "System.Xml.XmlSerializer.34ro8z8dsh.wasm",
        "hash": "sha256-vSyLMNOsrMi8VGmLz6rPQyOaNKETarPib6MQ+lNtSmE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.wasm",
        "name": "System.Xml.b580dj6iwt.wasm",
        "hash": "sha256-P2LWVd86BAhKQbvj1KAXewFpXbbd1EkMDK8N/V+EWv8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.wasm",
        "name": "System.u10zyadqw0.wasm",
        "hash": "sha256-AgXxqHB6fYd9hlU1ZfJQPrX9KD+fNwyXnQN5h16UJWI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "WindowsBase.wasm",
        "name": "WindowsBase.6u2bp05xrc.wasm",
        "hash": "sha256-Hiy1JVV70rVXluHOzOQsj2MrBIxEtRckKjRi2pAC6WA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "mscorlib.wasm",
        "name": "mscorlib.3z8ybzobjw.wasm",
        "hash": "sha256-7/hf9GP5FwgBAgCDPaz3ojkLGzAepjVpVTThtI5qLi8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "netstandard.wasm",
        "name": "netstandard.jyknzu5e4j.wasm",
        "hash": "sha256-JStcFvHrTnSfbVZdE2hbasXozFPGmp9HfVM0IBWWKmE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Application.wasm",
        "name": "PrTask.Application.efnu8lyev3.wasm",
        "hash": "sha256-Gu70+oy1v30CwMJhpWVSWY3FSnSOkXDAlSN3VvScAn4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Domain.wasm",
        "name": "PrTask.Domain.alwe29hk0c.wasm",
        "hash": "sha256-frJaC38NiRIkEnN5WHPQ9g5Ph9mQKb73GHR1aum0f24=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.SharedUI.wasm",
        "name": "PrTask.SharedUI.jyybptjevw.wasm",
        "hash": "sha256-RX0djghuyKWRzJ9EnVasJl3eIIITcNBCsgRvOd2jb/M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Client.wasm",
        "name": "PrTask.Client.mnywpwjbdb.wasm",
        "hash": "sha256-jl8vabgOQG/2IW4p8tAdMcuQvt1VDoPtdJ2MEJ8x4UE=",
        "cache": "force-cache"
      }
    ],
    "pdb": [
      {
        "virtualPath": "PrTask.Domain.pdb",
        "name": "PrTask.Domain.px8078gldf.pdb",
        "hash": "sha256-wwsiZo2rYVPVMR3l7EPe8TCtr/WQAS0OjchBNXFswI0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.SharedUI.pdb",
        "name": "PrTask.SharedUI.fl947le5v6.pdb",
        "hash": "sha256-bfvYrr7XkefPymC0xqC+41Mi0wjGk9ZwZhqKY7vdU3A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Application.pdb",
        "name": "PrTask.Application.rnmbt4yyym.pdb",
        "hash": "sha256-d7SY2SEoZkZQvfORmVEg9cuVnn1mHsTzEy5GnGty4fw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "PrTask.Client.pdb",
        "name": "PrTask.Client.ql1vynipeq.pdb",
        "hash": "sha256-ImhUt3+97hrTfKLMSc2XUOiSNRMEuKkOIgTgZ44tdu4=",
        "cache": "force-cache"
      }
    ],
    "satelliteResources": {
      "ar": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.bskdcfv3fy.wasm",
          "hash": "sha256-hX1uguz8tQmtbuJWwAYwGWHx5G5QE1L7wQmVkreth04=",
          "cache": "force-cache"
        }
      ],
      "de": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ix4luoon0p.wasm",
          "hash": "sha256-NopE5vGj/ypvx2ndJR2qTdLTHKMPcDdiIF4DhsaV+8E=",
          "cache": "force-cache"
        }
      ],
      "es": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.z36xt1r3we.wasm",
          "hash": "sha256-0RHdj9Qcn0/dZMJh0/QkSGqeO1C3jaHKd8dJO8cL27I=",
          "cache": "force-cache"
        }
      ],
      "fil": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.hdp4up1jct.wasm",
          "hash": "sha256-dQtsHG47aScf+ehbJisiA2Jgy3yw4zcMn8jkcV2MYKU=",
          "cache": "force-cache"
        }
      ],
      "fr": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ncehy2k7j4.wasm",
          "hash": "sha256-5wwtrnjMPdh8G78+emNMep1lGEBgvduESKKd/75MM+A=",
          "cache": "force-cache"
        }
      ],
      "hi": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.9tqdf949oq.wasm",
          "hash": "sha256-A4TJG9jx1NKFLmsqKNla6wjP2f8Vb0yCw3Hhj7KXLHM=",
          "cache": "force-cache"
        }
      ],
      "id": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ha03qatowz.wasm",
          "hash": "sha256-ObbdJRuzkyItpa9LKVA1X0B6Cyz7yrjhd0sv0FVsH88=",
          "cache": "force-cache"
        }
      ],
      "it": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.o2y55la0m8.wasm",
          "hash": "sha256-wHTASjrbDDVrLubn+mPSj7Fg9av3HIhDYZHGjdHaFy8=",
          "cache": "force-cache"
        }
      ],
      "ja": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.zech4u8dw4.wasm",
          "hash": "sha256-G9XzWrOsdmk6Ph5p+pSw6TOIKk98ftu7Xl6tcukSIeY=",
          "cache": "force-cache"
        }
      ],
      "ko": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ofvwd8ovyl.wasm",
          "hash": "sha256-JPRifvqqpIQTg2EROL+8pfFiY8ZnFXpxATXL+rYylGI=",
          "cache": "force-cache"
        }
      ],
      "nl": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.j3ed4rgyvw.wasm",
          "hash": "sha256-YScMNdV9ONfGqsKu9CGNCuKBVMX+cZwnY0wSc41hlPA=",
          "cache": "force-cache"
        }
      ],
      "pt": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.qwhuevycv8.wasm",
          "hash": "sha256-1n9vMKcrYb7oLKY1v2QbrqcL3BBcjmEhAAn15V0xSRQ=",
          "cache": "force-cache"
        }
      ],
      "ru": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.ipybz3p5yu.wasm",
          "hash": "sha256-irz851JN3b2NMF8z1omU7UnPg9c3cGsUJ+zrUVt488s=",
          "cache": "force-cache"
        }
      ],
      "tr": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.rgegpa190t.wasm",
          "hash": "sha256-xeG1NacKFECVj2WbOmEGsOJGSuv70GbQTTeLItzbM2Y=",
          "cache": "force-cache"
        }
      ],
      "zh": [
        {
          "virtualPath": "PrTask.SharedUI.resources.wasm",
          "name": "PrTask.SharedUI.resources.h8ljuruxdu.wasm",
          "hash": "sha256-v8OCytNCkaPlzz+zjeF4mUnB3rvh41VzaSrO7L4HFQk=",
          "cache": "force-cache"
        }
      ]
    }
  },
  "debugLevel": -1,
  "appsettings": [
    "../appsettings.json"
  ],
  "globalizationMode": "all",
  "extensions": {
    "blazor": {}
  },
  "runtimeConfig": {
    "runtimeOptions": {
      "configProperties": {
        "Microsoft.AspNetCore.Components.Routing.RegexConstraintSupport": false,
        "Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability": true,
        "System.ComponentModel.DefaultValueAttribute.IsSupported": false,
        "System.ComponentModel.Design.IDesignerHost.IsSupported": false,
        "System.ComponentModel.TypeConverter.EnableUnsafeBinaryFormatterInDesigntimeLicenseContextSerialization": false,
        "System.ComponentModel.TypeDescriptor.IsComObjectDescriptorSupported": false,
        "System.Data.DataSet.XmlSerializationIsSupported": false,
        "System.Diagnostics.Debugger.IsSupported": false,
        "System.Diagnostics.Metrics.Meter.IsSupported": false,
        "System.Diagnostics.Tracing.EventSource.IsSupported": false,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": false,
        "System.Net.Http.WasmEnableStreamingResponse": true,
        "System.Net.SocketsHttpHandler.Http3Support": false,
        "System.Reflection.Metadata.MetadataUpdater.IsSupported": false,
        "System.Resources.ResourceManager.AllowCustomResourceTypes": false,
        "System.Resources.UseSystemResourceKeys": true,
        "System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported": true,
        "System.Runtime.InteropServices.BuiltInComInterop.IsSupported": false,
        "System.Runtime.InteropServices.EnableConsumingManagedCodeFromNativeHosting": false,
        "System.Runtime.InteropServices.EnableCppCLIHostActivation": false,
        "System.Runtime.InteropServices.Marshalling.EnableGeneratedComInterfaceComImportInterop": false,
        "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false,
        "System.StartupHookProvider.IsSupported": false,
        "System.Text.Encoding.EnableUnsafeUTF7Encoding": false,
        "System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault": true,
        "System.Threading.Thread.EnableAutoreleasePool": false,
        "Microsoft.AspNetCore.Components.Endpoints.NavigationManager.DisableThrowNavigationException": false
      }
    }
  }
}/*json-end*/);export{mt as default,ut as dotnet,ft as exit};
