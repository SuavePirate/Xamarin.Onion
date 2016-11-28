# Xamarin Forms Onion Architecture Template #

This is a template and example of a scalable / plugable onion architecture for Xamarin Projects.

*Author*: Alex Dunn

*Last Edit*: 11/28/2016 - Alex Dunn

### Purpose ###

* Create new projects quickly
* Properly implement IoC and DI
* Allow for swapable dependencies
* Allow for maximum code reuse
* Allow for easy addition of new projects
* Allow for moving out of Xamarin.Forms to Xamarin Native and vice versa with no conflict

### Practices ###

* Inversion of Control (IoC)
* Dependency Injection (DI)
* Model View ViewModel (MVVM)
* Separation of Concerns (SoC)

### Libraries ###

* Xamarin
* Xamarin.Forms (optional)
* MVVM Light (can be switched with another MVVM + IoC Framework)
* SqlLite-net PCL (optional)
* PCL Storage (optional)
* Dependencies of above libraries

### Set up ###

* Install VS / XS
* Get the latest stable version of the Xamarin SDKs
* Restore Nuget Packages
* Update Android SDK to latest version
* Update XCode / iOS SDKs to the latest versions
* Build

### Next Steps / Goals ###

* Add more views / templates to showcase DI
* Update README's with more details
* Add more examples of edge cases or native services