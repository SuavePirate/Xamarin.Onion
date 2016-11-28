# Controls

This project contains custom Xamarin.Forms re-usable, non-data-tied controls. These controls can have custom renderers that map to native controls.

 This project should reference no other project as these controls should not be bound to specific data, but rather should be bindable to anything.

 Certain views may require custom models, and those models should also live within this project.

 Client projects should reference this project if they need to implement a custom renderer from this project.