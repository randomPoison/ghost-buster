# Ghost Buster

[![openupm](https://img.shields.io/npm/v/com.random-poison.ghost-buster?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.random-poison.ghost-buster/)

:ghost::gun: Remove references to Boo and UnityScript in generated `.csproj` files.

---

Has this ever happened to you? You're trying to use `List<T>` or another generic collection type from `System.Collections.Generic` and Visual Studio "helpfully" auto-completes to `Boo.Lang.List` instead!

![Accidentally inserting `using Boo.Lang` in a script.](images/using-boo-lang.gif)

Well never fear! ghost-buster is here to exorcize `Boo.Lang` and its undead friend `UnityScript`. Simply add ghost-buster to your project's packages and it will automatically strip references to `Boo.Lang` and `UnityScript` from the generated `.csproj` files, preventing Visual Studio from auto-completing references to `Boo.Lang`.

# Usage

ghost-buster is [available on OpenUPM](https://openupm.com/packages/com.random-poison.ghost-buster/). The recommended way to install this package is using the OpenUPM CLI tool:

```
openupm add com.random-poison.ghost-buster
```

No additional setup is needed once you add the package.
