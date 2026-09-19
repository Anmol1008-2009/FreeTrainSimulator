# FreeTrainSimulator Android proof of concept

This is intentionally a standalone Android host. It does not reference the existing FTS projects and does not include route loading, simulation, audio, touch controls, RailDriver, Windows Forms, WPF, or desktop tools.

## Target

- Target framework: `net10.0-android`
- Runtime identifier: `android-arm64`
- MonoGame package: `MonoGame.Framework.Android` 3.8.4

## Build

From the repository root:

```bash
dotnet build Source/Android/FreeTrainSimulator.Android/FreeTrainSimulator.Android.csproj -c Debug -f net10.0-android -r android-arm64
```

The expected output is a debug ARM64 APK under the project's `bin/Debug/net10.0-android/android-arm64/` directory.
