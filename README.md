## iOS

```bash
flutter create -i swift  --project-name uni_links_ios -t app --org wk .

flutter build ios
flutter emulators --launch apple_ios_simulator
flutter run

/usr/bin/xcrun simctl openurl booted  https://bd1c8cc6.ngrok.io/signin
```