
# react-native-considerate-service-to-family

## Getting started

`$ npm install react-native-considerate-service-to-family --save`

### Mostly automatic installation

`$ react-native link react-native-considerate-service-to-family`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-considerate-service-to-family` and add `RNConsiderateServiceToFamily.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNConsiderateServiceToFamily.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNConsiderateServiceToFamilyPackage;` to the imports at the top of the file
  - Add `new RNConsiderateServiceToFamilyPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-considerate-service-to-family'
  	project(':react-native-considerate-service-to-family').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-considerate-service-to-family/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-considerate-service-to-family')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNConsiderateServiceToFamily.sln` in `node_modules/react-native-considerate-service-to-family/windows/RNConsiderateServiceToFamily.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Considerate.Service.To.Family.RNConsiderateServiceToFamily;` to the usings at the top of the file
  - Add `new RNConsiderateServiceToFamilyPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNConsiderateServiceToFamily from 'react-native-considerate-service-to-family';

// TODO: What to do with the module?
RNConsiderateServiceToFamily;
```
  