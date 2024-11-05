
# react-native-community-service-center

## Getting started

`$ npm install react-native-community-service-center --save`

### Mostly automatic installation

`$ react-native link react-native-community-service-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-community-service-center` and add `RNCommunityServiceCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCommunityServiceCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCommunityServiceCenterPackage;` to the imports at the top of the file
  - Add `new RNCommunityServiceCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-community-service-center'
  	project(':react-native-community-service-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-community-service-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-community-service-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCommunityServiceCenter.sln` in `node_modules/react-native-community-service-center/windows/RNCommunityServiceCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Community.Service.Center.RNCommunityServiceCenter;` to the usings at the top of the file
  - Add `new RNCommunityServiceCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCommunityServiceCenter from 'react-native-community-service-center';

// TODO: What to do with the module?
RNCommunityServiceCenter;
```
  